//LINQ language integrated Query
//Imperative (Procedural, OOP etc.) (C, C++, c# etc) vs Declarative [functional] (SQL, Haskel, C#, LISP) programming languages
class LINQ
{
    
int[] ages = [45,8,18,12.9,67];
//Find squares of all numbers in ages collection
public void LearnLINQ()
{
//Imperative
List<int> squares = [];
foreach(var age in ages)
{
var square = age * age;
square.Add(square);
}

//Declarative
var square = ages.Select(age => age * age);



//find odd numbers within ages
var odds = ages.Where(x => x % 2 == 1);

//find cubes of all even numbers within ages collection
var cubes = ages.Where(age => age % 2 == 0).Select(age => age * age * age);  
}
}