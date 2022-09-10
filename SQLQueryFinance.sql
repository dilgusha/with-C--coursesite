create table About(
	AboutID int identity(1,1)  primary key,
	AboutContent nvarchar(max),
	AboutPhoto nvarchar(max),
	AboutSolution nvarchar(max)
)
select  * from About

create table OurService(
	OurServiceID int identity(1,1) primary key,
	OurServiceAboutID int,
	OurServiceName nvarchar(30),
	OurServiceAbout nvarchar(max),
	OurServicePhoto nvarchar(max)
)

select * from OurService

create table Team(
	TeamID int identity(1,1) primary key,
	TeamAboutID int,
	TeamName nvarchar(30),
	TeamPosition nvarchar(40),
	TeamAbout nvarchar(max),
	TeamPhoto nvarchar(max)
)
select * from Team

create view DetailView as(
select * from About
left join Team
on AboutID=TeamAboutID
)
select * from DetailView

create view General as(
select * from About
left join OurService
on AboutID=OurServiceAboutID
)

select * from General

create table Info(
	InfoID int identity(1,1) primary key,
	InfoPhone nvarchar(30),
	InfoEmail nvarchar(30),
	InfoLocation nvarchar(max),
	InfoPlace nvarchar(100),
	InfoFace nvarchar(50),
	InfoTwitter nvarchar(50),
	infoLink nvarchar(50)
)
select * from Info

create table Contact(
	ContactID int identity(1,1) primary key,
	ContactName nvarchar(30),
	ContactEmail nvarchar(30),
	ContactSubject nvarchar(30),
	ContactMessage nvarchar(500)
)

select * from Contact
