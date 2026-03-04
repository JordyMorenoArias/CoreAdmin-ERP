using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        
        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal Subtotal { get; set; }
    }
}
