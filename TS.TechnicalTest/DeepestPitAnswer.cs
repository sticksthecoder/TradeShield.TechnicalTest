namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
            int n = points.Length;
            int maxDepth = -1;

            int i = 1;

            while (i < n)
            {
                // Find start of a decent
                if (points[i] < points[i - 1] && points[i - 1] > 0)
                {
                   
                }

            }

            return maxDepth;
        }
    
}
