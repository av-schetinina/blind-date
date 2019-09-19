create table City
(id_city  integer primary key NOT NULL IDENTITY(1,1),
name char (50) NOT NULL UNIQUE);

insert into City (name) values('Kiev'),('Khakiv'),('Lviv'),('Odessa'),('Dnepr'),('Krivoy Rog'),('Poltava'),('Melitipol');

delete from City where name='|Melitipol';

drop table DateStatus;

create table DateStatus
(id_status  integer primary key NOT NULL IDENTITY(1,1),
name char (20) NOT NULL UNIQUE);

insert into DateStatus (name) values('new'),('1 user agreed(m)'),('1 user agreed(w)'),('2 uses agreed'),('being organized'),('organized'),('cancel'),('done');

create table Question
(id_quest integer primary key NOT NULL IDENTITY(1,1),
quest char (200) NOT NULL UNIQUE);

insert into  Question(quest) values('Loves a good party'),('Enjoys going to museums and cultural events'),
('Likes to talk about feelings and emotions'),('Likes to keep to a schedule'),
('Keeps up a steady stream of conversation'),('Likes to talk about intellectual things like art and philosophy'),
('Agrees with me to keep the peace'),('Keeps a very clean house'),('Is a social butterfly'), ('Is more logical than emotional');
 
create table DateType
(id_type integer primary key NOT NULL IDENTITY(1,1),
place text NOT NULL,
date_time datetime NOT NULL,
descrip text , 
comment  text,
feedback text);

insert into  DateType(place, date_time, descrip) values('People, st. Sumy, 6', '2019-07-11 19:00', 'Dark place with romantic music for passive people'),
('Circus, Maydan Iryna Bugrimova, 1', '2019-07-01 12:00', 'For people, who love pets'), ('Fabrika, Blagoveshchenskaya street 1', '2019-11-11 21:00', 'Jazz concert'),
('Depstor, the area of the Constitution, 1', '2019-08-03 20:00', 'House evening'), ('Depstor, the area of the Constitution, 1', '2019-08-03 20:00', 'Disco night');

TRUNCATE  table Users;
drop table Users;
drop table Results;
drop table Request;

use blinddating;

create table Users
(id_user integer primary key NOT NULL IDENTITY(1,1),
userName varchar(20) NOT NULL ,
surname varchar(20) NOT NULL ,
email varchar(30) NOT NULL UNIQUE,
telephone varchar(13) NOT NULL UNIQUE,
dateOfBirth date NOT NULL ,
genus varchar(1) NOT NULL , 
city int FOREIGN KEY REFERENCES City(id_city) NOT NULL ,
information varchar(250) NOT NULL , 
pass varchar(20) NOT NULL
);

alter table Users drop  column pass ;
alter table Users ADD  pass varchar(20);

insert into  Users(userName, surname, email,telephone, dateOfBirth,genus,city,information,pass) values
('Ann', 'White', 'ann.wht@gmail.com', '+380675465745','1998-12-12','f',2, 'i love pets and sad music','12345'),
('Kait', 'Jordan', 'jordat_kitty@gmail.com', '+380675463345','1998-05-03','f',2,'i love jazz and game of thrones','34567'),
('Alexandra', 'Smith', 'smithhh_02@gmail.com', '+380930465545','1998-06-12','f',2,'sport it s my life','23678'),
('Bill', 'Brown', 'bll.brwn@gmail.com', '+380548888745','1997-10-22','m',2,'smog weed every day','12789'),
('Garry', 'lord', 'lord_king@gmail.com', '+380568675745','1994-01-22','m',2,'looking for princess :)', '12345');

insert into  Users(userName, surname, email,telephone, dateOfBirth,genus,city,information,pass) values ('Garry', 'Tomson', 'll_pldg@gmail.com', '+380568765745','1994-01-20','m',2,'looking for future wife :)', '72345');

drop table Results;
create table Results
(id_user int FOREIGN KEY REFERENCES Users(id_user)  NOT NULL,
id_quest int FOREIGN KEY REFERENCES Question(id_quest)  NOT NULL,
answer int NOT NULL,
PRIMARY KEY(id_user, id_quest)
);

insert into  Results(id_user, id_quest, answer) values(10,1,2),(10,2,2),(10,3,2),(10,4,2),(10,5,2),(10,6,5),(10,7,1),(10,8,2),(10,9,4),(10,10,2),
(12,1,5),(12,2,5),(12,3,5),(12,4,2),(12,5,2),(12,6,5),(12,7,3),(12,8,3),(12,9,4),(12,10,2),
(3,1,2),(3,2,2),(3,3,2),(3,4,2),(3,5,2),(3,6,5),(3,7,1),(3,8,2),(3,9,4),(3,10,2),

(11,1,2),(11,2,2),(11,3,2),(11,4,2),(11,5,2),(11,6,5),(11,7,1),(11,8,2),(11,9,4),(11,10,2),
(13,1,5),(13,2,5),(13,3,5),(13,4,2),(13,5,2),(13,6,5),(13,7,3),(13,8,3),(13,9,4),(13,10,2),
(14,1,2),(14,2,2),(14,3,2),(14,4,2),(14,5,2),(14,6,5),(14,7,1),(14,8,2),(14,9,4),(14,10,2);

create table Request
(id_req integer primary key NOT NULL IDENTITY(1,1),
id_user int FOREIGN KEY REFERENCES Users(id_user)  NOT NULL,
id_date int FOREIGN KEY REFERENCES Question(id_quest)  NOT NULL,
id_status int FOREIGN KEY REFERENCES DateStatus(id_status)  NOT NULL,
comment text,
partner int FOREIGN KEY REFERENCES DateStatus(id_status)  NOT NULL,);



