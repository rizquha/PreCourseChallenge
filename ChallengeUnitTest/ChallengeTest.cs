using System;
using System.Collections;
using Xunit;
using YourName;
using DaysToNextBirthday;
using StringLength;
using Substitution;
using EvenOdd;
using Grade;
using TempratureConverter;
using LeapYear;
using Timezone;
using Calculator;
using SumArgument;
using ToUpperCase;
using CountWords;
using PalindromeDetector;
using MirrorString;
using FruitFinder;
using FooBarBaz;
using FindMinMaxAvg;
using Sorter;
using Challenge;



namespace ChallengeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Your_Name()
        {
            Assert.Equal("Rizquha",Program.nama("Rizquha"));
        }

        [Fact]
        public void Test_DaysToNextBirthday()
        {
            Assert.Equal(-8208,DaysNextBirthday.RemainingNextBirthday("1997/07/26"));
        }

        [Fact]
        public void Test_String_Length()
        {
            Assert.Equal(7, CountingStringLength.CountString("rizquha"));
        }

        [Fact]
        public void Test_subtitution()
        {
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");
            Assert.Equal("Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.", SubtitutionClass.replace("Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.",censoredWords));
        }

        [Fact]
        public void Test_OddOrEven()
        {
            Assert.True(EvenOrOdd.isOdd(21));
            Assert.True(EvenOrOdd.isEven(20));
        }

        [Fact]
        public void Test_Grade()
        {
            Assert.Equal('E',GradeClass.Grade(50));
        }

        [Fact]
        public void Test_TempConverter()
        {
            Assert.Equal(32,TempConverter.CelciusToFahrenheit(0));
            Assert.Equal(10,TempConverter.FahrenheitToCelcius(50));
            Assert.Equal(373.15,TempConverter.CelciusToKelvin(100));
            Assert.Equal(101.85,TempConverter.KelvinToCelcius(375));
            Assert.Equal(215.33,TempConverter.KelvinToFahrenheit(375));
            Assert.Equal(262.039,TempConverter.FahrenheitToKelvin(12));
        }

        [Fact]
        public void Test_IsLeapYear()
        {
            Assert.True(LeapYearClass.IsLeapYear(2008));
        }

        [Fact]
        public void Test_Timezone()
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            var expected1 = $"{jakarta.Item1} 7 hour ahead {london.Item1}";
            var expected2 = $"{cairo.Item1} 7 hour ahead {chicago.Item1}";
            var expected3 = $"{cairo.Item1} 6 hour behind {bali.Item1}";
            var expected4 = $"{denver.Item1} 13 hour behind {jakarta.Item1}";

            Assert.Equal(expected1, TimezoneClass.TimezoneDiff(jakarta, london));
            Assert.Equal(expected2, TimezoneClass.TimezoneDiff(cairo, chicago));
            Assert.Equal(expected3, TimezoneClass.TimezoneDiff(cairo, bali));
            Assert.Equal(expected4, TimezoneClass.TimezoneDiff(denver, jakarta));
        }

        [Fact]
        public void Test_Calculator()
        {
            int a = 5;
            int b = 5;
            Assert.Equal(10,CalculatorClass.Sum(a,b));
            Assert.Equal(0,CalculatorClass.Substract(a,b));
            Assert.Equal(25,CalculatorClass.Multiply(a,b));
            Assert.Equal(1,CalculatorClass.Divide(a,b));
        }

        [Fact]
        public void Test_SumArgument()
        {
            int[] arg = {1, 5, 8, 3};
            Assert.Equal(17, SumArgumentClass.sum(arg));
        }

        [Fact]
        public void Test_ToUpper()
        {
            string str = "RIZQUHA MAULIDA";
            Assert.Equal(str,ToUpperClass.toUpper("rizquha maulida"));
        }

        [Fact]
        public void Test_CountWords()
        {
            string str1="Hello";
            string str2 = "Hello World";
            string str3 = "Lorem ipsum dolor sit amet";
            Assert.Equal(1,CountWordsClass.CountWords(str1));
            Assert.Equal(2,CountWordsClass.CountWords(str2));
            Assert.Equal(5,CountWordsClass.CountWords(str3));
        }

        [Fact]
        public void Test_PalindromeDetector()
        {
            string str1="ipsum";
            string str2="malam";
            string str3="tidur";
            string str4="kasur rusak";
            string str5="ibu ratna antar ubi";

            Assert.False(PalindromeDetectorClass.IsPalindrome(str1));
            Assert.True(PalindromeDetectorClass.IsPalindrome(str2));
            Assert.False(PalindromeDetectorClass.IsPalindrome(str3));
            Assert.True(PalindromeDetectorClass.IsPalindrome(str4));
            Assert.True(PalindromeDetectorClass.IsPalindrome(str5));
        }

        [Fact]
        public void Test_MirrorString()
        {
            Assert.Equal("--vvvv--",MirrorStringClass.Mirror("--vv"));
        }

        [Fact]
        public void Test_FruitFinder()
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            string fruit1 = "Jeruk";
            string fruit2 = "Pepaya";
            string fruit3 = "Markisa";

            Assert.Equal(0,FruitFinderClass.IndexFinder(fruits,fruit1));
            Assert.Equal(3,FruitFinderClass.IndexFinder(fruits,fruit2));
            Assert.Equal(6,FruitFinderClass.IndexFinder(fruits,fruit3));
        }

        [Fact]
        public void Test_FooBarBaz()
        {
            var expected = new ArrayList();
            for(int i=0; i<1000; i++){
                if(i%5 == 0){
                    if(i%20 == 0){
                        if(i%100 == 0)
                            expected.Add("Baz");

                        else
                            expected.Add("Bar");
                    }

                    else
                        expected.Add("Foo");
                }

                else
                    expected.Add(i);
            }

            Assert.Equal(expected, FooBarBazClass.calculate());
        }

        [Fact]
        public void Test_FindMinMaxAvg()
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            Assert.Equal(330,FindMinMaxAvgClass.FindMax(numbers));
            Assert.Equal(-65,FindMinMaxAvgClass.FindMin(numbers));
            Assert.Equal(52.166666666666664,FindMinMaxAvgClass.FindAverage(numbers));
        }

        [Fact]
        public void Test_Sorter()
        {
            int[] sorted = {-65, -4, 2, 4, 12, 19, 40, 54, 54, 88, 92, 330};
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            Assert.Equal(sorted,SorterClass.sort(numbers));

        }

        [Fact]
        public void Test_ItemSale()
        {
            string expected = "Indomie Goreng (Rp 2800)";
            Item.name = "Indomie Goreng";
            Item.price = 3500;
            Item.onSale = true;

            Assert.Equal(expected, Item.itemPrice());
        }



    }
}
