using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale
{
    public class DeleteSaleCommand: IRequest<DeleteSaleResponse>
    {

        public int Id { get; }

        public DeleteSaleCommand(int id)
        {
            Id = id;
        }
    }

}
