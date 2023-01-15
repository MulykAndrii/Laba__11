using System;
using System.Globalization;

class Program
{
	static void Main()
	{
        var result = new string[] { "14", "15" };
        
        var people = new List<Student>();
        people.Add(new Student("554214", 2, 5, 3, 5, 6));
        people.Add(new Student("653215", 2, 6, 6, 5, 5));
        people.Add(new Student("156212", 2, 5, 3, 1, 1));
        people.Add(new Student("324413", 2, 5, 3, 3, 2));
        people.Add(new Student("134014", 2, 5, 6, 6, 6));

        var collection = people.Where(p => result.Contains(p.course.Substring(p.course.Length - 2))).Select(p => string.Join(" ", p.marks));
            

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
	}
}

record class Student(string course, params int[] marks);
