using System;


namespace _11___Message_Printer_Task
{
    internal class Program
    {
        
       
        static void Main()
        {
            // 1. Be användaren skriva in ett meddelande
            Console.WriteLine("Please enter the message: C# is fun, I am going to code C# tomorrow");
            string message = Console.ReadLine();


            // 2. Skriv ut meddelandet i original ordning
            Console.WriteLine("\nOriginal Order:");
            Console.WriteLine(message);


            // 3. Skriv ut meddelandet i omvänd ordning
            Console.WriteLine("\nReverse Order:");
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            string reversedMessage = new string(messageArray);
            Console.WriteLine(reversedMessage);


            // 4. Skriv ut varje bokstav på ny rad
            Console.WriteLine("\nLetter by Letter:");
            foreach (char c in message)
            {
                Console.WriteLine(c);
            }

            // 5. Skriv ut varje bokstav i omvänd ordning på ny rad
            Console.WriteLine("\nReversed Letter by Letter:");
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}
    

