namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_FormClass
    {
        [Key]
        [StringLength(50)]
        public string FMClassId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(128)]
        public string Caption { get; set; }

        [StringLength(50)]
        public string FatherId { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public int? ClassLevel { get; set; }

        [StringLength(50)]
        public string FormType { get; set; }

        public int OrderNum { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public DateTime? ModifyTime { get; set; }

        public int DeleteFlag { get; set; }

        public int EnableFlag { get; set; }
    }
}
