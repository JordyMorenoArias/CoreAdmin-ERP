namespace CoreAdmin_ERP.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

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
