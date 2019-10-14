namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FilterSet
    {
        [Key]
        public Guid FilterSetID { get; set; }

        public Guid? menuItemID { get; set; }

        [StringLength(512)]
        public string listTitle { get; set; }

        [StringLength(256)]
        public string filterName { get; set; }

        [StringLength(600)]
        public string bllName { get; set; }

        [StringLength(256)]
        public string ctlName { get; set; }

        [StringLength(256)]
        public string grdName { get; set; }

        [StringLength(526)]
        public string sourceTable { get; set; }

        [StringLength(150)]
        public string KeyIDName { get; set; }

        public int? PageSize { get; set; }

        public int? tableorview { get; set; }

        public Guid? userID { get; set; }

        public bool? showPanel { get; set; }

        public int? filterSetType { get; set; }

        [StringLength(2048)]
        public string SQLstr { get; set; }

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

        public bool? showNextProcessBtn { get; set; }

        [StringLength(600)]
        public string nextProcessDllname { get; set; }

        [StringLength(256)]
        public string nextProcessCtlname { get; set; }
    }
}
