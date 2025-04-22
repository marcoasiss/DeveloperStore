using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleProfile:Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Ambev.DeveloperEvaluation.Domain.Entities.Sales>();
            CreateMap<Ambev.DeveloperEvaluation.Domain.Entities.Sales, CreateSaleResult>();

        }
    }
}
