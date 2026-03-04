using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class PurchaseDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PurchaseId { get; set; }
        public Purchase? Purchase { get; set; }
        
        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitCost { get; set; }

        [Required]
        public decimal Subtotal { get; set; }
    }
}
