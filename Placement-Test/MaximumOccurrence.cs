using System;
using System.Collections.Generic;
using System.Linq;

namespace Placement_Test
{
    class MaximumOccurrence
    {
        public static string MaxOccur(string text)
        {
            try
            {
                Dictionary<char, int> letterCount = new Dictionary<char, int>();
                foreach (char c in text)
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount[c] = 1;
                    }
                }
                int maxOccurency = letterCount.Values.Max();

                if (maxOccurency == 1)
                {
                    return "No Repetiton";
                }
                
                var result = letterCount.Where(x => x.Value == maxOccurency).Select(x => x.Key).ToArray();

                return result.Count() == 1 ? result.First().ToString() : string.Join(", ", result); ;
            }
            catch (Exception)
            {
                return "Text is empty. Please enter a valid text!";
            }
        }
    }
}
