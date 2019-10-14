namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_stock_move_dtl
    {
        [Key]
        public Guid stock_move_dtl_id { get; set; }

        public Guid stock_move_tr_id { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? location_id { get; set; }

        public Guid? obj_location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? basemove_qty { get; set; }

        public Guid? baseunit_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? move_qty { get; set; }

        public Guid? unit_id { get; set; }

        [StringLength(50)]
        public string move_reason { get; set; }

        public Guid? entry_person { get; set; }

        public DateTime? entry_date { get; set; }

        public Guid? upd_person { get; set; }

        public DateTime? upd_date { get; set; }

        public int? pmstatus { get; set; }

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
