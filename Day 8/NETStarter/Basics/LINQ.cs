//LINQ language integrated Query
//Imperative (Procedural, OOP etc.) (C, C++, c# etc) vs Declarative [functional] (SQL, Haskel, C#, LISP) programming languages
using System.Collections.Generic;
using System.Linq;
class LINQ
{
    
int[] ages = [45,8,18,12,9,67];
List<Student> students = [
    new Student() {name ="kabita", address="mashina"},
    new Student() {name ="khima", address="Ghorahi"},
    new Student() {name ="Chahana", address="Ghorahi"},
    new Student() {name ="Anupama", address="Sarra"},
];
//Find squares of all numbers in ages collection
public void LearnLINQ()
{
//Declarative
var squares = ages.Select(age => age * age);
       

//find odd numbers within ages
var odds = ages.Where(x => x % 2 == 1);
     

//find cubes of all even numbers within ages collection

var cubesOfEvens = ages.Where(age => age % 2 == 0).Select(age => age * age * age); 

//find students who lives in ghorahi and sort the result by names

var ghorahiStudents = students.Where(s =>s.address == "Ghorahi").OrderBy(s => s.name);
 
}
}