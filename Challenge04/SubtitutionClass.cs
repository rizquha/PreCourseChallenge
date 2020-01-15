using System;
using System.Collections;

namespace Substitution
{
    public class SubtitutionClass
    {
        
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            paragraph = replace(paragraph,censoredWords);
            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.

            Console.Write(paragraph);
        }

        public static string replace(string prg, ArrayList word)
        {
                foreach(string wrd in word){
                string censorer = "";
                for(int i=0; i<wrd.Length; i++)
                    censorer += '*';

                prg = prg.Replace(wrd, censorer);
                }
                return prg;
        }
    }
}
