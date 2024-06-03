namespace API.Entities
{
    public class ReserveItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //navigarea proprietatilor
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}