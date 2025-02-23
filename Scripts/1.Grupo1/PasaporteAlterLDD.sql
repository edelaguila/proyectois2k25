

-- ALTERS DEL MODULO DE CONTABILIDAD 28-10-2024
ALTER TABLE tbl_cuentas

ADD COLUMN es_efectivo TINYINT DEFAULT 0 AFTER Pk_id_cuenta_enlace;
-- FIN DE ALTER 28-10-2024
    
-- Alteraciones para asegurar integridad y consistencia con el script principal

-- **1. Añadir claves primarias y auto-incrementos a las tablas referenciadas**

-- Primero, aseguramos que `tbl_recetas` tenga su clave primaria definida
ALTER TABLE `tbl_recetas`
    ADD PRIMARY KEY (`Pk_id_receta`),
    MODIFY `Pk_id_receta` int(11) NOT NULL AUTO_INCREMENT;

-- Luego, definimos la clave primaria en `tbl_cierre_produccion`
ALTER TABLE `tbl_cierre_produccion`
    ADD PRIMARY KEY (`pk_id_cierre`),
    MODIFY `pk_id_cierre` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_conversiones`
ALTER TABLE `tbl_conversiones`
    ADD PRIMARY KEY (`id_conversion`),
    MODIFY `id_conversion` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_mantenimientos`
ALTER TABLE `tbl_mantenimientos`
    ADD PRIMARY KEY (`Pk_id_maquinaria`),
    MODIFY `Pk_id_maquinaria` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_ordenes_produccion`
ALTER TABLE `tbl_ordenes_produccion`
    ADD PRIMARY KEY (`Pk_id_orden`),
    MODIFY `Pk_id_orden` int(11) NOT NULL AUTO_INCREMENT;

-- **2. Añadir claves foráneas y índices en las tablas que referencian a otras**

-- Tabla `tbl_proceso_produccion_encabezado`
ALTER TABLE `tbl_proceso_produccion_encabezado`
    ADD PRIMARY KEY (`Pk_id_proceso`),
    MODIFY `Pk_id_proceso` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_maquinaria` (`Fk_id_maquinaria`),
    ADD CONSTRAINT `fk_orden_proceso_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_maquinaria_proceso_produccion` FOREIGN KEY (`Fk_id_maquinaria`) REFERENCES `tbl_mantenimientos` (`Pk_id_maquinaria`);

-- Tabla `tbl_lotes_encabezado`
ALTER TABLE `tbl_lotes_encabezado`
    ADD PRIMARY KEY (`Pk_id_lote`),
    MODIFY `Pk_id_lote` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_proceso_lote_encabezado` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_proceso_lote_encabezado` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- Tabla `tbl_lotes_detalles`
ALTER TABLE `tbl_lotes_detalles`
    ADD PRIMARY KEY (`Pk_id_lotes_detalle`),
    MODIFY `Pk_id_lotes_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD INDEX `idx_fk_lote` (`Fk_id_lote`),
    ADD CONSTRAINT `fk_producto_lotes_detalles` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_lote_lotes_detalles` FOREIGN KEY (`Fk_id_lote`) REFERENCES `tbl_lotes_encabezado` (`Pk_id_lote`);

-- Tabla `tbl_ordenes_produccion_detalle`
ALTER TABLE `tbl_ordenes_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_orden_detalle_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_producto_detalle_produccion` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_receta_detalle`
ALTER TABLE `tbl_receta_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_receta_detalle` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_producto_receta_detalle` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_proceso_produccion_detalle`
ALTER TABLE `tbl_proceso_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_proceso_detalle`),
    MODIFY `Pk_id_proceso_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_productos` (`Fk_id_productos`),
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_empleado` (`Fk_id_empleado`),
    ADD INDEX `idx_fk_proceso` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_productos_proceso_produccion` FOREIGN KEY (`Fk_id_productos`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_receta_proceso_produccion` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_empleado_proceso_produccion` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    ADD CONSTRAINT `fk_proceso_produccion` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- **3. Integración de claves foráneas en tablas existentes**

-- Aseguramos que `tbl_recetas` tenga su clave primaria antes de ser referenciada
ALTER TABLE `Tbl_Productos`
    ADD COLUMN `Fk_id_receta` INT(11),
    ADD INDEX `idx_fk_receta_producto` (`Fk_id_receta`),
    ADD CONSTRAINT `fk_receta_producto` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`);    
    
 -- Aprobado por Brandon Boch
 -- Alters de componente de producción
 -- Inicio
 -- 1. Dropeo de columnas
ALTER TABLE tbl_rrhh_produccion 
DROP COLUMN id_empleado,
DROP COLUMN id_contrato,
DROP COLUMN dias,
DROP COLUMN total_dias,
DROP COLUMN horas,
DROP COLUMN total_horas,
DROP COLUMN id_hora_extra,
DROP COLUMN total_horas_extras,
DROP COLUMN total_mano_obra,
DROP COLUMN estado;

-- 2. Se agregan las columnas
ALTER TABLE tbl_rrhh_produccion 
ADD COLUMN id_empleado INT NOT NULL,
ADD COLUMN salario DECIMAL(10, 2) NOT NULL,
ADD COLUMN dias INT NOT NULL,
ADD COLUMN total_dias DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas INT NOT NULL,
ADD COLUMN total_horas DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas_extras INT NOT NULL,
ADD COLUMN total_horas_extras DECIMAL(10, 2) NOT NULL,
ADD COLUMN total_mano_obra DECIMAL(10, 2) NOT NULL,
ADD COLUMN estado TINYINT(1) NOT NULL;

-- 3. Se dropea la columna id_RRHH
ALTER TABLE tbl_rrhh_produccion
DROP COLUMN id_RRHH;

-- 4. Se agrega el pk correcto
ALTER TABLE tbl_rrhh_produccion
ADD COLUMN pk_id_RRHH INT AUTO_INCREMENT PRIMARY KEY;
 -- Fin
-- ALTERS DEL MODULO DE LOGISTICA 31-10-2024
ALTER TABLE Tbl_TrasladoProductos
MODIFY costoTotal INT NOT NULL;
ALTER TABLE Tbl_TrasladoProductos
MODIFY costoTotalGeneral INT NOT NULL;
ALTER TABLE Tbl_TrasladoProductos
MODIFY precioTotal INT NOT NULL;

ALTER TABLE Tbl_TrasladoProductos
ADD COLUMN codigoProducto INT NOT NULL;

ALTER TABLE Tbl_chofer
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;
ALTER TABLE Tbl_remitente
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;
ALTER TABLE Tbl_destinatario
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;

ALTER TABLE Tbl_Productos
ADD COLUMN comisionInventario DOUBLE NOT NULL;
ALTER TABLE Tbl_Productos
ADD COLUMN comisionCosto DOUBLE NOT NULL;
ALTER TABLE Tbl_Marca
ADD COLUMN comision DOUBLE NOT NULL;
ALTER TABLE Tbl_Linea
ADD COLUMN comision DOUBLE NOT NULL;

-- ALTERS DEL MODULO DE CUENTAS CORRIENTES 31-10-2024

/*ALTER TABLE Tbl_caja_cliente
DROP COLUMN caja_deuda_monto,
DROP COLUMN caja_mora_monto,
DROP COLUMN caja_transaccion_monto;
ALTER TABLE Tbl_caja_cliente
ADD COLUMN Fk_id_factura INT NOT NULL;*/


-- NUEVOS ALTER DEL MODULO DE PRODUCCIÓN 03-11-2024 aprobado por Brandon Boch
-- 2. Alter para añadir la foránea a la tabla de mantenimiento
ALTER TABLE `tbl_mantenimientos`
ADD COLUMN `fk_id_maquina` int(11) NOT NULL;

ALTER TABLE `tbl_mantenimientos`
ADD CONSTRAINT `fk_maquina`
FOREIGN KEY (`fk_id_maquina`) REFERENCES `tbl_maquinaria`(`pk_id_maquina`);

-- NUEVOS ALTERS DEL MODULO DE CUENTAS CORRIENTES DEL 03/11/2024 
-- inica modulo de cuentas corrientes
ALTER TABLE Tbl_cobrador
CHANGE COLUMN cobrador_estado estado TINYINT DEFAULT 0 NOT NULL;

-- TBL_paises

ALTER TABLE Tbl_paises
CHANGE COLUMN pais_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Formadepago

ALTER TABLE Tbl_Formadepago
CHANGE COLUMN pado_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Deudas_Clientes
ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Efecto_trans VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_Deudas_Clientes 
DROP FOREIGN KEY tbl_deudas_clientes_ibfk_3;
ALTER TABLE Tbl_Deudas_Clientes 
DROP COLUMN Fk_id_pago;

-- TBL_Transaccion_clientes
ALTER TABLE Tbl_Transaccion_cliente
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_trans_cliente FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura),
ADD COLUMN Fk_id_transC INT NOT NULL,
ADD CONSTRAINT fk_transC_trans_cliente FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue),
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

-- Eliminar llaves foráneas 
ALTER TABLE Tbl_Transaccion_cliente 
DROP FOREIGN KEY tbl_transaccion_cliente_ibfk_3, 
DROP FOREIGN KEY tbl_transaccion_cliente_ibfk_2;

-- Eliminar columnas innecesarias
ALTER TABLE Tbl_Transaccion_cliente
DROP COLUMN transaccion_cuotas, 
DROP COLUMN tansaccion_cuenta,
DROP COLUMN Fk_id_pais,
DROP COLUMN Fk_id_pago,
DROP COLUMN transaccionserie;

-- TBL_mora_clientes
ALTER TABLE Tbl_mora_clientes MODIFY COLUMN morafecha VARCHAR(15) NOT NULL;

-- TBL_caja_clientes

ALTER TABLE Tbl_caja_cliente MODIFY COLUMN caja_fecha_registro VARCHAR(15) NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD COLUMN Fk_id_factura INT NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD CONSTRAINT id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_cliente
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_mora_monto, 
DROP COLUMN caja_transaccion_monto;

-- TBL_Deuda_Proveedores
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_inicio VARCHAR(150) NOT NULL;
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_vencimiento VARCHAR(150) NOT NULL;
ALTER TABLE Tbl_Deudas_Proveedores
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Deudas_Proveedores
ADD COLUMN Efecto_trans VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Deudas_Proveedores
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_id_factura2 FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_Deudas_Proveedores 
DROP FOREIGN KEY tbl_deudas_proveedores_ibfk_2;
ALTER TABLE Tbl_Deudas_Proveedores
DROP COLUMN Fk_id_pago;

-- TBL_Transaccion_proveedor
ALTER TABLE Tbl_Transaccion_proveedor
ADD COLUMN Fk_id_transC INT NOT NULL,
ADD CONSTRAINT fk_transC_trans_proveedor FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue),
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

-- Eliminar llaves foráneas 
ALTER TABLE Tbl_Transaccion_proveedor 
DROP FOREIGN KEY tbl_transaccion_proveedor_ibfk_3, 
DROP FOREIGN KEY tbl_transaccion_proveedor_ibfk_2;

-- Eliminar columnas innecesarias
ALTER TABLE Tbl_Transaccion_proveedor
DROP COLUMN tansaccion_cuotas, 
DROP COLUMN tansaccion_cuenta,
DROP COLUMN Fk_id_pais,
DROP COLUMN Fk_id_pago,
DROP COLUMN transaccion_serie;

-- TBL_caja_proveedor

ALTER TABLE Tbl_caja_proveedor MODIFY COLUMN caja_fecha_registro VARCHAR(150) NOT NULL;
ALTER TABLE Tbl_caja_proveedor
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_caja FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_proveedor
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_transaccion_monto;


-- ALTER MODULO LOGISTICA 04/11/2024
ALTER TABLE tbl_productos ADD CONSTRAINT UQ_codigoProducto UNIQUE
(codigoProducto);

-- Alter del modulo de nominas 4/11/2024
ALTER TABLE tbl_dedu_perp_emp
ADD COLUMN dedu_perp_emp_mes VARCHAR(25) NOT NULL AFTER dedu_perp_emp_cantidad;

ALTER TABLE tbl_horas_extra
MODIFY COLUMN horas_cantidad_horas INT;


-- ALTER MODULO DE LOGISTICA 05/11/2024
ALTER TABLE Tbl_Productos
ADD COLUMN precio_venta DECIMAL(10, 2) AFTER precioUnitario,
ADD COLUMN costo_compra DECIMAL(10, 2) AFTER precio_venta;
ALTER TABLE TBL_LOCALES
MODIFY FECHA_REGISTRO DATE NOT NULL;

-- ALTER MODULO COMERCIAL 06/11/2024

CREATE TABLE Tbl_clasificacionLista (
    pk_id_clasificacion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_clasificacion VARCHAR(50) NOT NULL,  
    descripcion_clasificacion VARCHAR(100),                   
    estado TINYINT NOT NULL DEFAULT 1           
);

  
ALTER TABLE tbl_lista_encabezado
  ADD COLUMN Fk_id_clasificacion INT AFTER Pk_id_lista_Encabezado;
  
ALTER TABLE tbl_lista_encabezado
  ADD CONSTRAINT fk_clasificacion
  FOREIGN KEY (Fk_id_clasificacion) REFERENCES Tbl_clasificacionLista(Pk_id_clasificacion);


ALTER TABLE tbl_lista_encabezado
  CHANGE COLUMN ListEncabezado_fecha ListEncabezado_fecha DATE;


ALTER TABLE tbl_lista_encabezado
  CHANGE COLUMN ListEncabezado_estado estado TINYINT(1) DEFAULT 1;
  

ALTER TABLE tbl_lista_encabezado
  DROP COLUMN ListEncabezado_nombre;

 ALTER TABLE tbl_cotizacion_detalle
DROP FOREIGN KEY tbl_cotizacion_detalle_ibfk_2;
 
 SHOW CREATE TABLE tbl_cotizacion_detalle;

  
ALTER TABLE Tbl_lista_detalle
DROP COLUMN Pk_id_lista_detalle;



ALTER TABLE Tbl_lista_detalle
  CHANGE COLUMN ListDetalle_preVenta ListDetalle_precio DECIMAL(10,2) NULL;


ALTER TABLE Tbl_lista_detalle
  ADD PRIMARY KEY (Fk_id_lista_Encabezado, Fk_id_Producto);  


ALTER TABLE Tbl_lista_detalle
  ADD CONSTRAINT fk_lista_encabezado FOREIGN KEY (Fk_id_lista_Encabezado) REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado),
  ADD CONSTRAINT fk_producto FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto);


ALTER TABLE Tbl_lista_detalle
  DROP COLUMN ListDetalle_descuento,
  DROP COLUMN ListDetalle_impuesto;


DROP TABLE IF EXISTS Tbl_detalle_comisiones;
DROP TABLE IF EXISTS Tbl_comisiones_encabezado;
DROP TABLE IF EXISTS Tbl_pedido_detalle;
DROP TABLE IF EXISTS Tbl_pedido_encabezado;
DROP TABLE IF EXISTS Tbl_cotizacion_detalle;
DROP TABLE IF EXISTS Tbl_cotizacion_encabezado;
DROP TABLE IF EXISTS Tbl_vendedores;
DROP TABLE IF EXISTS Tbl_detalle_ordenes_compra;
DROP TABLE IF EXISTS Tbl_ordenes_compra;

CREATE TABLE IF NOT EXISTS Tbl_vendedores (
    Pk_id_vendedor int (11) NOT NULL,
    vendedores_nombre VARCHAR(100)NOT NULL ,
    vendedores_apellido VARCHAR(100)NOT NULL ,
    vendedores_sueldo DECIMAL(10,2)NOT NULL ,
    vendedores_direccion VARCHAR(255)NOT NULL ,
    vendedores_telefono VARCHAR(20)NOT NULL ,
	Fk_id_empleado INT NOT NULL,
    estado tinyint(1) DEFAULT 1,
    FOREIGN KEY (Fk_id_empleado) REFERENCES tbl_empleados(pk_clave),
    PRIMARY KEY (Pk_id_vendedor)
);

 
 ALTER TABLE Tbl_clientes 
ADD COLUMN Cliente_Tipo VARCHAR(20) NOT NULL;

ALTER TABLE Tbl_clientes
ADD COLUMN Clientes_deuda DECIMAL(10, 2) DEFAULT 0.00;

ALTER TABLE Tbl_clientes 
ADD Fk_id_vendedor INT NOT NULL,
ADD CONSTRAINT FK_vendedor_cliente
FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor); 

ALTER TABLE Tbl_clientes 
CHANGE Clientes_estado estado TINYINT(1) DEFAULT 1;

ALTER TABLE Tbl_clientes 
ADD COLUMN Fk_id_lista_Encabezado INT NOT NULL;

ALTER TABLE Tbl_clientes 
ADD CONSTRAINT FK_id_lista_Encabezado
FOREIGN KEY (Fk_id_lista_Encabezado) 
REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado);

ALTER TABLE Tbl_proveedores
ADD COLUMN Proveedor_deuda DECIMAL(10, 2) DEFAULT 0.00;

ALTER TABLE Tbl_proveedores 
CHANGE Prov_estado estado TINYINT(1) DEFAULT 1;


CREATE TABLE IF NOT EXISTS Tbl_cotizacion_encabezado (
    Pk_id_cotizacionEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_vendedor INT,
    Fk_id_cliente INT,
    CotizacionEnc_fechaVenc DATE,
    CotizacionEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_cotizacionEnc)
);

CREATE TABLE IF NOT EXISTS Tbl_cotizacion_detalle (
    Fk_id_cotizacionEnc VARCHAR(20) NOT NULL,  
    Fk_id_producto INT,        
    CotizacionDet_cantidad INT,
    CotizacionDet_precio DECIMAL(10,2),
    CotizacionDet_subtotal decimal(10,2),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);

CREATE TABLE IF NOT EXISTS Tbl_pedido_encabezado (
    Pk_id_pedidoEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_vendedor INT  NOT NULL,
    PedidoEncfecha DATE  NOT NULL,
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_PedidoEnc)
);


CREATE TABLE IF NOT EXISTS Tbl_pedido_detalle (
    Fk_id_pedidoEnc VARCHAR(20) NOT NULL,
    Fk_id_producto INT,
    Fk_id_cotizacionEnc VARCHAR(20) NOT NULL,
    PedidoDet_cantidad int,
    PedidoEnc_precio decimal(10,2),
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_pedidoEnc) REFERENCES Tbl_pedido_encabezado(Pk_id_pedidoEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    PRIMARY KEY (Fk_id_pedidoEnc, Fk_id_producto,Fk_id_cotizacionEnc)
);

SET foreign_key_checks = 0;
ALTER TABLE Tbl_pedido_encabezado 
    MODIFY Pk_id_PedidoEnc VARCHAR(20) NOT NULL UNIQUE;
SET foreign_key_checks = 1;


SET foreign_key_checks = 0;
ALTER TABLE Tbl_pedido_detalle 
    MODIFY Fk_id_pedidoEnc VARCHAR(20) NOT NULL,
    MODIFY Fk_id_cotizacionEnc VARCHAR(20),
    DROP PRIMARY KEY,
    ADD PRIMARY KEY (Fk_id_pedidoEnc, Fk_id_producto, Fk_id_cotizacionEnc);




DROP TABLE IF EXISTS Tbl_factura_detalle;
DROP TABLE IF EXISTS Tbl_factura_encabezado;

CREATE TABLE IF NOT EXISTS Tbl_factura_encabezado (
    Pk_id_facturaEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_vendedor INT,
    Fk_id_cliente INT,
    Fk_id_PeidoEnc INT,
    CotizacionEnc_fechaCrea DATE,
    CotizacionEnc_fechaVenc DATE,
    factura_formPago ENUM('al contado', 'al crédito') NOT NULL,
    factura_subtotal DECIMAL(10,2)  NOT NULL,
    factura_iva DECIMAL(4, 2) NOT NULL DEFAULT 0.12,
	facturaEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_facturaEnc)
);

-- Tabla factura Detalle
CREATE TABLE IF NOT EXISTS Tbl_factura_detalle (
    fk_id_facturaEnc VARCHAR(20) NOT NULL,  
    Fk_id_producto INT,        
    facturaDet_cantidad INT,
    facturaDet_precio DECIMAL(10,2),
    facturaDet_subtotal decimal(10,2),
    FOREIGN KEY (fk_id_facturaEnc) REFERENCES Tbl_factura_encabezado(Pk_id_facturaEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);


CREATE TABLE IF NOT EXISTS Tbl_comisiones_encabezado (
    Pk_id_comisionEnc INT(11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Comisiones_fecha_ DATE NOT NULL,
    Comisiones_total_venta DECIMAL(10,2) NOT NULL,
    Comisiones_total_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_comisionEnc)
);

CREATE TABLE IF NOT EXISTS Tbl_detalle_comisiones (
    Pk_id_detalle_comision INT(11) NOT NULL,
    Fk_id_comisionEnc INT NOT NULL,
    Fk_id_facturaEnc VARCHAR(20) NOT NULL,
    Comisiones_porcentaje DECIMAL(5,2) NOT NULL,
    Comisiones_monto_venta DECIMAL(10,2) NOT NULL,
    Comisiones_monto_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_comisionEnc) REFERENCES Tbl_comisiones_encabezado(Pk_id_comisionEnc),
    FOREIGN KEY (Fk_id_facturaEnc) REFERENCES Tbl_factura_encabezado(Pk_id_facturaEnc),
    PRIMARY KEY (Pk_id_detalle_comision)
);

CREATE TABLE IF NOT EXISTS Tbl_EncabezadoOrdenCompra(
    PK_encOrCom_numeroOC VARCHAR(20) NOT NULL UNIQUE,
    Fk_prov_id INT,
	EncOrCom_fechaEntrega DATE,
	total DECIMAL(10, 2),
    FOREIGN KEY (Fk_prov_id) REFERENCES Tbl_proveedores(Pk_prov_id),
    PRIMARY KEY (PK_encOrCom_numeroOC)
);
CREATE TABLE IF NOT EXISTS Tbl_DetalleOrdenesCompra (
    FK_encOrCom_numeroOC VARCHAR(20) NOT NULL,
    FK_codigoProducto INT,
    DetOrCom_precioU DECIMAL(10,2),
    DetOrCom_cantidad INT NOT NULL,
    DetOrCom_total DECIMAL(10,2),
    FOREIGN KEY (FK_encOrCom_numeroOC) REFERENCES Tbl_EncabezadoOrdenCompra(PK_encOrCom_numeroOC),
    FOREIGN KEY (FK_codigoProducto) REFERENCES Tbl_Productos(codigoProducto),
    PRIMARY KEY ( FK_encOrCom_numeroOC, FK_codigoProducto)
);



-- CREACION DE TABLAS DEL MODULO DE PRODUCCION  06/11/2024
CREATE TABLE IF NOT EXISTS tbl_implosion ( 
    pk_id_implosion INT(11) NOT NULL AUTO_INCREMENT,
    fk_id_orden INT(11) DEFAULT NULL, -- Relacionado con la orden de producción
    fk_id_producto_final INT(11) DEFAULT NULL, -- Producto final que se construye
    id_componente VARCHAR(50) DEFAULT NULL, -- Componente utilizado en la consolidación, ahora como string
    cantidad_componente INT(11) DEFAULT NULL, -- Cantidad de cada componente
    costo_componente INT(11) DEFAULT NULL, -- Costo de cada componente
    duracion_horas INT(11) DEFAULT NULL, -- Duración en horas para consolidar el componente
    fk_id_proceso INT(11) DEFAULT NULL, -- Relación con el proceso de producción
    fecha_implosion DATETIME DEFAULT NULL, -- Fecha de la implosión
    PRIMARY KEY (pk_id_implosion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS tbl_explosion (
pk_id_explosion INT(11) NOT NULL AUTO_INCREMENT,
fk_id_orden INT(11) DEFAULT NULL, -- Relacionado con la orden de producción
fk_id_producto INT(11) DEFAULT NULL, -- Producto que se descompone
cantidad INT(11) DEFAULT NULL, -- Cantidad de producto a descomponer
costo_total DECIMAL(10,2) DEFAULT NULL, -- Costo total de la descomposición
duracion_horas INT(11) DEFAULT NULL, -- Duración en horas
fk_id_proceso INT(11) DEFAULT NULL, -- Relación con el proceso
fecha_explosion DATE DEFAULT NULL, -- Fecha de la explosión
PRIMARY KEY (pk_id_explosion),
FOREIGN KEY (fk_id_producto) REFERENCES tbl_productos(pk_id_producto),
FOREIGN KEY (fk_id_proceso) REFERENCES tbl_proceso_produccion_encabezado(pk_id_proceso)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- CUENTAS CORRIENTES 07/11/2024

DROP TABLE Tbl_paises;
Drop table Tbl_Formadepago;

-- PRODUCCION 08/11/024
ALTER TABLE tbl_recetas
ADD COLUMN `dias` INT(11) NULL,
ADD COLUMN `horas` DECIMAL(10,2) NULL;

-- COMERCIAL 10/11/2024
CREATE TABLE IF NOT EXISTS Tbl_ComprasRealizadas (
    PK_noCompra VARCHAR(20) NOT NULL UNIQUE, 
    Fk_prov_id INT,                             
    CR_FechaCompra DATETIME,                       
    CR_TotalCompra DECIMAL(18,2),                 
    CR_CodigoProducto INT,                         
    CR_PrecioU DECIMAL(18,2),                    
    CR_Cantidad INT,                               
    CR_TotalDetalle DECIMAL(18,2),  
     PRIMARY KEY (PK_noCompra),
    FOREIGN KEY (Fk_prov_id) REFERENCES Tbl_proveedores(Pk_prov_id)
);

