namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ResetPmRecord
    {
        [Key]
        public Guid t_resetpmrecord_id { get; set; }

        [StringLength(50)]
        public string record_code { get; set; }

        public Guid? pm_id { get; set; }

        [StringLength(50)]
        public string pm_name { get; set; }

        [StringLength(50)]
        public string pm_code { get; set; }

        public Guid? location_id { get; set; }

        [StringLength(50)]
        public string location_name { get; set; }

        public Guid? prc_id { get; set; }

        [StringLength(50)]
        public string prc_name { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(50)]
        public string lot_no { get; set; }

        public Guid? business_id { get; set; }

        [StringLength(50)]
        public string business_code { get; set; }

        public int? business_type { get; set; }

        public DateTime? reset_date { get; set; }

        public int? reset_times { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reset_num { get; set; }

        public Guid? unit_id { get; set; }

        [StringLength(50)]
        public string unit_name { get; set; }

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
    }
}
