using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTend
{
    public class Anagrams
    {
        public bool AnagramsWords(string anaword, string anawords)
        {
           bool ANAGRAM = false;
           int x = 0, y = 0;
           
            string[] anaword = new string[7] 
            {"amor", "trama", "poder", "frase", "saco", "materialismo", "resto" };
            
             string[] anawords = new string[7] 
            {"mora", "marta", "pedro","fresa", "cosa", "memorialista", "retos"};
            

            for (int j = 0; j < anaword.Length - 1; j++)
            {
                x++;
                int aw = anawords.Length - 1;
                y = aw;

                if (anaword.Contains(words[j]) && x = y)
                {
                    ANAGRAM = true;

                }
      
                return AnagramWords(anaword[j], anawords[j]);
            }
            return ANAGRAM;
        }
    }
}
