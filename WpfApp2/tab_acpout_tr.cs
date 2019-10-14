namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_acpout_tr
    {
        [Key]
        public Guid actout_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(50)]
        public string actout_no { get; set; }

        public long? actout_cls { get; set; }

        public DateTime? actout_date { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        [StringLength(100)]
        public string license_no { get; set; }

        public Guid? dl_cd { get; set; }

        [StringLength(50)]
        public string dl_no { get; set; }

        public long? inner_out_cls { get; set; }

        public Guid? location_id { get; set; }

        public Guid? actout_person { get; set; }

        public long? tax_charged_cls { get; set; }

        public decimal? rate { get; set; }

        public decimal? acp_amt { get; set; }

        public decimal? tax_amt { get; set; }

        public decimal? nat_acp_amt { get; set; }

        public decimal? nat_tax_amt { get; set; }

        public long? acp_status { get; set; }

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
