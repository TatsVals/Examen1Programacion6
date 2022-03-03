CREATE PROCEDURE [dbo].[VehiculoObtener]
	@IdVehiculo int = NULL
AS
BEGIN
	SET NOCOUNT ON

	SELECT 
			IdVehiculo,
			Codigo,
			Descripcion,
			Valor,
			Estado
	
	FROM dbo.Vehiculo
	WHERE
		(@IdVehiculo IS NULL OR IdVehiculo=@IdVehiculo )
END
