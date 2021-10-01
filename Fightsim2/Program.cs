using System;

namespace Fightsim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();
            Role f1Role = new Role();
            Fighter f2 = new Fighter();
            Role f2Role = new Role();
            while (f1.hp < 80){
                Console.WriteLine("Pick a role: 1. Mage 2. Tank 3. Knight");
                Console.WriteLine("Mage: High damage low HP     Tank: High HP low damage    Knight: Balanced HP and damage");
                string Role = Console.ReadLine();
                Role.ToLower();
                if (Role == "1" || Role == "mage"){
                    f1.hp = f1Role.MageHp;
                }
                else if (Role == "2" || Role == "tank"){
                    f1.hp = f1Role.TankHp;
                }
                else if (Role == "3" || Role == "knight"){
                    f1.hp = f1Role.KnightHp;
                }
            }
            Console.ReadLine();
        }
    }
}
