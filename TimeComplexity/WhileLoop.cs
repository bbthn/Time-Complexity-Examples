using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
    //In each iteration, the value of I is doubled. Each time problem space is divided into half.
    //Time Complexity: O(log(n))
    public class WhileLoop
    {
        int fun4(int n)
        {
            int i, m = 0;
            i = 1;
            while (i < n)
            {
                m += 1;
                i = i * 2;
            }
            return m;
        }
        //In each iteration, the value of I is halved. Same as above each time problem space is divided into half.
        //Time Complexity: O(log(n))
        int fun5(int n)
        {
            int i, m = 0;
            i = n;
            while(i>0)
            {
                m += 1;
                i = i / 2;
            }
            return m;
        }
    }
}
