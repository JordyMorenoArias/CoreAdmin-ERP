using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string CompanyName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string ContactName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Address { get; set; } = string.Empty;

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool IsActive { get; set; } = true;

        private readonly List<Purchase> _purchases = new();
        public IReadOnlyCollection<Purchase> Purchases => _purchases;

        private readonly List<Product> _products = new();
        public IReadOnlyCollection<Product> Products => _products;
    }
}
