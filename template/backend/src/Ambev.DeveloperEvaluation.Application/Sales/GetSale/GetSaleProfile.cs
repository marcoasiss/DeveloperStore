using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleProfile: Profile
    {
        public GetSaleProfile()
        {
            CreateMap<int, GetSaleCommand>()
                .ConstructUsing(id => new Application.Sales.GetSale.GetSaleCommand(id));
                CreateMap<Ambev.DeveloperEvaluation.Domain.Entities.Sales, GetSaleResult>();
        }

    }

}
