using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
        }


        public static long Hash(string s)
        {
            long h = 0;
            var letters = "acdegilmnoprstuw";
            var index = 0;
            long inc = 0;

            h = 7;

            for (int i = 0; i < s.Length; i++)
            { 
                inc = h * 37;
                index = letters.IndexOf(s[i]);
                h = inc + index;
            }

           return h;
        }


    }
}
