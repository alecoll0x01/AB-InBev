using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator() 
        {
            RuleFor(sale => sale.TotalAmount)
                .GreaterThan(0).WithMessage("Total amount must be greater than 0.");

            RuleFor(sale => sale.Items).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Sale must have at least one item.")
                .ForEach(item => item.SetValidator(new SaleItemValidator()));
        }
    }
}
