///************************************************
/// Generated by: TuDM
/// Date: 28/07/2013 09:41:13
/// Goal: Create User Service Class for DM_NHA
///************************************************
/// <summary>
/// Create User Service Class for DM_NHA
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;
using WebDS.CDBNames;


namespace WebUS
{
    public class US_DM_NHA : US_Object
    {
        private const string c_TableName = "DM_NHA";
        #region "Public Properties"
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

        public decimal dcID_DAT
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DAT", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DAT"] = value;
            }
        }

        public bool IsID_DATNull()
        {
            return pm_objDR.IsNull("ID_DAT");
        }

        public void SetID_DATNull()
        {
            pm_objDR["ID_DAT"] = System.Convert.DBNull;
        }

        public decimal dcCAP_HANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "CAP_HANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["CAP_HANG"] = value;
            }
        }

        public bool IsCAP_HANGNull()
        {
            return pm_objDR.IsNull("CAP_HANG");
        }

        public void SetCAP_HANGNull()
        {
            pm_objDR["CAP_HANG"] = System.Convert.DBNull;
        }

        public decimal dcSO_TANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TANG"] = value;
            }
        }

        public bool IsSO_TANGNull()
        {
            return pm_objDR.IsNull("SO_TANG");
        }

        public void SetSO_TANGNull()
        {
            pm_objDR["SO_TANG"] = System.Convert.DBNull;
        }

        public decimal dcNGAY_THANG_NAM_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NGAY_THANG_NAM_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NGAY_THANG_NAM_SU_DUNG"] = value;
            }
        }

        public bool IsNGAY_THANG_NAM_SU_DUNGNull()
        {
            return pm_objDR.IsNull("NGAY_THANG_NAM_SU_DUNG");
        }

        public void SetNGAY_THANG_NAM_SU_DUNGNull()
        {
            pm_objDR["NGAY_THANG_NAM_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcNAM_XAY_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NAM_XAY_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NAM_XAY_DUNG"] = value;
            }
        }

        public bool IsNAM_XAY_DUNGNull()
        {
            return pm_objDR.IsNull("NAM_XAY_DUNG");
        }

        public void SetNAM_XAY_DUNGNull()
        {
            pm_objDR["NAM_XAY_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcDT_XAY_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DT_XAY_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DT_XAY_DUNG"] = value;
            }
        }

        public bool IsDT_XAY_DUNGNull()
        {
            return pm_objDR.IsNull("DT_XAY_DUNG");
        }

        public void SetDT_XAY_DUNGNull()
        {
            pm_objDR["DT_XAY_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcTONG_DT_SAN_XD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_DT_SAN_XD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_DT_SAN_XD"] = value;
            }
        }

        public bool IsTONG_DT_SAN_XDNull()
        {
            return pm_objDR.IsNull("TONG_DT_SAN_XD");
        }

        public void SetTONG_DT_SAN_XDNull()
        {
            pm_objDR["TONG_DT_SAN_XD"] = System.Convert.DBNull;
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

        public decimal dcTRU_SO_LAM_VIEC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TRU_SO_LAM_VIEC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TRU_SO_LAM_VIEC"] = value;
            }
        }

        public bool IsTRU_SO_LAM_VIECNull()
        {
            return pm_objDR.IsNull("TRU_SO_LAM_VIEC");
        }

        public void SetTRU_SO_LAM_VIECNull()
        {
            pm_objDR["TRU_SO_LAM_VIEC"] = System.Convert.DBNull;
        }

        public decimal dcCO_SO_HDSN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "CO_SO_HDSN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["CO_SO_HDSN"] = value;
            }
        }

        public bool IsCO_SO_HDSNNull()
        {
            return pm_objDR.IsNull("CO_SO_HDSN");
        }

        public void SetCO_SO_HDSNNull()
        {
            pm_objDR["CO_SO_HDSN"] = System.Convert.DBNull;
        }

        public decimal dcLAM_NHA_O
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LAM_NHA_O", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LAM_NHA_O"] = value;
            }
        }

        public bool IsLAM_NHA_ONull()
        {
            return pm_objDR.IsNull("LAM_NHA_O");
        }

        public void SetLAM_NHA_ONull()
        {
            pm_objDR["LAM_NHA_O"] = System.Convert.DBNull;
        }

        public decimal dcCHO_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "CHO_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["CHO_THUE"] = value;
            }
        }

        public bool IsCHO_THUENull()
        {
            return pm_objDR.IsNull("CHO_THUE");
        }

        public void SetCHO_THUENull()
        {
            pm_objDR["CHO_THUE"] = System.Convert.DBNull;
        }

        public decimal dcBO_TRONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "BO_TRONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["BO_TRONG"] = value;
            }
        }

        public bool IsBO_TRONGNull()
        {
            return pm_objDR.IsNull("BO_TRONG");
        }

        public void SetBO_TRONGNull()
        {
            pm_objDR["BO_TRONG"] = System.Convert.DBNull;
        }

        public decimal dcBI_LAN_CHIEM
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "BI_LAN_CHIEM", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["BI_LAN_CHIEM"] = value;
            }
        }

        public bool IsBI_LAN_CHIEMNull()
        {
            return pm_objDR.IsNull("BI_LAN_CHIEM");
        }

        public void SetBI_LAN_CHIEMNull()
        {
            pm_objDR["BI_LAN_CHIEM"] = System.Convert.DBNull;
        }

        public decimal dcKHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["KHAC"] = value;
            }
        }

        public bool IsKHACNull()
        {
            return pm_objDR.IsNull("KHAC");
        }

        public void SetKHACNull()
        {
            pm_objDR["KHAC"] = System.Convert.DBNull;
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

        public decimal dcID_DON_VI_DAU_TU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_DAU_TU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI_DAU_TU"] = value;
            }
        }

        public bool IsID_DON_VI_DAU_TUNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_DAU_TU");
        }

        public void SetID_DON_VI_DAU_TUNull()
        {
            pm_objDR["ID_DON_VI_DAU_TU"] = System.Convert.DBNull;
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

        #endregion
        #region "Init Functions"
        public US_DM_NHA()
        {
            pm_objDS = new DS_DM_NHA();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_NHA(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_NHA(decimal i_dbID)
        {
            pm_objDS = new DS_DM_NHA();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region "Addition Functions"
        public void load_nha_by_ten(DS_DM_NHA op_ds_dm_nha, string ip_str_search, decimal ip_dc_id_dat)
        {
            if (ip_dc_id_dat == CONST_QLDB.ID_TAT_CA)
            {
                this.FillDataset(op_ds_dm_nha, "where " + DM_NHA.ID_TRANG_THAI + " = " + ID_TRANG_THAI_NHA.DANG_SU_DUNG);
            } 
            else
            {
                CStoredProc v_cstore = new CStoredProc("pr_DM_NHA_Search_by_name");
                v_cstore.addNVarcharInputParam("@TU_KHOA", ip_str_search);
                v_cstore.addDecimalInputParam("@ID_DAT", ip_dc_id_dat);
                v_cstore.fillDataSetByCommand(this, op_ds_dm_nha);
            }
        }

        public bool check_ma_tai_san_is_valid(string ip_str_ma_tai_san)
        {
            US_DM_NHA v_us_dm_nha = new US_DM_NHA();
            DS_DM_NHA v_ds_dm_nha = new DS_DM_NHA();
            v_us_dm_nha.FillDataset(v_ds_dm_nha, "where " + DM_NHA.MA_TAI_SAN + " = '" + ip_str_ma_tai_san + "'");
            if (v_ds_dm_nha.DM_NHA.Rows.Count == 0) return true;
            return false;
        }
        #endregion
    }
}
