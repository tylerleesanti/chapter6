using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;



namespace chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
            string card = null;
            string[] listOfSuits = { "Spades", "Hearts", "Clubs", "Diamonds" };
            foreach (string i in listOfSuits)
            {
                for (int i1 = 1; i1 < 13; i1++)
                {
                    switch (i1)
                    {
                        case 1:
                            card = "2";
                            break;
                        case 2:
                            card = "3";
                            break;
                        case 3:
                            card = "4";
                            break;
                        case 4:
                            card = "5";
                            break;
                        case 5:
                            card = "6";
                            break;
                        case 6:
                            card = "7";
                            break;
                        case 7:
                            card = "8";
                            break;
                        case 8:
                            card = "9";
                            break;
                        case 9:
                            card = "10";
                            break;
                        case 10:
                            card = "Jack";
                            break;
                        case 11:
                            card = "Queen";
                            break;
                        case 12:
                            card = "King";
                            break;
                    }

                    Console.WriteLine("{0} of {1}", card, i);
                }
            }
            Console.WriteLine();
            // 4. <end>

                       
            // 10. Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers.
            Console.Write("Please enter a positive integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            int z = 1;

            //Rows
            for (int x = 1; x <= n; x++)
            {
                // Columns
                for (int y = 1; y <= n; y++, z++)
                {
                    Console.Write(z + "\t");
                }
                Console.WriteLine();
                z = 1;
                z += x;
            }
            Console.ReadLine();
            // 10. <end>
            

            // 16.Write a program that by a given integer N prints the numbers from 1 to N in random order.

            Console.Write("Please enter an integer: ");
            int userInteger = Int32.Parse(Console.ReadLine());
            // Create array with max length provided by the user input.
            int[] numArray = Enumerable.Range(1, userInteger).ToArray();
            // Declare random int, then sort the array.
            Random rngInt = new Random();
            numArray = numArray.OrderBy(x => rngInt.Next()).ToArray();
            // Display each item in the Array
            foreach (int i in numArray)
            {
                Console.Write(i);
            }


        }
    }
}
