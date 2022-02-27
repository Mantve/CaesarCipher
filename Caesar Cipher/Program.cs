using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            (string, int) cipherVars;

            while (true)
            {
                Console.WriteLine("Select a mode: C - Cipher, D - Decipher, E - Exit the program");
                string option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "E":
                        return;
                    case "D":
                        cipherVars = ReadLineShift();
                       Console.WriteLine("Deciphered string: {0}\n", CaesarCipher.Decipher(cipherVars.Item1, cipherVars.Item2));
                        break;
                    case "C":
                        cipherVars = ReadLineShift();
                        Console.WriteLine("Ciphered string: {0}\n", CaesarCipher.Cipher(cipherVars.Item1, cipherVars.Item2));
                        break;
                }
            }
        }

        /// <summary>
        /// Get Caesar cipher inputs from the console
        /// </summary>
        /// <returns>Input string and shift</returns>
        static (string, int) ReadLineShift()
        {
            int shift;
            Console.Write("Enter the string: ");
            string line = Console.ReadLine();
            Console.Write("Enter the shift of the cipher: ");

            while (!Int32.TryParse(Console.ReadLine(), out shift))
            {
                Console.Write("Incorrect format. Enter the shift of the cipher in numbers: ");
            }
            return (line, shift);
        }
    }
}
