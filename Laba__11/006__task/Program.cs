using System;

class Program
{
	static void Main()
	{
        var people = new List<Person>();
        people.Add(new Person("Sara Gibson", "02435521"));
        people.Add(new Person("Andrew Gibson", "0895223344"));
        people.Add(new Person("Craig Ellis", "+3592667710"));
        people.Add(new Person("Steven Cole", "3242133312"));
        people.Add(new Person("Andrew Ellis", "+001234532"));

        var collection = people.Where(p => p.phone.StartsWith("02") || p.phone.StartsWith("+3592"));

        foreach (var item in collection)
        {
            Console.WriteLine($"{item.name}");
        }

        Console.ReadLine();
	}
}

record class Person(string name, string phone);
