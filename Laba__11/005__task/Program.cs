using System;
class Program
{
    static void Main()
    {
        var people = new List<Person>();
        people.Add(new Person("Sara Gibson", "Smills@gmail.com"));
        people.Add(new Person("Andrew Gibson", "Gibson@abv.bg"));
        people.Add(new Person("Craig Ellis", "Ellis@abv.bg"));
        people.Add(new Person("Steven Cole", "Themachine@abv.bg"));
        people.Add(new Person("Andrew Ellis", "ac147@gmail.com"));

        var collection = people.Where(p => p.email.EndsWith("@gmail.com"));

        foreach (var item in collection)
        {
            Console.WriteLine($"{item.name}");
        }

        Console.ReadLine();
    }
}

record Person(string name, string email);