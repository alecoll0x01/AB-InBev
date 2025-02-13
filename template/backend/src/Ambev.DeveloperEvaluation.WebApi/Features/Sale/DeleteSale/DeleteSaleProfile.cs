using Ambev.DeveloperEvaluation.Application.Sale.DeleteUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.DeleteSale
{

    /// <summary>
    /// Profile for mapping between Sale entity and DeleteSaleResponse
    /// </summary>
    public class DeleteSaleProfile : Profile
    {

        /// <summary>
        /// Initialize DeleteSaleProfile
        /// </summary>
        public DeleteSaleProfile()
        {
            CreateMap<Guid, DeleteSaleCommand>().
                ConstructUsing(id => new DeleteSaleCommand(id));
        }
    }
}
