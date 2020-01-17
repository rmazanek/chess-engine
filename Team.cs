using System;
using System.Collections.Generic;
using System.Linq;

namespace chess_engine
{
  public class Team
  {
    public string Name {get; set;}
    public string Color {get; set;}
    public bool IsWhite {get; set;}
    public static int count = 0;
    public List<Piece> pieceList;
//    public List<Piece> pieceListWhite;
//    public List<Piece> pieceListBlack;
    
    //Constructor for player team
    public Team(string name, string color, bool isWhite)
    {
    Name = name;
    Color = color;
    IsWhite = isWhite;
    }

    //Constructor for AI teams
    public Team()
    {
      newTeam();
    }
    
    //Create AI team
    public static Team newTeam()
    {
      if (count==0)
      {
        Team white = new Team("Computer1","White",true);
        count++;
        return white;
      }
      else if (count==1)
      {
        Team black = new Team("Computer2","Black",false);
        count++;
        return black;
      }
      return null;
    }

    //Instantiate pieces of your team color
    public void CreatePieces()
    { 
      //Initialize pawns
      for (int i = 1; i < 9; i++)
      {
        this.pieceList.Add(new Pawn("Pawn", i, 2, 0, false, false, this));
      }
      
      //Initialize others
      this.pieceList.Add(new Rook("Rook", 1, 1, 0, false, false, this));
      this.pieceList.Add(new Knight("Knight", 2, 1, 0, false, false, this));
      this.pieceList.Add(new Bishop("Bishop", 3, 1, 0, false, false, this));
      this.pieceList.Add(new Queen("Queen", 4, 1, 0, false, false, this));
      this.pieceList.Add(new King("King", 5, 1, 0, false, false, this));
      this.pieceList.Add(new Bishop("Bishop", 6, 1, 0, false, false, this));
      this.pieceList.Add(new Knight("Knight", 7, 1, 0, false, false, this));
      this.pieceList.Add(new Rook("Rook", 8, 1, 0, false, false, this));

      //If black team, set all pieces to the proper row
      if(!this.IsWhite)
      {
        foreach (Piece item in this.pieceList) //Set all pieces to row 8 momentarily
        {
          item.PosY = 8;
        }
        foreach (Pawn item in this.pieceList) //Overwrite row for pawns
        {
          item.PosY = 7;
        }
      }
    }

    //Move a piece
    public string Move(Board board, BoardCell cell1, BoardCell cell2)
    {      
      board.BoardCells.Equals(cell1);
      cell1.P.Validate(cell2);

      this.PickPiece(board).Move(board);
      
      move.Add();
      //board.BoardCells;
      return move;
    }

    //Pick a random piece from your team
    public Piece PickPiece(Board board)
    {
      var rand = new Random();

      int index = rand.Next(1,this.pieceList.Count);   
      return this.pieceList.ElementAt(index);
    }
  }
}