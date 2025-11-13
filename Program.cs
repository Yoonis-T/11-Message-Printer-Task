using System;


namespace _11___Message_Printer_Task
{
    internal class Program
    {
        
       
            static void Main()
            {
                // Frågar användaren om ett meddelande
                Console.WriteLine("Skriv ett meddelande:");
                string text = Console.ReadLine();

                // Skriver ut meddelandet som det är
                Console.WriteLine("\nOriginal:");
                Console.WriteLine(text);

                // Skriver ut meddelandet baklänges
                Console.WriteLine("\nBaklänges:");
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }

                // Skriver ut varje bokstav på ny rad
                Console.WriteLine("\n\nBokstav för bokstav:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
    

