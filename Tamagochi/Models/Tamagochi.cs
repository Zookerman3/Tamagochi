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
                if (animal.Name.Equals(petName))
                {
                    food += 2;
                    animal.Food = food;
                }
                Console.WriteLine(animal.Food);
            }
        }

         public static void PraisePet(string petName, int attention)
        {
            Console.WriteLine(attention + "__________________-");
            foreach (Tamagochi animal in _instances)
            {
                if (animal.Name.Equals(petName))
                {
                    attention += 2;
                    animal.Attention = attention;
                }
                Console.WriteLine(animal.Attention);
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
                }
                Console.WriteLine(animal.Rest);
            }
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
