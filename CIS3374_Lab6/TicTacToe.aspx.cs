using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3374_Lab6
{
    public partial class TicTacToe : System.Web.UI.Page
    {

        Game game = new Game();

        protected void Page_Load(object sender, EventArgs e)
        {
            game.createBoard();
            string[,] board = game.Board;
            string player = game.CurrentPlayer;
        }
    }
}