using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Models
{
    sealed class Car
    {
        //public readonly string Name;
        public string  Name { get; private set; }

        public Car()
        {
            Name = "Mercedes";
        }
    }
}
