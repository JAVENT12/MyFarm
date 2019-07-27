using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    public class Cow
    {
        public string name;
        public string sound;
        public string food;
        public string product;
        public Cow(string aName, string aSound, string aFood, string aProduct)
        {
            name = aName;
            sound = aSound;
            food = aFood;
            product = aProduct;
        }
        public void Intro()
        {
            Console.WriteLine($"\n\tHi my name is {name}, whenever I'm hungry I like to {sound}");
        }
        public void Speak()
        {
            Console.WriteLine($"\n\t{sound} out the way!");
        }
        public void Product()
        {
            Console.WriteLine($"\n\tI love making {product}");
        }
        public void Eat()
        {
            Console.WriteLine($"\n\t{food} is my favorite snack");
        }
    }
    public class Horse
    {
        public string name;
        public string sound;
        public string food;
        public string product;
        public Horse(string aName, string aSound, string aFood, string aProduct)
        {
            name = aName;
            sound = aSound;
            food = aFood;
            product = aProduct;
        }
        public void Intro()
        {
            Console.WriteLine($"\n\t{sound} my name is {name} lets grab some {product} ");
        }
        public void Speak()
        {
            Console.WriteLine($"\n\t{sound} out the way!");
        }
        public void Product()
        {
            Console.WriteLine($"\n\tI love making {product}");
        }
        public void Eat()
        {
            Console.WriteLine($"\n\t{food} is my favorite snack");
        }
    }
    public class Chicken
    {
        public string name;
        public string sound;
        public string food;
        public string product;
        public Chicken(string aName, string aSound, string aFood, string aProduct)
        {
            name = aName;
            sound = aSound;
            food = aFood;
            product = aProduct;
        }
        public void Intro()
        {
            Console.WriteLine($"\n\t{sound} my name is {name} lets grab some {product} ");
        }
        public void Speak()
        {
            Console.WriteLine($"\n\t{sound} out the way!");
        }
        public void Product()
        {
            Console.WriteLine($"\n\tI love making {product}");
        }
        public void Eat()
        {
            Console.WriteLine($"\n\t{food} is my favorite snack");
        }
    }
    public class Pig
    {
        public string name;
        public string sound;
        public string food;
        public string product;
        public Pig(string aName, string aSound, string aFood, string aProduct)
        {
            name = aName;
            sound = aSound;
            food = aFood;
            product = aProduct;
        }
        public void Intro()
        {
            Console.WriteLine($"\n\t{sound} my name is {name} lets grab some {product} ");
        }
        public void Speak()
        {
            Console.WriteLine($"\n\t{sound} out the way!");
        }
        public void Product()
        {
            Console.WriteLine($"\n\tI love making {product}");
        }
        public void Eat()
        {
            Console.WriteLine($"\n\t{food} is my favorite snack");
        }
    }
}
