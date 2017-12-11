using ccminer_gui.Interfaces;

namespace ccminer_gui.Entities
{
    class MinerReport : IMinerReport
    {
        public int AcceptedShares { get; set; }

        public int StaleShares { get; set; }

        public int TotalShares { get; set; }

        public decimal TotalHashrate { get; set; }

        public decimal StratumDifficulty { get; set; }

        public decimal BlockDifficulty { get; set; }

        public int Block { get; set; }
    }
}
