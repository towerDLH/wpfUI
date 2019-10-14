namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class R_TEMPLATE
    {
        [Key]
        public Guid tempid { get; set; }

        [Required]
        [StringLength(20)]
        public string tempname { get; set; }

        public int? tempkind { get; set; }

        [Required]
        [StringLength(200)]
        public string temppath { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] tempdata { get; set; }

        public bool? currentflg { get; set; }

        [StringLength(2000)]
        public string SQLselect { get; set; }

        [StringLength(1024)]
        public string SQLwhere { get; set; }

        [StringLength(512)]
        public string SQLorder { get; set; }

        [StringLength(50)]
        public string IDfield { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] lastchanged { get; set; }

        [StringLength(200)]
        public string printername { get; set; }
    }
}
