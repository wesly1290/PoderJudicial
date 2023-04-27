CREATE TABLE [dbo].[TProducto]
(
	 producto_id INT IDENTITY(1,1) CONSTRAINT PK_producto_id PRIMARY KEY CLUSTERED(producto_id) NOT NULL
   , descripcion VARCHAR(250) NOT NULL
   , tipo VARCHAR(250) NOT NULL
   , tipo_precio VARCHAR(250) NOT NULL
   , cantidad INT NOT NULL
   , precio FLOAT NOT NULL
   
)