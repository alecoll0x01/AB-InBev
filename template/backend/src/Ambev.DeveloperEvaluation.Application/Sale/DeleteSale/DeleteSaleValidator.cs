using Ambev.DeveloperEvaluation.Application.Sale.DeleteUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteSale
{
    /// <summary>
    /// Validator for sale deletion command that defines validation rules for sale deletion command.
    /// </summary>
    public class DeleteSaleValidator : AbstractValidator<DeleteSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteSaleValidator with defined validation rules.
        /// </summary>
        public DeleteSaleValidator() 
        {
            RuleFor(sale => sale.Id).NotEmpty().WithMessage("Sale ID is required");
        }
    }
}
