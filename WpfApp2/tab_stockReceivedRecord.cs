namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stockReceivedRecord
    {
        [Key]
        public Guid stockReceivedRecord_id { get; set; }

        [StringLength(50)]
        public string stockReceivedRecord_code { get; set; }

        public Guid? stockReceivedPlan_id { get; set; }

        [StringLength(50)]
        public string receivedOrder { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        [StringLength(50)]
        public string productRoughPlan_code { get; set; }

        public DateTime? receivedTime { get; set; }

        public Guid? goalLocation_id { get; set; }

        public Guid? recipient { get; set; }

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
