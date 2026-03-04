using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class QuotationDetail
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int QuotationId { get; set; }
        public Quotation? Quotation { get; set; }
        
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
