namespace BaseballDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaseballDB.BaseballContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BaseballDB.BaseballContext context)
        {
            Player P1 = new Player()
            {
                Id = 1,
                Name = "Kyle Hendricks",
                Number = 23,
                Team = "Chicago Cubs",
            };
            Player P2 = new Player()
            {
                Id = 2,
                Name = "Jon Lester",
                Number = 34,
                Team = "Chicago Cubs",
            };
            Player P3 = new Player()
            {
                Id = 3,
                Name = "Noah Syndergaard",
                Number = 34,
                Team = "New York Mets",
            };

            Player P4 = new Player()
            {
                Id = 4,
                Name = "Max Scherzer",
                Number = 31,
                Team = "Washington Nationals"
            };
            Player P5 = new Player()
            {
                Id = 5,
                Name = "Madison Bumgarner",
                Number = 40,
                Team = "San Franciso Giants"
            };
            Team CHC = new Team()
            {
                Id = 1,
                TeamName = "Chicago Cubs",
            };
            Team WSH = new Team()
            {
                Id = 2,
                TeamName = "Washington Nationals",
            };
            Team NYM = new Team()
            {
                Id = 3,
                TeamName = "New York Mets",
            };
            Team SFG = new Team()
            {
                Id = 4,
                TeamName = "San Francisco Giants",
            };
            Stat P1Stat = new Stat()
            {
                Id = 1,
                Name = "Kyle Hendricks",
                IP = 190,
                SO = 170,
                ERA = 2.13,
            };
            Stat P2Stat = new Stat()
            {
                Id = 2,
                Name = "Jon Lester",
                IP = 202.2,
                SO = 197,
                ERA = 2.44,
            };
            Stat P3Stat = new Stat()
            {
                Id = 3,
                Name = "Noah Syndergaard",
                IP = 183.2,
                SO = 218,
                ERA = 2.6,
            };
            Stat P4Stat = new Stat()
            {
                Id = 4,
                Name = "Madison Bumgarner",
                IP = 226.2,
                SO = 251,
                ERA = 2.74,
            };

            context.Player.Add(P1);
            context.Player.Add(P2);
            context.Player.Add(P3);
            context.Player.Add(P4);
            context.Player.Add(P5);
            context.Team.Add(CHC);
            context.Team.Add(SFG);
            context.Team.Add(WSH);
            context.Stat.Add(P4Stat);
            context.Stat.Add(P3Stat);
            context.Stat.Add(P2Stat);
            context.Stat.Add(P1Stat);

            context.SaveChanges();
        }
    }
}
