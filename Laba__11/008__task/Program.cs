using System;
class Program
{
    static void Main()
    {
        var people = new List<Person>();
        people.Add(new Person("Sara Gibson", 6, 6, 6, 5));
        people.Add(new Person("Andrew Gibson", 3, 4, 5, 6));
        people.Add(new Person("Craig Ellis", 4, 2, 3, 4));
        people.Add(new Person("Steven Cole", 5, 6, 5, 5));
        people.Add(new Person("Andrew Carter", 5, 3, 4, 2));

        var collection = people.Where(p => p.marks.Where(p => p <= 3).Count() >= 2);

        foreach (var item in collection)
        {
            Console.WriteLine($"{item.name}");
        }

        Console.ReadLine();
    }
}

record Person(string name, params int[] marks);
