using System;

namespace chess_engine
{
  public class Team
  {
    //White goes first
    public Team(bool white)
    {
      White = white;  
    }
    public bool White {get;set;}
  }
}