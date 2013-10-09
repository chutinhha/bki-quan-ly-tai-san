///************************************************
/// Generated by: Vanna
/// Date: 07/09/2013 11:13:12
/// Goal: Create User Service Class for V_GD_KHAU_HAO_DM_TAI_SAN_KHAC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_KHAU_HAO_DM_TAI_SAN_KHAC
/// </summary>

using System;
using WebDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;
using WebDS.CDBNames;

namespace WebUS
{

    public class US_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC : US_Object
    {
        private const string c_TableName = "V_GD_KHAU_HAO_DM_TAI_SAN_KHAC";
        #region "Public Properties"
        public string strTEN_DV_SU_DUNG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_SU_DUNG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_SU_DUNG"] = value;
            }
        }

        public bool IsTEN_DV_SU_DUNGNull()
        {
            return pm_objDR.IsNull("TEN_DV_SU_DUNG");
        }

        public void SetTEN_DV_SU_DUNGNull()
        {
            pm_objDR["TEN_DV_SU_DUNG"] = System.Convert.DBNull;
        }

        public string strTEN_DV_CHU_QUAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_CHU_QUAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_CHU_QUAN"] = value;
            }
        }

        public bool IsTEN_DV_CHU_QUANNull()
        {
            return pm_objDR.IsNull("TEN_DV_CHU_QUAN");
        }

        public void SetTEN_DV_CHU_QUANNull()
        {
            pm_objDR["TEN_DV_CHU_QUAN"] = System.Convert.DBNull;
        }

        public string strTEN_DV_BO_TINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_BO_TINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_BO_TINH"] = value;
            }
        }

        public bool IsTEN_DV_BO_TINHNull()
        {
            return pm_objDR.IsNull("TEN_DV_BO_TINH");
        }

        public void SetTEN_DV_BO_TINHNull()
        {
            pm_objDR["TEN_DV_BO_TINH"] = System.Convert.DBNull;
        }

        public string strTEN_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TRANG_THAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TRANG_THAI"] = value;
            }
        }

        public bool IsTEN_TRANG_THAINull()
        {
            return pm_objDR.IsNull("TEN_TRANG_THAI");
        }

        public void SetTEN_TRANG_THAINull()
        {
            pm_objDR["TEN_TRANG_THAI"] = System.Convert.DBNull;
        }

        public string strTEN_TINH_TRANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TINH_TRANG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TINH_TRANG"] = value;
            }
        }

        public bool IsTEN_TINH_TRANGNull()
        {
            return pm_objDR.IsNull("TEN_TINH_TRANG");
        }

        public void SetTEN_TINH_TRANGNull()
        {
            pm_objDR["TEN_TINH_TRANG"] = System.Convert.DBNull;
        }

        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_TAI_SAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_TAI_SAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_TAI_SAN"] = value;
            }
        }

        public bool IsMA_TAI_SANNull()
        {
            return pm_objDR.IsNull("MA_TAI_SAN");
        }

        public void SetMA_TAI_SANNull()
        {
            pm_objDR["MA_TAI_SAN"] = System.Convert.DBNull;
        }

        public string strTEN_TAI_SAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TAI_SAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TAI_SAN"] = value;
            }
        }

        public bool IsTEN_TAI_SANNull()
        {
            return pm_objDR.IsNull("TEN_TAI_SAN");
        }

        public void SetTEN_TAI_SANNull()
        {
            pm_objDR["TEN_TAI_SAN"] = System.Convert.DBNull;
        }

        public string strKY_HIEU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "KY_HIEU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["KY_HIEU"] = value;
            }
        }

        public bool IsKY_HIEUNull()
        {
            return pm_objDR.IsNull("KY_HIEU");
        }

        public void SetKY_HIEUNull()
        {
            pm_objDR["KY_HIEU"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_TAI_SAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TAI_SAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_TAI_SAN"] = value;
            }
        }

        public bool IsID_LOAI_TAI_SANNull()
        {
            return pm_objDR.IsNull("ID_LOAI_TAI_SAN");
        }

        public void SetID_LOAI_TAI_SANNull()
        {
            pm_objDR["ID_LOAI_TAI_SAN"] = System.Convert.DBNull;
        }

        public string strNUOC_SAN_XUAT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NUOC_SAN_XUAT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NUOC_SAN_XUAT"] = value;
            }
        }

        public bool IsNUOC_SAN_XUATNull()
        {
            return pm_objDR.IsNull("NUOC_SAN_XUAT");
        }

        public void SetNUOC_SAN_XUATNull()
        {
            pm_objDR["NUOC_SAN_XUAT"] = System.Convert.DBNull;
        }

        public decimal dcNAM_SAN_XUAT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NAM_SAN_XUAT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NAM_SAN_XUAT"] = value;
            }
        }

        public bool IsNAM_SAN_XUATNull()
        {
            return pm_objDR.IsNull("NAM_SAN_XUAT");
        }

        public void SetNAM_SAN_XUATNull()
        {
            pm_objDR["NAM_SAN_XUAT"] = System.Convert.DBNull;
        }

        public decimal dcNAM_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NAM_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NAM_SU_DUNG"] = value;
            }
        }

        public bool IsNAM_SU_DUNGNull()
        {
            return pm_objDR.IsNull("NAM_SU_DUNG");
        }

        public void SetNAM_SU_DUNGNull()
        {
            pm_objDR["NAM_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcNGUON_NS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NGUON_NS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NGUON_NS"] = value;
            }
        }

        public bool IsNGUON_NSNull()
        {
            return pm_objDR.IsNull("NGUON_NS");
        }

        public void SetNGUON_NSNull()
        {
            pm_objDR["NGUON_NS"] = System.Convert.DBNull;
        }

        public decimal dcNGUON_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NGUON_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NGUON_KHAC"] = value;
            }
        }

        public bool IsNGUON_KHACNull()
        {
            return pm_objDR.IsNull("NGUON_KHAC");
        }

        public void SetNGUON_KHACNull()
        {
            pm_objDR["NGUON_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcGIA_TRI_CON_LAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_CON_LAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_TRI_CON_LAI"] = value;
            }
        }

        public bool IsGIA_TRI_CON_LAINull()
        {
            return pm_objDR.IsNull("GIA_TRI_CON_LAI");
        }

        public void SetGIA_TRI_CON_LAINull()
        {
            pm_objDR["GIA_TRI_CON_LAI"] = System.Convert.DBNull;
        }

        public decimal dcQLNN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "QLNN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["QLNN"] = value;
            }
        }

        public bool IsQLNNNull()
        {
            return pm_objDR.IsNull("QLNN");
        }

        public void SetQLNNNull()
        {
            pm_objDR["QLNN"] = System.Convert.DBNull;
        }

        public decimal dcKINH_DOANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "KINH_DOANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["KINH_DOANH"] = value;
            }
        }

        public bool IsKINH_DOANHNull()
        {
            return pm_objDR.IsNull("KINH_DOANH");
        }

        public void SetKINH_DOANHNull()
        {
            pm_objDR["KINH_DOANH"] = System.Convert.DBNull;
        }

        public decimal dcKHONG_KINH_DOANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "KHONG_KINH_DOANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["KHONG_KINH_DOANH"] = value;
            }
        }

        public bool IsKHONG_KINH_DOANHNull()
        {
            return pm_objDR.IsNull("KHONG_KINH_DOANH");
        }

        public void SetKHONG_KINH_DOANHNull()
        {
            pm_objDR["KHONG_KINH_DOANH"] = System.Convert.DBNull;
        }

        public decimal dcHD_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "HD_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["HD_KHAC"] = value;
            }
        }

        public bool IsHD_KHACNull()
        {
            return pm_objDR.IsNull("HD_KHAC");
        }

        public void SetHD_KHACNull()
        {
            pm_objDR["HD_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI"] = value;
            }
        }

        public bool IsID_TRANG_THAINull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI");
        }

        public void SetID_TRANG_THAINull()
        {
            pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_NHAT_CUOI
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_NHAT_CUOI", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP_NHAT_CUOI"] = value;
            }
        }

        public bool IsNGAY_CAP_NHAT_CUOINull()
        {
            return pm_objDR.IsNull("NGAY_CAP_NHAT_CUOI");
        }

        public void SetNGAY_CAP_NHAT_CUOINull()
        {
            pm_objDR["NGAY_CAP_NHAT_CUOI"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_LAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_LAP"] = value;
            }
        }

        public bool IsID_NGUOI_LAPNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_LAP");
        }

        public void SetID_NGUOI_LAPNull()
        {
            pm_objDR["ID_NGUOI_LAP"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_DUYET
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_DUYET"] = value;
            }
        }

        public bool IsID_NGUOI_DUYETNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_DUYET");
        }

        public void SetID_NGUOI_DUYETNull()
        {
            pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_SU_DUNG"] = value;
            }
        }

        public bool IsID_DON_VI_SU_DUNGNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_SU_DUNG");
        }

        public void SetID_DON_VI_SU_DUNGNull()
        {
            pm_objDR["ID_DON_VI_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI_CHU_QUAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CHU_QUAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_CHU_QUAN"] = value;
            }
        }

        public bool IsID_DON_VI_CHU_QUANNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_CHU_QUAN");
        }

        public void SetID_DON_VI_CHU_QUANNull()
        {
            pm_objDR["ID_DON_VI_CHU_QUAN"] = System.Convert.DBNull;
        }

        public decimal dcID_TINH_TRANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TINH_TRANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TINH_TRANG"] = value;
            }
        }

        public bool IsID_TINH_TRANGNull()
        {
            return pm_objDR.IsNull("ID_TINH_TRANG");
        }

        public void SetID_TINH_TRANGNull()
        {
            pm_objDR["ID_TINH_TRANG"] = System.Convert.DBNull;
        }

        public decimal dcID_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_KH"] = value;
            }
        }

        public bool IsID_KHNull()
        {
            return pm_objDR.IsNull("ID_KH");
        }

        public void SetID_KHNull()
        {
            pm_objDR["ID_KH"] = System.Convert.DBNull;
        }

        public string strMA_PHIEU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_PHIEU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_PHIEU"] = value;
            }
        }

        public bool IsMA_PHIEUNull()
        {
            return pm_objDR.IsNull("MA_PHIEU");
        }

        public void SetMA_PHIEUNull()
        {
            pm_objDR["MA_PHIEU"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_LAP_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_LAP_KH"] = value;
            }
        }

        public bool IsID_NGUOI_LAP_KHNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_LAP_KH");
        }

        public void SetID_NGUOI_LAP_KHNull()
        {
            pm_objDR["ID_NGUOI_LAP_KH"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_DUYET_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_DUYET_KH"] = value;
            }
        }

        public bool IsID_NGUOI_DUYET_KHNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_DUYET_KH");
        }

        public void SetID_NGUOI_DUYET_KHNull()
        {
            pm_objDR["ID_NGUOI_DUYET_KH"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI"] = value;
            }
        }

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_TAI_SAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TAI_SAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TAI_SAN"] = value;
            }
        }

        public bool IsID_TAI_SANNull()
        {
            return pm_objDR.IsNull("ID_TAI_SAN");
        }

        public void SetID_TAI_SANNull()
        {
            pm_objDR["ID_TAI_SAN"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_TAI_SAN_KH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TAI_SAN_KH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_TAI_SAN_KH"] = value;
            }
        }

        public bool IsID_LOAI_TAI_SAN_KHNull()
        {
            return pm_objDR.IsNull("ID_LOAI_TAI_SAN_KH");
        }

        public void SetID_LOAI_TAI_SAN_KHNull()
        {
            pm_objDR["ID_LOAI_TAI_SAN_KH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_LAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_LAP"] = value;
            }
        }

        public bool IsNGAY_LAPNull()
        {
            return pm_objDR.IsNull("NGAY_LAP");
        }

        public void SetNGAY_LAPNull()
        {
            pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
        }

        public decimal dcGIA_TRI_KHAU_HAO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_KHAU_HAO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_TRI_KHAU_HAO"] = value;
            }
        }

        public bool IsGIA_TRI_KHAU_HAONull()
        {
            return pm_objDR.IsNull("GIA_TRI_KHAU_HAO");
        }

        public void SetGIA_TRI_KHAU_HAONull()
        {
            pm_objDR["GIA_TRI_KHAU_HAO"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_DUYET
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_DUYET", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_DUYET"] = value;
            }
        }

        public bool IsNGAY_DUYETNull()
        {
            return pm_objDR.IsNull("NGAY_DUYET");
        }

        public void SetNGAY_DUYETNull()
        {
            pm_objDR["NGAY_DUYET"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC()
        {
            pm_objDS = new DS_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region "Additional Functions"
        public void FillDataSetByKeyWord(
            string ip_str_id_bo_tinh
            , string ip_str_id_dv_chu_quan
            , string ip_str_id_dv_su_dung
            , string ip_str_id_trang_thai
            , string ip_str_user_name
            , string ip_str_loai_hinh_dv
            , string ip_str_tu_khoa
            , DS_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC op_ds_v_gd_khau_hao_dm_ts_khac)
        {
            CStoredProc v_obj_procedure = new CStoredProc("pr_V_GD_KHAU_HAO_DM_TAI_SAN_KHAC_Load_data_to_grid_by_tu_khoa");
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_bo_tinh", ip_str_id_bo_tinh);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_don_vi_chu_quan", ip_str_id_dv_chu_quan);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_don_vi_su_dung", ip_str_id_dv_su_dung);
            v_obj_procedure.addDecimalInputParam("@ip_dc_id_trang_thai", ip_str_id_trang_thai);
            v_obj_procedure.addNVarcharInputParam("@ip_str_user_name", ip_str_user_name);
            v_obj_procedure.addNVarcharInputParam("@ip_str_loai_hinh_don_vi", ip_str_loai_hinh_dv);
            v_obj_procedure.addNVarcharInputParam("@ip_str_tu_khoa", ip_str_tu_khoa);
            v_obj_procedure.fillDataSetByCommand(this, op_ds_v_gd_khau_hao_dm_ts_khac);
        }
        #endregion
    }
}
