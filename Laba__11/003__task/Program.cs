using System;
using System.Linq;
using System.Security.Claims;
using _003__task;

class Program
{
    static void Main()
    {

        var people = new List<Person>();
        people.Add(new Person("Sara Mills", 24));
        people.Add(new Person("Andrew Gibson", 21));
        people.Add(new Person("Craig Ellis", 35));
        people.Add(new Person("Steven Cole", 19));
        people.Add(new Person("Andrew Carter", 15));

        var collections = people.Select(p => new
        {
            FirstName = p.name.Split(' ')[0],
            LastName = p.name.Split(' ')[1],
            Age = p.age
        }).Where(p => p.Age >= 18 && p.Age <= 24).OrderBy(p => p.Age);


        foreach (var item in collections)
        {
            Console.WriteLine($"The student: {item.FirstName} {item.LastName} - the age is {item.Age}");
        }

        Console.ReadLine();
    }
}