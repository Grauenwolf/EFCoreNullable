using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    [Table("CountryRegion", Schema = "Person")]
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            SalesTerritory = new HashSet<SalesTerritory>();
            StateProvince = new HashSet<StateProvince>();
        }

        [Key]
        [StringLength(3)]
        public string? CountryRegionCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public ICollection<CountryRegionCurrency> CountryRegionCurrency { get; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public ICollection<SalesTerritory> SalesTerritory { get; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public ICollection<StateProvince> StateProvince { get; }
    }
}
