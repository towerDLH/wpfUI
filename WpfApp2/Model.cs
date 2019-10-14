namespace WpfApp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<B_ClBtnConfig> B_ClBtnConfig { get; set; }
        public virtual DbSet<B_ClBtnMethodProperty> B_ClBtnMethodProperty { get; set; }
        public virtual DbSet<base_calendar> base_calendar { get; set; }
        public virtual DbSet<base_category> base_category { get; set; }
        public virtual DbSet<base_category_dtl> base_category_dtl { get; set; }
        public virtual DbSet<HF_AccreditUser> HF_AccreditUser { get; set; }
        public virtual DbSet<HF_Cms_AritcleCate> HF_Cms_AritcleCate { get; set; }
        public virtual DbSet<HF_Cms_Article> HF_Cms_Article { get; set; }
        public virtual DbSet<HF_FormClass> HF_FormClass { get; set; }
        public virtual DbSet<HF_Group> HF_Group { get; set; }
        public virtual DbSet<HF_Logs> HF_Logs { get; set; }
        public virtual DbSet<HF_MainForms> HF_MainForms { get; set; }
        public virtual DbSet<HF_Module> HF_Module { get; set; }
        public virtual DbSet<HF_ModuleButton> HF_ModuleButton { get; set; }
        public virtual DbSet<HF_Operator> HF_Operator { get; set; }
        public virtual DbSet<HF_OperatorInstance> HF_OperatorInstance { get; set; }
        public virtual DbSet<HF_Organize> HF_Organize { get; set; }
        public virtual DbSet<HF_Purview> HF_Purview { get; set; }
        public virtual DbSet<HF_ServiceMessage> HF_ServiceMessage { get; set; }
        public virtual DbSet<HF_SubWorkFlow> HF_SubWorkFlow { get; set; }
        public virtual DbSet<HF_User_Token> HF_User_Token { get; set; }
        public virtual DbSet<HF_UserGroup> HF_UserGroup { get; set; }
        public virtual DbSet<HF_WorkFlow> HF_WorkFlow { get; set; }
        public virtual DbSet<HF_WorkFlowAbnormal> HF_WorkFlowAbnormal { get; set; }
        public virtual DbSet<HF_WorkFlowClass> HF_WorkFlowClass { get; set; }
        public virtual DbSet<HF_WorkFlowInstance> HF_WorkFlowInstance { get; set; }
        public virtual DbSet<HF_WorkFlowRemindEvent> HF_WorkFlowRemindEvent { get; set; }
        public virtual DbSet<HF_WorkLine> HF_WorkLine { get; set; }
        public virtual DbSet<HF_WorkOutTime> HF_WorkOutTime { get; set; }
        public virtual DbSet<HF_WorkTask> HF_WorkTask { get; set; }
        public virtual DbSet<HF_WorkTaskAdapter> HF_WorkTaskAdapter { get; set; }
        public virtual DbSet<HF_WorkTaskCommands> HF_WorkTaskCommands { get; set; }
        public virtual DbSet<HF_WorkTaskForm> HF_WorkTaskForm { get; set; }
        public virtual DbSet<HF_WorkTaskInstance> HF_WorkTaskInstance { get; set; }
        public virtual DbSet<HF_WorkTaskInstanceNextOper> HF_WorkTaskInstanceNextOper { get; set; }
        public virtual DbSet<HF_WorkTaskPower> HF_WorkTaskPower { get; set; }
        public virtual DbSet<HF_WorkTaskVar> HF_WorkTaskVar { get; set; }
        public virtual DbSet<mem_card> mem_card { get; set; }
        public virtual DbSet<mem_card_type> mem_card_type { get; set; }
        public virtual DbSet<mem_enter> mem_enter { get; set; }
        public virtual DbSet<mem_person> mem_person { get; set; }
        public virtual DbSet<orderprcEquip> orderprcEquip { get; set; }
        public virtual DbSet<QS_ModelEquipment_RX> QS_ModelEquipment_RX { get; set; }
        public virtual DbSet<QS_ModelMS_RX> QS_ModelMS_RX { get; set; }
        public virtual DbSet<QS_ModelPrcExam_RX> QS_ModelPrcExam_RX { get; set; }
        public virtual DbSet<QS_ModelProcess_RX> QS_ModelProcess_RX { get; set; }
        public virtual DbSet<QS_ModelTemplate> QS_ModelTemplate { get; set; }
        public virtual DbSet<R_ButtonReport> R_ButtonReport { get; set; }
        public virtual DbSet<R_TEMPLATE> R_TEMPLATE { get; set; }
        public virtual DbSet<S_COMPANY> S_COMPANY { get; set; }
        public virtual DbSet<S_FilterCondiction> S_FilterCondiction { get; set; }
        public virtual DbSet<S_FilterFiledSet> S_FilterFiledSet { get; set; }
        public virtual DbSet<S_FilterOrder> S_FilterOrder { get; set; }
        public virtual DbSet<S_FilterOrderSet> S_FilterOrderSet { get; set; }
        public virtual DbSet<S_FilterSet> S_FilterSet { get; set; }
        public virtual DbSet<S_FilterSQLblock> S_FilterSQLblock { get; set; }
        public virtual DbSet<S_IDrecords> S_IDrecords { get; set; }
        public virtual DbSet<s_lan> s_lan { get; set; }
        public virtual DbSet<S_Menu> S_Menu { get; set; }
        public virtual DbSet<S_MenuItem> S_MenuItem { get; set; }
        public virtual DbSet<S_Part> S_Part { get; set; }
        public virtual DbSet<S_Permissions> S_Permissions { get; set; }
        public virtual DbSet<S_Permissions_Category> S_Permissions_Category { get; set; }
        public virtual DbSet<S_PHONE> S_PHONE { get; set; }
        public virtual DbSet<S_RoleAndPermissions> S_RoleAndPermissions { get; set; }
        public virtual DbSet<S_RoleAndPermissionsB> S_RoleAndPermissionsB { get; set; }
        public virtual DbSet<S_RoleAndUser> S_RoleAndUser { get; set; }
        public virtual DbSet<S_ROLEUSER> S_ROLEUSER { get; set; }
        public virtual DbSet<S_SYSSET> S_SYSSET { get; set; }
        public virtual DbSet<S_USER> S_USER { get; set; }
        public virtual DbSet<Sys_CompanyUser_Guide> Sys_CompanyUser_Guide { get; set; }
        public virtual DbSet<Sys_Dictionary> Sys_Dictionary { get; set; }
        public virtual DbSet<T_BusinessInterface> T_BusinessInterface { get; set; }
        public virtual DbSet<t_center_produce> t_center_produce { get; set; }
        public virtual DbSet<t_center_purchase> t_center_purchase { get; set; }
        public virtual DbSet<t_center_receive> t_center_receive { get; set; }
        public virtual DbSet<t_center_StockInventory> t_center_StockInventory { get; set; }
        public virtual DbSet<t_center_unqualify> t_center_unqualify { get; set; }
        public virtual DbSet<t_interface_btnconfig> t_interface_btnconfig { get; set; }
        public virtual DbSet<T_pmcategory_dic> T_pmcategory_dic { get; set; }
        public virtual DbSet<T_pmsource_dic> T_pmsource_dic { get; set; }
        public virtual DbSet<T_pmsource_rs> T_pmsource_rs { get; set; }
        public virtual DbSet<T_pmusing_dic> T_pmusing_dic { get; set; }
        public virtual DbSet<T_pmusing_rs> T_pmusing_rs { get; set; }
        public virtual DbSet<t_productPlanNoticeRs> t_productPlanNoticeRs { get; set; }
        public virtual DbSet<T_ResetPmRecord> T_ResetPmRecord { get; set; }
        public virtual DbSet<t_stock_move_dtl> t_stock_move_dtl { get; set; }
        public virtual DbSet<t_stock_move_tr> t_stock_move_tr { get; set; }
        public virtual DbSet<t_versioncenter> t_versioncenter { get; set; }
        public virtual DbSet<tab_acp_tr> tab_acp_tr { get; set; }
        public virtual DbSet<tab_acp_tr_dtl> tab_acp_tr_dtl { get; set; }
        public virtual DbSet<tab_acpout_tr> tab_acpout_tr { get; set; }
        public virtual DbSet<tab_acpout_tr_dtl> tab_acpout_tr_dtl { get; set; }
        public virtual DbSet<tab_acpoutdt_stockms> tab_acpoutdt_stockms { get; set; }
        public virtual DbSet<tab_auto_num_ms> tab_auto_num_ms { get; set; }
        public virtual DbSet<tab_bomMode> tab_bomMode { get; set; }
        public virtual DbSet<tab_BomMultiMode> tab_BomMultiMode { get; set; }
        public virtual DbSet<tab_BomTemplate> tab_BomTemplate { get; set; }
        public virtual DbSet<tab_childPlan> tab_childPlan { get; set; }
        public virtual DbSet<tab_chiPlanPmRx> tab_chiPlanPmRx { get; set; }
        public virtual DbSet<tab_comfirm_dtl> tab_comfirm_dtl { get; set; }
        public virtual DbSet<tab_comfirm_infor> tab_comfirm_infor { get; set; }
        public virtual DbSet<tab_company_condition_ms> tab_company_condition_ms { get; set; }
        public virtual DbSet<tab_curr_ms> tab_curr_ms { get; set; }
        public virtual DbSet<tab_custDelivery> tab_custDelivery { get; set; }
        public virtual DbSet<tab_custLink> tab_custLink { get; set; }
        public virtual DbSet<tab_customer_ms> tab_customer_ms { get; set; }
        public virtual DbSet<tab_custPm_Rx> tab_custPm_Rx { get; set; }
        public virtual DbSet<tab_date_mnth_ms> tab_date_mnth_ms { get; set; }
        public virtual DbSet<tab_del_issue_tr> tab_del_issue_tr { get; set; }
        public virtual DbSet<tab_del_issueamt_tr> tab_del_issueamt_tr { get; set; }
        public virtual DbSet<tab_deliveryPlan> tab_deliveryPlan { get; set; }
        public virtual DbSet<tab_deliveryStage> tab_deliveryStage { get; set; }
        public virtual DbSet<tab_depart_ms> tab_depart_ms { get; set; }
        public virtual DbSet<tab_desc_detail_ms> tab_desc_detail_ms { get; set; }
        public virtual DbSet<tab_desc_ms> tab_desc_ms { get; set; }
        public virtual DbSet<tab_employee> tab_employee { get; set; }
        public virtual DbSet<tab_equipGro_Rx> tab_equipGro_Rx { get; set; }
        public virtual DbSet<tab_equipGroup> tab_equipGroup { get; set; }
        public virtual DbSet<tab_equipment> tab_equipment { get; set; }
        public virtual DbSet<tab_equipRecord> tab_equipRecord { get; set; }
        public virtual DbSet<tab_fac_condition_ms> tab_fac_condition_ms { get; set; }
        public virtual DbSet<tab_fac_stock_ms> tab_fac_stock_ms { get; set; }
        public virtual DbSet<tab_fac_stockamt_ms> tab_fac_stockamt_ms { get; set; }
        public virtual DbSet<tab_facOutside> tab_facOutside { get; set; }
        public virtual DbSet<tab_infor_ms> tab_infor_ms { get; set; }
        public virtual DbSet<tab_inspectmode_dtl> tab_inspectmode_dtl { get; set; }
        public virtual DbSet<tab_inspectmode_tr> tab_inspectmode_tr { get; set; }
        public virtual DbSet<tab_io_stock_comp_tr> tab_io_stock_comp_tr { get; set; }
        public virtual DbSet<tab_labanswer_ms> tab_labanswer_ms { get; set; }
        public virtual DbSet<tab_labinfor_dtl> tab_labinfor_dtl { get; set; }
        public virtual DbSet<tab_laboratory_infor> tab_laboratory_infor { get; set; }
        public virtual DbSet<tab_laSpecimenResult> tab_laSpecimenResult { get; set; }
        public virtual DbSet<tab_laStandard> tab_laStandard { get; set; }
        public virtual DbSet<tab_lot_ms> tab_lot_ms { get; set; }
        public virtual DbSet<tab_oPrcExamine> tab_oPrcExamine { get; set; }
        public virtual DbSet<tab_order_prcs_ms> tab_order_prcs_ms { get; set; }
        public virtual DbSet<tab_order_StockInventory> tab_order_StockInventory { get; set; }
        public virtual DbSet<tab_orderprcEquip_Rx> tab_orderprcEquip_Rx { get; set; }
        public virtual DbSet<tab_pm_ms> tab_pm_ms { get; set; }
        public virtual DbSet<tab_pmAppoint> tab_pmAppoint { get; set; }
        public virtual DbSet<tab_pmAppoRecord> tab_pmAppoRecord { get; set; }
        public virtual DbSet<tab_pmOutside> tab_pmOutside { get; set; }
        public virtual DbSet<tab_pmRegOutside_Rx> tab_pmRegOutside_Rx { get; set; }
        public virtual DbSet<Tab_PmSourceStation> Tab_PmSourceStation { get; set; }
        public virtual DbSet<tab_proceedsDtl> tab_proceedsDtl { get; set; }
        public virtual DbSet<tab_proceedsPlan> tab_proceedsPlan { get; set; }
        public virtual DbSet<tab_prod_desc_ms> tab_prod_desc_ms { get; set; }
        public virtual DbSet<tab_prodLevel> tab_prodLevel { get; set; }
        public virtual DbSet<tab_produce_tr> tab_produce_tr { get; set; }
        public virtual DbSet<tab_produce_tr_dtl> tab_produce_tr_dtl { get; set; }
        public virtual DbSet<tab_producLicence> tab_producLicence { get; set; }
        public virtual DbSet<tab_productindicate> tab_productindicate { get; set; }
        public virtual DbSet<tab_productIndiPm> tab_productIndiPm { get; set; }
        public virtual DbSet<tab_productPlan> tab_productPlan { get; set; }
        public virtual DbSet<tab_productRoughPlan> tab_productRoughPlan { get; set; }
        public virtual DbSet<tab_ps_hs> tab_ps_hs { get; set; }
        public virtual DbSet<tab_ps_ms> tab_ps_ms { get; set; }
        public virtual DbSet<tab_purapplication_dt> tab_purapplication_dt { get; set; }
        public virtual DbSet<tab_purapplication_tr> tab_purapplication_tr { get; set; }
        public virtual DbSet<tab_purchaseorder_dt> tab_purchaseorder_dt { get; set; }
        public virtual DbSet<tab_purchaseorder_tr> tab_purchaseorder_tr { get; set; }
        public virtual DbSet<tab_rate_ms> tab_rate_ms { get; set; }
        public virtual DbSet<tab_RegisNum> tab_RegisNum { get; set; }
        public virtual DbSet<tab_required_result_ms> tab_required_result_ms { get; set; }
        public virtual DbSet<tab_roughPlanPm> tab_roughPlanPm { get; set; }
        public virtual DbSet<tab_roughPlanPrc> tab_roughPlanPrc { get; set; }
        public virtual DbSet<tab_roughtPmSource> tab_roughtPmSource { get; set; }
        public virtual DbSet<tab_salePm_Rx> tab_salePm_Rx { get; set; }
        public virtual DbSet<tab_salePm_RxKit> tab_salePm_RxKit { get; set; }
        public virtual DbSet<tab_sales_tr> tab_sales_tr { get; set; }
        public virtual DbSet<tab_saleSend> tab_saleSend { get; set; }
        public virtual DbSet<tab_saleSendPm_Rx> tab_saleSendPm_Rx { get; set; }
        public virtual DbSet<tab_saleSendPmNumInforma> tab_saleSendPmNumInforma { get; set; }
        public virtual DbSet<tab_salesReturn> tab_salesReturn { get; set; }
        public virtual DbSet<tab_salesReturnPm_Rx> tab_salesReturnPm_Rx { get; set; }
        public virtual DbSet<tab_salesReturnPmNumInforma> tab_salesReturnPmNumInforma { get; set; }
        public virtual DbSet<tab_ship_dt> tab_ship_dt { get; set; }
        public virtual DbSet<tab_ship_tr> tab_ship_tr { get; set; }
        public virtual DbSet<tab_sply_result_dt> tab_sply_result_dt { get; set; }
        public virtual DbSet<tab_sply_result_tr> tab_sply_result_tr { get; set; }
        public virtual DbSet<tab_standard_ms> tab_standard_ms { get; set; }
        public virtual DbSet<tab_starequire_answer> tab_starequire_answer { get; set; }
        public virtual DbSet<tab_starequire_ms> tab_starequire_ms { get; set; }
        public virtual DbSet<tab_starequire_para> tab_starequire_para { get; set; }
        public virtual DbSet<tab_stock_adj_dt> tab_stock_adj_dt { get; set; }
        public virtual DbSet<tab_stock_adj_tr> tab_stock_adj_tr { get; set; }
        public virtual DbSet<tab_stock_location_ms> tab_stock_location_ms { get; set; }
        public virtual DbSet<tab_stock_move_tr> tab_stock_move_tr { get; set; }
        public virtual DbSet<tab_stock_new_tr> tab_stock_new_tr { get; set; }
        public virtual DbSet<tab_stockDeliverAcc> tab_stockDeliverAcc { get; set; }
        public virtual DbSet<tab_stockDeliverPm> tab_stockDeliverPm { get; set; }
        public virtual DbSet<tab_stockReceivedNumInformaRecord> tab_stockReceivedNumInformaRecord { get; set; }
        public virtual DbSet<tab_stockReceivedPlan> tab_stockReceivedPlan { get; set; }
        public virtual DbSet<tab_stockReceivedPm> tab_stockReceivedPm { get; set; }
        public virtual DbSet<tab_stockReceivedPmRecord> tab_stockReceivedPmRecord { get; set; }
        public virtual DbSet<tab_stockReceivedRecord> tab_stockReceivedRecord { get; set; }
        public virtual DbSet<tab_stockReplenishPlan> tab_stockReplenishPlan { get; set; }
        public virtual DbSet<tab_stockReplenishPm> tab_stockReplenishPm { get; set; }
        public virtual DbSet<tab_supplier_ms> tab_supplier_ms { get; set; }
        public virtual DbSet<tab_uncheck_infor> tab_uncheck_infor { get; set; }
        public virtual DbSet<tab_uncomp_infor> tab_uncomp_infor { get; set; }
        public virtual DbSet<tab_unit_ms> tab_unit_ms { get; set; }
        public virtual DbSet<tab_unitPrice> tab_unitPrice { get; set; }
        public virtual DbSet<tab_worequipmentRecord> tab_worequipmentRecord { get; set; }
        public virtual DbSet<tab_worequipRecordLog> tab_worequipRecordLog { get; set; }
        public virtual DbSet<tab_worexpendRecord> tab_worexpendRecord { get; set; }
        public virtual DbSet<tab_workshopuse_dt> tab_workshopuse_dt { get; set; }
        public virtual DbSet<tab_workshopuse_tr> tab_workshopuse_tr { get; set; }
        public virtual DbSet<tab_worMergeLot> tab_worMergeLot { get; set; }
        public virtual DbSet<tab_worsheet> tab_worsheet { get; set; }
        public virtual DbSet<W_LOGIN> W_LOGIN { get; set; }
        public virtual DbSet<zTest> zTest { get; set; }
        public virtual DbSet<S_SERVERIMAGE> S_SERVERIMAGE { get; set; }
        public virtual DbSet<S_SYSTEMSET> S_SYSTEMSET { get; set; }
        public virtual DbSet<T_DepEmployeeRS> T_DepEmployeeRS { get; set; }
        public virtual DbSet<T_DutyEmpRS> T_DutyEmpRS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<B_ClBtnConfig>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<B_ClBtnConfig>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<B_ClBtnConfig>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<B_ClBtnMethodProperty>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<B_ClBtnMethodProperty>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<B_ClBtnMethodProperty>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.fac_code)
                .IsUnicode(false);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.fac_date)
                .HasPrecision(8, 0);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.day_no)
                .HasPrecision(7, 0);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.wk_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.short_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<base_calendar>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<base_category>()
                .Property(e => e.category_code)
                .IsUnicode(false);

            modelBuilder.Entity<base_category>()
                .Property(e => e.CLS_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<base_category>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<base_category>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<base_category>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<base_category_dtl>()
                .Property(e => e.CLS_DETAIL_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<base_category_dtl>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<base_category_dtl>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<base_category_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<base_category_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.AccreditId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.AccreditFromUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.FromUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.AccreditToUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.ToUserName)
                .IsFixedLength();

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.AccreditStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_AccreditUser>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.CateId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.CateCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_AritcleCate>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.CateId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.TitleColor)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.SubTitle)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.BriefContent)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.CompileName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.TagWord)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Keyword)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.SourceName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.SourceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.WorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Cms_Article>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.FMClassId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.FormType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_FormClass>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Group>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.LogId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.LogContent)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.LogUserID)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.LogUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.IPAddressName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.Host)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.ModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.Brower)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Logs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.MainFormId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.FmClassId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.FormType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_MainForms>()
                .Property(e => e.UrlMethod)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.NavigateUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.PowerCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Module>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ModuleButton>()
                .Property(e => e.ActionUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.OperatorId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.OperContent)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Operator>()
                .Property(e => e.OperDisplay)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.OperatorInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.WorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.OperContent)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.OperContentText)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.OperStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.ChangeOperator)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.DoResult)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.DoResultMsg)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.DoCommandName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.ReturnOperatorInsId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_OperatorInstance>()
                .Property(e => e.FromOperatorInsId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.LoginAccount)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.OrgAccount)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.LinkTel)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.AuditMsg)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.WxHostUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.WxCorpId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Organize>()
                .Property(e => e.OrganizeShortName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Purview>()
                .Property(e => e.PrvID)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Purview>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_Purview>()
                .Property(e => e.OperationId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.MessageId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.WorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.MsgType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.Users1)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.Users2)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.Users3)
                .IsUnicode(false);

            modelBuilder.Entity<HF_ServiceMessage>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.SubWFId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.SubWorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.SubWorkFlowCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.SubStartTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.SubStartTaskCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_SubWorkFlow>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_User_Token>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_User_Token>()
                .Property(e => e.UserToKen)
                .IsUnicode(false);

            modelBuilder.Entity<HF_UserGroup>()
                .Property(e => e.UGID)
                .IsUnicode(false);

            modelBuilder.Entity<HF_UserGroup>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_UserGroup>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.FlowCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.WFClassId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.SignOutUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.MgrUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlow>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowAbnormal>()
                .Property(e => e.AbnormalId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowAbnormal>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowAbnormal>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowAbnormal>()
                .Property(e => e.AbnormalMsg)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.WFClassId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.MgrUrl)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowClass>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.FlowInstanceCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.Priority)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.StartUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.StartUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.SuspendStaus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.MainWorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.MainWorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.MainWorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.MainWorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.NowTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.UserBusinessNO)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.UserBusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.StatusRemark)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowInstance>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.RemindEventId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.OutTimeToUsers)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkFlowRemindEvent>()
                .Property(e => e.ReceiveToUsers)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.WorkLineId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.StartTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.EndTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.LineType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.LineM)
                .HasPrecision(18, 1);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.BreakX)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.BreakY)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkLine>()
                .Property(e => e.CommandName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkOutTime>()
                .Property(e => e.OutTimeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkOutTime>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkOutTime>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkOutTime>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkOutTime>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.TaskTypeId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.TaskTypeAndOr)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.TaskCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTask>()
                .Property(e => e.OperRule)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.AdapterId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.AdapterType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.Context)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.RunType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.DllName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.MethodName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskAdapter>()
                .Property(e => e.DataBaseCfgName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.CommandId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.CommandName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskCommands>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.TaskFormId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.MainFormId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskForm>()
                .Property(e => e.FormType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.WorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.PreviousTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.TaskInstanceCaption)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.OperatedDes)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.OperatorInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.SuccessMsg)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.SourceWorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstance>()
                .Property(e => e.pOperatedDes)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.NextOperId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.UserLoginId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.WorkFlowInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskInstanceNextOper>()
                .Property(e => e.WorkTaskInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.Powerid)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.PowerName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskPower>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.WorkTaskVarId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.WorkFlowId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.WorkTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.VarName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.VarType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.DataBaseCfgId)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.TableField)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.InitValue)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.AccessType)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.DataBaseSever)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.OrderNum)
                .IsUnicode(false);

            modelBuilder.Entity<HF_WorkTaskVar>()
                .Property(e => e.ValueSortField)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.facade_img)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.sid_img)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.examine_notes)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<mem_card_type>()
                .Property(e => e.card_type_name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card_type>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<mem_card_type>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.enter_name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.main_busi)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<mem_enter>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<mem_person>()
                .Property(e => e.real_name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.nick_name)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<mem_person>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<orderprcEquip>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<orderprcEquip>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<orderprcEquip>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelEquipment_RX>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelEquipment_RX>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelEquipment_RX>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelMS_RX>()
                .Property(e => e.seiban)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelMS_RX>()
                .Property(e => e.batch_size_buns)
                .HasPrecision(18, 3);

            modelBuilder.Entity<QS_ModelMS_RX>()
                .Property(e => e.batch_size_bunbo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<QS_ModelMS_RX>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelMS_RX>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelPrcExam_RX>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelPrcExam_RX>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelPrcExam_RX>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.prod_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.safe_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.yield_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.per_seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.wk_time)
                .HasPrecision(6, 2);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.unit_prod_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.eff_period)
                .HasPrecision(5, 0);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelProcess_RX>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<QS_ModelTemplate>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<QS_ModelTemplate>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<R_ButtonReport>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<R_ButtonReport>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_ButtonReport>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_ButtonReport>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_ButtonReport>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.tempname)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.temppath)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<R_TEMPLATE>()
                .Property(e => e.printername)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.companycode)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.companyname)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.legal)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.linceseno)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.productionlicenses)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.regnumber)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.taxnumber)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.cid)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.introduce)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.EBusinessID)
                .IsUnicode(false);

            modelBuilder.Entity<S_COMPANY>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.fieldType)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.operatorsybol)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.paraProviderSQL)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.conectSyb)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.condictionName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.condictionDes)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.filedName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.parmA)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.parmB)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboViewName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboDisplayPath)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboValuePath)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboPrimaryID)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboOrderFiled)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboFiltField)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboFiltValue)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.comboSQL)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterCondiction>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.filedName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.fieldType)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.colTitle)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.colWidth)
                .HasPrecision(18, 0);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterFiledSet>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_FilterOrder>()
                .Property(e => e.filterField)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterOrder>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_FilterOrderSet>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterOrderSet>()
                .Property(e => e.FiledName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterOrderSet>()
                .Property(e => e.AscOrDesc)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterOrderSet>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterOrderSet>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.listTitle)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.filterName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.bllName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.ctlName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.grdName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.sourceTable)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.KeyIDName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.SQLstr)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.nextProcessDllname)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSet>()
                .Property(e => e.nextProcessCtlname)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSQLblock>()
                .Property(e => e.ViewName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSQLblock>()
                .Property(e => e.blockName)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSQLblock>()
                .Property(e => e.connectSyb)
                .IsUnicode(false);

            modelBuilder.Entity<S_FilterSQLblock>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_IDrecords>()
                .Property(e => e.TabName)
                .IsUnicode(false);

            modelBuilder.Entity<S_IDrecords>()
                .Property(e => e.strKey)
                .IsUnicode(false);

            modelBuilder.Entity<S_IDrecords>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_IDrecords>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<s_lan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<s_lan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_Menu>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_MenuItem>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_Part>()
                .Property(e => e.rolename)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.roleDes)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_Part>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<S_Part>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.PmsCode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.PmsName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.PmsDes)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_Permissions>()
                .Property(e => e.keyflag)
                .IsFixedLength();

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.sort)
                .IsFixedLength();

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_Permissions_Category>()
                .Property(e => e.keyfalg)
                .IsFixedLength();

            modelBuilder.Entity<S_Permissions_Category>()
                .HasMany(e => e.S_Permissions)
                .WithRequired(e => e.S_Permissions_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.phonecode)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.phoneexplanation)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.validflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_PHONE>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_RoleAndPermissions>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissions>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissions>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissions>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissions>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_RoleAndPermissionsB>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissionsB>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissionsB>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissionsB>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndPermissionsB>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_RoleAndUser>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndUser>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndUser>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndUser>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_RoleAndUser>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_ROLEUSER>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.TheSubsystemID)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.IMSystemServerIP)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.FTPSystemServerIP)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.ImageStorageEndIP)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.TheUserName)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSSET>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_USER>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.DicType)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.Caption)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.DicParameter)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.DicValue)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Dictionary>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<T_BusinessInterface>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<T_BusinessInterface>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_BusinessInterface>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_center_produce>()
                .Property(e => e.prod_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_produce>()
                .Property(e => e.produced_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_produce>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_center_produce>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_center_purchase>()
                .Property(e => e.pur_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_purchase>()
                .Property(e => e.purchased_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_purchase>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_center_purchase>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_center_receive>()
                .Property(e => e.rec_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_receive>()
                .Property(e => e.receiveed_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_receive>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_center_receive>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_center_StockInventory>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_center_StockInventory>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_center_unqualify>()
                .Property(e => e.unquelify_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_unqualify>()
                .Property(e => e.out_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_center_unqualify>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_center_unqualify>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_interface_btnconfig>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_interface_btnconfig>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_interface_btnconfig>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_pmcategory_dic>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_pmcategory_dic>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_pmsource_dic>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_pmsource_dic>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_pmsource_rs>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_pmsource_rs>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_pmusing_dic>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_pmusing_dic>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_pmusing_rs>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_pmusing_rs>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_productPlanNoticeRs>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_productPlanNoticeRs>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_ResetPmRecord>()
                .Property(e => e.reset_num)
                .HasPrecision(12, 3);

            modelBuilder.Entity<T_ResetPmRecord>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<T_ResetPmRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_ResetPmRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_stock_move_dtl>()
                .Property(e => e.basemove_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_stock_move_dtl>()
                .Property(e => e.move_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<t_stock_move_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_stock_move_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_stock_move_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_stock_move_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<t_versioncenter>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_versioncenter>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.tax_rate)
                .HasPrecision(3, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.vou_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.vou_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.vou_balance_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.print_vou_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acp_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.purorder_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.std_acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.std_acpout_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.std_acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.tax_rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.nat_rm_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.rm_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.rm_atm)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acp_tr_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acpout_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.purorder_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.acpout_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.realout_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.std_acpout_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.std_noout_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.std_acpreal_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.std_acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.tax_rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.nat_rm_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.rm_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.rm_atm)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acpout_tr_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_acpoutdt_stockms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acpoutdt_stockms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_acpoutdt_stockms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_auto_num_ms>()
                .Property(e => e.total_count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tab_auto_num_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_auto_num_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_bomMode>()
                .Property(e => e.batch_size_buns)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_bomMode>()
                .Property(e => e.batch_size_bunbo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_bomMode>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_bomMode>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_BomMultiMode>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_BomMultiMode>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_BomTemplate>()
                .Property(e => e.seiban)
                .IsFixedLength();

            modelBuilder.Entity<tab_BomTemplate>()
                .Property(e => e.batch_size_buns)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_BomTemplate>()
                .Property(e => e.batch_size_bunbo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_BomTemplate>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_BomTemplate>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_childPlan>()
                .Property(e => e.percentComple)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_childPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_childPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_chiPlanPmRx>()
                .Property(e => e.saleNum)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_chiPlanPmRx>()
                .Property(e => e.quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_chiPlanPmRx>()
                .Property(e => e.thisTimequantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_chiPlanPmRx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_chiPlanPmRx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.sum_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.uncomp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.uncomp_realqty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_comfirm_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_comfirm_infor>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_comfirm_infor>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.condition_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.company_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.native_curr_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.frc_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.total_mst_set_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.multi_fac_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.date_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.inspecton_location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.rjt_wh_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.non_alloc_location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.trade_wh_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.os_wh_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.non_sales_wh_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.legal)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.linceseno)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.productionlicenses)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.regnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.taxnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.cid)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.introduce)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.EBusinessID)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.AppKey)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_company_condition_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.lang_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.curr_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.unit_price_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.up_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.amt_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_curr_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.delivery_person)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.delivery_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.delivery_tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.mail_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.fax_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.is_default)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custDelivery>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_name)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_fax)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_position)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.link_dep)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custLink>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.customer_cd)
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.transfer_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.trade_lang_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.tax_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.do_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.inv_dest_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.charged_sply_cls)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.tax_charged_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.sales_frc_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.sales_slip_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.sales_trade_up_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.is_invoice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.inv_closing_date)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_method)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_term1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_term2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.border_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.bill_sight)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_sch_mnth)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_sch_day)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.inv_person_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.inv_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.trade_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.rcp_section)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.credit_limit_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.credit_limit_amt_perm)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.bank_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.cllt_bank_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.fee_chrg_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.fee_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.fixed_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_customer_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_custPm_Rx>()
                .Property(e => e.pm_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_custPm_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_custPm_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_date_mnth_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_date_mnth_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.now_stock_qty)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.in_out_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.up)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.rm_up)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.rm_amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.rate)
                .HasPrecision(14, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.nat_amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.up_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.amt_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.nat_amt_dgt)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.obj_in_out_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_del_issue_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.in_out_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.up)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.rate)
                .HasPrecision(14, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.tax_rate)
                .HasPrecision(3, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.nat_up)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.nat_amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_del_issueamt_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_deliveryPlan>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_deliveryPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_deliveryPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.sale_order_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.thisTimePmBaseNum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.pmNum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_deliveryStage>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.depart_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.depart_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.depart_desc_kana)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.mail_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.address3)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.fax_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.manage_person)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.con_person)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.depart_path_id)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.depart_path_name)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<tab_depart_ms>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_detail_ms>()
                .Property(e => e.CLS_DETAIL_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_detail_ms>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_detail_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_detail_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_detail_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_desc_ms>()
                .Property(e => e.category_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_ms>()
                .Property(e => e.CLS_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_desc_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.entry_time)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.family_address)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.link_address)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<tab_employee>()
                .Property(e => e.LeaderName)
                .IsUnicode(false);

            modelBuilder.Entity<tab_equipGro_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_equipGro_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_equipGroup>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_equipGroup>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_equipment>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_equipment>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_equipRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_equipRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.fac_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.fac_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.lead_person)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.fac_desc_kana)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.lang_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.wk_time)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.rate_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.po_create_period)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.mrp_period)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.po_confirm_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.safe_stock_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.mrp_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.alc_period)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.sales_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.po_slc_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.ship_input_inv_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.acp_input_inv_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.gov_no_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.sales_check_flow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.po_per_check_flow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.po_check_flow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_condition_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.CurBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.mnth_start_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.cur_in_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.cur_out_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.cur_adjst_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.cur_loss_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.trn_in_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.trn_out_Qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_stock_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.curBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.curBalance_Up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.curBalance_Amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.cur_in_Amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.cur_out_Amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_fac_stockamt_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.facOutside_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.facOutside_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.lead_person)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.wk_time)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.addres)
                .IsFixedLength();

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_facOutside>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_infor_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_infor_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_inspectmode_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_inspectmode_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_inspectmode_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_inspectmode_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.line_no)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.sou_line_no)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.io_notes_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.io_result_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_io_stock_comp_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_labanswer_ms>()
                .Property(e => e.ins_rtj_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_labanswer_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_labanswer_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_labinfor_dtl>()
                .Property(e => e.sampling_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_labinfor_dtl>()
                .Property(e => e.ins_rtj_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_labinfor_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_labinfor_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_curqty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_samplingqty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.std_acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.tobeins_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_ok_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_rtj_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_loss_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.ins_in_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.reinspection_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.qualified_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.unqualified_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tab_laboratory_infor>()
                .Property(e => e.bad_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tab_laSpecimenResult>()
                .Property(e => e.parameter_stvlue)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laSpecimenResult>()
                .Property(e => e.parameter_mine)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laSpecimenResult>()
                .Property(e => e.parameter_max)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_laSpecimenResult>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_laSpecimenResult>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_laStandard>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_laStandard>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_lot_ms>()
                .Property(e => e.iner_lot_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_lot_ms>()
                .Property(e => e.sourceTable)
                .IsUnicode(false);

            modelBuilder.Entity<tab_lot_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_lot_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_oPrcExamine>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_oPrcExamine>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_oPrcExamine>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.prod_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.safe_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.yield_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.per_seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.wk_time)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.unit_prod_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.eff_period)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_order_prcs_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_order_StockInventory>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_order_StockInventory>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_orderprcEquip_Rx>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_orderprcEquip_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_orderprcEquip_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.item_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.item_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.drw_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.seiban)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.tax_rate)
                .HasPrecision(14, 8);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.frp_period)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.lot_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.min_lot_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.safe_stock_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.trsh_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.std_unit_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.start_seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.end_seq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.ship_location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.net_weight)
                .HasPrecision(9, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.gross_weight)
                .HasPrecision(9, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.m3)
                .HasPrecision(14, 7);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.low_level)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.sum_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.plan_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.maker_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.qry_mtrl)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.size1)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.size2)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.size3)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.gravity)
                .HasPrecision(8, 5);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.proc_sum_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.hcdflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.spflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.pmrkey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.pmrver)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.sephin)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.ryuhin)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.sakusei)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.minsafestock)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.expend_lot)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_pm_ms>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmAppoint>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmAppoint>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_pmAppoRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmAppoRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.pmOutside_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.pmOutside_name)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.drw_no)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.seiban)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.min_lot_qty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmOutside>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_pmRegOutside_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_pmRegOutside_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<Tab_PmSourceStation>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<Tab_PmSourceStation>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsDtl>()
                .Property(e => e.amount)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_proceedsDtl>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsDtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsDtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_proceedsPlan>()
                .Property(e => e.sale_order_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsPlan>()
                .Property(e => e.gross)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_proceedsPlan>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_proceedsPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.prod_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.OrganizeName)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prod_desc_ms>()
                .Property(e => e.FatherId)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prodLevel>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prodLevel>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_prodLevel>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.tax_rate)
                .HasPrecision(3, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.vou_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.vou_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.vou_balance_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.print_vou_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_produce_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.std_acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.std_acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.tax_rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.nat_rm_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.rm_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.rm_atm)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_produce_tr_dtl>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_producLicence>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_producLicence>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_productindicate>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_productindicate>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_productIndiPm>()
                .Property(e => e.workHours)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_productIndiPm>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_productIndiPm>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_productPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_productPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.productNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.NumProuduct)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.NumProcurement)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.NumWh)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.workHours)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.alreadyPickingNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.notyetPickingNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.supplementNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_productRoughPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_ps_hs>()
                .Property(e => e.seiban)
                .IsFixedLength();

            modelBuilder.Entity<tab_ps_hs>()
                .Property(e => e.batch_size_buns)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_ps_hs>()
                .Property(e => e.batch_size_bunbo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_ps_hs>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_ps_hs>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_ps_ms>()
                .Property(e => e.seiban)
                .IsFixedLength();

            modelBuilder.Entity<tab_ps_ms>()
                .Property(e => e.batch_size_buns)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_ps_ms>()
                .Property(e => e.batch_size_bunbo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_ps_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_ps_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.item_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.item_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.purapplica_qty)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.CurBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.purorder_qty)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.purinstock_qty)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.purapplica_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.purapplica_up)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purapplication_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_purapplication_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purapplication_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.purapplica_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.tax_rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.acpin_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.std_acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.std_acp_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purchaseorder_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.purorder_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.rate)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.pay_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.nat_acp_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.nat_tax_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_purchaseorder_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.rate_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.realRate)
                .HasPrecision(14, 8);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.rate)
                .HasPrecision(14, 8);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.cnv_method)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_rate_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_RegisNum>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_RegisNum>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_required_result_ms>()
                .Property(e => e.requiredres_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_required_result_ms>()
                .Property(e => e.requiredres_remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_required_result_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_required_result_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_roughPlanPm>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_roughPlanPm>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_roughPlanPrc>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_roughPlanPrc>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.PmNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.NumProuduct)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.NumProcurement)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.NumWh)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_roughtPmSource>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.PmBasePrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.PmPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.taxrate)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.originalCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.originalCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.homeCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.homeCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.alreadyQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salePm_Rx>()
                .Property(e => e.ensuer_amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.PmBasePrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.PmPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.taxrate)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.originalCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.originalCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.homeCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.homeCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.alreadyQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salePm_RxKit>()
                .Property(e => e.ensuer_amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.sale_order_code)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.taxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.con_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.nat_curr_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.transfer_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.safe_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.ship_number)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.free_charge)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.free_reason)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.remark1)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.remark2)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_sales_tr>()
                .Property(e => e.ensuer_amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.con_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.nat_curr_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_saleSend>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.PmBasePrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.PmPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.taxrate)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.originalCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.originalCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.homeCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.homeCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_saleSendPm_Rx>()
                .Property(e => e.ensuer_amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_saleSendPmNumInforma>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_saleSendPmNumInforma>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_saleSendPmNumInforma>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.con_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.nat_curr_amt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salesReturn>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.PmBasePrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.PmPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.taxrate)
                .HasPrecision(6, 2);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.originalCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.originalCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.homeCurrMoney)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.homeCurrTaxrate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_salesReturnPm_Rx>()
                .Property(e => e.ensuer_amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tab_salesReturnPmNumInforma>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salesReturnPmNumInforma>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_salesReturnPmNumInforma>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_ship_dt>()
                .Property(e => e.ship_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_ship_dt>()
                .Property(e => e.CurBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_ship_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_ship_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_ship_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_ship_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.sply_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.sply_amt)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.sply_up)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.CurBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sply_result_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_sply_result_tr>()
                .Property(e => e.print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tab_sply_result_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_sply_result_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_standard_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_standard_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_starequire_answer>()
                .Property(e => e.reqanswer_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tab_starequire_answer>()
                .Property(e => e.reqanswer_remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_starequire_answer>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_starequire_answer>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_starequire_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_starequire_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.parameter_mine)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.parameter_max)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.parameter_stvlue)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.parameter_accuracy)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_starequire_para>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stock_adj_dt>()
                .Property(e => e.adj_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_stock_adj_dt>()
                .Property(e => e.CurBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_stock_adj_dt>()
                .Property(e => e.adj_amt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_stock_adj_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_adj_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stock_adj_tr>()
                .Property(e => e.line_no)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_stock_adj_tr>()
                .Property(e => e.adj_totalamt)
                .HasPrecision(20, 3);

            modelBuilder.Entity<tab_stock_adj_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_adj_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stock_location_ms>()
                .Property(e => e.location_name)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_location_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_location_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stock_move_tr>()
                .Property(e => e.line_no)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_stock_move_tr>()
                .Property(e => e.move_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_stock_move_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_move_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stock_new_tr>()
                .Property(e => e.stnew_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_stock_new_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stock_new_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockDeliverAcc>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockDeliverAcc>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockDeliverPm>()
                .Property(e => e.notyetReceivedNum)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockDeliverPm>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockDeliverPm>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReceivedNumInformaRecord>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedNumInformaRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedNumInformaRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReceivedPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.requiredNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.alreadyReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.notyetReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.replenishNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.ThisTimeReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.ThisTimeReceived)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedPm>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.requiredNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.alreadyReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.notyetReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.replenishNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.ThisTimeReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.practicalReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.ThisTimepracticalReceivedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedPmRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReceivedRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReceivedRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReplenishPlan>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReplenishPlan>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReplenishPm>()
                .Property(e => e.notyetReceivedNum)
                .IsFixedLength();

            modelBuilder.Entity<tab_stockReplenishPm>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_stockReplenishPm>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.suppler_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.tax_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.transfer_lt)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.trade_lang_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.do_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.inv_dest_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.charged_sply_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.tax_charged_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_dest_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_up_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_frc_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_tax_calc_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_tax_frc_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_tax_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.po_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_trade_up_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.trade_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.vendor_pack_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.vendor_transfer_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_closing_date)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_method)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_term1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_term2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.border_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.bill_sight)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_sch_mnth)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_sch_day)
                .HasPrecision(2, 0);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_person_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_list_issue_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_section)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.credit_limit_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.credit_limit_amt_perm)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.pay_dest_bank_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.fee_chrg_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.fee_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.fixed_amt)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_supplier_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.std_acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.uncheck_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.ins_ok_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.ins_rtj_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_uncheck_infor>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.sum_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.acp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.uncomp_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.uncomp_realqty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_uncomp_infor>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_unit_ms>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_unit_ms>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_unitPrice>()
                .Property(e => e.cnv_rate_bunsi)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_unitPrice>()
                .Property(e => e.cnv_rate_bunbo)
                .HasPrecision(6, 0);

            modelBuilder.Entity<tab_unitPrice>()
                .Property(e => e.unitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tab_unitPrice>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_unitPrice>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_worequipmentRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worequipmentRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_worequipRecordLog>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worequipRecordLog>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.outputNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.consumptionNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.thisTimeconsumptionNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.torsionNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.thisTimetorsionNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worexpendRecord>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_workshopuse_dt>()
                .Property(e => e.consume_qty)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_workshopuse_dt>()
                .Property(e => e.CurBalance)
                .HasPrecision(12, 3);

            modelBuilder.Entity<tab_workshopuse_dt>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_workshopuse_dt>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_workshopuse_tr>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_workshopuse_tr>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_worMergeLot>()
                .Property(e => e.outputNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worMergeLot>()
                .Property(e => e.qualifiedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worMergeLot>()
                .Property(e => e.scrapNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worMergeLot>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worMergeLot>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.outputNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.qualifiedNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.scrapNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.productTaskNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<tab_worsheet>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<W_LOGIN>()
                .Property(e => e.usercode)
                .IsUnicode(false);

            modelBuilder.Entity<W_LOGIN>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<W_LOGIN>()
                .Property(e => e.passwords)
                .IsUnicode(false);

            modelBuilder.Entity<W_LOGIN>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<W_LOGIN>()
                .Property(e => e.factoryflg)
                .IsUnicode(false);

            modelBuilder.Entity<zTest>()
                .Property(e => e.test02)
                .IsUnicode(false);

            modelBuilder.Entity<zTest>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<zTest>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.clientaddress)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.serveraddress)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SERVERIMAGE>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.synchronousflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.staffsetflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.productpriceflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.staffprosetflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.regdateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.updateuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.deleteuser)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.printoneflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.uniquenum)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.shippingprices)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.sricestatus)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.subline)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.processnumber)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.automaticbarcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.aotoprintbarcode)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.outsideback)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.productioninterface)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.tryhandling)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.matchrawmaterial)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.canchange)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.returnorderflg)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.cansave)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.beforeorderin)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.drug)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.disinfection)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.inseizure)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.outseizure)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.eligiblesingle)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.processinspection)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.wrap)
                .IsUnicode(false);

            modelBuilder.Entity<S_SYSTEMSET>()
                .Property(e => e.billprice)
                .IsUnicode(false);

            modelBuilder.Entity<T_DepEmployeeRS>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_DepEmployeeRS>()
                .Property(e => e.lastchanged)
                .IsFixedLength();

            modelBuilder.Entity<T_DutyEmpRS>()
                .Property(e => e.netpointcode)
                .IsUnicode(false);

            modelBuilder.Entity<T_DutyEmpRS>()
                .Property(e => e.lastchanged)
                .IsFixedLength();
        }
    }
}
