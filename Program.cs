using System;
using golf_cart.models;

namespace golf_cart
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      #region data initialization
      Course mini = new Course("Mini Put Put");
      Course foxtrot = new Course("Foxtrot Resort");
      Course bluelakes = new Course("Blue Lakes Country Club");
      Hole par2 = new Hole(2);
      Hole par3 = new Hole(3);
      Hole par4 = new Hole(4);
      Hole par5 = new Hole(5);
      mini.Holes.Add(par2);
      mini.Holes.Add(par3);
      mini.Holes.Add(par4);
      mini.Holes.Add(par4);
      mini.Holes.Add(par5);
      mini.Holes.Add(par2);
      mini.Holes.Add(par3);
      mini.Holes.Add(par2);
      mini.Holes.Add(par5);
      foxtrot.Holes.Add(par3);
      foxtrot.Holes.Add(par3);
      foxtrot.Holes.Add(par2);
      foxtrot.Holes.Add(par5);
      foxtrot.Holes.Add(par5);
      foxtrot.Holes.Add(par4);
      foxtrot.Holes.Add(par2);
      foxtrot.Holes.Add(par2);
      foxtrot.Holes.Add(par4);
      bluelakes.Holes.Add(par4);
      bluelakes.Holes.Add(par2);
      bluelakes.Holes.Add(par3);
      bluelakes.Holes.Add(par5);
      bluelakes.Holes.Add(par2);
      bluelakes.Holes.Add(par3);
      bluelakes.Holes.Add(par5);
      bluelakes.Holes.Add(par4);
      bluelakes.Holes.Add(par2);
      Game game = new Game();
      game.Courses.Add(mini);
      game.Courses.Add(foxtrot);
      game.Courses.Add(bluelakes);
      #endregion

      System.Console.WriteLine("Welcome");
      System.Console.WriteLine("Pick A Course");
      game.DrawCourses();

      System.Console.WriteLine($"Thanks for playing at {game.ActiveCourse.Name}.");
      game.SetPlayers();
      game.StartGame();
      System.Console.WriteLine("Thank you for playing");
      game.TheWinner();


    }
  }
}
