﻿
// Student Kabita = new();
// Student Chahana = new();
// Student Khima = new();
// Student Anupama = new();
// Student Seerzu = new();
// Student Sandhya = new();

// Kabita.name = "Kabita";
// Kabita.address = "mashina";
// Kabita.roll = 18;
// Kabita.dob = new DateTime(2000,7,18);

// //Console.WriteLine(kabita.name +" "+kabita.address +" "+kabita.roll + " "+kabita.dob);

// Console.WriteLine($"{Kabita.name} {Kabita.address} {Kabita.roll} {Kabita.dob}");

// Animal a1=new();
// Animal a2=new();

// a1.name="cow";
// a1.type="domestic";
// a1.scientificname= "Bos taurus";
// a1.weight=30;
// a1.age=10;
// Console.WriteLine($"{a1.name} {a1.type} {a1.scientificname} {a1.weight} {a1.age}");

// a2.name="lion";
// a2.type=" non domestic";
// a2.scientificname= " Panthera leo";
// a2.weight=20;
// a2.age=5;
// Console.WriteLine($"{a2.name} {a2.type} {a2.scientificname} {a2.weight} {a2.age}");

// var rec1 = new Rectangle(18.18,8.8);
// var p = rec1.GetPerimeter();

// var rec2 = new Rectangle(4.5,5.5);
// var a = rec2.GetArea();
// Console.WriteLine("Rectangle 1 - Perimeter:" + p);
// Console.WriteLine("Rectangle 2 - Area:" + a);

// var square1 = new Square(9.8);
// var sa = square1.GetArea();
// var sp = square1.GetPerimeter();
// Console.WriteLine("Square1 -perimeter: " + sp);
// Console.WriteLine("Square1 -Area: " + sa);


// Circle c1 = new Circle(16.3);
// double perimeter = c1.GetPerimeter();
// double area = c1.GetArea();
// Console.WriteLine("circle-Perimeter: " + perimeter);
// Console.WriteLine("circle-Area: " + area);

// var sphere =new Sphere(45,8);
// var ssa = sphere1.GetArea();
// sphere1.PrintSphereInfo(45,8); 


// var fileio = new FileIO();
// fileio.CreateFile();
// fileio.CreateFileWithInfolder();

// string filePath =@"E:\day 2\learning-database\Day 8\NETStarter\Basics\Peoplemanagement\People.csv";
// CSVParser csvParser = new CSVParser();
// csvParser.Parse(filePath);
// csvParser.PrintNames();

//next solution
// CsvParser parser = new();
// parser.Parse();
// parser.PrintNames();


// int[] ages = [45,8,18,12.9,67];
// //Find squares of all numbers in ages collection
// //Imperative
// List<int> squares = [];
// foreach(var age in ages)
// {
// var square = age * age;
// square.Add(square);
// }

// //Declarative
// var square = ages.Select(age => age * age);

// ParallelAsync parallelAsync = new();
// parallelAsync.ProcessNumbers();

// await parallelAsync.IgniteStove();
// await parallelAsync.PutKettleOnWithWater();
// await parallelAsync.GrindMasala();

// BasicDbContext Db = new();
// var teacher1 = new Teacher
// {
// Name="Ashin",
// Address = "Dang",
// Gender ='F',
// Qualification = "Bachelor",
// Dob = new DateTime(2002,07,20)
// };
// Db.Teachers.Add(teacher1);
// Db.SaveChanges();
// //var teachers = Db.Teachers.ToList();
// //List all female teachers from dang
// var teachers = Db.Teachers.Where(teacher => teacher.Gender == 'F' && teacher.Address == "Dang").ToList();


// foreach(var teacher in teachers)
// {
//     Console.WriteLine($"Name: {teacher.Name}, Dob:{teacher.Dob}");
// }





CsvParser parser = new CsvParser();
List<Person> people = parser.Parse();

// Create instance of PeopleReport
PeopleReport report = new PeopleReport();

// Generate and save reports
report.SaveMales(people.ToArray(), "males.csv");
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");

