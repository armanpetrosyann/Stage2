using System;

namespace Lesson_3
{
    class Person
    {
        protected string name;
        protected int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

    }
 

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
