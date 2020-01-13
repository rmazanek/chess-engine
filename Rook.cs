using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Rook : Piece
  {
    public Rook(string name, int x, int y, int kills, bool threatened, bool hasMoved) : base("Rook", x, y, kills, threatened, hasMoved)
    {

    }
  }
}