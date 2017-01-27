using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BaseballDB
{
    class Program
    {
        static string Read(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            using (var db = new BaseballContext())
            {
                while (true)
                {
                    Console.WriteLine("(P) for new Player");
                    Console.WriteLine("(T) for new Team");
                    Console.WriteLine("(S) for new Stat");
                    var selection = Read("> ");
                    switch (selection.ToUpper())
                    {
                        case "P":
                            CreatePlayer(db);
                            break;
                        case "T":
                            CreateTeam(db);
                            break;
                        case "S":
                            CreateStat(db);
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }
            }
        }

        private static void CreateStat(BaseballContext db)
        {
            var playername = Read("Enter Player name...");
            var ip = double.Parse(Read("Enter IP..."));
            var so = double.Parse(Read("Enter SO..."));
            var era = double.Parse(Read("Enter ERA..."));
            Stat newStat = new Stat
            {
                Name = playername,
                IP = ip,
                SO = so,
                ERA = era,

            };
            db.Stat.Add(newStat);
            db.SaveChanges();
        }

        private static void CreateTeam(BaseballContext db)
        {
            var team = Read("Enter team name...");
            Team newTeam = new Team
            {
                TeamName = team,
            };
            db.Team.Add(newTeam);
            db.SaveChanges();
        }

        private static void CreatePlayer(BaseballContext db)
        {
            var name = Read("Enter player name...");
            var number = int.Parse(Read("Enter player number..."));
            var team = Read("Enter player team...");

            Player newPlayer = new Player
            {
                Name = name,
                Team = team,
                Number = number,
            };
            db.Player.Add(newPlayer);
            db.SaveChanges();
        }
    }
}
