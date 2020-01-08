using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
  public class BoardCell
  {
    public BoardCell(int x, int y, Piece  p)
    {
      X = x;
      Y = y;
      P = p;      
    }
    public int X { get; }
    public int Y { get; }
    public Piece P { get; }
  }
}