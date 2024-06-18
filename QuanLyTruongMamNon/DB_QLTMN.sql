USE MASTER
CREATE DATABASE TRUONGMAMNON

USE TRUONGMAMNON

CREATE TABLE CLASSES
(
	yearSchool				varchar(9),
	className				nvarchar(25),
	teacher					varchar(8),
	wholesale				int,

	PRIMARY KEY(yearSchool, className)
)


CREATE TABLE STAFFS 
(
	idStaff					varchar(8),
	nameStaff				nvarchar(25),
	gender					bit,
	dateBirth				date,
	placeBirth				nvarchar(25),
	nation					nvarchar(25),
	nationality				nvarchar(25),
	idCityzen				nvarchar(12),
	licenseDate				date,
	licensePlace			nvarchar(25),
	address_cur				nvarchar(50),
	province_cur			nvarchar(25),
	district_cur			nvarchar(25),
	commune_cur				nvarchar(25),
	address_res				nvarchar(50),
	province_res			nvarchar(25),
	district_res			nvarchar(25),
	commune_res				nvarchar(25),
	roled					nvarchar(25),
	actived					bit,
	phone					nvarchar(10),
	email					varchar(50),
	pwd						varchar(255)	DEFAULT 'Abc@123',

	PRIMARY KEY(idStaff)
)


CREATE TABLE STUDENTS
(
	idStudent				varchar(8),
	nameStudent				nvarchar(25),
	gender					bit,
	dateBirth				date,
	placeBirth				nvarchar(25),
	nation					nvarchar(25),
	nationality				nvarchar(25),
	address_cur				nvarchar(50),
	province_cur			nvarchar(25),
	district_cur			nvarchar(25),
	commune_cur				nvarchar(25),
	address_res				nvarchar(50),
	province_res			nvarchar(25),
	district_res			nvarchar(25),
	commune_res				nvarchar(25),
	yearSchool				varchar(9),
	class					nvarchar(25),
	actived					bit,

	PRIMARY KEY(idStudent)
)

CREATE TABLE RELATIVES
(
	idRelative				varchar(8),
	nameRelative			nvarchar(25),
	phone					nvarchar(10),
	yearBorn				nvarchar(4),

	PRIMARY KEY(idRelative) 
)


CREATE TABLE RELATIVED
(
	idRelative				varchar(8),
	idstudent				varchar(8),
	relationship			nvarchar(25)

	PRIMARY KEY(idRelative, idstudent)
)


CREATE TABLE ATTENDANCES
(
	idStudent			varchar(8),
	dateAttend			date,
	PRIMARY KEY(idStudent, dateAttend)
)

CREATE TABLE ACHIEVEMENTS
(
	idStudent			varchar(8),
	dateAchived			date,
	achievement			nvarchar(50),

)

CREATE TABLE TRANSACTIONS
(
	idTransaction			varchar(8),
	classify				nvarchar(25),
	amountMoney				int,

	PRIMARY KEY(idTransaction)
)


CREATE TABLE FEES
(
	idTransaction			varchar(8),
	idStudent				varchar(8),
	collected				bit,

	PRIMARY KEY(idTransaction, idStudent)
)

CREATE TABLE EXPENSES
(
	idTransaction			varchar(8),
	receiver				nvarchar(25),
	addressReceiver			nvarchar(100),
	reason					nvarchar(100),

	PRIMARY KEY(idTransaction)
)


CREATE TABLE SERVICES
(
	idTransaction			varchar(8),
	idStudent				varchar(8),
	uniform					int,
	lunch1					bit,
	lunch2					bit,
	healthnsurance			bit,
	accidentinsurance		bit,

	PRIMARY KEY(idTransaction, idStudent)
)


CREATE TABLE MENUS
(
	dateMenu				date,
	idFood1					varchar(4),
	idFood2					varchar(4),
	idFood3					varchar(4),
	amountNutrition			int,

	PRIMARY KEY(dateMenu)
)

CREATE TABLE FOODS
(
	idFood					varchar(4),
	nameFood				nvarchar(25),
	nutrition				int,

	PRIMARY KEY(idFood)
)


CREATE TABLE NOTICATION
(
	idNotication			varchar(8),
	dateNotication			date,
	title					nvarchar(25),
	content					nvarchar(500),

	PRIMARY KEY(idNotication)
)

CREATE TABLE NOTICATION_STAFF
(
	idNotication			varchar(8),
	idStaff					varchar(8),
	seen					bit,

	PRIMARY KEY(idNotication , idStaff)
)

ALTER TABLE NOTICATION_STAFF
ADD CONSTRAINT NO_NO_idNotication
FOREIGN KEY (idNotication) REFERENCES NOTICATION(idNotication) ON DELETE CASCADE

ALTER TABLE NOTICATION_STAFF
ADD CONSTRAINT NO_ST_idStaff
FOREIGN KEY (idStaff) REFERENCES STAFFS(idStaff) ON DELETE CASCADE


ALTER TABLE RELATIVED
ADD CONSTRAINT RE_RE_idRelative
FOREIGN KEY (idRelative) REFERENCES RELATIVES(idRelative)


ALTER TABLE RELATIVED
ADD CONSTRAINT RE_ST_idStudent
FOREIGN KEY (idStudent) REFERENCES STUDENTS(idStudent)


ALTER TABLE ACHIEVEMENTS
ADD CONSTRAINT AC_ST_idStudent
FOREIGN KEY (idStudent) REFERENCES STUDENTS(idStudent)


ALTER TABLE STUDENTS
ADD CONSTRAINT ST_CL_yearSchool
FOREIGN KEY (yearSchool, class) REFERENCES CLASSES(yearSchool, className)


ALTER TABLE CLASSES
ADD CONSTRAINT CL_ST_idStaff
FOREIGN KEY (teacher) REFERENCES STAFFS(idStaff)


ALTER TABLE SERVICES
ADD CONSTRAINT SE_ST_idStudent
FOREIGN KEY (idStudent) REFERENCES STUDENTS(idStudent)

ALTER TABLE SERVICES
ADD CONSTRAINT SE_TR_idTransaction
FOREIGN KEY (idTransaction) REFERENCES TRANSACTIONS(idTransaction)

ALTER TABLE FEES
ADD CONSTRAINT FE_ST_idStudent
FOREIGN KEY (idStudent) REFERENCES STUDENTS(idStudent)

ALTER TABLE FEES
ADD CONSTRAINT FE_TR_idTransaction
FOREIGN KEY (idTransaction) REFERENCES TRANSACTIONS(idTransaction)

ALTER TABLE EXPENSES
ADD CONSTRAINT EX_TR_idTransaction
FOREIGN KEY (idTransaction) REFERENCES TRANSACTIONS(idTransaction)

ALTER TABLE MENUS
ADD CONSTRAINT ME_FO_idFood1
FOREIGN KEY (idFood1) REFERENCES FOODS(idFood)

ALTER TABLE MENUS
ADD CONSTRAINT ME_FO_idFood2
FOREIGN KEY (idFood2) REFERENCES FOODS(idFood)

ALTER TABLE MENUS
ADD CONSTRAINT ME_FO_idFood3
FOREIGN KEY (idFood3) REFERENCES FOODS(idFood)


--Thêm thông tin vào bảng STAFFS
INSERT INTO STAFFS (idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email)
VALUES 
	('Unsigned', 'Giáo viên Không', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	('admin', N'Admin', 1, '1990-01-01', N'Kiên Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Ban giám hiệu', 1, '0123456789', 'gv001@example.com'),
	('GH000001', N'Ban giám hiệu', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Ban giám hiệu', 1, '0123456789', 'gv002@example.com'),
	('NV000001', N'Nhân viên 1', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Văn phòng', 1, '0123456789', 'gv002@example.com'),
	('NV000002', N'Nhân viên 2', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Văn phòng', 1, '0123456789', 'gv002@example.com'),
	('KT000001', N'Kế toán 1', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Kế toán', 1, '0123456789', 'gv002@example.com'),
	('DB000001', N'Đứng bếp', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Đứng bếp', 1, '0123456789', 'gv002@example.com'),
	('GV000001', N'Văn phòng', 1, '1990-01-01', N'Tiền Giang', N'Việt Nam', N'Việt Nam', '0123456789', '2010-01-01', N'Kiên Giang', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'KP Vĩnh Phước 2', N'Kiên Giang', N'Vĩnh Thuận', N'Vĩnh Thuận', N'Văn phòng', 1, '0123456789', 'gv002@example.com');


--Thêm thông tin vào bảng CLASSES
INSERT INTO CLASSES (yearSchool, className, teacher, wholesale)
VALUES ('2022-2023', N'Mầm 1', N'NV000001', 30),
       ('2022-2023', N'Mầm 2', N'NV000001', 30);


--Thêm thông tin vào bảng STUDENTS
INSERT INTO STUDENTS (idStudent, nameStudent, gender, dateBirth, placeBirth, nation, nationality, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, yearSchool, class, actived)
VALUES ('22230001', N'Nguyễn Văn A', 1, '2010-01-01', N'Hà Nội', N'Việt Nam', N'Việt Nam', N'19 Nguyễn Hữu Thọ', N'TP. Hồ Chí Minh', N'Quận 7', N'Phường Tân Phong', N'20 Nguyễn Hữu Thọ', N'TP. Hồ Chí Minh', N'Quận 7', N'Tân Phong', '2022-2023', N'Mầm 1', 1),
       ('22230002', N'Trần Thị B', 0, '2010-01-01', N'Hà Nội', N'Việt Nam', N'Việt Nam', N'19 Nguyễn Hữu Thọ', N'TP. Hồ Chí Minh', N'Quận 7', N'Phường Tân Phong', N'20 Nguyễn Hữu Thọ', N'TP. Hồ Chí Minh', N'Quận 7', N'Tân Phong', '2022-2023', N'Mầm 1', 1);

--Thêm thông tin vào bảng RELATIVES
INSERT INTO RELATIVES (idRelative, nameRelative, phone, yearBorn)
VALUES ('22230001', N'Nguyễn Văn C', '0123456789', '1980'),
       ('22230002', N'Trần Thị B', '0123456789', '1975');

--Thêm thông tin vào bảng RELATIVED
INSERT INTO RELATIVED (idRelative, idstudent, relationship)
VALUES ('22230001', N'22230001', 'Cha'),
       ('22230002', N'22230001', 'Mẹ');

--Thêm thông tin vào bảng ATTENDANCES
INSERT INTO ATTENDANCES (idStudent, dateAttend)
VALUES ('22230001', '2023-04-26'),
       ('22230002', '2023-04-26'),
	   ('22230001', '2023-04-27'),
       ('22230002', '2023-04-27');

--Thêm thông tin vào bảng ACHIEVEMENTS
INSERT INTO ACHIEVEMENTS (idStudent, dateAchived, achievement)
VALUES ('22230001', '2024-04-26', N'Vở sạch chữ đẹp'),
       ('22230002', '2024-04-26', N'Chăm ngoan');


--Thêm thông tin vào bảng TRANSACTIONS
INSERT INTO TRANSACTIONS (idTransaction, classify, amountMoney)
VALUES ('T001', N'Thu', 500000),
       ('T002', N'Chi', 300000);

--Thêm thông tin vào bảng FEES
INSERT INTO FEES (idTransaction, idStudent, collected)
VALUES ('T001', '22230001', 1),
       ('T002', '22230002', 1);

--Thêm thông tin vào bảng EXPENSES
INSERT INTO EXPENSES (idTransaction, receiver, addressReceiver, reason)
VALUES ('T002', N'Phạm Thị X', N'Đường D6', N'Mua cơ sở vật chất');

--Thêm thông tin vào b?ng SERVICES
INSERT INTO SERVICES (idTransaction, idStudent, uniform, lunch1, lunch2, healthnsurance, accidentinsurance)
VALUES ('T001', '22230002', 1, 1, 0, 1, 0),
       ('T002', '22230001', 1, 0, 1, 1, 1);

--Thêm thông tin vào bảng FOODS
INSERT INTO FOODS (idFood, nameFood, nutrition)
VALUES ('F001', N'Cơm chiên dương châu', 500),
       ('F002', N'Thịt kho tàu', 800),
	   ('F003', N'Trứng chiên', 500),
	   ('F004', N'Dưa hấu', 300),
	   ('F005', N'Canh chua', 400);

--Thêm thông tin vào bảng MENUS
INSERT INTO MENUS (dateMenu, idFood1, idFood2, idFood3)
VALUES ('2024-04-26', 'F001', 'F002', 'F004'),
       ('2024-04-27', 'F005', 'F003', 'F004');



--Thêm thông tin vào bảng NOTICATION
INSERT INTO NOTICATION (idNotication, dateNotication, title, content)
VALUES ('N001', '2024-04-26', N'Thông báo 1', N'Nội dung thông báo 1'),
       ('N002', '2024-04-27', N'Thông báo 2', N'Nội dung thông báo 2');



Go
CREATE PROC USP_Login
@userName nvarchar(10), @password nvarchar(255)
AS
BEGIN
	SELECT * FROM dbo.STAFFS WHERE phone = @userName AND pwd = @password
END
GO

CREATE PROCEDURE USP_ForgotPassword
    @userName NVARCHAR(50),
    @newPassword NVARCHAR(100), -- Thêm tham số cho mật khẩu mới
	@email    VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem tài khoản có tồn tại trong hệ thống không
    IF EXISTS (SELECT * FROM STAFFS WHERE phone = @userName and email = @email)
    BEGIN
        -- Cập nhật mật khẩu mới cho người dùng
        UPDATE STAFFS  SET pwd =  @newPassword WHERE phone = @userName
        
        -- Trả về kết quả báo thành công
        SELECT 'Success' AS Result
    END
    ELSE
    BEGIN
        -- Trả về kết quả báo không thành công nếu tài khoản không tồn tại
        SELECT 'Failed' AS Result
    END
END

Go
CREATE PROCEDURE USP_ChangePassword
    @id NVARCHAR(50),
    @pwd NVARCHAR(100),
    @newpwd NVARCHAR(100)
AS
BEGIN
    DECLARE @OldPwd NVARCHAR(50)

    -- Lấy mật khẩu cũ từ bảng người dùng dựa trên ID
    SELECT @OldPwd = pwd
    FROM STAFFS
    WHERE idStaff = @id

    -- Kiểm tra xem mật khẩu hiện tại có khớp không
    IF @OldPwd = @pwd
    BEGIN
        -- Nếu khớp, cập nhật mật khẩu mới
        UPDATE STAFFS
        SET pwd = @newpwd
        WHERE idStaff = @id

        -- Trả về kết quả thành công
        SELECT 'Success' AS Result
    END
    ELSE
    BEGIN
        -- Nếu không khớp, trả về kết quả thất bại
        SELECT 'Failure' AS Result
    END
END


Go
CREATE PROCEDURE USP_AddNewStaff
    @idStaff VARCHAR(8),
    @nameStaff NVARCHAR(25),
    @gender BIT,
    @dateBirth DATE,
    @placeBirth NVARCHAR(25),
    @nation NVARCHAR(25),
    @nationality NVARCHAR(25),
    @idCityzen NVARCHAR(12),
    @licenseDate DATE,
    @licensePlace NVARCHAR(25),
    @address_cur NVARCHAR(50),
    @province_cur NVARCHAR(25),
    @district_cur NVARCHAR(25),
    @commune_cur NVARCHAR(25),
    @address_res NVARCHAR(50),
    @province_res NVARCHAR(25),
    @district_res NVARCHAR(25),
    @commune_res NVARCHAR(25),
    @roled NVARCHAR(25),
    @actived BIT,
    @phone NVARCHAR(10),
    @email VARCHAR(50),
	@pwd Varchar(255) = 'Abc@123'
AS
BEGIN
    INSERT INTO STAFFS (idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email, pwd)
    VALUES (@idStaff, @nameStaff, @gender, @dateBirth, @placeBirth, @nation, @nationality, @idCityzen, @licenseDate, @licensePlace, @address_cur, @province_cur, @district_cur, @commune_cur, @address_res, @province_res, @district_res, @commune_res, @roled, @actived, @phone, @email,@pwd);
END

Go
CREATE PROCEDURE USP_UpdateStaffInfo
    @idStaff VARCHAR(8),
    @nameStaff NVARCHAR(25),
    @gender BIT,
    @dateBirth DATE,
    @placeBirth NVARCHAR(25),
    @nation NVARCHAR(25),
    @nationality NVARCHAR(25),
    @idCityzen NVARCHAR(12),
    @licenseDate DATE,
    @licensePlace NVARCHAR(25),
    @address_cur NVARCHAR(50),
    @province_cur NVARCHAR(25),
    @district_cur NVARCHAR(25),
    @commune_cur NVARCHAR(25),
    @address_res NVARCHAR(50),
    @province_res NVARCHAR(25),
    @district_res NVARCHAR(25),
    @commune_res NVARCHAR(25),
    @roled NVARCHAR(25),
    @actived BIT,
    @phone NVARCHAR(10),
    @email VARCHAR(50)
AS
BEGIN
    UPDATE STAFFS
    SET 
        nameStaff = @nameStaff,
        gender = @gender,
        dateBirth = @dateBirth,
        placeBirth = @placeBirth,
        nation = @nation,
        nationality = @nationality,
        idCityzen = @idCityzen,
        licenseDate = @licenseDate,
        licensePlace = @licensePlace,
        address_cur = @address_cur,
        province_cur = @province_cur,
        district_cur = @district_cur,
        commune_cur = @commune_cur,
        address_res = @address_res,
        province_res = @province_res,
        district_res = @district_res,
        commune_res = @commune_res,
        roled = @roled,
        actived = @actived,
        phone = @phone,
        email = @email
    WHERE idStaff = @idStaff;
END


Go
CREATE PROCEDURE USP_DeleteStaff
    @idStaff VARCHAR(8)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Tiếp theo, xóa dữ liệu từ bảng nhân viên
        DELETE FROM STAFFS WHERE idStaff = @idStaff;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END

Go
Create ProceDure USP_LoadEmptyClass
	@yearSchool Varchar(9)
AS
BEGIN
	Select * FROM CLASSES WHERE wholesale < 30 and yearSchool = @yearSchool
END


Go
CREATE PROCEDURE USP_AddNewStudent 
    @idStudent VARCHAR(8),
    @nameStudent NVARCHAR(25),
    @gender BIT,
    @dateBirth DATE,
    @placeBirth NVARCHAR(25),
    @nation NVARCHAR(25),
    @nationality NVARCHAR(25),
    @address_cur NVARCHAR(50),
    @province_cur NVARCHAR(25),
    @district_cur NVARCHAR(25),
    @commune_cur NVARCHAR(25),
    @address_res NVARCHAR(50),
    @province_res NVARCHAR(25),
    @district_res NVARCHAR(25),
    @commune_res NVARCHAR(25),
	@yearSchool NVARCHAR(25),
	@classes NVARCHAR(25),
    @actived BIT
AS
BEGIN
	UPDATE CLASSES
	SET wholesale = wholesale + 1
	where className = @classes;
    INSERT INTO STUDENTS(idStudent, nameStudent, gender, dateBirth, placeBirth, nation, nationality, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, yearSchool, class, actived)
    VALUES (@idStudent, @nameStudent, @gender, @dateBirth, @placeBirth, @nation, @nationality, @address_cur, @province_cur, @district_cur, @commune_cur, @address_res, @province_res, @district_res, @commune_res,@yearSchool, @classes, @actived);
END


GO
CREATE PROCEDURE USP_AddNewRelationship
	@idStudent VARCHAR(8),
	@nameRelative NVARCHAR(25),
	@phone	NVARCHAR(10),
	@yearBorn NVARCHAR(4),
	@idRelative VARCHAR(8),
	@relationship NVARCHAR(25)
AS
BEGIN
	INSERT INTO RELATIVES(idRelative,nameRelative,phone,yearBorn)
	VALUES(@idRelative,@nameRelative,@phone,@yearBorn);

	INSERT INTO RELATIVED(idRelative,idstudent,relationship)
	VALUES(@idRelative,@idStudent,@relationship);
END

Go
CREATE PROCEDURE USP_UpdateStudent
    @idStudent VARCHAR(8),
    @nameStudent NVARCHAR(25),
    @gender BIT,
    @dateBirth DATE,
    @placeBirth NVARCHAR(25),
    @nation NVARCHAR(25),
    @nationality NVARCHAR(25),
    @address_cur NVARCHAR(50),
    @province_cur NVARCHAR(25),
    @district_cur NVARCHAR(25),
    @commune_cur NVARCHAR(25),
    @address_res NVARCHAR(50),
    @province_res NVARCHAR(25),
    @district_res NVARCHAR(25),
    @commune_res NVARCHAR(25),
	@yearSchool NVARCHAR(25),
	@classes NVARCHAR(25),
    @actived BIT
AS
BEGIN
    UPDATE Students
    SET nameStudent = @nameStudent,
        gender = @gender,
        dateBirth = @dateBirth,
        placeBirth = @placeBirth,
        nation = @nation,
        nationality = @nationality,
        address_cur = @address_cur,
        province_cur = @province_cur,
        district_cur = @district_cur,
        commune_cur = @commune_cur,
        address_res = @address_res,
        province_res = @province_res,
        district_res = @district_res,
        commune_res = @commune_res,
        yearSchool = @yearSchool,
        class = @classes,
        actived = @actived
    WHERE idStudent = @idStudent;
END

Go
CREATE PROCEDURE USP_DeleteStudent
    @idStudent VARCHAR(8)
AS
BEGIN
    SET NOCOUNT ON;

	declare @idrelative varchar(8) 
	SELECT @idrelative = idRelative FROM RELATIVED WHERE idStudent = @idStudent

	DECLARE @idClass NVARCHAR(25);
    SELECT @idClass = class FROM STUDENTS WHERE idStudent = @idStudent;
	UPDATE CLASSES
	SET wholesale = wholesale -1
	where className = @idClass;

    -- Xóa thông tin từ bảng RELATIVED

		DELETE FROM RELATIVED WHERE idStudent = @idStudent;
		DELETE FROM RELATIVES WHERE idRelative = @idrelative;
	
    
		-- Xóa thông tin từ bảng ACHIEVEMENTS
		DELETE FROM ACHIEVEMENTS WHERE idStudent = @idStudent;
    
		-- Xóa thông tin từ bảng SERVICES
		DELETE FROM SERVICES WHERE idStudent = @idStudent;
    
		-- Xóa thông tin từ bảng FEES
		DELETE FROM FEES WHERE idStudent = @idStudent;
    
		-- Xóa thông tin từ bảng STUDENTS
		DELETE FROM STUDENTS WHERE idStudent = @idStudent;

END

Go
CREATE PROCEDURE USP_NewSchoolYear
    @yearSchool VARCHAR(9),
    @className NVARCHAR(25),
    @teacher VARCHAR(8) = Null,
    @wholesale INT
AS
BEGIN
    INSERT INTO CLASSES(yearSchool, className, teacher, wholesale)
    VALUES (@yearSchool, @className, @teacher, @wholesale)
END


Go
CREATE PROCEDURE USP_AddNewAchievements
    @idStudent NVARCHAR(8),
    @dateAchieved DATE,
    @achievement NVARCHAR(50)
AS
BEGIN
    INSERT INTO ACHIEVEMENTS( idStudent , dateAchived ,achievement)
    VALUES (@idStudent, @dateAchieved, @achievement);
END

go 
CREATE TRIGGER trg_InsertNotificationStaff
ON NOTICATION
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm các liên kết mới vào bảng NOTIFICATION_STAFF và set thuộc tính seen của notifications bằng 1
    INSERT INTO NOTICATION_STAFF (idNotication, idStaff, seen)
    SELECT inserted.idNotication, STAFFS.idStaff, 0 
    FROM inserted
    CROSS JOIN STAFFS
    WHERE STAFFS.actived = 1;
END;

Go
CREATE PROCEDURE USP_UpdateSeenStatus
    @idNoti VARCHAR(8),
    @idStaff VARCHAR(8)
AS
BEGIN
    UPDATE NOTICATION_STAFF
    SET seen = 1 
    WHERE idNotication = @idNoti AND idStaff = @idStaff;
END





go
CREATE PROCEDURE USP_AddNewAttendences
    @idStudent NVARCHAR(8),
    @dateAttendance DATE
AS
BEGIN
	INSERT INTO ATTENDANCES(idStudent, dateAttend)
    VALUES (@idStudent, @dateAttendance)
END
