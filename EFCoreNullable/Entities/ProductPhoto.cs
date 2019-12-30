using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EFCoreNullable.Entities
{
    [Table("ProductPhoto", Schema = "Production")]
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }

        [Key]
        [Column("ProductPhotoID")]
        public int ProductPhotoId { get; set; }

        [SuppressMessage("Performance", "CA1819")]
        public byte[]? ThumbNailPhoto { get; set; }

        [StringLength(50)]
        public string? ThumbnailPhotoFileName { get; set; }

        [SuppressMessage("Performance", "CA1819")]
        public byte[]? LargePhoto { get; set; }

        [StringLength(50)]
        public string? LargePhotoFileName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("ProductPhoto")]
        public ICollection<ProductProductPhoto> ProductProductPhoto { get; }
    }
}
