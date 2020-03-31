using System;

namespace ProgaLaba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            task1.ListAnalysis();

            Task2 task2 = new Task2();
            task2.DictionaryAnalysis();

            Task3 task3 = new Task3();
            task3.LINQ();
        }
    }
}
