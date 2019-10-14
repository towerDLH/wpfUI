namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_fac_condition_ms
    {
        [Key]
        public Guid fac_id { get; set; }

        [StringLength(12)]
        public string fac_code { get; set; }

        [StringLength(200)]
        public string fac_desc { get; set; }

        [StringLength(64)]
        public string lead_person { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(16)]
        public string tel { get; set; }

        [StringLength(128)]
        public string mail { get; set; }

        [StringLength(16)]
        public string fax { get; set; }

        [StringLength(100)]
        public string fac_desc_kana { get; set; }

        [StringLength(4)]
        public string lang_code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? wk_time { get; set; }

        [StringLength(4)]
        public string rate_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? po_create_period { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mrp_period { get; set; }

        [StringLength(4)]
        public string po_confirm_cd { get; set; }

        [StringLength(4)]
        public string safe_stock_cd { get; set; }

        [StringLength(4)]
        public string mrp_cd { get; set; }

        [StringLength(4)]
        public string alc_period { get; set; }

        [StringLength(4)]
        public string sales_cd { get; set; }

        [StringLength(4)]
        public string po_slc_cd { get; set; }

        [StringLength(4)]
        public string ship_input_inv_cd { get; set; }

        [StringLength(4)]
        public string acp_input_inv_cd { get; set; }

        [StringLength(4)]
        public string gov_no_cls { get; set; }

        [StringLength(4)]
        public string sales_check_flow { get; set; }

        [StringLength(4)]
        public string po_per_check_flow { get; set; }

        [StringLength(4)]
        public string po_check_flow { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        [StringLength(1024)]
        public string address { get; set; }

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
