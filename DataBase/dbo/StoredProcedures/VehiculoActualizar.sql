CREATE PROCEDURE [dbo].[VehiculoActualizar]
	@IdVehiculo INT,
	@Codigo VARCHAR(250),
	@Descripcion VARCHAR(250),
	@Valor VARCHAR(250),
	@Estado BIT
	
AS 
BEGIN 
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA 

		BEGIN TRY
			UPDATE dbo.Vehiculo SET
			 Codigo = @Codigo,
			 Descripcion = @Descripcion,
			 Valor = @Valor,
			 Estado = @Estado
			 WHERE 
				IdVehiculo = @IdVehiculo

			COMMIT TRANSACTION TRASA
			SELECT 0 AS CodeError,'' AS MsgError
		END TRY

		BEGIN CATCH
			SELECT 
				ERROR_NUMBER() AS CodeError,
				ERROR_MESSAGE() AS MsgError
			ROLLBACK TRANSACTION TRASA
		END CATCH

	END