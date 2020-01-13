using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Knight : Piece
  {
    public Knight(string name, int x, int y, int kills, bool threatened, bool hasMoved) : base("Knight", x, y, kills, threatened, hasMoved)
    {

    }

    public List<BoardCell> moveList = new List<BoardCell>
    {
      new BoardCell(2,1,null),
      new BoardCell(1,2,null),
      new BoardCell(-1,2,null),
      new BoardCell(-2,1,null),
      new BoardCell(0,-2,null),
      new BoardCell(0,-1,null),
      new BoardCell(0,1,null),
      new BoardCell(0,2,null)
    };

  }
}