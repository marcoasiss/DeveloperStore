using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequest
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string Branch { get; set; }
        public bool IsCancelled { get; set; }

        // Customer relationship
        public int CustomerId { get; set; }
        //public Customer Customer { get; set; }

        // Sale items collection
        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}