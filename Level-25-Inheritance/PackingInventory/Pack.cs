namespace PackingInventory
{
    internal class Pack
    {
        public int totalItem { get; }
        public double maxWeight { get; }
        public double maxVolume { get; }
        private InventoryItem[] items;

        public int currentItem { get; set; }
        public double currentWeight { get; set; }
        public double currentVolume { get; set; }

        public Pack()
        {
            maxWeight = 10;
            maxVolume = 5;
            totalItem = 20;
            items = new InventoryItem[totalItem];
        }

        public bool Add(InventoryItem item)
        {
            if (currentVolume >= maxVolume || currentWeight >= maxWeight || currentItem >= totalItem)
            {
                return false; 
            }

            currentWeight += item._weight;
            currentVolume += item._volume;
            currentItem++;

            

            return true;
        }

        // there is nothing added to the items array so can't display whats in it
        public new string ToString()
        {
            string inventory = " ";
            foreach (InventoryItem item in items)
            {
                inventory = item + " ";
            }

            return $"Pack containing {inventory}";
        }

        // separate testing 
        public void PrintItems()
        {
            foreach (InventoryItem item in items)
            {
                Console.WriteLine(item + " ");
            }
            
            Console.WriteLine(items[1].ToString());
            Console.WriteLine(items[2].ToString());
            Console.WriteLine(items[3].ToString());
            Console.WriteLine(items[4].ToString());

        }
    }
}
