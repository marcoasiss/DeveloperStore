using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleResult
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string Branch { get; set; }
        public bool IsCancelled { get; set; }
        public int CustomerId { get; set; }
    }
}
