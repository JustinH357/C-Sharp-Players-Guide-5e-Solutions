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
    }
}
