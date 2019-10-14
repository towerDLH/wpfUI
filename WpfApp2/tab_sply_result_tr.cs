namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_sply_result_tr
    {
        [Key]
        public Guid sply_rlt_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(35)]
        public string sply_rlt_no { get; set; }

        public DateTime? sply_date { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? prod_sply_no { get; set; }

        public Guid? location_id { get; set; }

        public Guid? acp_location_id { get; set; }

        public long? comp_status { get; set; }

        public Guid? comp_person { get; set; }

        public DateTime? comp_date { get; set; }

        public long? print_status { get; set; }

        public decimal? print_qty { get; set; }

        public Guid? print_person { get; set; }

        public DateTime? print_date { get; set; }

        [StringLength(50)]
        public string print_no { get; set; }

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
