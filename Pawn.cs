using System;
using System.Collections.Generic;

namespace chess_engine
{
  public class Pawn : Piece
  {
    public bool EnPassant = false;
    BoardCell optStartMove = new BoardCell(0,2,null);
    BoardCell regMove = new BoardCell(0,1,null);
    BoardCell atkLeft = new BoardCell(-1,1,null);
    BoardCell atkRight = new BoardCell(1,1,null);
    public List<BoardCell> moves = new List<BoardCell>{};

    //Piece p1 = new Pawn();
    
    //Constructor
    public Pawn(string name, int posX, int posY, int kills, bool threatened, bool hasMoved, Team team) 
      : base (name, posX, posY, kills, threatened, hasMoved, team)
    {
      //int count;
//
      //if(team.IsWhite)
      //{
      //  count = countWhite++;
      //  posY = 2;
      //}
      //else
      //{
      //  count = countBlack++;
      //  posY = 7;
      //}
//
      //name = "Pawn"+count;
      //posX++;
      //count++;
      //kills = 0;
      //threatened = false;
      //hasMoved = false;
    }

    //public EnPassant(Pawn pawn)
    //{
    //  if (last move was pawn that moved two spaces next to your pawn)
    //{
    //  add attack move in that direction to move list
    //}
    //}

    //public override List<BoardCell> moveList(Piece p, List<BoardCell> boardCells)
    //{
    //  BoardCell atkLeft = new BoardCell();
//
    //  if ( == 5)
    //  {
    //    List<BoardCell> moveList = new List<BoardCell>{};
    //    moveList.Add(atkLeft);
    //    return moveList;
    //  }
    //  else if (p.hasMoved)
    //  {
    //      return moveList;
    //  }
    //  return moveList;
    //}

    //Function to add en passant to move list
    //Function to allow attack move when valid
    //new BoardCell(1,1,null),
    //new BoardCell(-1,1,null)
  }
}