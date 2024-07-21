using Dumpify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Linq
{
    internal class Zip
    {
        internal void Exmaple1()
        {
            var names = new[] { "Ssam", "Jhon", "Smith", "Alice" };
            var ages = new[] { 20, 25, 31, 55 };

            var pairs = names.Zip(ages, (name, age) => (name, age));

            pairs.Dump(); 
        }
    }
}
