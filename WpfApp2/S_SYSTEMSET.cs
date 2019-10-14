namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_SYSTEMSET
    {
        [StringLength(1)]
        public string synchronousflg { get; set; }

        [StringLength(1)]
        public string staffsetflg { get; set; }

        [StringLength(1)]
        public string productpriceflg { get; set; }

        [StringLength(1)]
        public string staffprosetflg { get; set; }

        public int? finishdate { get; set; }

        public int? outdate { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime regdatetime { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(20)]
        public string updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        [StringLength(20)]
        public string deleteuser { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] lastchanged { get; set; }

        [StringLength(1)]
        public string printoneflg { get; set; }

        [StringLength(3)]
        public string uniquenum { get; set; }

        [StringLength(1)]
        public string shippingprices { get; set; }

        [StringLength(1)]
        public string sricestatus { get; set; }

        [StringLength(1)]
        public string subline { get; set; }

        [StringLength(1)]
        public string processnumber { get; set; }

        [StringLength(1)]
        public string automaticbarcode { get; set; }

        [StringLength(1)]
        public string aotoprintbarcode { get; set; }

        [StringLength(1)]
        public string outsideback { get; set; }

        [StringLength(1)]
        public string productioninterface { get; set; }

        [StringLength(1)]
        public string tryhandling { get; set; }

        [StringLength(1)]
        public string matchrawmaterial { get; set; }

        [StringLength(1)]
        public string canchange { get; set; }

        [StringLength(1)]
        public string returnorderflg { get; set; }

        [StringLength(1)]
        public string cansave { get; set; }

        public int? cansavetime { get; set; }

        [StringLength(1)]
        public string beforeorderin { get; set; }

        [StringLength(1)]
        public string drug { get; set; }

        [StringLength(1)]
        public string disinfection { get; set; }

        [StringLength(1)]
        public string inseizure { get; set; }

        [StringLength(1)]
        public string outseizure { get; set; }

        [StringLength(1)]
        public string eligiblesingle { get; set; }

        [StringLength(1)]
        public string processinspection { get; set; }

        [StringLength(1)]
        public string wrap { get; set; }

        [StringLength(1)]
        public string billprice { get; set; }
    }
}
