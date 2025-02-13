namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.GetSale
{
    /// <summary>
    /// Request to get a sale by their ID.
    /// </summary>
    public class GetSaleRequest
    {

        /// <summary>
        /// The unique identifier of the sale to retrieve.
        /// </summary>
        public Guid Id
        {
            get; set;
        }
    }
}
