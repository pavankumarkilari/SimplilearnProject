using System;
using System.Collections.Generic;

namespace PlayerAndRequirements
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            Player player = new Player();
            while (true)
            {
                Console.Write("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players: ");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("Enter Player Id:");
                        player.PlayerId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Player Name:");
                        player.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age:");
                        player.PlayerAge = int.Parse(Console.ReadLine());
                        team.Add(player);
                        break;
                    case 2:
                        Console.Write("Enter Player Id:");
                        int IdToRemove = int.Parse(Console.ReadLine());
                        team.Remove(IdToRemove);
                        break;
                    case 3:
                        Console.Write("Enter Player Id:");
                        int IdToFind = int.Parse(Console.ReadLine());
                        Console.WriteLine(team.GetPlayerById(IdToFind));
                        break;
                    case 4:
                        Console.Write("Enter Player Name:");
                        string NameToFind = Console.ReadLine();
                        Console.WriteLine(team.GetPlayerByName(NameToFind));
                        break;
                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        foreach (Player getPlayer in allPlayers)
                        {
                            Console.WriteLine($"{getPlayer.PlayerId}\t{getPlayer.PlayerName}  {getPlayer.PlayerAge}");
                        }
                        break;
                    default:
                        Console.WriteLine("Error! Please enter a valid option.");
                        break;
                }
                Console.Write("Do you want to continue (yes/no)?:");
                string YesOrNo = Console.ReadLine();
                if (YesOrNo == "no")
                {
                    break;
                }
            }
            
        }
    }
}
