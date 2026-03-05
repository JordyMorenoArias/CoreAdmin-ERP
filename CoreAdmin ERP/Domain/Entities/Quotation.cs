using System.ComponentModel.DataAnnotations;

namespace CoreAdmin_ERP.Domain.Entities
{
    public class Quotation
    {
        public int Id { get; set; }

        public DateTimeOffset IssueDate { get; set; }

        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        private readonly List<QuotationDetail> _quotationDetails = new();
        public IReadOnlyCollection<QuotationDetail> QuotationDetails => _quotationDetails;
    }
}
