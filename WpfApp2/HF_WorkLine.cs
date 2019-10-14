namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkLine
    {
        [Key]
        [StringLength(50)]
        public string WorkLineId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [Required]
        [StringLength(50)]
        public string StartTaskId { get; set; }

        [Required]
        [StringLength(50)]
        public string EndTaskId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Condition { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(50)]
        public string LineType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LineM { get; set; }

        [StringLength(512)]
        public string BreakX { get; set; }

        [StringLength(512)]
        public string BreakY { get; set; }

        [Required]
        [StringLength(128)]
        public string CommandName { get; set; }

        public int? Priority { get; set; }
    }
}
