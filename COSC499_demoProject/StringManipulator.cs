using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC499_demoProject
{
    public class StringManipulator
    {
        public string String5Times(string input)
        {
            string ans = "";
            for (int i = 0; i < 5; i++)
            {
                ans += input;
            }
            return ans;
        }

        public int FindEs(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'e')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
