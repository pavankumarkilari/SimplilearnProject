create database MVCDb
use MVCDb

create table Classes
(
ClassId int primary key,
ClassName nvarchar(50) not null
)

create table Subject(
SubjectId int primary key,
SubjectName nvarchar(50) not null,
TeacherName nvarchar(50) not null
)

create table Student(
StudentId int primary key,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Gender varchar(50) not null,
ClassId int foreign key references Classes(ClassId)
)

select * from Classes
select * from Student
select * from Subject