using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreNullable.Entities
{
    [Table("SalesPerson", Schema = "Sales")]
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistory = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            Store = new HashSet<Store>();
        }

        [Key]
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }

        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesQuota { get; set; }

        [Column(TypeName = "money")]
        public decimal Bonus { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CommissionPct { get; set; }

        [Column("SalesYTD", TypeName = "money")]
        public decimal SalesYtd { get; set; }

        [Column(TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(Employee.SalesPerson))]
        public virtual Employee? BusinessEntity { get; set; }

        [ForeignKey(nameof(TerritoryId))]
        [InverseProperty(nameof(SalesTerritory.SalesPerson))]
        public virtual SalesTerritory? Territory { get; set; }

        [InverseProperty("SalesPerson")]
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; }

        [InverseProperty("BusinessEntity")]
        public ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; }

        [InverseProperty("BusinessEntity")]
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; }

        [InverseProperty("SalesPerson")]
        public ICollection<Store> Store { get; }
    }
}
