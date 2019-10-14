namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_comfirm_dtl
    {
        [Key]
        public Guid comfirm_dlt_id { get; set; }

        public Guid? comfirm_id { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? acp_id { get; set; }

        [StringLength(50)]
        public string acp_no { get; set; }

        public Guid? ins_id { get; set; }

        [StringLength(50)]
        public string ins_no { get; set; }

        public decimal? sum_qty { get; set; }

        public decimal? acp_qty { get; set; }

        public decimal? uncomp_qty { get; set; }

        public decimal? uncomp_realqty { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? acp_unit { get; set; }

        public Guid? ori_location_id { get; set; }

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

        public int? pmstatus { get; set; }

        public Guid? uncompid { get; set; }
    }
}
