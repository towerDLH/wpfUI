namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_labinfor_dtl
    {
        [Key]
        public Guid ins_dlt_id { get; set; }

        public Guid? ins_id { get; set; }

        public Guid? laSpecimenResult_id { get; set; }

        [StringLength(35)]
        public string clause { get; set; }

        [StringLength(35)]
        public string ins_pro { get; set; }

        public Guid? standard_id { get; set; }

        public Guid? require_id { get; set; }

        public Guid? requireQualified { get; set; }

        [StringLength(35)]
        public string tech_require { get; set; }

        public decimal? sampling_qty { get; set; }

        [StringLength(35)]
        public string casual_ins_res { get; set; }

        public decimal? ins_rtj_qty { get; set; }

        public long? ins_judge { get; set; }

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

        public Guid? ins_userid { get; set; }
    }
}
