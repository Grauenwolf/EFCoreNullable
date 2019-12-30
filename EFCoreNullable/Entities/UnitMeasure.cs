using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    [Table("UnitMeasure", Schema = "Production")]
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            ProductSizeUnitMeasureCodeNavigation = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
            ProductWeightUnitMeasureCodeNavigation = new HashSet<Product>();
        }

        [Key]
        [StringLength(3)]
        public string? UnitMeasureCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("UnitMeasureCodeNavigation")]
        public ICollection<BillOfMaterials> BillOfMaterials { get; }

        [InverseProperty(nameof(Product.SizeUnitMeasureCodeNavigation))]
        public ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; }

        [InverseProperty("UnitMeasureCodeNavigation")]
        public ICollection<ProductVendor> ProductVendor { get; }

        [InverseProperty(nameof(Product.WeightUnitMeasureCodeNavigation))]
        public ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; }
    }
}
