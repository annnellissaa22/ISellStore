namespace API.Entities
{
    public class Reserve
    {

         public int Id { get; set; }

        public string BuyerId { get; set; }

         public List<ReserveItem> Items { get; set; } = new();

        public void AddItem(Product product, int quantity)
        {
            if(Items.All(Item => Item.ProductId != product.Id))
            {
              Items.Add(new ReserveItem{Product = product, Quantity = quantity});
            }

            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id)  ;
            if(existingItem != null) existingItem.Quantity += quantity;

         }
         public void RemoveItem(int productId, int quantity)
         {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);  
            if (item == null) return;
            item.Quantity -= quantity;
            if(item.Quantity == 0) Items.Remove(item);
         }
    }
}