using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Abstraction
{
   public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public abstract void Test();
    }
}
