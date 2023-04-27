/****************************************************************************************************
Usuario: WESLY SOLANO
Fecha: 27.04.2023
Observavion: PROCEDIMIENTO ALMACENADO QUE INSERTA LA INFORMACION DEL PRODUCTO
****************************************************************************************************/
CREATE PROCEDURE [dbo].[insert_producto]
@descripcion VARCHAR(250), @tipo VARCHAR(250), @tipo_precio VARCHAR(250), @cantidad INT, @precio FLOAT
	
AS BEGIN
SET NOCOUNT ON
	-- INICIO DE TRANSACCION 
	BEGIN TRANSACTION TRASA
	-- TRY
	BEGIN TRY
		-- INSERTA LA INFORMACION CON LOS PARAMETROS
		INSERT INTO TProducto
		(descripcion, tipo, tipo_precio, cantidad, precio)
		VALUES
		-- LEE LOS PARAMETROS DEL PROCEDIMIENTO
		(@descripcion, @tipo, @tipo_precio, @cantidad, @precio)
		-- APLICA LA TRANSACCION
		COMMIT TRANSACTION TRASA
		-- ASIGNA CODIGO DE MENSAJE DE ERROR
		SELECT 0 AS CodeError, '' AS MsgError
	END TRY
	BEGIN CATCH
		SELECT 
			-- RETORNA
			ERROR_NUMBER() AS CodeError,
			ERROR_MESSAGE() AS MsgError
			-- DESAPLICA LA TRANSACCION
			ROLLBACK TRANSACTION TRASA
	END CATCH


END
