﻿using Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    public class DeleteSaleProfile: Profile
    {
        public DeleteSaleProfile()
        {
            CreateMap<int, DeleteSaleCommand>()
            .ConstructUsing(Id => new DeleteSaleCommand(Id));
        }
    }

}
