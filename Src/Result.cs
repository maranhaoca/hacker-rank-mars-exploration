using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

        public static int marsExploration(string s)
        {
            int count = 0;

            for (int i = 1; i < s.Length -1; i+=3)
            {
                count = s[i - 1] != 'S' ? count+= 1 : count;
                count = s[i]     != 'O' ? count+= 1 : count;
                count = s[i + 1] != 'S' ? count+= 1 : count;
            }

            return count;
        }
    }
}