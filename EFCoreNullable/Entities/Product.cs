using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    [Table("Product", Schema = "Production")]
    public partial class Product
    {
        public Product()
        {
            BillOfMaterialsComponent = new HashSet<BillOfMaterials>();
            BillOfMaterialsProductAssembly = new HashSet<BillOfMaterials>();
            ProductCostHistory = new HashSet<ProductCostHistory>();
            ProductInventory = new HashSet<ProductInventory>();
            ProductListPriceHistory = new HashSet<ProductListPriceHistory>();
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
            ProductReview = new HashSet<ProductReview>();
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
            TransactionHistory = new HashSet<TransactionHistory>();
            WorkOrder = new HashSet<WorkOrder>();
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(25)]
        public string? ProductNumber { get; set; }

        [Required]
        public bool? MakeFlag { get; set; }

        [Required]
        public bool? FinishedGoodsFlag { get; set; }

        [StringLength(15)]
        public string? Color { get; set; }

        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }

        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string? Size { get; set; }

        [StringLength(3)]
        public string? SizeUnitMeasureCode { get; set; }

        [StringLength(3)]
        public string? WeightUnitMeasureCode { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Weight { get; set; }

        public int DaysToManufacture { get; set; }

        [StringLength(2)]
        public string? ProductLine { get; set; }

        [StringLength(2)]
        public string? Class { get; set; }

        [StringLength(2)]
        public string? Style { get; set; }

        [Column("ProductSubcategoryID")]
        public int? ProductSubcategoryId { get; set; }

        [Column("ProductModelID")]
        public int? ProductModelId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime SellStartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SellEndDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DiscontinuedDate { get; set; }

        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductModelId))]
        [InverseProperty("Product")]
        public virtual ProductModel? ProductModel { get; set; }

        [ForeignKey(nameof(ProductSubcategoryId))]
        [InverseProperty("Product")]
        public virtual ProductSubcategory? ProductSubcategory { get; set; }

        [ForeignKey(nameof(SizeUnitMeasureCode))]
        [InverseProperty(nameof(UnitMeasure.ProductSizeUnitMeasureCodeNavigation))]
        public virtual UnitMeasure? SizeUnitMeasureCodeNavigation { get; set; }

        [ForeignKey(nameof(WeightUnitMeasureCode))]
        [InverseProperty(nameof(UnitMeasure.ProductWeightUnitMeasureCodeNavigation))]
        public virtual UnitMeasure? WeightUnitMeasureCodeNavigation { get; set; }

        [InverseProperty(nameof(BillOfMaterials.Component))]
        public ICollection<BillOfMaterials> BillOfMaterialsComponent { get; }

        [InverseProperty(nameof(BillOfMaterials.ProductAssembly))]
        public ICollection<BillOfMaterials> BillOfMaterialsProductAssembly { get; }

        [InverseProperty("Product")]
        public ICollection<ProductCostHistory> ProductCostHistory { get; }

        [InverseProperty("Product")]
        public ICollection<ProductInventory> ProductInventory { get; }

        [InverseProperty("Product")]
        public ICollection<ProductListPriceHistory> ProductListPriceHistory { get; }

        [InverseProperty("Product")]
        public ICollection<ProductProductPhoto> ProductProductPhoto { get; }

        [InverseProperty("Product")]
        public ICollection<ProductReview> ProductReview { get; }

        [InverseProperty("Product")]
        public ICollection<ProductVendor> ProductVendor { get; }

        [InverseProperty("Product")]
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; }

        [InverseProperty("Product")]
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; }

        [InverseProperty("Product")]
        public ICollection<SpecialOfferProduct> SpecialOfferProduct { get; }

        [InverseProperty("Product")]
        public ICollection<TransactionHistory> TransactionHistory { get; }

        [InverseProperty("Product")]
        public ICollection<WorkOrder> WorkOrder { get; }
    }
}
