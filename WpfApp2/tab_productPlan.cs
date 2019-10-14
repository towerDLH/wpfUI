namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_productPlan
    {
        [Key]
        public Guid productPlan_id { get; set; }

        [StringLength(50)]
        public string productPlan_code { get; set; }

        [StringLength(50)]
        public string productPlan_name { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(64)]
        public string lot_no { get; set; }

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

        public DateTime? PlanStartTime { get; set; }

        public DateTime? PlanEndTime { get; set; }

        public Guid? unit { get; set; }

        public int? Number { get; set; }

        public Guid? PlanUser { get; set; }
    }
}
