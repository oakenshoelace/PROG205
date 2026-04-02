//using directives
namespace AdventureGame2026
{
    public class World
    {
        public string WorldName;
        public string Description;
        public List<Location> Locations = new List<Location>();
        public string title = @"
                                                                                                  
.____                       .___         _____     _____                           
|    |   _____    ____    __| _/   _____/ ____\   /  _  \___  ______   ____  __ __ 
|    |   \__  \  /    \  / __ |   /  _ \   __\   /  /_\  \  \/ /  _ \ /    \|  |  \
|    |___ / __ \|   |  \/ /_/ |  (  <_> )  |    /    |    \   (  <_> )   |  \  |  /
|_______ (____  /___|  /\____ |   \____/|__|    \____|__  /\_/ \____/|___|  /____/ 
        \/    \/     \/      \/                         \/                \/                                           

";


        //https://programmingisfun.com/command-line-ascii-design/
        //string title = @"";
        //Console.WriteLine(title);

        public string VisitWorld()
        {

            string output = $"Welcome to {WorldName}!\n{Description}\nThese are the available locations:\n";
            int choiceNum = 1;
            foreach (Location location in Locations)
            {
                output += $"    {choiceNum}. {location.LocationName}.\n";
                choiceNum++;
            }
            return output;


        }

        public string GetPlayerChoice()
        {
            return Utility.GetUserInput("Type the number of your desired location.");
        }

        public string LoadLoc(int locIndex)
        {
            return $"{Locations[locIndex].LocationName}: {Locations[locIndex].LocationDesc}";
        }
    }
}