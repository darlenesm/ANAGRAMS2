using System;
using System.Collections.Generic;


namespace Anagrams
{
    public class AnagramWordsList
    {
        public const string SEPARATE = ", ";
       
        Dictionary<String, List<String>> AnagramCollection = new Dictionary<String, List<String>>();

        public static void AddAna(string letter)
        {
           string value;
           
            if (AnagramCollection.ContainsKey(avalue))
            {
                AnagramCollection.TryGetValue(avalue, out List<string> Anagrams);
                Anagrams.Add(letter);
            }
            else
            {
                AnagramCollection.Add(avalue, new List<string> { letter});
            }

        }


        private static void Remove(System.Text.StringBuilder stringBuilder, int size)
        {
            stringBuilder.Remove(stringBuilder.Length - size, size);
        }

       
    }
}
