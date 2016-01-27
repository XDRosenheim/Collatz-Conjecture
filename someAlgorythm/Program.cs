using System;

namespace someAlgorythm {
    class Program {
        static void Main( string[] args ) {
            while(true) {
                long l;
                while(true) {
                    Console.WriteLine( "Collatz Conjecture" );
                    Console.Write( "Number: " );
                    l = Convert.ToInt64( Console.ReadLine() );
                    if(l > 0) break;
                }
                var i = 0;
                var x = l;
                while(true) {
                    Console.WriteLine( i + ": " + x );
                    if(x == 1) break;
                    if(x % 2 == 0) x = x / 2;
                    else x = x * 3 + 1;
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine( "Total runs: " + i );
                break;
            }
            Console.ReadKey();
        }
    }
}
