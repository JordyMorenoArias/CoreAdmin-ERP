namespace CoreAdmin_ERP.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }

        public DateTimeOffset IssueDate { get; set; }

        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        private readonly List<InvoiceDetail> _invoiceDetails = new();
        public IReadOnlyCollection<InvoiceDetail> InvoiceDetails => _invoiceDetails;
    }
}
