using BlazorGridGettingStarted.Data.Models;

namespace BlazorGridGettingStarted.Data {
    public class DataService {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static DataService() {
            InitializeData();
        }

        public IEnumerable<Product> GetProducts() => _products;
        public IEnumerable<Category> GetCategories() => _categories;

        private static void InitializeData() {
            InitializeCategories();
            InitializeProducts();
        }

        private static void InitializeCategories() {
            _categories.AddRange(new[] {
                new Category { CategoryID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
                new Category { CategoryID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
                new Category { CategoryID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads" },
                new Category { CategoryID = 4, CategoryName = "Dairy Products", Description = "Cheeses" },
                new Category { CategoryID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" },
                new Category { CategoryID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats" },
                new Category { CategoryID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd" },
                new Category { CategoryID = 8, CategoryName = "Seafood", Description = "Seaweed and fish" }
            });
        }

        private static void InitializeProducts() {
            _products.AddRange(new[] {
                new Product { ProductID = 1, ProductName = "Chai", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 18.00m, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false },
                new Product { ProductID = 2, ProductName = "Chang", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 19.00m, UnitsInStock = 17, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = 10.00m, UnitsInStock = 13, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false },
                new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "48 - 6 oz jars", UnitPrice = 22.00m, UnitsInStock = 53, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "36 boxes", UnitPrice = 21.35m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true },
                new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "12 - 8 oz jars", UnitPrice = 25.00m, UnitsInStock = 120, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false },
                new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", SupplierID = 3, CategoryID = 7, QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = 30.00m, UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false },
                new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "12 - 12 oz jars", UnitPrice = 40.00m, UnitsInStock = 6, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", SupplierID = 4, CategoryID = 6, QuantityPerUnit = "18 - 500 g pkgs.", UnitPrice = 97.00m, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true },
                new Product { ProductID = 10, ProductName = "Ikura", SupplierID = 4, CategoryID = 8, QuantityPerUnit = "12 - 200 ml jars", UnitPrice = 31.00m, UnitsInStock = 31, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 11, ProductName = "Queso Cabrales", SupplierID = 5, CategoryID = 4, QuantityPerUnit = "1 kg pkg.", UnitPrice = 21.00m, UnitsInStock = 22, UnitsOnOrder = 30, ReorderLevel = 30, Discontinued = false },
                new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", SupplierID = 5, CategoryID = 4, QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 38.00m, UnitsInStock = 86, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 13, ProductName = "Konbu", SupplierID = 6, CategoryID = 8, QuantityPerUnit = "2 kg box", UnitPrice = 6.00m, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false },
                new Product { ProductID = 14, ProductName = "Tofu", SupplierID = 6, CategoryID = 7, QuantityPerUnit = "40 - 100 g pkgs.", UnitPrice = 23.25m, UnitsInStock = 35, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 15, ProductName = "Genen Shouyu", SupplierID = 6, CategoryID = 2, QuantityPerUnit = "24 - 250 ml bottles", UnitPrice = 15.50m, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false },
                new Product { ProductID = 16, ProductName = "Pavlova", SupplierID = 7, CategoryID = 3, QuantityPerUnit = "32 - 500 g boxes", UnitPrice = 17.45m, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false },
                new Product { ProductID = 17, ProductName = "Alice Mutton", SupplierID = 7, CategoryID = 6, QuantityPerUnit = "20 - 1 kg tins", UnitPrice = 39.00m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true },
                new Product { ProductID = 18, ProductName = "Carnarvon Tigers", SupplierID = 7, CategoryID = 8, QuantityPerUnit = "16 kg pkg.", UnitPrice = 62.50m, UnitsInStock = 42, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", SupplierID = 8, CategoryID = 3, QuantityPerUnit = "10 boxes x 12 pieces", UnitPrice = 9.20m, UnitsInStock = 25, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false },
                new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", SupplierID = 8, CategoryID = 3, QuantityPerUnit = "30 gift boxes", UnitPrice = 81.00m, UnitsInStock = 40, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false }
            });
        }
    }
}
