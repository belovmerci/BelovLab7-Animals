using System;
using System.Collections.Generic;
using System.Text;

namespace BelovLab7
{
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
        public Hay(string name = "Hay", int hungrinessRestore = 10, int hayFreshness = 1000) : base(name, hungrinessRestore)
        {
            this.hayFreshness = hayFreshness;
        }
    }

}

