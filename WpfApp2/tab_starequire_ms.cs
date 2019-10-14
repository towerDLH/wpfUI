namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_starequire_ms
    {
        [Key]
        public Guid require_id { get; set; }

        public Guid? standard_id { get; set; }

        public int? require_req { get; set; }

        [StringLength(35)]
        public string require_no { get; set; }

        [StringLength(35)]
        public string require_content { get; set; }

        [StringLength(35)]
        public string check_method { get; set; }

        public long? equip_difference { get; set; }

        public long? equip_group { get; set; }

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

        public Guid? sourcerequireid { get; set; }
    }
}
