using System;

namespace cipher
{
    public class Program
    {
        // Creating Caesar cipher - encryption
        public string caesar_encrypt(string text, int shift)
        {
            int shift_aA = shift, shift_1 = shift;
            if (shift <= 0)
            {
                shift_aA = (shift % 26+26)%26;
                shift_1 = (shift % 32+32)%32;
            }
            char[] buffer = text.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char let = buffer[i];
                if (let == ' ') continue; // passes on a space symbol
                // Checks whether the symbol is a upper / lower case letter or a symbol or a number and acts accordingly
                if (char.IsLower(let))
                {
                    let = (char)((let - 'a' + shift_aA) % 26 + 'a');
                }
                else if (char.IsUpper(let))
                {
                    let = (char)((let - 'A' + shift_aA) % 26 + 'A');
                }
                else if ((let >= '!') && (let <= '@'))
                {
                    let = (char)((let - '!' + shift_1) % 32 + '!');
                }
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
                if (char.IsLower(let)) let = (char)((((let - 'a' - shift) % 26) + 26) % 26 + 'a');
                else if (char.IsUpper(let)) let = (char)((((let - 'A' - shift) % 26) + 26) % 26 + 'A');
                else if ((let <= '@') && (let >= '!')) let = (char)((((let - '!' - shift) % 32) + 32) % 32 + '!');
                buffer[i] = let;
            }
            return new string(buffer);
        }
        static void Main(string[] args)
        {
            string a = "I am an Encryption Bot. Hi! 1 5 90";
            Program pr = new Program();
            Console.WriteLine(pr.caesar_encrypt(a,-50) + " -> encrypted text.");
            Console.WriteLine(pr.caesar_decrypt(pr.caesar_encrypt(a,-50), -50) + " -> decrypted text.");
        }
    }
}
