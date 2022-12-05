using System;
using System.Collections.Generic;
using System.Text;

namespace elso_ora
{

    class SomeClass
    {

        public static int NumberOfClasses;

        public SomeClass()
        {
            NumberOfClasses++;
        }

        ~SomeClass()
        {
            NumberOfClasses--;
        }
    }
}
