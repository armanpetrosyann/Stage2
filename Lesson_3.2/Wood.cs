using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3._2
{
    internal class Wood : IItemActions
    {
        protected string name;
        protected MyEnum type;
        protected string color;
        protected decimal price;

        public Wood(string name, string type, string color, decimal price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void PrintAboutItem()
        {
            Console.WriteLine($"Wood name is {name}, wood type is {type}, wood color is {color}, wood price is {price}");
        }

    }
    enum MyEnum
    {
        light,
        dark,
        lighten,
        darken
    }
}
