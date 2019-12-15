CREATE DATABASE AirportInfo;
GO

USE AirportInfo;

SELECT * FROM INFORMATION_SCHEMA.TABLES; -- Для себя

-- ТАБЛО ВЫЛЕТОВ
CREATE TABLE dbo.DepartureBoard
        (       
                    FlightNumber NVARCHAR(20) NOT NULL, -- ● номер рейса
                    DepartureCity NVARCHAR(20) NOT NULL, -- ●город вылета
                    DepartureCountry NVARCHAR(20) NOT NULL, -- ●страна вылета
                    CityOfArrival NVARCHAR(20) NOT NULL, -- ●город прилёта
                    ArrivalCountry NVARCHAR(20) NOT NULL, -- ●страна прилёта
                    [DateTimeDeparture] DATETIMEOFFSET(0) NOT NULL, -- дата и время вылета
                    [DateTimeArrival] DATETIMEOFFSET(0) NOT NULL,-- дата и время приёлета
                    [FlightTime]  TIME NOT NULL, -- ● время в полёте
                    Airline NVARCHAR(50) NOT NULL, -- ● авиакомпания
                    AirplaneModel NVARCHAR(20) NOT NULL, --● модель самолёта
        ) ON [PRIMARY];
GO

--------------------------------
SELECT * FROM DepartureBoard; -- Для себя

INSERT INTO DepartureBoard(
    FlightNumber,DepartureCity,DepartureCountry,CityOfArrival,
    ArrivalCountry,DateTimeDeparture,DateTimeArrival,
    FlightTime,Airline,AirplaneModel)
VALUES ('RU2640','СПБ','РОССИЯ',
    'АНКАРА','ТУРЦИЯ','2019-12-15 20:00:00 +03:00',
    '2019-12-15 00:00:00 +05:00','4:00','АЕРОФЛОТ','BOING747');

INSERT INTO DepartureBoard 
VALUES ('RU3640','МОСКВА','РОССИЯ',
    'АНКАРА','ТУРЦИЯ','2019-12-15T20:00:00',
    '2019-12-15 00:00:00 +05:00','4:00','ПОБЕДА','BOING747');

SELECT * FROM DepartureBoard;

DROP TABLE DepartureBoard;


DROP DATABASE AirportInfo;


 