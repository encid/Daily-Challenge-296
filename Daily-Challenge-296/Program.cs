using System;
using System.Collections.Generic;

namespace DailyChallenge296 {
    class Program {

        static void Main()
        {
            var Days = new List<string> { "first", "second", "third", "fourth", "fifth", "sixth",
                        "seventh", "eighth", "ninth", "tenth", "eleventh", "twelveth" };

            var Gifts = new List<string> { "a Partridge in a Pear Tree", "two Turtle Doves",
                        "three French Hens", "four Calling Birds", "five Golden Rings",
                        "six Geese a Laying", "seven Swans a Swimming", "eight Maids a Milking",
                        "nine Ladies Dancing", "ten Lords a Leaping", "eleven Pipers Piping",
                        "twelve Drummers Drumming" };

            for (int i = 0; i < 12; i++) {
                Console.WriteLine("\nOn the {0} day of Christmas\nmy true love sent to me:", Days[i]);
                for (int j = i; j >= 0; j--) {
                    if (i > 0)
                        Gifts[0] = "and a Partridge in a Pear Tree";
                    else
                        Gifts[0] = "a Partridge in a Pear Tree";
                    Console.WriteLine(Gifts[j]);
                }                                
            }
            Console.ReadLine();
        }
    }
}
