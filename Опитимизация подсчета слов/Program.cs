using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        var wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {
        var words = Regex.Matches(text, @"\b\w+\b");
        var result = new Dictionary<string, int>();

        foreach (Match match in words)
        {
            string word = match.Value;

            if (result.TryGetValue(word, out int count))
            {
                result[word] = count + 1;
            }
            else
            {
                result[word] = 1;
            }
        }

        return result;
    }
}





