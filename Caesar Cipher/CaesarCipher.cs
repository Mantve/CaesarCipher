using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    public class CaesarCipher
    {
        //Ranges of characters that are shifted by the cipher
        static readonly CharacterRanges[] characterRanges = {
            new CharacterRanges('a', 'z'),
            new CharacterRanges('A', 'Z')
        };

        /// <summary>
        /// Ciphers the string with the Ceasar cipher algorithm
        /// </summary>
        /// <param name="line">The string to cipher</param>
        /// <param name="shift">Ceasar shift to right</param>
        /// <returns>New string shifted by the specified amount</returns>
        public static string Cipher(string line, int shift)
        {
            StringBuilder builder = new();
            for (int i = 0; i < line.Length; i++)
                builder.Append(ShiftChar(line[i], shift));

            return builder.ToString();
        }

        /// <summary>
        /// Deciphers the string with the Ceasar cipher algorithm
        /// </summary>
        /// <param name="line">The string to decipher</param>
        /// <param name="shift">Ceasar shift to the left</param>
        /// <returns>New string shifted by the specified amount to the opposite direction</returns>
        public static string Decipher(string line, int shift)
        {
            return Cipher(line, -shift);
        }

        /// <summary>
        /// Shifts a single character and overlaps it in specified ranges 
        /// </summary>
        /// <param name="character">A character to shift</param>
        /// <param name="shift">The amount to shift the character to the right</param>
        /// <returns>New character shifted to the right</returns>
        static char ShiftChar(char character, int shift)
        {
            foreach (CharacterRanges range in characterRanges)
            {
                if (character >= range.Floor && character <= range.Ceiling)
                {
                    //True offset of the new character
                    int offset = (character - range.Floor + shift) % (range.Ceiling - range.Floor + 1);
                    //Add ceiling if offset is negative
                    return (char)(offset < 0 ? offset + range.Ceiling + 1 : offset + range.Floor);
                }
            }
            return character;
        }
    }
}
