using System;
using System.Collections.Generic;

namespace golf_cart.models

{
  public class Player
  {
    public string Name { get; set; }
    public List<int> Scores { get; set; }
    public Player(string name)
    {
      Name = name;
      Scores = new List<int>();

    }
    public void ShowScore()
    {
      int total = 0;
      foreach (int score in Scores)
      {
        total += score;

      }

      System.Console.WriteLine(value: $"{Name} - Score: {total}");
    }








  }






}