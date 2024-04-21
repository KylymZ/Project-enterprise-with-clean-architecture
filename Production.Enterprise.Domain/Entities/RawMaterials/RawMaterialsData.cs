using Production.Enterprise.Domain.Entities.Ingredients;
using Production.Enterprise.Domain.Entities.PurchaseOfRawMaterials;
using Production.Enterprise.Domain.Entities.Units;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.RawMaterials
{
    public class RawMaterialsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }
        
        public string Name { get; set; }=string.Empty;

        [ForeignKey("UnitId")]
        public short UnitId { get; set; }

        public decimal Sum { get; set; }

        public decimal Count { get; set; }

        public UnitsData Units { get; set; }

        public ICollection<IngredientsData> Ingredients { get; set; }
        
        public ICollection<PurchaseOfRawMaterialsData> PurchaseOfRawMaterials { get; set; }
    }
}
