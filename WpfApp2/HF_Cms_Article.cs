namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HF_Cms_Article
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        public int? TypeId { get; set; }

        [StringLength(50)]
        public string CateId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(50)]
        public string TitleColor { get; set; }

        [StringLength(256)]
        public string SubTitle { get; set; }

        [StringLength(512)]
        public string BriefContent { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [StringLength(50)]
        public string CompileName { get; set; }

        [StringLength(200)]
        public string TagWord { get; set; }

        [StringLength(200)]
        public string Keyword { get; set; }

        [StringLength(50)]
        public string SourceName { get; set; }

        [StringLength(255)]
        public string SourceAddress { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int? IsTop { get; set; }

        public int PV { get; set; }

        public DateTime? ReleaseTime { get; set; }

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

        [StringLength(50)]
        public string WorkFlowId { get; set; }

        [StringLength(50)]
        public string WorkFlowInstanceId { get; set; }

        [StringLength(50)]
        public string WorkTaskId { get; set; }

        [StringLength(50)]
        public string WorkTaskInstanceId { get; set; }

        public int? IsSys { get; set; }

        public int? IsSlide { get; set; }

        public int? IsRed { get; set; }

        public int? IsHot { get; set; }

        public int? IsMsg { get; set; }

        [StringLength(255)]
        public string ImgUrl { get; set; }

        [StringLength(255)]
        public string LinkUrl { get; set; }
    }
}
