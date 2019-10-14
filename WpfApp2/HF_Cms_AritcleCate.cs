namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Cms_AritcleCate
    {
        [Key]
        [StringLength(50)]
        public string CateId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string CateCaption { get; set; }

        [StringLength(50)]
        public string FatherId { get; set; }

        [StringLength(255)]
        public string ImgUrl { get; set; }

        [StringLength(255)]
        public string LinkUrl { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int? IsSys { get; set; }

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
