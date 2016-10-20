
CREATE TABLE Album(
Id int PRIMARY KEY,
Title varchar(100),
Artist varchar (50),
Genre varchar(50),
Year int,
CoverUrl varchar(1024),
TrackId int FOREIGN KEY REFERENCES Track(Number));

CREATE TABLE Track(
Number int PRIMARY KEY,
SongTitle varchar(100),
Length time);