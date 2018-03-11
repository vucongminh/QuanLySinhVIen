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
