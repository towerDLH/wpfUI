namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_laboratory_infor
    {
        [Key]
        public Guid ins_id { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? uncheck_id { get; set; }

        [StringLength(50)]
        public string ins_no { get; set; }

        public DateTime? ins_date { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? location_id { get; set; }

        public decimal? ins_curqty { get; set; }

        public decimal? ins_samplingqty { get; set; }

        public Guid? ins_person { get; set; }

        [StringLength(1024)]
        public string ins_remark { get; set; }

        public Guid? review_person { get; set; }

        public DateTime? ins_rslt_date { get; set; }

        public decimal? std_acp_qty { get; set; }

        public decimal? tobeins_qty { get; set; }

        public long? ins_cls { get; set; }

        public long? ins_judge { get; set; }

        public long? ins_deal { get; set; }

        public long? ins_answer { get; set; }

        public decimal? ins_ok_qty { get; set; }

        public decimal? ins_rtj_qty { get; set; }

        public decimal? ins_loss_qty { get; set; }

        public decimal? ins_in_qty { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        [StringLength(50)]
        public string ins_ptn { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? acp_id { get; set; }

        [StringLength(50)]
        public string acp_no { get; set; }

        public Guid? acp_person { get; set; }

        public Guid? std_unit_cd { get; set; }

        public Guid? purorder_id { get; set; }

        [StringLength(50)]
        public string purorder_no { get; set; }

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

        public Guid? versioncenter_id { get; set; }

        public Guid? insmode_id { get; set; }

        public decimal? reinspection_qty { get; set; }

        public decimal? qualified_qty { get; set; }

        public decimal? unqualified_qty { get; set; }

        public decimal? bad_qty { get; set; }
    }
}
