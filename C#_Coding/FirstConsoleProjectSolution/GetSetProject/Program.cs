using System;
using System.Dynamic;
using System.Xml.Serialization;

namespace GetSetProject
{
    class Program
    {
        class Player {
            private int maxHealth = 100;
            
            private int _health = 100;
            public int health 
            {
                get {
                    return _health;
                }
                set {
                    if (value <= 0)
                    {
                        _health = 0;
                    }
                    else if (value >= maxHealth)
                    {
                        _health = maxHealth;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }

            public void Damage(int _dmg) {
                _health -= _dmg;
            }
        }
        public static void Main(string[] args) {
            Player tom = new Player();
            tom.health -= 200;
            Console.WriteLine("Health: " + tom.health);
            tom.health += 400;
            Console.WriteLine("Health: " + tom.health);
            tom.health = 50;
            Console.WriteLine("Health: " + tom.health);


            Console.ReadKey();
        }
    }
}
