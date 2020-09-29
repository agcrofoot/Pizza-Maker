using System;

namespace fall_2020_starter_code
{
    public abstract class Pizza
    {
        public string Size{get; set;}
        public string Description{get; set;}

        public Pizza()
        {
            Description = "Unknown pizza";
        }
        public virtual string GetDescription()
        {
            return Size + " " + Description;
        }

        public virtual void SetSize(string size)
        {
            Size = size;
        }

        public virtual string GetSize()
        {
            return Size;
        }
        public abstract double Cost();
    }

}