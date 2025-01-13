// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Program
{
    public static void Main(string[] args)
    {
        string s = "abcabcbb";
        Program program = new Program();
        int result = program.LengthOfLongestSubstring(s);
        Console.WriteLine($"Length of the longest substring without repeating characters: {result}");
    }
    public int LengthOfLongestSubstring(string s)
    {
        int count = 0;

        int currentCount = 0;
        var currentLetters = new List<char>();
        int startingIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (currentCount == 0)
            {
                startingIndex = i + 1;
            }
            if (currentLetters.Contains(s[i]))
            {
                if (count < currentCount)
                {
                    count = currentCount;
                }
                currentLetters = new List<char>();
                i = startingIndex - 1;
                currentCount = 0;
            }
            else
            {
                currentCount++;
                currentLetters.Add(s[i]);
            }
        }

        if (count < currentCount)
        {
            return currentCount;
        }

        return count;
    }
}