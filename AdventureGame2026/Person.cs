namespace AdventureGame2026

{

    public class Person
    {
        public static void Print(string input) => Console.WriteLine(input);

        public string Name;
        public string Role;
        public bool Merchant;
        public List<Item> Inventory = new List<Item>();
        public List<Item> Wares = new List<Item>();
        public double Moneys;

        // Constructor
        public Person(string name, string role, bool isMerchant)
        {
            Name = name;
            Role = role;
            Merchant = isMerchant;
            Moneys = 0;

        }

        public void SetUpInventory()
        {
            Inventory.Add(new Item("Map of the land", "A map made of rough canvas, it depicts the coastal nation of Avonu. There is a village, a creek and a forest.", 2.189));
            Inventory.Add(new Item("Bottle of Water", "A canteen full of water.", 1.0));
            Inventory.Add(new Item("Dagger", "A sharp blade mounted on a handle made of animal bone.", 5.0));
            Inventory.Add(new Item("Lantern", "An ornate metal lantern. You're not yet sure how to light it.", 0.0));
            //lantern cannot be sold
            Inventory.Add(new Item("Rope", "20 feet of sturdy rope", 2.5));
            Inventory.Add(new Food("Jello", "Weird food item", 1.5));
            Moneys = 10;
        }

        public Person()
        {
            SetUpInventory();
        }

        public string ShowInventory()
        {
            string output = $"{Name}'s Inventory:\n";
            //string output = Name + "'s Inventory:\n";

            foreach (Item temporaryItem in Inventory)
            {
                if (temporaryItem is Food)
                {
                    Food food = (Food)temporaryItem;
                    output += $"* {temporaryItem.ItemName}: {temporaryItem.ItemDescription} It has a taste value of {food.tasteLevel} (Price: {temporaryItem.Value})\n";
                }
                else
                {
                    output += $"~ {temporaryItem.ItemName}: {temporaryItem.ItemDescription} (Price: {temporaryItem.Value})\n";
                }
            }

            return output;
        }

    }
}
