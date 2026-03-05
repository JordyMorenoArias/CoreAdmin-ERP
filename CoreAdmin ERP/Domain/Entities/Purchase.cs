namespace CoreAdmin_ERP.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }

        public DateTimeOffset PurchaseDate { get; set; }

        public decimal TotalAmount { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        private readonly List<PurchaseDetail> _purchaseDetails = new();
        public IReadOnlyCollection<PurchaseDetail> PurchaseDetails => _purchaseDetails;
    }
}
