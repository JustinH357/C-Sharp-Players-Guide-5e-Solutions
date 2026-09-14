namespace PackingInventory
{
    internal class Arrow : InventoryItem
    {
        public Arrow() : base(0.1, 0.05)
        {

        }

        public new string ToString() => "Arrow";
    }
}
