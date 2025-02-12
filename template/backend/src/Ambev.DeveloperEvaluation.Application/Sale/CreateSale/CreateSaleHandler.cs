using Ambev.DeveloperEvaluation.Application.Features.Sales.Commands;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    /// <summary>
    /// Handler para o comando de criação de venda
    /// </summary>
    public class CreateSaleCommandHandler : IRequestHandler<CreateSaleCommand, Guid>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IBranchRepository _branchRepository;
        private readonly IProductRepository _productRepository;

        public CreateSaleCommandHandler(
            ISaleRepository saleRepository,
            ICustomerRepository customerRepository,
            IBranchRepository branchRepository,
            IProductRepository productRepository)
        {
            _saleRepository = saleRepository;
            _customerRepository = customerRepository;
            _branchRepository = branchRepository;
            _productRepository = productRepository;
        }

        public async Task<Guid> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            // Validações de negócio
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId);
            if (customer == null)
                throw new Exception("Cliente não encontrado.");

            var branch = await _branchRepository.GetByIdAsync(request.BranchId);
            if (branch == null)
                throw new Exception("Filial não encontrada.");

            var saleItems = new List<SaleItem>();
            foreach (var itemDto in request.Items)
            {
                var product = await _productRepository.GetByIdAsync(itemDto.ProductId);
                if (product == null)
                    throw new Exception($"Produto com ID {itemDto.ProductId} não encontrado.");

                var saleItem = new SaleItem
                {
                    ProductId = itemDto.ProductId,
                    Quantity = itemDto.Quantity,
                    UnitPrice = itemDto.UnitPrice
                };

                saleItem.CalculateTotalAmount();
                saleItems.Add(saleItem);
            }

            var sale = new Domain.Entities.Sale
            {
                SaleNumber = request.SaleNumber,
                SaleDate = DateTime.UtcNow,
                CustomerId = request.CustomerId,
                BranchId = request.BranchId,
                Items = saleItems,
                TotalAmount = saleItems.Sum(i => i.TotalAmount),
                IsCancelled = false
            };

            await _saleRepository.AddAsync(sale);
            await _saleRepository.SaveChangesAsync();

            Console.WriteLine($"SaleCreated: {sale.SaleNumber}");

            return sale.Id;
        }
    }
}
