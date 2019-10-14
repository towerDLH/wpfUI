namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_productindicate
    {
        [Key]
        public Guid productindicate_id { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        public Guid? roughtPmSource_id { get; set; }

        [StringLength(50)]
        public string productindicateName { get; set; }

        public DateTime? planStartDate { get; set; }

        public DateTime? planEndDate { get; set; }

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
