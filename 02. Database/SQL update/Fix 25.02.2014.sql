update dm_nha set TONG_DT_SAN_XD = 0 WHERE TONG_DT_SAN_XD IS NULL
GO
update dm_nha set NGUON_NS = 0 WHERE NGUON_NS IS NULL
GO
update dm_nha set NGUON_KHAC = 0 WHERE NGUON_KHAC IS NULL
GO
update dm_dat set DT_KHUON_VIEN = 0 WHERE DT_KHUON_VIEN IS NULL
GO
update dm_dat set GT_THEO_SO_KE_TOAN = 0 WHERE GT_THEO_SO_KE_TOAN IS NULL
GO
update dm_oto set NGUON_NS = 0 WHERE NGUON_NS IS NULL
GO
update dm_oto set NGUON_KHAC = 0 WHERE NGUON_KHAC IS NULL
