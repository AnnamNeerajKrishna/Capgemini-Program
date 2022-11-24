create table footballleague(
MatchId int primary key,
TeamName1 varchar(50) NOT NULL,
TeamName2 varchar(50) NOT NULL,
Statuss varchar(20) NOT NULL,
WinningTeam varchar(50),
Points int NOT NULL
);

-- ***Display all the data in the table***
select * from footballleague


-- ***Insert data into the table ****
insert into footballleague values(1001, 'Italy', 'France', 'Win', 'France', 4);



-- Q1) Retrieve all the winning teams
select WinningTeam from footballleague where Points = 4;



--Q2)Create View Match_View to display the teams whose status is Draw
create view [Match_View]  as 
select * from footballleague where points = 2;

-- executing the view
select * from [Match_View]



--Q3) Retrieve details of all the matches in which japan played
select * from footballleague where TeamName1 = 'Japan' OR TeamName2 = 'Japan'