namespace ConsoleApp28
{
    internal class Program
    {
        static void Main()
        {
            string text = "Hello World!";
            Cipher cipher = new Cipher();

            string encryptedStr = cipher.Encode(text, 1);
            string decodeStr = cipher.Decode(encryptedStr, 1);

            Console.WriteLine($"Original string: {text}");
            Console.WriteLine($"Encrypted string: {encryptedStr}");
            Console.WriteLine($"Original string: {decodeStr}");
        }
        public interface ICipher
        {
            string Encode(string str, int key);
            string Decode(string str, int key);
        }
        public class Cipher : ICipher
        {
            public string Encode(string str, int key)
            {
                string encryptedString = "";
                for (int i = 0; i < str.Length; i++)
                {
                    encryptedString += (char)(str[i] + key);
                }
                return encryptedString;
            }
            public string Decode(string str, int key)
            {
                string decryptedString = "";
                for (int i = 0; i < str.Length; i++)
                {
                    decryptedString += (char)(str[i] - key);
                }
                return decryptedString;
            }
        }
    }
}
