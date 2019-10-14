namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_purchaseorder_tr
    {
        [Key]
        public Guid purorder_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(50)]
        public string purorder_no { get; set; }

        public DateTime? purorder_date { get; set; }

        public Guid? purorder_person { get; set; }

        public Guid? pur_section { get; set; }

        public DateTime? arrival_date { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public long? innerflag { get; set; }

        public long? price_cls { get; set; }

        public DateTime? payplan_date { get; set; }

        public decimal? purorder_amt { get; set; }

        public long? payrigflag { get; set; }

        public Guid? dl_cd { get; set; }

        [StringLength(50)]
        public string dl_no { get; set; }

        [StringLength(100)]
        public string license_no { get; set; }

        public decimal? rate { get; set; }

        public Guid? location_id { get; set; }

        [StringLength(50)]
        public string invoice_no { get; set; }

        [StringLength(50)]
        public string pay_account { get; set; }

        [StringLength(50)]
        public string pay_bank { get; set; }

        public decimal? pay_amt { get; set; }

        public Guid? chk_person { get; set; }

        public DateTime? chk_date { get; set; }

        public int? chkflag { get; set; }

        public decimal? acp_amt { get; set; }

        public decimal? tax_amt { get; set; }

        public decimal? nat_acp_amt { get; set; }

        public decimal? nat_tax_amt { get; set; }

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
