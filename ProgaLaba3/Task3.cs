using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgaLaba3
{
    class Task3 : Base
    {
        public void LINQ()
        {
            Create();

            Console.WriteLine();

            int count = (from n in nums where n > 0 select n).Count();
            Console.WriteLine($"Количество положительных чисел: {count}");

            int sum = (from n in nums where n < 0 select n).Sum();
            Console.WriteLine($"Сумма отрицательных элементов: {sum}");
        }
    }
}
