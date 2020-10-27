using Microsoft.VisualStudio.TestTools.UnitTesting;
using cipher;
using System;
using System.Collections.Generic;
using System.Text;

namespace cipher.Tests_for_encryption_decryption
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void caesar_encrypt_Test1()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION, POSITIVE SHIFT
            string x = "this is a sentence";
            int shift = 28;
            string expected = "vjku ku c ugpvgpeg";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_encrypt_Test2()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION, POSITIVE SHIFT
            // Arrange - variables for the test
            string x = "This is a sentence! Greetings, everyone.";
            int shift = 15;
            string expected = "Iwxh xh p htcitcrt0 Vgttixcvh; tktgndct=";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_encrypt_Test3()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION, NEGATIVE SHIFT
            // Arrange - variables for the test
            string x = "This is a sentence! Greetings, everyone.";
            int shift = -25;
            string expected = "Uijt jt b tfoufodf( Hsffujoht3 fwfszpof5";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_decrypt_Test4()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION, POSITIVE SHIFT
            // Arrange - variables for the test
            string x = "S kw kx Oxmbizdsyx Lyd8 Rs+ ; ? #:";
            int shift = 10;
            string expected = "I am an Encryption Bot. Hi! 1 5 90";
            // Act - gets the decrypted variable from the decryption function
            var sut = new cipher.Program();
            var decrypted = sut.caesar_decrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, decrypted, "The text was decrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_decrypt_Test5()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION, NEGATIVE SHIFT
            // Arrange - variables for the test
            string x = "Q iu iv Mvkzgxbqwv Jwb< Pq/ ? # '>";
            int shift = -18;
            string expected = "I am an Encryption Bot. Hi! 1 5 90";
            // Act - gets the decrypted variable from the decryption function
            var sut = new cipher.Program();
            var decrypted = sut.caesar_decrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, decrypted, "The text was decrypted incorrectly.");
        }
    }
}