using System;

namespace cipher
{
    class Program
    {
        // Creating Caesar cipher - encryption
        public string caesar_encrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char let = buffer[i];
                if (let == ' ') continue;
                if ((let <= 'z') && (let >= 'a')) let = (char)((let - 'a' + shift) % 26 + 'a');
                else if ((let >= 'A') && (let <= 'Z')) let = (char)((let - 'A' + shift) % 26 + 'A');
                else if ((let >= '!') && (let <= '@')) let = (char)((let - '!' + shift) % 32 + '!');
                buffer[i] = let;
            }
            return new string(buffer);
        }
        static void Main(string[] args)
        {
            string a = "this is a sentence";
            Program pr = new Program();
            Console.WriteLine(pr.caesar_encrypt(a,5) + " -> encrypted text.");
        }
    }
}
