namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mem_enter
    {
        [Key]
        public Guid enter_id { get; set; }

        public Guid? user_id { get; set; }

        [StringLength(128)]
        public string enter_name { get; set; }

        public long? busi_age { get; set; }

        public long? enter_scale { get; set; }

        [StringLength(1024)]
        public string main_busi { get; set; }

        [StringLength(2048)]
        public string website { get; set; }

        [StringLength(128)]
        public string country { get; set; }

        [StringLength(128)]
        public string province { get; set; }

        [StringLength(128)]
        public string city { get; set; }

        [StringLength(128)]
        public string area { get; set; }

        [StringLength(248)]
        public string street { get; set; }

        [StringLength(16)]
        public string tel { get; set; }

        [StringLength(16)]
        public string fax { get; set; }

        [StringLength(32)]
        public string name { get; set; }

        public byte? card_type { get; set; }

        [StringLength(32)]
        public string card_no { get; set; }

        public byte? register_status { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        [StringLength(16)]
        public string mobile { get; set; }

        [StringLength(32)]
        public string address { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

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
