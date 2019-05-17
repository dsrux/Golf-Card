using System;
using System.Collections.Generic;

namespace golf_cart.models
{
  public class Course
  {
    public List<Hole> Holes { get; set; } = new List<Hole>();
    public string Name { get; set; }


    public Course(string name)
    {
      Name = name;
    }
  }

}