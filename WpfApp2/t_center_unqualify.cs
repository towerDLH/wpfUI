namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_center_unqualify
    {
        [Key]
        public Guid unqualify_id { get; set; }

        public Guid? billmainid { get; set; }

        public Guid? billdetailid { get; set; }

        public int? billtype { get; set; }

        public Guid? fac_id { get; set; }

        public int? unqualify_req { get; set; }

        [StringLength(50)]
        public string unqualify_no { get; set; }

        public Guid? std_unit_cd { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public decimal? unquelify_qty { get; set; }

        public decimal? out_qty { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? location_id { get; set; }

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
