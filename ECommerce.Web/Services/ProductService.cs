using ECommerce.Data.Interfaces;
using ECommerce.Models;

namespace ECommerce.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts() => _productRepository.GetAll();

        public Product GetProductById(int productId) => _productRepository.GetById(productId);

        public void AddProduct(Product product) => _productRepository.Add(product);

        public void UpdateProduct(Product product) => _productRepository.Update(product);

        public void DeleteProduct(int productId) => _productRepository.Delete(productId);

        public void AddProductImage(ProductImage image)
        {
            var product = _productRepository.GetById(image.ProductId);
            if (product != null)
            {
                product.Images.Add(image);
                _productRepository.Update(product);
            }
        }
    }
}
