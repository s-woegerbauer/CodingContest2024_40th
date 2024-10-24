namespace CodingContest2024_40th.Collections;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    public static string Remove(this string input, string remove)
    {
        return input.Replace(remove, string.Empty);
    }
    
    public static int CountOccurence(this string input, string occurence)
    {
        int count = 0;
        
        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] == occurence[0])
            {
                bool found = true;
                for (int j = 1; j < occurence.Length; j++)
                {
                    if (input[i + j] != occurence[j])
                    {
                        found = false;
                        break;
                    }
                }
                
                if (found)
                {
                    count++;
                }
            }
        }

        return count;
    }
    
    public static bool LengthInMinMax(this string input, int min, int max)
    {
        return input.Length >= min && input.Length <= max;
    }
    
    public static bool IsNumeric(this string input)
    {
        return int.TryParse(input, out _);
    }
}

public static class IntExtensions
{
    public static int[] ToDigits(this int input)
    {
        return input.ToString().Select(x => int.Parse(x.ToString())).ToArray();
    }
    
    public static int DigitSum(this int input)
    {
        return input.ToDigits().Sum();
    }
    
    public static int DigitProduct(this int input)
    {
        return input.ToDigits().Aggregate(1, (x, y) => x * y);
    }
    
    public static int DigitCount(this int input)
    {
        return input.ToDigits().Length;
    }
    
    public static double DigitAverage(this int input)
    {
        return input.ToDigits().Average();
    }
}

public static class DictionaryExtensions
{
    public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary[key] = value;
        }
        else
        {
            dictionary.Add(key, value);
        }
    }
}