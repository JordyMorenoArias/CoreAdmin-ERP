using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTimeOffset PurchaseDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        private readonly List<PurchaseDetail> _purchaseDetails = new();
        public IReadOnlyCollection<PurchaseDetail> PurchaseDetails => _purchaseDetails;
    }
}
