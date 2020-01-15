using System;

namespace PalindromeDetector
{
    public class PalindromeDetectorClass
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            Console.WriteLine(IsPalindrome("ipsum")); // false
            Console.WriteLine(IsPalindrome("malam")); // true
            Console.WriteLine(IsPalindrome("tidur")); // false
            Console.WriteLine(IsPalindrome("kasur rusak")); // true
            Console.WriteLine(IsPalindrome("ibu ratna antar ubi")); // true
        }


        public static bool IsPalindrome(string text)
        {
            if(text.Length % 2 == 1){
                int ln = text.Length/2;
                char[] temp = new char[ln]; 
                String mirror = text.Substring(ln);

                for(int i=0; i<ln; i++)
                    temp[i] = mirror[ln-i];
                
                mirror = new string(temp);
                if(text.Substring(0, ln) == mirror)
                    return true;

                else
                    return false;
            }

            else
                return false;
        }
    }
}
