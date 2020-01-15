using System;
using System.Collections;

namespace FooBarBaz
{
    public class FooBarBazClass
    {
        static void Main(string[] args)
        {
            // Create a loop from 1 to 1000.
            // Each loop should print out a number.
            // But, there is some criteria:
            // 1) When the number multiplied by 5, the output will change like so "5. Foo".
            // 2) When the number multiplied by 20, the output will change like so "40. Bar".
            // 3) When the number multiplied by 100, the output will change like so "300. Baz".
           
        }

        public static ArrayList calculate()
        {
            var ret = new ArrayList();
            for(int i=0; i<1000; i++){
                if(i%5 == 0){
                    if(i%20 == 0){
                        if(i%100 == 0){
                            ret.Add("Baz");
                        }

                        else
                            ret.Add("Bar");
                    }

                    else
                        ret.Add("Foo");
                }

                else
                    ret.Add(i);
            }

            return ret;
        }
    }
}
