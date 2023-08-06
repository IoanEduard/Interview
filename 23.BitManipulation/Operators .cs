using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.Interview.BitManipulation
{
    public class Operators
    {
        public int Not(int n)
        {
            var result = ~n;
            return result;
        }

        public int And(int n) {
            var result = &n;
            return result;
        }

        public int Or(int n, int m) {
            var nToBinary = n.ToString(2);
            var mToBinary = m.ToString(2);

            var result = new StringBuilder();

             result.$"decimal: {n} - binary: {nToBinary}";
             

            var result = n | m;
        }
    }
}