using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ccminer_gui
{
    public partial class Miner : Form
    {
        public Miner()
        {
            InitializeComponent();

            _miner = new CCMinerInterop();
            _miner.OutputDataReceived += _miner_OutputDataReceived;
            _miner.ErrorDataReceived += _miner_ErrorDataReceived;

            timer1.Enabled = true;
            timer1.Start();

            SetupUI();
        }

        private void AddItem(string data)
        {
            Invoke((MethodInvoker)(() =>
            {
                listBox1.Items.Add(_miner.RemoveColors(data));
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.ClearSelected();
                if (listBox1.Items.Count > 100)
                {
                    listBox1.Items.RemoveAt(0);
                }
            }));
        }

        private void _miner_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            AddItem(e.Data);
        }

        private void _miner_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            AddItem(e.Data);
        }

        private CCMinerInterop _miner;
        private CustomConfig _customConfig;

        private bool _isStarted = false;

        private string _path = Path.Combine(Environment.CurrentDirectory, "guiminer.conf");
        private BinaryFormatter _bin = new BinaryFormatter();

        private void SetupUI()
        {
            // Set all algorithms.
            foreach (var algorithm in _miner.GetList())
            {
                algorithmBox.Items.Add(algorithm);
            }

            if (!File.Exists(_path))
            {
                var dc = new DefaultConfig();
                algorithmBox.Text = dc.Algorithm;
                intensityBox.Text = dc.Intensity;
                gpuStatsBox.Value = dc.StatsAvg;
                usernameBox.Text = dc.Username;
                passwordBox.Text = dc.Password;
                poolUrlBox.Text = dc.PoolUrl;
            }
            else
            {
                using (FileStream fs = new FileStream(_path, FileMode.Open)) //double check that...
                {
                    var dc = (CustomConfig)_bin.Deserialize(fs);
                    algorithmBox.Text = dc.Algorithm;
                    intensityBox.Text = dc.Intensity;
                    gpuStatsBox.Value = dc.StatsAvg;
                    usernameBox.Text = dc.Username;
                    passwordBox.Text = dc.Password;
                    poolUrlBox.Text = dc.PoolUrl;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _customConfig = new CustomConfig();
            _customConfig.SetConfig(intensityBox.Text, usernameBox.Text, passwordBox.Text, poolUrlBox.Text, Convert.ToInt32(gpuStatsBox.Value), algorithmBox.Text);

            using (FileStream fs = new FileStream(_path, FileMode.Create))
            {
                _bin.Serialize(fs, _customConfig);
            }

            _isStarted = !_isStarted;

            if (!idleBox.Checked)
            {
                if (!_miner.IsRunning)
                {
                    AddItem("----------- Starting Miner -----------");
                    _miner.Run(_customConfig);
                }
            }
            else
            {
                if (!_miner.IsRunning)
                {
                    AddItem("----------- Waiting to Start Miner for PC Idle -----------");
                }
            }

            if (_isStarted)
            {
                startButton.Text = "Stop";
                // Disable UI items.
                algorithmBox.Enabled = false;
                intensityBox.ReadOnly = true;
                gpuStatsBox.ReadOnly = true;
                usernameBox.ReadOnly = true;
                passwordBox.ReadOnly = true;
                poolUrlBox.ReadOnly = true;
                idleBox.Enabled = false;
            }
            else
            {
                _miner.Stop();
                AddItem("----------- Stopped Miner -----------");
                startButton.Text = "Start";
                algorithmBox.Enabled = true;
                intensityBox.ReadOnly = false;
                gpuStatsBox.ReadOnly = false;
                usernameBox.ReadOnly = false;
                passwordBox.ReadOnly = false;
                poolUrlBox.ReadOnly = false;
                idleBox.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check status.
            statusLabel.Text = (_miner.IsRunning ? "Running." : "Stopped.");

            if (idleBox.Checked && _isStarted)
            {
                if (Win32.GetIdleTime() > (2 * 60 * 1000))
                {
                    if (!_miner.IsRunning)
                    {
                        AddItem("----------- Starting Miner (Detected PC Idle) -----------");
                        _miner.Run(_customConfig);
                    }
                }
                else
                {
                    if (_miner.IsRunning)
                    {
                        _miner.Stop();
                        AddItem("----------- Stopped Miner (Detected PC Input) -----------");
                    }
                }
            }
        }

        private void Miner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_miner.IsRunning && _isStarted)
            {
                _isStarted = false;
                _miner.Stop();
            }
        }
    }
}
