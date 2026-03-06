namespace CoreAdmin_ERP.Domain.Entities
{
    public class QuotationDetail
    {
        public int Id { get; set; }
        
        public int QuotationId { get; set; }
        public Quotation? Quotation { get; set; }
        
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Subtotal { get; set; }
    }
}
