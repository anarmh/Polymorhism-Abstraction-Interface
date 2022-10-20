using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Polymorhfism
{
    class Cow:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cow sound");
        }
        public void Eat()
        {
            Console.WriteLine("Cow grass eating");
        }
        public void Eat(string n)
        {
            Console.WriteLine("Cow straw eating");
        }
        public void Eat(string m,string v)
        {
            Console.WriteLine(m+""+v);
        }

    }
}
