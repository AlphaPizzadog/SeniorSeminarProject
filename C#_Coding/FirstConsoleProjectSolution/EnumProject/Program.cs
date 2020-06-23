using System;

namespace EnumProject
{

    class Project
    {
        public enum Breed {Bulldog, Boxer, Chihuahua, Briard, Labrador}

        //Base class
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

        }

        //Derived class
        class Dog:Animal 
        {
            public Breed breed;

            public Dog(string _name, int _age, float _happiness, Breed _breed)
            {
                name = _name;
                age = _age;
                happiness = _happiness;

                breed = _breed;
            }

            public void Print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
                
                Console.WriteLine("Breed: " + breed);
            }
        }
        
        public static void Main(string[] args) 
        {
            Dog hulk = new Dog("Hulk", 6, 0.7f, Breed.Chihuahua);
            hulk.Print();
            
            Console.ReadKey();
        }
    }
}
