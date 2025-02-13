using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleRequest that defines validation rules for sale creation request.
    /// </summary>
    public class CreateSaleValidator : AbstractValidator<CreateSaleRequest>
    {

        /// <summary>
        /// Initializes a new instance of the CreateSaleValidator with defined validation rules.
        /// </summary>
        /// <remarks
        /// Validation rules include:
        ///  - CustomerId: Required
        /// </remarks>
        public CreateSaleValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty()
                .WithMessage("Customer ID is required.");
        }
    }
}