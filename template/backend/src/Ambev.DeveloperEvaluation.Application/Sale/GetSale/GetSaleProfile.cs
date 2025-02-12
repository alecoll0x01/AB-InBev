using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetSale
{

    /// <summary>
    /// Profile for GetSale
    /// </summary>
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initialize GetSaleProfile
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<GetSaleCommand, GetSaleResult>();
        }
    }
}
