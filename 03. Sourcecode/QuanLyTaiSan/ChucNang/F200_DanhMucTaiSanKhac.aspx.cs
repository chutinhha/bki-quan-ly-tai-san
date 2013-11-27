﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPData;
using IP.Core.IPUserService;
using WebDS.CDBNames;
using WebDS;
using IP.Core.IPCommon;
using WebUS;
using IP.Core.WinFormControls;
using System.Threading;
using IP.Core.IPBusinessService;
using IP.Core.IPException;

public partial class Default2 : System.Web.UI.Page
{
    #region Member
    US_DM_TAI_SAN_KHAC m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC();
    DS_DM_TAI_SAN_KHAC m_ds_tai_san_khac = new DS_DM_TAI_SAN_KHAC();
    DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
    #endregion

    #region Data Structures
    #endregion

    #region Private Methods
    private void load_data_2_grid()
    {
        US_V_DM_TAI_SAN_KHAC m_us_v_tai_san_khac = new US_V_DM_TAI_SAN_KHAC();
        DS_V_DM_TAI_SAN_KHAC m_ds_v_tai_san_khac = new DS_V_DM_TAI_SAN_KHAC();
        m_ds_v_tai_san_khac.V_DM_TAI_SAN_KHAC.Clear();
        m_us_v_tai_san_khac.FillDatasetLoadDataToGridTaiSanKhac_by_tu_khoa(m_txt_tim_kiem.Text.Trim()
            , CONST_QLDB.ID_TAT_CA
            , CONST_QLDB.ID_TAT_CA
            , CONST_QLDB.ID_TAT_CA
            , CONST_QLDB.ID_TAT_CA
            , CONST_QLDB.ID_TAT_CA.ToString()
            , Person.get_user_name()
            , m_ds_v_tai_san_khac);
        m_grv_tai_san_khac.DataSource = m_ds_v_tai_san_khac.V_DM_TAI_SAN_KHAC;
        string v_str_thong_tin = " (Có " + m_ds_v_tai_san_khac.V_DM_TAI_SAN_KHAC.Rows.Count + " bản ghi)";
        m_lbl_title.Text = "DANH SÁCH TÀI SẢN KHÁC";
        m_lbl_title.Text += v_str_thong_tin;
        m_grv_tai_san_khac.DataBind();
    }
    private bool check_validate_data_is_ok()
    {
        if (!CValidateTextBox.IsValid(m_txt_ma_tai_san, DataType.StringType, allowNull.NO))
        {
            m_lbl_mess.Text = "Chưa nhập đúng mã tài sản";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_ten_tai_san, DataType.StringType, allowNull.NO))
        {
            m_lbl_mess.Text = "Chưa nhập đúng tên tài sản";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_nguyen_gia_nguon_ns, DataType.NumberType, allowNull.NO))
        {
            m_lbl_mess.Text = "Chưa nhập đúng nguyên giá nguồn ngân sách";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_nguyen_gia_nguon_khac, DataType.NumberType, allowNull.NO))
        {
            m_lbl_mess.Text = "Chưa nhập đúng nguyên giá nguồn khác";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_ngay_su_dung, DataType.NumberType, allowNull.YES))
        {
            m_lbl_mess.Text = "Chưa nhập đúng ngày sử dụng";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_nam_sx, DataType.NumberType, allowNull.YES))
        {
            m_lbl_mess.Text = "Chưa nhập đúng năm sản xuất";
            return false;
        }
        if (!CValidateTextBox.IsValid(m_txt_gia_tri_con_lai, DataType.NumberType, allowNull.NO))
        {
            m_lbl_mess.Text = "Chưa nhập đúng giá trị còn lại";
            return false;
        }
        if ((m_txt_ngay_su_dung.Text.Trim().Length > 0) & (m_txt_nam_sx.Text.Trim().Length > 0))
        {
            if (CIPConvert.ToDecimal(m_txt_ngay_su_dung.Text) < CIPConvert.ToDecimal(m_txt_nam_sx.Text))
            {
                m_lbl_mess.Text = "Năm sử dụng phải lớn hơn hoặc bằng năm sản xuất!";
                m_txt_nam_sx.Focus();
                return false;
            }
        }
        if ((m_txt_nguyen_gia_nguon_ns.Text.Trim().Length > 0) & (m_txt_nguyen_gia_nguon_khac.Text.Trim().Length > 0) & (m_txt_gia_tri_con_lai.Text.Trim().Length > 0))
        {
            if (CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_ns.Text) + CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_khac.Text) < CIPConvert.ToDecimal(m_txt_gia_tri_con_lai.Text))
            {
                m_lbl_mess.Text = "Nguyên giá (nguồn ngân sách + nguồn khác) phải lớn hơn giá trị còn lại!";
                m_txt_gia_tri_con_lai.Focus();
                return false;
            }
        }
        if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
        {
            m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC(CIPConvert.ToDecimal(hdf_id.Value));
            if (m_us_tai_san_khac.strMA_TAI_SAN != m_txt_ma_tai_san.Text)
            {
                if (!m_us_tai_san_khac.check_ma_valid(m_txt_ma_tai_san.Text))
                {
                    m_lbl_mess.Text = "Không thể cập nhật. Lỗi: Mã tài sản này đã tồn tại";
                    m_txt_ma_tai_san.Focus();
                    return false;
                }
            }
        }
        if (m_e_form_mode == DataEntryFormMode.InsertDataState)
        {
            if (!m_us_tai_san_khac.check_ma_valid(m_txt_ma_tai_san.Text.Trim()))
            {
                m_lbl_mess.Text = "Mã tài sản này đã tồn tại";
                m_txt_ma_tai_san.Focus();
                return false;
            };
        }
        return true;
    }
    private void form_2_us_object()
    {
        m_us_tai_san_khac.dcID_NGUOI_LAP = CIPConvert.ToDecimal(Person.get_user_id());
        m_us_tai_san_khac.dcID_DON_VI_CHU_QUAN = CIPConvert.ToDecimal(m_cbo_don_vi_chu_quan.SelectedValue);
        m_us_tai_san_khac.dcID_DON_VI_SU_DUNG = CIPConvert.ToDecimal(m_cbo_don_vi_su_dung.SelectedValue);
        m_us_tai_san_khac.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_tai_san.SelectedValue);
        if ((m_txt_nguyen_gia_nguon_ns.Text.Trim().Length > 0) & (m_txt_nguyen_gia_nguon_khac.Text.Trim().Length > 0) & (m_txt_gia_tri_con_lai.Text.Trim().Length > 0))
        {
            if (CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_ns.Text) + CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_khac.Text) < CIPConvert.ToDecimal(500000000))
            {
                m_us_tai_san_khac.dcID_LOAI_TAI_SAN = CIPConvert.ToDecimal("9");
            }
            else
                m_us_tai_san_khac.dcID_LOAI_TAI_SAN = CIPConvert.ToDecimal("8");
        }
        m_us_tai_san_khac.datNGAY_CAP_NHAT_CUOI = DateTime.Now.Date;
        m_us_tai_san_khac.strMA_TAI_SAN = m_txt_ma_tai_san.Text.Trim();
        m_us_tai_san_khac.strTEN_TAI_SAN = m_txt_ten_tai_san.Text.Trim();
        m_us_tai_san_khac.strKY_HIEU = m_txt_ky_hieu.Text.Trim();
        m_us_tai_san_khac.strNUOC_SAN_XUAT = m_txt_nuoc_sx.Text.Trim();
        m_us_tai_san_khac.dcNAM_SAN_XUAT = CIPConvert.ToDecimal(m_txt_nam_sx.Text.Trim());
        m_us_tai_san_khac.dcNAM_SU_DUNG = CIPConvert.ToDecimal(m_txt_ngay_su_dung.Text.Trim());
        m_us_tai_san_khac.dcNGUON_NS = CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_ns.Text.Trim());
        m_us_tai_san_khac.dcNGUON_KHAC = CIPConvert.ToDecimal(m_txt_nguyen_gia_nguon_khac.Text.Trim());
        m_us_tai_san_khac.dcGIA_TRI_CON_LAI = CIPConvert.ToDecimal(m_txt_gia_tri_con_lai.Text.Trim());
        set_gia_tri_hien_trang(m_us_tai_san_khac);
        if (hdf_id.Value.Equals(String.Empty))
        {
            m_us_tai_san_khac.dcID_TINH_TRANG = ID_TINH_TRANG.TOT;
        }
    }
    private void us_object_2_form(US_DM_TAI_SAN_KHAC ip_us_m_dm_tai_san_khac)
    {
        hdf_id.Value = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcID);
        m_txt_ten_tai_san.Text = ip_us_m_dm_tai_san_khac.strTEN_TAI_SAN;

        US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI(ip_us_m_dm_tai_san_khac.dcID_DON_VI_CHU_QUAN);
        m_cbo_bo_tinh.SelectedValue = CIPConvert.ToStr(v_us_dm_don_vi.dcID_DON_VI_CAP_TREN);
        WinFormControls.load_data_to_cbo_don_vi_chu_quan(
                   m_cbo_bo_tinh.SelectedValue
                   , WinFormControls.eTAT_CA.NO
                   , m_cbo_don_vi_chu_quan);

        m_cbo_don_vi_chu_quan.SelectedValue = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcID_DON_VI_CHU_QUAN);
        WinFormControls.load_data_to_cbo_don_vi_su_dung(
            m_cbo_don_vi_chu_quan.SelectedValue
            , m_cbo_bo_tinh.SelectedValue
            , WinFormControls.eTAT_CA.NO
            , m_cbo_don_vi_su_dung);
        m_cbo_don_vi_su_dung.SelectedValue = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcID_DON_VI_SU_DUNG);
        m_cbo_trang_thai_tai_san.SelectedValue = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcID_TRANG_THAI);
        m_txt_ma_tai_san.Text = ip_us_m_dm_tai_san_khac.strMA_TAI_SAN;
        m_txt_ky_hieu.Text = ip_us_m_dm_tai_san_khac.strKY_HIEU;
        m_txt_nuoc_sx.Text = ip_us_m_dm_tai_san_khac.strNUOC_SAN_XUAT;
        m_txt_nam_sx.Text = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcNAM_SAN_XUAT);
        m_txt_ngay_su_dung.Text = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcNAM_SU_DUNG);
        m_txt_nguyen_gia_nguon_ns.Text = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcNGUON_NS, "#,##0.00");
        m_txt_nguyen_gia_nguon_khac.Text = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcNGUON_KHAC, "#,##0.00");
        m_txt_gia_tri_con_lai.Text = CIPConvert.ToStr(ip_us_m_dm_tai_san_khac.dcGIA_TRI_CON_LAI, "#,##0.00");
        load_gia_tri_hien_trang(ip_us_m_dm_tai_san_khac);
        m_txt_ten_tai_san.Focus();
    }
    private void set_gia_tri_hien_trang(US_DM_TAI_SAN_KHAC ip_us_m_dm_tai_san_khac)
    {
        string v_str_hien_trang = m_rbl_muc_dich_su_dung.SelectedValue;
        ip_us_m_dm_tai_san_khac.dcQLNN = 0;
        ip_us_m_dm_tai_san_khac.dcKINH_DOANH = 0;
        ip_us_m_dm_tai_san_khac.dcKHONG_KINH_DOANH = 0;
        ip_us_m_dm_tai_san_khac.dcHD_KHAC = 0;

        switch (v_str_hien_trang)
        {
            case "QLNN":
                ip_us_m_dm_tai_san_khac.dcQLNN = 1;
                break;
            case "KD":
                ip_us_m_dm_tai_san_khac.dcKINH_DOANH = 1;
                break;
            case "KKD":
                ip_us_m_dm_tai_san_khac.dcKHONG_KINH_DOANH = 1;
                break;
            case "MDK":
                ip_us_m_dm_tai_san_khac.dcHD_KHAC = 1;
                break;
        }
    }
    private void load_gia_tri_hien_trang(US_DM_TAI_SAN_KHAC ip_us_m_dm_tai_san_khac)
    {
        if (ip_us_m_dm_tai_san_khac.dcQLNN == 1)
        {
            m_rbl_muc_dich_su_dung.SelectedValue = "QLNN";
            return;
        }
        if (ip_us_m_dm_tai_san_khac.dcKINH_DOANH == 1)
        {
            m_rbl_muc_dich_su_dung.SelectedValue = "KD";
            return;
        }
        if (ip_us_m_dm_tai_san_khac.dcKHONG_KINH_DOANH == 1)
        {
            m_rbl_muc_dich_su_dung.SelectedValue = "KKD";
            return;
        }
        if (ip_us_m_dm_tai_san_khac.dcHD_KHAC == 1)
        {
            m_rbl_muc_dich_su_dung.SelectedValue = "MDK";
            return;
        }
    }
    private void load_data_2_us_update(int ip_i_stt_row)
    {
        decimal dc_id_tai_san_khac = CIPConvert.ToDecimal(m_grv_tai_san_khac.DataKeys[ip_i_stt_row].Value);
        hdf_id.Value = CIPConvert.ToStr(dc_id_tai_san_khac);
        m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC(dc_id_tai_san_khac);
    }
    private void reset_control()
    {
        m_lbl_mess.Text = "";
        m_txt_ten_tai_san.Text = "";
        m_txt_ma_tai_san.Text = "";
        m_txt_ky_hieu.Text = "";
        m_txt_nuoc_sx.Text = "";
        m_txt_nam_sx.Text = "";
        m_txt_ngay_su_dung.Text = "";
        m_txt_nguyen_gia_nguon_ns.Text = "";
        m_txt_nguyen_gia_nguon_khac.Text = "";
        m_txt_gia_tri_con_lai.Text = "";
        m_e_form_mode = DataEntryFormMode.InsertDataState;
        m_txt_ten_tai_san.Focus();
    }
    private void set_form_mode()
    {
        switch (m_e_form_mode)
        {
            case DataEntryFormMode.InsertDataState:
                m_cmd_tao_moi.Visible = true;
                m_cmd_cap_nhat.Visible = false;
                m_lbl_caption.Text = "NHẬP MỚI TÀI SẢN KHÁC";
                break;
            case DataEntryFormMode.SelectDataState:
                break;
            case DataEntryFormMode.UpdateDataState:
                m_cmd_tao_moi.Visible = false;
                m_cmd_cap_nhat.Visible = true;
                m_lbl_caption.Text = "CẬP NHẬT THÔNG TIN TÀI SẢN KHÁC";
                break;
            case DataEntryFormMode.ViewDataState:
                break;
            default:
                break;
        }
    }
    private void update_data()
    {
        if (hdf_id.Value.Trim().Equals(""))
        {
            m_lbl_mess.Visible = true;
            m_lbl_mess.Text = "Bạn chưa chọn tài sản để cập nhật!";
            return;
        }
        if (!check_validate_data_is_ok()) return;
        m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC(CIPConvert.ToDecimal(hdf_id.Value));

        form_2_us_object();

        m_us_tai_san_khac.Update();
        load_data_2_grid();
        hdf_id.Value = "";
        reset_control();
        set_form_mode();
        m_lbl_mess.Text = "Cập nhật thành công!";
    }
    private void insert_data()
    {
        if (!check_validate_data_is_ok()) return;
        form_2_us_object();
        m_us_tai_san_khac.Insert();
        load_data_2_grid();
        reset_control();
        hdf_id.Value = m_us_tai_san_khac.dcID.ToString();
        m_lbl_mess.Text = "Tạo mới thành công!";
        display_panel_tang_giam();
    }
    private void load_data_to_ly_do()
    {
        WinFormControls.load_data_to_cbo_ly_do_tang_giam(
            WinFormControls.eLOAI_TU_DIEN.LY_DO_TANG_GIAM_TS
            , WinFormControls.eLOAI_TANG_GIAM_TAI_SAN.TANG_TAI_SAN
            , m_cbo_ly_do_thay_doi);
    }
    private void hidden_panel_tang_giam()
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_pnl_confirm_tg.Visible = false;
    }
    private void display_panel_tang_giam()
    {
        if (hdf_id.Value == "") return;
        load_data_to_ly_do();
        m_pnl_confirm_tg.Visible = true;
        m_mtv_1.SetActiveView(m_view_confirm);
    }
    private void them_moi_tang_giam()
    {
        US_GD_TANG_GIAM_TAI_SAN v_us_gd_tang_giam_tai_san = new US_GD_TANG_GIAM_TAI_SAN();
        m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC(CIPConvert.ToDecimal(hdf_id.Value));
        v_us_gd_tang_giam_tai_san.datNGAY_DUYET = m_dat_ngay_duyet.SelectedDate;
        v_us_gd_tang_giam_tai_san.datNGAY_TANG_GIAM_TAI_SAN = m_dat_ngay_tang_giam.SelectedDate;
        v_us_gd_tang_giam_tai_san.dcID_LY_DO_TANG_GIAM = CIPConvert.ToDecimal(m_cbo_ly_do_thay_doi.SelectedValue);
        v_us_gd_tang_giam_tai_san.strTANG_GIA_TRI_TAI_SAN_YN = m_rbl_loai.SelectedValue;

        v_us_gd_tang_giam_tai_san.dcID_TAI_SAN = m_us_tai_san_khac.dcID;
        v_us_gd_tang_giam_tai_san.dcID_LOAI_TAI_SAN = m_us_tai_san_khac.dcID_LOAI_TAI_SAN;
        v_us_gd_tang_giam_tai_san.strMA_PHIEU = m_txt_ma_phieu.Text;
        v_us_gd_tang_giam_tai_san.dcDIEN_TICH = m_us_tai_san_khac.dcKINH_DOANH + m_us_tai_san_khac.dcKHONG_KINH_DOANH + m_us_tai_san_khac.dcHD_KHAC;
        v_us_gd_tang_giam_tai_san.dcGIA_TRI_NGUYEN_GIA_TANG_GIAM = m_us_tai_san_khac.dcNGUON_NS + m_us_tai_san_khac.dcNGUON_KHAC;

        v_us_gd_tang_giam_tai_san.dcID_NGUOI_LAP = Person.get_user_id();
        v_us_gd_tang_giam_tai_san.dcID_NGUOI_DUYET = Person.get_user_id();

        v_us_gd_tang_giam_tai_san.Insert();

        // Phần cập nhật thông tin cho DM
        reset_control();
        m_lbl_mess.Text = "Đã cập nhật thông tin tăng giảm thành công";
        m_txt_tim_kiem.Text = v_us_gd_tang_giam_tai_san.strMA_PHIEU;
    }
    private void clear_panel_data()
    {
        m_txt_ma_phieu.Text = "";
    }
    private void lua_chon_loai_tang_giam()
    {
        decimal v_dc_loai_tang_giam = CIPConvert.ToDecimal(m_cbo_ly_do_thay_doi.SelectedValue);
        if (v_dc_loai_tang_giam == ID_LY_DO_TANG_GIAM_TAI_SAN.THANH_LY
            || v_dc_loai_tang_giam == ID_LY_DO_TANG_GIAM_TAI_SAN.DIEU_CHUYEN)
        {
            m_rbl_loai.SelectedValue = "N";
        }
        else
        {
            m_rbl_loai.SelectedValue = "Y";
        }
    }
    private void clear_message()
    {
        m_lbl_mess.Text = "";
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!this.IsPostBack)
            {
                m_grv_tai_san_khac.Columns[0].Visible = Person.Allow2DeleteData();
                set_form_mode();
                WinFormControls.load_data_to_cbo_bo_tinh(
                    WinFormControls.eTAT_CA.NO
                    , m_cbo_bo_tinh);
                WinFormControls.load_data_to_cbo_don_vi_chu_quan(
                    m_cbo_bo_tinh.SelectedValue
                    , WinFormControls.eTAT_CA.NO
                    , m_cbo_don_vi_chu_quan);
                WinFormControls.load_data_to_cbo_don_vi_su_dung(
                    m_cbo_don_vi_chu_quan.SelectedValue
                    , m_cbo_bo_tinh.SelectedValue
                    , WinFormControls.eTAT_CA.NO
                    , m_cbo_don_vi_su_dung);
                WinFormControls.load_data_to_cbo_tu_dien(
                    WinFormControls.eLOAI_TU_DIEN.TRANG_THAI_TAI_SAN_KHAC
                    , WinFormControls.eTAT_CA.NO
                    , m_cbo_trang_thai_tai_san);
                m_cbo_trang_thai_tai_san.SelectedValue = TRANG_THAI_TAI_SAN_KHAC.DANG_SU_DUNG;
                load_data_2_grid();
                if (Request.QueryString[CONST_QLDB.MA_THAM_SO_URL.ID_TAI_SAN_KHAC] != null)
                {
                    decimal v_dc_id_tai_san_khac = CIPConvert.ToDecimal(Request.QueryString[CONST_QLDB.MA_THAM_SO_URL.ID_TAI_SAN_KHAC]);
                    m_us_tai_san_khac = new US_DM_TAI_SAN_KHAC(v_dc_id_tai_san_khac);
                    us_object_2_form(m_us_tai_san_khac);
                }
                hidden_panel_tang_giam();
            }
        }
        catch (Exception v_e)
        {
            this.Response.Write(v_e.ToString());
        }
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
    }
    protected void m_cmd_cap_nhat_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            Thread.Sleep(2000);
            update_data();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(v_e);
        }
    }
    protected void m_grv_tai_san_khac_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            clear_message();
            load_data_2_us_update(e.RowIndex);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            set_form_mode();
            us_object_2_form(m_us_tai_san_khac);
            m_cbo_bo_tinh.Focus();

        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(v_e);
        }
    }
    protected void m_cmd_tao_moi_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            Thread.Sleep(2000);
            insert_data();
            m_cbo_bo_tinh.Focus();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(v_e);
        }
    }
    protected void m_cbo_bo_tinh_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            m_lbl_mess.Text = "";
            WinFormControls.load_data_to_cbo_don_vi_chu_quan(
                m_cbo_bo_tinh.SelectedValue
                , WinFormControls.eTAT_CA.NO, m_cbo_don_vi_chu_quan);
            WinFormControls.load_data_to_cbo_don_vi_su_dung(
                m_cbo_don_vi_chu_quan.SelectedValue
                , m_cbo_bo_tinh.SelectedValue
                , WinFormControls.eTAT_CA.NO
                , m_cbo_don_vi_su_dung);

        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(v_e);
        }

    }
    protected void m_cbo_don_vi_chu_quan_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            m_lbl_mess.Text = "";
            WinFormControls.load_data_to_cbo_don_vi_su_dung(
                m_cbo_don_vi_chu_quan.SelectedValue
                , m_cbo_bo_tinh.SelectedValue
                , WinFormControls.eTAT_CA.NO
                , m_cbo_don_vi_su_dung);

        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(v_e);
        }

    }
    protected void m_grv_tai_san_khac_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            clear_message();
            decimal dc_id_tai_san_khac = CIPConvert.ToDecimal(m_grv_tai_san_khac.DataKeys[e.RowIndex].Value);
            m_us_tai_san_khac.DeleteByID(dc_id_tai_san_khac);
            load_data_2_grid();
            m_lbl_mess.Text = "Xóa thành công!";
            m_cbo_bo_tinh.Focus();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(v_e);
        }
    }
    protected void m_cmd_search_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            m_lbl_title.Text = "DANH SÁCH TÀI SẢN KHÁC";
            Thread.Sleep(2000);
            load_data_2_grid();
            m_txt_tim_kiem.Focus();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(v_e);
        }

    }
    protected void m_grv_tai_san_khac_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            clear_message();
            m_grv_tai_san_khac.PageIndex = e.NewPageIndex;
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(v_e);
        }

    }
    protected void m_cmd_xoa_trang_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            Thread.Sleep(2000);
            reset_control();
            set_form_mode();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(v_e);
        }

    }
    protected void m_cmd_xuat_excel_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            Thread.Sleep(2000);
            // vì có phân trang, nên nếu muốn xuất all dữ liệu trên lưới (tất cả các trang) thì thê 2 dòng sau:
            m_grv_tai_san_khac.AllowPaging = false;
            load_data_2_grid();  // đây là hàm load lại dữ liệu lên lưới
            // còn nếu chỉ muốn xuất dữ liệu ở Page hiện tại thì không cần 2 dòng trên
            WinformReport.export_gridview_2_excel(
                        m_grv_tai_san_khac
                        , "DS tai san khac.xls"
                        , 0
                        , 1); // 0 và 1 là số thứ tự 2 cột: Sửa, Xóa
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_an_Click(object sender, EventArgs e)
    {
        try
        {
            clear_message();
            Thread.Sleep(2000);
            m_grv_tai_san_khac.Columns[0].Visible = false;
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_tao_tang_giam_Click(object sender, EventArgs e)
    {
        try
        {
            them_moi_tang_giam();
            hidden_panel_tang_giam();
            m_cbo_bo_tinh.Focus();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_huy_bo_Click(object sender, EventArgs e)
    {
        try
        {
            clear_panel_data();
            hidden_panel_tang_giam();
            reset_control();
            load_data_2_grid();
            m_cbo_bo_tinh.Focus();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_confirm_Click(object sender, EventArgs e)
    {
        try
        {
            m_mtv_1.SetActiveView(m_view_them_moi_tg);
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cbo_ly_do_thay_doi_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lua_chon_loai_tang_giam();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_txt_tim_kiem_TextChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cbo_don_vi_su_dung_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            clear_message();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }

    }
    protected void m_cbo_trang_thai_tai_san_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            clear_message();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }

    }
    #endregion
}