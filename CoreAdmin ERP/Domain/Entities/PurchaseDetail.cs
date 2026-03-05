namespace CoreAdmin_ERP.Domain.Entities
{
    public class PurchaseDetail
    {
        public int Id { get; set; }

        public int PurchaseId { get; set; }
        public Purchase? Purchase { get; set; }
        
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }

        public decimal Subtotal { get; set; }
    }
}
