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
                    var leftPeak = points[i - 1];
                    
                    // To find the lowest point
                    while (i < n && points[i] < points[i - 1])
                    {
                        i++;
                    }
                    
                    // Becomes invalid when there's no movement or has reached an end
                    if (i >= n)
                        break;
                   
                }

            }

            return maxDepth;
        }
    
}
