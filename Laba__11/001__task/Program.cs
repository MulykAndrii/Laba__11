using System;
using System.Linq;
using _001__task;

class Program
{
    static void Main()
    {
        var people = new List<Person>();
        people.Add(new Person("James", 1));
        people.Add(new Person("Susan", 1));
        people.Add(new Person("Tomas", 2));
        people.Add(new Person("Raily", 2));
        people.Add(new Person("Megan", 1));
        people.Add(new Person("Bob", 2));

        var collections = people.Where(p => p.course == 2);

        foreach (var item in collections)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}