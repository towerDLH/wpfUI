namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_SYSSET
    {
        [Key]
        public Guid Suid { get; set; }

        public bool? SyncTips { get; set; }

        public bool? WarrantyRow { get; set; }

        public bool? Certificate { get; set; }

        public bool? UnitPrice { get; set; }

        public bool? AutomaticOrder { get; set; }

        public bool? PrintOrder { get; set; }

        public bool? ForeignCounterOrder { get; set; }

        public bool? ProductionScan { get; set; }

        public bool? CloseOrder { get; set; }

        public bool? AutomaticRawMaterial { get; set; }

        public int? ProductPrice { get; set; }

        public bool? UpdateReport { get; set; }

        public bool? RecordPhoto { get; set; }

        public bool? InfoCopy { get; set; }

        public bool? OrderModification { get; set; }

        public bool? LineNumber { get; set; }

        public bool? OrderPreservation { get; set; }

        public int? Minutes { get; set; }

        public bool? OrderQuery { get; set; }

        public bool? OrderThePop_up { get; set; }

        public bool? PlayProcessingSingle { get; set; }

        public bool? ReturnTheUnitPrice { get; set; }

        public bool? DetailedPictures { get; set; }

        public bool? PrintingCompany { get; set; }

        public bool? AvoidLanding { get; set; }

        public bool? QuickLogin { get; set; }

        public bool? DrugSafetyFunction { get; set; }

        public bool? Line { get; set; }

        public bool? Disinfection { get; set; }

        public bool? MoreProcess { get; set; }

        public bool? ProcessInspection { get; set; }

        public bool? AutomaticDelivery { get; set; }

        public bool? OrderScanning { get; set; }

        public bool? TheOrderColor { get; set; }

        public int? PhotoSoftware { get; set; }

        public int? PagingDisplay { get; set; }

        [StringLength(50)]
        public string TheSubsystemID { get; set; }

        public int? FinishedDays { get; set; }

        public int? ShipmentDays { get; set; }

        [StringLength(50)]
        public string IMSystemServerIP { get; set; }

        [StringLength(50)]
        public string FTPSystemServerIP { get; set; }

        [StringLength(50)]
        public string ImageStorageEndIP { get; set; }

        [StringLength(50)]
        public string TheUserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? validflg { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public bool? OrderNoLimit { get; set; }

        public bool? autocheckdisinfect { get; set; }

        public bool? zeropriceRemind { get; set; }

        public bool? noxjflg { get; set; }

        public bool? nouseflg { get; set; }

        public bool? zeropriceForbid { get; set; }

        public bool? inreworkflg { get; set; }

        public bool? handercheckdisinfect { get; set; }

        public bool? outreworkflg { get; set; }

        public bool? ordernodefault { get; set; }

        public int? orderdefaultdate { get; set; }

        public bool? materialflg { get; set; }

        public bool? materialCheckflg { get; set; }

        public bool? orderrecordrunoutflg { get; set; }

        public int? processminute { get; set; }

        public int? processremindflg { get; set; }

        public int? certificateNum { get; set; }

        public bool? isprintJYJLDflg { get; set; }

        public bool? autolmjyflg { get; set; }

        public bool? autolmxdflg { get; set; }

        public bool? autocpjyflg { get; set; }

        public bool? autocpxdflg { get; set; }

        public bool? ycjgjlczrczsjflg { get; set; }

        public bool? equipmentcollectflg { get; set; }

        public bool? cpjytbchtjflg { get; set; }

        public bool? nextChecklastflg { get; set; }

        public bool? importsvnflg { get; set; }

        public int? sgslflg { get; set; }

        public bool outcanprintshdflg { get; set; }

        public bool cprkflg { get; set; }

        public bool? scanpwdflg { get; set; }

        public bool? showstaffcode { get; set; }

        public bool? printhzfilt { get; set; }
    }
}
