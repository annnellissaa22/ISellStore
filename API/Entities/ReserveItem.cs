using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("ReserveItems")]
    public class ReserveItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //navigarea proprietatilor
        public int ProductId { get; set; }

        public Product Product { get; set; }
        
        public int ReserveId { get; set; }

        public  Reserve Reserve { get; set; }
    }
}