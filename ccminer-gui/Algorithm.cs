using System.Collections.Generic;
using System.Linq;

namespace ccminer_gui
{
    class Algorithm
    {
        public Algorithm()
        {
        }

        public Algorithm(string name, string argument)
        {
            _name = name;
            _argument = argument;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Argument
        {
            get
            {
                return _argument;
            }
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
                names.Add(algo._name);
            }
            return names;
        }

        private string _argument;
        private string _name;
    }
}
