USE
-- Kê khai
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Trụ sở làm việc, cơ sở HĐSN'
WHERE ID = 156
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Xe ô tô' 
WHERE ID = 157
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'TS nguyên giá >=500 triệu'
WHERE ID = 158
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'TS nguyên giá < 500 triệu'
WHERE ID = 167
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Đất'
WHERE ID = 195
GO


-- Đề nghị xl ------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Trụ sở làm việc, cơ sở HĐSN'
WHERE ID = 122
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Xe ô tô'
WHERE ID = 127
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'TS nguyên giá >=500 triệu'
WHERE ID = 153
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Đất'
WHERE ID = 154
GO

-- Báo cáo tổng cục ------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Báo cáo của tổng cục'
WHERE ID = 115
GO

-- Thống kê -----------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Nhà'
WHERE ID = 177
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Xe ô tô' 
WHERE ID = 178
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'TS nguyên giá >=500 triệu'
WHERE ID = 179
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'TS nguyên giá < 500 triệu'
WHERE ID = 181
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Đất'
WHERE ID = 176
GO

-- Theo dõi ------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Trụ sở làm việc, cơ sở HĐSN'
WHERE ID = 137
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Xe ô tô'
WHERE ID = 138
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Tài sản khác'
WHERE ID = 139
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Đất'
WHERE ID = 136
GO

-- Linh tinh khác ------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Tình hình tăng, giảm tài sản'
WHERE ID = 163
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Hiện trạng sử dụng nhà, đất'
WHERE ID = 159
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Hiện trạng sử dụng tài sản khác'
WHERE ID = 183
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'Hiện trạng sử dụng ô tô'
WHERE ID = 189
GO

-- Tăng giảm --------------------------------------------------------
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	TEN_CHUC_NANG = N'3.1-Điều chuyển/Thanh lý tài sản'
WHERE ID = 196
GO
UPDATE HT_CHUC_NANG
SET
	-- ID = ? -- this column value is auto-generated,
	VI_TRI = 3800
WHERE ID = 108
GO
INSERT INTO HT_CHUC_NANG
(
	-- ID -- this column value is auto-generated,
	TEN_CHUC_NANG,
	URL_FORM,
	TRANG_THAI_YN,
	VI_TRI,
	CHUC_NANG_PARENT_ID,
	HIEN_THI_YN
)
VALUES
(
	N'3.2-Điều chuyển nội bộ',
	'#',
	'Y',
	3700,
	84,
	'Y'
)
GO
INSERT INTO HT_QUYEN_GROUP
(
	-- ID -- this column value is auto-generated,
	ID_USER_GROUP,
	ID_QUYEN
)
VALUES
(
	5,
	201
)
GO

-- Tạo điều chuyển nội bộ --
INSERT INTO HT_CHUC_NANG
(
	-- ID -- this column value is auto-generated,
	TEN_CHUC_NANG,
	URL_FORM,
	TRANG_THAI_YN,
	VI_TRI,
	CHUC_NANG_PARENT_ID,
	HIEN_THI_YN
)
VALUES
(
	N'Đất',
	'ChucNang/F111_DieuChuyenNoiBoDat.aspx',
	'Y',
	3810,
	201,
	'Y'
)
GO
INSERT INTO HT_CHUC_NANG
(
	-- ID -- this column value is auto-generated,
	TEN_CHUC_NANG,
	URL_FORM,
	TRANG_THAI_YN,
	VI_TRI,
	CHUC_NANG_PARENT_ID,
	HIEN_THI_YN
)
VALUES
(
	N'Nhà',
	'ChucNang/F110_DieuChuyenNoiBoNha.aspx',
	'Y',
	3820,
	201,
	'Y'
)
GO
INSERT INTO HT_CHUC_NANG
(
	-- ID -- this column value is auto-generated,
	TEN_CHUC_NANG,
	URL_FORM,
	TRANG_THAI_YN,
	VI_TRI,
	CHUC_NANG_PARENT_ID,
	HIEN_THI_YN
)
VALUES
(
	N'Ô tô',
	'ChucNang/F112_DieuChuyenNoiBoOto.aspx',
	'Y',
	3830,
	201,
	'Y'
)
GO
INSERT INTO HT_CHUC_NANG
(
	-- ID -- this column value is auto-generated,
	TEN_CHUC_NANG,
	URL_FORM,
	TRANG_THAI_YN,
	VI_TRI,
	CHUC_NANG_PARENT_ID,
	HIEN_THI_YN
)
VALUES
(
	N'Tài sản khác',
	'ChucNang/F113_DieuChuyenNoiBoTsk.aspx',
	'Y',
	3840,
	201,
	'Y'
)
GO
INSERT INTO HT_QUYEN_GROUP
(
	-- ID -- this column value is auto-generated,
	ID_USER_GROUP,
	ID_QUYEN
)
VALUES
(
	5,
	202
)
GO
INSERT INTO HT_QUYEN_GROUP
(
	-- ID -- this column value is auto-generated,
	ID_USER_GROUP,
	ID_QUYEN
)
VALUES
(
	5,
	203
)
GO
INSERT INTO HT_QUYEN_GROUP
(
	-- ID -- this column value is auto-generated,
	ID_USER_GROUP,
	ID_QUYEN
)
VALUES
(
	5,
	204
)
GO
INSERT INTO HT_QUYEN_GROUP
(
	-- ID -- this column value is auto-generated,
	ID_USER_GROUP,
	ID_QUYEN
)
VALUES
(
	5,
	205
)
GO

