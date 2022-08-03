using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3
{
    class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }

        public new void Print()
        {
            Console.WriteLine($"User name is {name}, user age is {age}, user compnay is {company}");
        }
    }
}
