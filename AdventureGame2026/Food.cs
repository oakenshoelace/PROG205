namespace AdventureGame2026
{
    public class Food : Item
    {
        public int tasteLevel;


        public Food(string itemName, string itemDescription, double value) : base()
        {
            ItemName = "Unknown food";
            ItemDescription = "You're not quite sure what this is...";
            Value = 0.0;
        }

    }
}