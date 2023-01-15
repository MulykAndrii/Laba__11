using System;
using System.Linq;
using System.Security.Claims;
using _002__task;

class Program
{
    static void Main()
    {

        var people = new List<Person>();
        people.Add(new Person("Sara Mills", 1));
        people.Add(new Person("Andrew Gibson", 1));
        people.Add(new Person("Craig Ellis", 2));
        people.Add(new Person("Steven Cole", 2));
        people.Add(new Person("Andrew Carter", 1));

        var collections = people.Select(p => new
        {
            FirstName = p.name.Split(' ')[0],
            LastName = p.name.Split(' ')[1]
        }).Where(s => String.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0);

        foreach (var item in collections)
        {
            Console.WriteLine($"The student: {item.FirstName} {item.LastName}");
        }

        Console.ReadLine();
    }
}