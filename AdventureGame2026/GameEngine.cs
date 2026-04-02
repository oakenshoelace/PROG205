using static AdventureGame2026.Utility;
using static System.Console;

namespace AdventureGame2026
{
    class GameEngine
    {
        public void ConsoleWindow()
        {
            Console.Title = "Land of Avonu";
            Console.ForegroundColor = ConsoleColor.Green;
        }

        //multiple worlds
        public List<World> Worlds { get; set; } = new List<World>();
        public Person Player;
        public Merchant Harmony;
        World CurrentWorld;
        public bool hasBread;
        int playerChoice;
        int encounterNum = 0;
        public string bear = @"
 __| |___________________________________________________________________| |___
(__   ___________________________________________________________________   ___)
   | |                                                                   | |
   | |                                                                   | |
   | |                                                                   | |
   | |    ____  ____  _  _   __   ____  ____    ____  ____   __   ____   | |
   | |   (  _ \(  __)/ )( \ / _\ (  _ \(  __)  (  _ \(  __) / _\ (  _ \  | |
   | |    ) _ ( ) _) \ /\ //    \ )   / ) _)    ) _ ( ) _) /    \ )   /  | |
   | |   (____/(____)(_/\_)\_/\_/(__\_)(____)  (____/(____)\_/\_/(__\_)  | |
   | |                                                                   | |
   | |                                                                   | |
 __| |dc_________________________________________________________________| |__
(__   ___________________________________________________________________   __)
   | |                                                                   | |
";

        public string dog = @"    ___
 __/ / \
|    |/\
|_--\   \              /-
     \   \-___________/ /
      \                :
      |                :
      |       ___ \    )
       \|  __/     \  )
        | /         \  \
        |l           ( l
        |l            ll
        |l            |l
       / l           / l
       --/           --";
        public string end = @"
  _   _                           _ 
 | | | |                         | |
 | |_| |__   ___    ___ _ __   __| |
 | __| '_ \ / _ \  / _ \ '_ \ / _` |
 | |_| | | |  __/ |  __/ | | | (_| |
  \__|_| |_|\___|  \___|_| |_|\__,_|
                                    
                                    ";

        public void SetUpWorld()
        {

            CurrentWorld = Worlds[0];
            CurrentWorld.WorldName = "The Land of Avonu";
            CurrentWorld.Description = "A familiar but distant place.";
            Title = CurrentWorld.title;

            Player = new Person("Alex", "Adventurer", false);
            Player.SetUpInventory();
            Harmony = new Merchant("Harmony", "General store owner");
            Harmony.SetUpWares();
            CurrentWorld.Locations = new List<Location>() {
                new Location
                {
                    LocationName = "Crossroads",
                    LocationDesc = "\nWhere roads meet and journeys begin."
                },
                new Location
                {
                    LocationName = "Cypio Village",
                    LocationDesc = "\nA quaint little village, it smells of toasted sesame and Jacinthe flowers."
                },
                new Location
                {
                    LocationName = "Tifor Creek",
                    LocationDesc = "\nA beautiful creek with a rushing stream. The sunlight shining between the leaves makes it dream-like."
                },
                new Location
                {
                    LocationName = "Goose Forest",
                    LocationDesc = "\nA thick and sprawling forest, there are signs warning you to not go alone."
                }

            };

            Run();
        }
        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Print(Title);
            Console.Title = "Land of Avonu";
            Print(CurrentWorld.VisitWorld());

            Print($"You have been named {Player.Name}.");
            Print($"Would you like to change your name?");
            Print($"Enter y for yes. Any other key will begin the game.");
            string input = ReadLine();

            if (input.ToLower() == "y")
            {
                Print("Enter your new name:");
                string newName = ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    Player.Name = newName;
                }
                Print($"Your name has been changed to {Player.Name}.");
            }
            Print(Player.ShowInventory());

            menu();
            //Print($".....game starts here....\n \n");
            //Print("You are a lonely adventurer, finding yourself in a new land...\n");
            //
            for (encounterNum = 0; encounterNum <= 1; encounterNum++)
            {
                if (playerChoice == 1)
                {
                    Clear();
                    Print("You are a lonely adventurer, finding yourself in a new land...\n");
                    Print("You have chosen to begin your new adventure at The Crossroads, where you open yourself up to opportunity and new beginnings. There is nothing for you here... yet.\nSo you continue on...\n");
                    menu();
                }
                else if (playerChoice == 2)
                {
                    Clear();
                    Print("You are a lonely adventurer, finding yourself in a new land...\n");
                    Print("You have chosen to begin your new adventure in a quaint and warm village. As you enter their humble community, you take note of the people around you. There are hard-working people out and about, thriving in their corner of the world. Some tend to horses, others manage small market booths.\n\n(Press any key to continue)");
                    Print("\nThe smell of fresh bread draws you to the general store, where a friendly woman with ginger hair greets you.\n");
                    Print("\"Hello!\" She greets, \"What can I get for you?\" \n  1- See General Store Wares\n  2- Ask About Adventurer's Commissions");
                    if (encounterNum >= 1)
                    {
                        Print("  3- Open map");
                    }
                    input = ReadLine();
                    Print("(Press any key to continue)");
                    ReadKey();
                    if (input == "1")
                    {
                        Print(Harmony.ShowWares());
                        Print($"What would you like to purchase? You have {Player.Moneys} Moneys");
                        string purchase = ReadLine();
                        if (purchase == "1" && Player.Moneys > 0)
                        {
                            Player.Inventory.Add(new Item("Loaf of Bread", "A fresh loaf of generic oven-fired bread. It smells delicious.", 1.0));
                            Player.Moneys--;
                            hasBread = true;
                            Print($"You purchased a loaf of bread! It has been added to your inventory and you now have {Player.Moneys} Moneys left.\n\n(Press any key to continue)");
                        }
                        else if (purchase == "2" && Player.Moneys > 0)
                        {
                            Player.Inventory.Add(new Item("Box of Matches", "A small fire-starter. There is a drawing of a woman on the box.", 1.0));
                            Player.Moneys--;
                            Print($"You purchased a box of matches! It has been added to your inventory and you now have {Player.Moneys} Moneys left.\n\n(Press any key to continue)");
                        }
                        else if (purchase == "3" && Player.Moneys > 0)
                        {
                            Player.Inventory.Add(new Item("Blanket", "A warm blanket made of wool and linen.", 5.0));
                            Player.Moneys -= 5;
                            Print($"You purchased a blanket! It has been added to your inventory and you now have {Player.Moneys} Moneys left.\n\n(Press any key to continue)");
                        }
                        else
                        {
                            Print("You buy nothing. Exiting shop...\n\n(Press any key to return to Harmony's menu)");
                        }
                    }
                    else if (input == "2")
                    {
                        Print("\"Do you have any work for out-of-town adventurers?\" You ask.\n\nThe woman, whose name plaque reads \'Harmony,\' smiles at your question. She points to the receipt-holder on the counter,\"This is the commissions stack. you can claim any available requests.\" \n");
                        Print("\"Currently there is only one available quest, Liney is looking for their lost dog. You can talk to them in the town square for more information, they always sit by the fountain.\"");
                        ReadKey();
                        Console.Clear();
                        Print("You thank her and make your way outside, looking around for \'Liney\'\n\nThe town is quite scenic at midday. There are a few large trees lining the square and providing shade, some of them are still flowering with the remnants of spring. There is a humble fountain built into a wall on the far side of the square, away from the general store. There is a lonely person sitting there, drawing in a beaten-up book.\n");
                        Print($"'You must be Liney,\"You say as you approach, \"I'm {Player.Name}, I'm an adventurer here to take your commission!\"\nLiney's face lights up, \"Oh, thank goodness! We were painting in the creek and my poor little Roux heard a noise and ran off!\" They explain");
                        Print("\'Who even names a dog Roux?\' You think to yourself.\n\nLyney goes on, \'You should be able to attract him pretty easily, he likes bread.\' You nod politely and exchange courtesies, promising to bring Roux back by sundown.");
                        if (hasBread == true)
                        {
                            encounterNum++;
                        }
                        Print("\n(You need to buy at least 1 loaf of bread from Harmony to continue this quest)");

                    }
                    else if (input == "3")
                    {
                        menu();
                    }
                    ReadKey();
                    //encounterNum++;
                }
                else if (playerChoice == 3)
                {
                    Clear();
                    Print("You are a lonely adventurer, finding yourself in a new land...\n");
                    Print("You have chosen to begin your new adventure at the rushing creek, an omen of serenity. The leaves of the canopy above your head filters out just enough sunlight to keep the environment cool.\n");
                    Print("The constant sound of the stream soothes you, and you feel a breeze toss your hair. It's beautiful here.\nThere's nothing for you here yet.\n");
                    menu();
                }
                else if (playerChoice == 4)
                {
                    Clear();
                    Print("You are a lonely adventurer, finding yourself in a new land...\n");
                    Print("You have chosen to begin your adventure far away from people, in the secluded forest. As you make your way through the outer brush, you spot a sign warning of dangers ahead.\n");
                    Print("You push on, trying to get closer and read what the sign says. You notice large clawmarks on the tree the sign was nailed to. It reads:");
                    Print(bear);
                    Print("You turn around, deciding it may be best to leave this for when you're better prepared");
                    menu();
                }
                //encounterNum++;
                ReadKey();
            }

            for (encounterNum = 1; encounterNum < 1; encounterNum++)
            {
                menu();
                if (playerChoice == 1)
                {
                    Clear();
                    Print("You found yourself at The Crossroads, where you open yourself up to opportunity and new beginnings. There is nothing for you here... yet.\nSo you continue on...\n");
                    menu();
                }
                else if (playerChoice == 2)
                {
                    Clear();
                    Print("The walk back to the town is brisk; you and Roux race each other playfully on the way there. Why did you think you could outrun a farm dog?\n\nThe sun is setting on the town soon, and as soon as you reach the square, Lyney runs up to you.");
                    Print("\"You found him!\" They say, picking him up in their arms with little effort despite his size, \"Oh, thank you so much!\" They hand you 20 Moneys in cash. You nod respectfully and pet Roux one last time. Onto the next one.\n\n");
                    Player.Moneys += 20;
                    Print(end);
                }
                else if (playerChoice == 3)
                {
                    Clear();
                    Print("As you leave town and follow the map for Tifor Creek, you can hear the rushing water ahead, an omen of serenity. The leaves of the canopy above your head filters out just enough sunlight to keep the environment cool.\n");
                    Print("The constant sound of the stream soothes you, and you feel a breeze toss your hair. It's beautiful here.\n\nYou figure you should probably call for the dog now. You yell its name to no answer from the creek.");
                    ReadKey();
                    Print("You yell out a couple more times, deciding to give in and finally break out the bread. You take it out of your bag and break it in half, taking a moment to appreciate the craters formed by the yeast. \"Roux! Bread!\" You call out again, throwing a piece of crust into the bushes.");
                    Print("You hear a rustling, and then loud sniffing getting closer.\n");
                    ReadKey();
                    Print(dog);
                    Print("\n\nAh, there he is. He's pretty cute for a dog his size.\"Hey buddy,\" You say, giving a small piece of bread to him, \"Lyney's worried sick about you... But this was fairly easy, all in a day's work, I guess.\"");
                    Print("You take an extra moment to appreciate the sights and sounds of an early afternoon in the creek. You pet Roux, and he leans into your hand.\n\nYou should probably take him home soon.");
                    menu();
                }
                else if (playerChoice == 4)
                {
                    Clear();
                    Print("You make your way towards the sprowling secluded forest. As you make your way through the outer brush, you spot a sign warning of dangers ahead.\n");
                    Print("You push on, trying to get closer and read what the sign says. You notice large clawmarks on the tree the sign was nailed to. It reads:");
                    Print(bear);
                    Print("You turn around, deciding it may be best to leave this for when you're better prepared");
                    menu();
                }
            }

            //  ReadKey(); //temporary for window to stay open
        }

        private void menu()
        {
            Print(CurrentWorld.VisitWorld());
            //Print(CurrentWorld.LoadLoc(ConvertStringToInteger(CurrentWorld.GetPlayerChoice())));
            playerChoice = ConvertStringToInteger(CurrentWorld.GetPlayerChoice());
            if (playerChoice > 0 || playerChoice <= CurrentWorld.Locations.Count)
            {

                Print(CurrentWorld.LoadLoc(playerChoice - 1));
                Print("Press any key to continue.");
            }
            else
            {
                Print("Invalid location choice. Please enter a number from the list of locations.");
                ReadKey();
                menu();
            }

        }
    }
}