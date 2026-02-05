using SmartLedger.API.Models;

namespace SmartLedger.API.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category { Name = "Housing", BudgetLimit = 1500.00m },
                new Category { Name = "Food", BudgetLimit = 500.00m },
                new Category { Name = "Transportation", BudgetLimit = 300.00m },
                new Category { Name = "Entertainment", BudgetLimit = 200.00m }
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            context.Expenses.AddRange(
                new Expense
                {
                    Merchant = "HEB",
                    Amount = 145.32m,
                    Date = DateTime.UtcNow.AddDays(-2),
                    Category = categories.First(c => c.Name == "Food")
                },
                new Expense
                {
                    Merchant = "Shell Station",
                    Amount = 45.00m,
                    Date = DateTime.UtcNow.AddDays(-5),
                    Category = categories.First(c => c.Name == "Transportation")
                },
                new Expense
                {
                    Merchant = "Netflix",
                    Amount = 15.99m,
                    Date = DateTime.UtcNow.AddDays(-10),
                    Category = categories.First(c => c.Name == "Entertainment")
                }
            );

            context.SaveChanges();
        }
    }
}