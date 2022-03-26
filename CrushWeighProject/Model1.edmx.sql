
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2022 11:06:12
-- Generated from EDMX file: D:\Yoany\Programming\CrushWeigh\CrushWeighProject\CrushWeighProject\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CrushWeighDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TruckTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_TruckTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_DriverTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_DriverTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterialTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_MaterialTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketStatusTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_TicketStatusTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_CustomerTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterialPricesByClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PricesByClients] DROP CONSTRAINT [FK_MaterialPricesByClient];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerPricesByClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PricesByClients] DROP CONSTRAINT [FK_CustomerPricesByClient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Drivers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drivers];
GO
IF OBJECT_ID(N'[dbo].[Tickets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tickets];
GO
IF OBJECT_ID(N'[dbo].[Trucks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trucks];
GO
IF OBJECT_ID(N'[dbo].[Materials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materials];
GO
IF OBJECT_ID(N'[dbo].[TicketStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TicketStatus];
GO
IF OBJECT_ID(N'[dbo].[SystemConfigs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemConfigs];
GO
IF OBJECT_ID(N'[dbo].[PricesByClients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PricesByClients];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NULL,
    [Location] nvarchar(max)  NULL,
    [MailingAddress] nvarchar(max)  NULL
);
GO

-- Creating table 'Drivers'
CREATE TABLE [dbo].[Drivers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [LicenseNumber] int  NOT NULL
);
GO

-- Creating table 'Tickets'
CREATE TABLE [dbo].[Tickets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SeqNumber] int  NOT NULL,
    [DateTimeIn] datetime  NULL,
    [DateTimeOut] datetime  NULL,
    [Tare] float  NULL,
    [GrossWeight] float  NULL,
    [NetWeight] float  NULL,
    [Truck_Id] int  NOT NULL,
    [Driver_Id] int  NOT NULL,
    [Material_Id] int  NOT NULL,
    [TicketStatus_Id] int  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- Creating table 'Trucks'
CREATE TABLE [dbo].[Trucks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlateNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BasePrice] float  NOT NULL
);
GO

-- Creating table 'TicketStatus'
CREATE TABLE [dbo].[TicketStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SystemConfigs'
CREATE TABLE [dbo].[SystemConfigs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KeyName] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PricesByClients'
CREATE TABLE [dbo].[PricesByClients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL,
    [Material_Id] int  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Drivers'
ALTER TABLE [dbo].[Drivers]
ADD CONSTRAINT [PK_Drivers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [PK_Tickets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trucks'
ALTER TABLE [dbo].[Trucks]
ADD CONSTRAINT [PK_Trucks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TicketStatus'
ALTER TABLE [dbo].[TicketStatus]
ADD CONSTRAINT [PK_TicketStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SystemConfigs'
ALTER TABLE [dbo].[SystemConfigs]
ADD CONSTRAINT [PK_SystemConfigs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PricesByClients'
ALTER TABLE [dbo].[PricesByClients]
ADD CONSTRAINT [PK_PricesByClients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Truck_Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_TruckTicket]
    FOREIGN KEY ([Truck_Id])
    REFERENCES [dbo].[Trucks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TruckTicket'
CREATE INDEX [IX_FK_TruckTicket]
ON [dbo].[Tickets]
    ([Truck_Id]);
GO

-- Creating foreign key on [Driver_Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_DriverTicket]
    FOREIGN KEY ([Driver_Id])
    REFERENCES [dbo].[Drivers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DriverTicket'
CREATE INDEX [IX_FK_DriverTicket]
ON [dbo].[Tickets]
    ([Driver_Id]);
GO

-- Creating foreign key on [Material_Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_MaterialTicket]
    FOREIGN KEY ([Material_Id])
    REFERENCES [dbo].[Materials]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialTicket'
CREATE INDEX [IX_FK_MaterialTicket]
ON [dbo].[Tickets]
    ([Material_Id]);
GO

-- Creating foreign key on [TicketStatus_Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_TicketStatusTicket]
    FOREIGN KEY ([TicketStatus_Id])
    REFERENCES [dbo].[TicketStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketStatusTicket'
CREATE INDEX [IX_FK_TicketStatusTicket]
ON [dbo].[Tickets]
    ([TicketStatus_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_CustomerTicket]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerTicket'
CREATE INDEX [IX_FK_CustomerTicket]
ON [dbo].[Tickets]
    ([Customer_Id]);
GO

-- Creating foreign key on [Material_Id] in table 'PricesByClients'
ALTER TABLE [dbo].[PricesByClients]
ADD CONSTRAINT [FK_MaterialPricesByClient]
    FOREIGN KEY ([Material_Id])
    REFERENCES [dbo].[Materials]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialPricesByClient'
CREATE INDEX [IX_FK_MaterialPricesByClient]
ON [dbo].[PricesByClients]
    ([Material_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'PricesByClients'
ALTER TABLE [dbo].[PricesByClients]
ADD CONSTRAINT [FK_CustomerPricesByClient]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerPricesByClient'
CREATE INDEX [IX_FK_CustomerPricesByClient]
ON [dbo].[PricesByClients]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------