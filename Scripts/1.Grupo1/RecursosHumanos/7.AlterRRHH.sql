use colchoneria; 
-- --------------------------------Brandon Boch --------------------------------------
ALTER TABLE Tbl_expedientes
DROP COLUMN pruebas_psicometricas,
-- DROP COLUMN pruebas_psicologicas,
DROP COLUMN pruebas_aptitud,
DROP COLUMN estado;

ALTER TABLE Tbl_expedientes
ADD COLUMN documento_entrevista LONGBLOB,
ADD COLUMN prueba_logica DECIMAL(5,2),
ADD COLUMN prueba_numerica DECIMAL(5,2),
ADD COLUMN prueba_verbal DECIMAL(5,2),
ADD COLUMN razonamiento DECIMAL(5,2),
ADD COLUMN prueba_tecnologica DECIMAL(5,2),
ADD COLUMN prueba_personalidad VARCHAR(255),
ADD COLUMN pruebas_psicometricas LONGBLOB;
-- --------------------------------------------------------------------------------
-- -------------------kEVIN--------------------------
-- Script para correciones y agregados a Gestion Disciplinaria

-- Primero renombrar el campo falta_tipo a fk_id_gravedad
ALTER TABLE tbl_faltas_disciplinarias
CHANGE COLUMN falta_tipo fk_id_gravedad INT NOT NULL,
CHANGE COLUMN estado fk_id_estado INT NOT NULL,
ADD COLUMN estado TINYINT(1) NOT NULL DEFAULT 1; 

-- 1. Crear la tabla de gravedad de faltas
CREATE TABLE tbl_gravedad_faltas (
    pk_id_gravedad INT NOT NULL AUTO_INCREMENT,
    gravedad VARCHAR(50) NOT NULL UNIQUE,
	estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_gravedad)
);

-- Insertar los niveles de gravedad
INSERT INTO tbl_gravedad_faltas (gravedad) VALUES 
('Leve'),
('Grave'),
('Reincidencia');

-- 2. Crear la tabla de estados de faltas
CREATE TABLE tbl_estados_faltas (
    pk_id_estado INT NOT NULL AUTO_INCREMENT,
    estado_falta VARCHAR(100) NOT NULL UNIQUE,
    estado TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (pk_id_estado)
);

-- Insertar los diferentes estados
INSERT INTO tbl_estados_faltas (estado_falta) VALUES 
('En investigación'),
('Pendiente de revisión'),
('Falta confirmada'),
('Pendiente de sanción'),
('Sancionado'),
('Cerrado');

-- 3. Agregar las foreign keys apuntando a los campos de id
-- Foreign key para falta_gravedad
ALTER TABLE tbl_faltas_disciplinarias
ADD CONSTRAINT fk_id_gravedad
FOREIGN KEY (fk_id_gravedad) REFERENCES tbl_gravedad_faltas (pk_id_gravedad);

-- Foreign key para estado
ALTER TABLE tbl_faltas_disciplinarias
ADD CONSTRAINT fk_id_estado
FOREIGN KEY (fk_id_estado) REFERENCES tbl_estados_faltas (pk_id_estado);

-- Cambios nuevos 04-05-25

-- agregados para tabla sanciones 
ALTER TABLE tbl_sanciones
ADD COLUMN sancion_operador INT NOT NULL,
ADD CONSTRAINT fk_sancion_operador
FOREIGN KEY (sancion_operador) REFERENCES tbl_empleados(pk_clave);

-- insert de puestos dentro de RRHH que pueden aplicar sanciones disciplinarias
    
INSERT INTO tbl_puestos_trabajo (puestos_nombre_puesto, puestos_descripcion)
VALUES 
  ('Jefe de Recursos Humanos', 'Responsable del área de RRHH'),
  ('Analista de Recursos Humanos', 'Analiza y gestiona procesos del personal'),
  ('Coordinador de Talento Humano', 'Gestiona sanciones y desarrollo del personal');   

-- insert de empleados que ocuparan los registros anteriores, el penultimo campo de "fk_id_puestos" depende 
-- del Id en que se se insertaron en la tabla correspondiente, en mi caso pertenecen al fk_id_puestos 4, 5 y 6 respectivamente
-- modificar si es necesario

INSERT INTO tbl_empleados (
    empleados_nombre, empleados_apellido, empleados_fecha_nacimiento, empleados_no_identificacion,
    empleados_codigo_postal, empleados_fecha_alta, empleados_fecha_baja, empleados_causa_baja,
    fk_id_departamento, fk_id_puestos, estado
)
VALUES
('Andrea', 'Martínez', '1985-04-12', 'ID-001-A', '01001', '2020-01-15', NULL, NULL, 2, 4, 1),
('Carlos', 'Reyes', '1990-06-23', 'ID-002-C', '01002', '2019-09-10', NULL, NULL, 2, 5, 1),
('María', 'López', '1988-11-30', 'ID-003-M', '01003', '2021-03-22', NULL, NULL, 2, 5, 1),
('Luis', 'Ortega', '1982-02-17', 'ID-004-L', '01004', '2018-07-05', NULL, NULL, 2, 6, 1),
('Verónica', 'Díaz', '1993-08-09', 'ID-005-V', '01005', '2022-06-01', NULL, NULL, 2, 5, 1);
   
use colchoneria;
select * from tbl_evidencias;
select * from tbl_sanciones;
-- --------------------------------------------------------------------------------

-- -----------------------Marco Monroy -----------------------------
use colchoneria;
-- 1. Tabla de asistencias sin procesar (staging) CORREGIDA
CREATE TABLE IF NOT EXISTS tbl_asistencias_preeliminar (
    pk_id_preeliminar INT NOT NULL AUTO_INCREMENT,
    linea TEXT NOT NULL,
    fecha_import DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    procesada TINYINT(1) DEFAULT 0,  -- 0 = pendiente, 1 = procesada
    PRIMARY KEY (pk_id_preeliminar)
);

-- 2. Tabla de excepciones de séptimo día
CREATE TABLE IF NOT EXISTS tbl_excepcion_septimo (
    pk_id_excepcion INT NOT NULL AUTO_INCREMENT,
    fk_id_empleado INT NOT NULL,
    semana INT NOT NULL,            -- número de semana en el año
    anio INT NOT NULL,              -- año
    exento TINYINT(1) DEFAULT 1,    -- 1 = no descontar séptimo día, 0 = aplicar
    PRIMARY KEY (pk_id_excepcion),
    FOREIGN KEY (fk_id_empleado)
        REFERENCES tbl_empleados(pk_clave)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

SELECT * FROM tbl_asistencias_preeliminar;

-- 3. Modificación de tbl_control_faltas: vincular con excepciones
ALTER TABLE tbl_control_faltas
    ADD COLUMN fk_id_excepcion INT DEFAULT NULL,
    ADD CONSTRAINT fk_control_falta_excepcion
        FOREIGN KEY (fk_id_excepcion)
        REFERENCES tbl_excepcion_septimo(pk_id_excepcion)
        ON UPDATE CASCADE
        ON DELETE SET NULL;

-- 4. Modificación de tbl_permisos: indicar si es con o sin goce de sueldo
ALTER TABLE tbl_permisos
    ADD COLUMN con_goce_sueldo TINYINT(1) NOT NULL DEFAULT 0;  -- 1 = con goce, 0 = sin goce

-- 5. Trigger mínimo para generar falta al insertar una asistencia con estado 'Falta'
DELIMITER $$
CREATE TRIGGER trg_insert_falta
AFTER INSERT ON tbl_asistencias
FOR EACH ROW
BEGIN
    IF NEW.estado_asistencia = 'Falta' THEN
        INSERT INTO tbl_control_faltas (fk_id_empleado, fecha)
        VALUES (NEW.fk_id_empleado, NEW.fecha);
    END IF;
END $$
DELIMITER ;

-- 6. Procedimiento para marcar previa como procesada
DELIMITER $$
CREATE PROCEDURE marcar_asistencia_preeliminar_procesada(IN p_id INT)
BEGIN
    UPDATE tbl_asistencias_preeliminar
    SET procesada = 1
    WHERE pk_id_preeliminar = p_id;
END $$
DELIMITER ;

-- 7. Procedimiento para insertar fila cruda en preliminar (opcional)
DELIMITER $$
CREATE PROCEDURE insertar_asistencia_preeliminar(IN p_linea TEXT)
BEGIN
    INSERT INTO tbl_asistencias_preeliminar (linea)
    VALUES (p_linea);
END $$
DELIMITER ;

-- 8. Procedimiento para justificar faltas
DELIMITER $$
CREATE PROCEDURE justificar_falta(IN p_id_falta INT, IN p_id_permiso INT)
BEGIN
    UPDATE tbl_control_faltas
    SET justificada = 1,
        fk_id_permiso = p_id_permiso
    WHERE pk_id_control_faltas = p_id_falta;
END $$
DELIMITER ;

-- A partir de aqui wtf 13/5/25
CREATE TABLE IF NOT EXISTS tbl_salarios_mensuales (
    pk_id_salario INT NOT NULL AUTO_INCREMENT,
    fk_id_empleado INT NOT NULL,
    mes INT NOT NULL,
    anio INT NOT NULL,
    pago_base DECIMAL(10,2) NOT NULL,
    pago_horas_extra DECIMAL(10,2) NOT NULL,
    deducciones DECIMAL(10,2) NOT NULL,
    salario_total DECIMAL(10,2) NOT NULL,
    fecha_generacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (pk_id_salario),
    FOREIGN KEY (fk_id_empleado) REFERENCES tbl_empleados(pk_clave)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

ALTER TABLE tbl_contratos ADD contratos_jornada_semanal INT NOT NULL DEFAULT 48;

SELECT* FROM tbl_salarios_mensuales;

select* FROM tbl_contratos;

select* FROM tbl_empleados;



-- Jose Daniel Sierra------------

CREATE TABLE tbl_detalle_evaluacion (
    pk_id_detalle INT NOT NULL AUTO_INCREMENT,
    fk_id_evaluacion INT NOT NULL,
    fk_id_competencia INT NOT NULL,
    calificacion DECIMAL(5,2) NOT NULL,
    comentarios TEXT,
    PRIMARY KEY (pk_id_detalle),
    FOREIGN KEY (fk_id_evaluacion) REFERENCES tbl_evaluaciones(pk_id_evaluacion),
    FOREIGN KEY (fk_id_competencia) REFERENCES tbl_competencias(pk_id_competencia)
);

ALTER TABLE tbl_evaluaciones
ADD COLUMN fk_evaluador INT NOT NULL AFTER fk_clave_empleado,
ADD FOREIGN KEY (fk_evaluador) REFERENCES tbl_empleados(pk_clave);


INSERT INTO tbl_competencias (nombre_competencia, descripcion)
VALUES
('Liderazgo', 'Capacidad de guiar a un equipo hacia el logro de objetivos'),
('Trabajo en equipo', 'Capacidad para colaborar y trabajar con otros de manera efectiva'),
('Comunicación', 'Habilidad para expresar ideas claramente y escuchar a otros'),
('Resolución de problemas', 'Capacidad para analizar y encontrar soluciones a los problemas'),
('Innovación y creatividad', 'Habilidad para generar ideas nuevas y creativas'),
('Gestión de tiempo', 'Capacidad para gestionar el tiempo de manera efectiva'),
('Adaptabilidad', 'Habilidad para adaptarse a cambios en el entorno'),
('Productividad', 'Capacidad para completar tareas de manera eficiente'),
('Orientación al cliente', 'Habilidad para atender y satisfacer las necesidades del cliente'),
('Responsabilidad', 'Compromiso con las tareas y responsabilidades asignadas');

select * from tbl_competencias;

-- Ismar Cortez Alter
ALTER TABLE tbl_puestos_trabajo
ADD puestos_salario_rec DECIMAL(10,2);

-- ----------------------

CREATE TABLE tbl_parametros (
    Pk_id_parametro INT AUTO_INCREMENT PRIMARY KEY,
    LimiteVerde DECIMAL(5,2),
    LimiteAmarillo DECIMAL(5,2)
);

INSERT INTO tbl_parametros (LimiteVerde, LimiteAmarillo)
VALUES (80.00, 40.00);

 SELECT e.pk_id_evaluacion, e.tipo_evaluacion, e.calificacion AS calificacion_general, e.comentarios AS comentario_general, 
        d.calificacion AS calificacion_detalle, c.nombre_competencia, d.comentarios AS comentario_detalle
 FROM tbl_evaluaciones e
 INNER JOIN tbl_detalle_evaluacion d ON e.pk_id_evaluacion = d.fk_id_evaluacion
 INNER JOIN tbl_competencias c ON d.fk_id_competencia = c.Pk_id_competencia
 WHERE e.fk_clave_empleado = 2;
 
 select* from tbl_evaluaciones;
 
 -- Jose Daniel Sierra -------------------
 -- 17/5/25
 -- 1. Eliminar la clave foránea actual (nombre exacto puede variar)
ALTER TABLE tbl_bonos_promociones
DROP FOREIGN KEY tbl_bonos_promociones_ibfk_1;

-- 2. Eliminar la columna fk_id_resultado
ALTER TABLE tbl_bonos_promociones
DROP COLUMN fk_id_resultado;

-- 3. Agregar columna fk_id_evaluacion
ALTER TABLE tbl_bonos_promociones
ADD COLUMN fk_id_evaluacion INT NOT NULL AFTER pk_id_bono_promocion;

-- 4. Agregar columna fk_clave_empleado
ALTER TABLE tbl_bonos_promociones
ADD COLUMN fk_clave_empleado INT NOT NULL AFTER fk_id_evaluacion;

-- 5. Crear clave foránea hacia tbl_evaluaciones
ALTER TABLE tbl_bonos_promociones
ADD CONSTRAINT fk_bono_evaluacion
FOREIGN KEY (fk_id_evaluacion) REFERENCES tbl_evaluaciones(pk_id_evaluacion)
ON DELETE CASCADE;

-- 6. Crear clave foránea hacia tbl_empleados (con columna pk_clave)
ALTER TABLE tbl_bonos_promociones
ADD CONSTRAINT fk_bono_empleado
FOREIGN KEY (fk_clave_empleado) REFERENCES tbl_empleados(pk_clave)
ON DELETE CASCADE;
