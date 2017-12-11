using System;

namespace ccminer_gui
{
    [Serializable]
    public class CustomConfig : IConfig
    {
        public string Intensity { get; private set; }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public string PoolUrl { get; private set; }

        public int StatsAvg { get; private set; }

        public string Algorithm { get; private set; }

        public void SetConfig(string intensity, string username, string password, string poolurl, int statsavg, string algorithm)
        {
            Intensity = intensity;
            Username = username;
            Password = password;
            PoolUrl = poolurl;
            StatsAvg = statsavg;
            // Find the algorithm.
            Algorithm = algorithm;
        }
    }
}
