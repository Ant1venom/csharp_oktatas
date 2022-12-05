using System;
using System.Collections.Generic;

namespace elso_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000000;
            int prev = 0;
            for (int i = 0; i < max; i++)
            {
                var newClass = new SomeClass();
                SomeClass newClass2 = new();
                if (SomeClass.NumberOfClasses < prev)
                {
                    break;
                }
                prev = SomeClass.NumberOfClasses;
            }

            Console.WriteLine(SomeClass.NumberOfClasses);
        }
    }
}
