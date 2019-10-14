namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_employee
    {
        [Key]
        public Guid emp_id { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? depart_id { get; set; }

        [StringLength(50)]
        public string emp_cd { get; set; }

        [StringLength(50)]
        public string emp_desc { get; set; }

        [StringLength(50)]
        public string emp_desc_kana { get; set; }

        public long? emp_sex { get; set; }

        public int? emp_age { get; set; }

        [StringLength(50)]
        public string healthCardCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? healthCardDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        public DateTime? entry_start_date { get; set; }

        public long? education { get; set; }

        [StringLength(50)]
        public string identityCard { get; set; }

        public bool? jobStatu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? leaveOfficeDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? entry_time { get; set; }

        public Guid? entry_job { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(16)]
        public string tel { get; set; }

        [StringLength(16)]
        public string phone { get; set; }

        [StringLength(16)]
        public string mail { get; set; }

        [StringLength(16)]
        public string fax { get; set; }

        [StringLength(1024)]
        public string family_address { get; set; }

        [StringLength(1024)]
        public string link_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        public Guid? prodLevel { get; set; }

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

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(255)]
        public string OrganizeName { get; set; }

        public int? LeaderId { get; set; }

        [StringLength(50)]
        public string LeaderName { get; set; }
    }
}
