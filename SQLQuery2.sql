create table Admins(
	Usernames nvarchar(150) primary key not null,
	Passwords nvarchar(150) not null
);
insert into Admins
values
('Hosny','123456');
create table Students(
	ID int primary key IDENTITY(1,1) not null,
	Names nvarchar(150) not null,
	Genders nvarchar(150) not null,
	Age int not null,
	Addresss nvarchar(150) not null,
	Departments nvarchar(150) not null
);
ALTER TABLE Students ALTER COLUMN Age int not NULL
ALTER TABLE Students ALTER COLUMN Genders nvarchar(150)  NULL

insert into Students
values
('Hosny','male',16,'Egypt','CS');
create table User_LogIn(
	Usernames nvarchar(150) primary key not null,
	Passwords nvarchar(150) not null
);
Select * from Students
