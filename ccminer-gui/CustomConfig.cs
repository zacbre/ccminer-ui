using System;

namespace ccminer_gui
{
    [Serializable]
    public class CustomConfig : IConfig
    {
        public string Intensity => _intensity;

        public string Username => _username;
        public string Password => _password;
        public string PoolUrl => _poolurl;

        public int StatsAvg => _statsavg;

        public string Algorithm => _algorithm;

        public CustomConfig()
        { 
        }

        public void SetConfig(string intensity, string username, string password, string poolurl, int statsavg, string algorithm)
        {
            _intensity = intensity;
            _username = username;
            _password = password;
            _poolurl = poolurl;
            _statsavg = statsavg;
            // Find the algorithm.
            _algorithm = algorithm;
        }

        private string _intensity;

        private string _username;
        private string _password;
        private string _poolurl;

        private int _statsavg;

        private string _algorithm;
    }
}
