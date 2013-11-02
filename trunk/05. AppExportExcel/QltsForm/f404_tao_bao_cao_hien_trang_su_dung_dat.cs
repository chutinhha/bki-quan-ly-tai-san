///************************************************
/// Generated by: TuDm
/// Date: 19/10/2013 04:37:47
/// Goal: Create Form for RPT_TONG_HOP_HIEN_TRANG
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

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace QltsForm
{



    public class f404_tao_bao_cao_hien_trang_su_dung_dat : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg_htsd_nha_dat;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label m_lbl_ten_bao_cao;
        private Label m_lbl_don_vi_chu_quan;
        private Label m_lbl_don_vi_bo_tinh;
        private Panel panel2;
        private Panel panel3;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_browser;
        private Label label7;
        private TextBox m_txt_file_path;
        private OpenFileDialog m_openDiaglog;
        private Label m_lbl_thong_bao;
        private C1FlexGrid m_fg_nha_dat_excel;
        private Label label3;
        private Label m_lbl_ma_don_vi;
        private System.ComponentModel.IContainer components;

        public f404_tao_bao_cao_hien_trang_su_dung_dat()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f404_tao_bao_cao_hien_trang_su_dung_dat));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg_htsd_nha_dat = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_ten_bao_cao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_don_vi_chu_quan = new System.Windows.Forms.Label();
            this.m_lbl_don_vi_bo_tinh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_browser = new SIS.Controls.Button.SiSButton();
            this.label7 = new System.Windows.Forms.Label();
            this.m_txt_file_path = new System.Windows.Forms.TextBox();
            this.m_lbl_thong_bao = new System.Windows.Forms.Label();
            this.m_lbl_ma_don_vi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_fg_nha_dat_excel = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_openDiaglog = new System.Windows.Forms.OpenFileDialog();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_htsd_nha_dat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_nha_dat_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 446);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(800, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_xuat_excel.TabIndex = 21;
            this.m_cmd_xuat_excel.Text = "Xuất excel";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(708, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg_htsd_nha_dat
            // 
            this.m_fg_htsd_nha_dat.ColumnInfo = resources.GetString("m_fg_htsd_nha_dat.ColumnInfo");
            this.m_fg_htsd_nha_dat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg_htsd_nha_dat.Location = new System.Drawing.Point(0, 0);
            this.m_fg_htsd_nha_dat.Name = "m_fg_htsd_nha_dat";
            this.m_fg_htsd_nha_dat.Size = new System.Drawing.Size(800, 220);
            this.m_fg_htsd_nha_dat.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_htsd_nha_dat.Styles"));
            this.m_fg_htsd_nha_dat.TabIndex = 20;
            // 
            // m_lbl
            // 
            this.m_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl.Location = new System.Drawing.Point(0, 0);
            this.m_lbl.Name = "m_lbl";
            this.m_lbl.Size = new System.Drawing.Size(800, 50);
            this.m_lbl.TabIndex = 21;
            this.m_lbl.Text = "BÁO CÁO HIỆN TRẠNG SỬ DỤNG NHÀ ĐẤT";
            this.m_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_ten_bao_cao);
            this.panel1.Controls.Add(this.m_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 23;
            // 
            // m_lbl_ten_bao_cao
            // 
            this.m_lbl_ten_bao_cao.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_ten_bao_cao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_bao_cao.Location = new System.Drawing.Point(0, 50);
            this.m_lbl_ten_bao_cao.Name = "m_lbl_ten_bao_cao";
            this.m_lbl_ten_bao_cao.Size = new System.Drawing.Size(800, 23);
            this.m_lbl_ten_bao_cao.TabIndex = 22;
            this.m_lbl_ten_bao_cao.Text = "1. Tổng hợp chung";
            this.m_lbl_ten_bao_cao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đơn vị bộ tỉnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đơn vị chủ quản:";
            // 
            // m_lbl_don_vi_chu_quan
            // 
            this.m_lbl_don_vi_chu_quan.AutoSize = true;
            this.m_lbl_don_vi_chu_quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_don_vi_chu_quan.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_don_vi_chu_quan.Location = new System.Drawing.Point(528, 28);
            this.m_lbl_don_vi_chu_quan.Name = "m_lbl_don_vi_chu_quan";
            this.m_lbl_don_vi_chu_quan.Size = new System.Drawing.Size(11, 13);
            this.m_lbl_don_vi_chu_quan.TabIndex = 24;
            this.m_lbl_don_vi_chu_quan.Text = " ";
            // 
            // m_lbl_don_vi_bo_tinh
            // 
            this.m_lbl_don_vi_bo_tinh.AutoSize = true;
            this.m_lbl_don_vi_bo_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_don_vi_bo_tinh.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_don_vi_bo_tinh.Location = new System.Drawing.Point(162, 28);
            this.m_lbl_don_vi_bo_tinh.Name = "m_lbl_don_vi_bo_tinh";
            this.m_lbl_don_vi_bo_tinh.Size = new System.Drawing.Size(11, 13);
            this.m_lbl_don_vi_bo_tinh.TabIndex = 24;
            this.m_lbl_don_vi_bo_tinh.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.m_cmd_browser);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.m_txt_file_path);
            this.panel2.Controls.Add(this.m_lbl_thong_bao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.m_lbl_don_vi_chu_quan);
            this.panel2.Controls.Add(this.m_lbl_ma_don_vi);
            this.panel2.Controls.Add(this.m_lbl_don_vi_bo_tinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 144);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã đơn vị:";
            // 
            // m_cmd_browser
            // 
            this.m_cmd_browser.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_browser.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_browser.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_browser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_browser.ImageIndex = 5;
            this.m_cmd_browser.ImageList = this.ImageList;
            this.m_cmd_browser.Location = new System.Drawing.Point(724, 59);
            this.m_cmd_browser.Name = "m_cmd_browser";
            this.m_cmd_browser.Size = new System.Drawing.Size(33, 28);
            this.m_cmd_browser.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "File excel";
            // 
            // m_txt_file_path
            // 
            this.m_txt_file_path.Location = new System.Drawing.Point(528, 64);
            this.m_txt_file_path.Name = "m_txt_file_path";
            this.m_txt_file_path.Size = new System.Drawing.Size(190, 20);
            this.m_txt_file_path.TabIndex = 27;
            // 
            // m_lbl_thong_bao
            // 
            this.m_lbl_thong_bao.AutoSize = true;
            this.m_lbl_thong_bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_thong_bao.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_thong_bao.Location = new System.Drawing.Point(136, 110);
            this.m_lbl_thong_bao.Name = "m_lbl_thong_bao";
            this.m_lbl_thong_bao.Size = new System.Drawing.Size(12, 16);
            this.m_lbl_thong_bao.TabIndex = 24;
            this.m_lbl_thong_bao.Text = " ";
            // 
            // m_lbl_ma_don_vi
            // 
            this.m_lbl_ma_don_vi.AutoSize = true;
            this.m_lbl_ma_don_vi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ma_don_vi.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_ma_don_vi.Location = new System.Drawing.Point(162, 67);
            this.m_lbl_ma_don_vi.Name = "m_lbl_ma_don_vi";
            this.m_lbl_ma_don_vi.Size = new System.Drawing.Size(11, 13);
            this.m_lbl_ma_don_vi.TabIndex = 24;
            this.m_lbl_ma_don_vi.Text = " ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_fg_nha_dat_excel);
            this.panel3.Controls.Add(this.m_fg_htsd_nha_dat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 220);
            this.panel3.TabIndex = 27;
            // 
            // m_fg_nha_dat_excel
            // 
            this.m_fg_nha_dat_excel.ColumnInfo = resources.GetString("m_fg_nha_dat_excel.ColumnInfo");
            this.m_fg_nha_dat_excel.Location = new System.Drawing.Point(7, 23);
            this.m_fg_nha_dat_excel.Name = "m_fg_nha_dat_excel";
            this.m_fg_nha_dat_excel.Size = new System.Drawing.Size(800, 221);
            this.m_fg_nha_dat_excel.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_nha_dat_excel.Styles"));
            this.m_fg_nha_dat_excel.TabIndex = 21;
            this.m_fg_nha_dat_excel.Visible = false;
            // 
            // m_openDiaglog
            // 
            this.m_openDiaglog.FileName = "openFileDialog1";
            // 
            // f404_tao_bao_cao_hien_trang_su_dung_dat
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f404_tao_bao_cao_hien_trang_su_dung_dat";
            this.Text = "f404_tao_bao_cao_hien_trang_su_dung_dat";
            this.Load += new System.EventHandler(this.f404_tao_bao_cao_hien_trang_su_dung_dat_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_htsd_nha_dat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_nha_dat_excel)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            DT_TRU_SO_LAM_VIEC = 4
,
            TONG_DIEN_TICH = 3
                ,
            DT_CHO_THUE = 7
                ,
            DT_KHAC = 10
                ,
            SO_LUONG = 2
                ,
            DT_CO_SO_HDSN = 5
                ,
            TEN_TAI_SAN = 1
                ,
            DT_BI_LAN_CHIEM = 9
                ,
            DT_LAM_NHA_O = 6
                , DT_BO_TRONG = 8

        }
        public enum e_col_Excel_number
        {
            STT=0,
            TAI_SAN = 1,
            SO_LUONG = 2,
            DIEN_TICH = 3,
            DT_TRU_SO_LAM_VIEC = 4,
            DT_CO_SO_HDSN = 5,
            DT_LAM_NHA_O = 6,
            DT_CHO_THUE = 7,
            DT_BO_TRONG = 8,
            DT_BI_LAN_CHIEM = 9,
            DT_KHAC = 10,
            TEN_DON_VI_BO_TINH = 11,
            TEN_DON_VI_CHU_QUAN = 12,
            MA_DON_VI_CHU_QUAN = 13
        }
        public enum eFormMode
        {
            TONG_HOP_CHUNG,
            CHI_TIET_THEO_LOAI_HINH,
            CHI_TIET_THEO_TUNG_DON_VI
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_RPT_TONG_HOP_HIEN_TRANG m_ds = new DS_RPT_TONG_HOP_HIEN_TRANG();
        US_RPT_TONG_HOP_HIEN_TRANG m_us = new US_RPT_TONG_HOP_HIEN_TRANG();
        eFormMode m_e_form_mode = eFormMode.TONG_HOP_CHUNG;
        #endregion

        #region Private Methods
        private void export_excel()
        {
            CExcelReport v_obj_exe_report = new CExcelReport();
            switch (m_e_form_mode)
            {
                case eFormMode.TONG_HOP_CHUNG:
                    v_obj_exe_report = new CExcelReport(TEN_BAO_CAO.BCTH_HTSD_THC, 17, 1);
                    break;
                case eFormMode.CHI_TIET_THEO_LOAI_HINH:
                    v_obj_exe_report = new CExcelReport(TEN_BAO_CAO.BCTH_HTSD_LH, 17, 1);
                    break;
                case eFormMode.CHI_TIET_THEO_TUNG_DON_VI:
                    v_obj_exe_report = new CExcelReport(TEN_BAO_CAO.BCTH_HTSD_DV, 17, 1);
                    break;

            }
            v_obj_exe_report.AddFindAndReplaceItem("<BO_TINH>", m_lbl_don_vi_bo_tinh.Text);
            v_obj_exe_report.AddFindAndReplaceItem("<DON_VI_BO_TINH>", m_lbl_don_vi_bo_tinh.Text);
            v_obj_exe_report.AddFindAndReplaceItem("<DON_VI_CHU_QUAN>", m_lbl_don_vi_chu_quan.Text);
            v_obj_exe_report.AddFindAndReplaceItem("<MA_DON_VI>", m_lbl_ma_don_vi.Text); 
            v_obj_exe_report.AddFindAndReplaceItem("<NGAY>", DateTime.Now.Day);
            v_obj_exe_report.AddFindAndReplaceItem("<THANG>", DateTime.Now.Month);
            v_obj_exe_report.AddFindAndReplaceItem("<NAM>", DateTime.Now.Year);
            v_obj_exe_report.FindAndReplace(false);
            v_obj_exe_report.Export2ExcelWithoutFixedRows(m_fg_htsd_nha_dat, 2, m_fg_htsd_nha_dat.Cols.Count - 1, true);
        }
        private void load_report_name()
        {
            switch (m_e_form_mode)
            {
                case eFormMode.TONG_HOP_CHUNG:
                    m_lbl_ten_bao_cao.Text = "Phần 1. Tổng hợp chung";
                    break;
                case eFormMode.CHI_TIET_THEO_LOAI_HINH:
                    m_lbl_ten_bao_cao.Text = "Phần 2: Chi tiết theo loại hình đơn vị";
                    break;
                case eFormMode.CHI_TIET_THEO_TUNG_DON_VI:
                    m_lbl_ten_bao_cao.Text = "Phần 3: Chi tiết theo từng đơn vị";
                    break;
            }
        }
        private void format_grid()
        {
            m_fg_nha_dat_excel.Visible = false;
            m_fg_htsd_nha_dat.Visible = true;
        }
        private void set_initial_form_load()
        {
            xoa_trang_control();
            load_report_name();
            format_grid();
        }
        private void open_excel_file_and_load_2_form()
        {
            m_openDiaglog.Filter = "File Excel|*.xls";
            m_openDiaglog.Title = "Hãy chọn file excel";
            m_openDiaglog.FileName = "Chọn file excel";
            DialogResult result = m_openDiaglog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.OK) // Test result.
            {
                m_txt_file_path.Text = m_openDiaglog.FileName;
            }

            load_data_from_file_excel(m_txt_file_path.Text);
        }
        public void set_form_mode(eFormMode ip_e_form_mode)
        {
            m_e_form_mode = ip_e_form_mode;
        }
        private void xoa_trang_control()
        {
            m_lbl_don_vi_bo_tinh.Text = "";
            m_lbl_don_vi_chu_quan.Text = "";
            m_txt_file_path.Text = "";
            m_lbl_thong_bao.Text = "";
            m_lbl_ma_don_vi.Text = "";
        }
        public void load_data_from_file_excel(string ip_str_file_name)
        {
            xoa_trang_control();
            //1. Dua du lieu tu file excel len grid excel
            m_lbl_thong_bao.Text = "Chương trình đang xử lý, vui lòng chờ đợi!";
            m_txt_file_path.Text = ip_str_file_name;
            load_excel_2_grid_excel();
            //2. Dua du lieu tu grid excel len form (grid + controls khac)
            load_grid_excel_2_form();

            m_lbl_thong_bao.Text = "Chương trình đã Tạo xong Báo Cáo!";
        }
        private void load_excel_2_grid_excel()
        {

            IP.Core.IPExcelReport.CExcelReport v_obj_excel_report
               = new IP.Core.IPExcelReport.CExcelReport(m_txt_file_path.Text);
            int v_int_excel_row_cout = v_obj_excel_report.GetCountRow();
            m_fg_htsd_nha_dat.Rows.Count = v_int_excel_row_cout;
            m_fg_nha_dat_excel.Rows.Count = v_int_excel_row_cout;

            for (int v_i_grid_col = 1; v_i_grid_col < m_fg_nha_dat_excel.Cols.Count; v_i_grid_col++)
            {
                v_obj_excel_report.Export2Grid(
                m_fg_nha_dat_excel
                , 5
                , v_i_grid_col
                , v_i_grid_col);
            }
            for (int v_i_cur_row = m_fg_nha_dat_excel.Rows.Count - 1; v_i_cur_row > m_fg_nha_dat_excel.Rows.Fixed; v_i_cur_row--)
            {
                if (m_fg_nha_dat_excel[v_i_cur_row, 1] == null)
                {
                    m_fg_nha_dat_excel.Rows.Remove(v_i_cur_row);
                }
                else
                    if (m_fg_nha_dat_excel[v_i_cur_row, 1].ToString().Trim().Length == 0)
                    {
                        m_fg_nha_dat_excel.Rows.Remove(v_i_cur_row);
                    }
            }


        }
        // load du lieu len control cua form
        private void load_grid_excel_2_form()
        {

            // load data to combobox
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_nha_dat_excel)) return;

            m_lbl_don_vi_bo_tinh.Text = CIPConvert.ToStr(m_fg_nha_dat_excel[1, (int)e_col_Excel_number.TEN_DON_VI_BO_TINH]);
            m_lbl_don_vi_chu_quan.Text = CIPConvert.ToStr(m_fg_nha_dat_excel[1, (int)e_col_Excel_number.TEN_DON_VI_CHU_QUAN]);

            if (m_fg_nha_dat_excel[1, (int)e_col_Excel_number.MA_DON_VI_CHU_QUAN]==null)
            {
                m_lbl_ma_don_vi.Text = "";
            }
            else
            {
                m_lbl_ma_don_vi.Text = CIPConvert.ToStr(m_fg_nha_dat_excel[1, (int)e_col_Excel_number.MA_DON_VI_CHU_QUAN]);
            }
            //load data 2 grid
            load_data_from_data_table_to_grid(get_data_table_from_excel_grid(), m_fg_htsd_nha_dat);
            //siSButton1_Click(siSButton1,EventArgs.Empty);

        }
        private DataTable get_data_table_from_excel_grid()
        {
            DataTable v_dtb = new DataTable("BangTam");
            v_dtb.Columns.Add("STT", typeof(object));
            v_dtb.Columns.Add("TÊN TÀI SẢN", typeof(object));
            v_dtb.Columns.Add("SỐ LƯỢNG", typeof(object));
            v_dtb.Columns.Add("DIỆN TÍCH", typeof(object));
            v_dtb.Columns.Add("TRỤ SỞ LÀM VIỆC", typeof(object));
            v_dtb.Columns.Add("CƠ SỞ HĐSN", typeof(object));
            v_dtb.Columns.Add("LÀM NHÀ Ở", typeof(object));
            v_dtb.Columns.Add("CHO THUÊ", typeof(object));
            v_dtb.Columns.Add("BỎ TRỐNG", typeof(object));
            v_dtb.Columns.Add("BỊ LẤN CHIẾM", typeof(object));
            v_dtb.Columns.Add("KHÁC", typeof(object));
            int v_stt = 1;
            for (int row = m_fg_nha_dat_excel.Rows.Fixed; row < m_fg_nha_dat_excel.Rows.Count; row++)
            {
                DataRow v_dtr = v_dtb.NewRow();
                v_dtr[0] = v_stt++;
                v_dtr[1] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.TAI_SAN);
                v_dtr[2] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.SO_LUONG);
                v_dtr[3] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DIEN_TICH);
                v_dtr[4] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_TRU_SO_LAM_VIEC);
                v_dtr[5] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_CO_SO_HDSN);
                v_dtr[6] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_LAM_NHA_O);
                v_dtr[7] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_CHO_THUE);
                v_dtr[8] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_BO_TRONG);
                v_dtr[9] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_BI_LAN_CHIEM);
                v_dtr[10] = m_fg_nha_dat_excel.GetData(row, (int)e_col_Excel_number.DT_KHAC);
                v_dtb.Rows.Add(v_dtr);
            }
            return v_dtb;
        }
        private void load_data_from_data_table_to_grid(DataTable i_dtb, C1FlexGrid i_fg)
        {
            i_fg.DataSource = i_dtb.DefaultView;
        }
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg_htsd_nha_dat);
            set_define_events();
            this.KeyPreview = true;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_TRU_SO_LAM_VIEC, e_col_Number.DT_TRU_SO_LAM_VIEC);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.TONG_DIEN_TICH, e_col_Number.TONG_DIEN_TICH);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_CHO_THUE, e_col_Number.DT_CHO_THUE);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_KHAC, e_col_Number.DT_KHAC);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.SO_LUONG, e_col_Number.SO_LUONG);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_CO_SO_HDSN, e_col_Number.DT_CO_SO_HDSN);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.TEN_TAI_SAN, e_col_Number.TEN_TAI_SAN);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_BI_LAN_CHIEM, e_col_Number.DT_BI_LAN_CHIEM);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_LAM_NHA_O, e_col_Number.DT_LAM_NHA_O);
            v_htb.Add(RPT_TONG_HOP_HIEN_TRANG.DT_BO_TRONG, e_col_Number.DT_BO_TRONG);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.RPT_TONG_HOP_HIEN_TRANG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_RPT_TONG_HOP_HIEN_TRANG();
            m_us.FillDataset(m_ds);
            m_fg_htsd_nha_dat.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg_htsd_nha_dat, m_obj_trans);
            m_fg_htsd_nha_dat.Redraw = true;
        }
        private void grid2us_object(US_RPT_TONG_HOP_HIEN_TRANG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg_htsd_nha_dat.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_RPT_TONG_HOP_HIEN_TRANG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg_htsd_nha_dat.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_rpt_tong_hop_hien_trang()
        {
            //	f404_tao_bao_cao_hien_trang_su_dung_dat_DE v_fDE = new  f404_tao_bao_cao_hien_trang_su_dung_dat_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_rpt_tong_hop_hien_trang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_htsd_nha_dat)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_htsd_nha_dat, m_fg_htsd_nha_dat.Row)) return;
            grid2us_object(m_us, m_fg_htsd_nha_dat.Row);
            //	f404_tao_bao_cao_hien_trang_su_dung_dat_DE v_fDE = new f404_tao_bao_cao_hien_trang_su_dung_dat_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_rpt_tong_hop_hien_trang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_htsd_nha_dat)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_htsd_nha_dat, m_fg_htsd_nha_dat.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_RPT_TONG_HOP_HIEN_TRANG v_us = new US_RPT_TONG_HOP_HIEN_TRANG();
            grid2us_object(v_us, m_fg_htsd_nha_dat.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg_htsd_nha_dat.Rows.Remove(m_fg_htsd_nha_dat.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_rpt_tong_hop_hien_trang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_htsd_nha_dat)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_htsd_nha_dat, m_fg_htsd_nha_dat.Row)) return;
            grid2us_object(m_us, m_fg_htsd_nha_dat.Row);
            //	f404_tao_bao_cao_hien_trang_su_dung_dat_DE v_fDE = new f404_tao_bao_cao_hien_trang_su_dung_dat_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cmd_browser.Click += new EventHandler(m_cmd_browser_Click); ;
        }
        #endregion

        #region Events
        private void f404_tao_bao_cao_hien_trang_su_dung_dat_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_excel();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        private void m_cmd_browser_Click(object sender, EventArgs e)
        {
            try
            {
                open_excel_file_and_load_2_form();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        #endregion

    }
}

