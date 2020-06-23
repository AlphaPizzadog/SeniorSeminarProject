using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceProject
{
    class Program
    {
        interface IItem { 
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }

        interface IDamageable
        {
            int durability { get; set; }

            void TakeDamage(int _amount);
        }

        interface IPartOfQuest
        {
            void TurnIn();
        }

        class Sword : IItem, IDamageable, IPartOfQuest
        { 
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Sword(string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 50;
            }

            public void Equip() {
                Console.WriteLine(name + " equipped.");
            }
            public void Sell() {
                Console.WriteLine(name + " sold for " + goldValue + " gold.");
            }

            public void TakeDamage(int _dmg) 
            {
                durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + "! It now has a durability of " + durability + ".");
            }
            public void TurnIn() 
            {
                Console.WriteLine(name + " turned in.");
            }
        }
        class Axe : IItem, IDamageable, IPartOfQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Axe(string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 50;
            }

            public void Equip()
            {
                Console.WriteLine(name + " equipped.");
            }
            public void Sell()
            {
                Console.WriteLine(name + " sold for " + goldValue + " gold.");
            }

            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + "! It now has a durability of " + durability + ".");
            }
            public void TurnIn()
            {
                Console.WriteLine(name + " was begrudgingly handed over.");
            }
        }

        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(20);
            sword.Sell();
            
            Console.WriteLine();

            Axe axe = new Axe("Axe of Fury");
            axe.Equip();
            axe.TakeDamage(20);
            axe.Sell();

            Console.WriteLine();
            
            //Create an inventory

            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            //loop through and turn in all quest items
            for (int i = 0; i < inventory.Length; i++)
            {
                IPartOfQuest questItem = inventory[i] as IPartOfQuest;
                if (questItem != null) 
                {
                    questItem.TurnIn();
                }
            }
            
            Console.ReadKey();
        }
    }
}
