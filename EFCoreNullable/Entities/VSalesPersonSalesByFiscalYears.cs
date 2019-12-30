using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    public partial class VSalesPersonSalesByFiscalYears
    {
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }

        [StringLength(152)]
        public string? FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string? JobTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string? SalesTerritory { get; set; }

        [Column("2002", TypeName = "money")]
        public decimal? Year2002 { get; set; }

        [Column("2003", TypeName = "money")]
        public decimal? Year2003 { get; set; }

        [Column("2004", TypeName = "money")]
        public decimal? Year2004 { get; set; }
    }
}
