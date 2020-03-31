using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgaLaba3
{
    class Task2 : Base
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string> { };

        public override void Create()
        {
            string path = @"C:\Users\Lenovo\Desktop\names.txt";
            string text = File.ReadAllText(path);
            string[] names = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < 10; i++)
            {
                int name = rnd.Next(0, names.Length);
                dictionary.Add(i, names[name]);
            }

            foreach (KeyValuePair<int, string> c in dictionary)
                Console.WriteLine(c.Key + "-" + c.Value);
        }

        public void DictionaryAnalysis()
        {
            Create();
            List<string> repetition = new List<string> { };

            for (int j = 0; j < dictionary.Count; j++)
            {
                for (int i = 0; i < dictionary.Count; i++)
                {
                    if (dictionary[j] == dictionary[i] && j != i)
                    {
                        repetition.Add(dictionary[i]);
                    }
                }
            }

            if (repetition.Count != 0)
                    {
                repetition = repetition.Distinct().ToList();
                    
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < repetition.Count; i++)
                    {
                        if (dictionary[j] == repetition[i])
                        {
                            dictionary.Remove(j);
                            break;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Повторяющиеся элементы: ");
                foreach (string s in repetition)
                    Console.WriteLine(s + " ");

                Console.WriteLine();

                Console.WriteLine("Измененный словарь:");
                foreach(KeyValuePair<int, string> t in dictionary)
                Console.WriteLine(t.Key + "-" + t.Value);
            }

            else Console.WriteLine("Все элементы уникальны.");
        }
    }
}
