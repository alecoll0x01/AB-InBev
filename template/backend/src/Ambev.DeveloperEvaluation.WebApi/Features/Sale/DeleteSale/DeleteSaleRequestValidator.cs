using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.DeleteSale
{

    /// <summary>
    /// Validator for sale deletion request that defines validation rules for sale deletion request.
    /// </summary>
    public class DeleteSaleRequestValidator : AbstractValidator<DeleteSaleRequest>
    {

        /// <summary>
        /// Initializes a new instance of the DeleteSaleRequestValidator with defined validation rules.
        /// </summary>
        public DeleteSaleRequestValidator()
        {
            RuleFor(sale => sale.Id).NotEmpty().WithMessage("Sale ID is required");
        }
    }
}
