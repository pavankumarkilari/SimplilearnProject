using System;
using System.Collections.Generic;

namespace PlayerAndRequirements
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public int Capacity { get; set; }
        public OneDayTeam()
        {
             Capacity = 11;
        }
        public void Add(Player player)
        {
            if(oneDayTeam.Count<=Capacity)
            {
                Player newPlayer = new Player
                {
                    PlayerId = player.PlayerId,
                    PlayerName = player.PlayerName,
                    PlayerAge = player.PlayerAge
                };
                oneDayTeam.Add(newPlayer);
                Console.WriteLine("Player is added successfully");
            }
            else
            {
                Console.WriteLine("Unable to add a new player. Team is already formed with 11 players.");
            }
        }
        public void Remove(int playerId)
        {
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerId == playerId)
                {
                    oneDayTeam.Remove(player);
                    Console.WriteLine("Player is removed successfully");
                    return;
                }
            }
        }
        public Player GetPlayerById(int playerId)
        {
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerId == playerId)
                {
                    Console.Write($"{ player.PlayerId}\t\t{ player.PlayerName}\t{ player.PlayerAge}");
                }
            }
            return null;
        }
        public Player GetPlayerByName(string playerName)
        {
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerName == playerName)
                {
                    Console.Write($"{player.PlayerId}\t\t{player.PlayerName}\t{player.PlayerAge}");
                }
            }
            return null;
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
