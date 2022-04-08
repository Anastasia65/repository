using System;

namespace AtbashCipher
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter messages: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();


            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            string AlphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";


            foreach (char c in userInput)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (c == Alphabet[i])
                    {
                        result += Alphabet[Alphabet.Length - 1 - i];

                    }
                    if (c == AlphabetUpper[i])
                    {
                        result += AlphabetUpper[AlphabetUpper.Length - 1 - i];

                    }
                }

            }

            Console.WriteLine("Encoded messages: " + result);
            Console.WriteLine();

            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}