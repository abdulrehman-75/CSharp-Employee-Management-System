create table users
(
id int primary key identity(1,1),
username varchar(MAX) null,
password varchar(MAX) null,
date_register date null
);

select * from users;

create table employees
(
id int primary key identity(1,1),
employeeId varchar(MAX) null,
fullName varchar(MAX) null,
gender varchar(MAX) null,
phoneNumber varchar(MAX) null,
position varchar(MAX) null,
image varchar(MAX) null,
salary int,
insertDate date null,
updateDate date null,
deleteDate date null,
status varchar(MAX) null
)


select * from employees;
