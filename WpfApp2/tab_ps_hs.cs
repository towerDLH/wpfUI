namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_ps_hs
    {
        [Key]
        public Guid hs_id { get; set; }

        public long? hs_type { get; set; }

        public Guid? pm_id { get; set; }

        public Guid? fac_cd { get; set; }

        [StringLength(10)]
        public string seiban { get; set; }

        public Guid? upper_item_cd { get; set; }

        [StringLength(50)]
        public string uppe_itemr_name { get; set; }

        public long? use_seq { get; set; }

        public Guid? lower_item_cd { get; set; }

        [StringLength(50)]
        public string lower_item_name { get; set; }

        [StringLength(50)]
        public string node_path { get; set; }

        public long? bom_type { get; set; }

        public decimal? batch_size_buns { get; set; }

        public decimal? batch_size_bunbo { get; set; }

        public Guid? req_seq { get; set; }

        public decimal? failure_rate { get; set; }

        public long? charged_sply_cls { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public Guid? part_no { get; set; }

        public long? ready_qty { get; set; }

        public long? changed_state { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        [StringLength(100)]
        public string remark2 { get; set; }

        [StringLength(100)]
        public string remark3 { get; set; }

        [StringLength(100)]
        public string remark4 { get; set; }

        public DateTime? entry_date { get; set; }

        public DateTime? upd_date { get; set; }

        public Guid? last_user { get; set; }

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
