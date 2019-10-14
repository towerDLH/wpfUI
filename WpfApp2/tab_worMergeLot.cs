namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_worMergeLot
    {
        [Key]
        public Guid worMergeLot_id { get; set; }

        [StringLength(50)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? Pm_id { get; set; }

        public decimal? outputNum { get; set; }

        public decimal? qualifiedNum { get; set; }

        public decimal? scrapNum { get; set; }

        public long? examineStatus { get; set; }

        public DateTime? productStartDate { get; set; }

        public DateTime? productEndDate { get; set; }

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
