using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Bishop : Piece
  {
    public int MoveDis {get; set;}
    public List<BoardCell> moves = new List<BoardCell>
    {
      //new BoardCell(1,1,null),
      //new BoardCell(1,-1,null),
      //new BoardCell(-1,-1,null),
      //new BoardCell(-1,1,null)
    };
    public Bishop(string name, int posX, int posY, int kills, bool threatened, bool hasMoved, Team team)
      : base (name, posX, posY, kills, threatened, hasMoved, team){}

  }
}