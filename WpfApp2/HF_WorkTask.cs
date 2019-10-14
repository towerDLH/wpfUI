namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTask
    {
        [Key]
        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(1)]
        public string TaskTypeId { get; set; }

        [StringLength(50)]
        public string TaskTypeAndOr { get; set; }

        [StringLength(128)]
        public string TaskCaption { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public int? iXPosition { get; set; }

        public int? iYPosition { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        public string OperRule { get; set; }

        public int IsJumpSelf { get; set; }
    }
}
