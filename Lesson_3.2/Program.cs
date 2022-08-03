using System;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chipboard chipboard = new Chipboard("Chipboard", "dark", "Orange", 1000);

            chipboard.type = MyEnum.dark;

            Plywood plywood = new Plywood("Plywood", "light", "Cream", 3000);

            plywood.type = MyEnum.light;

            Beech beech = new Beech("Beech", "light", "Chockolate", 5000);

            beech.type = MyEnum.light;

            chipboard.PrintAboutItem();

            plywood.PrintAboutItem();

            beech.PrintAboutItem();
        }
    }
}
