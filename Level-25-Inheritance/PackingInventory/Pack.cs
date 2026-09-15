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

            items[currentItem] = item; // currentItem is being incremented so it works as the index to add the item to array

            currentWeight += item._weight;
            currentVolume += item._volume;
            currentItem++;

            return true;
        }

        // works now. it didnt work because I was using the "new" keyword which I was suppose to use "override" keyword
        // needed to do += the strings to inventory so it can add the strings of each item.ToString() override version
        // doing ToString() at the element or index works since doing foreach item in items of item.ToString() gives a null error
        public override string ToString()
        {
            string inventory = "";
            for (int i = 0; i < currentItem; i++)
            {
                inventory += items[i].ToString() + " "; 
            }

            return inventory;
        }
    }
}
