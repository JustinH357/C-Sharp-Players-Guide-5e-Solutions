namespace PackingInventory
{
    internal class FoodRations : InventoryItem
    {
        public FoodRations() : base(1, 0.5)
        {

        }

        public new string ToString() => "Food rations";
    }
}
