using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {

        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.TotalSaleAmount).GreaterThan(0);
        }
    }
}
