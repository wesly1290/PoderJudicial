/****************************************************************************************************
Usuario: WESLY SOLANO
Fecha: 27.04.2023
Observavion: PROCEDIMIENTO ALMACENADO QUE INSERTA LA INFORMACION DEL PRODUCTO
****************************************************************************************************/
CREATE PROCEDURE [dbo].[get_list_producto]
AS
	BEGIN
	SET NOCOUNT ON
	SELECT producto_id, descripcion, tipo, tipo_precio, cantidad, precio FROM TProducto 
	END
