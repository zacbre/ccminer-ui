using System;
using System.Runtime.InteropServices;

namespace ccminer_gui
{
    internal struct LASTINPUTINFO
    {
        public uint cbSize;
  
        public uint dwTime;
    }
  
    /// <summary>
    /// Summary description for Win32.
    /// </summary>
    public class Win32
    { 
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);        
  
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();
      
        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);
  
            return ((uint) Environment.TickCount - lastInPut.dwTime);
        }
  
        public static long GetTickCount()
        {
            return Environment.TickCount;
        }
  
        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)Marshal.SizeOf(lastInPut);
            if (!GetLastInputInfo(ref lastInPut))
            {
                throw new Exception(GetLastError().ToString());
            }
                              
            return lastInPut.dwTime;
        }
    }
}
