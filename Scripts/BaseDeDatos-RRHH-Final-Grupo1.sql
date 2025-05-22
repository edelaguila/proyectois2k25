-- create database nominasPrueba; 
-- use nominasPrueba; 
-- DROP DATABASE nominasPrueba; 
-- use colchoneria; 

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
 FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` 
(`pk_id_departamento`), 
    FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`),  
 primary key (`pk_clave`), 
    estado TINYINT(1) NOT NULL DEFAULT 1 
); 
 
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
    FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES 
`tbl_planilla_Encabezado` (`pk_registro_planilla_Encabezado`), 
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
    dedu_perp_emp_cantidad FLOAT, -- Este campo basicamente calculara la deduccion a la 
    estado TINYINT(1), 
    FOREIGN KEY (Fk_clave_empleado) REFERENCES tbl_empleados (pk_clave), 
    FOREIGN KEY (Fk_dedu_perp ) REFERENCES tbl_dedu_perp (pk_dedu_perp), 
    PRIMARY KEY (pk_dedu_perp_emp) 
); 
 
CREATE TABLE tbl_empresas ( 
    empresa_id INT AUTO_INCREMENT PRIMARY KEY,  -- Llave primaria autoincremental 
    empresas_nombre VARCHAR(255) NOT NULL,       -- Nombre de la empresa 
    empresas_logo LONGBLOB,                              -- Campo para almacenar la foto (logo) en 
    empresas_direccion VARCHAR(255),                     -- Dirección de la empresa 
    empresas_telefono VARCHAR(20),                       -- Número de teléfono de la empresa 
    empresas_email VARCHAR(100),                         -- Correo electrónico de la empresa 
    empresas_pagina_web VARCHAR(100),                     -- Página web de la empresa 
    estado TINYINT(1)                          -- Estado de la empresa (activa/inactiva) 
); 
 
ALTER TABLE tbl_dedu_perp_emp 
ADD COLUMN dedu_perp_emp_mes VARCHAR(25) NOT NULL AFTER 
dedu_perp_emp_cantidad; 
 -- Ingresos obligatorios Nominas 
INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado)  
VALUES ('Faltas', 'Porcentaje', 'Todos', 'Sin excepción', 0, 20.00, 1); 
 
INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, 
dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado)  
VALUES ('Anticipo', 'Monto', 'Todos', 'Sin excepción', 0, 1, 1); 
 
INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, 
dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado)  
VALUES ('Horas Extras', 'Monto', 'Todos', 'Sin excepción', 0, 1, 1); 
 
INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, 
dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto,estado)  
VALUES ('Bono 14','Bono 14','Porcentaje','Todos',0,8.33,1); 
 
INSERT INTO tbl_dedu_perp (dedu_perp_clase, 
dedu_perp_concepto,dedu_perp_tipo,dedu_perp_aplicacion,dedu_perp_excepcion,dedu_perp_monto,estado)  
VALUES ('Aguinaldo','Aguinaldo','Porcentaje','Todos',0,8.33,1); 
 
INSERT INTO tbl_dedu_perp 
(dedu_perp_clase,dedu_perp_concepto,dedu_perp_tipo,dedu_perp_aplicacion,dedu_perp_excepcion,dedu_perp_monto,estado)  
VALUES ('Vacaciones','Vacaciones','Porcentaje','Todos',0,5.75,1); 


-- ----------------------------------------------- Reclutamiento Brandon Boch ---------------------------------------------
ALTER TABLE tbl_puestos_trabajo
ADD COLUMN requisitos VARCHAR(250);

DROP TABLE IF EXISTS Tbl_postulante;
CREATE TABLE IF NOT EXISTS Tbl_postulante(
	Pk_id_postulante INT AUTO_INCREMENT PRIMARY KEY,
	Fk_puesto_aplica_postulante INT NULL,
    nombre_postulante VARCHAR(50) NOT NULL,
    apellido_postulante VARCHAR(50) NOT NULL,
    email_postulante VARCHAR(50) NOT NULL,
    telefono_postulante VARCHAR(15) NOT NULL
);
ALTER TABLE Tbl_postulante ADD CONSTRAINT Fk_puesto_aplica_postulante FOREIGN KEY (Fk_puesto_aplica_postulante) REFERENCES tbl_puestos_trabajo(pk_id_puestos) ON DELETE SET NULL;

DROP TABLE IF EXISTS Tbl_expedientes;
CREATE TABLE IF NOT EXISTS Tbl_expedientes(
	Pk_id_expediente INT AUTO_INCREMENT PRIMARY KEY,
    Fk_id_postulante INT NULL,
    curriculum LONGBLOB,
    pruebas_psicometricas LONGBLOB,
    pruebas_psicologicas LONGBLOB,
    pruebas_aptitud LONGBLOB
);
ALTER TABLE Tbl_expedientes ADD CONSTRAINT Fk_id_postulante FOREIGN KEY (Fk_id_postulante) REFERENCES Tbl_postulante(Pk_id_postulante) ON DELETE SET NULL;

DROP TABLE IF EXISTS Tbl_perfil_postulante;
CREATE TABLE IF NOT EXISTS Tbl_perfil_postulante(
	Pk_id_perfil_postulante INT AUTO_INCREMENT PRIMARY KEY,
    Fk_id_puestos INT NULL,
    nivel_academico VARCHAR(50),
    idiomas VARCHAR(50),
    experiencia VARCHAR(50),
    certificaciones VARCHAR(250),
    habilidades VARCHAR (250)
);
ALTER TABLE Tbl_perfil_postulante ADD CONSTRAINT Fk_id_puestos FOREIGN KEY (Fk_id_puestos) REFERENCES tbl_puestos_trabajo(pk_id_puestos) ON DELETE SET NULL;
-- -----------------------------------------------------------------------------------------------------------------------------------
-- --------------------------- Faltas Marco Monroy -----------------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tbl_asistencias (
    pk_id_asistencia INT NOT NULL AUTO_INCREMENT,
    fk_id_empleado INT NOT NULL,
    fecha DATE NOT NULL,
    hora_entrada TIME,
    hora_salida TIME,
    estado_asistencia ENUM('Presente', 'Falta', 'Permiso') DEFAULT 'Presente',
    PRIMARY KEY (pk_id_asistencia),
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados(pk_clave)
);

CREATE TABLE IF NOT EXISTS tbl_permisos (
    pk_id_permiso INT NOT NULL AUTO_INCREMENT,
    fk_id_empleado INT NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    tipo_permiso VARCHAR(50), -- Ejemplo: 'Médico', 'Personal'
    aprobado TINYINT(1) DEFAULT 0, -- 1 = Aprobado, 0 = Pendiente o Denegado
    PRIMARY KEY (pk_id_permiso),
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados(pk_clave)
);

ALTER TABLE tbl_control_faltas
ADD COLUMN justificada TINYINT(1) DEFAULT 0; -- 1 = Justificada, 0 = No

ALTER TABLE tbl_control_faltas
ADD COLUMN fk_id_permiso INT DEFAULT NULL,
ADD CONSTRAINT fk_permiso_falta FOREIGN KEY (fk_id_permiso) REFERENCES tbl_permisos(pk_id_permiso);
-- ------------------------------------------------------------------------------------------------------------------------------------
-- -------------------------- Capacitacion Joel ------------------------------------------------------------------------------
ALTER TABLE tbl_departamentos 
ADD COLUMN departamentos_competencia VARCHAR(100) NOT NULL;



-- Creación de tbl_instructores
CREATE TABLE IF NOT EXISTS tbl_instructores (
    pk_id_instructor INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    instructores_nombre VARCHAR(50) NOT NULL,
    instructores_apellido VARCHAR(50) NOT NULL,
    instructores_especialidad VARCHAR(100) NOT NULL,
    instructores_email VARCHAR(100) UNIQUE NOT NULL,
    instructores_telefono VARCHAR(20),
    estado TINYINT(1) NOT NULL DEFAULT 1
);



-- Creación de tbl_capacitaciones
CREATE TABLE IF NOT EXISTS tbl_capacitaciones (
    pk_id_capacitacion INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    capacitaciones_nombre VARCHAR(100) NOT NULL,
    capacitaciones_descripcion TEXT,
    fk_id_departamento INT NOT NULL,
    fk_id_instructor INT NOT NULL,
    capacitaciones_fecha DATE NOT NULL,
    capacitaciones_hora TIME NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_departamento) REFERENCES tbl_departamentos (pk_id_departamento),
    FOREIGN KEY (fk_id_instructor) REFERENCES tbl_instructores (pk_id_instructor)
);

-- Creación de tbl_cierres
CREATE TABLE IF NOT EXISTS tbl_cierres (
    pk_id_cierre INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_empleado INT NOT NULL,
    fk_id_capacitacion INT NOT NULL,
    cierres_competencia VARCHAR(100) NOT NULL,
    cierres_porcentaje_asistencia DECIMAL(5,2) NOT NULL CHECK (cierres_porcentaje_asistencia BETWEEN 0 AND 100),
    cierre_fecha DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados (pk_clave),
    FOREIGN KEY (fk_id_capacitacion) REFERENCES tbl_capacitaciones (pk_id_capacitacion)
);

-- Creación de tbl_notas
CREATE TABLE IF NOT EXISTS tbl_notas (
    pk_id_nota INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_empleado INT NOT NULL,
    fk_id_capacitacion INT NOT NULL,
    notas_nivel CHAR(1) NOT NULL CHECK (notas_nivel IN ('D', 'C', 'B', 'A')),
    notas_puntaje DECIMAL(5,2) NOT NULL CHECK (notas_puntaje BETWEEN 0 AND 100),
    notas_fecha DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados (pk_clave),
    FOREIGN KEY (fk_id_capacitacion) REFERENCES tbl_capacitaciones (pk_id_capacitacion)
);
-- ----------------------------------------------------------------------------------------------------
-- ---------------------------------------Desempeño Jose Daniel Sierra---------------------------------------------
 CREATE TABLE tbl_evaluaciones (
    pk_id_evaluacion INT NOT NULL AUTO_INCREMENT,
    fk_clave_empleado INT NOT NULL,
    tipo_evaluacion VARCHAR(50) NOT NULL,
    calificacion DECIMAL(5, 2) NOT NULL,
    comentarios TEXT,
    fecha_evaluacion DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_evaluacion),
    FOREIGN KEY (fk_clave_empleado) REFERENCES tbl_empleados(pk_clave)
);
-- Creación de tbl_resultados_evaluacion
CREATE TABLE tbl_resultados_evaluacion (
    pk_id_resultado INT NOT NULL AUTO_INCREMENT,
    fk_clave_empleado INT NOT NULL,
    calificacion_final DECIMAL(5, 2) NOT NULL,
    fecha_consolidacion DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_resultado),
    FOREIGN KEY (fk_clave_empleado) REFERENCES tbl_empleados(pk_clave)
);
-- Creación de tbl_bonos_promociones
CREATE TABLE tbl_bonos_promociones (
    pk_id_bono_promocion INT NOT NULL AUTO_INCREMENT,
    fk_id_resultado INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    monto DECIMAL(10, 2),
    fecha_recomendacion DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_bono_promocion),
    FOREIGN KEY (fk_id_resultado) REFERENCES tbl_resultados_evaluacion(pk_id_resultado)
);
-- ---------------------------------------------------------------------------------------------------------------
-- --------------------------------------Desarrollo de carrera - Ismar Cortez----------------------------------------
CREATE TABLE tbl_promociones (
    pk_id_promocion INT NOT NULL AUTO_INCREMENT,
    fk_clave_empleado INT NOT NULL,
    promociones_fecha DATE NOT NULL,
    promociones_puesto_actual VARCHAR(50) NOT NULL,
    promociones_salario_actual DECIMAL(10,2) NOT NULL,
    promociones_nuevo_puesto VARCHAR(50) NOT NULL,
    promociones_nuevo_salario DECIMAL(10,2) NOT NULL,
    promociones_motivo VARCHAR(255),
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_promocion),
    FOREIGN KEY (fk_clave_empleado) REFERENCES tbl_empleados (pk_clave)
);
-- ------------------------------------------------------------------------------------------------------------------

-- -------------------------------------Gestion Disciplinaria - Kevin Hamilton--------------------------------------------------------

-- Creación de la tabla de faltas disciplinarias
CREATE TABLE tbl_faltas_disciplinarias (
    pk_id_falta INT NOT NULL AUTO_INCREMENT,
    fk_clave_empleado INT NOT NULL,
    falta_fecha DATE NOT NULL,
    falta_tipo VARCHAR(50) NOT NULL,
    falta_descripcion TEXT NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_falta),
    FOREIGN KEY (fk_clave_empleado) REFERENCES tbl_empleados (pk_clave)
);

-- Creación de la tabla de evidencias asociadas a una falta disciplinaria
CREATE TABLE tbl_evidencias (
    pk_id_evidencia INT NOT NULL AUTO_INCREMENT,
    fk_id_falta INT NOT NULL,
    evidencia_tipo VARCHAR(50) NOT NULL,  -- Ejemplo: Imagen, Video, Documento
    evidencia_url TEXT NOT NULL,          -- Ruta donde se almacena la evidencia
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_evidencia),
    FOREIGN KEY (fk_id_falta) REFERENCES tbl_faltas_disciplinarias (pk_id_falta)
);

-- Creación de la tabla de sanciones asociadas a una falta disciplinaria
CREATE TABLE tbl_sanciones (
    pk_id_sancion INT NOT NULL AUTO_INCREMENT,
    fk_id_falta INT NOT NULL,
    sancion_tipo VARCHAR(50) NOT NULL,  -- Ejemplo: Amonestación, Suspensión, Despido
    sancion_descripcion TEXT NOT NULL,
    sancion_fecha DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_sancion),
    FOREIGN KEY (fk_id_falta) REFERENCES tbl_faltas_disciplinarias (pk_id_falta)
);

 

-- ------------------------------------------------------------------------------------------------------------------
