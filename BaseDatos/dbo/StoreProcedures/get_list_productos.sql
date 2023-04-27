
/****************************************************************************************************
Usuario: WESLY SOLANO
Fecha: 27.04.2023
Observavion: PROCEDIMIENTO ALMACENADO QUE LISTA LA INFORMACION DE LOS PRODUCTOS
****************************************************************************************************/
CREATE PROCEDURE [dbo].get_list_productos(@in_producto_id INT)

AS BEGIN
	SET NOCOUNT ON
	SELECT descripcion, tipo, tipo_precio, cantidad, precio FROM TProducto 
	WHERE producto_id = @in_producto_id

END