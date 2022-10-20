using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Polymorhfism
{
    class Animal
    {
        public string Name { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
