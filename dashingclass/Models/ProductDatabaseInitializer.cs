using System.Collections.Generic;
using System.Data.Entity;

namespace dashingclass.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductName = "Unisex Polo",
                    ProductType = "Polo",
                    ProductBrand = "TopBest",
                    Description = "A polo shirt for both men and women",
                    ProductColor = "Black",
                    ProductSize = "Small",
                    ImagePath = "TopBest-Unisex-Short-Sleeve-Polo-Black.jpg",
                    ProductStatus = "Available",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Unisex Polo",
                    ProductType = "Polo",
                    ProductBrand = "TopBest",
                    Description = "A polo shirt for both men and women",
                    ProductColor = "Black",
                    ProductSize = "Medium",
                    ProductStatus = "Available",
                    ImagePath = "TopBest-Unisex-Short-Sleeve-Polo-Black.jpg",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Unisex Polo",
                    ProductType = "Polo",
                    ProductBrand = "TopBest",
                    Description = "A polo shirt for both men and women",
                    ProductColor = "Black",
                    ProductSize = "Large",
                    ProductStatus = "Available",
                    ImagePath = "TopBest-Unisex-Short-Sleeve-Polo-Black.jpg",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Unisex T-Shirt",
                    ProductType = "T-shirt",
                    ProductBrand = "Blue Corner",
                    Description = "A t-shirt for both men and women",
                    ProductColor = "Black",
                    ProductSize = "Small",
                    ProductStatus = "Available",
                    ImagePath = "BlueCorner-Unisex-T-Shirt-Black.jpg",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Unisex T-Shirt",
                    ProductType = "T-shirt",
                    ProductBrand = "Blue Corner",
                    Description = "A t-shirt for both men and women",
                    ProductColor = "Black",
                    ProductSize = "Medium",
                    ProductStatus = "Available",
                    ImagePath = "BlueCorner-Unisex-T-Shirt-Black.jpg",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Unisex T-Shirt",
                    ProductType = "T-shirt",
                    Description = "A t-shirt for both men and women",
                    ProductBrand = "Blue Corner",
                    ProductColor = "Black",
                    ProductSize = "Large",
                    ProductStatus = "Available",
                    ImagePath = "BlueCorner-Unisex-T-Shirt-Black.jpg",
                    ProductCost = 12.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Mens Maong Pants",
                    ProductType = "Pants",
                    Description = "A pair of maong pants for men",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Small",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Maong-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Maong Pants",
                    Description = "A pair of maong pants for men",
                    ProductType = "Pants",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Medium",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Maong-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Maong Pants",
                    Description = "A pair of maong pants for men",
                    ProductType = "Pants",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Maong-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Denim Pants",
                    Description = "A pair of denim pants for men",
                    ProductType = "Pants",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Small",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Denim-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Denim Pants",
                    Description = "A pair of denim pants for men",
                    ProductType = "Pants",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Medium",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Denim-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Denim Pants",
                    Description = "A pair of denim pants for men",
                    ProductType = "Pants",
                    ProductBrand = "Unitop",
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductStatus = "Available",
                    ImagePath = "Unitop-Mens-Denim-Pants-Blue.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Leather Jacket",
                    Description = "A beautiful bikers leather jacket",
                    ProductType = "Jacket",
                    ProductBrand = "Vintage",
                    ProductColor = "Blue",
                    ProductSize = "Small",
                    ProductStatus = "Available",
                    ImagePath = "Vintage-Mens-Biker-Motorcycle-Brown-Wax-Real-Leather-Jacket.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Leather Jacket",
                    Description = "A beautiful bikers leather jacket",
                    ProductType = "Jacket",
                    ProductBrand = "Vintage",
                    ProductColor = "Blue",
                    ProductSize = "Medium",
                    ProductStatus = "Available",
                    ImagePath = "Vintage-Mens-Biker-Motorcycle-Brown-Wax-Real-Leather-Jacket.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                },
                new Product
                {
                    ProductName = "Mens Leather Jacket",
                    Description = "A beautiful bikers leather jacket",
                    ProductType = "Jacket",
                    ProductBrand = "Vintage",
                    ProductColor = "Blue",
                    ProductSize = "Large",
                    ProductStatus = "Available",
                    ImagePath = "Vintage-Mens-Biker-Motorcycle-Brown-Wax-Real-Leather-Jacket.jpg",
                    ProductCost = 20.00M,
                    ProductQuantity = 200
                }
            };
        }
    }
}