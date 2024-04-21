using Production.Enterprise.Domain.Entities.Employees;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Positions
{
    public class PositionsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<EmployeesData> Employees { get; set; }

    }
}
