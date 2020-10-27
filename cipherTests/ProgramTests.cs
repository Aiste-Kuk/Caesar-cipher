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
        public void caesar_encrypt_Test()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION
            // Arrange - variables for the test
            string x = "this is a sentence";
            int shift = 5;
            string expected = "ymnx nx f xjsyjshj";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_encrypt_Test2()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION
            // Arrange - variables for the test
            string x = "This is a sentence! Greetings, everyone.";
            int shift = 20;
            string expected = "Nbcm cm u myhnyhwy5 Alyyncham@ ypylsihy\"";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
        [TestMethod()]
        public void caesar_decrypt_Test3()
        {
            //______________USING AAA PATTERN, TEXT ENCRYPTION
            // Arrange - variables for the test
            string x = "this is a sentence";
            int shift = 5;
            string expected = "ymnx nx f xjsyjshj";
            // Act - gets the encrypted variable from the encryption function
            var sut = new cipher.Program();
            var encrypted = sut.caesar_encrypt(x, shift);
            // Asert - checks if variables are equal, if not - throws an error
            Assert.AreEqual(expected, encrypted, "The text was encrypted incorrectly.");
        }
    }
}