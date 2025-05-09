 use colchoneria;
-- use nominasPrueba; 
-- Integración a colchoneria nuevos modulos RRHH

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
    estado TINYINT(1) NOT NULL DEFAULT 1, -- se agrego para funcionamiento del navegador
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
    fk_id_departamento INT NOT NULL,
    fk_id_capacitacion INT NOT NULL,
    cierres_puntuacion DECIMAL(5,2) NOT NULL CHECK (cierres_puntuacion BETWEEN 0 AND 100),
    cierres_porcentaje_asistencia DECIMAL(5,2) NOT NULL CHECK (cierres_porcentaje_asistencia BETWEEN 0 AND 100),
    cierre_fecha DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_departamento) REFERENCES tbl_departamentos (pk_id_departamento),
    FOREIGN KEY (fk_id_capacitacion) REFERENCES tbl_capacitaciones (pk_id_capacitacion)
);

DROP TABLE IF EXISTS tbl_nivelcompetencia;
-- Paso 1: Crear la tabla tbl_nivelcompetencia
CREATE TABLE IF NOT EXISTS tbl_nivelcompetencia (
    pk_id_nivel INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nivel_nombre CHAR(1) NOT NULL CHECK (nivel_nombre IN ('A', 'B', 'C', 'D')),  -- A, B, C, D
    nivel_descripcion VARCHAR(100),
    estado TINYINT(1) NOT NULL DEFAULT 1
);
-- Creación de tbl_notas
CREATE TABLE IF NOT EXISTS tbl_notas (
    pk_id_nota INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_empleado INT NOT NULL,
    fk_id_capacitacion INT NOT NULL,
    fk_id_nivel INT NOT NULL,
    notas_puntaje DECIMAL(5,2) NOT NULL CHECK (notas_puntaje BETWEEN 0 AND 100),
    notas_fecha DATE NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados (pk_clave),
    FOREIGN KEY (fk_id_capacitacion) REFERENCES tbl_capacitaciones (pk_id_capacitacion),
    FOREIGN KEY (fk_id_nivel) REFERENCES tbl_nivelcompetencia (pk_id_nivel)
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


