DROP DATABASE IF exists colchoneria;
CREATE DATABASE colchoneria;
use colchoneria;
-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-09-2024 a las 09:00:00
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `controlempleados`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE   PROCEDURE `cambiarContraModulo` (IN `p_usuario` INT, IN `p_nueva_contrasenia` VARCHAR(100))   BEGIN
    -- Actualizar la contraseña del usuario
    UPDATE tbl_usuarios
    SET password_usuario = p_nueva_contrasenia
    WHERE pk_id_usuario = p_usuario;

    -- Confirmar que el cambio se realizó
    IF ROW_COUNT() > 0 THEN
        SELECT 'Contraseña actualizada con éxito' AS resultado;
    ELSE
        SELECT 'Usuario no encontrado' AS resultado;
    END IF;
END$$

-- Cambio de contraseña procedimiento ----------------------------------------------------------------------
CREATE   PROCEDURE `cambioContrasenia` (IN `p_usuario` VARCHAR(20))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN        
        SELECT 'Usuario encontrado' AS resu;
    ELSE
        SELECT 'Usuario no encontrado' AS resu;
    END IF;
END$$

CREATE   PROCEDURE `cambiarContrasenia` (IN `usuario` VARCHAR(255), IN `nuevaContrasenia` VARCHAR(255), IN `respuestaSeguridad` VARCHAR(255))   BEGIN
    DECLARE respuestaGuardada VARCHAR(255);
    DECLARE usuarioExiste INT;

    -- Verificar si el usuario existe
    SELECT COUNT(*) INTO usuarioExiste 
    FROM tbl_usuarios 
    WHERE username_usuario = usuario;

    IF usuarioExiste = 0 THEN
        -- Si el usuario no existe, devolver mensaje de error
        SELECT 'Usuario no encontrado' AS resultado;
    ELSE
        -- Obtener la respuesta de seguridad desde la base de datos
        SELECT respuesta INTO respuestaGuardada 
        FROM tbl_usuarios 
        WHERE username_usuario = usuario;

        -- Verificar si la respuesta ingresada coincide con la guardada
        IF LOWER(respuestaGuardada) = LOWER(respuestaSeguridad) THEN
            -- Actualizar la contraseña
            UPDATE tbl_usuarios
            SET password_usuario = nuevaContrasenia
            WHERE username_usuario = usuario;
            
            -- Devolver el resultado exitoso
            SELECT 'Contraseña actualizada con éxito' AS resultado;
        ELSE
            -- Devolver resultado si la respuesta de seguridad es incorrecta
            SELECT 'Respuesta de seguridad incorrecta' AS resultado;
        END IF;
    END IF;
END$$

CREATE   PROCEDURE `procedimientoLogin` (IN `p_usuario` VARCHAR(20), IN `p_clave` VARCHAR(100))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario AND password_usuario = p_clave;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN
        UPDATE tbl_usuarios
        SET ultima_conexion_usuario = NOW()
        WHERE username_usuario = p_usuario AND password_usuario = p_clave;
        
        SELECT 'Inicio de sesión exitoso' AS resultado;
    ELSE
        SELECT 'Inicio de sesión fallido' AS resultado;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` varchar(255) DEFAULT NULL,
  `indice` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `Tbl_aplicaciones`;
CREATE TABLE IF NOT EXISTS `Tbl_aplicaciones` (
	Pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (`Pk_id_aplicacion`)
);


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignaciones_perfils_usuario`
--

CREATE TABLE `tbl_asignaciones_perfils_usuario` (
  `PK_id_Perfil_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacion_modulo_aplicacion`
--

CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_id_modulos` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Estructura de tabla para la tabla `tbl_usuarios`
--

DROP TABLE IF EXISTS `Tbl_usuarios`;
CREATE TABLE IF NOT EXISTS `Tbl_usuarios` (
  Pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  ultima_conexion_usuario DATETIME NULL DEFAULT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (`Pk_id_usuario`)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

DROP TABLE IF EXISTS Tbl_bitacora;
CREATE TABLE IF NOT EXISTS Tbl_bitacora (
  Pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  Fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(200) NOT NULL,
  PRIMARY KEY (`Pk_id_bitacora`),
  FOREIGN KEY (`Fk_id_usuario`) REFERENCES `Tbl_usuarios` (`Pk_id_usuario`),
  FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `Tbl_aplicaciones` (`Pk_id_aplicacion`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_consultainteligente`
--

CREATE TABLE `tbl_consultainteligente` (
  `Pk_consultaID` int(11) NOT NULL,
  `nombre_consulta` varchar(50) NOT NULL,
  `tipo_consulta` int(1) NOT NULL,
  `consulta_SQLE` varchar(100) NOT NULL,
  `consulta_estatus` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulos`
--

CREATE TABLE `tbl_modulos` (
  `Pk_id_modulos` int(11) NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfiles`
--

CREATE TABLE `tbl_perfiles` (
  `Pk_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicaciones_usuario`
--

CREATE TABLE `tbl_permisos_aplicaciones_usuario` (
  `PK_id_Aplicacion_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicacion_perfil`
--

CREATE TABLE `tbl_permisos_aplicacion_perfil` (
  `PK_id_Aplicacion_Perfil` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_regreporteria`
--

CREATE TABLE `tbl_regreporteria` (
  `idregistro` int(11) NOT NULL,
  `ruta` varchar(500) NOT NULL,
  `nombre_archivo` varchar(45) NOT NULL,
  `aplicacion` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `Fk_id_modulos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--



-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `id_venta` int(11) NOT NULL,
  `monto` int(11) NOT NULL,
  `nombre_cliente` varchar(50) NOT NULL,
  `nombre_empleado` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Estructura Stand-in para la vista `vwaplicacionperfil`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionperfil` (
`ID` int(11)
,`Perfil` varchar(50)
,`Aplicacion` int(11)
,`Insertar` tinyint(1)
,`Modificar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwaplicacionusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionusuario` (
`Aplicacion` int(11)
,`ID` int(11)
,`Usuario` varchar(50)
,`Insertar` tinyint(1)
,`Editar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwmoduloaplicacion`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwmoduloaplicacion` (
`ID` int(11)
,`Modulo` varchar(50)
,`Aplicacion` int(11)
,`Nombre` varchar(50)
,`Descripcion` varchar(150)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwperfilusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwperfilusuario` (
`ID` int(11)
,`Usuario` varchar(50)
,`nickName` varchar(20)
,`perfil` int(11)
,`Nombre` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `vwaplicacionperfil`
--
DROP TABLE IF EXISTS `vwaplicacionperfil`;

CREATE ALGORITHM=UNDEFINED   SQL SECURITY DEFINER VIEW `vwaplicacionperfil`  AS SELECT `b`.`Fk_id_perfil` AS `ID`, `a`.`nombre_perfil` AS `Perfil`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Modificar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicacion_perfil` `b` join `tbl_perfiles` `a` on(`a`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwaplicacionusuario`
--
DROP TABLE IF EXISTS `vwaplicacionusuario`;

CREATE ALGORITHM=UNDEFINED   SQL SECURITY DEFINER VIEW `vwaplicacionusuario`  AS SELECT `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Editar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicaciones_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwmoduloaplicacion`
--
DROP TABLE IF EXISTS `vwmoduloaplicacion`;

CREATE ALGORITHM=UNDEFINED   SQL SECURITY DEFINER VIEW `vwmoduloaplicacion`  AS SELECT `b`.`Fk_id_modulos` AS `ID`, `a`.`nombre_modulo` AS `Modulo`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `c`.`nombre_aplicacion` AS `Nombre`, `c`.`descripcion_aplicacion` AS `Descripcion` FROM ((`tbl_asignacion_modulo_aplicacion` `b` join `tbl_modulos` `a` on(`a`.`Pk_id_modulos` = `b`.`Fk_id_modulos`)) join `tbl_aplicaciones` `c` on(`c`.`Pk_id_aplicacion` = `b`.`Fk_id_aplicacion`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwperfilusuario`
--
DROP TABLE IF EXISTS `vwperfilusuario`;

CREATE ALGORITHM=UNDEFINED   SQL SECURITY DEFINER VIEW `vwperfilusuario`  AS SELECT `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `a`.`username_usuario` AS `nickName`, `b`.`Fk_id_perfil` AS `perfil`, `c`.`nombre_perfil` AS `Nombre` FROM ((`tbl_asignaciones_perfils_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) join `tbl_perfiles` `c` on(`c`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  ADD PRIMARY KEY (`Id_ayuda`);

--
-- Indices de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD PRIMARY KEY (`PK_id_Perfil_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD PRIMARY KEY (`Fk_id_modulos`,`Fk_id_aplicacion`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--



--
-- Indices de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  ADD PRIMARY KEY (`Pk_consultaID`);

--
-- Indices de la tabla `tbl_modulos`
--
ALTER TABLE `tbl_modulos`
  ADD PRIMARY KEY (`Pk_id_modulos`);

--
-- Indices de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  ADD PRIMARY KEY (`Pk_id_perfil`);

--
-- Indices de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Perfil`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD PRIMARY KEY (`idregistro`),
  ADD KEY `Fk_id_modulos` (`Fk_id_modulos`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--


--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id_venta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  MODIFY `Id_ayuda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  MODIFY `PK_id_Perfil_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `Pk_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=200;

--
-- AUTO_INCREMENT de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  MODIFY `Pk_consultaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  MODIFY `Pk_id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  MODIFY `PK_id_Aplicacion_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  MODIFY `PK_id_Aplicacion_Perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=223;

--
-- AUTO_INCREMENT de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  MODIFY `idregistro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tbl_usuarios`
--
ALTER TABLE `tbl_usuarios`
  MODIFY `Pk_id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Restricciones para tablas volcadas
--
-- Filtros para la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--


--
-- Filtros para la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_1` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD CONSTRAINT `tbl_regreporteria_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_regreporteria_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

ALTER TABLE `Tbl_bitacora`
ADD COLUMN `tabla` VARCHAR(50) NOT NULL;


-- Estructura de tabla para la tabla `ayuda`
--

-- Implementación de Nominas con la base de datos general ya que fue aprobado por Brandon Boch
-- solo se espera las dos revisiones para que sea subido al repositorio principal
DROP TABLE IF EXISTS tbl_planilla_Detalle;
DROP TABLE IF EXISTS tbl_planilla_Encabezado;
DROP TABLE IF EXISTS tbl_contratos;
DROP TABLE IF EXISTS tbl_horas_extra;
DROP TABLE IF EXISTS tbl_control_anticipos;
DROP TABLE IF EXISTS tbl_control_faltas;
DROP TABLE IF EXISTS tbl_Liquidacion_Trabajadores;
DROP TABLE IF EXISTS tbl_dedu_perp_emp;
DROP TABLE IF EXISTS tbl_asignacion_vacaciones;
DROP TABLE IF EXISTS tbl_empleados;
DROP TABLE IF EXISTS tbl_puestos_trabajo;
DROP TABLE IF EXISTS tbl_departamentos;
DROP TABLE IF EXISTS tbl_dedu_perp;
DROP TABLE IF EXISTS tbl_empresas;
DROP TABLE IF EXISTS tbl_polizas;

CREATE TABLE tbl_puestos_trabajo (
	pk_id_puestos INT NOT NULL AUTO_INCREMENT,
    puestos_nombre_puesto VARCHAR(50),
    puestos_descripcion  VARCHAR(50),
    primary key (`pk_id_puestos`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_departamentos (
	pk_id_departamento  INT NOT NULL AUTO_INCREMENT,
    departamentos_nombre_departamento VARCHAR(50),
    departamentos_descripcion  VARCHAR(50) NOT NULL,
    primary key (`pk_id_departamento`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS tbl_empleados (
	pk_clave INT NOT NULL AUTO_INCREMENT,
    empleados_nombre VARCHAR(50) NOT NULL,
    empleados_apellido  VARCHAR(50),
    empleados_fecha_nacimiento  date,
    empleados_no_identificacion  VARCHAR(50) NOT NULL,
    empleados_codigo_postal  VARCHAR(50),
    empleados_fecha_alta  date,
    empleados_fecha_baja date,
    empleados_causa_baja  VARCHAR(50),
    fk_id_departamento INT NOT NULL, 
    fk_id_puestos INT NOT NULL, 
	FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` (`pk_id_departamento`),
    FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`), 
	primary key (`pk_clave`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);
select* from tbl_empleados;
CREATE TABLE  tbl_asignacion_vacaciones (
	pk_registro_vaciones int auto_increment not null,
    asignacion_vacaciones_descripcion varchar(25),
    asignacion_vacaciones_fecha_inicio date,
    asignacion_vacaciones_fecha_fin date,
    fk_clave_empleado INT NOT NULL, 
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_vaciones`)
);

CREATE TABLE  tbl_contratos (
	pk_id_contrato INT NOT NULL AUTO_INCREMENT,
    contratos_fecha_creacion date NOT NULL,
    contratos_salario  decimal(10,2) NOT NULL,
    contratos_tipo_contrato varchar(35), 
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_id_contrato`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_horas_extra (
	pk_registro_horas INT NOT NULL AUTO_INCREMENT,
    horas_mes varchar(25),
    horas_cantidad_horas decimal(10,2),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_horas`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_control_anticipos (
	pk_registro_anticipos INT NOT NULL AUTO_INCREMENT,
    anticipos_cantidad decimal(10,2),
    anticipos_descripcion varchar(50),
    anticipos_mes varchar(25),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_anticipos`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_control_faltas (
	pk_registro_faltas INT NOT NULL AUTO_INCREMENT,
    faltas_fecha_falta date,
    faltas_mes varchar(25),
    faltas_justificacion varchar(25),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_faltas`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE tbl_Liquidacion_Trabajadores (
	pk_registro_liquidacion INT NOT NULL AUTO_INCREMENT,
    liquidacion_aguinaldo decimal (10,2) not null,
    liquidacion_bono_14 decimal (10,2) not null,
    liquidacion_vacaciones decimal (10,2) not null,
    liquidacion_tipo_operacion varchar(25), 
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_liquidacion`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_planilla_Encabezado (
	pk_registro_planilla_Encabezado INT NOT NULL AUTO_INCREMENT,
    encabezado_correlativo_planilla int not null, 
    encabezado_fecha_inicio date,
    encabezado_fecha_final date,
    encabezado_total_mes decimal(10,2),
    primary key (`pk_registro_planilla_Encabezado`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_planilla_Detalle (
	pk_registro_planilla_Detalle INT NOT NULL AUTO_INCREMENT,
    detalle_total_Percepciones decimal (10,2),
    detalle_total_Deducciones decimal(10,2),
    detalle_total_liquido decimal(10,2),
    fk_clave_empleado int not null, 
    fk_id_contrato int not null,
    fk_id_registro_planilla_Encabezado int not null,
    -- fk_registro_horas int not null,
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`),
    FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES `tbl_planilla_Encabezado` (`pk_registro_planilla_Encabezado`),
    primary key (`pk_registro_planilla_Detalle`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE tbl_dedu_perp (
    pk_dedu_perp INT NOT NULL AUTO_INCREMENT,
    dedu_perp_clase varchar(25),
    dedu_perp_concepto VARCHAR(25), -- IGSS, Vacaciones, Bonificacion Incentivo
    dedu_perp_tipo VARCHAR(25), -- Porcentaje o monton
    dedu_perp_aplicacion varchar(25), -- Todos, ninguno, etc
    dedu_perp_excepcion TINYINT(1), 
    dedu_perp_monto FLOAT,
    estado TINYINT(1),
    PRIMARY KEY ( pk_dedu_perp)
);

CREATE TABLE tbl_dedu_perp_emp (
    pk_dedu_perp_emp INT NOT NULL AUTO_INCREMENT,
    Fk_clave_empleado INT NOT NULL,
    Fk_dedu_perp INT NOT NULL,
    dedu_perp_emp_cantidad FLOAT, -- Este campo basicamente calculara la deduccion a la que se asocie el empleado
    -- Si es un % (como el IGSS) se multiplica el sueldo base (que lo tenemos en el contrato) por ese porcentaje(%)
    -- Si es un monto (que seria fijo cada mes, como Descuentos judiciales por ejemplo Q400, ese valor solo se copiara
    -- a "cantidad_deduccion"
    estado TINYINT(1),
    FOREIGN KEY (Fk_clave_empleado) REFERENCES tbl_empleados (pk_clave),
    FOREIGN KEY (Fk_dedu_perp ) REFERENCES tbl_dedu_perp (pk_dedu_perp),
    PRIMARY KEY (pk_dedu_perp_emp)
);

CREATE TABLE tbl_empresas (
    empresa_id INT AUTO_INCREMENT PRIMARY KEY,  -- Llave primaria autoincremental
    empresas_nombre VARCHAR(255) NOT NULL,       -- Nombre de la empresa
    empresas_logo LONGBLOB,                              -- Campo para almacenar la foto (logo) en formato binario
    empresas_fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,  -- Campo para la fecha de creación
    empresas_direccion VARCHAR(255),                     -- Dirección de la empresa
    empresas_telefono VARCHAR(20),                       -- Número de teléfono de la empresa
    empresas_email VARCHAR(100),                         -- Correo electrónico de la empresa
    empresas_pagina_web VARCHAR(100),                     -- Página web de la empresa
    estado TINYINT(1)                          -- Estado de la empresa (activa/inactiva)
);
-- Aqui termina nóminas

-- Modulo de Contabilidad

-- Tabla para encabezados de clases de cuentas
CREATE TABLE IF NOT EXISTS tbl_encabezadoclasecuenta (
    Pk_id_encabezadocuenta INT NOT NULL, 
    nombre_tipocuenta VARCHAR(50) NOT NULL,
    estado TINYINT(1) NOT NULL, 
    PRIMARY KEY (Pk_id_encabezadocuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

-- Tabla para tipos de cuenta
CREATE TABLE IF NOT EXISTS tbl_tipocuenta (
    PK_id_tipocuenta INT NOT NULL, 
    nombre_tipocuenta VARCHAR(50) NOT NULL,
    serie_tipocuenta VARCHAR(50) NOT NULL,
    estado TINYINT NOT NULL, 
    PRIMARY KEY (PK_id_tipocuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

-- Tabla para tipos de póliza
CREATE TABLE IF NOT EXISTS tbl_tipopoliza (
    Pk_id_tipopoliza INT NOT NULL, 
    tipo VARCHAR(65),
    estado TINYINT NOT NULL, 
    PRIMARY KEY (Pk_Id_tipopoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para encabezados de póliza
CREATE TABLE IF NOT EXISTS tbl_polizaencabezado (
    Pk_id_polizaencabezado INT AUTO_INCREMENT NOT NULL, 
    fechaPoliza VARCHAR(50),
    concepto VARCHAR(65),
    Pk_id_tipopoliza INT NOT NULL, 
    PRIMARY KEY (Pk_id_polizaencabezado),
    FOREIGN KEY (Pk_id_tipopoliza) REFERENCES tbl_tipopoliza (Pk_id_tipopoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para tipos de operación
CREATE TABLE IF NOT EXISTS tbl_tipooperacion (
    Pk_id_tipooperacion INT NOT NULL,
    nombre VARCHAR(65), 
    estado TINYINT NOT NULL, 
    PRIMARY KEY (Pk_id_tipooperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- Tabla para cuentas
CREATE TABLE IF NOT EXISTS tbl_cuentas (
    Pk_id_cuenta INT UNIQUE NOT NULL, 
    Pk_id_tipocuenta INT NOT NULL, 
    Pk_id_encabezadocuenta INT NOT NULL,
    nombre_cuenta VARCHAR(50) NOT NULL,
    cargo_mes FLOAT DEFAULT 0,
    abono_mes FLOAT DEFAULT 0,
    saldo_ant FLOAT DEFAULT 0,
    saldo_act FLOAT DEFAULT 0,
    cargo_acumulado FLOAT DEFAULT 0,
    abono_acumulado FLOAT DEFAULT 0,
    Pk_id_cuenta_enlace INT NULL,
    estado TINYINT NOT NULL,
    
    PRIMARY KEY (Pk_id_cuenta, Pk_id_tipocuenta, Pk_id_encabezadocuenta),
    
    FOREIGN KEY (Pk_id_tipocuenta) REFERENCES tbl_tipocuenta(PK_id_tipocuenta),
    FOREIGN KEY (Pk_id_encabezadocuenta) REFERENCES tbl_encabezadoclasecuenta(Pk_id_encabezadocuenta),
    FOREIGN KEY (Pk_id_cuenta_enlace) REFERENCES tbl_cuentas(Pk_id_cuenta)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

CREATE TABLE IF NOT EXISTS tbl_configuracion (
    Pk_id_config INT AUTO_INCREMENT NOT NULL PRIMARY KEY,      
    mes INT NOT NULL,                                 
    anio INT NOT NULL,                                
    metodo VARCHAR(10) NOT NULL,                     
    Pk_id_cuenta INT NOT NULL,                       
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas(Pk_id_cuenta)  
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabla para activos fijos
CREATE TABLE IF NOT EXISTS tbl_activofijo (
    Pk_id_idactivofijo INT(11) NOT NULL AUTO_INCREMENT,  
    Codigo_Activo VARCHAR(50) NOT NULL,               
    Tipo_Activo VARCHAR(50) DEFAULT NULL,            
    Descripcion VARCHAR(255) NOT NULL,                
    Marca VARCHAR(100) DEFAULT NULL,                  
    Modelo VARCHAR(100) DEFAULT NULL,                
    Fecha_Adquisicion DATE DEFAULT NULL,              
    Costo_Adquisicion DECIMAL(10,2) DEFAULT NULL,    
    Vida_Util DECIMAL(5,2) DEFAULT NULL,              
    Valor_Residual DECIMAL(10,2) DEFAULT NULL,        
    Estado VARCHAR(50) DEFAULT NULL,                  
    Pk_id_cuenta INT NOT NULL,                        
    PRIMARY KEY (Pk_id_idactivofijo),                    
    UNIQUE (Codigo_Activo),                           
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas (Pk_id_cuenta) ON DELETE CASCADE 
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla para detalles de póliza
CREATE TABLE IF NOT EXISTS tbl_polizadetalle (
    Pk_id_polizadetalle INT AUTO_INCREMENT NOT NULL, 
    Pk_id_polizaencabezado INT NOT NULL,
    Pk_id_cuenta INT NOT NULL,
    Pk_id_tipooperacion INT NOT NULL,
    valor FLOAT,

    PRIMARY KEY (Pk_id_polizadetalle),

    FOREIGN KEY (Pk_id_polizaencabezado) REFERENCES tbl_polizaencabezado (Pk_id_polizaencabezado),
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas (Pk_id_cuenta),
    FOREIGN KEY (Pk_id_tipooperacion) REFERENCES tbl_tipooperacion (Pk_id_tipooperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS tbl_historico_cuentas (
    Pk_id_cuenta INT NOT NULL, 
    mes INT NOT NULL,
    anio INT NOT NULL,
    cargo_mes FLOAT DEFAULT 0,
    abono_mes FLOAT DEFAULT 0,
    saldo_ant FLOAT DEFAULT 0,
    saldo_act FLOAT DEFAULT 0,
    cargo_acumulado FLOAT DEFAULT 0,
    abono_acumulado FLOAT DEFAULT 0,
    saldoanual FLOAT DEFAULT 0,
    
    PRIMARY KEY (Pk_id_cuenta, mes, anio),
    FOREIGN KEY (Pk_id_cuenta) REFERENCES tbl_cuentas(Pk_id_cuenta)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla presupuesto
CREATE TABLE tbl_presupuesto (
Pk_id_presupuesto INT PRIMARY KEY AUTO_INCREMENT,
nombre_presupuesto VARCHAR(100),
ejercicio_presupuesto INT,
fecha_creacion DATE,
total_presupuesto DECIMAL(18, 2),
estado TINYINT(1) NOT NULL DEFAULT 1
);

-- Tabla detalle presupuesto
CREATE TABLE tbl_detalle_presupuesto (
Pk_id_detalle INT PRIMARY KEY AUTO_INCREMENT,
Fk_id_presupuesto INT,
Fk_id_cuenta INT,
mes_enero DECIMAL(18, 2),
mes_febrero DECIMAL(18, 2),
mes_marzo DECIMAL(18, 2),
mes_abril DECIMAL(18, 2),
mes_mayo DECIMAL(18, 2),
mes_junio DECIMAL(18, 2),
mes_julio DECIMAL(18, 2),
mes_agosto DECIMAL(18, 2),
mes_septiembre DECIMAL(18, 2),
mes_octubre DECIMAL(18, 2),
mes_noviembre DECIMAL(18, 2),
mes_diciembre DECIMAL(18, 2),
total_cuenta DECIMAL(18, 2),

FOREIGN KEY (Fk_id_presupuesto) REFERENCES tbl_presupuesto(Pk_id_presupuesto),
FOREIGN KEY (Fk_id_cuenta) REFERENCES tbl_cuentas(Pk_id_cuenta)
);
-- FIN MODULO CONTABILIDAD


-- MODULO DE LOGISTICA
CREATE TABLE Tbl_chofer (
    Pk_id_chofer INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nombreEmpresa VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    licencia VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    direccion VARCHAR(255)
  );
  
CREATE TABLE Tbl_vehiculos (
    Pk_id_vehiculo INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    numeroPlaca VARCHAR(10) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    color VARCHAR(30) NOT NULL,
    descripcion TEXT,
    horaLlegada DATETIME NOT NULL,
    horaSalida DATETIME,
    pesoTotal DECIMAL(10, 2) NOT NULL,
    Fk_id_chofer INT NOT NULL,
    Estado VARCHAR (30),
    FOREIGN KEY (Fk_id_chofer) REFERENCES Tbl_chofer(Pk_id_chofer)
);
ALTER TABLE Tbl_vehiculos
MODIFY Estado TINYINT NOT NULL DEFAULT 1;

CREATE TABLE Tbl_remitente (
    Pk_id_remitente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    correoElectronico VARCHAR(100)
);

CREATE TABLE Tbl_destinatario (
    Pk_id_destinatario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    correoElectronico VARCHAR(100)
);
 
CREATE TABLE Tbl_datos_pedido (
    Pk_id_guia INT AUTO_INCREMENT PRIMARY KEY,
    fechaEmision DATE NOT NULL,
    fechaTraslado DATE NOT NULL,
    direccionPartida VARCHAR(255) NOT NULL,
    direccionLlegada VARCHAR(255) NOT NULL,
    numeroOrdenRecojo VARCHAR(20),
    formaPago VARCHAR(50) NOT NULL,
    destino VARCHAR(255) NOT NULL,
    Fk_id_remitente INT NOT NULL,
    Fk_id_destinatario INT NOT NULL,
    Fk_id_vehiculo INT NOT NULL,
    FOREIGN KEY (Fk_id_remitente) REFERENCES Tbl_remitente(Pk_id_remitente),  
    FOREIGN KEY (Fk_id_destinatario) REFERENCES Tbl_destinatario(Pk_id_destinatario),
    FOREIGN KEY (Fk_id_vehiculo) REFERENCES Tbl_vehiculos(Pk_id_vehiculo)
);

CREATE TABLE Tbl_Productos (
    Pk_id_Producto INT AUTO_INCREMENT PRIMARY KEY,
    codigoProducto INT NOT NULL,
    nombreProducto VARCHAR(30) NOT NULL,
    medidaProducto VARCHAR(20) NOT NULL,
    precioUnitario DECIMAL(10, 2) NOT NULL,
    clasificacion VARCHAR(30) NOT NULL,
    estado VARCHAR(50) NOT NULL DEFAULT 'Activo'
);

ALTER TABLE Tbl_Productos
ADD COLUMN stock INT NOT NULL;
ALTER TABLE Tbl_Productos
ADD COLUMN empaque VARCHAR(50) NOT NULL;
ALTER TABLE Tbl_Productos
CHANGE COLUMN medidaProducto pesoProducto VARCHAR(20);
ALTER TABLE Tbl_Productos
MODIFY estado TINYINT NOT NULL DEFAULT 1;

CREATE TABLE Tbl_TrasladoProductos (
    Pk_id_TrasladoProductos INT AUTO_INCREMENT PRIMARY KEY,
    documento VARCHAR(50) NOT NULL,
    fecha DATETIME NOT NULL,
    cantidad INT NOT NULL,  
    costoTotal DECIMAL(10, 2) NOT NULL,
    costoTotalGeneral DECIMAL(10, 2) NOT NULL,
    precioTotal DECIMAL(10, 2) NOT NULL,
    Fk_id_Producto INT NOT NULL,
    Fk_id_guia INT NOT NULL,
    FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_guia) REFERENCES Tbl_datos_pedido(Pk_id_guia)
);

ALTER TABLE Tbl_TrasladoProductos
DROP COLUMN cantidad;

drop table if exists TBL_LOCALES;
CREATE TABLE TBL_LOCALES (
    Pk_ID_LOCAL INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE_LOCAL VARCHAR(100) NOT NULL,
    UBICACION VARCHAR(255) NOT NULL,
    CAPACIDAD INT NOT NULL,
    ESTADO VARCHAR(50) NOT NULL DEFAULT 'Activo',
    FECHA_REGISTRO DATETIME DEFAULT NOW()
);
ALTER TABLE TBL_LOCALES
MODIFY ESTADO TINYINT NOT NULL DEFAULT 1;

CREATE TABLE Tbl_movimiento_de_inventario (
	Pk_id_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    estado TINYINT NOT NULL DEFAULT 1,
    Fk_id_producto INT NOT NULL,
    Fk_id_stock INT NOT NULL,
    Fk_ID_LOCALES INT NOT NULL,
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_stock) REFERENCES Tbl_TrasladoProductos(Pk_id_TrasladoProductos),
    CONSTRAINT FK_EXISTENCIA_LOCAL FOREIGN KEY (Fk_ID_LOCALES) REFERENCES TBL_LOCALES(Pk_ID_LOCAL)
);
ALTER TABLE Tbl_movimiento_de_inventario
MODIFY estado TINYINT NOT NULL DEFAULT 1;

CREATE TABLE Tbl_mantenimiento (
	Pk_id_Mantenimiento INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nombre_Solicitante varchar(20) NOT NULL,
    tipo_de_Mantenimiento varchar(15) NOT NULL,
    componente_Afectado varchar(15) NOT NULL,
    fecha DATE NOT NULL,
    responsable_Asignado varchar(20) NOT NULL,
    codigo_Error_Problema varchar (50) NOT NULL,
    estado_del_Mantenimiento varchar (20) NOT NULL,
    tiempo_Estimado varchar (30) NOT NULL,
	Fk_id_vehiculo INT NOT NULL,
    FOREIGN KEY (Fk_id_vehiculo) REFERENCES Tbl_vehiculos(Pk_id_vehiculo)
);

CREATE TABLE TBL_BODEGAS (
 Pk_ID_BODEGA INT AUTO_INCREMENT PRIMARY KEY,
 NOMBRE_BODEGA VARCHAR(100) NOT NULL,
 UBICACION VARCHAR(255) NOT NULL,
 CAPACIDAD INT NOT NULL,
 FECHA_REGISTRO DATE
);
ALTER TABLE TBL_BODEGAS
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;

CREATE TABLE TBL_EXISTENCIAS_BODEGA (
    Pk_ID_EXISTENCIA INT AUTO_INCREMENT PRIMARY KEY,
    Fk_ID_BODEGA INT NOT NULL,
    Fk_ID_PRODUCTO INT NOT NULL,
    CANTIDAD_ACTUAL INT NOT NULL,
    CANTIDAD_INICIAL INT NOT NULL,
    CONSTRAINT FK_EXISTENCIA_BODEGA FOREIGN KEY (Fk_ID_BODEGA) REFERENCES TBL_BODEGAS(Pk_ID_BODEGA),
    CONSTRAINT FK_EXISTENCIA_PRODUCTO FOREIGN KEY (Fk_ID_PRODUCTO) REFERENCES Tbl_Productos(Pk_id_Producto)
);
 
CREATE TABLE TBL_AUDITORIAS (
    Pk_ID_AUDITORIA INT AUTO_INCREMENT PRIMARY KEY,
    Fk_ID_BODEGA INT NOT NULL,
    Fk_ID_PRODUCTO INT NOT NULL,  -- Agregando la clave foránea para el producto
    FECHA_AUDITORIA DATE,
    DISCREPANCIA_DETECTADA BOOLEAN DEFAULT FALSE,
    CANTIDAD_REGISTRADA INT NOT NULL,
    CANTIDAD_FISICA INT NOT NULL,
    OBSERVACIONES TEXT,
    FOREIGN KEY (Fk_ID_BODEGA) REFERENCES TBL_BODEGAS(Pk_ID_BODEGA),
    FOREIGN KEY (Fk_ID_PRODUCTO) REFERENCES Tbl_Productos(Pk_id_Producto)  -- Clave foránea para el producto
);

CREATE TABLE Tbl_Marca (
	Pk_id_Marca INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_Marca VARCHAR(50),
    descripcion VARCHAR(100),
    estado VARCHAR(30),
    fk_id_Producto INT,
    foreign key (fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);
ALTER TABLE Tbl_Marca
MODIFY estado TINYINT NOT NULL DEFAULT 1;

CREATE TABLE Tbl_Linea(
	Pk_id_linea INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_linea VARCHAR(50),
    estado VARCHAR (30),
    fk_id_marca INT,
    foreign key (fk_id_Marca) REFERENCES Tbl_Marca(Pk_id_Marca)    
);
ALTER TABLE Tbl_Linea
MODIFY estado TINYINT NOT NULL DEFAULT 1;

-- FIN MODULO DE LIGISTICA


-- modulo comercial inicio
 -- Tabla Clientes
CREATE TABLE IF NOT EXISTS Tbl_clientes(
    Pk_id_cliente int(11) NOT NULL,
    Clientes_nombre VARCHAR(100) NOT NULL,
    Clientes_apellido VARCHAR(100) NOT NULL,
    Clientes_nit VARCHAR(20) NOT NULL,
    Clientes_telefon VARCHAR(20) NOT NULL ,
    Clientes_direccion VARCHAR(255) NOT NULL,
    Clientes_No_Cuenta VARCHAR(255) NOT NULL,
    Clientes_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_cliente)
);

-- Tabla Vendedores
CREATE TABLE IF NOT EXISTS Tbl_vendedores (
    Pk_id_vendedor int (11) NOT NULL,
    vendedores_nombre VARCHAR(100)NOT NULL ,
    vendedores_apellido VARCHAR(100)NOT NULL ,
    vendedores_sueldo DECIMAL(10,2)NOT NULL ,
    vendedores_direccion VARCHAR(255)NOT NULL ,
    vendedores_telefono VARCHAR(20)NOT NULL ,
	Fk_id_empleado INT NOT NULL,
    Fk_id_cliente INT NOT NULL,
    vendedores_estado tinyint(1) DEFAULT 1,
    FOREIGN KEY (Fk_id_empleado) REFERENCES tbl_empleados(pk_clave),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_vendedor)
);

-- Tabla Proveedores
CREATE TABLE IF NOT EXISTS Tbl_proveedores (
    Pk_prov_id INT,
    Prov_nombre VARCHAR(100) NOT NULL,
    Prov_direccion VARCHAR(255),
    Prov_telefono VARCHAR(20),
    Prov_email VARCHAR(100),
    Prov_fechaRegistro DATE,
    Prov_estado tinyint(1) DEFAULT 1,
     PRIMARY KEY (Pk_prov_id)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS Tbl_lista_encabezado (
    Pk_id_lista_Encabezado INT(11) NOT NULL,
    ListEncabezado_nombre VARCHAR(50),
    ListEncabezado_fecha DATE,
    ListEncabezado_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_lista_Encabezado)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS Tbl_lista_detalle (
    Pk_id_lista_detalle INT(11) NOT NULL,
    Fk_id_lista_Encabezado INT NOT NULL,
    Fk_id_Producto INT NOT NULL,
    ListDetalle_preVenta DECIMAL(10,2) NULL, -- precio de venta
    ListDetalle_descuento DECIMAL(10,2) NULL,
    ListDetalle_impuesto DECIMAL(10,2) NULL,
    FOREIGN KEY (Fk_id_lista_Encabezado) REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado),
    FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    PRIMARY KEY (Pk_id_lista_detalle)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla Ordenes de Compra
CREATE TABLE IF NOT EXISTS Tbl_ordenes_compra (
    Pk_encOrCom_id  int (11) NOT NULL,
    EncOrCom_numero VARCHAR(20) NOT NULL UNIQUE,
    Fk_prov_id INT,
    EncOrCom_fechaEntrega DATE,
    FOREIGN KEY (Fk_prov_id) REFERENCES Tbl_proveedores(Pk_prov_id),
    PRIMARY KEY (Pk_encOrCom_id)
);

-- Tabla Detalle Ordenes de Compra
CREATE TABLE IF NOT EXISTS Tbl_detalle_ordenes_compra (
    Pk_detOrCom_id  int (11) NOT NULL,
    Fk_encOrCom_id INT,
    Fk_id_producto INT,
    DetOrCom_cantidad INT NOT NULL,
    DetOrCom_preUni DECIMAL(10,2) NOT NULL,
    DetOrCom_total DECIMAL(10,2),
    FOREIGN KEY (Fk_encOrCom_id) REFERENCES Tbl_ordenes_compra(Pk_encOrCom_id),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_productos(Pk_id_producto),
    PRIMARY KEY (Pk_detOrCom_id)
);

-- Tabla Póliza
CREATE TABLE IF NOT EXISTS Tbl_poliza (
    Pk_id_poliza  int (11) NOT NULL,
    Poliza_fecha_emision DATE NOT NULL,
    Poliza_concepto VARCHAR(255) NOT NULL,
    Poliza_docto VARCHAR(50),
    PRIMARY KEY (Pk_id_poliza)
);

-- Tabla Movimiento
CREATE TABLE IF NOT EXISTS Tbl_movimiento (
    Pk_id_movimiento  int (11) NOT NULL,
    Movimiento_codigo VARCHAR(50) NOT NULL,
    Movimiento_cuenta VARCHAR(50) NOT NULL,
    Movimiento_tipo VARCHAR(20) NOT NULL,
    Movimiento_valor DECIMAL(10,2) NOT NULL,
    Movimiento_cargos DECIMAL(10,2) NOT NULL,
    Movimiento_abonos DECIMAL(10,2) NOT NULL,
    Fk_id_poliza INT,
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    PRIMARY KEY (Pk_id_movimiento)
);

-- Tabla Contabilidad
CREATE TABLE IF NOT EXISTS Tbl_contabilidad (
    Pk_id_contabilidad  int (11) NOT NULL,
    Contabilidad_tipo_registro VARCHAR(50) NOT NULL,
    Contabilidad_descripcion VARCHAR(255) NOT NULL,
    PRIMARY KEY (Pk_id_contabilidad)
);

-- Relación entre Póliza y Contabilidad
CREATE TABLE IF NOT EXISTS Tbl_poliza_contabilidad (
    Fk_id_poliza  int (11) NOT NULL,
    Fk_id_contabilidad INT,
    PRIMARY KEY (Fk_id_poliza, Fk_id_contabilidad),
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    FOREIGN KEY (Fk_id_contabilidad) REFERENCES Tbl_contabilidad(Pk_id_contabilidad)
);

-- Tabla Rango de Fechas
CREATE TABLE IF NOT EXISTS Tbl_rango_fechas (
    Pk_id_rango  int (11) NOT NULL,
    Rango_fecha_inicio DATE NOT NULL,
    Rango_fecha_fin DATE NOT NULL,
    PRIMARY KEY (Pk_id_rango)
);

-- Relación entre Póliza y Rango de Fechas
CREATE TABLE IF NOT EXISTS Tbl_poliza_rango_fechas (
    Fk_id_poliza  int (11) NOT NULL,
    Fk_id_rango INT,
    PRIMARY KEY (Fk_id_poliza, Fk_id_rango),
    FOREIGN KEY (Fk_id_poliza) REFERENCES Tbl_poliza(Pk_id_poliza),
    FOREIGN KEY (Fk_id_rango) REFERENCES Tbl_rango_fechas(Pk_id_rango)
);

-- Tabla Cotización Encabezado
CREATE TABLE IF NOT EXISTS Tbl_cotizacion_encabezado (
    Pk_id_cotizacionEnc int (11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Fk_id_cliente INT NOT NULL,
    CotizacionEnc_fechaVenc DATE NOT NULL,
    CotizacionEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_cotizacionEnc)
);

-- Tabla Cotización Detalle
CREATE TABLE IF NOT EXISTS Tbl_cotizacion_detalle (
    Pk_id_CotizacionDet int (11) NOT NULL,
    Fk_id_cotizacionEnc INT  NOT NULL, 
    Fk_id_producto INT  NOT NULL,
    CotizacionDet_cantidad INT  NOT NULL,
    CotizacionDet_precio DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_lista_detalle(Pk_id_lista_detalle),
    PRIMARY KEY (Pk_id_CotizacionDet)
);


-- Tabla Pedido Encabezado
CREATE TABLE IF NOT EXISTS Tbl_pedido_encabezado (
    Pk_id_PedidoEnc int (11) NOT NULL,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_vendedor INT  NOT NULL,
    PedidoEncfecha DATE  NOT NULL,
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_PedidoEnc)
);

-- Tabla Pedido Detalle
CREATE TABLE IF NOT EXISTS Tbl_pedido_detalle (
    Pk_id_pedidoDet int (11) NOT NULL,
    Fk_id_pedidoEnc INT,
    Fk_id_producto INT,
    Fk_id_cotizacionEnc int,
    PedidoDet_cantidad int,
    PedidoEnc_precio decimal(10,2),
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_pedidoEnc) REFERENCES Tbl_pedido_encabezado(Pk_id_PedidoEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_productos(Pk_id_producto),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    PRIMARY KEY (Pk_id_pedidoDet)
);

-- Tabla Factura Encabezado
CREATE TABLE IF NOT EXISTS Tbl_factura (
    Pk_id_factura int (11) NOT NULL,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_pedidoEnc INT  NOT NULL,
    factura_fecha DATE  NOT NULL,
    factura_formPago VARCHAR(20)  NOT NULL,
    factura_subtotal DECIMAL(10,2)  NOT NULL,
    factura_iva DECIMAL(10,2)  NOT NULL,
    factura_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
	FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_factura)
);

-- Tabla Comisiones Encabezado
CREATE TABLE IF NOT EXISTS Tbl_comisiones_encabezado (
    Pk_id_comisionEnc INT(11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Comisiones_fecha_ DATE NOT NULL,
    Comisiones_total_venta DECIMAL(10,2) NOT NULL,
    Comisiones_total_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_comisionEnc)
);

-- Detalle Comisiones
CREATE TABLE IF NOT EXISTS Tbl_detalle_comisiones (
    Pk_id_detalle_comision INT(11) NOT NULL,
    Fk_id_comisionEnc INT NOT NULL,
    Fk_id_factura INT NOT NULL,
    Comisiones_porcentaje DECIMAL(5,2) NOT NULL,
    Comisiones_monto_venta DECIMAL(10,2) NOT NULL,
    Comisiones_monto_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_comisionEnc) REFERENCES Tbl_comisiones_encabezado(Pk_id_comisionEnc),
    FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura),
    PRIMARY KEY (Pk_id_detalle_comision)
);

-- modulo comercial final

-- modulo bancos inicio
-- Tabla: tbl_banco
CREATE TABLE tbl_banco (
    pk_banco_id INT AUTO_INCREMENT PRIMARY KEY,
    banco_nombre VARCHAR(100) NOT NULL
);

-- Tabla: tbl_cuentabancaria
CREATE TABLE tbl_cuentabancaria (
    pk_cuenta_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_banco_id INT NOT NULL,
    cuenta_numero VARCHAR(20) UNIQUE NOT NULL,
    cuenta_saldo DECIMAL(10,2) NOT NULL,
    cuenta_tipo VARCHAR(50) NOT NULL,
    CONSTRAINT fk_banco FOREIGN KEY (fk_banco_id) REFERENCES tbl_banco(pk_banco_id)
);

-- Tabla: tbl_movimientobancario
CREATE TABLE tbl_movimientobancario (
    pk_movimientobancario_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_cuenta_id INT NOT NULL,
    movimientobancario_fecha DATE NOT NULL,
    movimientobancario_tipo VARCHAR(50) NOT NULL,
    movimientobancario_monto DECIMAL(10,2) NOT NULL,
    movimientobancario_descripcion TEXT,
    movimientobancario_metodo_pago VARCHAR(50),
    movimientobancario_estado TINYINT(1),
    CONSTRAINT fk_cuenta FOREIGN KEY (fk_cuenta_id) REFERENCES tbl_cuentabancaria(pk_cuenta_id)
);

-- Tabla: tbl_transaccion
CREATE TABLE tbl_transaccion (
    pk_transaccion_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_cuenta_id INT NOT NULL,
    transaccion_fecha DATETIME NOT NULL,
    transaccion_monto DECIMAL(10,2) NOT NULL,
    transaccion_estado TINYINT(1) NOT NULL,
    CONSTRAINT fk_cuenta_id FOREIGN KEY (fk_cuenta_id) REFERENCES tbl_cuentabancaria(pk_cuenta_id)
);

create table tbl_tipoCambio (
	pk_id_tipoCambio INT AUTO_INCREMENT PRIMARY KEY,
    tipoCambio_nombre_moneda VARCHAR (50) NOT NULL,
    tipoCambio_valor_moneda decimal (5,3) NOT NULL,
    tipoCambio_valorCambio_moneda decimal (5,3) NOT NULL,
    tipoCambio_estatus TINYINT (1) DEFAULT 1
);
-- finaliza modulo bancos

-- inica modulo de cuentas corrientes
-- TBL_cobrador
CREATE TABLE IF NOT EXISTS `Tbl_cobrador` (
	Pk_id_cobrador INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_empleado INT NOT NULL,
    cobrador_nombre VARCHAR(150) NOT NULL,
    cobrador_direccion VARCHAR(150) NOT NULL,
    cobrador_telefono INT NOT NULL,
    cobrador_depto VARCHAR(150) NOT NULL,
    cobrador_estado TINYINT DEFAULT 0 NOT NULL,    
    FOREIGN KEY (`Fk_id_empleado`) REFERENCES tbl_empleados (pk_clave) -- Referencia a tablas de Nominas
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- TBL_paises
CREATE TABLE IF NOT EXISTS `Tbl_paises` (
	Pk_id_pais INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pais_nombre VARCHAR(150) NOT NULL,
    pais_region VARCHAR(150) NOT NULL,
    pais_estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Formadepago
CREATE TABLE IF NOT EXISTS `Tbl_Formadepago` (
	Pk_id_pago INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pago_nombre VARCHAR(150) NOT NULL,
    pago_tipo_moneda VARCHAR(15) NOT NULL,
    pado_estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- TBL_Deudas_Clientes
CREATE TABLE IF NOT EXISTS `Tbl_Deudas_Clientes` (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_cobrador INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    deuda_monto DECIMAL(10, 2) NOT NULL,
    deuda_fecha_inicio_deuda VARCHAR(255) NOT NULL,
    deuda_fecha_vencimiento_deuda VARCHAR(255) NOT NULL,
    deuda_descripcion_deuda VARCHAR(255),
    deuda_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clientes` (Pk_id_cliente),
    FOREIGN KEY (`Fk_id_cobrador`) REFERENCES `Tbl_cobrador` (`Pk_id_cobrador`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Transaccion_clientes
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_cliente` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    transaccion_fecha VARCHAR(150) NOT NULL,
    tansaccion_cuenta VARCHAR(150) NOT NULL,
    transaccion_cuotas VARCHAR(2) NOT NULL,
    transaccion_monto Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    transaccion_tipo_moneda VARCHAR(100) NOT NULL,
    transaccionserie VARCHAR(100) NOT NULL,
    transaccion_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clienteS` (`Pk_id_cliente`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_mora_clientes
CREATE TABLE IF NOT EXISTS Tbl_mora_clientes (
    Pk_id_mora INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_transaccion INT NOT NULL,
    morafecha DATE NOT NULL,
    mora_monto DECIMAL(10, 2) NOT NULL,
    mora_dias INT NOT NULL,
    mora_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_transaccion) REFERENCES Tbl_Transaccion_cliente (Pk_id_transaccion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_caja_clientes
CREATE TABLE IF NOT EXISTS Tbl_caja_cliente (
    Pk_id_caja_cliente INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    caja_cliente_nombre VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    caja_deuda_monto DECIMAL(10, 2) NOT NULL,
    caja_mora_monto DECIMAL(10, 2) NOT NULL,
    caja_transaccion_monto DECIMAL(10, 2) NOT NULL,
    caja_saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    caja_estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    caja_fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Clientes (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Deuda_Proveedores
    CREATE TABLE IF NOT EXISTS Tbl_Deudas_Proveedores (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    deuda_monto DECIMAL(10, 2) NOT NULL,
    deuda_fecha_inicio DATE NOT NULL,
    deuda_fecha_vencimiento DATE NOT NULL,
    deuda_descripcion VARCHAR(255),
    deuda_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (Fk_id_proveedor) REFERENCES Tbl_proveedores (Pk_prov_id),
    FOREIGN KEY (Fk_id_pago) REFERENCES Tbl_Formadepago (Pk_id_pago)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Transaccion_proveedor
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_proveedor` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    fecha_transaccion VARCHAR(150) NOT NULL,
    tansaccion_cuenta VARCHAR(150) NOT NULL,
    tansaccion_cuotas VARCHAR(2) NOT NULL,
    transaccion_monto Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    transaccion_tipo_moneda VARCHAR(100) NOT NULL,
    transaccion_serie VARCHAR(100) NOT NULL,
    transaccion_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `Tbl_proveedores` (`Pk_prov_id`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_caja_proveedor
CREATE TABLE IF NOT EXISTS Tbl_caja_proveedor (
    Pk_id_caja_proveedor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    caja_proveedor_nombre VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    caja_deuda_monto DECIMAL(10, 2) NOT NULL,
    caja_transaccion_monto DECIMAL(10, 2) NOT NULL,
    caja_saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    caja_estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    caja_fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_proveedor) REFERENCES Tbl_proveedores (Pk_prov_id),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Proveedores (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Tabla nueva Transacciones_cuentas
CREATE TABLE IF NOT EXISTS Tbl_transaccion_cuentas (
	Pk_id_tran_cue INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    tran_nombre VARCHAR(150) NOT NULL,
    tran_efecto VARCHAR(15) NOT NULL,
    estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- FIN TABLAS MAESTRAS CUENTAS CORRIENTES

-- INICIA CREACIÓN DE TABLAS PRODUCCIÓN
CREATE TABLE IF NOT EXISTS `tbl_cierre_produccion` (
  `pk_id_cierre` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `saldo_anterior` decimal(10,2) NOT NULL,
  `cargos_mes` decimal(10,2) NOT NULL,
  `abonos_mes` decimal(10,2) NOT NULL,
  `saldo_actual` decimal(10,2) NOT NULL,
  `cargos_acumulados` decimal(10,2) NOT NULL,
  `abonos_acumulados` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_conversiones` (
  `id_conversion` int(11) NOT NULL,
  `unidad_origen` varchar(50) NOT NULL,
  `unidad_destino` varchar(50) NOT NULL,
  `factor_conversion` decimal(10,6) NOT NULL,
  `tipo_conversion` varchar(50) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_detalles` (
  `Pk_id_lotes_detalle` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `Fk_id_lote` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_encabezado` (
  `Pk_id_lote` int(11) NOT NULL,
  `codigo_lote` varchar(100) DEFAULT NULL,
  `Fecha_Producción` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_mantenimientos` (
  `Pk_id_maquinaria` int(11) NOT NULL,
  `nombre_maquinaria` varchar(255) DEFAULT NULL,
  `tipo_maquina` varchar(255) DEFAULT NULL,
  `hora_operacion` decimal(10,2) DEFAULT NULL,
  `mantenimiento_periodico` varchar(100) DEFAULT NULL,
  `ultima_mantenimiento` date DEFAULT NULL,
  `proximo_mantenimiento` date DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `desgaste_porcentaje` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion` (
  `Pk_id_orden` int(11) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_orden` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_detalle` (
  `Pk_id_proceso_detalle` int(11) NOT NULL,
  `Fk_id_productos` int(11) DEFAULT NULL,
  `Fk_id_receta` int(11) DEFAULT NULL,
  `Fk_id_empleado` int(11) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `costo_u` decimal(10,2) DEFAULT NULL,
  `costo_t` decimal(10,2) DEFAULT NULL,
  `duracion_horas` decimal(10,2) DEFAULT NULL,
  `mano_de_obra` decimal(10,2) DEFAULT NULL,
  `costo_luz` decimal(10,2) DEFAULT NULL,
  `costo_agua` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_encabezado` (
  `Pk_id_proceso` int(11) NOT NULL,
  `Fk_id_orden` int(11) DEFAULT NULL,
  `Fk_id_maquinaria` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_recetas` (
  `Pk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `cama` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_receta_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_rrhh_produccion` (
  `id_RRHH` int(10) UNSIGNED NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `id_contrato` int(11) NOT NULL,
  `dias` int(11) NOT NULL,
  `total_dias` decimal(10,2) NOT NULL,
  `horas` decimal(10,2) NOT NULL,
  `total_horas` decimal(10,2) NOT NULL,
  `id_hora_extra` int(11) DEFAULT NULL,
  `total_horas_extras` decimal(10,2) DEFAULT NULL,
  `total_mano_obra` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
-- FIN DE CREACIÓN DE TABLA DE PRODUCCIÓN


-- Nueva tabla creada por parte de producción 03-11-2024 aprobado por Brandon Boch
-- 1. Creación de tabla maquinaria, hablada con el ingeniero.
CREATE TABLE IF NOT EXISTS `tbl_maquinaria` (
  `pk_id_maquina` int(11) AUTO_INCREMENT PRIMARY KEY,
  `nombre_maquina` varchar(100) NOT NULL,
  `tipo_maquina` varchar(50) NOT NULL,
  `capacidad_produccion` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Fin

--  CREACIÓN DE NUEVAS TABLAS PARA EL MODULO DE CONTABILIDAD - ACTIVOS FIJOS APROBADO POR BRANDON BOCH 03-11-2024

DROP TABLE IF EXISTS `tbl_ActivoFijo`;

-- Creación de la tabla `tbl_TipoActivoFijo`
CREATE TABLE IF NOT EXISTS `tbl_TipoActivoFijo` (
  `Pk_Id_TipoActivoFijo` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Tipo` VARCHAR(50) NOT NULL,
  `Estado` TINYINT(4) NOT NULL,
  PRIMARY KEY (`Pk_Id_TipoActivoFijo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_IdentidadActivo` (
  `Pk_Id_Identidad` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Identidad` VARCHAR(50) NOT NULL,
  `Estado` TINYINT(4) NOT NULL,
  PRIMARY KEY (`Pk_Id_Identidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ActivoFijo` (
  `Pk_Id_ActivoFijo` INT(11) NOT NULL AUTO_INCREMENT,
  `Codigo_Activo` VARCHAR(50) NOT NULL UNIQUE,
  `Pk_Id_TipoActivoFijo` INT(11) DEFAULT NULL,
  `Descripcion` VARCHAR(255) NOT NULL,
  `Pk_Id_Identidad` INT(11) DEFAULT NULL,
  `Modelo` VARCHAR(100) DEFAULT NULL,
  `Fecha_Adquisicion` DATE DEFAULT NULL,
  `Costo_Adquisicion` DECIMAL(10,2) DEFAULT NULL,
  `Vida_Util` DECIMAL(5,2) DEFAULT NULL,
  `Valor_Residual` DECIMAL(10,2) DEFAULT NULL,
  `Estado` TINYINT(4) DEFAULT NULL,
  `Pk_Id_Cuenta` INT(11) NOT NULL,
  PRIMARY KEY (`Pk_Id_ActivoFijo`),
  KEY `Fk_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`),
  KEY `Fk_Identidad` (`Pk_Id_Identidad`),
  KEY `Fk_Cuenta` (`Pk_Id_Cuenta`),
  CONSTRAINT `Fk_TipoActivoFijo_New` FOREIGN KEY (`Pk_Id_TipoActivoFijo`) REFERENCES `tbl_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`) ON DELETE SET NULL,
  CONSTRAINT `Fk_Identidad_New` FOREIGN KEY (`Pk_Id_Identidad`) REFERENCES `tbl_IdentidadActivo` (`Pk_Id_Identidad`) ON DELETE SET NULL,
  CONSTRAINT `Fk_Cuenta_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_Cuentas` (`Pk_Id_Cuenta`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Creación de la tabla `tbl_Depreciacion_ActivoFijo`
CREATE TABLE IF NOT EXISTS `tbl_Depreciacion_ActivoFijo` (
  `Pk_Id_Depreciacion` INT(11) NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` INT(11) NOT NULL,
  `Nombre_Activo` VARCHAR(100) NOT NULL,
  `Tipo_Activo` VARCHAR(50) NOT NULL,
  `Encargado` VARCHAR(100) DEFAULT NULL,
  `Departamento` VARCHAR(100) DEFAULT NULL,
  `Fecha_Depreciacion` DATE DEFAULT NULL,
  `Depreciacion` DECIMAL(10,2) DEFAULT NULL,
  `Depreciacion_Fiscal` DECIMAL(10,2) DEFAULT NULL,
  `Descripcion` VARCHAR(255) DEFAULT NULL,
  `Estado` TINYINT(4) DEFAULT NULL,
  `Pk_Id_Cuenta` INT(11) NOT NULL,
  PRIMARY KEY (`Pk_Id_Depreciacion`),
  CONSTRAINT `Fk_IdActivoFijo_Depreciacion` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_ActivoFijo` (`Pk_Id_ActivoFijo`) ON DELETE CASCADE,
  CONSTRAINT `Fk_Cuenta_Depreciacion_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_Cuentas` (`Pk_Id_Cuenta`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- FIN

-- INICIO DE CREACIÓN DE TABLA POR PARTE DEL MODULO DE CONTABILIDAD EL DIA 05-11-2024
CREATE TABLE IF NOT EXISTS `tbl_historial_servicio` (
  `Pk_Id_HistorialServicio` INT(11) NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` INT(11) NOT NULL,
  `Compania_Asegurada` VARCHAR(100) NOT NULL,
  `Agente_Seguro` VARCHAR(100) NOT NULL,
  `Tel_Siniestro` VARCHAR(20) NOT NULL,
  `Tipo_Cobertura` VARCHAR(50) NOT NULL,
  `Monto_Asegurado` DECIMAL(10,2) NOT NULL,
  `Prima_Total` DECIMAL(10,2) NOT NULL,
  `Deducible` DECIMAL(10,2) NOT NULL,
  `Vigencia` DATE NOT NULL,
  `Fecha_Util` DATE NOT NULL,
  `Costo_Servicio` DECIMAL(10,2) NOT NULL,
  `Periodo_Servicio` INT(11) NOT NULL, -- Periodo en meses
  `Prox_Servicio` DATE NOT NULL,
  `Estado` TINYINT(4) NOT NULL, -- Campo para el estado del servicio
  PRIMARY KEY (`Pk_Id_HistorialServicio`),
  KEY `Fk_ActivoFijo` (`Pk_Id_ActivoFijo`),
  CONSTRAINT `Fk_ActivoFijo_HistorialServicio` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_ActivoFijo` (`Pk_Id_ActivoFijo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
-- FIN APROBADO POR BRANDON BOCH