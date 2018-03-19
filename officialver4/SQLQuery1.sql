SELECT MaHP,MaGV,DiaDiemTCHP,SoTC FROM LOPHOCPHAN WHERE MaLHP='LHP001'
SELECT MaLHP,LOPHOCPHAN.MaHP,TenHP,LOPHOCPHAN.SoTC,DiaDiemTCHP,TenGV FROM LOPHOCPHAN,HOCPHAN,GIAOVIEN where HOCPHAN.MaHP=LOPHOCPHAN.MaHP and LOPHOCPHAN.MaGV=GIAOVIEN.MaGV

CREATE PROCEDURE InsertDataIntoBoMon
@mabm nvarchar(50),
@tenbm nvarchar(80),
@machunhiembm varchar(50)
AS
BEGIN
INSERT INTO BOMON(MaBM, TenBM, MaChuNhiemBM) 
VALUES ( @mabm, @tenbm, @machunhiembm) 
END
drop proc InsertDataIntoBoMon


CREATE PROCEDURE InsertDataIntoLop
@malop nvarchar(50),
@tenlop nvarchar(80),
@maloptruong varchar(50),
@magvcn varchar(50)
AS
BEGIN
INSERT INTO LOP(MaLop, TenLop, MaLopTruong,MaGVCN) 
VALUES ( @malop, @tenlop, @maloptruong,@magvcn) 
END
drop proc InsertDataIntoLop

CREATE PROCEDURE InsertDataIntoHocPhan
@mahp nvarchar(50),
@tenhp nvarchar(50),
@sotc int,
@hocky int,
@mabm varchar(50)
AS
BEGIN
INSERT INTO HOCPHAN(MaHP,TenHP,SoTC,HocKy,MaBM)
VALUES ( @mahp, @tenhp, @sotc,@hocky,@mabm) 
END
drop proc InsertDataIntoHocPhan
CREATE PROCEDURE InsertDataIntoLopHocPhan
@malhp nvarchar(50),
@mahp varchar(50),
@magv varchar(50),
@diadiemtchp varchar(50),
@sotc int
AS
BEGIN
INSERT INTO LOPHOCPHAN(MaLHP, MaHP, MaGV,DiaDiemTCHP,SoTC) 
VALUES ( @malhp, @mahp, @magv,@diadiemtchp,@sotc) 
END

drop proc InsertDataIntoLopHocPhan
