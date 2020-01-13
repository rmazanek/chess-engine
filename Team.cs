using System;

namespace chess_engine
{
  public class Team
  {
    public string Name {get; set;}
    public bool IsWhite {get; set;}
    
    public Team(string name, bool isWhite)
    {
    Name = name;
    IsWhite = isWhite;
    }

    public Team()
    {
      Name = "White";
      IsWhite = true;
    }
    
  }
}