namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_calendar
    {
        [Key]
        public Guid calendar_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(32)]
        public string fac_code { get; set; }

        public DateTime? op_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fac_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? day_no { get; set; }

        [StringLength(4)]
        public string wk_cls { get; set; }

        [StringLength(6)]
        public string short_date { get; set; }

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
