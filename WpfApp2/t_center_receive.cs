namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_center_receive
    {
        [Key]
        public Guid reccenterid { get; set; }

        public Guid? businessmainid { get; set; }

        public Guid? businessdetailid { get; set; }

        [StringLength(50)]
        public string businessmaincode { get; set; }

        public int? businesstype { get; set; }

        [StringLength(50)]
        public string centercode { get; set; }

        public Guid? std_unit_cd { get; set; }

        public int? recstatus { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public decimal? rec_qty { get; set; }

        public decimal? receiveed_qty { get; set; }

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
