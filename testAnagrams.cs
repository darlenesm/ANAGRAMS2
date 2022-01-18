using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtestAnagrams
{
    [TestClass]
    public class AnagramTesting
    {
    
     [TestMethod]
        public void AnagramInvalid()
        {
            Anagrams obj = new Anagrams();

            tring[] anaword = new string[7] 
            {"amor", "trama", "poder", "frase", "saco", "materialismo", "resto" };
            
             string[] anawords = new string[7] 
            {"mora", "marta", " ", " ", "retos"};

            bool validation = obj.AnagramWords(anaword[1],anawords[2]);
            bool invalid =! validation;

            Assert.IsFalse(invalida);
        }
        
         [TestMethod]
        public void AnagramInvalid()
        {
            Anagrams obj = new Anagrams();

            tring[] anaword = new string[7] 
            {" ", " ", " ", " };
            
             string[] anawords = new string[7] 
            {"", "", " ", " "};

            bool validation = obj.AnagramWords(anaword[],anawords[]);

            Assert.IsNull(validation);
        }
        
    
         [TestMethod]
        public void AnagramValidation()
        {
            Anagrams obj = new Anagrams();

            tring[] anaword = new string[7] 
            {"amor", "trama", "poder", "frase", "saco", "materialismo", "resto" };
            
             string[] anawords = new string[7] 
            {"mora", "marta", "pedro","fresa", "cosa", "memorialista", "retos"};

            bool validation = obj.AnagramWords(anaword[1],anawords[2]);

            Assert.IsTrue(validation);
        }

    }
}
