using System;

class Sphere: Circle
{
    public Sphere(double radius) 
    : base(radius)
     {}

     //method overriding
     public override double GetArea() => 4 * Math.PI * radius *radius;
     
     public void PrintSphereInfo()
     {

     }
      public void PrintSphereInfo(double radius)
      {

      }
}