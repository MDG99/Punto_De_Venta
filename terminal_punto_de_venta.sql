
--Tables design

DROP TABLE IF EXISTS [usuarios];
DROP TABLE IF EXISTS [metodos_de_pago];
DROP TABLE IF EXISTS [categorias];
DROP TABLE IF EXISTS [productos];
DROP TABLE IF EXISTS [registro_ventas];

CREATE TABLE [usuarios](
       [id] INTEGER PRIMARY KEY,
       [nombre] TEXT NOT NULL,
       [apellido] TEXT NOT NULL,
       [edad] INTEGER NOT NULL,
       [administracion] INTEGER NOT NULL,
       [estado] INTEGER NOT NULL);
       
CREATE TABLE [metodos_de_pago](
       [id] INTEGER PRIMARY KEY,
       [tipo] TEXT NOT NULL,
       [porcentaje_impuesto] INTEGER NOT NULL);
       
CREATE TABLE [categorias] (
       [id] INTEGER PRIMARY KEY,
       [descripcion] TEXT NOT NULL UNIQUE);
       
CREATE TABLE [productos](
       [id] INTEGER PRIMARY KEY,
       [categoria_id] INTEGER NOT NULL REFERENCES categorias([id]),
       [nombre] TEXT NOT NULL UNIQUE,
       [descripcion] TEXT NOT NULL,
       [precio] REAL NOT NULL,
       [cantidad] INTEGER NOT NULL,
       CHECK([precio]>0),
       CHECK([cantidad]>=0));
       
CREATE TABLE [registro_ventas](
       [id] INTEGER PRIMARY KEY,
       [fecha_dia] TEXT NOT NULL,
       [fecha_mes] TEXT NOT NULL,
       [fecha_año] TEXT NOT NULL,
       [producto_id] INTEGER NOT NULL REFERENCES productos([id]),
       [cantidad] INTEGER NOT NULL,
       [pago_id] INTEGER NOT NULL REFERENCES metodos_de_pago(id),
       [usuario_id] TEXT NOT NULL REFERENCES usuarios([id]), 
       CHECK(0<[fecha_dia]<32),
       CHECK(0<[fecha_mes]<13),
       CHECK([cantidad]>0) );
       
       
--DATA
       
 
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (000, 'Juan', 'Perez', 20, 1, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (001, 'Jose', 'Herrera', 25, 0, 0);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (002, 'Pedro', 'Quintal', 23, 0, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (003, 'Roman', 'Lopez', 24, 1, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (004, 'Carlos', 'Carballo', 19, 0, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (005, 'Toño', 'Rios', 30, 0, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (006, 'Nestor', 'Chi', 21, 0, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (007, 'Angel', 'Gual', 26, 0, 0);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (008, 'Andrea', 'Rodriguez', 24, 1, 1);
INSERT INTO usuarios (id, nombre, apellido, edad, administracion, estado) VALUES (009, 'Frida', 'Diaz', 32, 0, 1);


INSERT INTO metodos_de_pago (id, tipo, porcentaje_impuesto) VALUES (01, 'efectivo', 0);
INSERT INTO metodos_de_pago (id, tipo, porcentaje_impuesto) VALUES (02, 'debito', 0);
INSERT INTO metodos_de_pago (id, tipo, porcentaje_impuesto) VALUES (03, 'credito', 3);


INSERT INTO categorias (id, descripcion) VALUES (01, 'bebidas');
INSERT INTO categorias (id, descripcion) VALUES (02, 'golosinas');
INSERT INTO categorias (id, descripcion) VALUES (03, 'limpieza');
INSERT INTO categorias (id, descripcion) VALUES (04, 'desechables');
INSERT INTO categorias (id, descripcion) VALUES (05, 'lacteos');


INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0001, 01, 'epura 1 litros', 'agua purificada', 10.50, 4);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0002, 1, 'coca cola 600ml', 'refresco sabor cola', 15.20, 10);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0003, 2, 'chetos flamin hot 350gr', 'botana picante hecha de maiz inflado', 13, 8);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0004, 2, 'clorets 25gr', 'chicles sabor menta', 7.00, 23);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0005, 3, 'servimax 100 hojas', 'servilletas', 30.95, 65);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0006, 3, 'stochbrite doble', 'esponjas 2 x 1', 15.10, 40);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0007, 4, 'partyspoon', 'cucharas 100 pz', 25.05, 37);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0008, 4, 'partyfork', 'tenedores 100 pz', 25.00, 39);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0009, 5, 'oikos 150 gr', 'yogurth natural', 15.60, 50);
INSERT INTO productos (id, categoria_id, nombre, descripcion, precio, cantidad)
VALUES (0010, 5, 'san marcos semidescremada', 'leche semidescremada 1 lt', 25.83, 37);


INSERT INTO registro_ventas (id, fecha_dia, fecha_mes, fecha_año, producto_id, cantidad, pago_id, usuario_id) VALUES (001, 5, 11, 2018, 0002, 2, 01, 006);
INSERT INTO registro_ventas (id, fecha_dia, fecha_mes, fecha_año, producto_id, cantidad, pago_id, usuario_id) VALUES (002, 7, 12, 2018, 0001, 4, 02, 006);
INSERT INTO registro_ventas (id, fecha_dia, fecha_mes, fecha_año, producto_id, cantidad, pago_id, usuario_id) VALUES (003, 2, 1, 2019, 0003, 1, 03, 005);
INSERT INTO registro_ventas (id, fecha_dia, fecha_mes, fecha_año, producto_id, cantidad, pago_id, usuario_id) VALUES (004, 3, 1, 2019, 0003, 2, 01, 005);










