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

    class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("James", 20, "Microsoft");

            
        }
    }
}
