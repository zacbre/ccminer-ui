namespace ccminer_gui
{
    interface IConfig
    {
        string Intensity { get; }
        string Username { get; }
        string Password { get; }
        string PoolUrl { get; }
        int StatsAvg { get; }
        string Algorithm { get; }
    }
}
