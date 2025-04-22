using System.ComponentModel.DataAnnotations.Schema;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;



public class Sales : BaseEntity
{
    public int Id { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalSaleAmount { get; set; }
    public string Branch { get; set; }
    public bool IsCancelled { get; set; }

    // Customer relationship
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    // Sale items collection
    public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
}

public class SaleItem
{
    // Composite primary key (SalesId + ProductId)
    public int SalesId { get; set; }  // Part of composite key
    public int ProductId { get; set; } // Part of composite key AND foreign key

    // No separate Id field
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    // Navigation to Product only
    public Product Product { get; set; }

    // Computed property
    [NotMapped]
    public decimal TotalItemAmount => (UnitPrice * Quantity) - Discount;
}
