﻿using System;

namespace MyFirstCat
{
    class AnimalShelter
    {
        private List<Cat> _Animals;
        public List<Cat> Animals
        {
            get { return _Animals; }
            set
            {
                if (_Animals == value) return;
                _Animals = value;
            }
        }
        public AnimalShelter()
        {
            Animals = new List<Cat>();
        }
        public void printAnimalShelter()
        {
            Console.WriteLine("\nThe Shelter in Dornbirn contains:");
            foreach (var animal in Animals)
            {
                //Console.WriteLine($"A {animal.Color} cat that is {animal.Age} years old and is called {animal.Name}");
                Console.WriteLine(animal.ToString());
            }
        }
    }
}