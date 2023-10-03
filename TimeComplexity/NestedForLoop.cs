

namespace TimeComplexity
{
    public class NestedForLoop
    {
        // Time Complexity: O(n^2), two nested for loop takes quadratic time.
        int fun2(int x)
        {
            int i, j, m = 0;

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    m += 1;
                }
            }
            return m;
        }

        //Time Complexity : O(n^2)
        int fun3(int n)
        {
            int i, j, m = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    m += 1;
                }
            }
            return m;
        }

        //Outer loop will run for n number of iterations.In each iteration of the outer
        //loop, inner loop will run for n iterations of its own.Three nested loops
        //running n number of times.
        //Time Complexity: O(n3)
        int fun6(int n)
        {
            int i, j, k, m = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    
            {
                    for (k = 0; k < n; k++)
                        m += 1;
                }
            }
            return m;
        }

        //Time Complexity: O(n* √n ) = O(n3/2)

        int fun8(int n)
        {
            int i, j, m = 0;
            for (i = 0; i < n; i++)
            {
                
            for (j = 0; j < Math.Sqrt(n); j++)
                    m += 1;
            }
            return m;
        }
    }
}
