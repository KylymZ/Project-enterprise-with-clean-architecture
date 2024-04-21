using Microsoft.EntityFrameworkCore;
using Production.Enterprise.Domain.Entities.Budgets;
using Production.Enterprise.Domain.Entities.Employees;
using Production.Enterprise.Domain.Entities.FinishedProducts;
using Production.Enterprise.Domain.Entities.Ingredients;
using Production.Enterprise.Domain.Entities.Months;
using Production.Enterprise.Domain.Entities.Positions;
using Production.Enterprise.Domain.Entities.Productions;
using Production.Enterprise.Domain.Entities.PurchaseOfRawMaterials;
using Production.Enterprise.Domain.Entities.RawMaterials;
using Production.Enterprise.Domain.Entities.SalaryOfEmployees;
using Production.Enterprise.Domain.Entities.SaleOfProducts;
using Production.Enterprise.Domain.Entities.Units;
using Production.Enterprise.Domain.Entities.Years;

namespace Production.Enterprise.Infrastructure.DataContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<BudgetsData> Budgets { get; set; }
        public DbSet<MonthsData> Months { get; set; }
        public DbSet<YearsData> Years { get; set; }
        public DbSet<EmployeesData> Employees { get; set; }
        public DbSet<FinishedProductsData> FinishedProducts { get; set; }
        public DbSet<IngredientsData> Ingredients { get; set; }
        public DbSet<PositionsData> Positions { get; set; }
        public DbSet<ProductionsData> Productions { get; set; }
        public DbSet<PurchaseOfRawMaterialsData> PurchaseOfRawMaterials { get; set; }
        public DbSet<RawMaterialsData> RawMaterials { get; set; }
        public DbSet<SaleOfProductsData> SaleOfProducts { get; set; }
        public DbSet<SalaryOfEmployeesData> Salaries { get; set; }
        public DbSet<UnitsData> Units { get; set; }
    }
}
