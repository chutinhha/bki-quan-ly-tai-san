///************************************************
/// Generated by: TuDm
/// Date: 12/09/2013 12:35:24
/// Goal: Create Form for RPT_TANG_GIAM_TAI_SAN
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using WebUS;
using WebDS;
using WebDS.CDBNames;
using IP.Core.IPExcelWebReport;
using C1.Win.C1FlexGrid;

namespace QltsForm
{



	public class F330_RPT_TANG_GIAM_TAI_SAN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
		private System.ComponentModel.IContainer components;

		public F330_RPT_TANG_GIAM_TAI_SAN()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(F330_RPT_TANG_GIAM_TAI_SAN));
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
			this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
			this.m_cmd_update = new SIS.Controls.Button.SiSButton();
			this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
			this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
			this.m_cmd_view = new SIS.Controls.Button.SiSButton();
			this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.m_pnl_out_place_dm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageList
			// 
			this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// m_pnl_out_place_dm
			// 
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
			this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_pnl_out_place_dm.DockPadding.All = 4;
			this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
			this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
			this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
			this.m_pnl_out_place_dm.TabIndex = 19;
			// 
			// m_cmd_delete
			// 
			this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_delete.ImageIndex = 4;
			this.m_cmd_delete.ImageList = this.ImageList;
			this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
			this.m_cmd_delete.Name = "m_cmd_delete";
			this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_delete.TabIndex = 14;
			this.m_cmd_delete.Text = "&Xoá";
			// 
			// m_cmd_update
			// 
			this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_update.ImageIndex = 3;
			this.m_cmd_update.ImageList = this.ImageList;
			this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
			this.m_cmd_update.Name = "m_cmd_update";
			this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_update.TabIndex = 13;
			this.m_cmd_update.Text = "&Sửa";
			// 
			// m_cmd_insert
			// 
			this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_insert.ImageIndex = 2;
			this.m_cmd_insert.ImageList = this.ImageList;
			this.m_cmd_insert.Location = new System.Drawing.Point(330, 4);
			this.m_cmd_insert.Name = "m_cmd_insert";
			this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_insert.TabIndex = 12;
			this.m_cmd_insert.Text = "&Thêm";
			// 
			// m_cmd_exit
			// 
			this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_exit.ImageIndex = 12;
			this.m_cmd_exit.ImageList = this.ImageList;
			this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
			this.m_cmd_exit.Name = "m_cmd_exit";
			this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_exit.TabIndex = 11;
			this.m_cmd_exit.Text = "Thoát (Esc)";
			// 
			// m_cmd_view
			// 
			this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_view.ImageIndex = 18;
			this.m_cmd_view.ImageList = this.ImageList;
			this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
			this.m_cmd_view.Name = "m_cmd_view";
			this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_view.TabIndex = 21;
			this.m_cmd_view.Text = "Xem";
			// 
			// m_fg
			// 
			this.m_fg.ColumnInfo = @"14,1,0,0,0,85,Columns:0{Width:13;}	 6{Caption:""SỐ TĂNG TRONG KỲ DIỆN TÍCH"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}2{Caption:""SỐ ĐẦU KỲ SỐ LƯỢNG"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}10{Caption:""SỐ GIẢM TRONG KỲ NGUYÊN GIÁ"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}12{Caption:""SỐ CUỐI KỲ DIỆN TÍCH"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}11{Caption:""SỐ CUỐI KỲ SỐ LƯỢNG"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}5{Caption:""SỐ TĂNG TRONG KỲ SỐ LƯỢNG"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}13{Caption:""SỐ CUỐI KỲ NGUYÊN GIÁ"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}8{Caption:""SỐ GIẢM TRONG KỲ SỐ LƯỢNG"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}9{Caption:""SỐ GIẢM TRONG KỲ DIỆN TÍCH"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}7{Caption:""SỐ TĂNG TRONG KỲ NGUYÊN GIÁ"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}1{Caption:""TÀI SẢN"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}3{Caption:""SỐ ĐÀU KỲ DIỆN TÍCH"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}4{Caption:""SỐ ĐẦU KỲ NGUYÊN GIÁ"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}	";
			this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fg.Location = new System.Drawing.Point(0, 0);
			this.m_fg.Name = "m_fg";
			this.m_fg.Size = new System.Drawing.Size(686, 373);
			this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Alternate{BackColor:Info;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.m_fg.TabIndex = 20;
			// 
			// F330_RPT_TANG_GIAM_TAI_SAN
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(686, 409);
			this.Controls.Add(this.m_fg);
			this.Controls.Add(this.m_pnl_out_place_dm);
			this.Name = "F330_RPT_TANG_GIAM_TAI_SAN";
			this.Text = "F330_RPT_TANG_GIAM_TAI_SAN";
			this.Load += new System.EventHandler(this.F330_RPT_TANG_GIAM_TAI_SAN_Load);
			this.m_pnl_out_place_dm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
        public void export_excel(TANG_GIAM_TAI_SAN ip_tang_giam_tai_san
           , ref IP.Core.QltsFormControls.CObjExcelAssetParameters op_obj_excel_parameters)
        {
            m_obj_trans = get_trans_object(m_fg);
            string v_str_ma_don_vi="";
            if (op_obj_excel_parameters.dcID_BO_TINH !=-1)
            {
                US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI(op_obj_excel_parameters.dcID_BO_TINH);
                v_str_ma_don_vi = v_us_dm_don_vi.strMA_DON_VI;
            }

            CExcelWebReport v_obj_exe_report = new CExcelWebReport("BC-330 BCTH-TGTS.xls", 16, 1);
            load_data_to_grid_tai_san(ip_tang_giam_tai_san
                , op_obj_excel_parameters.strUSER_NAME
                ,op_obj_excel_parameters.dcID_BO_TINH
                ,op_obj_excel_parameters.dcID_DON_VI_CHU_QUAN
                ,op_obj_excel_parameters.datTU_NGAY
                ,op_obj_excel_parameters.datDEN_NGAY);
            switch (ip_tang_giam_tai_san)
            {
                case TANG_GIAM_TAI_SAN.TONG_HOP_CHUNG:
                    v_obj_exe_report.AddFindAndReplaceItem("<LOAI_BAO_CAO>"
                        , "Phần 1: Tổng hợp chung" 
                        );
                    break;
                case TANG_GIAM_TAI_SAN.CHI_TIET_THEO_LOAI_HINH:
                   v_obj_exe_report.AddFindAndReplaceItem("<LOAI_BAO_CAO>"
                         , "Phần 2: Chi tiết theo loại hình đơn vị"
                         );
                    break;
                case TANG_GIAM_TAI_SAN.CHI_TIET_THEO_DON_VI:
                    v_obj_exe_report.AddFindAndReplaceItem("<LOAI_BAO_CAO>"
                        , "Phần 3: Chi tiết theo từng đơn vị"
                        );
                    break;
            }
            v_obj_exe_report.AddFindAndReplaceItem("<BO_TINH>", op_obj_excel_parameters.strTEN_BO_TINH);
            v_obj_exe_report.AddFindAndReplaceItem("<MA_DON_VI>", v_str_ma_don_vi);
            v_obj_exe_report.AddFindAndReplaceItem("<CHU_QUAN>", op_obj_excel_parameters.strTEN_DON_VI_CHU_QUAN);
            v_obj_exe_report.AddFindAndReplaceItem("<NGAY>", DateTime.Now.Day);
            v_obj_exe_report.AddFindAndReplaceItem("<THANG>", DateTime.Now.Month);
            v_obj_exe_report.AddFindAndReplaceItem("<NAM>", DateTime.Now.Year);
            v_obj_exe_report.FindAndReplace(false);
            v_obj_exe_report.Export2ExcelWithoutFixedRows(m_fg, 1, m_fg.Cols.Count - 1, true);
            op_obj_excel_parameters.strFILE_NAME_RESULT = v_obj_exe_report.GetStrOutputFileNameWithPath();

        }
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
        public enum TANG_GIAM_TAI_SAN
        {
            TONG_HOP_CHUNG
            ,CHI_TIET_THEO_LOAI_HINH
            ,CHI_TIET_THEO_DON_VI
        }
		private enum e_col_Number{
			SO_TANG_TRONG_KY_DIEN_TICH = 6
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_RPT_TANG_GIAM_TAI_SAN m_ds = new DS_RPT_TANG_GIAM_TAI_SAN();
		US_RPT_TANG_GIAM_TAI_SAN m_us = new US_RPT_TANG_GIAM_TAI_SAN();
		#endregion

		#region Private Methods
        private void load_data_to_grid_tai_san(
            TANG_GIAM_TAI_SAN ip_tang_giam_tai_san
            ,string ip_str_user_name
            ,decimal ip_dc_id_bo_tinh
            ,decimal ip_dc_id_don_vi_chu_quan
            ,DateTime ip_dat_tu_ngay
            ,DateTime ip_dat_den_ngay
            )
        {
            US_RPT_TANG_GIAM_TAI_SAN v_us_rpt_tang_giam_tai_san = new US_RPT_TANG_GIAM_TAI_SAN();
            DS_RPT_TANG_GIAM_TAI_SAN v_ds_rpt_tang_giam_tai_san = new DS_RPT_TANG_GIAM_TAI_SAN();
            switch (ip_tang_giam_tai_san)
            {
                case TANG_GIAM_TAI_SAN.TONG_HOP_CHUNG:
                    v_us_rpt_tang_giam_tai_san.FillDataSet_tong_hop_chung(
                        ip_str_user_name
                        ,ip_dc_id_bo_tinh
                        ,ip_dc_id_bo_tinh
                        ,ip_dat_tu_ngay
                        ,ip_dat_den_ngay
                        ,v_ds_rpt_tang_giam_tai_san
                        );
                    break;
                case TANG_GIAM_TAI_SAN.CHI_TIET_THEO_LOAI_HINH:
                    v_us_rpt_tang_giam_tai_san.FillDataSet_chi_tiet_theo_loai_hinh(
                        ip_str_user_name
                        , ip_dc_id_bo_tinh
                        , ip_dc_id_bo_tinh
                        , ip_dat_tu_ngay
                        , ip_dat_den_ngay
                        , v_ds_rpt_tang_giam_tai_san
                        );
                    break;
                case TANG_GIAM_TAI_SAN.CHI_TIET_THEO_DON_VI:
                    v_us_rpt_tang_giam_tai_san.FillDataSet_chi_tiet_theo_don_vi(
                        ip_str_user_name
                        , ip_dc_id_bo_tinh
                        , ip_dc_id_bo_tinh
                        , ip_dat_tu_ngay
                        , ip_dat_den_ngay
                        , v_ds_rpt_tang_giam_tai_san
                        );
                    break;
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_rpt_tang_giam_tai_san, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(RPT_TANG_GIAM_TAI_SAN.SO_TANG_TRONG_KY_DIEN_TICH, e_col_Number.SO_TANG_TRONG_KY_DIEN_TICH);
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.RPT_TANG_GIAM_TAI_SAN.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_RPT_TANG_GIAM_TAI_SAN();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_RPT_TANG_GIAM_TAI_SAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_RPT_TANG_GIAM_TAI_SAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_rpt_tang_giam_tai_san(){			
		//	F330_RPT_TANG_GIAM_TAI_SAN_DE v_fDE = new  F330_RPT_TANG_GIAM_TAI_SAN_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_rpt_tang_giam_tai_san(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	F330_RPT_TANG_GIAM_TAI_SAN_DE v_fDE = new F330_RPT_TANG_GIAM_TAI_SAN_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_rpt_tang_giam_tai_san(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_RPT_TANG_GIAM_TAI_SAN v_us = new US_RPT_TANG_GIAM_TAI_SAN();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_rpt_tang_giam_tai_san(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	F330_RPT_TANG_GIAM_TAI_SAN_DE v_fDE = new F330_RPT_TANG_GIAM_TAI_SAN_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void F330_RPT_TANG_GIAM_TAI_SAN_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_rpt_tang_giam_tai_san();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_rpt_tang_giam_tai_san();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_rpt_tang_giam_tai_san();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_rpt_tang_giam_tai_san();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}
