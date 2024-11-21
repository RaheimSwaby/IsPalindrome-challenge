using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace IsPalindrome_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Is it a palindrome======= ");
            Console.WriteLine(" how many words would you like to check");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] inputs = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the words you would like to check {i+1}:");
                inputs[i] = Console.ReadLine();
            }

            Console.WriteLine("the words are as follows");

            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine(inputs[i]);
            }

            for (int i = 0;i < size; i++)
            {
                string word = inputs[i];
                if (Ispalindrome(word))
                {
                    Console.WriteLine($"{word} is a palindrome");
                }
                else 
                {
                    Console.WriteLine($"{word} is NOT a palindrome");
                }
                
            }

            

            static bool Ispalindrome(string word)
            {
                int n = word.Length;

                for (int i = 0; i < n; i++)
                {
                    if (word[i] != word[n - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }




                
            

        }
    }
}
