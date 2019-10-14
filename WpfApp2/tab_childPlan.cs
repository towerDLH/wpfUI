namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_childPlan
    {
        [Key]
        public Guid childPlan_id { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? Pm_id { get; set; }

        [StringLength(50)]
        public string childPlan_code { get; set; }

        [StringLength(50)]
        public string childPlan_Num { get; set; }

        [StringLength(50)]
        public string productSize { get; set; }

        public decimal? productNum { get; set; }

        public decimal? productquanComple { get; set; }

        public decimal? productNotComple { get; set; }

        public decimal? percentComple { get; set; }

        [StringLength(50)]
        public string productModel { get; set; }

        public short? status { get; set; }

        public DateTime? scheduleStartDate { get; set; }

        public DateTime? scheduleEndtDate { get; set; }

        public DateTime? planStartDate { get; set; }

        public DateTime? planEndDate { get; set; }

        [StringLength(50)]
        public string invoiceSource { get; set; }

        public Guid? bomMultiMode_id { get; set; }

        [StringLength(1024)]
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

        public int? priority { get; set; }
    }
}
