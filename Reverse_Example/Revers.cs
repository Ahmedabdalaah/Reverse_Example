using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Example
{
    internal class Revers
    {
        public void rev(string input)
        {
            string output = "";
            for(int x=input.Length-1;x>=0 ;x--)
            {
                output += input[x];
            }
            Console.WriteLine(output);
        }
    }
}
