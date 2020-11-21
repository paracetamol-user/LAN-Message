CREATE DATABASE LANCHAT
USE LANCHAT
DROP TABLE TINNHAN
drop table USERS
DROP DATABASE LANCHAT
CREATE TABLE USERS
(
	ID NVARCHAR (50) NOT NULL,
	TENTK nvarchar(50) not null,
	MATKHAU nvarchar(50) not null,
	HOTEN nvarchar(50),
	SDT nvarchar(20),
	NGAYSINH smalldatetime,
	GIOITINH bit,
	--1 là nam, 0 là nữ--
	TINHTRANG bit,
	--1 là on, 0 là off--
	CONSTRAINT USERS_ID_PR PRIMARY KEY (ID)
)
CREATE TABLE TINNHAN
(
	MATINNHAN nvarchar(50) not null,
	NGUOIGUI nvarchar(50) not null,
	NGUOINHAN nvarchar(50) not null,
	NOIDUNGTINNHAN nvarchar(MAX),
	THOIGIAN smalldatetime,
	
	CONSTRAINT TINNHAN_MTN_PR PRIMARY KEY (MATINNHAN),
	CONSTRAINT TINNHAN_NGUOIGUI_FK FOREIGN KEY (NGUOIGUI) REFERENCES USERS (ID),
	CONSTRAINT TINNHAN_NGUOINHAN_FK FOREIGN KEY (NGUOINHAN) REFERENCES USERS (ID)
)

-- KIỂM TRA TRÙNG TÊN TÀI KHOẢN --

Select Count(*) DEM 
FROM USERS
WHERE TENTK='NAM'

-- THEM TAI KHOAN --


Set dateformat dmy
insert into USERS values('1001','dat','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1023','nam','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1026','kiet','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1999','dang','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1255','badu','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1678','phuc','123',NULL,NULL,NULL,NULL,0)
insert into USERS values('1542','toan','123',NULL,NULL,NULL,NULL,0)
-- XOA TẤT CẢ TAI KHOAN --

DELETE FROM USERS

-- XOA 1 TAI KHOAN --

DELETE FROM USERS
WHERE TENTK='nam'
 
-- THÊM TIN NHẮN --

Set dateformat dmy
insert into TINNHAN values('2','NAM','TUAN',N'XIN CHÀO','14/1/2020')-- thêm N vào trước nội dung tin nhắn để định dạng tiếng việt--
SET dateformat dmy
insert into TINNHAN values('3','TUAN','NAM',N'CHÀO','14/1/2020')
SET dateformat dmy
insert into TINNHAN values('4','TUAN','NAM',N'CHăO','14/1/2020')
insert into TINNHAN values('-sadas-d-sdsa-d-sad-as','1001','7889',N'Z:\LAN - Message\Server\filedata\','1')
-- XÓA TIN NHẮN --

DELETE FROM TINNHAN
WHERE MATINNHAN='1'

-- TIỀM KIẾM TIN NHẮN THEO THỜI GIAN --

-- theo năm --

SELECT *
FROM TINNHAN
WHERE YEAR(THOIGIAN)=2020

-- theo thang --

SELECT *
FROM TINNHAN
WHERE MONTH(THOIGIAN)=1 AND YEAR(THOIGIAN)=2020

-- theo giờ --

SELECT *
FROM TINNHAN
WHERE DATEPART(HOUR,THOIGIAN)=0

-- TIEM KIEM TIN NHẮN THEO NOI DUNG(không dấu) --
drop FUNCTION [dbo].[removeMark]
CREATE FUNCTION [dbo].[removeMark] (@text nvarchar(max))
RETURNS nvarchar(max)
AS
begin
	SET @text = LOWER(@text)
	DECLARE @textLen int = LEN(@text)
	IF @textLen > 0
	BEGIN
		DECLARE @index int = 1
		Declare @new nvarchar(max)=''
		DECLARE @SIGN_CHARS nvarchar(100) = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýđð';
		DECLARE @UNSIGN_CHARS varchar(100) = 'aadeooua a a a a a a a a a a a a a a e e e e e eeeeeiiii iooooooooooooooouuuuuuuuuuyyyyydd';
		DECLARE @sign_chars_LEN int = LEN(@SIGN_CHARS)
		WHILE @index <= @textLen
		BEGIN
			
			DECLARE @tam int = ASCII(SUBSTRING(@text,@index,1));
			
			
			DECLARE @lPos int = 1
			
			WHILE @lPos <= @sign_chars_LEN
			
			BEGIN
				DECLARE @flag bit = 'false'
				DECLARE @tam1 int = ASCII(SUBSTRING(@SIGN_CHARS,@lPos,1));
				
				if @tam=@tam1
				begin
					
					if SUBSTRING(@UNSIGN_CHARS,@lPos,1)<>' '
						set @new=@new+SUBSTRING(@UNSIGN_CHARS,@lPos,1);
					set @flag='true'
					
					break;
				end
				
				set @lPos=@lPos+1;	
			
			
			END
			
			if @flag='false' 
			begin
				set @new=@new+SUBSTRING(@text,@index,1);
			end
			
			set @index=@index+1;	
			
			
		END
		set @text=@new;
		
	END
	return @text
end
SELECT MATINNHAN,NGUOIGUI ,NGUOINHAN,NOIDUNGTINNHAN,dbo.removeMark(NOIDUNGTINNHAN) as noidung_khongdau,THOIGIAN 
FROM TINNHAN

DECLARE @query NVARCHAR(100)
SET @query = N'%a%'
SELECT *
FROM TINNHAN
WHERE dbo.removeMark(NOIDUNGTINNHAN) LIKE @query or NOIDUNGTINNHAN like @query


-- Thêm cột Loại Tin nhắn
ALTER TABLE TINNHAN
ADD LOAI bit not null

ALTER TABLE TINNHAN
DROP COLUMN THOIGIAN