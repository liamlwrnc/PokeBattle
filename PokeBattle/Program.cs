namespace Poke_Battle
{
    // defining the properties of the Pokemon class so any future instances will share these properties
    class Pokemon
    {
        public int Id;
        public string Name;
        public int Health;
        public int Attack;
        public string Move;
    }

    // im now creating lists of both my rivals and my own pokemon so I can select from them to decide who is battling who
    class Program
    {
        static List<Pokemon> garyPokemon = new List<Pokemon>() {
            new Pokemon {
                Id = 1,
                Name = "Mr.Mime",
                Health = 250,
                Attack = 500,
                Move = "Psychic"
            },
            new Pokemon {
                Id = 2,
                Name = "Dragonite",
                Health = 600,
                Attack = 600,
                Move = "Hyper Beam"
            },
            new Pokemon {
                Id = 3,
                Name= "Electrode",
                Health = 300,
                Attack = 300,
                Move = "Explode"
            },
            new Pokemon {
                Id = 4,
                Name = "Lapras",
                Health = 500,
                Attack = 350,
                Move = "Water Cannon"
            },
            new Pokemon {
                Id=5,
                Name = "Haunter",
                Health = 400,
                Attack = 350,
                Move = "Night Shade"
            },
            new Pokemon {
                Id = 6,
                Name = "Zapdos",
                Health = 500,
                Attack = 350,
                Move = "Thunder"
            }
        };

        static List<Pokemon> myPokemon = new List<Pokemon>() {
            new Pokemon {
                Id = 1,
                Name = "Blastoise",
                Health = 400,
                Attack = 350,
                Move = "Hydro Pump"
            },
            new Pokemon {
                Id = 2,
                Name = "Charizard",
                Health = 500,
                Attack = 500,
                Move = "Fire Blast"
            },
            new Pokemon {
                Id = 3,
                Name = "Venasaur",
                Health= 600,
                Attack = 450,
                Move = "Razor Leaf"
            },
            new Pokemon {
                Id = 4,
                Name = "Arcanine",
                Health = 400,
                Attack = 400,
                Move = "Flamethrower"
            },
            new Pokemon {
                Id = 5,
                Name = "Mewtwo",
                Health = 1000,
                Attack = 1000,
                Move = "Psystrike"
            },
            new Pokemon {
                Id = 6,
                Name = "Articuno",
                Health = 500,
                Attack = 350,
                Move = "Ice Breath"
            }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Your rival Gary wants to battle!");
            Console.WriteLine("Do you accept? (yes or no)");

            string input = Console.ReadLine();
            string text = "";

            if (input == "yes")
                text = "Yeah let's show him whos boss!";
            else
                text = "This is no time to chicken out! We're doing this!";

            Console.WriteLine(text);
            Console.ReadLine();

            // this will randomly select an entry from the list garyPokemon to set our opponent
            var rnd = new Random();
            var randomChoice = garyPokemon[rnd.Next(garyPokemon.Count)];

            Console.WriteLine("please choose your pokemon\n");

            //using a foreach loop here to print out each element of the list individually

            foreach (var pokemon in myPokemon)
            {
                Console.WriteLine($"{pokemon.Id} {pokemon.Name}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice)) // this converts my string to an int which enables me to use a simple comparison operator later on
            {
                if (choice == 1)
                    text = "Blastoise, the water type. Lets blast'em away!";
                else if (choice == 2)
                    text = "Charizard, the fiery dragon! We'll see if they can handle the heat!";
                else if (choice == 3)
                    text = "Venasaur, the plant type. They won't know what hit them!";
                else if (choice == 4)
                    text = "Arcanine, the fiery canine pokemon!";
                else if (choice == 5)
                    text = "Mewtwo, the most powerful pokemon of them all!";
                else
                    text = "Articuno, the legendary bird of ice!";

                Console.WriteLine(text);
                Console.ReadLine();

                // now we assign our typed choice to the correct pokemon in our list
                var myChoice = myPokemon[choice - 1]; // index starts at 0 but 1+ looks better

                Console.WriteLine("");
                Console.WriteLine("Gary: Hehe this is gonna be too easy! I choose you, " + randomChoice.Name + "!\n");
                Console.WriteLine("Thats what you think! Lets go, " + myChoice.Name + "!\n");

                // the above code was initially commented out as I realised I wouldnt be able to use a comparison operator to determine a winner when 
                // randomChoice was an int and myChoice would be a string. Upon discovering the TryParse function however, I was able to make it work

                Console.WriteLine("Type Go to Attack!");
                input = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(randomChoice.Name + " used " + randomChoice.Move + "!\n");
                Console.WriteLine(myChoice.Name + " used " + myChoice.Move + "!\n");
                Console.WriteLine("The ground trembles as these two titans engage in a fierce battle. However, there can be only one winner!\n");

                if (randomChoice.Attack > myChoice.Health)
                    text = "Oh no! He got us this time! We'll be back though, stronger than ever!";
                else if (myChoice.Attack > randomChoice.Health)
                    text = "We won! That was too easy. Looks like you need to do some training!";
                else
                    text = "It's a draw! Lucky we went easy on ya";

                Console.WriteLine(text);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That wasn't a valid choice!");
            }
        }
    }
}