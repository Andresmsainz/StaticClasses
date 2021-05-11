using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Classes!");

            // Error on creating a new instance of static class
            //Animal animal = new Animal;

            //Access Directly
            Animal.GetAge();
        }
    }

    static class Animal
    {
        static public string name;
        static public void GetAge()
        {
            Console.WriteLine("Age = " + (DateTime.Now.Year - DateTime.Now.AddYears(-2).Year));
        }
    }
}
