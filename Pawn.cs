using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Pawn : Piece
  {
    public bool EnPassant;
    public Pawn(string name, int x, int y, int kills, bool threatened, bool hasMoved) : base("Pawn", x, y, kills, threatened, hasMoved)
    {

    }

    public List<BoardCell> moveList(bool hasMoved, bool enPassant)
    {
      
      if (hasMoved && enPassant)
      {
        public List<BoardCell> moveListStart = new List<BoardCell>
        {
          new BoardCell(0,1,null),
          new BoardCell(0,2,null)
        };
        return moveListStart;
      }

    }

    //Function to add en passant to move list
    //Function to allow attack move when valid
    //new BoardCell(1,1,null),
    //new BoardCell(-1,1,null)
  }
}