namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_facOutside
    {
        [Key]
        public Guid facOutside_id { get; set; }

        [StringLength(12)]
        public string facOutside_code { get; set; }

        [StringLength(200)]
        public string facOutside_desc { get; set; }

        [StringLength(64)]
        public string lead_person { get; set; }

        [StringLength(50)]
        public string producLicence_code { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(16)]
        public string tel { get; set; }

        [StringLength(128)]
        public string mail { get; set; }

        [StringLength(16)]
        public string fax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? wk_time { get; set; }

        [StringLength(10)]
        public string addres { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

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
