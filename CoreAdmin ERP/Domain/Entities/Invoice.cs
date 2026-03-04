using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTimeOffset IssueDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        private readonly List<InvoiceDetail> _invoiceDetails = new();
        public IReadOnlyCollection<InvoiceDetail> InvoiceDetails => _invoiceDetails;
    }
}
