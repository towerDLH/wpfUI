namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_desc_detail_ms
    {
        [Key]
        public Guid category_dtl_id { get; set; }

        public Guid? category_id { get; set; }

        public long? CLS_CD { get; set; }

        [StringLength(64)]
        public string CLS_DETAIL_DESC { get; set; }

        public long? CLS_DETAIL_CD { get; set; }

        [StringLength(128)]
        public string code { get; set; }

        public int? priority { get; set; }

        [StringLength(516)]
        public string remark { get; set; }

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

        public Guid? company_id { get; set; }
    }
}
