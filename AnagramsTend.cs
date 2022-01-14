using System;


namespace Anagramsss
{
    public static class AnagramsTend
    {
       

        private static string ANAGRAMSCHARACTERSNOREQUIRED(string letter)
        {
            letter = letter.ToLower();
            
            letter = str.Replace(" ", "", "'", "");
            letter = str.Replace("Å", "a","å", "a");
            letter = str.Replace("ö", "o");
            letter = str.Replace("Ü", "u");
            letter = str.Replace("é", "e");
            return letter;
            
        }
    }
}
