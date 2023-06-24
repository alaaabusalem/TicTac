using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
		public static void Main(string[] args)
        {
            StartGame();

		}

		public static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
           
            
            Player player1= new Player();
            Console.WriteLine($"Please Enter Player 1 Name");
            string Name1 =Console.ReadLine();
            if(Name1 == null) {
                player1.Name = "player number 1";
            }
            else { 
            player1.Name = Name1;
			}
            player1.Marker = "X";
            player1.IsTurn = true;  
			Player player2= new Player();
			Console.WriteLine($"Please Enter Player 2 Name");
			string Name2 = Console.ReadLine();
            if (Name1 == null)
            {
                player2.Name = "player number 2";
            }
            else
            {
                player2.Name = Name2;
            }
            player2.Marker = "O";
            player2.IsTurn = false;

			Game game = new Game(player1,player2);
            
            game.Winner=game.Play();
            if (game.Winner == null)
            {
                Console.WriteLine();
                Console.WriteLine("sorry!No one winne ");
            }
            else
            {
				Console.WriteLine($"the winner is {game.Winner.Name}  yahooooooooooo");
			}
            
		}


    }
}
