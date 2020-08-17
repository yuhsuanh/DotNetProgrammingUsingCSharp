/* Create Database */
CREATE DATABASE [UsedVehicleSystem];


/* Create Make Table */
CREATE TABLE [dbo].[Make] (
    [MakeId]     INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [CreateDate] DATETIME     NOT NULL,
    [EditDate]   DATETIME     NULL,
    CONSTRAINT [PK_Make] PRIMARY KEY CLUSTERED ([MakeId] ASC)
);

/* Create Vehicle Type Table */
CREATE TABLE [dbo].[VehicleType] (
    [VehicleTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [CreateDate]    DATETIME     NOT NULL,
    [EditDate]      DATETIME     NULL,
    CONSTRAINT [PK_VehicleType] PRIMARY KEY CLUSTERED ([VehicleTypeId] ASC)
);

/* Create Vehicle Model Table */
CREATE TABLE [dbo].[VehicleModel] (
    [ModelId]       INT          IDENTITY (1, 1) NOT NULL,
    [ModelName]     VARCHAR (50) NOT NULL,
    [EngineSize]    INT          NULL,
    [NumberOfDoors] INT          NULL,
    [Colour]        VARCHAR (50) NULL,
    [VehicleTypeId] INT          NULL,
    [CreateDate]    DATETIME     NOT NULL,
    [EditDate]      DATETIME     NULL,
    CONSTRAINT [PK_VehicleModel] PRIMARY KEY CLUSTERED ([ModelId] ASC),
    CONSTRAINT [FK_VehicleModel_VehicleType] FOREIGN KEY ([VehicleTypeId]) REFERENCES [dbo].[VehicleType] ([VehicleTypeId])
);

/* Create Vehicle Table */
CREATE TABLE [dbo].[Vehicle] (
    [VehicleId]  CHAR (17)       NOT NULL,
    [MakeId]     INT             NULL,
    [ModelId]    INT             NULL,
    [Year]       INT             NULL,
    [Price]      DECIMAL (10, 2) NULL,
    [Cost]       DECIMAL (10, 2) NULL,
    [SoldDate]   DATETIME        NULL,
    [CreateDate] DATETIME        NOT NULL,
    [EditDate]   DATETIME        NULL,
    CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED ([VehicleId] ASC),
    CONSTRAINT [FK_Vehicle_Make] FOREIGN KEY ([MakeId]) REFERENCES [dbo].[Make] ([MakeId]),
    CONSTRAINT [FK_Vehicle_VehicleModel] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[VehicleModel] ([ModelId])
);


