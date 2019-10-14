namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tab_PmSourceStation
    {
        public Guid Id { get; set; }

        public Guid? PId { get; set; }

        public Guid? PmId { get; set; }

        public Guid? PrcId { get; set; }

        public byte? Operation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EsTime { get; set; }

        public double? RealNum { get; set; }

        public double? OccupyNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiry { get; set; }

        public string Remark { get; set; }

        public int? Validflg { get; set; }

        public DateTime? Regdatetime { get; set; }

        public Guid? Regdateuser { get; set; }

        public DateTime? Updatetime { get; set; }

        public Guid? Updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public double? RequestNum { get; set; }

        public double? OccupiedNum { get; set; }

        public int? OrderType { get; set; }
    }
}
