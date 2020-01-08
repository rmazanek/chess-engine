using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
  public class Piece
  {
    public Piece(string name, int x, int y, int kills)
    {

    }
    
    public void moveList(int xMove, int yMove)
    {
      List<BoardCell> moves = new List<BoardCell>();
    }

    public List<string> pieceTypes = new List<string> {
      "Pawn",
      "Rook",
      "Knight",
      "Bishop",
      "Queen",
      "King"
    };
  }
}