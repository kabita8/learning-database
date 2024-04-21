 using System;
 using System.Collections.Generic;
 using System.IO;
// public class CSVParser
// {
//     private List<Person> people;
//     public CSVParser()
//     {
//         people = new List<Person>();
//     }
//     public void Parse(string filePath)
//     {
//         using(StreamReader reader = new StreamReader(filePath))
//         {
//             while (!reader.EndOfStream)
//             {
//                 string line = reader.ReadLine();
//                 if (!string.IsNullOrEmpty(line))
//                 {
//                     string[] parts = line.Split(',');
//                     if (parts.Length >=7)
//                 {
//                     Person person = new Person
//                     {
//                         Index = parts[0],
//                         UserID = parts[1],
//                         FirstName = parts[2],
//                         LastName = parts[3],
//                         Sex = parts[4],
//                        Email = parts[5],
//                         Phone = parts[6],
        
//                     };
//                     people.Add(person);
//                     }
//                 }
//             }
//         }
//     }
//     public void PrintNames()
//     {
//         foreach (var person in people)
//         {
//             Console.WriteLine($"{person.Index} {person.UserID} {person.FirstName} {person.LastName} {person.Sex} {person.Email} {person.Phone}");
//         }
//     }
// } 


// next solution

class CsvParser
{
    List<Person> people = [];
    public void Parse()
    {
        // Read file
        string filePath = @"E:\day 2\learning-database\Day 8\NETStarter\Basics\Peoplemanagement\People.csv";
        var lines = File.ReadAllLines(filePath);
        
        // Parsing
        foreach(var line in lines.Skip(1))
        {
            var parts = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var person = new Person
            {
                index = int.Parse(parts[0]),
                userId = parts[1],
                firstName = parts[2],
                lastName = parts[3],
                sex = Enum.Parse<Gender>(parts[4]),
                email = parts[5],
                phone = parts[6],
                dob = DateTime.Parse(parts[7]),
                jobTitle = parts[8]
            };

            people.Add(person);
        }
    }

    public void PrintNames()
    {
        foreach(var person in people)
        {
            Console.WriteLine($"{person.firstName} {person.lastName}");
        }
    }
}