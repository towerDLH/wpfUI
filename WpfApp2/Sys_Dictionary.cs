namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Dictionary
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string FatherId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string DicType { get; set; }

        [StringLength(50)]
        public string Caption { get; set; }

        [StringLength(50)]
        public string DicParameter { get; set; }

        [StringLength(128)]
        public string DicValue { get; set; }

        public int IsSys { get; set; }

        public int IsPublic { get; set; }

        public int? Layer { get; set; }

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

        [StringLength(256)]
        public string Description { get; set; }
    }
}
