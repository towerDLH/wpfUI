namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_inspectmode_tr
    {
        [Key]
        public Guid insmode_id { get; set; }

        public DateTime? insmode_date { get; set; }

        [StringLength(35)]
        public string insmode_no { get; set; }

        [StringLength(50)]
        public string insmode_name { get; set; }

        [MaxLength(1024)]
        public byte[] insmode_remark { get; set; }

        [StringLength(35)]
        public string standard_basis { get; set; }

        [StringLength(35)]
        public string standard_no { get; set; }

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

        public int autoincr { get; set; }

        public Guid? versioncenter_id { get; set; }

        public Guid? procid { get; set; }

        public Guid? fatherid { get; set; }
    }
}
