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
            Console.Write("Player Name: ");
            string playerName = Console.ReadLine();
            Team team = new Team(playerName,true);
            Board board = new Board(true, false, false);

            if(team.IsWhite && board.GameContinues)
            {
                //Send move
                //Update and log board state
            }
            
            do
            {
                //Wait for move request
                //Validate move
                //Input move
                //Update and log board state
                

                //Send move
                //Update and log board state
            } while (board.GameContinues);

            //Validate move from last board state
            //Reconcile piece removals
            //Evaluate inCheck status
            

        }
    }
}
