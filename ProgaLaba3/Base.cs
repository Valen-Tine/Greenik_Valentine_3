using System;
using System.Collections.Generic;
using System.Text;

namespace ProgaLaba3
{
    class Base
    {
        public Random rnd = new Random();
        public List<int> nums = new List<int> {};

        public virtual void Create()
        {
            for (int i = 0; i < 10; i++)
            {
                int n = rnd.Next(-10, 10);
                nums.Add(n);
                Console.Write(n + " ");
            }
        }
    }
}
