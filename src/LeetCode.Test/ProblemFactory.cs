using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class ProblemFactory
    {
        private Dictionary<string, Type> _problems;


        public ProblemFactory()
        {
            _problems = new Dictionary<string, Type>();

            RegisterProblems();
        }



        public void RegisterProblems()
        {
            var type = typeof(IProblem);

            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(c => c.GetTypes()).Where(w => type.IsAssignableFrom(w) && w.IsClass);


            foreach (var t in types)
            {
                _problems.Add(t.Name, t);
            }
        }


        public IProblem Resolve(string name)
        {
            Type t = _problems[name];

            return (IProblem)Activator.CreateInstance(t);
        }

    }
}
