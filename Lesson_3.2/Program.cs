using System;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chipboard chipboard = new Chipboard("Chipboard", "dark", "Orange", 1000);

            chipboard.type = Types.dark;
            chipboard.color = Colors.orange;

            Plywood plywood = new Plywood("Plywood", "light", "Cream", 3000);

            plywood.type = Types.light;
            chipboard.color = Colors.cream;

            Beech beech = new Beech("Beech", "light", "Chockolate", 5000);

            beech.type = Types.lighten;
            beech.color = Colors.chockolate;

            chipboard.PrintAboutItem();

            plywood.PrintAboutItem();

            beech.PrintAboutItem();
        }
    }
}
