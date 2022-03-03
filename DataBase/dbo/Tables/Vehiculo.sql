﻿CREATE TABLE [dbo].[Vehiculo]
(
IdVehiculo INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Vehiculo PRIMARY KEY CLUSTERED(IdVehiculo)
,Codigo VARCHAR(250) NULL
 ,Descripcion VARCHAR(250) NULL
 ,Valor VARCHAR(250) NOT NULL
,Estado VARCHAR(250) NOT NULL
)
WITH (DATA_COMPRESSION = PAGE)
GO
