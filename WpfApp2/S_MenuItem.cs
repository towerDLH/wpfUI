namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_MenuItem
    {
        [Key]
        public Guid MenuItemID { get; set; }

        [StringLength(150)]
        public string ItemName { get; set; }

        public int? ItemType { get; set; }

        [StringLength(150)]
        public string ItemText { get; set; }

        [StringLength(500)]
        public string Path { get; set; }

        public byte[] obj { get; set; }

        public Guid? MenuID { get; set; }

        [Column(TypeName = "image")]
        public byte[] LargeIconPath { get; set; }

        [Column(TypeName = "image")]
        public byte[] IconPath { get; set; }

        [StringLength(500)]
        public string ItemCLID { get; set; }

        [Column(TypeName = "xml")]
        public string ItemObj { get; set; }

        public bool? Validflg { get; set; }

        public int? ItemSno { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
