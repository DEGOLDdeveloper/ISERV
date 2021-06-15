CREATE DATABASE RegistryService
ON
(
	NAME='RegistryService',
	FILENAME='D:\RegistryService.mdf',
	SIZE =10MB,
	MAXSIZE=100MB,
	FILEGROWTH=10MB
)
LOG ON
(
	NAME='LogRegistryService',
	FILENAME='D:\LogRegistryService.ldf',
	SIZE=5MB,
	MAXSIZE=50MB,
	FILEGROWTH=5MB
)
GO
USE RegistryService
CREATE TABLE Clients
(
	ClientId Int IDENTITY  NOT NULL PRIMARY KEY,
	Firstname nvarchar(20) NOT NULL,
	Lastname nvarchar(20) NOT NULL,
	Fullname as CONCAT(Firstname,' ',Lastname),
	DateOfBirth datetime NOT NULL,
	Age as datediff(year,DateOfBirth,getdate()),
)

CREATE TABLE Doctors
(
	DoctorId Int IDENTITY  NOT NULL PRIMARY KEY,
	Firstname nvarchar(20) NOT NULL,
	Lastname nvarchar(20) NOT NULL,
	Fullname as CONCAT(Firstname,' ',Lastname),
	DateOfBirth datetime NOT NULL,
	Age as datediff(year,DateOfBirth,getdate()),
	Specialization nvarchar(20) NOT NULL,
)

CREATE TABLE Registrations
(
	idOfRegistration Int IDENTITY NOT NULL,
	dateOfRegistration datetime NOT NULL,
	ClientId Int FOREIGN KEY REFERENCES Clients (ClientId) ON DELETE SET NULL,
	DoctorId Int FOREIGN KEY REFERENCES Doctors (DoctorId) ON DELETE SET NULL,
	isVisited bit NOT NULL DEFAULT 0,
)

INSERT dbo.Doctors
SELECT '��������','�������','12.10.1993','������'

INSERT dbo.Doctors
SELECT '������','��������','27.02.1984','�������'

INSERT dbo.Doctors
SELECT '�������','������','21.12.1993','������'

INSERT dbo.Doctors
SELECT '��������','��������','02.02.1973','�������'

INSERT dbo.Doctors
SELECT '�����','��������','15.06.1993','��������'

INSERT dbo.Doctors
SELECT '���������','��������','16.11.1989','����������'

INSERT dbo.Clients
SELECT '������','��������','17.07.1993'

INSERT dbo.Clients
SELECT '��������','��������','13.09.1984'

INSERT dbo.Clients
SELECT '�����','������','03.10.1993'

INSERT dbo.Clients
SELECT '������','�����������','25.08.1967'

INSERT dbo.Clients
SELECT '������','��������','14.01.1998'


INSERT dbo.Registrations
SELECT '2021-05-08 12:45:00','1','2','1'

INSERT dbo.Registrations
SELECT '2021-05-08 12:15:00','2','2','1'

INSERT dbo.Registrations
SELECT '2021-05-08 13:15:00','3','2','1'

INSERT dbo.Registrations
SELECT '2021-05-08 13:45:00','4','2','0'

INSERT dbo.Registrations
SELECT '2021-05-08 14:00:00','1','3','1'

INSERT dbo.Registrations
SELECT '2021-05-09 14:15:00','2','3','1'

INSERT dbo.Registrations
SELECT '2021-05-09 14:30:00','3','3','0'

INSERT dbo.Registrations
SELECT '2021-05-09 14:45:00','5','3','1'

INSERT dbo.Registrations
SELECT '2021-05-09 13:15:00','1','2','1'

INSERT dbo.Registrations
SELECT '2021-05-10 13:30:00','1','2','1'

INSERT dbo.Registrations
SELECT '2021-05-10 13:00:00','1','3','0'

INSERT dbo.Registrations
SELECT '2021-05-12 09:00:00','1','5','1'

INSERT dbo.Registrations
SELECT '2021-05-12 09:30:00','2','6','1'

INSERT dbo.Registrations
SELECT '2021-05-10 10:30:00','2','6','1'

INSERT dbo.Registrations
SELECT '2021-05-10 15:30:00','4','6','0'


