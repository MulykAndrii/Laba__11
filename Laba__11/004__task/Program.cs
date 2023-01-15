using System;
using _004__task;

class Program
{
    static void Main()
    {
        var people = new List<Person>();
        people.Add(new Person("Sara Gibson"));
        people.Add(new Person("Andrew Gibson"));
        people.Add(new Person("Craig Ellis"));
        people.Add(new Person("Steven Cole"));
        people.Add(new Person("Andrew Ellis"));

        var collection = people.Select(p => new
        {
            FirstName = p.name.Split(' ')[0],
            LastName = p.name.Split(' ')[1]
        }).OrderBy(p => p.LastName).ThenByDescending(p => p.LastName);

        foreach (var item in collection)
        {
            Console.WriteLine($"The student is {item.FirstName} {item.LastName}");
        }
    }

}