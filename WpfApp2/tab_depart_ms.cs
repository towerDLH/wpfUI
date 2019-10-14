namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_depart_ms
    {
        [Key]
        public Guid depart_id { get; set; }

        public Guid? mastDepart { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(12)]
        public string depart_cd { get; set; }

        [StringLength(50)]
        public string depart_desc { get; set; }

        [StringLength(50)]
        public string depart_desc_kana { get; set; }

        [StringLength(20)]
        public string mail_no { get; set; }

        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(100)]
        public string address2 { get; set; }

        [StringLength(100)]
        public string address3 { get; set; }

        [StringLength(20)]
        public string tel { get; set; }

        [StringLength(20)]
        public string fax_no { get; set; }

        [StringLength(20)]
        public string manage_person { get; set; }

        [StringLength(20)]
        public string con_person { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

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

        public Guid? parent_depart_id { get; set; }

        public int? depart_level { get; set; }

        [Column(TypeName = "text")]
        public string depart_path_id { get; set; }

        [Column(TypeName = "text")]
        public string depart_path_name { get; set; }

        public int? priority { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(255)]
        public string OrganizeName { get; set; }
    }
}
