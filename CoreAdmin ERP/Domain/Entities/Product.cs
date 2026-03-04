using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public decimal UnitPrice { get; set; }

        [Required, MaxLength(100)]
        public int StockQuantity { get; set; }

        [Required, MaxLength(100)]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required, MaxLength(100)]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool IsActive { get; set; } = true;

        private readonly List<InvoiceDetail> _invoiceDetails = new();
        public IReadOnlyCollection<InvoiceDetail> InvoiceDetails => _invoiceDetails;

        private readonly List<PurchaseDetail> _purchaseDetails = new();
        public IReadOnlyCollection<PurchaseDetail> PurchaseDetails => _purchaseDetails;
    }
}
