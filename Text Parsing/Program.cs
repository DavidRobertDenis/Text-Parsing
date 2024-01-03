using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

    public Person(string firstName, string lastName, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} {City}");
    }
}

class Program
{
    private const int v = 0;

    static void Main()
    {
        string text = "John.Davidson/Belgrade Michael.Barton/Krakow Ivan.Perkinson/Moscow";

         
        string[] entries = text.Split(' ');

         
        Person[] persons = new Person[entries.Length];

        for (int i = 0; i < entries.Length; i++)
        {
             
            string[] parts = entries[i].Split('/');

             
            persons[i] = new Person(parts[v], parts[1], parts[2]);
        }

         
        foreach (Person person in persons)
        {
            person.PrintInfo();
        }
    }
}

