using Production.Enterprise.Domain.Entities.FinishedProducts;
using Production.Enterprise.Domain.Entities.RawMaterials;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Ingredients
{
    public class IngredientsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        [ForeignKey("ProductId")]
        public short ProductId { get; set; }

        [ForeignKey("RawMaterialId")]
        public short RawMaterialId { get; set; }

        public decimal Count { get; set; }

        public FinishedProductsData FinishedProducts { get; set; }

        public RawMaterialsData RawMaterials { get; set; }
    }
}
