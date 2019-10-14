namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FilterOrder
    {
        [Key]
        public Guid filterOrderID { get; set; }

        public Guid? filterSetID { get; set; }

        [StringLength(256)]
        public string filterField { get; set; }

        public int? filedPositon { get; set; }

        public bool? DescFlag { get; set; }

        public bool? showOnPanel { get; set; }

        public int? validflg { get; set; }

        public Guid? f_company_id { get; set; }

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
