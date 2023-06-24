using static Lab04_TicTacToe.Classes.Board;
using static Lab04_TicTacToe.Classes.Game;
using Lab04_TicTacToe.Classes;

namespace TestTicTac
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			/*Board board = new Board();
			Player player1 = new Player();
			player1.Name ="Alaa";
			Player player2 = new Player();
			player1.Name = "Kady";
			Game Game = new Game(player1, player2);
			[Theory]
			[InlineData(true)]
			void CheckForWinner(bool expectedValue)
			{
				Game.Board.GameBoard[0, 0] = "X";
				Game.Board.GameBoard[1, 0] = "X";
				Game.Board.GameBoard[2, 0] = "X";

				Assert.Equal(expectedValue, Game.CheckForWinner(Game.Board));
			}*/

			[Fact]
			 void Play_TestForWinners()
			{
				// Arrange
				Player playerOne = new Player();
				playerOne.Name = "Alaa";
				playerOne.Marker = "X";
				Player playerTwo = new Player();
				playerTwo.Name = "Kadi";
				playerTwo.Marker = "O";
				Game game = new Game(playerOne, playerTwo);
				//Board board = new Board();
				game.Board.GameBoard[0, 0] = "X";
				game.Board.GameBoard[1, 0] = "X";
				game.Board.GameBoard[2, 0] = "X";
				// Act
				bool hasWinner = game.CheckForWinner(game.Board);
				// Assert
				Assert.Equal(hasWinner, true); }

			}

		[Fact]
		void Play_TestForNoWinners()
		{
			// Arrange
			Player playerOne = new Player();
			playerOne.Name = "Alaa";
			playerOne.Marker = "X";
			Player playerTwo = new Player();
			playerTwo.Name = "Kadi";
			playerTwo.Marker = "O";
			Game game = new Game(playerOne, playerTwo);
			
			//game.Board.GameBoard[0, 0] = "X";
			//game.Board.GameBoard[1, 0] = "X";
			//game.Board.GameBoard[2, 0] = "X";
			// Act
			bool hasWinner = game.CheckForWinner(game.Board);
			// Assert
			Assert.Equal(hasWinner, false);
		}

	

	[Fact]
	void Players_switch()
	{
		// Arrange
		Player player1 = new Player();
			player1.Name = "Alaa";
			player1.Marker = "X";
			player1.IsTurn = true;	
		Player player2= new Player();
			player2.Name = "Kadi";
			player2.IsTurn = false;
			player2.Marker = "O";
		Game game = new Game(player1, player2);
		//Board board = new Board();
		// Act
		game.SwitchPlayer();
			bool IsTurn = player1.IsTurn;
		// Assert
		Assert.Equal(IsTurn, false);
	}

		[Fact]
		void test_PositionForNumber()
		{
		
			Position position = Player.PositionForNumber(5);

			// Assert
			Assert.Equal(position,new Position(1, 1));
		}

	}

}
