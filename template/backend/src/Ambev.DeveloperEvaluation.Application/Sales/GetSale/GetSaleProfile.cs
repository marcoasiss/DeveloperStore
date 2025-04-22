using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleProfile: Profile
    {
        public GetSaleProfile()
        {
            CreateMap<int, GetSaleCommand>()
                .ConstructUsing(id => new Application.Sales.GetSale.GetSaleCommand(id));
        }
    }

}
