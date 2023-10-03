namespace TimeComplexity
{
    public class SingleForLoop
    {

        //Time Complexity : O(n), single for loop takes linear time

        int fun1(int x)
        {
            int m = 0;
            for(int i =0; i<x; i++)
            {
                m += 1;

            }
            return m;
        }


    }
}