using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetSaleResponse
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string Branch { get; set; }
        public bool IsCancelled { get; set; }
        public int CustomerId { get; set; }
    }
}
