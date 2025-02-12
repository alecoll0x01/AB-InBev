using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetSale
{
    /// <summary>
    /// Validator for GetSaleCommand that defines validation rules for sale retrieval command.
    /// </summary>
    public class GetSaleValidator : AbstractValidator<GetSaleCommand>
    {

        /// <summary>
        /// Initialize validator for GetSaleCommand
        /// </summary>
        public GetSaleValidator() 
        {
            RuleFor(sale => sale.Id).NotEmpty().WithMessage("Sale ID is required");
        }
    }
}
