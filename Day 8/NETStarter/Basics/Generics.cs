using System;
public class Generics
{
    publuc void print<T>(T x)
    {
        Console.WriteLine(x);
    }
    public void Test()
    {
        Print<string>("4556");
        Print<int>(45567);
        Print<decimal>(4556.65m);
        Print<byte>(455);
        List<int> marks = [];
        
        marks.Add(88);
    }
}
