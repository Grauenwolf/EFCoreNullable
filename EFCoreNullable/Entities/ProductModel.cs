﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    [Table("ProductModel", Schema = "Production")]
    public partial class ProductModel
    {
        public ProductModel()
        {
            Product = new HashSet<Product>();
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }

        [Key]
        [Column("ProductModelID")]
        public int ProductModelId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Column(TypeName = "xml")]
        public string? CatalogDescription { get; set; }

        [Column(TypeName = "xml")]
        public string? Instructions { get; set; }

        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("ProductModel")]
        public ICollection<Product> Product { get; }

        [InverseProperty("ProductModel")]
        public ICollection<ProductModelIllustration> ProductModelIllustration { get; }

        [InverseProperty("ProductModel")]
        public ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; }
    }
}
