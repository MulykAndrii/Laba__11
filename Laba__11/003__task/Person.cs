using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003__task
{
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            var Builder = new StringBuilder();
            Builder.AppendLine($"The student: {this.name} and his age is {this.age}");
            return Builder.ToString().TrimEnd();
        }
    }
}
