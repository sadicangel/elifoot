using System.Drawing;
using Elifoot.Core.Entities;

namespace Elifoot.Screens
{
    partial class ClubScreen
    {
        partial void CustomInitialize()
        {
            var club = CreateClub();
            Label_ClubName.Text = club.Name;
            foreach (var player in club.Players)
            {
                ListBox_ClubPlayers.Items.Add(player.Name);
            }
        }

        private static Club CreateClub()
        {
            var europe = new Region { Name = "Europe" };
            var africa = new Region { Name = "Africa" };
            var america = new Region { Name = "America" };
            var asia = new Region { Name = "Asia" };

            var portugal = new Country
            {
                Code = "PT",
                Name = "Portugal",
                Region = europe,
            };

            var spain = new Country
            {
                Code = "ES",
                Name = "Spain",
                Region = europe,
            };

            var netherlands = new Country
            {
                Code = "NL",
                Name = "Netherlands",
                Region = europe,
            };

            var denmark = new Country
            {
                Code = "DK",
                Name = "Denmark",
                Region = europe,
            };

            var england = new Country
            {
                Code = "EN",
                Name = "England",
                Region = europe,
            };

            var sweden = new Country
            {
                Code = "SE",
                Name = "Sweden",
                Region = europe,
            };

            var greece = new Country
            {
                Code = "GR",
                Name = "Greece",
                Region = europe,
            };

            var coteDIvoire = new Country
            {
                Code = "CI",
                Name = "Côte d'Ivoire",
                Region = africa,
            };

            var mozambique = new Country
            {
                Code = "MZ",
                Name = "Mozambique",
                Region = africa,
            };

            var brazil = new Country
            {
                Code = "BR",
                Name = "Brazil",
                Region = america,
            };

            var uruguay = new Country
            {
                Code = "UY",
                Name = "Uruguay",
                Region = america,
            };

            var japan = new Country
            {
                Code = "JP",
                Name = "Japan",
                Region = asia,
            };

            var coach = new Coach { Name = "Rui Borges" };

            var sporting = new Club
            {
                Name = "Sporting Clube de Portugal",
                PrimaryColor = Color.Green,
                SecondaryColor = Color.White,
                Stadium = new Stadium { Name = "José Alvalade" },
                Country = portugal,
                Coach = coach,
            };

            sporting.Contracts.AddRange(
                new Contract
                {
                    Club = sporting,
                    Weeks = 63,
                    Salary = 10728,
                    Player = new Player
                    {
                        Name = "Antonio Adán",
                        Country = spain,
                        Power = 84,
                        IsStar = false,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.GoalKeeper,
                        Price = 21000000,
                        Stats = new PlayerStats
                        {
                            Wins = 23,
                            Draws = 2,
                            Losses = 6,
                            Goals = 9,
                            RedCards = 2,
                            YellowCards = 1,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 67,
                    Salary = 33971,
                    Player = new Player
                    {
                        Name = "Franco Israel",
                        Country = uruguay,
                        Power = 78,
                        IsStar = false,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.GoalKeeper,
                        Price = 19500000,
                        Stats = new PlayerStats
                        {
                            Wins = 19,
                            Draws = 3,
                            Losses = 9,
                            Goals = 17,
                            RedCards = 1,
                            YellowCards = 1,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 108,
                    Salary = 30752,
                    Player = new Player
                    {
                        Name = "Gonçalo Inácio",
                        Country = portugal,
                        Power = 88,
                        IsStar = true,
                        Conduct = PlayerConduct.Thug,
                        Position = PlayerPosition.Defender,
                        Price = 27000000,
                        Stats = new PlayerStats
                        {
                            Wins = 12,
                            Draws = 1,
                            Losses = 9,
                            Goals = 30,
                            RedCards = 1,
                            YellowCards = 4,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 134,
                    Salary = 28532,
                    Player = new Player
                    {
                        Name = "Ousmane Diomande",
                        Country = coteDIvoire,
                        Power = 86,
                        IsStar = true,
                        Conduct = PlayerConduct.FairPlay,
                        Position = PlayerPosition.Defender,
                        Price = 26500000,
                        Stats = new PlayerStats
                        {
                            Wins = 12,
                            Draws = 9,
                            Losses = 1,
                            Goals = 25,
                            RedCards = 2,
                            YellowCards = 0,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 166,
                    Salary = 19060,
                    Player = new Player
                    {
                        Name = "Matheus Reis",
                        Country = brazil,
                        Power = 82,
                        IsStar = false,
                        Conduct = PlayerConduct.Harmless,
                        Position = PlayerPosition.Defender,
                        Price = 20500000,
                        Stats = new PlayerStats
                        {
                            Wins = 29,
                            Draws = 10,
                            Losses = 10,
                            Goals = 23,
                            RedCards = 0,
                            YellowCards = 2,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 89,
                    Salary = 10222,
                    Player = new Player
                    {
                        Name = "Eduardo Quaresma",
                        Country = portugal,
                        Power = 79,
                        IsStar = false,
                        Conduct = PlayerConduct.Thug,
                        Position = PlayerPosition.Defender,
                        Price = 19750000,
                        Stats = new PlayerStats
                        {
                            Wins = 15,
                            Draws = 5,
                            Losses = 7,
                            Goals = 8,
                            RedCards = 1,
                            YellowCards = 2,
                            Injuries = 2
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 129,
                    Salary = 55084,
                    Player = new Player
                    {
                        Name = "Jeremiah St. Juste",
                        Country = netherlands,
                        Power = 83,
                        IsStar = false,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.Defender,
                        Price = 20750000,
                        Stats = new PlayerStats
                        {
                            Wins = 20,
                            Draws = 6,
                            Losses = 0,
                            Goals = 3,
                            RedCards = 1,
                            YellowCards = 3,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 138,
                    Salary = 18635,
                    Player = new Player
                    {
                        Name = "Ricardo Esgaio",
                        Country = portugal,
                        Power = 80,
                        IsStar = false,
                        Conduct = PlayerConduct.Gentleman,
                        Position = PlayerPosition.Defender,
                        Price = 20000000,
                        Stats = new PlayerStats
                        {
                            Wins = 28,
                            Draws = 5,
                            Losses = 7,
                            Goals = 15,
                            RedCards = 0,
                            YellowCards = 2,
                            Injuries = 2
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 185,
                    Salary = 20929,
                    Player = new Player
                    {
                        Name = "Nuno Santos",
                        Country = portugal,
                        Power = 84,
                        IsStar = false,
                        Conduct = PlayerConduct.Harmless,
                        Position = PlayerPosition.Midfielder,
                        Price = 21000000,
                        Stats = new PlayerStats
                        {
                            Wins = 11,
                            Draws = 0,
                            Losses = 4,
                            Goals = 19,
                            RedCards = 2,
                            YellowCards = 4,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 60,
                    Salary = 11681,
                    Player = new Player
                    {
                        Name = "Hidemasa Morita",
                        Country = japan,
                        Power = 83,
                        IsStar = false,
                        Conduct = PlayerConduct.Harmless,
                        Position = PlayerPosition.Midfielder,
                        Price = 20750000,
                        Stats = new PlayerStats
                        {
                            Wins = 30,
                            Draws = 4,
                            Losses = 2,
                            Goals = 1,
                            RedCards = 2,
                            YellowCards = 4,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 178,
                    Salary = 53725,
                    Player = new Player
                    {
                        Name = "Daniel Bragança",
                        Country = portugal,
                        Power = 81,
                        IsStar = false,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Midfielder,
                        Price = 20250000,
                        Stats = new PlayerStats
                        {
                            Wins = 8,
                            Draws = 6,
                            Losses = 5,
                            Goals = 25,
                            RedCards = 1,
                            YellowCards = 0,
                            Injuries = 2
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 206,
                    Salary = 41479,
                    Player = new Player
                    {
                        Name = "Morten Hjulmand",
                        Country = denmark,
                        Power = 84,
                        IsStar = false,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Midfielder,
                        Price = 21000000,
                        Stats = new PlayerStats
                        {
                            Wins = 13,
                            Draws = 3,
                            Losses = 8,
                            Goals = 26,
                            RedCards = 1,
                            YellowCards = 0,
                            Injuries = 1
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 202,
                    Salary = 50141,
                    Player = new Player
                    {
                        Name = "Pedro Gonçalves",
                        Country = portugal,
                        Power = 87,
                        IsStar = true,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Midfielder,
                        Price = 26750000,
                        Stats = new PlayerStats
                        {
                            Wins = 18,
                            Draws = 9,
                            Losses = 4,
                            Goals = 9,
                            RedCards = 1,
                            YellowCards = 2,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 115,
                    Salary = 29043,
                    Player = new Player
                    {
                        Name = "Trincão",
                        Country = portugal,
                        Power = 84,
                        IsStar = true,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Forward,
                        Price = 26000000,
                        Stats = new PlayerStats
                        {
                            Wins = 20,
                            Draws = 1,
                            Losses = 2,
                            Goals = 6,
                            RedCards = 0,
                            YellowCards = 1,
                            Injuries = 1
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 190,
                    Salary = 20754,
                    Player = new Player
                    {
                        Name = "Paulinho",
                        Country = portugal,
                        Power = 82,
                        IsStar = false,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.Forward,
                        Price = 20500000,
                        Stats = new PlayerStats
                        {
                            Wins = 16,
                            Draws = 5,
                            Losses = 10,
                            Goals = 23,
                            RedCards = 0,
                            YellowCards = 1,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 179,
                    Salary = 12440,
                    Player = new Player
                    {
                        Name = "Marcus Edwards",
                        Country = england,
                        Power = 85,
                        IsStar = true,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.Forward,
                        Price = 26250000,
                        Stats = new PlayerStats
                        {
                            Wins = 17,
                            Draws = 4,
                            Losses = 5,
                            Goals = 10,
                            RedCards = 2,
                            YellowCards = 5,
                            Injuries = 0
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 84,
                    Salary = 46369,
                    Player = new Player
                    {
                        Name = "Viktor Gyökeres",
                        Country = sweden,
                        Power = 92,
                        IsStar = true,
                        Conduct = PlayerConduct.Gentleman,
                        Position = PlayerPosition.Forward,
                        Price = 28000000,
                        Stats = new PlayerStats
                        {
                            Wins = 23,
                            Draws = 0,
                            Losses = 8,
                            Goals = 1,
                            RedCards = 0,
                            YellowCards = 3,
                            Injuries = 1
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 207,
                    Salary = 17609,
                    Player = new Player
                    {
                        Name = "Geny Catamo",
                        Country = mozambique,
                        Power = 79,
                        IsStar = false,
                        Conduct = PlayerConduct.FairPlay,
                        Position = PlayerPosition.Midfielder,
                        Price = 19750000,
                        Stats = new PlayerStats
                        {
                            Wins = 20,
                            Draws = 5,
                            Losses = 9,
                            Goals = 8,
                            RedCards = 1,
                            YellowCards = 5,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 138,
                    Salary = 25833,
                    Player = new Player
                    {
                        Name = "Iván Fresneda",
                        Country = spain,
                        Power = 77,
                        IsStar = false,
                        Conduct = PlayerConduct.Sanguinary,
                        Position = PlayerPosition.Defender,
                        Price = 19250000,
                        Stats = new PlayerStats
                        {
                            Wins = 19,
                            Draws = 8,
                            Losses = 10,
                            Goals = 29,
                            RedCards = 0,
                            YellowCards = 4,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 201,
                    Salary = 17877,
                    Player = new Player
                    {
                        Name = "Sotiris Alexandropoulos",
                        Country = greece,
                        Power = 78,
                        IsStar = false,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Midfielder,
                        Price = 19500000,
                        Stats = new PlayerStats
                        {
                            Wins = 18,
                            Draws = 9,
                            Losses = 0,
                            Goals = 5,
                            RedCards = 0,
                            YellowCards = 0,
                            Injuries = 3
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 173,
                    Salary = 54321,
                    Player = new Player
                    {
                        Name = "Rafael Pontelo",
                        Country = portugal,
                        Power = 74,
                        IsStar = false,
                        Conduct = PlayerConduct.Rough,
                        Position = PlayerPosition.Defender,
                        Price = 18500000,
                        Stats = new PlayerStats
                        {
                            Wins = 10,
                            Draws = 4,
                            Losses = 4,
                            Goals = 22,
                            RedCards = 0,
                            YellowCards = 0,
                            Injuries = 2
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 163,
                    Salary = 32881,
                    Player = new Player
                    {
                        Name = "Diogo Pinto",
                        Country = portugal,
                        Power = 72,
                        IsStar = false,
                        Conduct = PlayerConduct.Thug,
                        Position = PlayerPosition.GoalKeeper,
                        Price = 18000000,
                        Stats = new PlayerStats
                        {
                            Wins = 6,
                            Draws = 3,
                            Losses = 1,
                            Goals = 10,
                            RedCards = 2,
                            YellowCards = 0,
                            Injuries = 1
                        }
                    }
                },

                new Contract
                {
                    Club = sporting,
                    Weeks = 86,
                    Salary = 42342,
                    Player = new Player
                    {
                        Name = "João Muniz",
                        Country = portugal,
                        Power = 76,
                        IsStar = false,
                        Conduct = PlayerConduct.Gentleman,
                        Position = PlayerPosition.Defender,
                        Price = 19000000,
                        Stats = new PlayerStats
                        {
                            Wins = 7,
                            Draws = 0,
                            Losses = 0,
                            Goals = 14,
                            RedCards = 1,
                            YellowCards = 0,
                            Injuries = 1
                        }
                    }
                });

            return sporting;
        }
    }
}
