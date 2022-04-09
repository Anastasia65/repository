using System;

namespace AtbashCipher
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter message: ");
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

            Console.WriteLine("Encripted message: " + result);
            Console.WriteLine();

            Console.WriteLine("Enter encripted message: ");
            string Input = Console.ReadLine();
            string res = "";
            foreach (char c in Input)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (c == Alphabet[i])
                    {
                        res += Alphabet[Alphabet.Length - 1 - i];

                    }
                    if (c == AlphabetUpper[i])
                    {
                        res += AlphabetUpper[AlphabetUpper.Length - 1 - i];

                    }
                }
            }
            Console.WriteLine("Decripted message: " + res);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
