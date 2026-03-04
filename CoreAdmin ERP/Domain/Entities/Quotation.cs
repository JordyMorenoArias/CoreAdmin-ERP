using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Quotation
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

        private readonly List<QuotationDetail> _quotationDetails = new();
        public IReadOnlyCollection<QuotationDetail> QuotationDetails => _quotationDetails;
    }
}
