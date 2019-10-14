namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stockReceivedNumInformaRecord
    {
        [Key]
        public Guid stockReceivedNumInformaRecord_id { get; set; }

        public Guid? stockReceivedPmRecord_id { get; set; }

        public Guid? stockReceivedRecord_id { get; set; }

        public Guid? stockReceivedPlan_id { get; set; }

        public Guid? stockReceivedPm_id { get; set; }

        [StringLength(50)]
        public string receivedOrder { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        public Guid? proc_id { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? goalLocation_id { get; set; }

        public Guid? location_id { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? item_id { get; set; }

        public decimal? CurBalance { get; set; }

        public decimal? MoveNum { get; set; }

        public decimal? thisTimeMoveNum { get; set; }

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

        public int? pmstatus { get; set; }

        [StringLength(20)]
        public string yearmonth { get; set; }
    }
}
