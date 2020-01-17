using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class King : Piece
  {
    public int MoveDis {get; set;}
    public List<BoardCell> moves = new List<BoardCell>
    {
      //new BoardCell(0,1,null),
      //new BoardCell(1,0,null),
      //new BoardCell(0,-1,null),
      //new BoardCell(-1,0,null)
    };
    public King(string name, int posX, int posY, int kills, bool threatened, bool hasMoved, Team team)
      : base (name, posX, posY, kills, threatened, hasMoved, team){}

  }
}