using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Production.Enterprise.Domain.Entities.Budgets
{
    public class BudgetsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        public decimal Amount { get; set; }

        public decimal SalePercentage { get; set; }

        public decimal? Bonus { get; set; }
    }
}
