using System;
using System.Collections.Generic;


namespace Hockey
{
    class Program
    {
        static void Main(string[] args)
        {
           
        //get a list of all players, display their name, position, team.
        Console.WriteLine("Here's a list of all the NHL players in my database!");
        Console.WriteLine("----------------");
        List<Player> players = GetPlayers();
        List<Team> teams = GetTeams();

        foreach(Player singlePlayer in players)
        {
            Console.WriteLine($"{singlePlayer.Name} is a {singlePlayer.Position} for the {singlePlayer.Team}.");
            Console.WriteLine("------------------------------------------------------------");
        }

        List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>
            {
                new Team
                {
                    Name = "Anaheim Ducks",
                    TeamId = 1
                },
                new Team
                {
                    Name = "Arizona Coyotes",
                    TeamId = 2
                },
                new Team
                {
                    Name = "Boston Bruins",
                    TeamId = 3
                },
                new Team
                {
                    Name = "Buffalo Sabres",
                    TeamId = 4
                },
                new Team
                {
                    Name = "Calgary Flames",
                    TeamId = 5
                },
                new Team
                {
                    Name = "Carolina Hurricanes",
                    TeamId = 6
                },
                new Team
                {
                    Name = "Chicago Blackhawks",
                    TeamId = 7
                },
                new Team
                {
                    Name = "Colorado Avalanche",
                    TeamId = 8
                },
                new Team
                {
                    Name = "Columbus Blue Jackets",
                    TeamId = 9
                },
                new Team
                {
                    Name = "Dallas Stars",
                    TeamId = 10
                },
                new Team
                {
                    Name = "Detroit Red Wings",
                    TeamId = 11
                },
                new Team
                {
                    Name = "Florida Panthers",
                    TeamId = 12
                },
                new Team
                {
                    Name = "Los Angeles Kings",
                    TeamId = 13
                },
                new Team
                {
                    Name = "Minnesota Wild",
                    TeamId = 14
                },
                new Team
                {
                    Name = "Nashville Predators",
                    TeamId = 15
                },
                new Team
                {
                    Name = "New Jersey Devils",
                    TeamId = 16
                },
                new Team
                {
                    Name = "New York Islanders",
                    TeamId = 17
                },
                new Team
                {
                    Name = "New York Rangers",
                    TeamId = 18
                },
                new Team
                {
                    Name = "Philadelphia Flyers",
                    TeamId = 19
                },
                new Team
                {
                    Name = "Pittsburgh Penguins",
                    TeamId = 20
                },
                new Team
                {
                    Name = "San Jose Sharks",
                    TeamId = 21
                },
                new Team
                {
                    Name = "Seattle Kraken",
                    TeamId = 22
                },
                new Team
                {
                    Name = "St. Louis Blues",
                    TeamId = 23
                },
                new Team
                {
                    Name = "Tampa Bay Lightning",
                    TeamId = 24
                },
                new Team
                {
                    Name = "Vegas Golden Knights",
                    TeamId = 25
                },
                new Team
                {
                    Name = "Washington Capitals",
                    TeamId = 26
                }
            };
            return teams;
        }

        List<Player> GetPlayers()
        {
            List<Player> players = new List<Player> 
            {
                new Player 
                {
                    Name = "Connor Mcdavid",
                    Position = "Center",
                    Team = "Edmonton Oilers"
                },
                new Player 
                {
                    Name = "Nathan Mackinnon",
                    Position = "Center",
                    Team = "Edmonton Oilers"
                },
                new Player 
                {
                    Name = "Leon Drasaitl",
                    Position = "Right-Wing",
                    Team = "Edmonton Oilers"
                },
                new Player 
                {
                    Name = "Filip Forsberg",
                    Position = "Left-Wing",
                    Team = "Nashville Predators"
                },
                new Player 
                {
                    Name = "Roman Josi",
                    Position = "Defenseman",
                    Team = "Nashville Predators"
                },
                new Player 
                {
                    Name = "Nikita Kucherov",
                    Position = "Center",
                    Team = "Tampa Bay Lightning"
                }

            };
            return players;
        }

        }
    }
}
