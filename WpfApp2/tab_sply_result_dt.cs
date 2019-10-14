namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_sply_result_dt
    {
        [Key]
        public Guid sply_rltdt_id { get; set; }

        public Guid? dt_sply_rlt_id { get; set; }

        public Guid? fac_id { get; set; }

        public long? sply_cls { get; set; }

        public Guid? item_id { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? location_id { get; set; }

        public Guid? acp_location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sply_qty { get; set; }

        public Guid? sply_unit_cd { get; set; }

        public Guid? std_unit_cd { get; set; }

        public decimal? sply_amt { get; set; }

        public decimal? sply_up { get; set; }

        public Guid? upper_item_id { get; set; }

        public long? upper_proc_ptn { get; set; }

        public Guid? upper_proc_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CurBalance { get; set; }

        public Guid? Pinstr_id { get; set; }

        [StringLength(200)]
        public string remark1 { get; set; }

        [StringLength(200)]
        public string remark2 { get; set; }

        public Guid? entry_person { get; set; }

        public DateTime? entry_date { get; set; }

        public Guid? upd_person { get; set; }

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
