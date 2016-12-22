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

            for (int i = 1; i <= 12; i++) {
                Console.WriteLine("");
                Console.WriteLine("On the " + Days[i - 1] + " day of Christmas\nmy true love sent to me:");
                for (int j = (i-1); j >= 0; j--) {
                    if (i > 1) Gifts[0] = "and a Partridge in a Pear Tree";
                    Console.WriteLine(Gifts[j]);
                }
                Gifts[0] = "a Partridge in a Pear Tree";          
                
            }
            Console.ReadLine();
        }
    }
}
