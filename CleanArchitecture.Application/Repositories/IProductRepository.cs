

using CleanArchitecture.Application.dtos;

namespace CleanArchitecture.Application.Repositories
{
	public interface IProductRepository
	{
		List<ProductResponse> GetProducts();
		ProductResponse GetProductById(int productId);
		void DeleteProductById(int productId);
		ProductResponse CreateProduct(CreateProductRequest request);
		ProductResponse UpdateProduct(int productId, UpdateProductRequest request);
	}
}
