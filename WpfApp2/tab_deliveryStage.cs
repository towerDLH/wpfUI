namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_deliveryStage
    {
        [Key]
        public Guid deliveryStage_id { get; set; }

        [StringLength(50)]
        public string deliveryStage_code { get; set; }

        public Guid? deliveryPlan_id { get; set; }

        public DateTime? deliveryDate { get; set; }

        public int? dueNum { get; set; }

        public long? transport { get; set; }

        public Guid? salePm_id { get; set; }

        [StringLength(128)]
        public string sale_order_code { get; set; }

        public Guid? pm_id { get; set; }

        public decimal? thisTimePmBaseNum { get; set; }

        public decimal? pmNum { get; set; }

        public Guid? unit { get; set; }

        public decimal? pmBaseNum { get; set; }

        public Guid? PmBaseUnit { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [StringLength(32)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? deleteuser { get; set; }

        public DateTime? deletetime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
