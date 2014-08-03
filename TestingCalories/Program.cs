using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many calories did you burn today?");
            string caloriesBurned = Console.ReadLine();
            Console.WriteLine("How many calories did you eat today?");
            string caloriesEaten = Console.ReadLine();

            int outCalories;
            bool isValid = int.TryParse(caloriesBurned, out outCalories);
            int inCalories;
            bool isValidTwo = int.TryParse(caloriesEaten, out inCalories);
            if ((isValid) && (isValidTwo))
            {
                int calorieDeficit;
                int calorieSurplus;


                if (outCalories > inCalories)
                {
                    calorieDeficit = outCalories - inCalories;
                    Console.WriteLine("You reached a calorie deficit of {0}", calorieDeficit);
                }
                else if (outCalories < inCalories)
                {
                    calorieSurplus = inCalories - outCalories;
                    Console.WriteLine("You reached a calorie surplus of {0}", calorieSurplus);
                }
                else if (outCalories == inCalories)
                {
                    Console.WriteLine("You ate exactly as many calories as you burned!");
                }
                else
                {
                    Console.WriteLine("Something went wrong! Please check your input!");
                }
            }
            Console.ReadLine();
        }
    }
}
