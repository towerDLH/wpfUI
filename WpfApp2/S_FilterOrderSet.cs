namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FilterOrderSet
    {
        [Key]
        public Guid ForderID { get; set; }

        [StringLength(250)]
        public string ViewName { get; set; }

        [StringLength(250)]
        public string FiledName { get; set; }

        [StringLength(50)]
        public string AscOrDesc { get; set; }

        public int? Position { get; set; }

        public Guid? filterSetID { get; set; }

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
