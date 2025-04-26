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

public class SaleItem : BaseEntity
{
    public int Id { get; set; }  
    public int ProductId { get; set; }                                       
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }


    // Computed property
    [NotMapped]
    public decimal TotalItemAmount => (UnitPrice * Quantity) - Discount;
}
