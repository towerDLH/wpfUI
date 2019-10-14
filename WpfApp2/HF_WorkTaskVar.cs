namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_WorkTaskVar
    {
        [Key]
        [StringLength(50)]
        public string WorkTaskVarId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(128)]
        public string VarName { get; set; }

        [StringLength(50)]
        public string VarType { get; set; }

        [StringLength(50)]
        public string DataBaseCfgId { get; set; }

        [StringLength(128)]
        public string TableName { get; set; }

        [StringLength(128)]
        public string TableField { get; set; }

        [StringLength(128)]
        public string InitValue { get; set; }

        [StringLength(50)]
        public string AccessType { get; set; }

        [StringLength(50)]
        public string DataBaseSever { get; set; }

        [StringLength(50)]
        public string OrderNum { get; set; }

        [StringLength(50)]
        public string ValueSortField { get; set; }
    }
}
