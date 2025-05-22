-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: colchoneria
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ayuda`
--

DROP TABLE IF EXISTS `ayuda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ayuda` (
  `Id_ayuda` int NOT NULL AUTO_INCREMENT,
  `Ruta` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `indice` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id_ayuda`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_activofijo`
--

DROP TABLE IF EXISTS `tbl_activofijo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_activofijo` (
  `Pk_Id_ActivoFijo` int NOT NULL AUTO_INCREMENT,
  `Codigo_Activo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Pk_Id_TipoActivoFijo` int DEFAULT NULL,
  `Descripcion` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `Pk_Id_Identidad` int DEFAULT NULL,
  `Modelo` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Fecha_Adquisicion` date DEFAULT NULL,
  `Costo_Adquisicion` decimal(10,2) DEFAULT NULL,
  `Vida_Util` decimal(5,2) DEFAULT NULL,
  `Valor_Residual` decimal(10,2) DEFAULT NULL,
  `Estado` tinyint DEFAULT NULL,
  `Pk_Id_Cuenta` int NOT NULL,
  PRIMARY KEY (`Pk_Id_ActivoFijo`),
  UNIQUE KEY `Codigo_Activo` (`Codigo_Activo`),
  KEY `Fk_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`),
  KEY `Fk_Identidad` (`Pk_Id_Identidad`),
  KEY `Fk_Cuenta` (`Pk_Id_Cuenta`),
  CONSTRAINT `Fk_Cuenta_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`) ON DELETE CASCADE,
  CONSTRAINT `Fk_Identidad_New` FOREIGN KEY (`Pk_Id_Identidad`) REFERENCES `tbl_identidadactivo` (`Pk_Id_Identidad`) ON DELETE SET NULL,
  CONSTRAINT `Fk_TipoActivoFijo_New` FOREIGN KEY (`Pk_Id_TipoActivoFijo`) REFERENCES `tbl_tipoactivofijo` (`Pk_Id_TipoActivoFijo`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicaciones` (
  `Pk_id_aplicacion` int NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`Pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_asignacion_modulo_aplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacion_modulo_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_id_modulos` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  PRIMARY KEY (`Fk_id_modulos`,`Fk_id_aplicacion`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_asignacion_vacaciones`
--

DROP TABLE IF EXISTS `tbl_asignacion_vacaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion_vacaciones` (
  `pk_registro_vaciones` int NOT NULL AUTO_INCREMENT,
  `asignacion_vacaciones_descripcion` varchar(25) DEFAULT NULL,
  `asignacion_vacaciones_fecha_inicio` date DEFAULT NULL,
  `asignacion_vacaciones_fecha_fin` date DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_vaciones`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_asignacion_vacaciones_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_asignaciones_perfils_usuario`
--

DROP TABLE IF EXISTS `tbl_asignaciones_perfils_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignaciones_perfils_usuario` (
  `PK_id_Perfil_Usuario` int NOT NULL AUTO_INCREMENT,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_perfil` int NOT NULL,
  PRIMARY KEY (`PK_id_Perfil_Usuario`),
  KEY `Fk_id_usuario` (`Fk_id_usuario`),
  KEY `Fk_id_perfil` (`Fk_id_perfil`),
  CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_asistencias`
--

DROP TABLE IF EXISTS `tbl_asistencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asistencias` (
  `pk_id_asistencia` int NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `hora_entrada` time DEFAULT NULL,
  `hora_salida` time DEFAULT NULL,
  `estado_asistencia` varchar(255) NOT NULL,
  `observaciones` text,
  `fk_clave_empleado` int NOT NULL,
  PRIMARY KEY (`pk_id_asistencia`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_asistencias_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_auditorias`
--

DROP TABLE IF EXISTS `tbl_auditorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_auditorias` (
  `Pk_ID_AUDITORIA` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_BODEGA` int NOT NULL,
  `Fk_ID_PRODUCTO` int NOT NULL,
  `FECHA_AUDITORIA` date DEFAULT NULL,
  `DISCREPANCIA_DETECTADA` tinyint(1) DEFAULT '0',
  `CANTIDAD_REGISTRADA` int NOT NULL,
  `CANTIDAD_FISICA` int NOT NULL,
  `OBSERVACIONES` text,
  PRIMARY KEY (`Pk_ID_AUDITORIA`),
  KEY `Fk_ID_BODEGA` (`Fk_ID_BODEGA`),
  KEY `Fk_ID_PRODUCTO` (`Fk_ID_PRODUCTO`),
  CONSTRAINT `tbl_auditorias_ibfk_1` FOREIGN KEY (`Fk_ID_BODEGA`) REFERENCES `tbl_bodegas` (`Pk_ID_BODEGA`),
  CONSTRAINT `tbl_auditorias_ibfk_2` FOREIGN KEY (`Fk_ID_PRODUCTO`) REFERENCES `tbl_productos` (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_banco`
--

DROP TABLE IF EXISTS `tbl_banco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_banco` (
  `pk_banco_id` int NOT NULL AUTO_INCREMENT,
  `banco_nombre` varchar(100) NOT NULL,
  PRIMARY KEY (`pk_banco_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacora` (
  `Pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(200) NOT NULL,
  `tabla` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_bitacora`),
  KEY `Fk_id_usuario` (`Fk_id_usuario`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  CONSTRAINT `tbl_bitacora_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=200 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_bodegas`
--

DROP TABLE IF EXISTS `tbl_bodegas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bodegas` (
  `Pk_ID_BODEGA` int NOT NULL AUTO_INCREMENT,
  `NOMBRE_BODEGA` varchar(100) NOT NULL,
  `UBICACION` varchar(255) NOT NULL,
  `CAPACIDAD` int NOT NULL,
  `FECHA_REGISTRO` date DEFAULT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_ID_BODEGA`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_caja_cliente`
--

DROP TABLE IF EXISTS `tbl_caja_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_caja_cliente` (
  `Pk_id_caja_cliente` int NOT NULL AUTO_INCREMENT,
  `Fk_id_cliente` int NOT NULL,
  `caja_cliente_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `Fk_id_deuda` int NOT NULL,
  `caja_deuda_monto` decimal(10,2) NOT NULL,
  `caja_mora_monto` decimal(10,2) NOT NULL,
  `caja_transaccion_monto` decimal(10,2) NOT NULL,
  `caja_saldo_restante` decimal(10,2) NOT NULL DEFAULT '0.00',
  `caja_estado` tinyint NOT NULL DEFAULT '1',
  `caja_fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Pk_id_caja_cliente`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_deuda` (`Fk_id_deuda`),
  CONSTRAINT `tbl_caja_cliente_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_caja_cliente_ibfk_2` FOREIGN KEY (`Fk_id_deuda`) REFERENCES `tbl_deudas_clientes` (`Pk_id_deuda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_caja_proveedor`
--

DROP TABLE IF EXISTS `tbl_caja_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_caja_proveedor` (
  `Pk_id_caja_proveedor` int NOT NULL AUTO_INCREMENT,
  `Fk_id_proveedor` int NOT NULL,
  `caja_proveedor_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `Fk_id_deuda` int NOT NULL,
  `caja_deuda_monto` decimal(10,2) NOT NULL,
  `caja_transaccion_monto` decimal(10,2) NOT NULL,
  `caja_saldo_restante` decimal(10,2) NOT NULL DEFAULT '0.00',
  `caja_estado` tinyint NOT NULL DEFAULT '1',
  `caja_fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Pk_id_caja_proveedor`),
  KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  KEY `Fk_id_deuda` (`Fk_id_deuda`),
  CONSTRAINT `tbl_caja_proveedor_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  CONSTRAINT `tbl_caja_proveedor_ibfk_2` FOREIGN KEY (`Fk_id_deuda`) REFERENCES `tbl_deudas_proveedores` (`Pk_id_deuda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_chofer`
--

DROP TABLE IF EXISTS `tbl_chofer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_chofer` (
  `Pk_id_chofer` int NOT NULL AUTO_INCREMENT,
  `nombreEmpresa` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `licencia` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_chofer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cierre_produccion`
--

DROP TABLE IF EXISTS `tbl_cierre_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cierre_produccion` (
  `pk_id_cierre` int NOT NULL,
  `fecha` date NOT NULL,
  `saldo_anterior` decimal(10,2) NOT NULL,
  `cargos_mes` decimal(10,2) NOT NULL,
  `abonos_mes` decimal(10,2) NOT NULL,
  `saldo_actual` decimal(10,2) NOT NULL,
  `cargos_acumulados` decimal(10,2) NOT NULL,
  `abonos_acumulados` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_clientes` (
  `Pk_id_cliente` int NOT NULL,
  `Clientes_nombre` varchar(100) NOT NULL,
  `Clientes_apellido` varchar(100) NOT NULL,
  `Clientes_nit` varchar(20) NOT NULL,
  `Clientes_telefon` varchar(20) NOT NULL,
  `Clientes_direccion` varchar(255) NOT NULL,
  `Clientes_No_Cuenta` varchar(255) NOT NULL,
  `Clientes_estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Pk_id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cobrador`
--

DROP TABLE IF EXISTS `tbl_cobrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cobrador` (
  `Pk_id_cobrador` int NOT NULL AUTO_INCREMENT,
  `Fk_id_empleado` int NOT NULL,
  `cobrador_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `cobrador_direccion` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `cobrador_telefono` int NOT NULL,
  `cobrador_depto` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `cobrador_estado` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`Pk_id_cobrador`),
  KEY `Fk_id_empleado` (`Fk_id_empleado`),
  CONSTRAINT `tbl_cobrador_ibfk_1` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_comisiones_encabezado`
--

DROP TABLE IF EXISTS `tbl_comisiones_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_comisiones_encabezado` (
  `Pk_id_comisionEnc` int NOT NULL,
  `Fk_id_vendedor` int NOT NULL,
  `Comisiones_fecha_` date NOT NULL,
  `Comisiones_total_venta` decimal(10,2) NOT NULL,
  `Comisiones_total_comision` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Pk_id_comisionEnc`),
  KEY `Fk_id_vendedor` (`Fk_id_vendedor`),
  CONSTRAINT `tbl_comisiones_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_configuracion`
--

DROP TABLE IF EXISTS `tbl_configuracion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_configuracion` (
  `Pk_id_config` int NOT NULL AUTO_INCREMENT,
  `mes` int NOT NULL,
  `anio` int NOT NULL,
  `metodo` varchar(10) NOT NULL,
  `Pk_id_cuenta` int NOT NULL,
  PRIMARY KEY (`Pk_id_config`),
  KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  CONSTRAINT `tbl_configuracion_ibfk_1` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_consultainteligente`
--

DROP TABLE IF EXISTS `tbl_consultainteligente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_consultainteligente` (
  `Pk_consultaID` int NOT NULL AUTO_INCREMENT,
  `nombre_consulta` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `tipo_consulta` int NOT NULL,
  `consulta_SQLE` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `consulta_estatus` int NOT NULL,
  PRIMARY KEY (`Pk_consultaID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_contabilidad`
--

DROP TABLE IF EXISTS `tbl_contabilidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_contabilidad` (
  `Pk_id_contabilidad` int NOT NULL,
  `Contabilidad_tipo_registro` varchar(50) NOT NULL,
  `Contabilidad_descripcion` varchar(255) NOT NULL,
  PRIMARY KEY (`Pk_id_contabilidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_contratos`
--

DROP TABLE IF EXISTS `tbl_contratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_contratos` (
  `pk_id_contrato` int NOT NULL AUTO_INCREMENT,
  `contratos_fecha_creacion` date NOT NULL,
  `contratos_salario` decimal(10,2) NOT NULL,
  `contratos_tipo_contrato` varchar(35) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_id_contrato`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_contratos_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_control_anticipos`
--

DROP TABLE IF EXISTS `tbl_control_anticipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_control_anticipos` (
  `pk_registro_anticipos` int NOT NULL AUTO_INCREMENT,
  `anticipos_cantidad` decimal(10,2) DEFAULT NULL,
  `anticipos_descripcion` varchar(50) DEFAULT NULL,
  `anticipos_mes` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_anticipos`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_control_anticipos_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_control_faltas`
--

DROP TABLE IF EXISTS `tbl_control_faltas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_control_faltas` (
  `pk_registro_faltas` int NOT NULL AUTO_INCREMENT,
  `faltas_fecha_falta` date DEFAULT NULL,
  `faltas_mes` varchar(25) DEFAULT NULL,
  `faltas_justificacion` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_faltas`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_control_faltas_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_conversiones`
--

DROP TABLE IF EXISTS `tbl_conversiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_conversiones` (
  `id_conversion` int NOT NULL,
  `unidad_origen` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `unidad_destino` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `factor_conversion` decimal(10,6) NOT NULL,
  `tipo_conversion` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cotizacion_detalle`
--

DROP TABLE IF EXISTS `tbl_cotizacion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cotizacion_detalle` (
  `Pk_id_CotizacionDet` int NOT NULL,
  `Fk_id_cotizacionEnc` int NOT NULL,
  `Fk_id_producto` int NOT NULL,
  `CotizacionDet_cantidad` int NOT NULL,
  `CotizacionDet_precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Pk_id_CotizacionDet`),
  KEY `Fk_id_cotizacionEnc` (`Fk_id_cotizacionEnc`),
  KEY `Fk_id_producto` (`Fk_id_producto`),
  CONSTRAINT `tbl_cotizacion_detalle_ibfk_1` FOREIGN KEY (`Fk_id_cotizacionEnc`) REFERENCES `tbl_cotizacion_encabezado` (`Pk_id_cotizacionEnc`),
  CONSTRAINT `tbl_cotizacion_detalle_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_lista_detalle` (`Pk_id_lista_detalle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cotizacion_encabezado`
--

DROP TABLE IF EXISTS `tbl_cotizacion_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cotizacion_encabezado` (
  `Pk_id_cotizacionEnc` int NOT NULL,
  `Fk_id_vendedor` int NOT NULL,
  `Fk_id_cliente` int NOT NULL,
  `CotizacionEnc_fechaVenc` date NOT NULL,
  `CotizacionEnc_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_cotizacionEnc`),
  KEY `Fk_id_vendedor` (`Fk_id_vendedor`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  CONSTRAINT `tbl_cotizacion_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`),
  CONSTRAINT `tbl_cotizacion_encabezado_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cuentabancaria`
--

DROP TABLE IF EXISTS `tbl_cuentabancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentabancaria` (
  `pk_cuenta_id` int NOT NULL AUTO_INCREMENT,
  `fk_banco_id` int NOT NULL,
  `cuenta_numero` varchar(20) NOT NULL,
  `cuenta_saldo` decimal(10,2) NOT NULL,
  `cuenta_tipo` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_cuenta_id`),
  UNIQUE KEY `cuenta_numero` (`cuenta_numero`),
  KEY `fk_banco` (`fk_banco_id`),
  CONSTRAINT `fk_banco` FOREIGN KEY (`fk_banco_id`) REFERENCES `tbl_banco` (`pk_banco_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_cuentas`
--

DROP TABLE IF EXISTS `tbl_cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas` (
  `Pk_id_cuenta` int NOT NULL,
  `Pk_id_tipocuenta` int NOT NULL,
  `Pk_id_encabezadocuenta` int NOT NULL,
  `nombre_cuenta` varchar(50) NOT NULL,
  `cargo_mes` float DEFAULT '0',
  `abono_mes` float DEFAULT '0',
  `saldo_ant` float DEFAULT '0',
  `saldo_act` float DEFAULT '0',
  `cargo_acumulado` float DEFAULT '0',
  `abono_acumulado` float DEFAULT '0',
  `Pk_id_cuenta_enlace` int DEFAULT NULL,
  `estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_id_cuenta`,`Pk_id_tipocuenta`,`Pk_id_encabezadocuenta`),
  UNIQUE KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  KEY `Pk_id_tipocuenta` (`Pk_id_tipocuenta`),
  KEY `Pk_id_encabezadocuenta` (`Pk_id_encabezadocuenta`),
  KEY `Pk_id_cuenta_enlace` (`Pk_id_cuenta_enlace`),
  CONSTRAINT `tbl_cuentas_ibfk_1` FOREIGN KEY (`Pk_id_tipocuenta`) REFERENCES `tbl_tipocuenta` (`PK_id_tipocuenta`),
  CONSTRAINT `tbl_cuentas_ibfk_2` FOREIGN KEY (`Pk_id_encabezadocuenta`) REFERENCES `tbl_encabezadoclasecuenta` (`Pk_id_encabezadocuenta`),
  CONSTRAINT `tbl_cuentas_ibfk_3` FOREIGN KEY (`Pk_id_cuenta_enlace`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_datos_pedido`
--

DROP TABLE IF EXISTS `tbl_datos_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_datos_pedido` (
  `Pk_id_guia` int NOT NULL AUTO_INCREMENT,
  `fechaEmision` date NOT NULL,
  `fechaTraslado` date NOT NULL,
  `direccionPartida` varchar(255) NOT NULL,
  `direccionLlegada` varchar(255) NOT NULL,
  `numeroOrdenRecojo` varchar(20) DEFAULT NULL,
  `formaPago` varchar(50) NOT NULL,
  `destino` varchar(255) NOT NULL,
  `Fk_id_remitente` int NOT NULL,
  `Fk_id_destinatario` int NOT NULL,
  `Fk_id_vehiculo` int NOT NULL,
  PRIMARY KEY (`Pk_id_guia`),
  KEY `Fk_id_remitente` (`Fk_id_remitente`),
  KEY `Fk_id_destinatario` (`Fk_id_destinatario`),
  KEY `Fk_id_vehiculo` (`Fk_id_vehiculo`),
  CONSTRAINT `tbl_datos_pedido_ibfk_1` FOREIGN KEY (`Fk_id_remitente`) REFERENCES `tbl_remitente` (`Pk_id_remitente`),
  CONSTRAINT `tbl_datos_pedido_ibfk_2` FOREIGN KEY (`Fk_id_destinatario`) REFERENCES `tbl_destinatario` (`Pk_id_destinatario`),
  CONSTRAINT `tbl_datos_pedido_ibfk_3` FOREIGN KEY (`Fk_id_vehiculo`) REFERENCES `tbl_vehiculos` (`Pk_id_vehiculo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_dedu_perp`
--

DROP TABLE IF EXISTS `tbl_dedu_perp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_dedu_perp` (
  `pk_dedu_perp` int NOT NULL AUTO_INCREMENT,
  `dedu_perp_clase` varchar(25) DEFAULT NULL,
  `dedu_perp_concepto` varchar(25) DEFAULT NULL,
  `dedu_perp_tipo` varchar(25) DEFAULT NULL,
  `dedu_perp_aplicacion` varchar(25) DEFAULT NULL,
  `dedu_perp_excepcion` tinyint(1) DEFAULT NULL,
  `dedu_perp_monto` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_dedu_perp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_dedu_perp_emp`
--

DROP TABLE IF EXISTS `tbl_dedu_perp_emp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_dedu_perp_emp` (
  `pk_dedu_perp_emp` int NOT NULL AUTO_INCREMENT,
  `Fk_clave_empleado` int NOT NULL,
  `Fk_dedu_perp` int NOT NULL,
  `dedu_perp_emp_cantidad` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_dedu_perp_emp`),
  KEY `Fk_clave_empleado` (`Fk_clave_empleado`),
  KEY `Fk_dedu_perp` (`Fk_dedu_perp`),
  CONSTRAINT `tbl_dedu_perp_emp_ibfk_1` FOREIGN KEY (`Fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  CONSTRAINT `tbl_dedu_perp_emp_ibfk_2` FOREIGN KEY (`Fk_dedu_perp`) REFERENCES `tbl_dedu_perp` (`pk_dedu_perp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_departamentos`
--

DROP TABLE IF EXISTS `tbl_departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_departamentos` (
  `pk_id_departamento` int NOT NULL AUTO_INCREMENT,
  `departamentos_nombre_departamento` varchar(50) DEFAULT NULL,
  `departamentos_descripcion` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_id_departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_depreciacion_activofijo`
--

DROP TABLE IF EXISTS `tbl_depreciacion_activofijo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_depreciacion_activofijo` (
  `Pk_Id_Depreciacion` int NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` int NOT NULL,
  `Nombre_Activo` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Tipo_Activo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Encargado` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Departamento` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Fecha_Depreciacion` date DEFAULT NULL,
  `Depreciacion` decimal(10,2) DEFAULT NULL,
  `Depreciacion_Fiscal` decimal(10,2) DEFAULT NULL,
  `Descripcion` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Estado` tinyint DEFAULT NULL,
  `Pk_Id_Cuenta` int NOT NULL,
  PRIMARY KEY (`Pk_Id_Depreciacion`),
  KEY `Fk_IdActivoFijo_Depreciacion` (`Pk_Id_ActivoFijo`),
  KEY `Fk_Cuenta_Depreciacion_New` (`Pk_Id_Cuenta`),
  CONSTRAINT `Fk_Cuenta_Depreciacion_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`) ON DELETE CASCADE,
  CONSTRAINT `Fk_IdActivoFijo_Depreciacion` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_activofijo` (`Pk_Id_ActivoFijo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_destinatario`
--

DROP TABLE IF EXISTS `tbl_destinatario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_destinatario` (
  `Pk_id_destinatario` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `correoElectronico` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_destinatario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_detalle_comisiones`
--

DROP TABLE IF EXISTS `tbl_detalle_comisiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_comisiones` (
  `Pk_id_detalle_comision` int NOT NULL,
  `Fk_id_comisionEnc` int NOT NULL,
  `Fk_id_factura` int NOT NULL,
  `Comisiones_porcentaje` decimal(5,2) NOT NULL,
  `Comisiones_monto_venta` decimal(10,2) NOT NULL,
  `Comisiones_monto_comision` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Pk_id_detalle_comision`),
  KEY `Fk_id_comisionEnc` (`Fk_id_comisionEnc`),
  KEY `Fk_id_factura` (`Fk_id_factura`),
  CONSTRAINT `tbl_detalle_comisiones_ibfk_1` FOREIGN KEY (`Fk_id_comisionEnc`) REFERENCES `tbl_comisiones_encabezado` (`Pk_id_comisionEnc`),
  CONSTRAINT `tbl_detalle_comisiones_ibfk_2` FOREIGN KEY (`Fk_id_factura`) REFERENCES `tbl_factura` (`Pk_id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_detalle_ordenes_compra`
--

DROP TABLE IF EXISTS `tbl_detalle_ordenes_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_ordenes_compra` (
  `Pk_detOrCom_id` int NOT NULL,
  `Fk_encOrCom_id` int DEFAULT NULL,
  `Fk_id_producto` int DEFAULT NULL,
  `DetOrCom_cantidad` int NOT NULL,
  `DetOrCom_preUni` decimal(10,2) NOT NULL,
  `DetOrCom_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_detOrCom_id`),
  KEY `Fk_encOrCom_id` (`Fk_encOrCom_id`),
  KEY `Fk_id_producto` (`Fk_id_producto`),
  CONSTRAINT `tbl_detalle_ordenes_compra_ibfk_1` FOREIGN KEY (`Fk_encOrCom_id`) REFERENCES `tbl_ordenes_compra` (`Pk_encOrCom_id`),
  CONSTRAINT `tbl_detalle_ordenes_compra_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_detalle_presupuesto`
--

DROP TABLE IF EXISTS `tbl_detalle_presupuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_presupuesto` (
  `Pk_id_detalle` int NOT NULL AUTO_INCREMENT,
  `Fk_id_presupuesto` int DEFAULT NULL,
  `Fk_id_cuenta` int DEFAULT NULL,
  `mes_enero` decimal(18,2) DEFAULT NULL,
  `mes_febrero` decimal(18,2) DEFAULT NULL,
  `mes_marzo` decimal(18,2) DEFAULT NULL,
  `mes_abril` decimal(18,2) DEFAULT NULL,
  `mes_mayo` decimal(18,2) DEFAULT NULL,
  `mes_junio` decimal(18,2) DEFAULT NULL,
  `mes_julio` decimal(18,2) DEFAULT NULL,
  `mes_agosto` decimal(18,2) DEFAULT NULL,
  `mes_septiembre` decimal(18,2) DEFAULT NULL,
  `mes_octubre` decimal(18,2) DEFAULT NULL,
  `mes_noviembre` decimal(18,2) DEFAULT NULL,
  `mes_diciembre` decimal(18,2) DEFAULT NULL,
  `total_cuenta` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_detalle`),
  KEY `Fk_id_presupuesto` (`Fk_id_presupuesto`),
  KEY `Fk_id_cuenta` (`Fk_id_cuenta`),
  CONSTRAINT `tbl_detalle_presupuesto_ibfk_1` FOREIGN KEY (`Fk_id_presupuesto`) REFERENCES `tbl_presupuesto` (`Pk_id_presupuesto`),
  CONSTRAINT `tbl_detalle_presupuesto_ibfk_2` FOREIGN KEY (`Fk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_deudas_clientes`
--

DROP TABLE IF EXISTS `tbl_deudas_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_deudas_clientes` (
  `Pk_id_deuda` int NOT NULL AUTO_INCREMENT,
  `Fk_id_cliente` int NOT NULL,
  `Fk_id_cobrador` int NOT NULL,
  `Fk_id_pago` int NOT NULL,
  `deuda_monto` decimal(10,2) NOT NULL,
  `deuda_fecha_inicio_deuda` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `deuda_fecha_vencimiento_deuda` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `deuda_descripcion_deuda` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `deuda_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_deuda`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_cobrador` (`Fk_id_cobrador`),
  KEY `Fk_id_pago` (`Fk_id_pago`),
  CONSTRAINT `tbl_deudas_clientes_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_deudas_clientes_ibfk_2` FOREIGN KEY (`Fk_id_cobrador`) REFERENCES `tbl_cobrador` (`Pk_id_cobrador`),
  CONSTRAINT `tbl_deudas_clientes_ibfk_3` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_deudas_proveedores`
--

DROP TABLE IF EXISTS `tbl_deudas_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_deudas_proveedores` (
  `Pk_id_deuda` int NOT NULL AUTO_INCREMENT,
  `Fk_id_proveedor` int NOT NULL,
  `Fk_id_pago` int NOT NULL,
  `deuda_monto` decimal(10,2) NOT NULL,
  `deuda_fecha_inicio` date NOT NULL,
  `deuda_fecha_vencimiento` date NOT NULL,
  `deuda_descripcion` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `deuda_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_deuda`),
  KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  KEY `Fk_id_pago` (`Fk_id_pago`),
  CONSTRAINT `tbl_deudas_proveedores_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  CONSTRAINT `tbl_deudas_proveedores_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_disponibilidad`
--

DROP TABLE IF EXISTS `tbl_disponibilidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_disponibilidad` (
  `Pk_id_disponibilidad` int NOT NULL AUTO_INCREMENT,
  `disponibilidad` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_disponibilidad`),
  UNIQUE KEY `disponibilidad` (`disponibilidad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_empleados`
--

DROP TABLE IF EXISTS `tbl_empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_empleados` (
  `pk_clave` int NOT NULL AUTO_INCREMENT,
  `empleados_nombre` varchar(50) NOT NULL,
  `empleados_apellido` varchar(50) DEFAULT NULL,
  `empleados_fecha_nacimiento` date DEFAULT NULL,
  `empleados_no_identificacion` varchar(50) NOT NULL,
  `empleados_codigo_postal` varchar(50) DEFAULT NULL,
  `empleados_fecha_alta` date DEFAULT NULL,
  `empleados_fecha_baja` date DEFAULT NULL,
  `empleados_causa_baja` varchar(50) DEFAULT NULL,
  `fk_id_departamento` int NOT NULL,
  `fk_id_puestos` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_clave`),
  KEY `fk_id_departamento` (`fk_id_departamento`),
  KEY `fk_id_puestos` (`fk_id_puestos`),
  CONSTRAINT `tbl_empleados_ibfk_1` FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` (`pk_id_departamento`),
  CONSTRAINT `tbl_empleados_ibfk_2` FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_empresas`
--

DROP TABLE IF EXISTS `tbl_empresas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_empresas` (
  `empresa_id` int NOT NULL AUTO_INCREMENT,
  `empresas_nombre` varchar(255) NOT NULL,
  `empresas_logo` longblob,
  `empresas_fecha_creacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `empresas_direccion` varchar(255) DEFAULT NULL,
  `empresas_telefono` varchar(20) DEFAULT NULL,
  `empresas_email` varchar(100) DEFAULT NULL,
  `empresas_pagina_web` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`empresa_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_encabezadoclasecuenta`
--

DROP TABLE IF EXISTS `tbl_encabezadoclasecuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_encabezadoclasecuenta` (
  `Pk_id_encabezadocuenta` int NOT NULL,
  `nombre_tipocuenta` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`Pk_id_encabezadocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_existencias_bodega`
--

DROP TABLE IF EXISTS `tbl_existencias_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_existencias_bodega` (
  `Pk_ID_EXISTENCIA` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_BODEGA` int NOT NULL,
  `Fk_ID_PRODUCTO` int NOT NULL,
  `CANTIDAD_ACTUAL` int NOT NULL,
  `CANTIDAD_INICIAL` int NOT NULL,
  PRIMARY KEY (`Pk_ID_EXISTENCIA`),
  KEY `FK_EXISTENCIA_BODEGA` (`Fk_ID_BODEGA`),
  KEY `FK_EXISTENCIA_PRODUCTO` (`Fk_ID_PRODUCTO`),
  CONSTRAINT `FK_EXISTENCIA_BODEGA` FOREIGN KEY (`Fk_ID_BODEGA`) REFERENCES `tbl_bodegas` (`Pk_ID_BODEGA`),
  CONSTRAINT `FK_EXISTENCIA_PRODUCTO` FOREIGN KEY (`Fk_ID_PRODUCTO`) REFERENCES `tbl_productos` (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_expedientes`
--

DROP TABLE IF EXISTS `tbl_expedientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_expedientes` (
  `Pk_id_expediente` int NOT NULL AUTO_INCREMENT,
  `Fk_id_postulante` int DEFAULT NULL,
  `curriculum` longblob,
  `pruebas_psicometricas` longblob,
  `pruebas_psicologicas` longblob,
  `pruebas_aptitud` longblob,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_expediente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_factura`
--

DROP TABLE IF EXISTS `tbl_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_factura` (
  `Pk_id_factura` int NOT NULL,
  `Fk_id_cliente` int NOT NULL,
  `Fk_id_pedidoEnc` int NOT NULL,
  `factura_fecha` date NOT NULL,
  `factura_formPago` varchar(20) NOT NULL,
  `factura_subtotal` decimal(10,2) NOT NULL,
  `factura_iva` decimal(10,2) NOT NULL,
  `factura_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_factura`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  CONSTRAINT `tbl_factura_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_factura_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_formadepago`
--

DROP TABLE IF EXISTS `tbl_formadepago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_formadepago` (
  `Pk_id_pago` int NOT NULL AUTO_INCREMENT,
  `pago_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `pago_tipo_moneda` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `pado_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_historial_pagos`
--

DROP TABLE IF EXISTS `tbl_historial_pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_historial_pagos` (
  `pk_id_pago` int NOT NULL AUTO_INCREMENT,
  `fk_clave_empleado` int NOT NULL,
  `fk_id_contrato` int NOT NULL,
  `monto_pago` decimal(10,2) NOT NULL,
  `fecha_pago` date NOT NULL,
  `estado_pago` tinyint(1) NOT NULL DEFAULT '1',
  `comentarios` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`pk_id_pago`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  KEY `fk_id_contrato` (`fk_id_contrato`),
  CONSTRAINT `tbl_historial_pagos_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  CONSTRAINT `tbl_historial_pagos_ibfk_2` FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_historial_servicio`
--

DROP TABLE IF EXISTS `tbl_historial_servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_historial_servicio` (
  `Pk_Id_HistorialServicio` int NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` int NOT NULL,
  `Compania_Asegurada` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Agente_Seguro` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Tel_Siniestro` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `Tipo_Cobertura` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Monto_Asegurado` decimal(10,2) NOT NULL,
  `Prima_Total` decimal(10,2) NOT NULL,
  `Deducible` decimal(10,2) NOT NULL,
  `Vigencia` date NOT NULL,
  `Fecha_Util` date NOT NULL,
  `Costo_Servicio` decimal(10,2) NOT NULL,
  `Periodo_Servicio` int NOT NULL,
  `Prox_Servicio` date NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_Id_HistorialServicio`),
  KEY `Fk_ActivoFijo` (`Pk_Id_ActivoFijo`),
  CONSTRAINT `Fk_ActivoFijo_HistorialServicio` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_activofijo` (`Pk_Id_ActivoFijo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_historico_cuentas`
--

DROP TABLE IF EXISTS `tbl_historico_cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_historico_cuentas` (
  `Pk_id_cuenta` int NOT NULL,
  `mes` int NOT NULL,
  `anio` int NOT NULL,
  `cargo_mes` float DEFAULT '0',
  `abono_mes` float DEFAULT '0',
  `saldo_ant` float DEFAULT '0',
  `saldo_act` float DEFAULT '0',
  `cargo_acumulado` float DEFAULT '0',
  `abono_acumulado` float DEFAULT '0',
  `saldoanual` float DEFAULT '0',
  PRIMARY KEY (`Pk_id_cuenta`,`mes`,`anio`),
  CONSTRAINT `tbl_historico_cuentas_ibfk_1` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_horas_extra`
--

DROP TABLE IF EXISTS `tbl_horas_extra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_horas_extra` (
  `pk_registro_horas` int NOT NULL AUTO_INCREMENT,
  `horas_mes` varchar(25) DEFAULT NULL,
  `horas_cantidad_horas` decimal(10,2) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_horas`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_horas_extra_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_identidadactivo`
--

DROP TABLE IF EXISTS `tbl_identidadactivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_identidadactivo` (
  `Pk_Id_Identidad` int NOT NULL AUTO_INCREMENT,
  `Nombre_Identidad` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_Id_Identidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_linea`
--

DROP TABLE IF EXISTS `tbl_linea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_linea` (
  `Pk_id_linea` int NOT NULL AUTO_INCREMENT,
  `nombre_linea` varchar(50) DEFAULT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  `fk_id_marca` int DEFAULT NULL,
  PRIMARY KEY (`Pk_id_linea`),
  KEY `fk_id_marca` (`fk_id_marca`),
  CONSTRAINT `tbl_linea_ibfk_1` FOREIGN KEY (`fk_id_marca`) REFERENCES `tbl_marca` (`Pk_id_Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_liquidacion_trabajadores`
--

DROP TABLE IF EXISTS `tbl_liquidacion_trabajadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_liquidacion_trabajadores` (
  `pk_registro_liquidacion` int NOT NULL AUTO_INCREMENT,
  `liquidacion_aguinaldo` decimal(10,2) NOT NULL,
  `liquidacion_bono_14` decimal(10,2) NOT NULL,
  `liquidacion_vacaciones` decimal(10,2) NOT NULL,
  `liquidacion_tipo_operacion` varchar(25) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_liquidacion`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_liquidacion_trabajadores_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lista_detalle`
--

DROP TABLE IF EXISTS `tbl_lista_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lista_detalle` (
  `Pk_id_lista_detalle` int NOT NULL,
  `Fk_id_lista_Encabezado` int NOT NULL,
  `Fk_id_Producto` int NOT NULL,
  `ListDetalle_preVenta` decimal(10,2) DEFAULT NULL,
  `ListDetalle_descuento` decimal(10,2) DEFAULT NULL,
  `ListDetalle_impuesto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_lista_detalle`),
  KEY `Fk_id_lista_Encabezado` (`Fk_id_lista_Encabezado`),
  KEY `Fk_id_Producto` (`Fk_id_Producto`),
  CONSTRAINT `tbl_lista_detalle_ibfk_1` FOREIGN KEY (`Fk_id_lista_Encabezado`) REFERENCES `tbl_lista_encabezado` (`Pk_id_lista_Encabezado`),
  CONSTRAINT `tbl_lista_detalle_ibfk_2` FOREIGN KEY (`Fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lista_encabezado`
--

DROP TABLE IF EXISTS `tbl_lista_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lista_encabezado` (
  `Pk_id_lista_Encabezado` int NOT NULL,
  `ListEncabezado_nombre` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ListEncabezado_fecha` date DEFAULT NULL,
  `ListEncabezado_estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Pk_id_lista_Encabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_locales`
--

DROP TABLE IF EXISTS `tbl_locales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_locales` (
  `Pk_ID_LOCAL` int NOT NULL AUTO_INCREMENT,
  `NOMBRE_LOCAL` varchar(100) NOT NULL,
  `UBICACION` varchar(255) NOT NULL,
  `CAPACIDAD` int NOT NULL,
  `ESTADO` tinyint NOT NULL DEFAULT '1',
  `FECHA_REGISTRO` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Pk_ID_LOCAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lotes_detalles`
--

DROP TABLE IF EXISTS `tbl_lotes_detalles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lotes_detalles` (
  `Pk_id_lotes_detalle` int NOT NULL,
  `Fk_id_producto` int DEFAULT NULL,
  `Fk_id_lote` int DEFAULT NULL,
  `cantidad` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lotes_encabezado`
--

DROP TABLE IF EXISTS `tbl_lotes_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lotes_encabezado` (
  `Pk_id_lote` int NOT NULL,
  `codigo_lote` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Fecha_Producción` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `Fk_id_proceso` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_mantenimiento`
--

DROP TABLE IF EXISTS `tbl_mantenimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimiento` (
  `Pk_id_Mantenimiento` int NOT NULL AUTO_INCREMENT,
  `nombre_Solicitante` varchar(20) NOT NULL,
  `tipo_de_Mantenimiento` varchar(15) NOT NULL,
  `componente_Afectado` varchar(15) NOT NULL,
  `fecha` date NOT NULL,
  `responsable_Asignado` varchar(20) NOT NULL,
  `codigo_Error_Problema` varchar(50) NOT NULL,
  `estado_del_Mantenimiento` varchar(20) NOT NULL,
  `tiempo_Estimado` varchar(30) NOT NULL,
  `Fk_id_vehiculo` int NOT NULL,
  PRIMARY KEY (`Pk_id_Mantenimiento`),
  KEY `Fk_id_vehiculo` (`Fk_id_vehiculo`),
  CONSTRAINT `tbl_mantenimiento_ibfk_1` FOREIGN KEY (`Fk_id_vehiculo`) REFERENCES `tbl_vehiculos` (`Pk_id_vehiculo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_mantenimientos`
--

DROP TABLE IF EXISTS `tbl_mantenimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mantenimientos` (
  `Pk_id_maquinaria` int NOT NULL,
  `nombre_maquinaria` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tipo_maquina` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `hora_operacion` decimal(10,2) DEFAULT NULL,
  `mantenimiento_periodico` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ultima_mantenimiento` date DEFAULT NULL,
  `proximo_mantenimiento` date DEFAULT NULL,
  `area` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `desgaste_porcentaje` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_maquinaria`
--

DROP TABLE IF EXISTS `tbl_maquinaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_maquinaria` (
  `pk_id_maquina` int NOT NULL AUTO_INCREMENT,
  `nombre_maquina` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `tipo_maquina` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `capacidad_produccion` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`pk_id_maquina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_marca`
--

DROP TABLE IF EXISTS `tbl_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_marca` (
  `Pk_id_Marca` int NOT NULL AUTO_INCREMENT,
  `nombre_Marca` varchar(50) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  `fk_id_Producto` int DEFAULT NULL,
  PRIMARY KEY (`Pk_id_Marca`),
  KEY `fk_id_Producto` (`fk_id_Producto`),
  CONSTRAINT `tbl_marca_ibfk_1` FOREIGN KEY (`fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `Pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_modulo` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_modulo` tinyint DEFAULT '0',
  PRIMARY KEY (`Pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_mora_clientes`
--

DROP TABLE IF EXISTS `tbl_mora_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_mora_clientes` (
  `Pk_id_mora` int NOT NULL AUTO_INCREMENT,
  `Fk_id_cliente` int NOT NULL,
  `Fk_id_transaccion` int NOT NULL,
  `morafecha` date NOT NULL,
  `mora_monto` decimal(10,2) NOT NULL,
  `mora_dias` int NOT NULL,
  `mora_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_mora`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_transaccion` (`Fk_id_transaccion`),
  CONSTRAINT `tbl_mora_clientes_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_mora_clientes_ibfk_2` FOREIGN KEY (`Fk_id_transaccion`) REFERENCES `tbl_transaccion_cliente` (`Pk_id_transaccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_movimiento`
--

DROP TABLE IF EXISTS `tbl_movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento` (
  `Pk_id_movimiento` int NOT NULL,
  `Movimiento_codigo` varchar(50) NOT NULL,
  `Movimiento_cuenta` varchar(50) NOT NULL,
  `Movimiento_tipo` varchar(20) NOT NULL,
  `Movimiento_valor` decimal(10,2) NOT NULL,
  `Movimiento_cargos` decimal(10,2) NOT NULL,
  `Movimiento_abonos` decimal(10,2) NOT NULL,
  `Fk_id_poliza` int DEFAULT NULL,
  PRIMARY KEY (`Pk_id_movimiento`),
  KEY `Fk_id_poliza` (`Fk_id_poliza`),
  CONSTRAINT `tbl_movimiento_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_movimiento_de_inventario`
--

DROP TABLE IF EXISTS `tbl_movimiento_de_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento_de_inventario` (
  `Pk_id_movimiento` int NOT NULL AUTO_INCREMENT,
  `estado` tinyint NOT NULL DEFAULT '1',
  `Fk_id_producto` int NOT NULL,
  `Fk_id_stock` int NOT NULL,
  `Fk_ID_LOCALES` int NOT NULL,
  PRIMARY KEY (`Pk_id_movimiento`),
  KEY `Fk_id_producto` (`Fk_id_producto`),
  KEY `Fk_id_stock` (`Fk_id_stock`),
  KEY `FK_EXISTENCIA_LOCAL` (`Fk_ID_LOCALES`),
  CONSTRAINT `FK_EXISTENCIA_LOCAL` FOREIGN KEY (`Fk_ID_LOCALES`) REFERENCES `tbl_locales` (`Pk_ID_LOCAL`),
  CONSTRAINT `tbl_movimiento_de_inventario_ibfk_1` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  CONSTRAINT `tbl_movimiento_de_inventario_ibfk_2` FOREIGN KEY (`Fk_id_stock`) REFERENCES `tbl_trasladoproductos` (`Pk_id_TrasladoProductos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_movimientobancario`
--

DROP TABLE IF EXISTS `tbl_movimientobancario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimientobancario` (
  `pk_movimientobancario_id` int NOT NULL AUTO_INCREMENT,
  `fk_cuenta_id` int NOT NULL,
  `movimientobancario_fecha` date NOT NULL,
  `movimientobancario_tipo` varchar(50) NOT NULL,
  `movimientobancario_monto` decimal(10,2) NOT NULL,
  `movimientobancario_descripcion` text,
  `movimientobancario_metodo_pago` varchar(50) DEFAULT NULL,
  `movimientobancario_estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_movimientobancario_id`),
  KEY `fk_cuenta` (`fk_cuenta_id`),
  CONSTRAINT `fk_cuenta` FOREIGN KEY (`fk_cuenta_id`) REFERENCES `tbl_cuentabancaria` (`pk_cuenta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_nivel_educativo`
--

DROP TABLE IF EXISTS `tbl_nivel_educativo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_nivel_educativo` (
  `Pk_id_nivel` int NOT NULL AUTO_INCREMENT,
  `nivel` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_nivel`),
  UNIQUE KEY `nivel` (`nivel`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_ordenes_compra`
--

DROP TABLE IF EXISTS `tbl_ordenes_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ordenes_compra` (
  `Pk_encOrCom_id` int NOT NULL,
  `EncOrCom_numero` varchar(20) NOT NULL,
  `Fk_prov_id` int DEFAULT NULL,
  `EncOrCom_fechaEntrega` date DEFAULT NULL,
  PRIMARY KEY (`Pk_encOrCom_id`),
  UNIQUE KEY `EncOrCom_numero` (`EncOrCom_numero`),
  KEY `Fk_prov_id` (`Fk_prov_id`),
  CONSTRAINT `tbl_ordenes_compra_ibfk_1` FOREIGN KEY (`Fk_prov_id`) REFERENCES `tbl_proveedores` (`Pk_prov_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_ordenes_produccion`
--

DROP TABLE IF EXISTS `tbl_ordenes_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ordenes_produccion` (
  `Pk_id_orden` int NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_ordenes_produccion_detalle`
--

DROP TABLE IF EXISTS `tbl_ordenes_produccion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ordenes_produccion_detalle` (
  `Pk_id_detalle` int NOT NULL,
  `Fk_id_orden` int NOT NULL,
  `Fk_id_producto` int NOT NULL,
  `cantidad` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_paises`
--

DROP TABLE IF EXISTS `tbl_paises`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_paises` (
  `Pk_id_pais` int NOT NULL AUTO_INCREMENT,
  `pais_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `pais_region` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `pais_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_pedido_detalle`
--

DROP TABLE IF EXISTS `tbl_pedido_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pedido_detalle` (
  `Pk_id_pedidoDet` int NOT NULL,
  `Fk_id_pedidoEnc` int DEFAULT NULL,
  `Fk_id_producto` int DEFAULT NULL,
  `Fk_id_cotizacionEnc` int DEFAULT NULL,
  `PedidoDet_cantidad` int DEFAULT NULL,
  `PedidoEnc_precio` decimal(10,2) DEFAULT NULL,
  `PedidoEnc_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_pedidoDet`),
  KEY `Fk_id_pedidoEnc` (`Fk_id_pedidoEnc`),
  KEY `Fk_id_producto` (`Fk_id_producto`),
  KEY `Fk_id_cotizacionEnc` (`Fk_id_cotizacionEnc`),
  CONSTRAINT `tbl_pedido_detalle_ibfk_1` FOREIGN KEY (`Fk_id_pedidoEnc`) REFERENCES `tbl_pedido_encabezado` (`Pk_id_PedidoEnc`),
  CONSTRAINT `tbl_pedido_detalle_ibfk_2` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  CONSTRAINT `tbl_pedido_detalle_ibfk_3` FOREIGN KEY (`Fk_id_cotizacionEnc`) REFERENCES `tbl_cotizacion_encabezado` (`Pk_id_cotizacionEnc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_pedido_encabezado`
--

DROP TABLE IF EXISTS `tbl_pedido_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pedido_encabezado` (
  `Pk_id_PedidoEnc` int NOT NULL,
  `Fk_id_cliente` int NOT NULL,
  `Fk_id_vendedor` int NOT NULL,
  `PedidoEncfecha` date NOT NULL,
  `PedidoEnc_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_PedidoEnc`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_vendedor` (`Fk_id_vendedor`),
  CONSTRAINT `tbl_pedido_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_pedido_encabezado_ibfk_2` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`Pk_id_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfiles` (
  `Pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_perfil` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_perfil` tinyint DEFAULT '0',
  PRIMARY KEY (`Pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_permisos_aplicacion_perfil`
--

DROP TABLE IF EXISTS `tbl_permisos_aplicacion_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisos_aplicacion_perfil` (
  `PK_id_Aplicacion_Perfil` int NOT NULL AUTO_INCREMENT,
  `Fk_id_perfil` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`PK_id_Aplicacion_Perfil`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  KEY `Fk_id_perfil` (`Fk_id_perfil`),
  CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_1` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`),
  CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=223 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_permisos_aplicaciones_usuario`
--

DROP TABLE IF EXISTS `tbl_permisos_aplicaciones_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisos_aplicaciones_usuario` (
  `PK_id_Aplicacion_Usuario` int NOT NULL AUTO_INCREMENT,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`PK_id_Aplicacion_Usuario`),
  KEY `Fk_id_usuario` (`Fk_id_usuario`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_planilla_detalle`
--

DROP TABLE IF EXISTS `tbl_planilla_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_planilla_detalle` (
  `pk_registro_planilla_Detalle` int NOT NULL AUTO_INCREMENT,
  `detalle_total_Percepciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_Deducciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_liquido` decimal(10,2) DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `fk_id_contrato` int NOT NULL,
  `fk_id_registro_planilla_Encabezado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_planilla_Detalle`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  KEY `fk_id_contrato` (`fk_id_contrato`),
  KEY `fk_id_registro_planilla_Encabezado` (`fk_id_registro_planilla_Encabezado`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_2` FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_3` FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES `tbl_planilla_encabezado` (`pk_registro_planilla_Encabezado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_planilla_encabezado`
--

DROP TABLE IF EXISTS `tbl_planilla_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_planilla_encabezado` (
  `pk_registro_planilla_Encabezado` int NOT NULL AUTO_INCREMENT,
  `encabezado_correlativo_planilla` int NOT NULL,
  `encabezado_fecha_inicio` date DEFAULT NULL,
  `encabezado_fecha_final` date DEFAULT NULL,
  `encabezado_total_mes` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_planilla_Encabezado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_poliza`
--

DROP TABLE IF EXISTS `tbl_poliza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_poliza` (
  `Pk_id_poliza` int NOT NULL,
  `Poliza_fecha_emision` date NOT NULL,
  `Poliza_concepto` varchar(255) NOT NULL,
  `Poliza_docto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_poliza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_poliza_contabilidad`
--

DROP TABLE IF EXISTS `tbl_poliza_contabilidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_poliza_contabilidad` (
  `Fk_id_poliza` int NOT NULL,
  `Fk_id_contabilidad` int NOT NULL,
  PRIMARY KEY (`Fk_id_poliza`,`Fk_id_contabilidad`),
  KEY `Fk_id_contabilidad` (`Fk_id_contabilidad`),
  CONSTRAINT `tbl_poliza_contabilidad_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`),
  CONSTRAINT `tbl_poliza_contabilidad_ibfk_2` FOREIGN KEY (`Fk_id_contabilidad`) REFERENCES `tbl_contabilidad` (`Pk_id_contabilidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_poliza_rango_fechas`
--

DROP TABLE IF EXISTS `tbl_poliza_rango_fechas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_poliza_rango_fechas` (
  `Fk_id_poliza` int NOT NULL,
  `Fk_id_rango` int NOT NULL,
  PRIMARY KEY (`Fk_id_poliza`,`Fk_id_rango`),
  KEY `Fk_id_rango` (`Fk_id_rango`),
  CONSTRAINT `tbl_poliza_rango_fechas_ibfk_1` FOREIGN KEY (`Fk_id_poliza`) REFERENCES `tbl_poliza` (`Pk_id_poliza`),
  CONSTRAINT `tbl_poliza_rango_fechas_ibfk_2` FOREIGN KEY (`Fk_id_rango`) REFERENCES `tbl_rango_fechas` (`Pk_id_rango`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_polizadetalle`
--

DROP TABLE IF EXISTS `tbl_polizadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_polizadetalle` (
  `Pk_id_polizadetalle` int NOT NULL AUTO_INCREMENT,
  `Pk_id_polizaencabezado` int NOT NULL,
  `Pk_id_cuenta` int NOT NULL,
  `Pk_id_tipooperacion` int NOT NULL,
  `valor` float DEFAULT NULL,
  PRIMARY KEY (`Pk_id_polizadetalle`),
  KEY `Pk_id_polizaencabezado` (`Pk_id_polizaencabezado`),
  KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  KEY `Pk_id_tipooperacion` (`Pk_id_tipooperacion`),
  CONSTRAINT `tbl_polizadetalle_ibfk_1` FOREIGN KEY (`Pk_id_polizaencabezado`) REFERENCES `tbl_polizaencabezado` (`Pk_id_polizaencabezado`),
  CONSTRAINT `tbl_polizadetalle_ibfk_2` FOREIGN KEY (`Pk_id_cuenta`) REFERENCES `tbl_cuentas` (`Pk_id_cuenta`),
  CONSTRAINT `tbl_polizadetalle_ibfk_3` FOREIGN KEY (`Pk_id_tipooperacion`) REFERENCES `tbl_tipooperacion` (`Pk_id_tipooperacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_polizaencabezado`
--

DROP TABLE IF EXISTS `tbl_polizaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_polizaencabezado` (
  `Pk_id_polizaencabezado` int NOT NULL AUTO_INCREMENT,
  `fechaPoliza` varchar(50) DEFAULT NULL,
  `concepto` varchar(65) DEFAULT NULL,
  `Pk_id_tipopoliza` int NOT NULL,
  PRIMARY KEY (`Pk_id_polizaencabezado`),
  KEY `Pk_id_tipopoliza` (`Pk_id_tipopoliza`),
  CONSTRAINT `tbl_polizaencabezado_ibfk_1` FOREIGN KEY (`Pk_id_tipopoliza`) REFERENCES `tbl_tipopoliza` (`Pk_id_tipopoliza`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_postulante`
--

DROP TABLE IF EXISTS `tbl_postulante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_postulante` (
  `Pk_id_postulante` int NOT NULL AUTO_INCREMENT,
  `Fk_puesto_aplica_postulante` int DEFAULT NULL,
  `nombre_postulante` varchar(50) NOT NULL,
  `apellido_postulante` varchar(50) NOT NULL,
  `email_postulante` varchar(50) NOT NULL,
  `telefono_postulante` varchar(15) NOT NULL,
  `anios_experiencia` int NOT NULL DEFAULT '0',
  `trabajo_anterior` varchar(100) DEFAULT NULL,
  `puesto_anterior` varchar(50) DEFAULT NULL,
  `Fk_nivel_educativo` int NOT NULL,
  `titulo_obtenido` varchar(100) DEFAULT NULL,
  `Fk_disponibilidad` int NOT NULL,
  `salario_pretendido` decimal(10,2) DEFAULT NULL,
  `fecha_postulacion` datetime DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_postulante`),
  KEY `Fk_puesto_aplica_postulante` (`Fk_puesto_aplica_postulante`),
  KEY `Fk_nivel_educativo` (`Fk_nivel_educativo`),
  KEY `Fk_disponibilidad` (`Fk_disponibilidad`),
  CONSTRAINT `Fk_disponibilidad` FOREIGN KEY (`Fk_disponibilidad`) REFERENCES `tbl_disponibilidad` (`Pk_id_disponibilidad`) ON DELETE RESTRICT,
  CONSTRAINT `Fk_nivel_educativo` FOREIGN KEY (`Fk_nivel_educativo`) REFERENCES `tbl_nivel_educativo` (`Pk_id_nivel`) ON DELETE RESTRICT,
  CONSTRAINT `Fk_puesto_aplica_postulante` FOREIGN KEY (`Fk_puesto_aplica_postulante`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_presupuesto`
--

DROP TABLE IF EXISTS `tbl_presupuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_presupuesto` (
  `Pk_id_presupuesto` int NOT NULL AUTO_INCREMENT,
  `nombre_presupuesto` varchar(100) DEFAULT NULL,
  `ejercicio_presupuesto` int DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `total_presupuesto` decimal(18,2) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_presupuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_proceso_produccion_detalle`
--

DROP TABLE IF EXISTS `tbl_proceso_produccion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proceso_produccion_detalle` (
  `Pk_id_proceso_detalle` int NOT NULL,
  `Fk_id_productos` int DEFAULT NULL,
  `Fk_id_receta` int DEFAULT NULL,
  `Fk_id_empleado` int DEFAULT NULL,
  `Fk_id_proceso` int DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `costo_u` decimal(10,2) DEFAULT NULL,
  `costo_t` decimal(10,2) DEFAULT NULL,
  `duracion_horas` decimal(10,2) DEFAULT NULL,
  `mano_de_obra` decimal(10,2) DEFAULT NULL,
  `costo_luz` decimal(10,2) DEFAULT NULL,
  `costo_agua` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_proceso_produccion_encabezado`
--

DROP TABLE IF EXISTS `tbl_proceso_produccion_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proceso_produccion_encabezado` (
  `Pk_id_proceso` int NOT NULL,
  `Fk_id_orden` int DEFAULT NULL,
  `Fk_id_maquinaria` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_productos`
--

DROP TABLE IF EXISTS `tbl_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_productos` (
  `Pk_id_Producto` int NOT NULL AUTO_INCREMENT,
  `codigoProducto` int NOT NULL,
  `nombreProducto` varchar(30) NOT NULL,
  `pesoProducto` varchar(20) DEFAULT NULL,
  `precioUnitario` decimal(10,2) NOT NULL,
  `clasificacion` varchar(30) NOT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  `stock` int NOT NULL,
  `empaque` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_proveedores`
--

DROP TABLE IF EXISTS `tbl_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proveedores` (
  `Pk_prov_id` int NOT NULL,
  `Prov_nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Prov_direccion` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Prov_telefono` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Prov_email` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Prov_fechaRegistro` date DEFAULT NULL,
  `Prov_estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Pk_prov_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_puestos_trabajo`
--

DROP TABLE IF EXISTS `tbl_puestos_trabajo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_puestos_trabajo` (
  `pk_id_puestos` int NOT NULL AUTO_INCREMENT,
  `puestos_nombre_puesto` varchar(50) DEFAULT NULL,
  `puestos_descripcion` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_id_puestos`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_quejas_reclamos`
--

DROP TABLE IF EXISTS `tbl_quejas_reclamos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_quejas_reclamos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `IdEmpleado` varchar(50) NOT NULL,
  `Departamento` varchar(100) DEFAULT NULL,
  `Correo` varchar(100) NOT NULL,
  `Tipo` varchar(100) NOT NULL,
  `Descripcion` text NOT NULL,
  `Urgencia` varchar(20) DEFAULT NULL,
  `Confidencial` tinyint(1) NOT NULL,
  `Terminos` tinyint(1) NOT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `ArchivosAdjuntos` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_rango_fechas`
--

DROP TABLE IF EXISTS `tbl_rango_fechas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_rango_fechas` (
  `Pk_id_rango` int NOT NULL,
  `Rango_fecha_inicio` date NOT NULL,
  `Rango_fecha_fin` date NOT NULL,
  PRIMARY KEY (`Pk_id_rango`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_receta_detalle`
--

DROP TABLE IF EXISTS `tbl_receta_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_receta_detalle` (
  `Pk_id_detalle` int NOT NULL,
  `Fk_id_receta` int NOT NULL,
  `Fk_id_producto` int NOT NULL,
  `cantidad` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_recetas`
--

DROP TABLE IF EXISTS `tbl_recetas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_recetas` (
  `Pk_id_receta` int NOT NULL,
  `Fk_id_producto` int DEFAULT NULL,
  `descripcion` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `area` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `cama` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_regreporteria`
--

DROP TABLE IF EXISTS `tbl_regreporteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_regreporteria` (
  `idregistro` int NOT NULL AUTO_INCREMENT,
  `ruta` varchar(500) COLLATE utf8mb4_general_ci NOT NULL,
  `nombre_archivo` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `aplicacion` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `estado` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `Fk_id_modulos` int NOT NULL,
  PRIMARY KEY (`idregistro`),
  KEY `Fk_id_modulos` (`Fk_id_modulos`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_regreporteria_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  CONSTRAINT `tbl_regreporteria_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_remitente`
--

DROP TABLE IF EXISTS `tbl_remitente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_remitente` (
  `Pk_id_remitente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `numeroIdentificacion` varchar(20) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `correoElectronico` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_remitente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_rrhh_produccion`
--

DROP TABLE IF EXISTS `tbl_rrhh_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_rrhh_produccion` (
  `id_RRHH` int unsigned NOT NULL,
  `id_empleado` int NOT NULL,
  `id_contrato` int NOT NULL,
  `dias` int NOT NULL,
  `total_dias` decimal(10,2) NOT NULL,
  `horas` decimal(10,2) NOT NULL,
  `total_horas` decimal(10,2) NOT NULL,
  `id_hora_extra` int DEFAULT NULL,
  `total_horas_extras` decimal(10,2) DEFAULT NULL,
  `total_mano_obra` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_tipoactivofijo`
--

DROP TABLE IF EXISTS `tbl_tipoactivofijo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipoactivofijo` (
  `Pk_Id_TipoActivoFijo` int NOT NULL AUTO_INCREMENT,
  `Nombre_Tipo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_Id_TipoActivoFijo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_tipocambio`
--

DROP TABLE IF EXISTS `tbl_tipocambio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipocambio` (
  `pk_id_tipoCambio` int NOT NULL AUTO_INCREMENT,
  `tipoCambio_nombre_moneda` varchar(50) NOT NULL,
  `tipoCambio_valor_moneda` decimal(5,3) NOT NULL,
  `tipoCambio_valorCambio_moneda` decimal(5,3) NOT NULL,
  `tipoCambio_estatus` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`pk_id_tipoCambio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_tipocuenta`
--

DROP TABLE IF EXISTS `tbl_tipocuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipocuenta` (
  `PK_id_tipocuenta` int NOT NULL,
  `nombre_tipocuenta` varchar(50) NOT NULL,
  `serie_tipocuenta` varchar(50) NOT NULL,
  `estado` tinyint NOT NULL,
  PRIMARY KEY (`PK_id_tipocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_tipooperacion`
--

DROP TABLE IF EXISTS `tbl_tipooperacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipooperacion` (
  `Pk_id_tipooperacion` int NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_id_tipooperacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_tipopoliza`
--

DROP TABLE IF EXISTS `tbl_tipopoliza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipopoliza` (
  `Pk_id_tipopoliza` int NOT NULL,
  `tipo` varchar(65) DEFAULT NULL,
  `estado` tinyint NOT NULL,
  PRIMARY KEY (`Pk_id_tipopoliza`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_transaccion`
--

DROP TABLE IF EXISTS `tbl_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaccion` (
  `pk_transaccion_id` int NOT NULL AUTO_INCREMENT,
  `fk_cuenta_id` int NOT NULL,
  `transaccion_fecha` datetime NOT NULL,
  `transaccion_monto` decimal(10,2) NOT NULL,
  `transaccion_estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`pk_transaccion_id`),
  KEY `fk_cuenta_id` (`fk_cuenta_id`),
  CONSTRAINT `fk_cuenta_id` FOREIGN KEY (`fk_cuenta_id`) REFERENCES `tbl_cuentabancaria` (`pk_cuenta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_transaccion_cliente`
--

DROP TABLE IF EXISTS `tbl_transaccion_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaccion_cliente` (
  `Pk_id_transaccion` int NOT NULL AUTO_INCREMENT,
  `Fk_id_cliente` int NOT NULL,
  `Fk_id_pais` int NOT NULL,
  `transaccion_fecha` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tansaccion_cuenta` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_cuotas` varchar(2) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_monto` decimal(10,2) DEFAULT NULL,
  `Fk_id_pago` int NOT NULL,
  `transaccion_tipo_moneda` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccionserie` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_transaccion`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_pago` (`Fk_id_pago`),
  KEY `Fk_id_pais` (`Fk_id_pais`),
  CONSTRAINT `tbl_transaccion_cliente_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`),
  CONSTRAINT `tbl_transaccion_cliente_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`),
  CONSTRAINT `tbl_transaccion_cliente_ibfk_3` FOREIGN KEY (`Fk_id_pais`) REFERENCES `tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_transaccion_cuentas`
--

DROP TABLE IF EXISTS `tbl_transaccion_cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaccion_cuentas` (
  `Pk_id_tran_cue` int NOT NULL AUTO_INCREMENT,
  `tran_nombre` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tran_efecto` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_tran_cue`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_transaccion_proveedor`
--

DROP TABLE IF EXISTS `tbl_transaccion_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaccion_proveedor` (
  `Pk_id_transaccion` int NOT NULL AUTO_INCREMENT,
  `Fk_id_proveedor` int NOT NULL,
  `Fk_id_pais` int NOT NULL,
  `fecha_transaccion` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tansaccion_cuenta` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tansaccion_cuotas` varchar(2) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_monto` decimal(10,2) DEFAULT NULL,
  `Fk_id_pago` int NOT NULL,
  `transaccion_tipo_moneda` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_serie` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_transaccion`),
  KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  KEY `Fk_id_pago` (`Fk_id_pago`),
  KEY `Fk_id_pais` (`Fk_id_pais`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`Pk_prov_id`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`Pk_id_pago`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_3` FOREIGN KEY (`Fk_id_pais`) REFERENCES `tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_trasladoproductos`
--

DROP TABLE IF EXISTS `tbl_trasladoproductos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_trasladoproductos` (
  `Pk_id_TrasladoProductos` int NOT NULL AUTO_INCREMENT,
  `documento` varchar(50) NOT NULL,
  `fecha` datetime NOT NULL,
  `costoTotal` decimal(10,2) NOT NULL,
  `costoTotalGeneral` decimal(10,2) NOT NULL,
  `precioTotal` decimal(10,2) NOT NULL,
  `Fk_id_Producto` int NOT NULL,
  `Fk_id_guia` int NOT NULL,
  PRIMARY KEY (`Pk_id_TrasladoProductos`),
  KEY `Fk_id_Producto` (`Fk_id_Producto`),
  KEY `Fk_id_guia` (`Fk_id_guia`),
  CONSTRAINT `tbl_trasladoproductos_ibfk_1` FOREIGN KEY (`Fk_id_Producto`) REFERENCES `tbl_productos` (`Pk_id_Producto`),
  CONSTRAINT `tbl_trasladoproductos_ibfk_2` FOREIGN KEY (`Fk_id_guia`) REFERENCES `tbl_datos_pedido` (`Pk_id_guia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuarios` (
  `Pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `ultima_conexion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  `fk_empleado` int DEFAULT NULL,
  PRIMARY KEY (`Pk_id_usuario`),
  KEY `fk_empleado` (`fk_empleado`),
  CONSTRAINT `tbl_usuarios_ibfk_1` FOREIGN KEY (`fk_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_vehiculos`
--

DROP TABLE IF EXISTS `tbl_vehiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_vehiculos` (
  `Pk_id_vehiculo` int NOT NULL AUTO_INCREMENT,
  `numeroPlaca` varchar(10) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `color` varchar(30) NOT NULL,
  `descripcion` text,
  `horaLlegada` datetime NOT NULL,
  `horaSalida` datetime DEFAULT NULL,
  `pesoTotal` decimal(10,2) NOT NULL,
  `Fk_id_chofer` int NOT NULL,
  `Estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_vehiculo`),
  KEY `Fk_id_chofer` (`Fk_id_chofer`),
  CONSTRAINT `tbl_vehiculos_ibfk_1` FOREIGN KEY (`Fk_id_chofer`) REFERENCES `tbl_chofer` (`Pk_id_chofer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_vendedores`
--

DROP TABLE IF EXISTS `tbl_vendedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_vendedores` (
  `Pk_id_vendedor` int NOT NULL,
  `vendedores_nombre` varchar(100) NOT NULL,
  `vendedores_apellido` varchar(100) NOT NULL,
  `vendedores_sueldo` decimal(10,2) NOT NULL,
  `vendedores_direccion` varchar(255) NOT NULL,
  `vendedores_telefono` varchar(20) NOT NULL,
  `Fk_id_empleado` int NOT NULL,
  `Fk_id_cliente` int NOT NULL,
  `vendedores_estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Pk_id_vendedor`),
  KEY `Fk_id_empleado` (`Fk_id_empleado`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  CONSTRAINT `tbl_vendedores_ibfk_1` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  CONSTRAINT `tbl_vendedores_ibfk_2` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`Pk_id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `id_venta` int NOT NULL AUTO_INCREMENT,
  `monto` int NOT NULL,
  `nombre_cliente` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `nombre_empleado` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `estado` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-15  9:01:11
