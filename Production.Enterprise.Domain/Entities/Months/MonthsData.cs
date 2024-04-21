using Production.Enterprise.Domain.Entities.SalaryOfEmployees;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Months
{
    public class MonthsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<SalaryOfEmployeesData> SalaryOfEmployees { get; set; }
    }
}
