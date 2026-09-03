namespace PackingInventory
{
    internal class InventoryItem
    {
        private double _weight {  get; set; }
        private double _volume { get; set; }

        public InventoryItem(double weight, double volume)
        {
            _weight = weight;
            _volume = volume;
        }
    }
}
