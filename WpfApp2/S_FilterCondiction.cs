namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FilterCondiction
    {
        [Key]
        public Guid condictionID { get; set; }

        [StringLength(160)]
        public string ViewName { get; set; }

        [StringLength(50)]
        public string fieldType { get; set; }

        public int? fieldLength { get; set; }

        [StringLength(50)]
        public string operatorsybol { get; set; }

        public int? ParaType { get; set; }

        [StringLength(1024)]
        public string paraProviderSQL { get; set; }

        [StringLength(50)]
        public string conectSyb { get; set; }

        [StringLength(160)]
        public string condictionName { get; set; }

        [StringLength(256)]
        public string condictionDes { get; set; }

        public int? condictionPosition { get; set; }

        public Guid? blockID { get; set; }

        public bool? notFlag { get; set; }

        [StringLength(128)]
        public string filedName { get; set; }

        public int? operatorSQL { get; set; }

        [StringLength(256)]
        public string parmA { get; set; }

        [StringLength(256)]
        public string parmB { get; set; }

        public DateTime? paramC { get; set; }

        public int? datetype { get; set; }

        public bool? waitforinput { get; set; }

        [StringLength(50)]
        public string comboViewName { get; set; }

        [StringLength(252)]
        public string comboDisplayPath { get; set; }

        [StringLength(252)]
        public string comboValuePath { get; set; }

        [StringLength(126)]
        public string comboPrimaryID { get; set; }

        [StringLength(150)]
        public string comboOrderFiled { get; set; }

        [StringLength(150)]
        public string comboFiltField { get; set; }

        [StringLength(50)]
        public string comboFiltValue { get; set; }

        [StringLength(500)]
        public string comboSQL { get; set; }

        public int? validflg { get; set; }

        public Guid? f_company_id { get; set; }

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
    }
}
