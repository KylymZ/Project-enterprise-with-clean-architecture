using Production.Enterprise.Domain.Entities.Employees;
using Production.Enterprise.Domain.Entities.RawMaterials;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.PurchaseOfRawMaterials
{
    public class PurchaseOfRawMaterialsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        [ForeignKey("RawMaterialsId")]
        public short RawMaterialsId { get; set; }
        
        public decimal Count { get; set; }
        
        public decimal Sum { get; set; }
        
        public DateTime Date { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        public EmployeesData Employees { get; set; }
        
        public RawMaterialsData RawMaterials { get; set; }
    }
}
