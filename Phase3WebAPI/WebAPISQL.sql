create database WebAPIDb
use WebAPIDb

create table Student
(StudentId int primary key,
RollNo int not null,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Gender varchar(50) not null
)
insert into Student values(1,101,'Praveen','Kondru','Female')
insert into Student values(2,102,'Siva','Kuriti','Male')
insert into Student values(3,103,'Samantha','Devara','Male')
insert into Student values(4,104,'Ragidi','Dola','Female')
insert into Student values(5,105,'Dwarak','Bhupathi','Male')

create table Subject(
SubjectId int primary key,
SubjectName nvarchar(50) not null
)
insert into Subject values(1001,'Mathematics')
insert into Subject values(1002,'Science')
insert into Subject values(1003,'Social')
insert into Subject values(1004,'Telugu')

create table Marks
(Id int primary key,
StudentId int foreign key references Student(StudentId),
SubjectId int foreign key references Subject(SubjectId),
Marks int not null)

insert into Marks values(400,1,1002,96)
insert into Marks values(444,3,1001,86)
insert into Marks values(555,4,1003,80)
insert into Marks values(500,2,1004,90)

select * from Student
select * from Subject
select * from Marks
