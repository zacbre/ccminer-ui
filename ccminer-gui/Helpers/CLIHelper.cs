using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ccminer_gui
{
    public abstract class CLIHelper : IDisposable
    {
        public event DataReceivedEventHandler OutputDataReceived;
        public event DataReceivedEventHandler ErrorDataReceived;

        private Process process;

        public virtual int Open(string path, string[] args = null)
        {
            if (File.Exists(path) && Closed)
            {
                process = new Process();
                ProcessStartInfo psi = new ProcessStartInfo(path)
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = String.Join(" ", args),
                    WorkingDirectory = Path.GetDirectoryName(path),
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                };

                process.EnableRaisingEvents = true;
                if (psi.RedirectStandardOutput) process.OutputDataReceived += Cli_OutputDataReceived;
                if (psi.RedirectStandardError) process.ErrorDataReceived += Cli_ErrorDataReceived;
                process.StartInfo = psi;
                process.Start();
                if (psi.RedirectStandardOutput) process.BeginOutputReadLine();
                if (psi.RedirectStandardError) process.BeginErrorReadLine();
            }

            return -1;
        }

        public virtual void Cli_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                OutputDataReceived?.Invoke(sender, e);
            }
        }

        public virtual void Cli_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                ErrorDataReceived?.Invoke(sender, e);
            }
        }

        public void WriteInput(string input)
        {
            if (process != null && process.StartInfo != null && process.StartInfo.RedirectStandardInput)
            {
                process.StandardInput.WriteLine(input);
            }
        }

        public virtual void ForceClose()
        {
            if (process != null)
            {
                if (!process.HasExited)
                {
                    process.Kill();
                }
            }
        }

        public virtual void Close()
        {
            if (process != null)
            {
                process.CloseMainWindow();
                if (!process.HasExited)
                {
                    ForceClose();
                    process = null;
                }
            }
        }

        public bool Closed
        {
            get
            {
                try
                {
                    if (process != null)
                    {
                        return process.HasExited;
                    }
                    else return true;
                }
                catch
                {
                    return true;
                }
            }
        }

        public void Dispose()
        {
            if (process != null)
            {
                process.Dispose();
            }
        }
    }
}
