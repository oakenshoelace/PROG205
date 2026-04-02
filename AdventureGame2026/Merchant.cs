namespace AdventureGame2026
{
    public class Merchant : Person
    {
        public Merchant(string name, string role)
        {
            Name = name;
            Role = role;
            Merchant = true;
            Moneys = 55;
        }

        public void SetUpWares()
        {
            Wares.Add(new Item("Loaf of Bread", "A fresh loaf of generic oven-fired bread. It smells delicious.", 1.0));
            Wares.Add(new Item("Box of Matches", "A small fire-starter. There is a drawing of a woman on the box.", 1.0));
            Wares.Add(new Item("Blanket", "A warm blanket made of wool and linen.", 5.0));
        }

        public string ShowWares()
        {
            string output = $"{Name}'s Shop:\n";
            int count = 1;
            foreach (Item temporaryItem in Wares)
            {
                output += $"{count}~ {temporaryItem.ItemName}: {temporaryItem.ItemDescription} (Price: {temporaryItem.Value})\n";
                count++;
            }

            return output;
        }
    }
}