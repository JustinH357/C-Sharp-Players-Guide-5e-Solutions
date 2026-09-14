namespace PackingInventory
{
    internal class Bow : InventoryItem
    {
        public Bow() : base(1, 4)
        {

        }

        public new string ToString() => "Bow";
    }
}
