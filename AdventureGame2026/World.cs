
//using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame2026
{
    public class World
    {
        public string WorldName;
        public string Description;
        public Person Player;
        public Person NPCMerchant;
        private string title = @"
                                                                                                  
,------. ,--.                         ,--.      ,------.,--.  ,--.           ,-.                  
|  .--. '|  | ,--,--.,--,--,  ,---. ,-'  '-.    |  .---''.  \ |  ,---.  ,---.'. \ ,--,--,  ,---.  
|  '--' ||  |' ,-.  ||      \| .-. :'-.  .-'    |  `--,   `--'|  .-.  || .-. ||  ||      \| .-. : 
|  | --' |  |\ '-'  ||  ||  |\   --.  |  |      |  `---.      |  | |  |' '-' '|  ||  ||  |\   --. 
`--'     `--' `--`--'`--''--' `----'  `--'      `------'      `--' `--' `---'.' / `--''--' `----' 
                                                                             `-'                                        

";

        //https://programmingisfun.com/command-line-ascii-design/
        //string title = @"";
        //Console.WriteLine(title);
        public void SetUpWorld()
        {

            string output = $"Welcome to {WorldName}!\n{Description}\nThese are the available locations:\n";
            int choiceNum = 1;
            foreach (Location location in Locations)
            {
                output += $"    {choiceNum}. {location.LocationName}.\n";
                choiceNum++;
            }
            return output;


            Player = new Person("Alex", "Adventurer");
            NPCMerchant = new Person("Zara", "Merchant");
            Run();
        }
        public void Run()
        {
            Console.WriteLine(title);
            Console.WriteLine($"Welcome to {WorldName}!");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"You have been named {Player.Name}.");
            Console.WriteLine($"Would you like to change your name?");
            Console.WriteLine($"Enter y for yes. Any other key will begin the game.");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                Console.WriteLine("Enter your new name:");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    Player.Name = newName;
                }
                Console.WriteLine($"Your name has been changed to {Player.Name}.");
            }
            Console.WriteLine($".....game starts here....");
            Console.ReadKey(); //temporary for window to stay open
        }
    }
}