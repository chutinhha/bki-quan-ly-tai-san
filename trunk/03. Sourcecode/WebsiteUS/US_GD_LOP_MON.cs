///************************************************
/// Generated by: tinhth
/// Date: 17/09/2011 03:56:12
/// Goal: Create User Service Class for GD_LOP_MON
///************************************************
/// <summary>
/// Create User Service Class for GD_LOP_MON
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;


namespace WebUS{

public class US_GD_LOP_MON : US_Object
{
	private const string c_TableName = "GD_LOP_MON";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_LOP_MON 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOP_MON", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOP_MON"] = value;
		}
	}

	public bool IsMA_LOP_MONNull() 
	{
		return pm_objDR.IsNull("MA_LOP_MON");
	}

	public void SetMA_LOP_MONNull() {
		pm_objDR["MA_LOP_MON"] = System.Convert.DBNull;
	}

	public decimal dcID_MON_HOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MON_HOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MON_HOC"] = value;
		}
	}

	public bool IsID_MON_HOCNull()	{
		return pm_objDR.IsNull("ID_MON_HOC");
	}

	public void SetID_MON_HOCNull() {
		pm_objDR["ID_MON_HOC"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BAT_DAU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU"] = value;
		}
	}

	public bool IsNGAY_BAT_DAUNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU");
	}

	public void SetNGAY_BAT_DAUNull()
	{
		pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC"] = value;
		}
	}

	public bool IsNGAY_KET_THUCNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC");
	}

	public void SetNGAY_KET_THUCNull()
	{
		pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
	}

	public string strPO_PHU_TRACH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PO_PHU_TRACH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PO_PHU_TRACH"] = value;
		}
	}

	public bool IsPO_PHU_TRACHNull() 
	{
		return pm_objDR.IsNull("PO_PHU_TRACH");
	}

	public void SetPO_PHU_TRACHNull() {
		pm_objDR["PO_PHU_TRACH"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_THI
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THI", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THI"] = value;
		}
	}

	public bool IsNGAY_THINull()
	{
		return pm_objDR.IsNull("NGAY_THI");
	}

	public void SetNGAY_THINull()
	{
		pm_objDR["NGAY_THI"] = System.Convert.DBNull;
	}

	public string strCHUONG_TRINH_PHU_TRACH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHUONG_TRINH_PHU_TRACH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHUONG_TRINH_PHU_TRACH"] = value;
		}
	}

	public bool IsCHUONG_TRINH_PHU_TRACHNull() 
	{
		return pm_objDR.IsNull("CHUONG_TRINH_PHU_TRACH");
	}

	public void SetCHUONG_TRINH_PHU_TRACHNull() {
		pm_objDR["CHUONG_TRINH_PHU_TRACH"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_HV 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_HV", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_HV"] = value;
		}
	}

	public bool IsSO_LUONG_HVNull()	{
		return pm_objDR.IsNull("SO_LUONG_HV");
	}

	public void SetSO_LUONG_HVNull() {
		pm_objDR["SO_LUONG_HV"] = System.Convert.DBNull;
	}

	public string strOFFLINE_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "OFFLINE_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["OFFLINE_YN"] = value;
		}
	}

	public bool IsOFFLINE_YNNull() 
	{
		return pm_objDR.IsNull("OFFLINE_YN");
	}

	public void SetOFFLINE_YNNull() {
		pm_objDR["OFFLINE_YN"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_OFFLINE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_OFFLINE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_OFFLINE"] = value;
		}
	}

	public bool IsSO_LUONG_OFFLINENull()	{
		return pm_objDR.IsNull("SO_LUONG_OFFLINE");
	}

	public void SetSO_LUONG_OFFLINENull() {
		pm_objDR["SO_LUONG_OFFLINE"] = System.Convert.DBNull;
	}

	public string strONLINES_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "ONLINES_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["ONLINES_YN"] = value;
		}
	}

	public bool IsONLINES_YNNull() 
	{
		return pm_objDR.IsNull("ONLINES_YN");
	}

	public void SetONLINES_YNNull() {
		pm_objDR["ONLINES_YN"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_ONLINES 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_ONLINES", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_ONLINES"] = value;
		}
	}

	public bool IsSO_LUONG_ONLINESNull()	{
		return pm_objDR.IsNull("SO_LUONG_ONLINES");
	}

	public void SetSO_LUONG_ONLINESNull() {
		pm_objDR["SO_LUONG_ONLINES"] = System.Convert.DBNull;
	}

	public string strBAI_TAP_GKY_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "BAI_TAP_GKY_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["BAI_TAP_GKY_YN"] = value;
		}
	}

	public bool IsBAI_TAP_GKY_YNNull() 
	{
		return pm_objDR.IsNull("BAI_TAP_GKY_YN");
	}

	public void SetBAI_TAP_GKY_YNNull() {
		pm_objDR["BAI_TAP_GKY_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_LOP_MON() 
	{
		pm_objDS = new DS_GD_LOP_MON();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_LOP_MON(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_LOP_MON(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_LOP_MON();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    #region Addtional
    public bool check_trung_ma_lop_mon(string i_str_ma_lop_mon) {
        try {
            DS_GD_LOP_MON v_ds = new DS_GD_LOP_MON();
            IMakeSelectCmd v_obj_mak_cmd = new CMakeAndSelectCmd(v_ds, v_ds.GD_LOP_MON.TableName);
            v_obj_mak_cmd.AddCondition("MA_LOP_MON", i_str_ma_lop_mon, eKieuDuLieu.KieuString, eKieuSoSanh.Bang);
            this.FillDatasetByCommand(v_ds, v_obj_mak_cmd.getSelectCmd());
            if (v_ds.GD_LOP_MON.Rows.Count > 0)
            {
                //this.DataRow2Me(v_ds.GD_LOP_MON.Rows[0]);
                return true;
            }
            return false;
        }
        catch (Exception v_e) {
            throw v_e;
        }
    }
    public void fill_data_by_search(decimal i_dc_id_mon_hoc
                                    ,string i_str_online_yn
                                    ,string i_str_offline_yn
                                    ,string i_str_bt_gky_yn
                                    ,string i_str_key_word
                                    ,string i_str_bat_dau_tu
                                    , string i_str_bat_dau_den
                                    , string i_str_ket_thuc_tu
                                    , string i_str_ket_thuc_den
                                    , string i_str_thi_tu
                                    , string i_str_thi_den        
                                    ,DS_GD_LOP_MON i_ds)
    {
        try
        {
            CStoredProc v_object = new CStoredProc("pr_GD_LOP_MON_Fill_By_Search");
            v_object.addDecimalInputParam("@ip_id_mon_hoc",i_dc_id_mon_hoc);
            v_object.addNVarcharInputParam("@ip_online_yn",i_str_online_yn);
            v_object.addNVarcharInputParam("@ip_offline_yn", i_str_offline_yn);
            v_object.addNVarcharInputParam("@ip_bt_gky_yn", i_str_bt_gky_yn);
            v_object.addNVarcharInputParam("@ip_key_word", i_str_key_word);
            v_object.addDatetimeInputParam("@ip_ngay_bat_dau_tu", CIPConvert.ToDatetime(i_str_bat_dau_tu,"dd/MM/yyyy"));
            v_object.addDatetimeInputParam("@ip_ngay_bat_dau_den", CIPConvert.ToDatetime(i_str_bat_dau_den,"dd/MM/yyyy"));
            v_object.addDatetimeInputParam("@ip_ngay_ket_thuc_tu", CIPConvert.ToDatetime(i_str_ket_thuc_tu,"dd/MM/yyyy"));
            v_object.addDatetimeInputParam("@ip_ngay_ket_thuc_den", CIPConvert.ToDatetime(i_str_ket_thuc_den,"dd/MM/yyyy"));
            v_object.addDatetimeInputParam("@ip_ngay_thi_tu", CIPConvert.ToDatetime(i_str_thi_tu,"dd/MM/yyyy"));
            v_object.addDatetimeInputParam("@ip_ngay_thi_den", CIPConvert.ToDatetime(i_str_thi_den, "dd/MM/yyyy"));
            v_object.fillDataSetByCommand(this, i_ds);
        }
        catch (Exception v_e)
        {
            throw v_e;
        }
    }

    #endregion
}
}
