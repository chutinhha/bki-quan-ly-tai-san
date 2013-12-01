USE [TRMTest]
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NHA_Update]    Script Date: 11/30/2013 16:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Sửa Proc Update nhà --
ALTER PROCEDURE [dbo].[pr_DM_NHA_Update]
	@ID numeric(18, 0),
	@TEN_TAI_SAN nvarchar(250),
	@MA_TAI_SAN nvarchar(15),
	@ID_LOAI_TAI_SAN numeric(18, 0),
	@ID_DAT numeric(18, 0),
	@CAP_HANG numeric(4, 0),
	@SO_TANG numeric(4, 0),
	@NGAY_THANG_NAM_SU_DUNG numeric(4, 0),
	@NAM_XAY_DUNG numeric(4, 0),
	@DT_XAY_DUNG numeric(18, 2),
	@TONG_DT_SAN_XD numeric(18, 2),
	@NGUON_NS numeric(21, 3),
	@NGUON_KHAC numeric(21, 3),
	@GIA_TRI_CON_LAI numeric(21, 3),
	@TRU_SO_LAM_VIEC numeric(18, 2),
	@CO_SO_HDSN numeric(18, 2),
	@LAM_NHA_O numeric(18, 2),
	@CHO_THUE numeric(18, 2),
	@BO_TRONG numeric(18, 2),
	@BI_LAN_CHIEM numeric(18, 2),
	@KHAC numeric(18, 2),
	@ID_TRANG_THAI numeric(18, 0),
	@NGAY_CAP_NHAT_CUOI datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@ID_NGUOI_DUYET numeric(18, 0),
	@ID_DON_VI_SU_DUNG numeric(18, 0),
	@ID_DON_VI_CHU_QUAN numeric(18, 0),
	@ID_DON_VI_DAU_TU numeric(18, 0),
	@ID_TINH_TRANG NUMERIC(18,0)
AS

UPDATE [dbo].[DM_NHA]
SET 
	[TEN_TAI_SAN] = @TEN_TAI_SAN,
	[MA_TAI_SAN] = @MA_TAI_SAN,
	[ID_LOAI_TAI_SAN] = @ID_LOAI_TAI_SAN,
	[ID_DAT] = @ID_DAT,
	[CAP_HANG] = @CAP_HANG,
	[SO_TANG] = @SO_TANG,
	[NGAY_THANG_NAM_SU_DUNG] = @NGAY_THANG_NAM_SU_DUNG,
	[NAM_XAY_DUNG] = @NAM_XAY_DUNG,
	[DT_XAY_DUNG] = @DT_XAY_DUNG,
	[TONG_DT_SAN_XD] = @TONG_DT_SAN_XD,
	[NGUON_NS] = @NGUON_NS,
	[NGUON_KHAC] = @NGUON_KHAC,
	[GIA_TRI_CON_LAI] = @GIA_TRI_CON_LAI,
	[TRU_SO_LAM_VIEC] = @TRU_SO_LAM_VIEC,
	[CO_SO_HDSN] = @CO_SO_HDSN,
	[LAM_NHA_O] = @LAM_NHA_O,
	[CHO_THUE] = @CHO_THUE,
	[BO_TRONG] = @BO_TRONG,
	[BI_LAN_CHIEM] = @BI_LAN_CHIEM,
	[KHAC] = @KHAC,
	[ID_TRANG_THAI] = @ID_TRANG_THAI,
	[NGAY_CAP_NHAT_CUOI] = @NGAY_CAP_NHAT_CUOI,
	[ID_NGUOI_LAP] = @ID_NGUOI_LAP,
	[ID_NGUOI_DUYET] = @ID_NGUOI_DUYET,
	[ID_DON_VI_SU_DUNG] = @ID_DON_VI_SU_DUNG,
	[ID_DON_VI_CHU_QUAN] = @ID_DON_VI_CHU_QUAN,
	[ID_DON_VI_DAU_TU] = @ID_DON_VI_DAU_TU,
	ID_TINH_TRANG = @ID_TINH_TRANG
WHERE
	[ID] = @ID


DECLARE @v_id_nha_history NUMERIC(18,0)
DECLARE @v_str_ghi_chu_lich_su NVARCHAR(250)

SET @v_str_ghi_chu_lich_su = N'Cập nhật thông tin nhà'

exec pr_DM_NHA_HISTORY_Insert
	@TEN_TAI_SAN,
	@MA_TAI_SAN ,
	@ID_LOAI_TAI_SAN,
	@ID_DAT ,
	@CAP_HANG ,
	@SO_TANG ,
	@NGAY_THANG_NAM_SU_DUNG ,
	@NAM_XAY_DUNG ,
	@DT_XAY_DUNG ,
	@TONG_DT_SAN_XD ,
	@NGUON_NS ,
	@NGUON_KHAC ,
	@GIA_TRI_CON_LAI ,
	@TRU_SO_LAM_VIEC ,
	@CO_SO_HDSN ,
	@LAM_NHA_O ,
	@CHO_THUE ,
	@BO_TRONG ,
	@BI_LAN_CHIEM ,
	@KHAC ,
	@ID_TRANG_THAI ,
	@NGAY_CAP_NHAT_CUOI ,
	@ID_NGUOI_LAP ,
	@ID_NGUOI_DUYET ,
	@ID_DON_VI_SU_DUNG ,
	@ID_DON_VI_CHU_QUAN,
	@ID_DON_VI_DAU_TU ,
	@ID,   -- ID nha
	@v_str_ghi_chu_lich_su,
	@ID_TINH_TRANG,
	@v_id_nha_history
	
UPDATE GD_TANG_GIAM_TAI_SAN
SET
	-- ID = ? -- this column value is auto-generated,
	GIA_TRI_NGUYEN_GIA_TANG_GIAM = (@NGUON_NS + @NGUON_KHAC),
	DIEN_TICH = @DT_XAY_DUNG
WHERE ID_TAI_SAN = @ID
AND ID_LOAI_TAI_SAN = @ID_LOAI_TAI_SAN

-- Sửa Proce Delete nhà --
GO
ALTER PROCEDURE [dbo].[pr_DM_NHA_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_NHA]
WHERE
	[ID] = @ID
	
DELETE FROM GD_KHAU_HAO
WHERE ID_TAI_SAN = @ID AND ID_LOAI_TAI_SAN = 2

DELETE FROM GD_TANG_GIAM_TAI_SAN
WHERE ID_TAI_SAN = @ID AND ID_LOAI_TAI_SAN = 2

DELETE FROM DM_NHA_HISTORY
WHERE ID = @ID

-- Sửa Proc Delete oto --
GO
ALTER PROCEDURE [dbo].[pr_DM_OTO_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_OTO]
WHERE
	[ID] = @ID
DELETE FROM GD_KHAU_HAO
WHERE ID_TAI_SAN = @ID AND 
ID_LOAI_TAI_SAN IN (SELECT ID FROM DM_LOAI_TAI_SAN dlts WHERE dlts.ID_LOAI_TAI_SAN_PARENT = 3)

DELETE FROM GD_TANG_GIAM_TAI_SAN
WHERE ID_TAI_SAN = @ID AND
ID_LOAI_TAI_SAN IN (SELECT ID FROM DM_LOAI_TAI_SAN dlts WHERE dlts.ID_LOAI_TAI_SAN_PARENT = 3)

DELETE FROM DM_OTO_HISTORY
WHERE ID = @ID

-- Sửa Proc Update oto --
GO
ALTER PROCEDURE [dbo].[pr_DM_OTO_Update]
	@ID numeric(18, 0),
	@TEN_TAI_SAN nvarchar(250),
	@MA_TAI_SAN nvarchar(15),
	@ID_LOAI_TAI_SAN numeric(18, 0),
	@NHAN_HIEU nvarchar(50),
	@NUOC_SAN_XUAT nvarchar(50),
	@BIEN_KIEM_SOAT nvarchar(50),
	@SO_CHO_NGOI numeric(18, 0),
	@CONG_SUAT_XE numeric(6, 2),
	@NAM_SAN_XUAT numeric(4, 0),
	@NAM_SU_DUNG numeric(4, 0),
	@NGUON_NS numeric(21, 3),
	@NGUON_KHAC numeric(21, 3),
	@GIA_TRI_CON_LAI numeric(21, 3),
	@QLNN numeric(4, 0),
	@KINH_DOANH numeric(4, 0),
	@HD_KHAC numeric(4, 0),
	@ID_TRANG_THAI numeric(18, 0),
	@NGAY_CAP_NHAT_CUOI datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@ID_NGUOI_DUYET numeric(18, 0),
	@ID_DON_VI_SU_DUNG numeric(18, 0),
	@ID_DON_VI_CHU_QUAN numeric(18, 0),
	@KHONG_KINH_DOANH numeric(4, 0),
	@CHUC_DANH_SU_DUNG nvarchar(250),
	@NGUON_GOC_XE nvarchar(250),
	@ID_TINH_TRANG NUMERIC(18,0)
AS
UPDATE [dbo].[DM_OTO]
SET 
	[TEN_TAI_SAN] = @TEN_TAI_SAN,
	[MA_TAI_SAN] = @MA_TAI_SAN,
	[ID_LOAI_TAI_SAN] = @ID_LOAI_TAI_SAN,
	[NHAN_HIEU] = @NHAN_HIEU,
	[NUOC_SAN_XUAT] = @NUOC_SAN_XUAT,
	[BIEN_KIEM_SOAT] = @BIEN_KIEM_SOAT,
	[SO_CHO_NGOI] = @SO_CHO_NGOI,
	[CONG_SUAT_XE] = @CONG_SUAT_XE,
	[NAM_SAN_XUAT] = @NAM_SAN_XUAT,
	[NAM_SU_DUNG] = @NAM_SU_DUNG,
	[NGUON_NS] = @NGUON_NS,
	[NGUON_KHAC] = @NGUON_KHAC,
	[GIA_TRI_CON_LAI] = @GIA_TRI_CON_LAI,
	[QLNN] = @QLNN,
	[KINH_DOANH] = @KINH_DOANH,
	[HD_KHAC] = @HD_KHAC,
	[ID_TRANG_THAI] = @ID_TRANG_THAI,
	[NGAY_CAP_NHAT_CUOI] = @NGAY_CAP_NHAT_CUOI,
	[ID_NGUOI_LAP] = @ID_NGUOI_LAP,
	[ID_NGUOI_DUYET] = @ID_NGUOI_DUYET,
	[ID_DON_VI_SU_DUNG] = @ID_DON_VI_SU_DUNG,
	[ID_DON_VI_CHU_QUAN] = @ID_DON_VI_CHU_QUAN,
	[KHONG_KINH_DOANH] = @KHONG_KINH_DOANH,
	[CHUC_DANH_SU_DUNG] = @CHUC_DANH_SU_DUNG,
	[NGUON_GOC_XE] = @NGUON_GOC_XE,
	ID_TINH_TRANG = @ID_TINH_TRANG
WHERE
	[ID] = @ID

DECLARE @v_id_oto_history NUMERIC(18,0)
DECLARE @v_str_ghi_chu_lich_su NVARCHAR(250)

SET @v_str_ghi_chu_lich_su = N'Cập nhật thông tin ô to'

EXEC pr_DM_OTO_HISTORY_Insert
	@TEN_TAI_SAN ,
	@MA_TAI_SAN ,
	@ID_LOAI_TAI_SAN ,
	@NHAN_HIEU ,
	@NUOC_SAN_XUAT ,
	@BIEN_KIEM_SOAT ,
	@SO_CHO_NGOI ,
	@CONG_SUAT_XE ,
	@NAM_SAN_XUAT ,
	@NAM_SU_DUNG ,
	@NGUON_NS ,
	@NGUON_KHAC ,
	@GIA_TRI_CON_LAI ,
	@QLNN ,
	@KINH_DOANH ,
	@HD_KHAC ,
	@ID_TRANG_THAI ,
	@NGAY_CAP_NHAT_CUOI ,
	@ID_NGUOI_LAP ,
	@ID_NGUOI_DUYET ,
	@ID_DON_VI_SU_DUNG ,
	@ID_DON_VI_CHU_QUAN ,
	@KHONG_KINH_DOANH ,
	@CHUC_DANH_SU_DUNG ,
	@NGUON_GOC_XE ,
	@ID ,
	@v_str_ghi_chu_lich_su ,
	@ID_TINH_TRANG,
	@v_id_oto_history 

UPDATE GD_TANG_GIAM_TAI_SAN
SET
	-- ID = ? -- this column value is auto-generated,
	GIA_TRI_NGUYEN_GIA_TANG_GIAM = (@NGUON_NS + @NGUON_KHAC)
WHERE ID_TAI_SAN = @ID
AND ID_LOAI_TAI_SAN = @ID_LOAI_TAI_SAN

-- Sửa Proce Delete Tài sản khác --
GO
ALTER PROCEDURE [dbo].[pr_DM_TAI_SAN_KHAC_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_TAI_SAN_KHAC]
WHERE
	[ID] = @ID
DELETE FROM GD_KHAU_HAO
WHERE ID_TAI_SAN = @ID AND 
ID_LOAI_TAI_SAN IN (SELECT ID FROM DM_LOAI_TAI_SAN dlts WHERE dlts.ID_LOAI_TAI_SAN_PARENT = 4)

DELETE FROM GD_TANG_GIAM_TAI_SAN
WHERE ID_TAI_SAN = @ID AND
ID_LOAI_TAI_SAN IN (SELECT ID FROM DM_LOAI_TAI_SAN dlts WHERE dlts.ID_LOAI_TAI_SAN_PARENT = 4)

DELETE FROM DM_OTO_HISTORY
WHERE ID = @ID

-- Sửa Proce Update Tài sản khác --
GO

ALTER PROCEDURE [dbo].[pr_DM_TAI_SAN_KHAC_Update]
	@ID numeric(18, 0),
	@MA_TAI_SAN nvarchar(35),
	@TEN_TAI_SAN nvarchar(250),
	@KY_HIEU nvarchar(35),
	@ID_LOAI_TAI_SAN numeric(18, 0),
	@NUOC_SAN_XUAT nvarchar(50),
	@NAM_SAN_XUAT numeric(4, 0),
	@NAM_SU_DUNG numeric(4, 0),
	
	@NGUON_NS numeric(21, 3),
	@NGUON_KHAC numeric(21, 3),
	@GIA_TRI_CON_LAI numeric(21, 3),
	@QLNN numeric(4, 0),
	@KINH_DOANH numeric(4, 0),
	@KHONG_KINH_DOANH numeric(4, 0),
	@HD_KHAC numeric(4, 0),
	@ID_TRANG_THAI numeric(18, 0),
	@NGAY_CAP_NHAT_CUOI datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@ID_NGUOI_DUYET numeric(18, 0),
	@ID_DON_VI_SU_DUNG numeric(18, 0),
	@ID_DON_VI_CHU_QUAN numeric(18, 0),
	@ID_TINH_TRANG NUMERIC(18,0)
AS
UPDATE [dbo].[DM_TAI_SAN_KHAC]
SET 
	[MA_TAI_SAN] = @MA_TAI_SAN,
	[TEN_TAI_SAN] = @TEN_TAI_SAN,
	[KY_HIEU] = @KY_HIEU,
	[ID_LOAI_TAI_SAN] = @ID_LOAI_TAI_SAN,
	[NUOC_SAN_XUAT] = @NUOC_SAN_XUAT,
	[NAM_SAN_XUAT] = @NAM_SAN_XUAT,
	[NAM_SU_DUNG] = @NAM_SU_DUNG,
	
	[NGUON_NS] = @NGUON_NS,
	[NGUON_KHAC] = @NGUON_KHAC,
	[GIA_TRI_CON_LAI] = @GIA_TRI_CON_LAI,
	[QLNN] = @QLNN,
	[KINH_DOANH] = @KINH_DOANH,
	[KHONG_KINH_DOANH] = @KHONG_KINH_DOANH,
	[HD_KHAC] = @HD_KHAC,
	[ID_TRANG_THAI] = @ID_TRANG_THAI,
	[NGAY_CAP_NHAT_CUOI] = @NGAY_CAP_NHAT_CUOI,
	[ID_NGUOI_LAP] = @ID_NGUOI_LAP,
	[ID_NGUOI_DUYET] = @ID_NGUOI_DUYET,
	[ID_DON_VI_SU_DUNG] = @ID_DON_VI_SU_DUNG,
	[ID_DON_VI_CHU_QUAN] = @ID_DON_VI_CHU_QUAN,
	ID_TINH_TRANG = @ID_TINH_TRANG
WHERE
	[ID] = @ID



DECLARE @v_id_tai_san_khac_history NUMERIC(18,0)
DECLARE @v_str_ghi_chu_lich_su NVARCHAR(250)
SET @v_str_ghi_chu_lich_su = N'cập nhật thông tin tài sản khác'


EXEC pr_DM_TAI_SAN_KHAC_HISTORY_Insert
	@MA_TAI_SAN ,
	@TEN_TAI_SAN ,
	@KY_HIEU ,
	@ID_LOAI_TAI_SAN ,
	@NUOC_SAN_XUAT ,
	@NAM_SAN_XUAT ,
	@NAM_SU_DUNG ,
	@NGUON_NS ,
	@NGUON_KHAC ,
	@GIA_TRI_CON_LAI ,
	@QLNN ,
	@KINH_DOANH ,
	@KHONG_KINH_DOANH ,
	@HD_KHAC ,
	@ID_TRANG_THAI ,
	@NGAY_CAP_NHAT_CUOI ,
	@ID_NGUOI_LAP ,
	@ID_NGUOI_DUYET ,
	@ID_DON_VI_SU_DUNG ,
	@ID_DON_VI_CHU_QUAN ,
	@ID ,
	@v_str_ghi_chu_lich_su ,
	@ID_TINH_TRANG,
	@v_id_tai_san_khac_history 

UPDATE GD_TANG_GIAM_TAI_SAN
SET
	-- ID = ? -- this column value is auto-generated,
	GIA_TRI_NGUYEN_GIA_TANG_GIAM = (@NGUON_NS + @NGUON_KHAC)
WHERE ID_TAI_SAN = @ID
AND ID_LOAI_TAI_SAN = @ID_LOAI_TAI_SAN

-- Sửa Proce Delete Đất --
GO
ALTER PROCEDURE [dbo].[pr_DM_DAT_Delete]
	@ID numeric(18, 0)
AS
DELETE FROM [dbo].[DM_DAT]
WHERE
	[ID] = @ID
DELETE FROM DM_DAT_HISTORY
WHERE ID = @ID
DELETE FROM GD_KHAU_HAO
WHERE ID_TAI_SAN = @ID AND ID_LOAI_TAI_SAN = 1
DELETE FROM GD_TANG_GIAM_TAI_SAN
WHERE ID_TAI_SAN = @ID AND ID_LOAI_TAI_SAN = 1

EXEC pr_DM_NHA_Delete
	@ID

-- Sửa Proc Update Đất --
GO
ALTER PROCEDURE [dbo].[pr_DM_DAT_Update]
	@ID numeric(18, 0),
	@MA_TAI_SAN nvarchar(35),
	@ID_LOAI_TAI_SAN numeric(18, 0),
	@DIA_CHI nvarchar(250),
	@DT_KHUON_VIEN numeric(18, 2),
	@DT_TRU_SO_LAM_VIEC numeric(18, 2),
	@DT_CO_SO_HOAT_DONG_SU_NGHIEP numeric(18, 2),
	@DT_LAM_NHA_O numeric(18, 2),
	@DT_CHO_THUE numeric(18, 2),
	@DT_BO_TRONG numeric(18, 2),
	@DT_BI_LAN_CHIEM numeric(18, 2),
	@DT_SU_DUNG_MUC_DICH_KHAC numeric(18, 2),
	@GT_THEO_SO_KE_TOAN numeric(21, 3),
	@ID_TRANG_THAI numeric(18, 0),
	@NGAY_CAP_NHAT_CUOI datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@ID_NGUOI_DUYET numeric(18, 0),
	@ID_DON_VI_SU_DUNG numeric(18, 0),
	@ID_DON_VI_CHU_QUAN numeric(18, 0),
	@SO_NAM_DA_SU_DUNG numeric(4, 0),
	@ID_TINH_TRANG NUMERIC(18,0)
AS
UPDATE [dbo].[DM_DAT]
SET 
	[MA_TAI_SAN] = @MA_TAI_SAN,
	[ID_LOAI_TAI_SAN] = @ID_LOAI_TAI_SAN,
	[DIA_CHI] = @DIA_CHI,
	[DT_KHUON_VIEN] = @DT_KHUON_VIEN,
	[DT_TRU_SO_LAM_VIEC] = @DT_TRU_SO_LAM_VIEC,
	[DT_CO_SO_HOAT_DONG_SU_NGHIEP] = @DT_CO_SO_HOAT_DONG_SU_NGHIEP,
	[DT_LAM_NHA_O] = @DT_LAM_NHA_O,
	[DT_CHO_THUE] = @DT_CHO_THUE,
	[DT_BO_TRONG] = @DT_BO_TRONG,
	[DT_BI_LAN_CHIEM] = @DT_BI_LAN_CHIEM,
	[DT_SU_DUNG_MUC_DICH_KHAC] = @DT_SU_DUNG_MUC_DICH_KHAC,
	[GT_THEO_SO_KE_TOAN] = @GT_THEO_SO_KE_TOAN,
	[ID_TRANG_THAI] = @ID_TRANG_THAI,
	[NGAY_CAP_NHAT_CUOI] = @NGAY_CAP_NHAT_CUOI,
	[ID_NGUOI_LAP] = @ID_NGUOI_LAP,
	[ID_NGUOI_DUYET] = @ID_NGUOI_DUYET,
	[ID_DON_VI_SU_DUNG] = @ID_DON_VI_SU_DUNG,
	[ID_DON_VI_CHU_QUAN] = @ID_DON_VI_CHU_QUAN,
	[SO_NAM_DA_SU_DUNG] = @SO_NAM_DA_SU_DUNG,
	ID_TINH_TRANG = @ID_TINH_TRANG
WHERE
	[ID] = @ID


DECLARE @v_id_dat_history NUMERIC(18,0)
DECLARE @v_str_ghi_chu_lich_su NVARCHAR(250)

SET @v_str_ghi_chu_lich_su = N'Cập nhật thông tin đất'

EXEC pr_DM_DAT_HISTORY_Insert
	@MA_TAI_SAN ,
	@ID_LOAI_TAI_SAN ,
	@DIA_CHI ,
	@DT_KHUON_VIEN ,
	@DT_TRU_SO_LAM_VIEC ,
	@DT_CO_SO_HOAT_DONG_SU_NGHIEP,
	@DT_LAM_NHA_O ,
	@DT_CHO_THUE ,
	@DT_BO_TRONG ,
	@DT_BI_LAN_CHIEM ,
	@DT_SU_DUNG_MUC_DICH_KHAC ,
	@GT_THEO_SO_KE_TOAN ,
	@ID_TRANG_THAI ,
	@NGAY_CAP_NHAT_CUOI ,
	@ID_NGUOI_LAP ,
	@ID_NGUOI_DUYET ,
	@ID_DON_VI_SU_DUNG ,
	@ID_DON_VI_CHU_QUAN ,
	@SO_NAM_DA_SU_DUNG ,
	@ID ,
	@v_str_ghi_chu_lich_su ,
	@ID_TINH_TRANG,
	@v_id_dat_history 

UPDATE GD_TANG_GIAM_TAI_SAN
SET
	-- ID = ? -- this column value is auto-generated,
	GIA_TRI_NGUYEN_GIA_TANG_GIAM = (@GT_THEO_SO_KE_TOAN),
	DIEN_TICH = @DT_KHUON_VIEN
WHERE ID_TAI_SAN = @ID AND ID_LOAI_TAI_SAN = @ID_LOAI_TAI_SAN,
