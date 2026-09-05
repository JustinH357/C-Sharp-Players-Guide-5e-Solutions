namespace PackingInventory
{
    internal class InventoryItem
    {
        public double _weight {  get; set; }
        public double _volume { get; set; }

        public InventoryItem(double weight, double volume)
        {
            _weight = weight;
            _volume = volume;
        }
    }
}
