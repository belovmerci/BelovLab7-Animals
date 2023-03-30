using System;
using System.Collections.Generic;
using System.Text;

namespace BelovLab7
{
    class Animal
    {
        public string name;
        public int hungriness;
        public string voiceSound;
        public Animal(string name = "Namey", int hungriness = 10, string voiceSound = "Growl")
        {
            this.name = name;
            this.hungriness = hungriness;
            this.voiceSound = voiceSound;
        }

        public virtual void Eat(Food food)
        {
            Console.Write($"{this.name} ate {food.name} and restored hungriness ({this.hungriness} -> ");
            this.hungriness += food.hungrinessRestore;
            Console.WriteLine($"{this.hungriness})");
        }

        public virtual void Voice()
        {
            Console.WriteLine($"{this.name} says {this.voiceSound}");
        }

        public virtual void Sleep()
        {
            Console.Write($"{this.name} slept and restored hungriness ({this.hungriness} -> ");
            this.hungriness += 10;
            Console.WriteLine($"{this.hungriness})");
        }
    }

    class Cat : Animal
    {
        int miceCaught;
        public Cat(string name = "Catto", int hungriness = 11, string voiceSound = "Meow", int miceCaught = 0) : base(name, hungriness, voiceSound)
        {
            this.miceCaught = miceCaught;
        }
        public override void Eat(Food food)
        {
            if (food.name == "Mouse") miceCaught++;
            base.Eat(food);
        }
    }

    class Dog : Animal
    {
        bool isGoodBoy = true;
        public Dog(string name = "Tuzik", int hungriness = 5, string voiceSound = "Woof") : base(name, hungriness, voiceSound)
        {
        }
        public override void Eat(Food food)
        {
            if (isGoodBoy) Console.WriteLine($"{this.name} is a good boy!");
            base.Eat(food);
        }
        public override void Voice()
        {
            if (isGoodBoy) Console.WriteLine($"{this.name} is a good boy!");
            base.Voice();
        }
    }

    class Horse : Animal
    {
        string residenceAddress;
        public Horse(string name = "Horso", int hungriness = 20, string voiceSound = "Neigh", string residenceAddress = "Wild") : base(name, hungriness, voiceSound)
        {
            this.residenceAddress = residenceAddress;
        }
        public override void Sleep()
        {
            Console.Write($"{this.name} slept in {this.residenceAddress} and restored hungriness ({this.hungriness} -> ");
            if (residenceAddress == "Wild") this.hungriness += 10;
            else this.hungriness += 15;
            Console.WriteLine($"{this.hungriness})");
        }
    }


    class Food
    {
        public string name;
        public int hungrinessRestore;
        public Food(string name = "Foodey", int hungrinessRestore = 5)
        {
            this.name = name;
            this.hungrinessRestore = hungrinessRestore;
        }
    }

    class Fish : Food
    {

    }
    class Bone : Food
    {

    }

    class Hay : Food
    {

    }


 
    class Controller
    {
        static void Feed(Animal animal, Food food)
        {
            animal.hungriness += food.hungrinessRestore;
        }

        public static void RunSim()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Controller.RunSim();
        }
    }
}
