using ShipBattleLibrary;
using ShipBattleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Ship Battle, based on the game " +
                "Battleship");
            Console.WriteLine("Designed by Tim Corey");
            Console.WriteLine("Built and modified by Chris Stelly\n");
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            // Ask for player name
            output.PlayerName = AskForPlayerName();

            // Load the shot grid
            GameLogic.InitializeGrid(output);

            // Ask for ship locations
            
            
            // Clear
        }

        private static string AskForPlayerName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        // This is here becase it needs UI
        private static void PlaceShips(PlayerInfoModel player)
        {
            do
            {
                Console.Write($"Where do you want to place ship number " +
                    $"{ player.PlayerShipLocations.Count + 1 }: ");
                string location = Console.ReadLine();
            } while (player.PlayerShipLocations.Count < 5); // May make dynamic
        }
}
