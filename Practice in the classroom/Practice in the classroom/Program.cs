using Practice_in_the_classroom.Abstraction;
using Practice_in_the_classroom.Models;
using Practice_in_the_classroom.Polymorhfism;
using Practice_in_the_classroom.Services.Implementation;
using Practice_in_the_classroom.Services.Interface;
using System;

namespace Practice_in_the_classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //Console.WriteLine(car1.Name);
            //Animal animal = new Animal();
            //animal.Sound();

            //Cow cow = new Cow();
            //cow.Sound();

            //Bird bird = new Bird();
            //bird.Sound();

            //Student student = new Student();
            //student.Test();
            //Employee employee = new Employee();
            //employee.Test();

            //IUser user = new User();
            //user.Login("Huseynov", "Anar");

            IAccountService accountService = new AccountService();
            accountService.Register();
        }
        
    }
}
