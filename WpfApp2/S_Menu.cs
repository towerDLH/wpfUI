namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Menu
    {
        [Key]
        public Guid MenuID { get; set; }

        [StringLength(150)]
        public string MenuName { get; set; }

        public int? MenuSno { get; set; }

        public bool? Validflg { get; set; }

        public int? MenuType { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }
    }
}
