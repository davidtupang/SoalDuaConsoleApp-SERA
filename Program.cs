using System;

namespace SoalDuaConsoleApp_SERA
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();
            if (input.Equals(""))
            {
                Console.WriteLine("Harap Input String, Tidak boleh kosong");
            }
            else
            {
                bool isPalindrome = IsPalindrome(input);

                Console.WriteLine($"Apakah \"{input}\" merupakan palindrome? : {isPalindrome}");
            }
        }

        static bool IsPalindrome(string str)
        {
            string checkString = str.Replace(" ", "").ToLower();

            int length = checkString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (checkString[i] != checkString[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
