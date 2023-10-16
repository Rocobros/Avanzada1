using Microsoft.EntityFrameworkCore;
using static System.Console;

using WorkingWithEFCore;

partial class Program{
    static void QueryingCategories()
    {
        using (Northwind db = new())
        {
            // Select * FROM Categories as C
            // LEFT JOIN Products as P ON P.CategoryId = C.CategoryID
            SectionTitle("Categories and how many products they have: ");
            // IQueryable
            IQueryable<Category>? categories =
            db.Categories? // SELECT * FROM Categories
            .Include( // LEFT JOIN
                c => c.Products // ON P.CategoryId = C.CategoryID
            ); 
            if( (categories is null) || !categories.Any() ){
                Fail("No categories found");
                return;
            }
            foreach(Category category in categories){
                WriteLine($"{category.CategoryName} has {category.Products!.Count} products.");
                Info($"Querying Categories: {categories.ToQueryString()}");
            }
        }
    }
    static void FilteredInclude()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products with a MINIMUM of units in stock.");
            string? input;
            int stock;
            do
            {
                Write("Enter the minimum for units in STOCK: ");
                input = ReadLine();
            } while (!int.TryParse(input, out stock));

            // SELECT * FROM Categories AS C
            // LEFT JOIN Products as P ON P.CategoryId = C.CategoryID
            // WHERE P.STOCK => @STOCK
            IQueryable<Category>? categories = db.Categories?.Include(c => c.Products!.Where(p => p.Stock >= stock));
            if ((categories is null) || !categories.Any())
            {
                Fail("No categories found");
                return;
            }
            foreach (Category category in categories)
            {
                WriteLine($"{category.CategoryName} has {category.Products!.Count} products with minimum of {stock}");
                
                foreach(Product product in category.Products)
                {
                    WriteLine($"{product.ProductName} has {product.Stock} units in Stock");
                }
                WriteLine();
            }
        }
    }
    static void QueryingProducts()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products with price of units");
            string? input;
            int price;
            do
            {
                Write("Enter the price for units in STOCK: ");
                input = ReadLine();
            } while (!int.TryParse(input, out price));

            // SELECT * FROM Products as P
            // WHERE P.Cost > @PRICE
            // ORDER BY DESC
            IQueryable<Product>? products = db.Products?
            .Where(product => product.Cost > price)
            .OrderByDescending(product => product.Cost);
            if ((products is null) || !products.Any())
            {
                Fail("No products found");
                return;
            }
            foreach (Product product in products)
            {
                WriteLine($"{product.ProductName} costs {product.Cost : $#,##0.00} and has {product.Stock} in stock");
                Info($"Querying Products: {products.ToQueryString()}");
            }
        }
    }
    static void QueryingWithLike()
    {
        using (Northwind db = new())
        {
            SectionTitle("Pattern matching with Like");
            Write("Enter a part of a product name: ");
            string? input = ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Fail("You did not enter part of a product's name");
            }

            // SELECT * FROM Products as P
            // WHERE P.Name LIKE "%input%"
            IQueryable<Product>? products = db.Products?
            .Where(p => EF.Functions.Like(p.ProductName!, $"%{input}%")); //.FirstOrDefault() -> para solamente obtener uno
            if ((products is null) || !products.Any())
            {
                Fail("No products found");
                return;
            }
            foreach (Product product in products)
            {
                WriteLine($"{product.ProductName} , {product.Stock} in stock. Discontinued? {product.Discontinued}");
                Info($"Querying Products: {products.ToQueryString()}");
            }
        }
    }
}