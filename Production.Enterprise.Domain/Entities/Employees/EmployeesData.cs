using Production.Enterprise.Domain.Entities.Positions;
using Production.Enterprise.Domain.Entities.Productions;
using Production.Enterprise.Domain.Entities.PurchaseOfRawMaterials;
using Production.Enterprise.Domain.Entities.SalaryOfEmployees;
using Production.Enterprise.Domain.Entities.SaleOfProducts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Employees
{
    public class EmployeesData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        [ForeignKey("PositionId")]
        public short PositionId { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public PositionsData Positions { get; set; }
        public ICollection<ProductionsData> Productions { get; set; }

        public ICollection<SalaryOfEmployeesData> Salaries { get; set; }

        public ICollection<PurchaseOfRawMaterialsData> PurchaseOfRawMaterials { get; set; }
        public ICollection<SaleOfProductsData> SaleOfProducts { get; set; }
    }
}
