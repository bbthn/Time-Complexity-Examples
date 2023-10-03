
using System.Text.RegularExpressions;

namespace TimeComplexity
{
    //These two groups of loop are in consecutive so their complexity will add up
    //to form the final complexity of the program.Time Complexity: O(n2) + O(n2)
    //= O(n2)
    public class Consecutive
    {
        int fun7(int n)
        {
            int i, j, k, m = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    m += 1;
                }
            }
            for (i = 0; i < n; i++)
            {
                for (k = 0; k < n; k++)
                {
                    m += 1;
                }
            }
            return m;
        }
    }
}
