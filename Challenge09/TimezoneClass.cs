using System;

namespace Timezone
{
    public class TimezoneClass
    {
        static void Main(string[] args)
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            Console.WriteLine(TimezoneDiff(jakarta, london)); // Output: Jakarta 7 hours ahead London
            Console.WriteLine(TimezoneDiff(cairo, chicago)); // Output: Cairo 7 hours ahead Chicago
            Console.WriteLine(TimezoneDiff(cairo, bali)); // Output: Cairo 6 hours behind ahead Bali
            Console.WriteLine(TimezoneDiff(denver, jakarta)); // Output: Denver 13 hours behind Jakarta
        }

        public static string TimezoneDiff(Tuple<string, int> a, Tuple<string, int> b)
        {
            int ret = a.Item2 - b.Item2;
            if(ret > 0)
                return string.Format("{0} {1} hour ahead {2}", a.Item1, ret, b.Item1);

            else
                return string.Format("{0} {1} hour behind {2}", a.Item1, Math.Abs(ret), b.Item1);
        }
    }
}
