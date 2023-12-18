create database SchoolDB

use SchoolDB

-- Create Subjects Table
create table Subjects (
    SubjectID int primary key,
    SubjectName varchar(255) not null
);

-- Create Index for SubjectName
create index SubjectNameIndex on Subjects(SubjectName);

-- Create Classes Table
create table Classes (
    ClassID int primary key,
    ClassName varchar(50) not null
);

-- Create Index for ClassName 
create index ClassNameIndex on Classes(ClassName);

-- Create Student Table
create table Student (
    StudentID int primary key,
    FirstName varchar(50) not null,
    LastName  varchar(50) not null,
    ClassID int references Classes(ClassID),
    constraint FK_Student_Class foreign key (ClassID) references Classes(ClassID)
);

-- Create Index for FirstName
create index FirstNameIndex on Student(FirstName);

-- Insert records into Classes table
insert into Classes (ClassID, ClassName)
values 
    (1, 'Class A'),
    (2, 'Class B'),
    (3, 'Class C');

-- Insert records into Subjects table
insert into Subjects (SubjectID, SubjectName)
values
    (1, 'Telugu'),
    (2, 'Hindi'),
    (3, 'English'),
    (4, 'Mathematics'),
    (5, 'Science'),
    (6, 'Social');

-- Insert records into Student table
insert into Student (StudentID, FirstName, LastName, ClassID)
values
    (1, 'Ramanji', 'Battula', 1),
    (2, 'Praveen', 'Kondru', 2),
    (3, 'Mahesh', 'Katuri', 1),
    (4, 'Prakash', 'Gaddala', 3),
    (5, 'Shashank', 'Darsi', 2),
    (6, 'Chandu', 'Vemula', 3),
    (7, 'Teja', 'Aradhyula', 1),
    (8, 'Gowtham', 'Koribilli', 2),
    (9, 'Sudhakar', 'Chitimala', 3),
    (10, 'Pavan', 'Kilari', 1);

-- Display All The Tables
select * from Student
select * from Classes
select * from Subjects

-- Display Records Using Index
select * from Student where FirstName = 'Gowtham'
select * from Classes where ClassName = 'Class B'
select * from Subjects where SubjectName = 'Science'