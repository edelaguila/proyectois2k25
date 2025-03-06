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

/*CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` varchar(255) DEFAULT NULL,
  `indice` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;*/

-- --------------------------------------------------------

-- Inicio tablas maestras
CREATE TABLE IF NOT EXISTS Tbl_Ciudadanos (
  Pk_Id_cuidadano INT(11) NOT NULL AUTO_INCREMENT,
  -- Ciudadano_DPI INT(11) NOT NULL,
  Cuidadano_nombres VARCHAR(60) NOT NULL,
  -- Cuidadano_apellidos VARCHAR(50) NOT NULL,
  Cuidadano_fecha_nac DATE NOT NULL,
  Cuidadano_correo VARCHAR(50) NOT NULL,
  Cuidadano_dire VARCHAR(50) NOT NULL,
  Cuidadano_nom_madre VARCHAR(60) NOT NULL,
  Cuidadano_nom_padre VARCHAR(60) NOT NULL,
  Ciudadano_estado_civil VARCHAR(60) NOT NULL,
  Cuidadano_genero VARCHAR(50) NOT NULL,
  Ciudadano_nacionalidad VARCHAR(60) NOT NULL,
  Ciudadano_lugar_nac VARCHAR(60) NOT NULL,
  Cuidadano_telefono INT(10) NOT NULL,
  Cuidadano_no_registro INT(15) NOT NULL,
  estado TINYINT(4) NOT NULL,
  PRIMARY KEY (Pk_Id_cuidadano)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS Tbl_Pago (
  Pk_Id_pago INT(11) NOT NULL AUTO_INCREMENT,
  Pago_nombreBanco VARCHAR(50) NOT NULL,
  Pago_correlativo TINYINT(10) NOT NULL,
  Pago_No_cgc TINYINT(10) NOT NULL,
  Pago_fecha DATE NOT NULL,
  Pago_cantidad TINYINT(10) NOT NULL,
  estado TINYINT(4) NOT NULL,
  PRIMARY KEY (Pk_Id_pago)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS Doc_Identificacion (
    PK_id_di INT(11) NOT NULL AUTO_INCREMENT,
    Doc_Tipo VARCHAR(50),
    Doc_No_di INT NOT NULL,
    Doc_Fecha_emision DATE NOT NULL,
    Doc_lugar_emision VARCHAR(50),
    estado TINYINT(4) NOT NULL,
    PRIMARY KEY (PK_id_di)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS Tbl_Oficinas (
    Pk_Id_Oficina INT(11) NOT NULL AUTO_INCREMENT,
    Oficina_Nombre VARCHAR(100) NOT NULL,
    Oficina_Direccion VARCHAR(255) NOT NULL,
    Oficina_Telefono VARCHAR(15),
    Oficina_Horario VARCHAR(50),
    estado TINYINT(4) NOT NULL DEFAULT 1, 
    PRIMARY KEY (Pk_Id_Oficina)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS Tbl_UsuariosOficina (
    Pk_Id_Usuario INT(11) NOT NULL AUTO_INCREMENT,
    Usuario_Nombre VARCHAR(50) NOT NULL,
    Usuario_Apellido VARCHAR(50) NOT NULL,
    Usuario_Email VARCHAR(100) NOT NULL UNIQUE,
    Usuario_Contraseña VARCHAR(255) NOT NULL,
    Usuario_Rol varchar(50) NOT NULL,
    estado TINYINT(4) NOT NULL DEFAULT 1,
    PRIMARY KEY (Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
-- Fin tablas maestras

CREATE TABLE IF NOT EXISTS Tbl_AgendarCita (
  Pk_Id_cita INT(11) NOT NULL AUTO_INCREMENT,
  Fk_id_pago INT(11) NOT NULL,
  Fk_id_oficina INT(11) NOT NULL,
  Cita_correlativo_pago TINYINT(10) NOT NULL,
  Cita_No_cgc TINYINT(10) NOT NULL,
  Cita_fecha DATETIME NOT NULL,
  -- Cita_hora DATE NOT NULL,
  Cita_tipo_tramite VARCHAR(50) NOT NULL, -- reprogramacion o agendar por primera vez
  estado TINYINT(4) NOT NULL,
  PRIMARY KEY ( Pk_Id_cita),
  FOREIGN KEY (Fk_id_pago) REFERENCES Tbl_Pago(Pk_Id_pago),
  FOREIGN KEY (Fk_id_oficina) REFERENCES Tbl_Oficinas(Pk_Id_Oficina)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Emerzon y Josue
-- Crear la tabla Tramite_Pasaporte
CREATE TABLE IF NOT EXISTS Tramite_Pasaporte (
    PK_id_tramite INT(11) NOT NULL AUTO_INCREMENT,
    FK_id_ciudadano INT(11) NOT NULL,
    FK_id_cita INT(11) NOT NULL,
    Tipo_tramite VARCHAR(50) NOT NULL,
    Fecha_inicio_tramite DATE NOT NULL,
    Fecha_fin_tramite DATE,
    estado TINYINT(4) NOT NULL,
    PRIMARY KEY (PK_Id_tramite),
    FOREIGN KEY (FK_Id_ciudadano) REFERENCES Tbl_Ciudadanos(PK_Id_cuidadano),
    FOREIGN KEY (FK_Id_cita) REFERENCES Tbl_AgendarCita(PK_Id_cita)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Crear la tabla Documentacion
CREATE TABLE IF NOT EXISTS Documentacion (
    PK_id_doc INT(11) NOT NULL AUTO_INCREMENT,
    FK_id_ciudadano INT(11) NOT NULL,
    Fk_id_di INT(11) NOT NULL,
    Doc_DPI_certificado VARCHAR(50),
    Doc_Form_solicitud VARCHAR(50),
    Doc_Pasaporte_vencido VARCHAR(50),
    Doc_Boleta_pago VARCHAR(50),
    Doc_DPI_padre VARCHAR(50),
    Doc_DPI_madre VARCHAR(50),
    estado TINYINT(4) NOT NULL,
    Fecha_present DATE NOT NULL,
    PRIMARY KEY (PK_id_doc),
    FOREIGN KEY (FK_id_ciudadano) REFERENCES Tbl_Ciudadanos(PK_Id_cuidadano),
    FOREIGN KEY (Fk_id_di) REFERENCES Doc_Identificacion(Pk_id_di) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Angel Y Shelly
CREATE TABLE IF NOT EXISTS Tbl_Historial_Tramites (
    Pk_Id_Historial INT(11) NOT NULL AUTO_INCREMENT,
    Fk_Id_Tramite INT(11) NOT NULL,
    Estado_Anterior TINYINT(4) NOT NULL,
    Estado_Nuevo TINYINT(4) NOT NULL,
    Fecha_Cambio DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Usuario_Responsable INT(11) NOT NULL,
    PRIMARY KEY (Pk_Id_Historial),
    FOREIGN KEY (Fk_Id_Tramite) REFERENCES Tramite_Pasaporte(PK_id_tramite),
    FOREIGN KEY (Usuario_Responsable) REFERENCES Tbl_UsuariosOficina(Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS Tbl_Multas (
    Pk_Id_Multa INT(11) NOT NULL AUTO_INCREMENT,
    Fk_Id_Ciudadano INT(11) NOT NULL,
    Motivo VARCHAR(255) NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    Fecha_Multa DATE NOT NULL,
    estado TINYINT(4) NOT NULL DEFAULT 1,
    PRIMARY KEY (Pk_Id_Multa),
    FOREIGN KEY (Fk_Id_Ciudadano) REFERENCES Tbl_Ciudadanos(Pk_Id_cuidadano)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS Tbl_Entrega_Pasaporte (
    Pk_Id_Entrega INT(11) NOT NULL AUTO_INCREMENT,
    Fk_Id_Tramite INT(11) NOT NULL,
    Fecha_Entrega DATE NOT NULL,
    Usuario_Entrega INT(11) NOT NULL,
    Firma_Recibido VARCHAR(255),
    estado TINYINT(4) NOT NULL DEFAULT 1,
    PRIMARY KEY (Pk_Id_Entrega),
    FOREIGN KEY (Fk_Id_Tramite) REFERENCES Tramite_Pasaporte(PK_id_tramite),
    FOREIGN KEY (Usuario_Entrega) REFERENCES Tbl_UsuariosOficina(Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;