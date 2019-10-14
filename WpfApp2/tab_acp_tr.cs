namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_acp_tr
    {
        [Key]
        public Guid acp_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(50)]
        public string acp_no { get; set; }

        public long? acp_cls { get; set; }

        public Guid? cls_cd { get; set; }

        public DateTime? acp_date { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        [StringLength(100)]
        public string license_no { get; set; }

        public Guid? dl_cd { get; set; }

        [StringLength(50)]
        public string dl_no { get; set; }

        public long? inner_out_cls { get; set; }

        public Guid? location_id { get; set; }

        public Guid? acp_person { get; set; }

        public long? tax_cls { get; set; }

        public decimal? tax_rate { get; set; }

        public long? tax_charged_cls { get; set; }

        public decimal? rate { get; set; }

        public decimal? acp_amt { get; set; }

        public decimal? tax_amt { get; set; }

        public decimal? nat_acp_amt { get; set; }

        public decimal? nat_tax_amt { get; set; }

        public long? ins_cls { get; set; }

        public DateTime? ins_rslt_date { get; set; }

        public long? ins_ok_qty { get; set; }

        public long? ins_rtj_qty { get; set; }

        public DateTime? vou_date { get; set; }

        public long? vou_cls { get; set; }

        public long? vou_qty { get; set; }

        public long? vou_up { get; set; }

        public decimal? vou_amt { get; set; }

        public decimal? vou_tax_amt { get; set; }

        public decimal? vou_balance_qty { get; set; }

        public Guid? comp_location_id { get; set; }

        public long? comp_stock_qty { get; set; }

        public long? acp_status { get; set; }

        public long? print_vou_status { get; set; }

        public decimal? print_vou_qty { get; set; }

        public Guid? print_vou_person { get; set; }

        public DateTime? print_vou_date { get; set; }

        [StringLength(50)]
        public string print_vou_no { get; set; }

        public long? print_stock_status { get; set; }

        public long? print_stock_qty { get; set; }

        public Guid? print_stock_person { get; set; }

        public DateTime? print_stock_date { get; set; }

        [StringLength(50)]
        public string print_stock_no { get; set; }

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
