using Production.Enterprise.Domain.Entities.Employees;
using Production.Enterprise.Domain.Entities.Months;
using Production.Enterprise.Domain.Entities.Years;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.SalaryOfEmployees
{
    public class SalaryOfEmployeesData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("YearId")]
        public int YearId { get; set; }

        [ForeignKey("MonthId")]
        public byte MonthId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        public byte ParticipationPurchase { get; set; }

        public byte ParticipationSale { get; set; }
        
        public byte ParticipationProduction { get; set; }
        
        public short CountParticipation { get; set; }
        
        public decimal Salary { get; set; }
        
        public float TotalAmount { get; set; }
        
        public bool Issued { get; set; }
        
        public decimal Bonus { get; set; }
        
        public EmployeesData Employees { get; set; }
        
        public YearsData Years { get; set; }
        
        public MonthsData Months { get; set; }
    }
}
