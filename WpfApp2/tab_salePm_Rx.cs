namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_salePm_Rx
    {
        [Key]
        public Guid salePm_id { get; set; }

        [StringLength(50)]
        public string salePm_code { get; set; }

        public Guid? order_id { get; set; }

        public Guid? pm_id { get; set; }

        public Guid? RegisNum_id { get; set; }

        [StringLength(50)]
        public string pmsize { get; set; }

        [StringLength(50)]
        public string pmmodel { get; set; }

        public decimal? pmBaseNum { get; set; }

        public decimal? pmNum { get; set; }

        public decimal? pmSendOutNum { get; set; }

        public decimal? PmBasePrice { get; set; }

        public decimal? PmPrice { get; set; }

        public Guid? PmBaseUnit { get; set; }

        public Guid? PmUnit { get; set; }

        public decimal? Pmbunsi { get; set; }

        public decimal? Pmbunbo { get; set; }

        public decimal? taxrate { get; set; }

        public long? tax_cls { get; set; }

        public decimal? originalCurrMoney { get; set; }

        public decimal? originalCurrTaxrate { get; set; }

        public decimal? homeCurrMoney { get; set; }

        public decimal? homeCurrTaxrate { get; set; }

        public long? caninvoice { get; set; }

        public decimal? alreadyQuantity { get; set; }

        [StringLength(1024)]
        public string remark { get; set; }

        public int? validflg { get; set; }

        [StringLength(32)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? deleteuser { get; set; }

        public DateTime? deletetime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ensuer_amount { get; set; }

        public Guid? salePmkit_id { get; set; }
    }
}
