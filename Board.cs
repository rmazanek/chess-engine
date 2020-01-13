using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
  public class Board
  {
      public bool CheckmateStatus {get; set;}
      public bool CheckStatus {get; set;}
      public bool GameContinues {get; set;}

    public Board(bool gameContinues, bool checkmateStatus, bool checkStatus)
    {
      GameContinues = gameContinues;
      CheckmateStatus = checkmateStatus;
      CheckStatus = checkStatus;


      List<BoardCell> BoardCells = new List<BoardCell>();

      for (int i = 1; i < 9; i++)
      {
        for (int j = 1; j < 9; j++)
        {
          BoardCell c = new BoardCell(i,j,null);
          BoardCells.Add(c);
        }
      }
    }

    public Queue<BoardCell> turnHistory = new Queue<BoardCell>();
  }
}