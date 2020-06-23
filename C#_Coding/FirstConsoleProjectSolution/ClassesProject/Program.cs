using System;
using System.Net.NetworkInformation;

namespace ClassesProject
{
    class Animal {
        //Class variables
        public static int count = 0;
        public string name;
        public int age;
        public float happiness;

        //Constructors
        public Animal() {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            count++;
        }
        public Animal(string _name, int _age, float _happiness) {

            name = _name;
            age = _age;
            happiness = _happiness;
            
            count++;
        }

        //Class methods
        public void Print() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }   
    class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr. Beans", 10, 0.6f);
            cat.Print();

            Console.WriteLine();
            Console.WriteLine("Num of animals: " + Animal.count);

            Console.ReadKey();
        }
    }

}
