namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mem_person
    {
        [Key]
        public Guid person_id { get; set; }

        public Guid? user_id { get; set; }

        [StringLength(64)]
        public string real_name { get; set; }

        public long? sex { get; set; }

        public long? age { get; set; }

        [StringLength(32)]
        public string nick_name { get; set; }

        public byte? card_type { get; set; }

        [StringLength(64)]
        public string card_no { get; set; }

        [StringLength(64)]
        public string country { get; set; }

        [StringLength(64)]
        public string province { get; set; }

        [StringLength(64)]
        public string city { get; set; }

        [StringLength(128)]
        public string county { get; set; }

        [StringLength(128)]
        public string street { get; set; }

        [StringLength(248)]
        public string address { get; set; }

        [StringLength(16)]
        public string tel { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(16)]
        public string fax { get; set; }

        public int? validflg { get; set; }

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

        public Guid? f_company_id { get; set; }
    }
}
