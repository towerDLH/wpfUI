namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stock_new_tr
    {
        [Key]
        public Guid stock_new_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(35)]
        public string stock_new_no { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? location_id { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public DateTime? stnew_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stnew_qty { get; set; }

        public Guid? stnew_person { get; set; }

        public DateTime? entry_date { get; set; }

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
