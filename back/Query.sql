use master
go

if not exists(
	select*
	from sys.databases 
	where name = 'WebSiteViagem'
	)

create database WebSiteViagem
go

use WebSiteViagem
go

create table Usuario(
	ID int identity primary key,
	Name varchar(100) not null,
	Email varchar(100) not null, 	 
	Userpass varchar(MAX) not null
);
go

create table token(
	ID int identity primary key, 
	UserID int references Usuario(ID), 
	Value varchar(MAX) not null
);
go

create table Formulario(
	ID int identity primary Key,
	UserID int references Usuario(ID),
	ArrivalDate date not null,
	DepartureDate date not null,
	TypeHosting varchar(100) not null,
	HostingAmount varchar(20) not null,
	Accommodation varchar(100) not null,
	Link varchar(50),
	HostingComments varchar(1000) not null,
	Food varchar(100) not null,
	FoodAmount varchar(20) not null,
	TypeFood varchar(50) not null,
	FoodComments varchar(1000) not null,
	TypeAttraction varchar(50) not null,
	AttractionAmount varchar(20) not null,
	TypeTransport varchar(50) not null,
	AttractionComments varchar(1000) not null
);
go
