create table bus_info(
BusId int primary key,
BoardingPoint varchar(3) NOT NULL,
TravelDate date NOT NULL,
Amount float NOT NULL,
Rating int NOT NULL
);


--****Display The Table After Creating The Stored Procedure****
--1Q
Select*from bus_info
--2Q
--****Retrieve all BoardingPoint and TravelDate for the amount which is greater than 450****
Select BoardingPoint,TravelDate from bus_info where Amount>450 

--3Q
--****Create View Bus_View to display the BusID, BoardingPoint whose rating is greater than 3***
create view
 [Bus_View] as (
select BusId,BoardingPoint from bus_info where Rating>3);

--Displaying the Bus_view 
select * from [Bus_View]

---4Q
--****Retrieve all the BusID, DroppingPoint for the bus travelled on 10-12-2017.
select BusId,BoardingPoint from bus_info where TravelDate='2017-12-10'