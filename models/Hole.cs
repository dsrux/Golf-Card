using System;
namespace golf_cart.models
{
  public class Hole
  {
    public int Par { get; set; }

    public Hole(int par)
    {
      Par = par;

    }
  }
}