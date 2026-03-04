using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Address { get; set; } = string.Empty;

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool IsActive { get; set; } = true;

        private readonly List<Invoice> _invoices = new();
        public IReadOnlyCollection<Invoice> Invoices => _invoices;

        private readonly List<Quotation> _quotations = new();
        public IReadOnlyCollection<Quotation> Quotations => _quotations;
    }
}
