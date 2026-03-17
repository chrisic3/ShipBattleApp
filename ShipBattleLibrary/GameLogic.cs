using ShipBattleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShipBattleLibrary
{
    public static class GameLogic
    {
        // This is here because it needs no UI
        public static void InitializeGrid(PlayerInfoModel player)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(player, letter, number);
                }
            }
        }

        private static void AddGridSpot(PlayerInfoModel player, string letter,
            int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            player.PlayerShots.Add(spot);
        }

        public static void MarkShotResult(PlayerInfoModel currentPlayer, string row, int column, bool isAHit)
        {
            // TODO: MarkShotResult
            throw new NotImplementedException();
        }

        public static bool PlaceShip(PlayerInfoModel player, string location)
        {
            // TODO: PlaceShip
            throw new NotImplementedException();
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            // TODO: SplitShotIntoRowAndColumn
            throw new NotImplementedException();
        }

        public static bool ValidateShot(PlayerInfoModel currentPlayer, string row, int column)
        {
            // TODO: ValidateShot
            throw new NotImplementedException();
        }

        public static bool GameOver(PlayerInfoModel player)
        {
            bool isGameOver = true;

            foreach (GridSpotModel ship in player.PlayerShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isGameOver = false;
                }
            }

            return isGameOver;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int output = 0;

            foreach (GridSpotModel shot in player.PlayerShots)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    output++;
                }
            }

            return output;
        }

        public static bool IdentifyShotResults(PlayerInfoModel opponent, string row, int column)
        {
            // TODO: IdentifyShotResults
            throw new NotImplementedException();
        }

    }
}
