using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgaLaba3
{
    class Task1 : Base
    {
        public void ListAnalysis()
        {
            Create();
            List<int> repetition = new List<int> { };
            nums.Sort();

            Console.WriteLine();
            for (int i = 1; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i - 1] || nums[i] == nums[i + 1])
                {
                    repetition.Add(nums[i]);
                }
            }
            repetition = repetition.Distinct().ToList();

            if (repetition.Count != 0)
            {
                Console.Write("В списке есть неуникальные элементы: ");
                foreach (int rep in repetition)
                    Console.Write(rep + " ");
            }
            else Console.WriteLine("Все элементы в списке уникальны.");
        }
    }
}
