
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        //separate string into sentences
        var sentences = s.Split(['.', '?', '!'], StringSplitOptions.None);
        int highestNumber = 0;
        
        foreach (var sentence in sentences)
        {
            //separate sentence into words
            var words = sentence.Trim().Split(' ').Count(word => word.Any(char.IsLetter));

            if (words > highestNumber)
            {
                highestNumber = words;
            }
        }
        
        return highestNumber;
    }
}
