use [D:\BC\SECONDYEAR\PRG282\PROJECTS\BIN\DEBUG\STUDENTSDB.MDF]
go

INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage)
SELECT	'James','Ray','1995-04-18','0834567532','54 Tree Ave','Male',StudentImage FROM OPENROWSET(BULK N'C:\Users\Dothraki\Desktop\Images\Stock1.png', SINGLE_BLOB)AS ImageSource(StudentImage)
INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage)
SELECT	'Alice','May','1999-11-03','0762418475','84 Willomore street','Female',StudentImage FROM OPENROWSET(BULK N'C:\Users\Dothraki\Desktop\Images\Stock.png', SINGLE_BLOB)AS ImageSource(StudentImage)
INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage)
SELECT	'Mira','Frost','2001-02-25','0614823549','101 Blue road','Female',StudentImage FROM OPENROWSET(BULK N'C:\Users\Dothraki\Desktop\Images\Stock2.png', SINGLE_BLOB)AS ImageSource(StudentImage)
INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage)
SELECT	'Blake','Queen','1998-03-14','0845269875','3 Black street','Male',StudentImage FROM OPENROWSET(BULK N'C:\Users\Dothraki\Desktop\Images\Stock3.png', SINGLE_BLOB)AS ImageSource(StudentImage)