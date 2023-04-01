using System;
using System.Collections.Generic;
using System.Text;

namespace BelovLab7
{
    // Animals
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
            if (food is Bone) Console.WriteLine($"{food} is a bone!");
            if (food is  Hay) Console.WriteLine($"{this.name} refuses to eat hay!");
            else base.Eat(food);
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

    // Foods
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
        string fishType;
        public Fish(string name = "Fish", int hungrinessRestore = 10, string fishType = "Koi") : base(name, hungrinessRestore)
        {
            this.fishType = fishType;
        }
    }
    class Bone : Food
    {
        int boneHardness;
        public Bone(string name = "Bone", int hungrinessRestore = 0, int boneHardness = 10) : base(name, hungrinessRestore)
        {
            this.boneHardness = boneHardness;
        }
    }

    class Hay : Food
    {
        int hayFreshness;
        public Hay(string name = "Fish", int hungrinessRestore = 10, int hayFreshness = 1000) : base(name, hungrinessRestore)
        {
            this.hayFreshness = hayFreshness;
        }
    }


    // Controller has animal creation and feeding in it
    class Controller
    {
        static void Feed(Animal animal, Food food)
        {
            animal.Eat(food);
        }

        public static void RunSim()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Horse horse = new Horse();

            Fish fish = new Fish();
            Bone bone = new Bone();
            Hay hay = new Hay();

            Feed(cat, fish);
            Feed(dog, bone);
            Feed(horse, hay);
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Controller.RunSim();
        }
    }
}
