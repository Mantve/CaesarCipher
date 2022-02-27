using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher.Tests
{
    [TestClass()]
    public class CaesarCipherTests
    {
        [TestMethod()]
        public void CipherTest()
        {
            int shift = 1;
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string expected = "bcdefghijklmnopqrstuvwxyzaBCDEFGHIJKLMNOPQRSTUVWXYZA";
            Assert.AreEqual(expected, CaesarCipher.Cipher(input, shift));
        }

        [TestMethod()]
        public void CipherOverflowTest()
        {
            int shift = 29;
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string expected = "defghijklmnopqrstuvwxyzabcDEFGHIJKLMNOPQRSTUVWXYZABC";
            Assert.AreEqual(expected, CaesarCipher.Cipher(input, shift));
        }

        [TestMethod()]
        public void DecipherTest()
        {
            int shift = 2;
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string expected = "yzabcdefghijklmnopqrstuvwxYZABCDEFGHIJKLMNOPQRSTUVWX";
            Assert.AreEqual(expected, CaesarCipher.Decipher(input, shift));
        }

        [TestMethod()]
        public void DecipherOverflowTest()
        {
            int shift = 58;
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string expected = "uvwxyzabcdefghijklmnopqrstUVWXYZABCDEFGHIJKLMNOPQRST";
            Assert.AreEqual(expected, CaesarCipher.Decipher(input, shift));
        }

        [TestMethod()]
        public void CipherIgnoredCharsTest()
        {
            int shift = 18;
            string input = "1234567890ąčęėįšųūабвгд[]`'";
            string expected = "1234567890ąčęėįšųūабвгд[]`'";
            Assert.AreEqual(expected, CaesarCipher.Cipher(input, shift));
        }

        [TestMethod()]
        public void DecipherIgnoredCharsTest()
        {
            int shift = 5;
            string input = "1234567890ąčęėįšųūабвгд[]`'";
            string expected = "1234567890ąčęėįšųūабвгд[]`'";
            Assert.AreEqual(expected, CaesarCipher.Decipher(input, shift));
        }
    }
}