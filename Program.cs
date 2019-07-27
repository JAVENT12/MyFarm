using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Program
    {
        public static void makeFarm()
        {
            Cow cow1 = new Cow("Big Bertha", "MOOO!!!", "Grass", "Jeep Wrangler");
            Cow cow2 = new Cow("Daisy", "MOOO!!!", "McDonalds", "Boats");        //The cows
            Cow cow3 = new Cow("Billy", "MOOO!!!", "Subway", "Oranges");
            Cow cow4 = new Cow("William", "MOOO!!!", "KFC", "Bananas");

            Horse horse1 = new Horse("Mr.Ed", "Hello", "Hay", "Airplanes");
            Horse horse2 = new Horse("Mr.Johnson", "Hello", "Chocolate", "Lumber");   //The horses
            Horse horse3 = new Horse("Mr.Middleton", "Hello", "Ice Cream", "Oil");
            Horse horse4 = new Horse("Mr.Jenkins", "Hello", "Bread", "Iron");

            Pig pig1 = new Pig("Steven", "Oink!", "sushi", "bananas");
            Pig pig2 = new Pig("Wilbur", "Oink!", "salads", "silver");        //The pigs
            Pig pig3 = new Pig("Kyle", "Oink!", "burritos", "internet");
            Pig pig4 = new Pig("Chad", "Oink!", "tacos", "gasoline");

            Chicken chicken1 = new Chicken("Mr. Cluckles", "Hola", "seeds", "Chicken-Fil-a");
            Chicken chicken2 = new Chicken("Mr. Smith", "Hola", "peanut butter", "KFC");      //The chickens
            Chicken chicken3 = new Chicken("Mr. Brad", "Hola", "bacon", "brea");
            Chicken chicken4 = new Chicken("Mr. Tyler", "Hola", "beef jerky", "Wal-Mart");

            string retry = "No";

            do
            {
                Console.WriteLine("\n\tWhat animal would you want to meet?");
                Console.WriteLine("\n\tYou can meet my Horse, Cow, Chicken, or Pig!");
                string animal = Console.ReadLine();
                switch (animal)
                {
                    case "Horse":
                        horse1.Intro();
                        break;
                    case "Cow":
                        cow2.Eat();
                        break;
                    case "Chicken":
                        chicken3.Speak();
                        break;
                    case "Pig":
                        pig4.Product();
                        break;
                    default:
                        Console.WriteLine("\n\tWould you like to try again?");
                        retry = Console.ReadLine();
                        Console.WriteLine("\n\tI'll take that as a yes!");
                        break;
                }
            } while (retry != "No");
        }
        static void Main(string[] args)
        {
            makeFarm();
        }
    }
}
