namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTaskForm
    {
        [Key]
        [StringLength(50)]
        public string TaskFormId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string MainFormId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string FormType { get; set; }
    }
}
