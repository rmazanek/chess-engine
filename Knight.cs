using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Knight : Piece
  {
    public List<BoardCell> moves = new List<BoardCell>
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

    //Constructor
    public Knight(string name, int posX, int posY, int kills, bool threatened, bool hasMoved, Team team) 
      : base (name, posX, posY, kills, threatened, hasMoved, team){}
    public override List<BoardCell> moveList(Piece p, List<BoardCell> boardCells)
    {
      return moves;
    }
  }
}