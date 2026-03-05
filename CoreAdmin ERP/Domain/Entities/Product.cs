namespace CoreAdmin_ERP.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal UnitPrice { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

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
