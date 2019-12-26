using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPractice
{
    class DictionaryTest
    {
        public string DictionaryPractice()
        {
            Dictionary<string, string> dictonary = new Dictionary<string, string>();
            Dictionary<string, string> dictonaryDuplicate = new Dictionary<string, string>();
            for (int i = 1; i <= 5; i++)
            {
                dictonary.Add(i.ToString(), RandomNumber());
            }
            for (int j = 1; j <= 5; j++)
            {
                dictonaryDuplicate.Add(j.ToString(), RandomNumber());
            }

            var duplicateList = dictonary.Where(kvp => dictonaryDuplicate.ContainsValue(kvp.Value)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.ReadLine();
            return "";
        }

        public string RandomNumber()
        {
            var randomNumber = new Random();
            return randomNumber.Next(1, 10).ToString();
        }

    }
}
