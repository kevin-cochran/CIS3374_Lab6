using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS3374_Lab6;


namespace CIS3374.UnitTests
{
    [TestClass]
    public class GameTests
    {
        
        //Assert board has nine spaces
        [TestMethod]
        public void createBoard_BoardHas9Spaces()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            int totalSpaces = game.Board.Length;

            //Assert
            Assert.AreEqual(9, totalSpaces);
        }


        //Assert Current player is X at start of game
        [TestMethod]
        public void createBoard_CurrentPlayerisX()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();          

            //Assert
            Assert.AreEqual(game.CurrentPlayer, "X");
        }


        //Assert Current player is O after change
        [TestMethod]
        public void changePlayer_CurrentPlayerisO()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.changePlayer();

            //Assert
            Assert.AreEqual(game.CurrentPlayer, "O");
        }

        [TestMethod]
        //Assert current player changes to X after O
        public void changePlayer_CurrentPlayerisX()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.changePlayer();
            game.changePlayer();

            //Assert
            Assert.AreEqual(game.CurrentPlayer, "X");
        }

        //Assert that an X is placed on the board
        [TestMethod]
        public void makeMove_CurrentPlayerPlacesX()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.makeMove(2, 2);

            //Assert           
            Assert.AreEqual(game.Board[2, 2], "X");
        }


        //Assert that an O is placed on the board
        [TestMethod]
        public void makeMove_CurrentPlayerPlacesO()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.makeMove(2, 2);
            game.makeMove(2, 1);

            //Assert
            Assert.AreEqual(game.Board[2, 1], "O");
        }

        //Assert that a space is occupied after a move takes place at that index
        [TestMethod]
        public void spaceInUse_SpotIsOccupied()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.makeMove(2, 2);
            game.makeMove(2, 2);

            //Assert
            Assert.AreEqual(true, game.spaceInUse(2, 2));
            Assert.AreEqual(game.Board[2, 2], "X");
        }

        [TestMethod]
        //Assert that a given space is unoccupied after a move to a different space
        public void spaceInUse_SpotIsUnoccupied()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.createBoard();
            game.makeMove(2, 2);         

            //Assert
            Assert.AreEqual(false, game.spaceInUse(2, 0));
            Assert.AreEqual(game.Board[2, 0], null);
        }
    }
}
