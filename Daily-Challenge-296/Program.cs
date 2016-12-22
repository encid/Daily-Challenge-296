using System;
using System.Collections.Generic;

namespace DailyChallenge296 {
    class Program {

        static void Main()
        {
            var Days = new List<string> { "first", "second", "third", "fourth", "fifth", "sixth",
                                "seventh", "eighth", "ninth", "tenth", "eleventh", "twelveth" };

            for (int i = 1; i <= 12; i++) {
                Console.WriteLine("On the " + Days[i - 1] + " day of Christmas\nmy true love sent to me:");
                if (i == 12) {
                    Console.WriteLine("12 Drummers Drumming");
                }
                if (i >= 11) {
                    Console.WriteLine("11 Pipers Piping");
                }
                if (i >= 10) {
                    Console.WriteLine("10 Lords a Leaping");
                }
                if (i >= 9) {
                    Console.WriteLine("9 Ladies Dancing");
                }
                if (i >= 8) {
                    Console.WriteLine("8 Maids a Milking");
                }
                if (i >= 7) {
                    Console.WriteLine("7 Swans a Swimming");
                }
                if (i >= 6) {
                    Console.WriteLine("6 Geese a Laying");
                }
                if (i >= 5) {
                    Console.WriteLine("5 Golden Rings");
                }
                if (i >= 4) {
                    Console.WriteLine("4 Calling Birds");
                }
                if (i >= 3) {
                    Console.WriteLine("3 French Hens");
                }
                if (i >= 2) {
                    Console.WriteLine("2 Turtle Doves");
                }
                if (i >= 1) {
                    if (i == 1) {
                        Console.WriteLine("1 Partridge in a Pear Tree\n");                        
                    }
                    else
                        Console.WriteLine("and 1 Partridge in a Pear Tree\n");
                }
            }
            Console.ReadLine();
        }
    }
}
