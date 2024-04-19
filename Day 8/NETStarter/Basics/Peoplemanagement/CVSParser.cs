using System;
using System.Collections.Generic;
using System.IO;
public class CSVParser
{
    private List<Person> people;
    public CSVParser()
    {
        people = new List<Person>();
    }
    public void Parse(string filePath)
    {
        using(StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >=7)
                {
                    Person person = new Person
                    {
                        Index = parts[0],
                        UserID = parts[1],
                        FirstName = parts[2],
                        LastName = parts[3],
                        Sex = parts[4],
                        Email = parts[5],
                        Phone = parts[6],
        
                    };
                    people.Add(person);
                    }
                }
            }
        }
    }
    public void PrintNames()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Index} {person.UserID} {person.FirstName} {person.LastName} {person.Sex} {person.Email} {person.Phone}");
        }
    }
}


// next solution

class csvParser
{
    List<Person> people = [];
    public void Parse()
    {
        //Read file
        string filepath=@""
        var lines = File.ReadAllLines(filepath);
        //parsing
        foreach(var line in lines.Skip(1))
        {
            var parts = line.Split(",",StrigSplitOptions.RemoveEmptyEntries);
            var person = new Person
            {
                index
            }
        }
    }
}