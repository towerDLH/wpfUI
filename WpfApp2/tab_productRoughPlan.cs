namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_productRoughPlan
    {
        [Key]
        public Guid productRoughPlan_id { get; set; }

        [StringLength(50)]
        public string productRoughPlan_code { get; set; }

        public Guid? productPlan_id { get; set; }

        [StringLength(50)]
        public string stockUpCode { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? parentPmid { get; set; }

        public Guid? Pm_id { get; set; }

        public Guid? prcId { get; set; }

        public decimal? productNum { get; set; }

        public decimal? NumProuduct { get; set; }

        public decimal? NumProcurement { get; set; }

        public decimal? NumWh { get; set; }

        public decimal? workHours { get; set; }

        public DateTime? planStartDate { get; set; }

        public DateTime? planEndDate { get; set; }

        public int? hierarchy { get; set; }

        public Guid? nodeChild { get; set; }

        public Guid? nodeParen { get; set; }

        public decimal? BatchSizeBuns { get; set; }

        public decimal? BatchSizeBunbo { get; set; }

        public decimal? qualifiedRate { get; set; }

        public short? createType { get; set; }

        public Guid? recipient { get; set; }

        public DateTime? receiveTime { get; set; }

        public long? warehouseStatus { get; set; }

        public long? manufactureStatus { get; set; }

        public decimal? alreadyPickingNum { get; set; }

        public decimal? notyetPickingNum { get; set; }

        public decimal? supplementNum { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
