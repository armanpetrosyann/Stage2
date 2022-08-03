using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3
{
    class Person : IActions
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

        public void Print()
        {
            Console.WriteLine($"User name is {name}, user age is {age}");
        }
    }
}
