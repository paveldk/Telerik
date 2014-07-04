using System;
using System.Collections.Generic;


namespace Preparation
{
    class Program
    {
        static void Main()
        {
            // Лист
            List<string> words = new List<string>();

            words.Add("gosho");
            words.Add("pesho");

            words.Remove("gosho"); // Това е МНОГО БАВНО
            words.RemoveAt(0); // пак бавно

            //Хешсет
            HashSet<string> quickWords = new HashSet<string>();

            quickWords.Add("pesho");

            quickWords.Remove("pesho"); // Хеш сета е БЪРЗ, но няма индексация! НЕ е като масивите няма quickwords[0]

            // Хеш сета съдържа само уникални елементи:

            quickWords.Add("1");
            quickWords.Add("1");
            quickWords.Add("1");
            quickWords.Add("1");
            quickWords.Add("1");

            // Това ще добави само 1 единица!!! Ще ни е полезно ако искаме да намерим всички уникални думи - бутаме всичко и му вадим Count
            // Обикалянето му става с foreach

            quickWords.Contains("1"); // проверка дали го съдържа

            // SortedSet
            SortedSet<int> sortedInt = new SortedSet<int>();

            // каквото и да добавиме го добавя СОРТИРАНО

            sortedInt.Add(5);
            sortedInt.Add(1);
            sortedInt.Add(8);
            sortedInt.Add(4);
            sortedInt.Add(4);

            // отново ако е повече от веднъж добавено брои само уникалните

            foreach (var number in sortedInt)
            {
                Console.WriteLine(number);    
            }

            // Има опции за минимален и максимален елемент с Min Max, бачка и за стрингове

            // Dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("pesho", "550");

            string peshosResults = dict["pesho"];

            // Нещо като масив, но ние избираме какъв да е ключа!!

            Console.WriteLine(peshosResults);

            //има втори вариант за добавяне

            dict["pesho"] = "1050";

            Console.WriteLine(dict["pesho"]);

            int i = dict.Count;

            dict.ContainsKey("gosho");

            // Може да се използва при повтаряне на букви в текст примерно. Добавяме в dictionary "А","Б","В" и при намираме добавяме

            if (dict.ContainsKey("A"))
            {
                dict["A"] +=1;
            }
            else
            {
                dict["A"] = "1";
            }

            // SortedDictionary

            SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();

            // Същото като другото, но тук кючовете са сортирани!!!


        }
    }
}
