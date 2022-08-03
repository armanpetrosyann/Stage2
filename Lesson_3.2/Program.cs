using System;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chipboard chipboard = new Chipboard("Chipboard", "dark", "Orange", 1000);
            Plywood plywood = new Plywood("Plywood", "light", "Cream", 3000);
            Beech beech = new Beech("Beech", "light", "Chockolate", 5000);
            chipboard.PrintAboutItem();
            plywood.PrintAboutItem();
            beech.PrintAboutItem();
        }
    }
}
