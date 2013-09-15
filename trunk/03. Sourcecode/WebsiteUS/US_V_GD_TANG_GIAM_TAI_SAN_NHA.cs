///************************************************
/// Generated by: TuDM
/// Date: 15/09/2013 10:40:27
/// Goal: Create User Service Class for V_GD_TANG_GIAM_TAI_SAN_NHA
///************************************************
/// <summary>
/// Create User Service Class for V_GD_TANG_GIAM_TAI_SAN_NHA
/// </summary>

using System;
using WebDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;


namespace AuctionUS{

public class US_V_GD_TANG_GIAM_TAI_SAN_NHA : US_Object
{
	private const string c_TableName = "V_GD_TANG_GIAM_TAI_SAN_NHA";
#region "Public Properties"
	public string strTEN_LOAI_TAI_SAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_TAI_SAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_TAI_SAN"] = value;
		}
	}

	public bool IsTEN_LOAI_TAI_SANNull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_TAI_SAN");
	}

	public void SetTEN_LOAI_TAI_SANNull() {
		pm_objDR["TEN_LOAI_TAI_SAN"] = System.Convert.DBNull;
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
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

	public void SetMA_PHIEUNull() {
		pm_objDR["MA_PHIEU"] = System.Convert.DBNull;
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

	public bool IsID_NGUOI_LAPNull()	{
		return pm_objDR.IsNull("ID_NGUOI_LAP");
	}

	public void SetID_NGUOI_LAPNull() {
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

	public bool IsID_NGUOI_DUYETNull()	{
		return pm_objDR.IsNull("ID_NGUOI_DUYET");
	}

	public void SetID_NGUOI_DUYETNull() {
		pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
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

	public DateTime datNGAY_TANG_GIAM_TAI_SAN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_TANG_GIAM_TAI_SAN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_TANG_GIAM_TAI_SAN"] = value;
		}
	}

	public bool IsNGAY_TANG_GIAM_TAI_SANNull()
	{
		return pm_objDR.IsNull("NGAY_TANG_GIAM_TAI_SAN");
	}

	public void SetNGAY_TANG_GIAM_TAI_SANNull()
	{
		pm_objDR["NGAY_TANG_GIAM_TAI_SAN"] = System.Convert.DBNull;
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

	public bool IsID_LOAI_TAI_SANNull()	{
		return pm_objDR.IsNull("ID_LOAI_TAI_SAN");
	}

	public void SetID_LOAI_TAI_SANNull() {
		pm_objDR["ID_LOAI_TAI_SAN"] = System.Convert.DBNull;
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

	public bool IsID_TAI_SANNull()	{
		return pm_objDR.IsNull("ID_TAI_SAN");
	}

	public void SetID_TAI_SANNull() {
		pm_objDR["ID_TAI_SAN"] = System.Convert.DBNull;
	}

	public string strTANG_GIA_TRI_TAI_SAN_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TANG_GIA_TRI_TAI_SAN_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TANG_GIA_TRI_TAI_SAN_YN"] = value;
		}
	}

	public bool IsTANG_GIA_TRI_TAI_SAN_YNNull() 
	{
		return pm_objDR.IsNull("TANG_GIA_TRI_TAI_SAN_YN");
	}

	public void SetTANG_GIA_TRI_TAI_SAN_YNNull() {
		pm_objDR["TANG_GIA_TRI_TAI_SAN_YN"] = System.Convert.DBNull;
	}

	public decimal dcGIA_TRI_NGUYEN_GIA_TANG_GIAM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_NGUYEN_GIA_TANG_GIAM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_TRI_NGUYEN_GIA_TANG_GIAM"] = value;
		}
	}

	public bool IsGIA_TRI_NGUYEN_GIA_TANG_GIAMNull()	{
		return pm_objDR.IsNull("GIA_TRI_NGUYEN_GIA_TANG_GIAM");
	}

	public void SetGIA_TRI_NGUYEN_GIA_TANG_GIAMNull() {
		pm_objDR["GIA_TRI_NGUYEN_GIA_TANG_GIAM"] = System.Convert.DBNull;
	}

	public decimal dcDIEN_TICH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DIEN_TICH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DIEN_TICH"] = value;
		}
	}

	public bool IsDIEN_TICHNull()	{
		return pm_objDR.IsNull("DIEN_TICH");
	}

	public void SetDIEN_TICHNull() {
		pm_objDR["DIEN_TICH"] = System.Convert.DBNull;
	}

	public decimal dcID_LY_DO_TANG_GIAM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LY_DO_TANG_GIAM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LY_DO_TANG_GIAM"] = value;
		}
	}

	public bool IsID_LY_DO_TANG_GIAMNull()	{
		return pm_objDR.IsNull("ID_LY_DO_TANG_GIAM");
	}

	public void SetID_LY_DO_TANG_GIAMNull() {
		pm_objDR["ID_LY_DO_TANG_GIAM"] = System.Convert.DBNull;
	}

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

	public void SetTEN_DV_SU_DUNGNull() {
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

	public void SetTEN_DV_CHU_QUANNull() {
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

	public void SetTEN_DV_BO_TINHNull() {
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

	public void SetTEN_TRANG_THAINull() {
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

	public void SetTEN_TINH_TRANGNull() {
		pm_objDR["TEN_TINH_TRANG"] = System.Convert.DBNull;
	}

	public string strDIA_CHI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_CHI"] = value;
		}
	}

	public bool IsDIA_CHINull() 
	{
		return pm_objDR.IsNull("DIA_CHI");
	}

	public void SetDIA_CHINull() {
		pm_objDR["DIA_CHI"] = System.Convert.DBNull;
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

	public void SetTEN_TAI_SANNull() {
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

	public void SetMA_TAI_SANNull() {
		pm_objDR["MA_TAI_SAN"] = System.Convert.DBNull;
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

	public bool IsID_DATNull()	{
		return pm_objDR.IsNull("ID_DAT");
	}

	public void SetID_DATNull() {
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

	public bool IsCAP_HANGNull()	{
		return pm_objDR.IsNull("CAP_HANG");
	}

	public void SetCAP_HANGNull() {
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

	public bool IsSO_TANGNull()	{
		return pm_objDR.IsNull("SO_TANG");
	}

	public void SetSO_TANGNull() {
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

	public bool IsNGAY_THANG_NAM_SU_DUNGNull()	{
		return pm_objDR.IsNull("NGAY_THANG_NAM_SU_DUNG");
	}

	public void SetNGAY_THANG_NAM_SU_DUNGNull() {
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

	public bool IsNAM_XAY_DUNGNull()	{
		return pm_objDR.IsNull("NAM_XAY_DUNG");
	}

	public void SetNAM_XAY_DUNGNull() {
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

	public bool IsDT_XAY_DUNGNull()	{
		return pm_objDR.IsNull("DT_XAY_DUNG");
	}

	public void SetDT_XAY_DUNGNull() {
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

	public bool IsTONG_DT_SAN_XDNull()	{
		return pm_objDR.IsNull("TONG_DT_SAN_XD");
	}

	public void SetTONG_DT_SAN_XDNull() {
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

	public bool IsNGUON_NSNull()	{
		return pm_objDR.IsNull("NGUON_NS");
	}

	public void SetNGUON_NSNull() {
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

	public bool IsNGUON_KHACNull()	{
		return pm_objDR.IsNull("NGUON_KHAC");
	}

	public void SetNGUON_KHACNull() {
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

	public bool IsGIA_TRI_CON_LAINull()	{
		return pm_objDR.IsNull("GIA_TRI_CON_LAI");
	}

	public void SetGIA_TRI_CON_LAINull() {
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

	public bool IsTRU_SO_LAM_VIECNull()	{
		return pm_objDR.IsNull("TRU_SO_LAM_VIEC");
	}

	public void SetTRU_SO_LAM_VIECNull() {
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

	public bool IsCO_SO_HDSNNull()	{
		return pm_objDR.IsNull("CO_SO_HDSN");
	}

	public void SetCO_SO_HDSNNull() {
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

	public bool IsLAM_NHA_ONull()	{
		return pm_objDR.IsNull("LAM_NHA_O");
	}

	public void SetLAM_NHA_ONull() {
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

	public bool IsCHO_THUENull()	{
		return pm_objDR.IsNull("CHO_THUE");
	}

	public void SetCHO_THUENull() {
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

	public bool IsBO_TRONGNull()	{
		return pm_objDR.IsNull("BO_TRONG");
	}

	public void SetBO_TRONGNull() {
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

	public bool IsBI_LAN_CHIEMNull()	{
		return pm_objDR.IsNull("BI_LAN_CHIEM");
	}

	public void SetBI_LAN_CHIEMNull() {
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

	public bool IsKHACNull()	{
		return pm_objDR.IsNull("KHAC");
	}

	public void SetKHACNull() {
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

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
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

	public bool IsID_DON_VI_SU_DUNGNull()	{
		return pm_objDR.IsNull("ID_DON_VI_SU_DUNG");
	}

	public void SetID_DON_VI_SU_DUNGNull() {
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

	public bool IsID_DON_VI_CHU_QUANNull()	{
		return pm_objDR.IsNull("ID_DON_VI_CHU_QUAN");
	}

	public void SetID_DON_VI_CHU_QUANNull() {
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

	public bool IsID_TINH_TRANGNull()	{
		return pm_objDR.IsNull("ID_TINH_TRANG");
	}

	public void SetID_TINH_TRANGNull() {
		pm_objDR["ID_TINH_TRANG"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_HINH_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_HINH_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_HINH_DON_VI"] = value;
		}
	}

	public bool IsTEN_LOAI_HINH_DON_VINull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_HINH_DON_VI");
	}

	public void SetTEN_LOAI_HINH_DON_VINull() {
		pm_objDR["TEN_LOAI_HINH_DON_VI"] = System.Convert.DBNull;
	}

	public string strMA_LOAI_HINH_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOAI_HINH_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOAI_HINH_DON_VI"] = value;
		}
	}

	public bool IsMA_LOAI_HINH_DON_VINull() 
	{
		return pm_objDR.IsNull("MA_LOAI_HINH_DON_VI");
	}

	public void SetMA_LOAI_HINH_DON_VINull() {
		pm_objDR["MA_LOAI_HINH_DON_VI"] = System.Convert.DBNull;
	}

	public string strTEN_DV_DUYET 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DV_DUYET", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DV_DUYET"] = value;
		}
	}

	public bool IsTEN_DV_DUYETNull() 
	{
		return pm_objDR.IsNull("TEN_DV_DUYET");
	}

	public void SetTEN_DV_DUYETNull() {
		pm_objDR["TEN_DV_DUYET"] = System.Convert.DBNull;
	}

	public string strTEN_DV_LAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DV_LAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DV_LAP"] = value;
		}
	}

	public bool IsTEN_DV_LAPNull() 
	{
		return pm_objDR.IsNull("TEN_DV_LAP");
	}

	public void SetTEN_DV_LAPNull() {
		pm_objDR["TEN_DV_LAP"] = System.Convert.DBNull;
	}

	public string strLY_DO_TANG_GIAM_TAI_SAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LY_DO_TANG_GIAM_TAI_SAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LY_DO_TANG_GIAM_TAI_SAN"] = value;
		}
	}

	public bool IsLY_DO_TANG_GIAM_TAI_SANNull() 
	{
		return pm_objDR.IsNull("LY_DO_TANG_GIAM_TAI_SAN");
	}

	public void SetLY_DO_TANG_GIAM_TAI_SANNull() {
		pm_objDR["LY_DO_TANG_GIAM_TAI_SAN"] = System.Convert.DBNull;
	}

	public string strTEN_NGAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NGAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NGAN"] = value;
		}
	}

	public bool IsTEN_NGANNull() 
	{
		return pm_objDR.IsNull("TEN_NGAN");
	}

	public void SetTEN_NGANNull() {
		pm_objDR["TEN_NGAN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_TANG_GIAM_TAI_SAN_NHA() 
	{
		pm_objDS = new DS_V_GD_TANG_GIAM_TAI_SAN_NHA();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_TANG_GIAM_TAI_SAN_NHA(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_TANG_GIAM_TAI_SAN_NHA(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_TANG_GIAM_TAI_SAN_NHA();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
