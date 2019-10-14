namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stockReceivedPm
    {
        [Key]
        public Guid stockReceivedPm_id { get; set; }

        public Guid? stockReceivedPlan_id { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        [StringLength(50)]
        public string receivedOrder { get; set; }

        [StringLength(50)]
        public string stockUpNum { get; set; }

        public long? sourceOrderType { get; set; }

        public Guid? sourceOrderId { get; set; }

        public DateTime? receivedTime { get; set; }

        public Guid? recipient { get; set; }

        public Guid? parentPmid { get; set; }

        public Guid? Pm_id { get; set; }

        public Guid? prcId { get; set; }

        public Guid? self_Prcid { get; set; }

        public Guid? nodeChild { get; set; }

        public Guid? nodeParen { get; set; }

        public decimal? requiredNum { get; set; }

        public decimal? alreadyReceivedNum { get; set; }

        public decimal? notyetReceivedNum { get; set; }

        public decimal? replenishNum { get; set; }

        public decimal? ThisTimeReceivedNum { get; set; }

        public decimal? ThisTimeReceived { get; set; }

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

        public Guid? receivecenterid { get; set; }

        [StringLength(50)]
        public string receivecentercode { get; set; }

        [StringLength(50)]
        public string businesscode { get; set; }
    }
}
