namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mem_card
    {
        public Guid? card_type_id { get; set; }

        [Key]
        public Guid card_page_id { get; set; }

        public Guid? user_id { get; set; }

        [StringLength(1024)]
        public string facade_img { get; set; }

        [StringLength(1024)]
        public string sid_img { get; set; }

        public DateTime? effective_time { get; set; }

        public DateTime? Invalid_time { get; set; }

        public byte? effective_status { get; set; }

        public byte? examine_status { get; set; }

        [StringLength(1024)]
        public string examine_notes { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public Guid? f_company_id { get; set; }
    }
}
