namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_customer_ms
    {
        [Key]
        public Guid customer_id { get; set; }

        [StringLength(50)]
        public string customer_cd { get; set; }

        [StringLength(100)]
        public string customer_arg_desc { get; set; }

        [StringLength(100)]
        public string customer_desc { get; set; }

        [StringLength(50)]
        public string customer_desc_kana { get; set; }

        [StringLength(20)]
        public string mail_no { get; set; }

        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(100)]
        public string address2 { get; set; }

        [StringLength(100)]
        public string address3 { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(20)]
        public string tel { get; set; }

        [StringLength(20)]
        public string fax_no { get; set; }

        public Guid? dl_curr_cd { get; set; }

        public decimal? transfer_lt { get; set; }

        [StringLength(4)]
        public string trade_lang_cls { get; set; }

        public long? tax_type { get; set; }

        public decimal? tax_rate { get; set; }

        public long? enable_rate { get; set; }

        [StringLength(4)]
        public string do_issue_cls { get; set; }

        [StringLength(12)]
        public string inv_dest_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? charged_sply_cls { get; set; }

        [StringLength(4)]
        public string tax_charged_cls { get; set; }

        public long? sales_up_cls { get; set; }

        [StringLength(4)]
        public string sales_frc_cls { get; set; }

        public short? sales_tax_frc_cls { get; set; }

        public long? sales_tax_calc_cls { get; set; }

        public long? sales_tax_cls { get; set; }

        [StringLength(4)]
        public string sales_slip_issue_cls { get; set; }

        [StringLength(4)]
        public string sales_trade_up_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? is_invoice { get; set; }

        public decimal? inv_closing_date { get; set; }

        [StringLength(6)]
        public string cllt_method { get; set; }

        [StringLength(4)]
        public string cllt_term1 { get; set; }

        [StringLength(4)]
        public string cllt_term2 { get; set; }

        public decimal? border_amt { get; set; }

        public decimal? bill_sight { get; set; }

        public decimal? cllt_sch_mnth { get; set; }

        public decimal? cllt_sch_day { get; set; }

        [StringLength(6)]
        public string inv_person_cd { get; set; }

        [StringLength(4)]
        public string inv_issue_cls { get; set; }

        [StringLength(40)]
        public string bank_cd { get; set; }

        [StringLength(4)]
        public string trade_cls { get; set; }

        [StringLength(12)]
        public string rcp_section { get; set; }

        public decimal? credit_limit_amt { get; set; }

        public decimal? credit_limit_amt_perm { get; set; }

        [StringLength(40)]
        public string dealing_bank { get; set; }

        [StringLength(64)]
        public string bank_no { get; set; }

        [StringLength(40)]
        public string cllt_bank { get; set; }

        [StringLength(4)]
        public string cllt_bank_type { get; set; }

        [StringLength(60)]
        public string cllt_account { get; set; }

        [StringLength(100)]
        public string cllt_account_desc { get; set; }

        [StringLength(4)]
        public string fee_chrg_cls { get; set; }

        [StringLength(4)]
        public string fee_cls { get; set; }

        public decimal? fixed_amt { get; set; }

        [StringLength(20)]
        public string con_person { get; set; }

        [StringLength(100)]
        public string remark1 { get; set; }

        [StringLength(100)]
        public string remark2 { get; set; }

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
    }
}
