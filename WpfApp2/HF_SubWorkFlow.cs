namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_SubWorkFlow
    {
        [Key]
        [StringLength(50)]
        public string SubWFId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string SubWorkFlowId { get; set; }

        [StringLength(50)]
        public string SubWorkFlowCaption { get; set; }

        [StringLength(50)]
        public string SubStartTaskId { get; set; }

        [StringLength(50)]
        public string SubStartTaskCaption { get; set; }

        [StringLength(512)]
        public string Description { get; set; }
    }
}
