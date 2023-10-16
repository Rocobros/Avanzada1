using WorkingWithEFCore;
using static System.Console;

Northwind db = new();

WriteLine($"Provider: {db.Database.ProviderName}");

QueryingCategories();
FilteredInclude();
QueryingProducts();
QueryingWithLike();