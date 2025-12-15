
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        //separate string into sentences
        var sentences = s.Split('.');
        int highestNumber = 0;
        
        foreach (var sentence in sentences)
        {
            //separate sentence into words
            var words = sentence.Trim().Split(' ');

            if (words.Length > highestNumber)
            {
                highestNumber = words.Length;
            }
        }
        
        return highestNumber;
        
        
    }
}
