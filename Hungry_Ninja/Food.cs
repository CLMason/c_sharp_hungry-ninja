using System;

namespace Foods
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food (string name, int calories, bool IsSpicy, bool IsSweet)
        {
            this.Name= name; 
            this.Calories = calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }
    }
}