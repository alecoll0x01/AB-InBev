using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;
/// <summary>
/// Represents a sale record.
/// </summary>
public class Sale : BaseEntity
{
    /// <summary>
    /// The unique identifier for the sale.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The sale number.
    /// </summary>
    public string SaleNumber { get; set; }


    /// <summary>
    /// The sale Date.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// The unique identifier for user.
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// The Customer object.
    /// </summary>
    public Customer Customer { get; set; }


    /// <summary>
    /// The unique identifier for branch.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// The Branch object.
    /// </summary>
    public Branch Branch { get; set; }

    /// <summary>
    /// The total amount of sale.
    /// </summary>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Represents if the sale is cancelled.
    /// </summary>
    public bool IsCancelled { get; set; }

    public DateTime UpdatedAt { get; private set; }


    /// <summary>
    /// List of item in sale.
    /// </summary>
    public List<SaleItem> Items { get; set; } = new List<SaleItem>();

    /// <summary>
    /// Validates the sale entity.
    /// </summary>
    /// <returns>A <see cref="ValidationResultDetail"/> containing validation results.</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Cancels the sale.
    /// </summary>
    public void Cancel()
    {
        IsCancelled = true;
        UpdatedAt = DateTime.UtcNow;
    }

}


/// <summary>
/// Represents an item in a sales transaction.
/// </summary>
public class SaleItem : BaseEntity
{
    /// <summary>
    /// Gets or sets the sale associated with this item.
    /// </summary>
    public int SaleId { get; set; }
    public Sale Sale { get; set; }

    /// <summary>
    /// Gets or sets the product associated with this item.
    /// </summary>
    public int ProductId { get; set; }
    public Product Product { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Gets or sets the total amount for the item.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Validates the sale item entity.
    /// </summary>
    /// <returns>A <see cref="ValidationResultDetail"/> containing validation results.</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleItemValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Calculates the total amount for the item based on quantity, unit price, and discount.
    /// </summary>
    public void CalculateTotalAmount()
    {
        if (Quantity > 20)
        {
            throw new InvalidOperationException("Cannot sell more than 20 identical items.");
        }

        if (Quantity >= 10 && Quantity <= 20)
        {
            Discount = 0.20m;
        }
        else if (Quantity >= 4)
        {
            Discount = 0.10m;
        }
        else
        {
            Discount = 0m;
        }

        TotalAmount = Quantity * UnitPrice * (1 - Discount);
    }
}
