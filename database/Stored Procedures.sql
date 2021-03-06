USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_BangKeChiTietNhap_Xuat]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BangKeChiTietNhap_Xuat]
@NGAYBD DATE,	--Lọc Chi tiết từ ngày
@NGAYKT DATE,	--Lọc Chi tiết đến ngày
@Permissions NVARCHAR(10),  --Quyền (CONGTY: lọc của cả 2 chi nhánh.  CHINHANH,USER: Lọc trên phân mảnh hiện hành)
@State NCHAR(4)				--Lọc chi tiết theo Phiếu Nhập or Phiếu Xuất (NHAP-XUAT)
AS 
BEGIN
	IF(@Permissions = 'CONGTY')
	BEGIN
		IF(@State = 'NHAP')
		BEGIN
			--Vì name của bảng tạm SQL sẽ định danh lại tên bảng tạm(tên user đặt + physical address)
			--nên nếu dùng OBJECT_ID sẽ không tìm được nên ở đây ta dùng LIKE và %(bỏ qua hậu tố physical address)
			IF EXISTS(SELECT *FROM tempdb.sys.tables		
						WHERE name LIKE '#PhieuNhapTemp1%') DROP TABLE #PhieuNhapTemp1

			SELECT PN.MAPN, PN.NGAY INTO #PhieuNhapTemp1
			FROM (
				SELECT PN_Current.MAPN, PN_Current.NGAY FROM dbo.PhieuNhap AS PN_Current
				UNION 
				SELECT PN_Other.MAPN, PN_Other.NGAY FROM LINK1.QLVT_DATHANG.dbo.PhieuNhap AS PN_Other
			) AS PN
			WHERE PN.NGAY BETWEEN @NGAYBD AND @NGAYKT

			SELECT 
			NGAYTHANG = FORMAT(PN.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPN.MAVT),
			TONGSOLUONG = SUM(CTPN.SOLUONG),
			TONGDONGIA = SUM(CTPN.DONGIA * CTPN.SOLUONG)-- Bẳng tổng của SLuong*DGia trên mỗi record
			FROM #PhieuNhapTemp1 AS PN
			INNER JOIN (
						SELECT * FROM dbo.CTPN
						UNION
						SELECT * FROM LINK1.QLVT_DATHANG.dbo.CTPN
						) AS CTPN
			ON CTPN.MAPN = PN.MAPN
			GROUP BY FORMAT(PN.NGAY, 'MM/yyyy'), CTPN.MAVT
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là String
		END
		ELSE IF(@State = 'XUAT')
		BEGIN
			IF EXISTS(SELECT *FROM tempdb.sys.tables		
						WHERE name LIKE '#PhieuXuatTemp1%') DROP TABLE #PhieuXuatTemp1

			SELECT PX.MAPX, PX.NGAY INTO #PhieuXuatTemp1
			FROM (
				SELECT PX_Current.MAPX, PX_Current.NGAY FROM dbo.PhieuXuat AS PX_Current
				UNION 
				SELECT PX_Other.MAPX, PX_Other.NGAY FROM LINK1.QLVT_DATHANG.dbo.PhieuXuat AS PX_Other
			) AS PX
			WHERE PX.NGAY BETWEEN @NGAYBD AND @NGAYKT
		
			SELECT 
			NGAYTHANG = FORMAT(PX.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPX.MAVT),
			TONGSOLUONG = SUM(CTPX.SOLUONG),
			TONGDONGIA = SUM(CTPX.DONGIA * CTPX.SOLUONG) -- The Sum of SOLUONG*DONGIA on each record
			FROM #PhieuXuatTemp1 AS PX
			INNER JOIN (
						SELECT * FROM dbo.CTPX
						UNION
						SELECT * FROM LINK1.QLVT_DATHANG.dbo.CTPX
						) AS CTPX
			ON CTPX.MAPX = PX.MAPX
			GROUP BY FORMAT(PX.NGAY, 'MM/yyyy'), CTPX.MAVT
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là String
		END
	END
	ELSE --In case: permissions is CHINHANH or USER
	BEGIN
		IF(@State = 'NHAP')
		BEGIN
			--Vì name của bảng tạm SQL sẽ định danh lại tên bảng tạm(tên user đặt + physical address)
			--nên nếu dùng OBJECT_ID sẽ không tìm được nên ở đây ta dùng LIKE và %(bỏ qua hậu tố physical address)
			IF EXISTS(SELECT *FROM tempdb.sys.tables		
						WHERE name LIKE '#PhieuNhapTemp2%') DROP TABLE #PhieuNhapTemp2
			SELECT MAPN, NGAY INTO #PhieuNhapTemp2 FROM dbo.PhieuNhap	
			WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT

			SELECT 
			NGAYTHANG = FORMAT(PN.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPN.MAVT),
			TONGSOLUONG = SUM(CTPN.SOLUONG),
			TONGDONGIA = SUM(CTPN.DONGIA * CTPN.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
			FROM #PhieuNhapTemp2 AS PN
			INNER JOIN dbo.CTPN AS CTPN
			ON CTPN.MAPN = PN.MAPN
			GROUP BY FORMAT(PN.NGAY, 'MM/yyyy'), CTPN.MAVT	
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là String
		END
		ELSE IF(@State = 'XUAT')
		BEGIN
			IF EXISTS(SELECT *FROM tempdb.sys.tables		
						WHERE name LIKE '#PhieuXuatTemp2%') DROP TABLE #PhieuXuatTemp2
			SELECT MAPX, NGAY INTO #PhieuXuatTemp2 FROM dbo.PhieuXuat
			WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT

			SELECT 
			NGAYTHANG = FORMAT(PX.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPX.MAVT),
			TONGSOLUONG = SUM(CTPX.SOLUONG),
			TONGDONGIA = SUM(CTPX.DONGIA * CTPX.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
			FROM #PhieuXuatTemp2 AS PX
			INNER JOIN dbo.CTPX AS CTPX
			ON CTPX.MAPX = PX.MAPX
			GROUP BY FORMAT(PX.NGAY, 'MM/yyyy'), CTPX.MAVT	
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là String
		END
	END
END


GO
/****** Object:  StoredProcedure [dbo].[SP_CheckID]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CheckID]
@Code NVARCHAR(10),
@Type NVARCHAR(15)
AS
BEGIN
	--Kiểm tra Table NhanVien của server hiện tại
	IF(@Type = 'MANV')
	BEGIN
		 IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.NhanVien AS NV WHERE NV.MANV = CONVERT(INT, @Code))
			RETURN 1;	--Mã NV tồn tại 
	END
	ELSE IF(@Type = 'MAVT')
	BEGIN
		IF EXISTS(SELECT *FROM dbo.Vattu WHERE dbo.Vattu.MAVT = @Code)
			RETURN 1;    --Mã VT tồn tại ở chi nhánh hiện tại
	END
	ELSE IF(@Type = 'MAKHO')
	BEGIN
	 IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.Kho AS KHO WHERE KHO.MAKHO = @Code)
			RETURN 1	--Mã KHO tồn tại
	END
	ELSE IF(@Type = 'TENKHO')
	BEGIN
		 IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.Kho AS KHO WHERE KHO.TENKHO = @Code)
			RETURN 1	--Tên KHO tồn tại 
	END
	ELSE IF(@Type = 'MADDH')
	BEGIN
		IF EXISTS(SELECT *FROM dbo.DatHang WHERE dbo.DatHang.MasoDDH = @Code)
			RETURN 1	--Tên Mã DDH đã tồn tại ở chi nhánh hiện tại
		ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.DatHang AS DDH WHERE DDH.MasoDDH = @Code)
			RETURN 2	--Tên Mã DDH tồn tại ở chi nhánh khác
	END
	ELSE IF(@Type = 'MAPN')
	BEGIN
		IF EXISTS(SELECT *FROM dbo.PhieuNhap WHERE dbo.PhieuNhap.MAPN = @Code)
			RETURN 1	--Tên Mã Phiếu Nhập đã tồn tại ở chi nhánh hiện tại
		ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.PhieuNhap AS PN WHERE PN.MAPN = @Code)
			RETURN 2	--Tên Mã Phiếu Nhập tồn tại ở chi nhánh khác
	END
	ELSE IF(@Type = 'MAPX')
	BEGIN
		IF EXISTS(SELECT *FROM dbo.PhieuXuat WHERE dbo.PhieuXuat.MAPX = @Code)
			RETURN 1	--Tên Mã Phiếu Xuất đã tồn tại ở chi nhánh hiện tại
		ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.PhieuXuat AS PX WHERE PX.MAPX = @Code)
			RETURN 2	--Tên Mã Phiếu Xuất tồn tại ở chi nhánh khác
	END
	ELSE IF(@Type = 'MANV_EXIST')
	BEGIN
		IF EXISTS(
			SELECT * FROM
			(	SELECT DH.MANV FROM dbo.DatHang AS DH
				UNION 
				SELECT PN.MANV FROM dbo.PhieuNhap AS PN
				UNION
				SELECT PX.MANV FROM dbo.PhieuXuat AS PX
			) AS NV WHERE NV.MANV = CONVERT(INT, @Code)
		)
		RETURN 1	--Tồn tại MANV ít nhất trong các bảng
	END
	ELSE IF(@Type = 'MAVT_EXIST')
	BEGIN
		IF EXISTS(
			SELECT * FROM
			(	SELECT MAVT FROM dbo.CTDDH
				UNION
				SELECT MAVT FROM LINK1.QLVT_DATHANG.dbo.CTDDH
				UNION
				SELECT MAVT FROM dbo.CTPN
				UNION
				SELECT MAVT FROM LINK1.QLVT_DATHANG.dbo.CTPN
				UNION
				SELECT MAVT FROM dbo.CTPX
				UNION
				SELECT MAVT FROM LINK1.QLVT_DATHANG.dbo.CTPX
			) AS VT WHERE VT.MAVT = @Code
		)
		RETURN 1	--Tồn tại MAVT ít nhất trong các bảng
	END
	ELSE IF(@Type = 'MAKHO_EXIST')
	BEGIN
		IF EXISTS(
			SELECT * FROM
			(	SELECT MAKHO FROM dbo.DatHang
				UNION
				SELECT MAKHO FROM dbo.PhieuXuat
			) AS KHO WHERE KHO.MAKHO = @Code
		)
		RETURN 1	--Tồn tại MAKHO ít nhất trong các bảng
	END
	RETURN 0	--Không bị trùng được thêm
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CheckLogin]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CheckLogin]
  @LOGIN VARCHAR(50),
  @USER VARCHAR(50)
AS
BEGIN
	IF EXISTS(SELECT name FROM sys.server_principals 
				WHERE TYPE IN ('U', 'S', 'G')	--U: Windows Login Accounts
				AND name NOT LIKE '%##%'		--S: SQL Login Accounts
				AND name = @LOGIN)				--G: Windows Group Login Accounts
		RETURN 1	--Trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USER)
		RETURN 2	--Trùng User
	RETURN 0		--Không trùng
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenCN]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChuyenCN]
@MANV INT, @NEWID INT
AS
BEGIN
--Vì name của bảng tạm SQL sẽ định danh lại tên bảng tạm(tên user đặt + physical address)
--nên nếu dùng OBJECT_ID sẽ không tìm được nên ở đây ta dùng LIKE và %(bỏ qua hậu tố physical address)
IF EXISTS(SELECT *FROM tempdb.sys.tables		
			WHERE name LIKE '#NhanVienTemp%') DROP TABLE #NhanVienTemp

--Giải quyết vấn đề Nhân viên chuyển đi xong rồi lại chuyển về thì phải ghi đè lên lại chứ không tạo mới MANV
SELECT HO, TEN, NGAYSINH 
INTO #NhanVienTemp	--Bảng tạm chứa 3 trường ở Server hiện tại để dò với các record Server khác
FROM dbo.NhanVien
WHERE MANV = @MANV

IF EXISTS(
	SELECT NV1.*
	FROM LINK1.QLVT_DATHANG.dbo.NhanVien AS NV1
	INNER JOIN #NhanVienTemp AS NV2 
	ON NV1.HO = NV2.HO 
	AND NV2.TEN = NV1.TEN 
	AND NV2.NGAYSINH = NV1.NGAYSINH
	WHERE NV1.TrangThaiXoa = 1
)
BEGIN
	RETURN -2
END
ELSE
BEGIN
	DECLARE @RET INT
	EXEC @RET= SP_NewChuyenCN @MANV, @NEWID
	IF (@RET = 0)   -- Thành công
	BEGIN
		EXEC @RET = SP_DeleteLogin @MANV
		IF(@RET = 1) RETURN -3	--Xóa Login không thành công
		IF(@RET = 2) RETURN -4	--Xóa User không thành công
		RETURN 0	--Thành công
	END
	
	IF (@RET = -1)  -- Thất bại
     RETURN -1
END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachDDHChuaLapPN]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DanhSachDDHChuaLapPN]
AS 
BEGIN
	SELECT DH.MasoDDH, DH.NGAY,DH.NhaCC,
	HOTENNV = (SELECT CONCAT(HO, ' ', TEN) FROM dbo.NhanVien WHERE MANV = DH.MANV), 
	TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CT.MAVT), 
	CT.SOLUONG, CT.DONGIA 
	FROM dbo.CTDDH AS CT
	INNER JOIN(
		SELECT MasoDDH, NGAY, NhaCC, MANV FROM dbo.DatHang
		WHERE MasoDDH NOT IN( SELECT MasoDDH 
							  FROM dbo.PhieuNhap)
	) AS DH
	ON DH.MasoDDH = CT.MasoDDH
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachNhanVien]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DanhSachNhanVien]
AS
BEGIN
SELECT MANV, CONCAT(HO,' ',TEN) AS HOTEN, DIACHI, NGAYSINH, LUONG, MACN FROM dbo.NhanVien 
WHERE TrangThaiXoa = 0
ORDER BY TEN, HO ASC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachVatTu]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DanhSachVatTu]
AS
BEGIN
SELECT MAVT, TENVT, DVT, SOLUONGTON FROM dbo.Vattu
ORDER BY TENVT
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteLogin]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteLogin]
@MANV INT
AS
BEGIN 
	DECLARE @USERNAME VARCHAR(10)
	DECLARE @LOGINNAME VARCHAR(30)
	DECLARE @RET INT

	SELECT @USERNAME = users.name, @LOGINNAME = logins.name 
	FROM sys.database_principals AS users
	INNER JOIN sys.server_principals AS logins
	ON logins.sid = users.sid
	WHERE users.name = CONVERT(NVARCHAR(10), @MANV)

	IF(@@ROWCOUNT <> 0)
	BEGIN
		EXEC @RET = SP_DROPLOGIN @LOGINNAME	
		IF(@RET = 1) RETURN 1

		EXEC @RET = SP_DROPUSER  @USERNAME
		IF(@RET = 1) RETURN 2
	END
	RETURN 0 --Thành công
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteNV]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteNV]
@MANV INT
AS
BEGIN
	DECLARE @RET INT

	UPDATE dbo.NhanVien		
	SET TrangThaiXoa = 1
	WHERE MANV = @MANV

	EXEC @RET = SP_DeleteLogin @MANV
	IF(@RET = 1)
	BEGIN
		UPDATE dbo.NhanVien				--Rollback thủ công nếu như tài khoản đang được logged in
		SET TrangThaiXoa = 0
		WHERE MANV = @MANV
		RETURN 1	--Xóa Login không thành công
	END
	ELSE IF(@RET = 2)
	BEGIN
		UPDATE dbo.NhanVien			
		SET TrangThaiXoa = 0
		WHERE MANV = @MANV
		RETURN 2	--Xóa User không thành công
	END
	RETURN 0	--Thành công
END


GO
/****** Object:  StoredProcedure [dbo].[SP_HoatDongNhanVien]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HoatDongNhanVien]
@MANV INT,			--Hoạt động của nhân viên
@NGAYBD DATE,		--Lọc chi tiết hoạt động từ ngày
@NGAYKT DATE,		--Lọc chi tiết hoạt động đến ngày
@State NVARCHAR(4)	--Lọc chi tiết theo Phiếu Nhập or Phiếu Xuất (NHAP-XUAT)
AS
BEGIN
	IF(@State = 'NHAP')
	BEGIN
		SELECT
		FORMAT(PN.NGAY,'MMMM yyyy') AS THANGNAM, --Để vào C# Group theo tháng/n
		PN.NGAY,
		CTPN.MAPN AS MAPHIEU,  --Đồng bộ cột khi SP chứa 2 câu query 2 cột MAPN,PAPX khác nhau
		N'Không có thông tin' AS HOTENKH,	   --Vì ở Phiếu Nhập ko có KH nên thêm cột giả như ở PX
		TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT		 --Từ MAVT lọc ra được tên TENVT
				WHERE VT.MAVT = CTPN.MAVT),
		TENKHO = (SELECT 
					  (SELECT KHO.TENKHO FROM dbo.Kho AS KHO --Từ MAKHO lọc ra được TENKHO
					   WHERE KHO.MAKHO = DDH.MAKHO) 
				  FROM dbo.DatHang AS DDH					 --Từ MasoDDH lọc ra được MAKHO
				  WHERE DDH.MasoDDH = PN.MasoDDH),
		CTPN.SOLUONG,
		CTPN.DONGIA,
		THANHTIEN = (CTPN.SOLUONG*CTPN.DONGIA)
		FROM dbo.CTPN AS CTPN
		INNER JOIN 
			(SELECT *		--Lọc các PN thỏa MANV và thời gian trước
			 FROM dbo.PhieuNhap
			 WHERE MANV = @MANV 
			 AND (NGAY BETWEEN @NGAYBD AND @NGAYKT)) AS PN
		ON PN.MAPN = CTPN.MAPN
	END
	ELSE IF(@State = 'XUAT')
	BEGIN
		SELECT
		FORMAT(PX.NGAY,'MMMM yyyy') AS THANGNAM, 
		PX.NGAY,
		CTPX.MAPX AS MAPHIEU,
		PX.HOTENKH,
		TENVT  = (SELECT VT.TENVT FROM dbo.Vattu AS VT
				  WHERE VT.MAVT = CTPX.MAVT),
		TENKHO = (SELECT  KHO.TENKHO FROM dbo.Kho AS KHO
					WHERE KHO.MAKHO = PX.MAKHO),
		CTPX.SOLUONG,
		CTPX.DONGIA,
		THANHTIEN = (CTPX.SOLUONG*CTPX.DONGIA)
		FROM dbo.CTPX AS CTPX
		INNER JOIN
			(SELECT *		--Lọc các PN thỏa MANV và thời gian trước
			FROM dbo.PhieuXuat
			WHERE MANV = @MANV 
			AND (NGAY BETWEEN @NGAYBD AND @NGAYKT)) AS PX
		ON PX.MAPX = CTPX.MAPX
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_InfoNV]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InfoNV]
@MANV INT
AS
BEGIN
	SELECT MANV, CONCAT(HO, ' ', TEN) AS HOTEN, NGAYSINH, DIACHI, LUONG, MACN
	FROM dbo.NhanVien 
	WHERE MANV = @MANV
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ListNVTrungChuyenChiNhanh]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListNVTrungChuyenChiNhanh]
@MANV INT
AS
BEGIN
	SELECT NV1.* FROM LINK1.QLVT_DATHANG.dbo.NhanVien AS NV1
	INNER JOIN (SELECT *FROM dbo.NhanVien
				WHERE MANV = @MANV) AS NV2
	ON NV2.HO = NV1.HO 
	AND NV2.TEN = NV1.TEN 
	AND NV2.NGAYSINH = NV1.NGAYSINH
	WHERE NV1.TrangThaiXoa = 1
END

GO
/****** Object:  StoredProcedure [dbo].[SP_NewChuyenCN]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NewChuyenCN]
@MANV INT, @NEWID INT
AS
BEGIN
	SET XACT_ABORT ON
	BEGIN DISTRIBUTED TRANSACTION
		DECLARE @MACN NCHAR(10)				--Tìm MACN ở bên Server mới để chuẩn bị thêm dữ liệu vào
		SELECT TOP 1 @MACN = MACN FROM LINK1.QLVT_DATHANG.dbo.ChiNhanh

		INSERT INTO LINK1.QLVT_DATHANG.dbo.NhanVien(MANV,HO,TEN,DIACHI,NGAYSINH,LUONG,MACN,TrangThaiXoa)
		SELECT @NEWID AS MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, @MACN AS MACN, 0 
		FROM dbo.NhanVien 
		WHERE MANV = @MANV

		UPDATE dbo.NhanVien					--Cập nhật lại Trạng thái xóa tại chi nhánh cũ
		SET TrangThaiXoa = 1
		WHERE MANV = @MANV 
		COMMIT TRANSACTION
		PRINT 'Commit Success'
		RETURN 0
		IF(@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRAN
			PRINT 'Commit Failure'
			RETURN -1	--Thất bại
		END

END

GO
/****** Object:  StoredProcedure [dbo].[SP_Pseudocode_BangKeChiTietNhap_Xuat]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CReate PROCEDURE [dbo].[SP_Pseudocode_BangKeChiTietNhap_Xuat]
@NGAYBD DATE,	--Lọc Chi tiết từ ngày
@NGAYKT DATE,	--Lọc Chi tiết đến ngày
@Permissions NVARCHAR(10),  --Quyền (CONGTY: lọc của cả 2 chi nhánh.  CHINHANH,USER: Lọc trên phân mảnh hiện hành)
@State NCHAR(4)				--Lọc chi tiết theo Phiếu Nhập or Phiếu Xuất (NHAP-XUAT)
AS
BEGIN
	SELECT 
	NGAYTHANG = '',
	TENVT = '',
	TONGSOLUONG = '',
	TONGDONGIA = ''
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLVT_DATHANG'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'CONGTY' OR @ROLE= 'CHINHANH'
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[SP_THONGTINDANGNHAP]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONGTINDANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_TongHopNhapXuat]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TongHopNhapXuat]
@NGAYBD DATE, @NGAYKT DATE
AS
BEGIN
	SET NOCOUNT ON;
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END
	--Nếu Bảng tạm đã tồn tại thì xóa bảng tạm đó đi
	IF EXISTS(SELECT *FROM tempdb.sys.tables		
				WHERE name LIKE '#PNTemp%') DROP TABLE #PNTemp
	IF EXISTS(SELECT *FROM tempdb.sys.tables		
				WHERE name LIKE '#PXTemp%') DROP TABLE #PXTemp

	--Lưu danh sách Phiếu Nhập, Phiếu Xuất trong khoảng thời gian vào Bảng tạm
	SELECT PN.MAPN, PN.NGAY INTO #PNTemp
	FROM dbo.PhieuNhap AS PN
	WHERE PN.NGAY BETWEEN @NGAYBD AND @NGAYKT

	SELECT PX.MAPX, PX.NGAY INTO #PXTemp
	FROM dbo.PhieuXuat AS PX
	WHERE PX.NGAY BETWEEN @NGAYBD AND @NGAYKT

	--Lấy ra được danh sách Ngày - Nhập - Xuất lưu vào Bảng tạm
	SELECT 
	ISNULL(NHAP.NGAY, XUAT.NGAY) AS NGAY, 
	ISNULL(NHAP.TONGTIEN, 0) AS NHAP , 
	ISNULL(XUAT.TONGTIEN, 0) AS XUAT 
	FROM
	(
		SELECT PN.NGAY, SUM(SOLUONG*DONGIA) AS TONGTIEN FROM #PNTemp AS PN
		INNER JOIN dbo.CTPN
		ON CTPN.MAPN = PN.MAPN
		GROUP BY PN.NGAY
	) AS NHAP
	FULL JOIN
	(
		SELECT PX.NGAY, SUM(SOLUONG*DONGIA) AS TONGTIEN FROM #PXTemp AS PX
		INNER JOIN dbo.CTPX
		ON CTPX.MAPX = PX.MAPX
		GROUP BY PX.NGAY
	) AS XUAT
	ON XUAT.NGAY = NHAP.NGAY
END



GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateChuyenCN]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateChuyenCN]
@CURRENT_MANV INT, @ORTHER_MANV INT
AS
BEGIN
	SET XACT_ABORT ON
		BEGIN DISTRIBUTED TRANSACTION
		UPDATE LINK1.QLVT_DATHANG.dbo.NhanVien		
		SET TrangThaiXoa = 0
		WHERE MANV = @ORTHER_MANV
		UPDATE dbo.NhanVien
		SET TrangThaiXoa = 1
		WHERE MANV = @CURRENT_MANV

		COMMIT TRANSACTION
		PRINT 'Commit Success'
		RETURN 0
	IF(@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRAN
			PRINT 'Commit Failure'
			RETURN -1	--Thất bại
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateVatTu]    Script Date: 3/1/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateVatTu]
@MAVT NCHAR(4), 
@SOLUONG INT , 
@State NVARCHAR(10)
AS
BEGIN
	BEGIN TRY
		IF(@State = 'INCREASE')
		BEGIN
			UPDATE dbo.Vattu SET SOLUONGTON += @SOLUONG
			WHERE MAVT = @MAVT
			RETURN 1	--Thành công
		END
		ELSE IF(@State = 'DECREASE')
		BEGIN
			UPDATE dbo.Vattu SET SOLUONGTON -= @SOLUONG
			WHERE MAVT = @MAVT
			RETURN 1	--Thành công
		END
		END TRY
	BEGIN CATCH
		RETURN 0	--Thất bại
	END CATCH
END

GO
