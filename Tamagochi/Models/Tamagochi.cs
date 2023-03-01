using System.Collections.Generic;
using System;
namespace Game.Models
{
    public class Tamagochi
    {
        public string Name { get; set; }
        public int Food { get; set; }
        public int Attention { get; set; }
        public int Rest { get; set; }
        public int Id { get; }
        private static List<Tamagochi> _instances = new List<Tamagochi> { };

        public Tamagochi(string name, int food, int attention, int rest)
        {
            Name = name;
            Food = 10;
            Attention = 10;
            Rest = 10;
            _instances.Add(this);
        }

        public static void FeedPet(string petName, int food)
        {
            Console.WriteLine(food + "__________________-");

                foreach (Tamagochi animal in _instances)
                {
                    if (animal.Name.Equals(petName) && animal.Food <= 0)
                    {
                        food += 2;
                        animal.Food = food;
                        break;
                    }
                    else 
                    Console.WriteLine(animal.Food);
                }
        }
        public static void PraisePet(string petName, int attention)
        {
            Console.WriteLine(attention + "__________________-");
            foreach (Tamagochi animal in _instances)
            {
                while (attention > 5)
                {
                    if (animal.Name.Equals(petName))
                    {
                        attention += 2;
                        animal.Attention = attention;
                    }
                    return;
                }
            }
        }

        public static void RestPet(string petName, int rest)
        {
            Console.WriteLine(rest + "__________________-");
            foreach (Tamagochi animal in _instances)
            {
                if (animal.Name.Equals(petName))
                {
                    rest += 2;
                    animal.Rest = rest;
                } else isDead(animal.Name);
                Console.WriteLine(animal.Rest);
            }
        }

        public static void isDead(string animal)
        {
            Console.WriteLine(animal);
        }
        public static List<Tamagochi> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Tamagochi Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}

//     else if (animal.Attention <= 5)
//     {
//         _instances.RemoveAt(_instances.IndexOf(animal));
//         return;
//     }
// }