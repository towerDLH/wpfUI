namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkOutTime
    {
        [Key]
        [StringLength(50)]
        public string OutTimeId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(128)]
        public string Caption { get; set; }

        public int? Days { get; set; }

        public int? Hours { get; set; }

        public int? Minutes { get; set; }

        public int? Days1 { get; set; }

        public int? Hours1 { get; set; }

        public int? Minutes1 { get; set; }

        public int? Days2 { get; set; }

        public int? Hours2 { get; set; }

        public int? Minutes2 { get; set; }

        public int? DoneType { get; set; }

        public int? EnableTimeout { get; set; }
    }
}
