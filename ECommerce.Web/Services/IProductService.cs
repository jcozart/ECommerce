﻿using ECommerce.Models;

namespace ECommerce.Web.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        void AddProductImage(ProductImage image);
    }
}
