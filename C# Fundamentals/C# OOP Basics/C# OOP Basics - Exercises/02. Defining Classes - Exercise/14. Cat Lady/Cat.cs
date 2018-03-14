using System;

namespace _14.Cat_Lady
{
    public class Cat
    {
        public Cat(string breed, string name)
        {
            this.Breed = breed;
            this.Name = name;
            this.Decibels = null;
            this.EarSize = null;
            this.FurLength = null;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public double? EarSize { get; set; }
        public double? FurLength { get; set; }
        public double? Decibels { get; set; }

        public override string ToString()
        {

            if (!this.EarSize.Equals(null))
            {
                return string.Concat($"{this.Breed} {this.Name} " + (int)this.EarSize);
            }
            else if (!this.FurLength.Equals(null))
            {
                return string.Concat($"{this.Breed} {this.Name} {this.FurLength:f2}");
            }
            else
            {
                return string.Concat($"{this.Breed} {this.Name} " + (int)this.Decibels);
            }

            throw new Exception(string.Format("Ivalid"));
        }
    }
}