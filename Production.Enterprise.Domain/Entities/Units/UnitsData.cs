using Production.Enterprise.Domain.Entities.FinishedProducts;
using Production.Enterprise.Domain.Entities.RawMaterials;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Units
{
    public class UnitsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        public string Name { get; set; }=string.Empty;

        public ICollection<FinishedProductsData> FinishedProducts { get; set; }

        public ICollection<RawMaterialsData> RawMaterials { get; set; }
    }
}
