create procedure InsertBusInfo(
@BusId int,
@BoardingPoint varchar(3),
@TravelDate date,
@Amount float,
@Rating int
)
As 
Begin 
		SET NOCOUNT ON;
		insert into bus_info values(@BusId,@BoardingPoint,@TravelDate,@Amount,@Rating)
END

GO

exec InsertBusInfo
		@BusId=1,
		@BoardingPoint='BGL',
		@TravelDate='2017-06-18',
		@Amount=400.65,
		@Rating=2
Go

exec InsertBusInfo
		@BusId=2,
		@BoardingPoint='HYD',
		@TravelDate='2017-10-05',
		@Amount=600.00,
		@Rating=3
Go

exec InsertBusInfo
		@BusId=3,
		@BoardingPoint='CHN',
		@TravelDate='2016-07-25',
		@Amount=445.95,
		@Rating=3
Go
exec InsertBusInfo
		@BusId=4,
		@BoardingPoint='PUN',
		@TravelDate='2017-12-10',
		@Amount=543.00,
		@Rating=4
Go
exec InsertBusInfo
		@BusId=5,
		@BoardingPoint='MUN',
		@TravelDate='2017-01-28',
		@Amount=550.50,
		@Rating=4
Go
exec InsertBusInfo
		@BusId=6,
		@BoardingPoint='PUN',
		@TravelDate='2016-03-27',
		@Amount=333.55,
		@Rating=3
Go
exec InsertBusInfo
		@BusId=7,
		@BoardingPoint='MUM',
		@TravelDate='2016-11-06',
		@Amount=510.00,
		@Rating=4
Go

