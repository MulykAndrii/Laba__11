using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001__task
{
    internal class Person
    {
        public string name;
        public int course;
        public Person(string name, int course)
        {
            this.name = name;
            this.course = course;
        }

        public override string ToString()
        {
            var Builder = new StringBuilder();
            Builder.AppendLine($"The student: {this.name} and his course is {this.course}");
            return Builder.ToString().TrimEnd();
        }
    }
}
