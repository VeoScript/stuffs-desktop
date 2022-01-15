create database stuffs

use stuffs

create table UserAccount (
	id int identity primary key not null,
	name varchar(255) unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null
)

create table Reports (
	id int identity primary key not null,
	uuid varchar(255) unique not null,
	reportBy varchar(255) not null,
	requestingPerson varchar(255) not null,
	reportedIssue varchar(255) not null,
	resolutionMade varchar(255) not null,
	dateReportedMonth varchar(255) not null,
	dateReportedDay varchar(255) not null,
	dateReportedYear varchar(255) not null,
	dateResolvedMonth varchar(255) not null,
	dateResolvedDay varchar(255) not null,
	dateResolvedYear varchar(255) not null
)

select * from useraccount

select * from reports

drop table Reports