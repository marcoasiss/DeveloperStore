using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleCommand: IRequest<CreateSaleResult>
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string Branch { get; set; }
        public bool IsCancelled { get; set; }

        // Relacionamento com Customer (um-para-um)
        public int CustomerId { get; set; } 

        // Relacionamento com SaleItems (um-para-muitos)
        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();

        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
