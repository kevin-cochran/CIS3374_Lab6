using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS3374_Lab6
{
    public class Game
    {

        private string player;
        private string[,] board;

        public string CurrentPlayer
        {
            get
            {
                return this.player;
            }
            set
            {
                this.player = value;
            }
        }

        public string[,] Board
        {
            get
            {
                return this.board;
            }
            set
            {
                this.board = value;
            }
        }

        //initializes game board and assigns first player with coin flip
        public void createBoard()
        {
            this.board = new string[3,3];


            CurrentPlayer = "X";
        }


        public void changePlayer()
        {
            if (CurrentPlayer == "X")
            {
                CurrentPlayer = "O";
            } else
            {
                CurrentPlayer = "X";
            }
        }

        public bool makeMove(int row, int col)
        {
            bool validMove = false;

            if (!spaceInUse(row, col))
            {
                Board[row, col] = CurrentPlayer;
                validMove = true;
                changePlayer();
            }

            return validMove;
        }

        public bool spaceInUse(int row, int col)
        {
            bool inUse = false;

            if (Board[row, col] != null)
            {
                inUse = true;
            }

            return inUse;
        }


    }
}