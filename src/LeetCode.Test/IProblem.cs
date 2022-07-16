using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal interface IProblem
    {
       

        static IProblem Create() => throw new NotImplementedException();
       

        void Resolve();
    }
}
