namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_standard_ms
    {
        [Key]
        public Guid standard_id { get; set; }

        public DateTime? standard_date { get; set; }

        public long? standard_cls { get; set; }

        [StringLength(35)]
        public string standard_clause { get; set; }

        [StringLength(35)]
        public string standard_no { get; set; }

        [StringLength(35)]
        public string standard_name { get; set; }

        [StringLength(35)]
        public string standard_basis { get; set; }

        [StringLength(1024)]
        public string standard_describe { get; set; }

        [StringLength(1024)]
        public string standard_remark { get; set; }

        public int? standard_req { get; set; }

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
    }
}
