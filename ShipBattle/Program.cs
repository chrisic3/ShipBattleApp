using ShipBattleLibrary;
using ShipBattleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UILogic.WelcomeMessage();

            PlayerInfoModel player1 = UILogic.CreatePlayer("Player 1");
            PlayerInfoModel player2 = UILogic.CreatePlayer("Player 2");

            PlayerInfoModel winner = null;
            PlayerInfoModel currentPlayer = player1;
            PlayerInfoModel opponent = player2;

            do
            {
                UILogic.DisplayShotGrid(currentPlayer);

                UILogic.RecordPlayerShot(currentPlayer, opponent);

                bool isGameOver = GameLogic.GameOver(opponent);

                if (isGameOver)
                {
                    winner = currentPlayer;
                }
                else
                {
                    // Neat trick using Tuples to swap players
                    (currentPlayer, opponent) = (opponent, currentPlayer);
                }
            } while (winner == null);

            UILogic.DisplayWinner(winner);

            Console.ReadLine();
        }
    }
}
