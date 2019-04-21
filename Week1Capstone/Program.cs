using System;

namespace Capstone_1_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Let's convert a word to Pig Latin.\n");
            string response;

            do
            {
                Console.WriteLine("Please enter a word: ");
                var userInput = Console.ReadLine();

                var lowerUserInput = ConvertToLower(userInput);

                var userPigLatin = ToPigLatin(lowerUserInput);
                Console.WriteLine(userPigLatin);

                Console.WriteLine("Would you like to convert another another word: Yes or No");
                response = Console.ReadLine();

            } while (response == "y" || response == "Y" || response == "Yes" || response == "yes");
        }

        public static string ConvertToLower(string a)
        {
            var converted = a.ToLower();
            return converted;
        }

        public static string ToPigLatin(string b)
        {
            string firstLetter, restWord;
            string vowels = "AEIOUaeiou";
            int currentLetter;

            foreach (var word in b.Split())
            {
                firstLetter = b.Substring(0, 1);
                restWord = b.Substring(1, b.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    b = restWord + firstLetter + "ay";
                    return b;
                }
                else
                {
                    b = word + "way";
                    return b;
                }
            }

            var empty = "";
            return empty;
        }
    }
}
