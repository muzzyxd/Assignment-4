using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        public class Animal
        {
         
            protected string name;
            protected int age;

            
            public Animal(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

          
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }

        
        public class Dog : Animal
        {
            
            public Dog(string name, int age) : base(name, age) { }

            
            public void Bark()
            {
                Console.WriteLine("Woof!");
            }
        }

        
        public class Cat : Animal
        {
            
            public Cat(string name, int age) : base(name, age) { }

            
            public void Meow()
            {
                Console.WriteLine("Meow!");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 5);
            dog.DisplayInfo(); 
            dog.Bark();        

            
            Cat cat = new Cat("Munchkin", 3);
            cat.DisplayInfo(); 
            cat.Meow();

            Console.ReadLine();
        }
    }
}
