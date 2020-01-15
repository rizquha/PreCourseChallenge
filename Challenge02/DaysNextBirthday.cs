using System;

namespace DaysToNextBirthday
{
    public class DaysNextBirthday
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Your next birthday date, please! ");
            string date = Console.ReadLine();
            int gap = RemainingNextBirthday(date);
            Console.WriteLine("{0} days remaining to my next birthday.", gap);
        }
        public static int RemainingNextBirthday(string date)
        {
            var today = DateTime.Now;
            DateTime birthDate = DateTime.Parse(date);
            TimeSpan gap =  birthDate - today;
            return(Convert.ToInt32(gap.Days));
        }
    }
}
