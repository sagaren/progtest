using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_Easy_Bots
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ta in en sträng med ord och kolla om nåt ord repeteras. Om det repeteras så returnera "no" och annars "yes"
            string inputLine = Console.ReadLine().ToLower(); 
            if (inputLine.Length < 80) 
            {
                Console.WriteLine(RepeatedWord(inputLine));
            }
            else
            {
                Console.WriteLine("The maximun length of the line is 80 characters. Try again!");
            }
        }

        public static string RepeatedWord (string inputLine)
        {
            string[] lineWithWords = inputLine.Split(' ');
            string yes = "yes";
            string no = "no";
            
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            foreach (var word in lineWithWords)
            {
                if (!uniqueWords.ContainsKey(word))
                {
                    uniqueWords.Add(word, 1);
                }

                else
                {
                    uniqueWords[word] += 1;
                }
            }

            if (uniqueWords.Where(i => i.Value != 1).Any())
            {
                return no;
            }

            else
            {
                return yes;
            }
          
        }
    }
}
