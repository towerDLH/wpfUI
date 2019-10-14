namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stockDeliverPm
    {
        [Key]
        public Guid stockDeliverPm_id { get; set; }

        public Guid? stockDeliverPmAcc_id { get; set; }

        public Guid? roughtPmSource_id { get; set; }

        public Guid? stockReceivedPm_id { get; set; }

        [StringLength(50)]
        public string receivedOrder { get; set; }

        [StringLength(50)]
        public string stockUpNum { get; set; }

        [StringLength(50)]
        public string sourceOrderType { get; set; }

        public Guid? sourceOrderId { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        public Guid? Pm_id { get; set; }

        public decimal? requiredNum { get; set; }

        public decimal? alreadyReceivedNum { get; set; }

        [StringLength(10)]
        public string notyetReceivedNum { get; set; }

        public decimal? replenishNum { get; set; }

        public decimal? ThisTimeDeliverPmNum { get; set; }

        public DateTime? DeliverPmTime { get; set; }

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
