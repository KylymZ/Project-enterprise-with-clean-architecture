using Production.Enterprise.Domain.Entities.Employees;
using Production.Enterprise.Domain.Entities.FinishedProducts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.SaleOfProducts
{
    public class SaleOfProductsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        [ForeignKey("ProductId")]
        public short ProductId { get; set; }

        public decimal Count { get; set; }

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        public EmployeesData Employees { get; set; }

        public FinishedProductsData FinishedProducts { get; set; }
    }
}
