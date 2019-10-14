namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Operator
    {
        [Key]
        [StringLength(50)]
        public string OperatorId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        public int? OperType { get; set; }

        [StringLength(256)]
        public string OperContent { get; set; }

        public int? Relation { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public int? InorExclude { get; set; }

        [StringLength(256)]
        public string OperDisplay { get; set; }
    }
}
