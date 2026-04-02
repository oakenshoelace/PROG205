namespace AdventureGame2026
{
    public class Item
    {
        public string ItemName = "Unknown Item";
        public string ItemDescription = "This item is unknowable.";
        public double Value = 0.0;

        public Item()
        {
        }

        public Item(string itemName, string itemDescription, double value)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            Value = value;
        }

    }
}
