namespace ccminer_gui.Interfaces
{
    interface IMinerReport
    {
        int AcceptedShares { get; }
        int StaleShares { get; }
        int TotalShares { get; }

        decimal TotalHashrate { get; } // in MH/s.

        decimal StratumDifficulty { get; }
        decimal BlockDifficulty { get; }
        int Block { get; }
    }
}
