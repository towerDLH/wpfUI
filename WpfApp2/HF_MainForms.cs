namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_MainForms
    {
        [Key]
        [StringLength(50)]
        public string MainFormId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string FmClassId { get; set; }

        [StringLength(512)]
        public string Caption { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(50)]
        public string FormType { get; set; }

        [StringLength(512)]
        public string Url { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public int? IsPublic { get; set; }

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

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(512)]
        public string UrlMethod { get; set; }
    }
}
