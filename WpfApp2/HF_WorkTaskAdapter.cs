namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTaskAdapter
    {
        [Key]
        [StringLength(50)]
        public string AdapterId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(128)]
        public string Caption { get; set; }

        [StringLength(50)]
        public string AdapterType { get; set; }

        [StringLength(256)]
        public string Context { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string RunType { get; set; }

        [StringLength(128)]
        public string ClassName { get; set; }

        [StringLength(128)]
        public string DllName { get; set; }

        [StringLength(128)]
        public string MethodName { get; set; }

        [StringLength(50)]
        public string DataBaseCfgName { get; set; }
    }
}
