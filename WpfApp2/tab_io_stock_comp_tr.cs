namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_io_stock_comp_tr
    {
        [Key]
        public Guid io_comp_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(35)]
        public string io_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? line_no { get; set; }

        public DateTime? io_notes_date { get; set; }

        [StringLength(6)]
        public string io_notes_person { get; set; }

        public DateTime? io_date { get; set; }

        public long? io_cls { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(25)]
        public string seiban { get; set; }

        public long? ins_cls { get; set; }

        public long? vou_cls { get; set; }

        public long? ind_dest_cd { get; set; }

        public long? ind_content { get; set; }

        [StringLength(35)]
        public string sou_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sou_line_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? io_notes_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? io_result_qty { get; set; }

        public Guid? sou_location_id { get; set; }

        public Guid? obj_location_id { get; set; }

        [StringLength(6)]
        public string io_person { get; set; }

        public long? comp_status { get; set; }

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
