using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
  public abstract class Piece
  {
    public string Name {get;set;}
    public int PosX {get;set;}
    public int PosY {get;set;}
    public int Kills {get;set;}
    public bool Threatened {get;set;}
    public bool HasMoved {get;set;}
    public Team Team {get;set;}
    List<BoardCell> moves = new List<BoardCell>();
    
    //enum pieceTypes
    //{
    //  Pawn,
    //  Rook,
    //  Knight,
    //  Bishop,
    //  Queen,
    //  King
    //};

    public Piece(string name, int posX, int posY, int kills, bool threatened, bool hasMoved, Team team)
    {
      this.Name = name;
      this.PosX = posX;
      this.PosY = posY;
      this.Kills = kills;
      this.Threatened = threatened;
      this.HasMoved = hasMoved;
      this.Team = team;
    }
    public virtual List<BoardCell> moveList(Piece p, List<BoardCell> boardCells)
    {
      return moves;
    }

    public string Move(BoardCell move)
    {      
      List<BoardCell> oneMove = new List<BoardCell> {
        new BoardCell (this.PosX, this.PosY, this),
        new BoardCell (this.PosX + move.X, this.PosY + move.Y, this)
      };
      
      this.PosX += move.X;
      this.PosY += move.Y;

      return oneMove.ToString();
    }
  }
}