namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_company_condition_ms
    {
        [Key]
        public Guid company_id { get; set; }

        [StringLength(6)]
        public string condition_cd { get; set; }

        [StringLength(100)]
        public string company_abd_desc { get; set; }

        [StringLength(100)]
        public string company_desc { get; set; }

        [StringLength(50)]
        public string company_desc_kana { get; set; }

        [StringLength(12)]
        public string company_code { get; set; }

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

        [StringLength(4)]
        public string native_curr_cd { get; set; }

        [StringLength(4)]
        public string frc_cls { get; set; }

        [StringLength(4)]
        public string total_mst_set_cls { get; set; }

        [StringLength(4)]
        public string multi_fac_cls { get; set; }

        [StringLength(4)]
        public string date_type { get; set; }

        [StringLength(12)]
        public string inspecton_location { get; set; }

        [StringLength(12)]
        public string rjt_wh_cd { get; set; }

        [StringLength(12)]
        public string non_alloc_location { get; set; }

        [StringLength(12)]
        public string trade_wh_cd { get; set; }

        [StringLength(12)]
        public string os_wh_cd { get; set; }

        [StringLength(12)]
        public string non_sales_wh_cd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        [StringLength(20)]
        public string legal { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(30)]
        public string linceseno { get; set; }

        [StringLength(30)]
        public string productionlicenses { get; set; }

        [StringLength(30)]
        public string regnumber { get; set; }

        [StringLength(30)]
        public string taxnumber { get; set; }

        public bool? systemflg { get; set; }

        [Column(TypeName = "image")]
        public byte[] businesscopy { get; set; }

        [Column(TypeName = "image")]
        public byte[] companylogo { get; set; }

        [StringLength(20)]
        public string cid { get; set; }

        public Guid? companyid { get; set; }

        public string introduce { get; set; }

        [StringLength(100)]
        public string EBusinessID { get; set; }

        [StringLength(100)]
        public string AppKey { get; set; }

        [StringLength(516)]
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
