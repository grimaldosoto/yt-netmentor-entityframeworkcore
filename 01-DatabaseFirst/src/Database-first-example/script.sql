CREATE DATABASE cursoEF;
go
USE cursoEF;

go

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE [dbo].[User] (
  UserId int NOT NULL IDENTITY,
  UserName varchar(50) NOT NULL,
  PRIMARY KEY (UserId),
  CONSTRAINT UserName UNIQUE  (UserName)
);

go
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE wokringexperience (
  id int NOT NULL IDENTITY,
  UserId int NOT NULL,
  Name varchar(150) NOT NULL,
  Details varchar(5000) NOT NULL,
  Environment varchar(500) NOT NULL,
  StartDate date DEFAULT NULL,
  EndDate date DEFAULT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (UserId) REFERENCES [dbo].[user](UserId)
);