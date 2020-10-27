using System;

namespace cipher
{
    public class Program
    {
        // Creating Caesar cipher - encryption
        public string caesar_encrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char let = buffer[i];
                if (let == ' ') continue; // passes on a space symbol
                // Checks whether the symbol is a upper / lower case letter or a symbol or a number and acts accordingly
                if ((let <= 'z') && (let >= 'a')) let = (char)((let - 'a' + shift) % 26 + 'a');
                else if ((let >= 'A') && (let <= 'Z')) let = (char)((let - 'A' + shift) % 26 + 'A');
                else if ((let >= '!') && (let <= '@')) let = (char)((let - '!' + shift) % 32 + '!');
                buffer[i] = let;
            }
            return new string(buffer);
        }
        // Creating Caesar cipher - decryption
        public string caesar_decrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char let = buffer[i];
                if (let == ' ') continue; // passes on a space symbol
                // Checks whether the symbol is a upper / lower case letter or a symbol or a number and acts accordingly
                // Redefined modulus operation (using modulus operator twice) so that the modulus can work with negative numbers
                if ((let <= 'z') && (let >= 'a')) let = (char)((((let - 'a' - shift) % 26) + 26) % 26 + 'a');
                else if ((let <= 'Z') && (let >= 'A')) let = (char)((((let - 'A' - shift) % 26) + 26) % 26 + 'A');
                else if ((let <= '@') && (let >= '!')) let = (char)((((let - '!' - shift) % 32) + 32) % 32 + '!');
                buffer[i] = let;
            }
            return new string(buffer);
        }
        static void Main(string[] args)
        {
            string a = "This is a sentence! Greetings, everyone.";
            Program pr = new Program();
            Console.WriteLine(pr.caesar_encrypt(a,20) + " -> encrypted text.");
            Console.WriteLine(pr.caesar_decrypt(pr.caesar_encrypt(a, 20), 20) + " -> decrypted text.");
        }
    }
}
