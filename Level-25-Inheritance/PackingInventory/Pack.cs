namespace PackingInventory
{
    internal class Pack
    {
        private int totalItem;
        private double maxWeight;
        private double maxVolume;
        private int[] items;

        public Pack()
        {
            //totalItem = 3;
            maxWeight = 10;
            maxVolume = 5;
            items = new int[3];
        }

        public bool Add(InventoryItem item)
        {
            if (item._volume == maxVolume || item._weight == maxWeight || items.Length-1 > items.Length)
            {
                return false; // if exceed max of vol and weight, return false as in can't add no mores
            }

            return true;
        }
    }
}
