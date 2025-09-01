create table school
(
schoolId serial primary key,
schooltitle varchar(50),
levelCount int,
isactive int,
createdat date,
updatedat date
);
create table parent
(
parentId serial primary key,
parentCode varchar(12),
parentFullname varchar(50),
email varchar(100),
phone varchar(20),
createdat Date,
updatedat date
);
create table student
(
studentId serial primary key,
studentCode varchar(12),
studentFullname varchar(50),
gender smallint,
dob date,
Email varchar(75),
Phone varchar(15),
schoolId int references school(schoolid),
stage int,
section char(2),
IsActive smallint,
joinDate Date,
createdat Date,
updatedat Date
);
create table studentParent
(
StudentParentId serial primary key,
StudentId int references student(studentid),
ParentId int references parent(parentid),
relationship int
);
create table subject
(
subjectId serial primary key,
title varchar(100),
schoolid int references school(schoolid),
stage int,
term int,
carryMark int,
createdat Date,
updatedat Date
);
create table classroom
(
classroomId serial primary key,
capacity int,
roomType int,
description varchar(100),
createdat date,
updatedat date
);
create table teacher
(
teacherId serial primary key,
teacherCode varchar(12),
teacherFullname varchar(75),
gender smallint,
dob date,
email varchar(75),
phone varchar(15),
isactive smallint,
joindate Date,
workingDays smallint,
createdat Date,
updatedat Date
);
create table class
(
classid serial primary key,
className varchar(50),
subjectId int references subject(subjectId),
teacherId int references teacher(teacherId),
classroomId int references classroom(classroomId),
section varchar(2),
createdat Date,
updatedat Date
);
create table classStudent
(
classStudentId serial primary key,
classId int references class(classid),
StudentId int references student(studentId)
);

