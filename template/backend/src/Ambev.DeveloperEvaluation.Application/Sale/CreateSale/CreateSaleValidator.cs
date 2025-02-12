using Ambev.DeveloperEvaluation.Application.Features.Sales.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleCommand that defines validation rules for sale creation command.
    /// </summary>
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {

        /// <summary>
        /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - CustomerId: Required
        /// - BranchId: Required
        /// </remarks>
        public CreateSaleCommandValidator() 
        {
            RuleFor(sale => sale.CustomerId).NotEmpty();
            RuleFor(sale => sale.BranchId).NotEmpty();
        }
    }
}
