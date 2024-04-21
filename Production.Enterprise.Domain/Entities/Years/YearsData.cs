using Production.Enterprise.Domain.Entities.SalaryOfEmployees;
using System.ComponentModel.DataAnnotations;

namespace Production.Enterprise.Domain.Entities.Years
{
    public class YearsData
    {
        [Key]
        public int Number { get; set; }

        public ICollection<SalaryOfEmployeesData> SalaryOfEmployees { get; set; }
    }
}
