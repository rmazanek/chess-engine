using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
  public class Piece
  {
    public Piece(string name, int x, int y, int kills, bool threatened, bool hasMoved)
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

    public List<BoardCell> Move(Piece piece, BoardCell startPos, BoardCell move)
    {
      List<BoardCell> oneMove = new List<BoardCell> {
        new BoardCell (startPos.X, startPos.Y,piece),
        new BoardCell (startPos.X + move.X, startPos.Y + move.Y, piece)
      };

      return oneMove;
    }
  }
}