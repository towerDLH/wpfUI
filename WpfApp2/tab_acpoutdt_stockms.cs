namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_acpoutdt_stockms
    {
        [Key]
        public Guid acpoutstock_id { get; set; }

        public Guid? actout_id { get; set; }

        public Guid? actout_dlt_id { get; set; }

        public Guid? proc_id { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? location_id { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? item_id { get; set; }

        public decimal? CurBalance { get; set; }

        public decimal? acpoutqty { get; set; }

        public decimal? curacpoutqty { get; set; }

        public Guid? pmUnit { get; set; }

        public Guid? pmBaseUnit { get; set; }

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

        public int? pmstatus { get; set; }
    }
}
