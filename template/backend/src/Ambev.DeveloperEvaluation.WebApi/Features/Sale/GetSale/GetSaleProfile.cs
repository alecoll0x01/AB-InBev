using Ambev.DeveloperEvaluation.Application.Sale.GetSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.GetSale
{
    /// <summary>
    /// Profile for mapping GetSale feature requests
    /// </summary>
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSale operation
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<Guid, GetSaleCommand>().
                ConstructUsing(id => new GetSaleCommand(id));
        }
    }
}
