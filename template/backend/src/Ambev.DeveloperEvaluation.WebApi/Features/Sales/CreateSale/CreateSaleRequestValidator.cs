using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequestValidator: AbstractValidator<CreateSaleRequest>
    {
      
        public CreateSaleRequestValidator()
        {
            //RuleFor(sale => sale.TotalSaleAmount).GreaterThan(0);
        }
    }
}
