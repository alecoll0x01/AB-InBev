using Ambev.DeveloperEvaluation.Application.Sale.DeleteSale;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteUser
{

    /// <summary>
    /// Handler for processing DeleteSaleCommand requests
    /// </summary>
    public class DeleteSaleHandler : IRequestHandler<DeleteSaleCommand, DeleteSaleResponse>
    {

        private readonly ISaleRepository _saleRepository;


        /// <summary>
        /// Initializes a new instance of DeleteSaleHandler
        /// </summary>
        /// <param name="saleRepository">The Sale Repository</param>
        public DeleteSaleHandler(
                ISaleRepository saleRepository
            ) 
        {
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// Handles the DeleteSaleCommand request
        /// </summary>
        /// <param name="request">The DeleteSale command</param>
        /// <param name="cancellationToken">Cancellation token</param> 
        /// <remarks>The Result of the delete operation</remarks>
        public async Task<DeleteSaleResponse> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteSaleValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);
            
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sucess = await _saleRepository.DeleteAsync(request.Id, cancellationToken);

            if (!sucess)
                throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            return new DeleteSaleResponse { Success = true };
        }
    }
}
