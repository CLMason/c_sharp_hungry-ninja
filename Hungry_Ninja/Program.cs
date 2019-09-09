using System;
using System.Collections.Generic;

namespace Hungry_Ninja
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
    class Buffet
    {
        public List<Food> Menu;
 
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            { //Superbowl food 
                new Food("Pizza",390,false, false),
                new Food("Chicken Wings", 200, true, false),
                new Food("Salad", 400, false, false),
                new Food("Chili", 600, true, false),
                new Food ("Pigs in a Blanket", 100, false, false),
                new Food ("Cupcakes", 230, false, true), 
                new Food ("Ribs", 299, true, false), 
                new Food ("Mac N' Cheese", 340, false, false)
            };
        }
    
        public Food Serve()
        {
            Random randFood = new Random();
            int randIdx = randFood.Next(Menu.Count);
            // Console.WriteLine($"{Menu[randIdx].Name}");//testing random generator 
                return Menu[randIdx];
        }

    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        // add a constructor that sets calorieintake to 0 and create a new empty list of Food objects to FoodHistory
            public Ninja()
            {
                this.calorieIntake=0;
                this.FoodHistory = new List<Food>();
            }
        //add a public "getter" property called "IsFull"
        public bool isFull
        {
            get{ return calorieIntake > 1200;}
        }
 
        // build out the Eat method
        public void Eat(Food item)
        {
            //adds calorie value to ninja's total calorieIntake
            calorieIntake += item.Calories;

            // adds the randomly selected Food object to ninja's FoodHistory list
            FoodHistory.Add(item);//FoodHistory is a list and were using the "add" method to add a food object 

            // writes the Food's Name - and if it is spicy/sweet to the console
            Console.WriteLine("Name" + ": " + item.Name);
            Console.WriteLine("Spicy" + ": "+ item.IsSpicy);
            Console.WriteLine("Sweet" + ": " + item.IsSweet);

            // if the Ninja IS full
            // issues a warning to the console that the ninja is full and cannot eat anymore
            if(isFull)
            {
                Console.WriteLine($"Warning, Ninja is full and cannot eat anymore.");
            } 
            
        }
    }
    class Program 
    {static void Main(string[] args)
        {
            Buffet b1= new Buffet();//to create a new instance of a class, you typically invoke one of the constructors of that type using the "new" operator.
            b1.Serve();//prints out random food items 
            Ninja n1 = new Ninja ();//testing isFull method 
            for(int i = 0; i < 10;i++)
            {
                Console.WriteLine(n1.isFull);
                n1.Eat(b1.Serve());
            }

        }
    }
}
