//create a class called "Animal"
//Define at least 5 internal fields.
//Define a method to print all details of animal in descriptive format.
// In program entry point ,create at least two objects of Animal.
//Print details in console
class Animal{
    internal string name;
    internal string type;
    internal string scientificname;
    internal int weight;
    internal int age ;
    internal void PrintDetails()
     {
       Console.WriteLine($"{name} {type} {scientificname} {weight} {age}");
     }
}
