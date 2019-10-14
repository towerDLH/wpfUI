namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_worsheet
    {
        [Key]
        public Guid worsheet_id { get; set; }

        [StringLength(50)]
        public string worsheet_code { get; set; }

        public Guid? productPlan_id { get; set; }

        public Guid? childPlan_id { get; set; }

        public Guid? productRoughPlan_id { get; set; }

        public Guid? worMergeLot_id { get; set; }

        public Guid? proc_id { get; set; }

        public DateTime? productStartDate { get; set; }

        public DateTime? productEndDate { get; set; }

        public DateTime? planStartDate { get; set; }

        public DateTime? planEndDate { get; set; }

        public decimal? outputNum { get; set; }

        public decimal? qualifiedNum { get; set; }

        public decimal? scrapNum { get; set; }

        public Guid? unit { get; set; }

        public Guid? Pm_id { get; set; }

        [StringLength(50)]
        public string model_SizeOrFigure { get; set; }

        public decimal? productTaskNum { get; set; }

        public DateTime? orderTime { get; set; }

        [StringLength(50)]
        public string pn { get; set; }

        [StringLength(50)]
        public string technology { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(50)]
        public string lot_no { get; set; }

        public long? manufactureStatus { get; set; }

        public long? mergerLogStatus { get; set; }

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

        public Guid? producecenterid { get; set; }

        [StringLength(50)]
        public string producecentercode { get; set; }

        [StringLength(50)]
        public string roughtplancode { get; set; }

        public Guid? fac_id { get; set; }

        public int? ins_cls { get; set; }

        public Guid? worsheetUserId { get; set; }
    }
}
