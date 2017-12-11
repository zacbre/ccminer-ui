using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ccminer_gui
{
    class CCMinerInterop
    {
        public event DataReceivedEventHandler OutputDataReceived;
        public event DataReceivedEventHandler ErrorDataReceived;

        public CCMinerInterop()
        {
            _minerCli = new MinerCli();

            _minerCli.OutputDataReceived += _minerCli_OutputDataReceived;
            _minerCli.ErrorDataReceived += _minerCli_ErrorDataReceived;

            _algorithms = new List<Algorithm>()
            {
                Algorithm.Create("bastion", "Joincoin"),
                Algorithm.Create("bitcore", "Bitcore's Timetravel10"),
                Algorithm.Create("blake", "Saffroncoin(Blake256)"),
                Algorithm.Create("blakecoin", "Old Blake 256"),
                Algorithm.Create("blake2s", "Nevacoin(Blake2-S 256)"),
                Algorithm.Create("bmw", "Midnight"),
                Algorithm.Create("cryptolight", "AEON cryptonight(MEM/2)"),
                Algorithm.Create("cryptonight", "XMR cryptonight"),
                Algorithm.Create("c11/flax", "Chaincoin and Flax"),
                Algorithm.Create("decred", "Decred 180 bytes Blake256-14"),
                Algorithm.Create("deep", "Deepcoin"),
                Algorithm.Create("dmd-gr", "Diamond-Groestl"),
                Algorithm.Create("equihash", "ZEC, HUSH and KMD"),
                Algorithm.Create("fresh", "Freshcoin"),
                Algorithm.Create("fugue256", "Fuguecoin"),
                Algorithm.Create("groestl", "Groestlcoin"),
                Algorithm.Create("heavy", "Heavycoin"),
                Algorithm.Create("hsr", "Hshare"),
                Algorithm.Create("jackpot", "Sweepcoin"),
                Algorithm.Create("keccak", "Maxcoin"),
                Algorithm.Create("keccakc", "CreativeCoin"),
                Algorithm.Create("lbry", "LBRY Credits"),
                Algorithm.Create("luffa", "Joincoin"),
                Algorithm.Create("lyra2", "CryptoCoin"),
                Algorithm.Create("lyra2v2", "Vertcoin"),
                Algorithm.Create("lyra2z", "Zerocoin(XZC)"),
                Algorithm.Create("mjollnir", "Mjollnircoin"),
                Algorithm.Create("myr-gr", "Myriad-Groest"),
                Algorithm.Create("neoscrypt", "FeatherCoin"),
                Algorithm.Create("nist5", "TalkCoin"),
                Algorithm.Create("penta", "Joincoin / Pentablake"),
                Algorithm.Create("phi", "LUXCoin"),
                Algorithm.Create("polytimos", "Polytimos"),
                Algorithm.Create("quark", "Quarkcoin"),
                Algorithm.Create("qubit", "Qubit"),
                Algorithm.Create("scrypt", "Scrypt coins"),
                Algorithm.Create("scrypt:N", "Scrypt-N(:10 for 2048 iterations)"),
                Algorithm.Create("scrypt-jane", "Chacha coins like Cache and Ultracoin"),
                Algorithm.Create("s3", "1coin(ONE)"),
                Algorithm.Create("sha256t", "OneCoin(OC)"),
                Algorithm.Create("sia", "SIA"),
                Algorithm.Create("sib", "Sibcoin"),
                Algorithm.Create("skein", "Skeincoin"),
                Algorithm.Create("skein2", "Woodcoin"),
                Algorithm.Create("skunk", "Signatum"),
                Algorithm.Create("timetravel ", "MachineCoin"),
                Algorithm.Create("tribus", "Denarius"),
                Algorithm.Create("x11evo", "Revolver"),
                Algorithm.Create("x11", "DarkCoin"),
                Algorithm.Create("x14", "X14Coin"),
                Algorithm.Create("x15", "Halcyon"),
                Algorithm.Create("x17", "X17"),
                Algorithm.Create("x17", "X17"),
                Algorithm.Create("vanilla", "Vanilla(Blake256)"),
                Algorithm.Create("veltor", "VeltorCoin"),
                Algorithm.Create("whirlpool", "Joincoin"),
                Algorithm.Create("wildkeccak", "Boolberry(Stratum only)"),
                Algorithm.Create("zr5", "ZiftrCoin"),
            };
        }

        public string FindAlgorithmName(string algorithmName)
        {
            return Algorithm.FindByArgument(algorithmName, _algorithms).Name;
        }

        public List<string> GetList()
        {
            return Algorithm.GetNames(_algorithms);
        }

        public void Run(IConfig config)
        {
            _minerCli.Open(Path.Combine(Environment.CurrentDirectory, "ccminer-x64.exe"), new string[] {
                "-N",
                config.StatsAvg.ToString(),
                "-i",
                config.Intensity,
                "-a",
                Algorithm.Find(config.Algorithm, _algorithms).Argument,
                "-o",
                config.PoolUrl,
                "-u",
                config.Username,
                "-p",
                config.Password
            });
        }

        private void _minerCli_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            ErrorDataReceived?.Invoke(sender, e);
        }

        private void _minerCli_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OutputDataReceived?.Invoke(sender, e);
        }

        public void Stop()
        {
            _minerCli.Close();
        }

        public bool IsRunning
        {
            get
            {
                return !_minerCli.Closed;
            }
        }

        public string RemoveColors(string data)
        {
            data = data.Replace("\u001b[0m", "");
            data = data.Replace("\u001b[32m", "");
            data = data.Replace("\u001b[33m", "");
            data = data.Replace("\u001b[34m", "");
            data = data.Replace("\u001b[35m", "");
            data = data.Replace("\u001b[36m", "");
            data = data.Replace("\u001b[01;37m", "");
            return data;
        }

        private List<Algorithm> _algorithms;
        private MinerCli _minerCli;
    }
}
