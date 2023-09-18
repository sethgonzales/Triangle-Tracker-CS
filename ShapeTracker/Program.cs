using System;
using ShapeTracker.Models; //import the namespace that acts as a collection of the Business interface models
using System.Collections.Generic;  

namespace ShapeTracker
{
  public class Program
  {
    static void Main()
    {
      //"Triangle" points to the Triangle class "testTriangle" is the variable "new Triangle()" points to the constructor method
      List<Triangle> allTriangles = Triangle.GetAll();
      Triangle testTriangle = new Triangle(3, 4, 5);
      Triangle secondTriangle = new Triangle(32, 74, 75);
      if (allTriangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else
      {
        Console.WriteLine("----------------------------------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
          Console.WriteLine("----------------------------------");
        }
      }
    }
  }
}