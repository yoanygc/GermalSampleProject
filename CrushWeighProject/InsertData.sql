


SET QUOTED_IDENTIFIER OFF;
GO
USE [CrushWeighDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

INSERT INTO TicketStatus (Status)
VALUES
  ('-- Select --'),
  ('Opened'),
  ('Closed'),
  ('Canceled');


INSERT INTO [SystemConfigs] (KeyName, Value)
VALUES
  ('UM', 'Kg'),
  ('IndicatorBrand', 'Avery Weigh-Tronix'),
  ('IndicatorModel', 'ZM405'),
  ('IndicatorIP', '10.10.10.10'),
  ('IndicatorPort', '502'),
  ('CompanyName', 'Concrete & Aggregates Ltd.'),
  ('CompanyAddress', 'P.O. Box 916 Union, Castries, St. Lucia'),
  ('CompanyPhone1', '758-450-2778'),
  ('CompanyPhone2', ''),
  ('CompanyFax', '758-450-2860'),
  ('CompanyEmail1', 'conag@candw.lc'),
  ('CompanyEmail2', 'conaggr@hotmail.com');


INSERT INTO Materials (Name, BasePrice)
VALUES
  ('-- Select --', ''),
  ('Gravel', '40.50'),
  ('Stones 16', '55.60'),
  ('Road Base', '35.30');


INSERT INTO Drivers (FullName, LicenseNumber)
VALUES
  ('-- Select --', ''),
  ('Yoany Guerra', '73374972'),
  ('Marlon Guerra', '74635234'),
  ('Melissa Guerra', '94567834'),
  ('Lemia Chinea', '88483294');

INSERT INTO Trucks (PlateNumber)
VALUES
  ('-- Select --'),
  ('PA1234'),
  ('PB5678'),
  ('PO8476');

INSERT INTO Customers (Name, Phone, Location, MailingAddress)
VALUES
  ('-- Select --', '', '', ''),
  ('Massy Stores Inc.', '+1 (758) 873-4665', 'Summersdale', 'Castries'),
  ('WIZO Ltd.', '+1 (758) 645-9334', 'Pierrot', 'Vieux Fort'),
  ('Sir Arthur Community College', '+1 (758) 564-9934', 'Laborie', 'Vieux Fort');


INSERT INTO Tickets (SeqNumber, DateTimeIn, DateTimeOut, Tare, GrossWeight, NetWeight, 
			Customer_Id, Driver_Id, Material_Id, Truck_Id, TicketStatus_Id)
VALUES
('9010', '2021-1-1 8:00:00', '2021-1-1 15:00:00', '1800.0', '10000.7', '0', 2, 2, 2, 2, 3),
('9011', '2021-1-2 8:00:00', '2021-1-2 10:00:00', '1800.0', '11000.4', '0', 2, 2, 2, 2, 3),
('9012', '2021-1-2 8:00:00', '2021-1-2 10:00:00', '1800.0', '11000.4', '0', 2, 2, 3, 2, 3),
('9013', '2021-1-2 8:00:00', '2021-1-2 10:00:00', '1800.0', '11000.4', '0', 3, 3, 2, 2, 3),
('9014', '2021-1-2 8:00:00', NULL, '1800.0', '11000.4', '0', 3, 3, 3, 2, 2),
('9015', '2021-1-2 8:00:00', NULL, '1800.0', '11000.4', '0', 2, 2, 2, 3, 2),
('9016', '2021-1-2 8:00:00', NULL, '1800.0', '11000.4', '0', 2, 4, 2, 3, 2),
('9017', '2021-1-3 8:00:00', NULL, '1700.0', '10500.4', '0', 3, 4, 3, 2, 2);

INSERT INTO PricesByClients (Price, Customer_Id, Material_Id)
VALUES
  ('50.00', '1', '1'),
  ('65.25', '1', '2');
