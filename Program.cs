using System;
using System.Collections.Generic;
using System.IO;

namespace chess_engine
{
    //Input, output, update board state
    class Program
    {
        static void Main(string[] args)
        {
            //Assign teams
            //Console.Write("Player Name: ");
            //string playerName = Console.ReadLine();
            Team white = new Team();
            Team black = new Team();
            Board board = new Board(true, false, false);
            white.CreatePieces();
            black.CreatePieces();
            
            while (board.GameContinues)
            {
                //White send move
                white.Move(board);
                //Update and log board state

                //Wait for black move request
                //Validate move
                //Input move
                black.Move(board);
                //Update and log board state
            } 

            //Validate move from last board state
            //Reconcile piece removals
            //Evaluate inCheck status       
        }

        public void MarryPiecestoBoard(Board board, List<Piece> pieces)
        {

        }
    }
}
