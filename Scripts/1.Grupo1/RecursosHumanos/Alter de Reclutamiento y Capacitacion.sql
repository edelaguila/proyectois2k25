use colchoneria; 
ALTER TABLE tbl_puestos_trabajo
ADD COLUMN Fk_id_perfil INT NULL;

-- Tabla para nivel educativo
CREATE TABLE IF NOT EXISTS Tbl_nivel_educativo (
    Pk_id_nivel INT AUTO_INCREMENT PRIMARY KEY,
    nivel VARCHAR(50) NOT NULL UNIQUE,
    estado TINYINT(1) NOT NULL DEFAULT 1
);

-- Tabla para disponibilidad
CREATE TABLE IF NOT EXISTS Tbl_disponibilidad (
    Pk_id_disponibilidad INT AUTO_INCREMENT PRIMARY KEY,
    disponibilidad VARCHAR(50) NOT NULL UNIQUE,
    estado TINYINT(1) NOT NULL DEFAULT 1
);

INSERT INTO Tbl_nivel_educativo (nivel) VALUES 
('Primaria'), ('Secundaria'), ('Técnico'), ('Universitario'), ('Postgrado');

-- Insertar opciones en Tbl_disponibilidad
INSERT INTO Tbl_disponibilidad (disponibilidad) VALUES 
('Inmediata'), ('1 semana'), ('1 mes'), ('Otro');

DROP TABLE IF EXISTS Tbl_postulante;
CREATE TABLE IF NOT EXISTS Tbl_postulante(
    Pk_id_postulante INT AUTO_INCREMENT PRIMARY KEY,
    Fk_puesto_aplica_postulante INT NULL,
    nombre_postulante VARCHAR(50) NOT NULL,
    apellido_postulante VARCHAR(50) NOT NULL,
    email_postulante VARCHAR(50) NOT NULL,
    telefono_postulante VARCHAR(15) NOT NULL,
    anios_experiencia INT NOT NULL DEFAULT 0,
    trabajo_anterior VARCHAR(100) NULL,
    puesto_anterior VARCHAR(50) NULL,
    Fk_nivel_educativo INT NOT NULL,
    titulo_obtenido VARCHAR(100) NULL,
    Fk_disponibilidad INT NOT NULL,
    salario_pretendido DECIMAL(10,2) NULL,
    fecha_postulacion DATETIME,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    
    CONSTRAINT Fk_puesto_aplica_postulante FOREIGN KEY (Fk_puesto_aplica_postulante) REFERENCES tbl_puestos_trabajo(pk_id_puestos) ON DELETE SET NULL,
    CONSTRAINT Fk_nivel_educativo FOREIGN KEY (Fk_nivel_educativo) REFERENCES Tbl_nivel_educativo(Pk_id_nivel) ON DELETE RESTRICT,
    CONSTRAINT Fk_disponibilidad FOREIGN KEY (Fk_disponibilidad) REFERENCES Tbl_disponibilidad(Pk_id_disponibilidad) ON DELETE RESTRICT
);

DROP TABLE IF EXISTS Tbl_expedientes;
CREATE TABLE IF NOT EXISTS Tbl_expedientes(
	Pk_id_expediente INT AUTO_INCREMENT PRIMARY KEY,
    Fk_id_postulante INT NULL,
    curriculum LONGBLOB,
    pruebas_psicometricas LONGBLOB,
    pruebas_psicologicas LONGBLOB,
    pruebas_aptitud LONGBLOB,
    estado TINYINT(1) NOT NULL DEFAULT 1
);
ALTER TABLE Tbl_expedientes ADD CONSTRAINT Fk_id_postulante FOREIGN KEY (Fk_id_postulante) REFERENCES Tbl_postulante(Pk_id_postulante) ON DELETE SET NULL;

DROP TABLE IF EXISTS Tbl_perfil_postulante;
CREATE TABLE IF NOT EXISTS Tbl_perfil_postulante(
	Pk_id_perfil_postulante INT AUTO_INCREMENT PRIMARY KEY,
    Fk_id_puestos INT NULL,
    anios_experiencia INT NOT NULL DEFAULT 0,
	Fk_nivel_educativo_esperado INT NOT NULL,
    titulo_esperado VARCHAR(100) NULL,
    salario_minimo DECIMAL(10,2) NULL,
    salario_maximo DECIMAL(10,2) NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    CONSTRAINT Fk_id_puestos FOREIGN KEY (Fk_id_puestos) REFERENCES tbl_puestos_trabajo(pk_id_puestos) ON DELETE SET NULL,
	CONSTRAINT Fk_nivel_educativo_esperado FOREIGN KEY (Fk_nivel_educativo_esperado) REFERENCES Tbl_nivel_educativo(Pk_id_nivel) ON DELETE RESTRICT
);


DROP TABLE IF EXISTS Tbl_status_ats;
CREATE TABLE IF NOT EXISTS Tbl_status_ats(
	Pk_id_status INT AUTO_INCREMENT PRIMARY KEY,
    nombre_status VARCHAR(50),
    descripcion VARCHAR(250),
    estado TINYINT(1) NOT NULL DEFAULT 1
);
select * from Tbl_status_ats;
INSERT INTO Tbl_status_ats (nombre_status, descripcion) VALUES
('Postulación recibida', 'CV ingresado al sistema'),
('En revisión', 'El reclutador está analizando el perfil y puesto al que aplicó'),
('Entrevista programada', 'Cita agendada para entrevista'),
('Rechazado', 'No fue seleccionado'),
('Aceptado', 'Listo para iniciar el proceso de contratación');

DROP TABLE IF EXISTS Tbl_ats;
CREATE TABLE IF NOT EXISTS Tbl_ats(
	Pk_id_ats INT AUTO_INCREMENT PRIMARY KEY,
    Fk_id_postulantes INT NULL,
    Fk_id_puesto INT NULL,
    Fk_id_status INT NULL,
    fecha DATETIME,
    estado TINYINT(1) NOT NULL DEFAULT 1
);
ALTER TABLE Tbl_ats ADD CONSTRAINT Fk_id_postulantes FOREIGN KEY (Fk_id_postulantes) REFERENCES Tbl_postulante(Pk_id_postulante) ON DELETE SET NULL;
ALTER TABLE Tbl_ats ADD CONSTRAINT Fk_id_puesto FOREIGN KEY (Fk_id_puesto) REFERENCES tbl_puestos_trabajo(pk_id_puestos) ON DELETE SET NULL;
ALTER TABLE Tbl_ats ADD CONSTRAINT Fk_id_status FOREIGN KEY (Fk_id_status) REFERENCES Tbl_status_ats(Pk_id_status) ON DELETE SET NULL;

DROP TABLE IF EXISTS Tbl_competencias;
CREATE TABLE IF NOT EXISTS Tbl_competencias(
	Pk_id_competencia INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_competencia VARCHAR(100),
    descripcion VARCHAR(250),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

-- JOEL LÓPEZ -------------------------------------------------
DROP TABLE IF EXISTS tbl_nivelcompetencia;
CREATE TABLE IF NOT EXISTS tbl_nivelcompetencia (
	pk_id_nivel INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nivel_nombre CHAR,  -- a b c d 
    nivel_descripcion VARCHAR(100),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

-- Insertar registros en Tbl_cobrador
INSERT INTO tbl_nivelcompetencia (nivel_nombre, nivel_descripcion, estado)
VALUES 
('A', 'Nivel Alto', 1),
('B', 'Nivel Bueno', 1),
('C', 'Nivel Regular', 1),
('D', 'Nivel Bajo', 1);

-- Tabla intermedia para la relación muchos a muchos
DROP TABLE IF EXISTS tbl_departamentos_competencias;
CREATE TABLE IF NOT EXISTS tbl_departamentos_competencias (
    fk_id_departamento INT NOT NULL,
    fk_id_competencia INT NOT NULL,
    nivelactual CHAR NOT NULL,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (fk_id_departamento, fk_id_competencia),
    CONSTRAINT fk_departamento FOREIGN KEY (fk_id_departamento) REFERENCES tbl_departamentos(pk_id_departamento) ON DELETE CASCADE,
    CONSTRAINT fk_competencia FOREIGN KEY (fk_id_competencia) REFERENCES Tbl_competencias(Pk_id_competencia) ON DELETE CASCADE
);

ALTER TABLE tbl_departamentos 
ADD COLUMN departamentos_competencia VARCHAR(100) NOT NULL;

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


-- Agregar columnas a tbl_capacitaciones
ALTER TABLE tbl_capacitaciones 
ADD COLUMN fk_id_competencia INT NOT NULL AFTER capacitaciones_hora,
ADD COLUMN fk_id_capacitaciones_nivelfinal INT NOT NULL AFTER fk_id_competencia;


ALTER TABLE tbl_capacitaciones 
ADD CONSTRAINT fk_capacitaciones_competencia FOREIGN KEY (fk_id_competencia) 
    REFERENCES tbl_competencias(pk_id_competencia),
ADD CONSTRAINT fk_capacitaciones_nivelfinal FOREIGN KEY (fk_id_capacitaciones_nivelfinal) 
    REFERENCES tbl_nivelcompetencia(pk_id_nivel);
    
 -- Insertar datos en tbl_instructores
INSERT INTO tbl_instructores (instructores_nombre, instructores_apellido, instructores_especialidad, instructores_email, instructores_telefono, estado) VALUES 
('Joel', 'Lopez', 'Hablar en público', 'joel@gmail.com', '41845784', 1);   

 -- ESTE INSERT ES DE PRUEBA PARA LAS COMPETENCIAS
INSERT INTO tbl_competencias (nombre_competencia, descripcion, estado) VALUES 
('Hablar en publico', 'para exposiciones y conferencias', 1);  

