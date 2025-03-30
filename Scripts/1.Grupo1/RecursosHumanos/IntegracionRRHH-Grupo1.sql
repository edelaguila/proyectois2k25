-- use colchoneria;
use colchoneria; 
-- Integración a colchoneria nuevos modulos RRHH
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


