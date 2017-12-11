using System.Collections.Generic;
using System.Linq;

namespace ccminer_gui
{
    class Algorithm
    {
        public string Name { get; private set; }
        public string Argument { get; private set; }

        public Algorithm()
        {
        }

        public Algorithm(string name, string argument)
        {
            Name = name;
            Argument = argument;
        }
        
        public static Algorithm Create(string argument, string name)
        {
            return new Algorithm(name, argument);
        }

        public static Algorithm Find(string name, List<Algorithm> algos)
        {
            return algos.Where(a => a.Name == name).FirstOrDefault();
        }

        public static Algorithm FindByArgument(string argument, List<Algorithm> algos)
        {
            return algos.Where(a => a.Argument == argument).FirstOrDefault();
        }

        public static List<string> GetNames(List<Algorithm> algos)
        {
            var names = new List<string>();
            foreach (var algo in algos)
            {
                names.Add(algo.Name);
            }
            return names;
        }
    }
}
