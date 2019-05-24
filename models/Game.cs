using System;
using System.Collections.Generic;

namespace golf_cart.models
{
  public class Game
  {
    public Course ActiveCourse { get; set; }
    public List<Player> Players { get; set; } = new List<Player>();
    public List<Course> Courses { get; set; } = new List<Course>();


    public void DrawCourses()
    {
      for (int i = 0; i < Courses.Count; i++)
      {
        Course course = Courses[i];
        System.Console.WriteLine($"{i + 1}. {course.Name}");
      }
      SelectCourse();
    }

    public void SelectCourse()
    {
      int selection;
      while (!Int32.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > Courses.Count)
      {
        System.Console.WriteLine(" bad input ");
      }
      ActiveCourse = Courses[selection - 1];
    }

    public void SetPlayers()
    {
      System.Console.WriteLine("How Many Players this Round?");
      int numberOfPlayers;
      while (!Int32.TryParse(Console.ReadLine(), out numberOfPlayers))
      {
        System.Console.WriteLine("Not a valid number");
      }
      while (numberOfPlayers > 0)
      {
        System.Console.WriteLine("enter Player name");
        string name = Console.ReadLine();
        Player player = new Player(name);
        Players.Add(player);
        numberOfPlayers--;
        System.Console.WriteLine($"Thanks for adding {player.Name}.");

      }
    }

    public void StartGame()
    {
      int holeCount = 1;
      foreach (Hole hole in ActiveCourse.Holes)
      {
        Console.Clear();
        System.Console.WriteLine($"Par for hole {holeCount} is {hole.Par}.");
        holeCount++;
        SetPlayerScores();
      }
      ShowScores();
    }

    public void SetPlayerScores()
    {
      Console.Clear();
      foreach (Player player in Players)
      {
        System.Console.WriteLine($"Enter the score for {player.Name}");
        int score;
        while (!Int32.TryParse(Console.ReadLine(), out score))
        {
          System.Console.WriteLine("Not a valid number");
        }
        player.Scores.Add(score);
      }
    }
    public void ShowScores()
    {
      foreach (Player player in Players)
      {
        player.ShowScore();
      }
    }
    public void TheWinner()
    {
      string winnerName = ""; int winnerScore = 1000;
      foreach (Player player in Players)
      {
        int playerScore = 0;
        foreach (int score in player.Scores)
        {
          playerScore += score;
        }
        if (playerScore < winnerScore)
        {
          winnerScore = playerScore;
          winnerName = player.Name;
        }
      }
      System.Console.WriteLine($"{winnerName} has won the game");
    }
  }



}
