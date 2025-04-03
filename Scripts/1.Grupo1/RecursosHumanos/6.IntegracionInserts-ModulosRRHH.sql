use colchoneria;

-- ---------------------Desarrollo de carrera - Inserts Ismar Cortez............................
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(12000, 'DESARROLLO DE CARRERA', 'Desarrollo de carrera', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(12001, 'Promociones', 'PARA DESARROLLO DE CARRERA', 1),
(12002, 'Carrera', 'PARA DESARROLLO DE CARRERA', 1);

-- ----------------------------------------------------------------------------------

-- -----------Reclutamiento y selección - Inserts Brandon Boch----------------------------------------------------
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(13000, 'Reclutamiento y Selección', 'Control de proceso de reclutamiento y selección', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(13001, 'Mant. de Postulante', 'Registro de los postulantes a los distintos puestos', 1),
(13002, 'Registro de Perfil', 'Registro del perfil que debe tener un postulante', 1),
(13003, 'Registro de Competencias', 'Compentencias que serviran para capacitar a todo un depto.', 1),
(13004, 'Mant. ControlATS', 'Control del proceso del postulante', 1),
(13005, 'Registro de Expedientes', 'Llevará el expediente de los postulantes', 1);

-- --------------------------------------------------------------------------------------


-- -------------------Capacitacion y desarrollo - Inserts Joel Lopez ---------------------------------------
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(14000, 'CAPACITACION', 'Capacitación y Desarrollo', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(14001, 'Mant. Capacitaciones', 'PARA CAPACITACION', 1),
(14002, 'Mant. Instructores', 'PARA CAPACITACION', 1),
(14003, 'Cierre Capacitacion', 'PARA CAPACITACION', 1),
(14004, 'Notas Capacitacion', 'PARA CAPACITACION', 1);

-- ----------------------------------------------------------------------------
-- ------------------Gestion Disciplinaria - Inserts Kevin ------------------------------------------------
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(15000, 'Gestion Disciplinaria', 'Registro de Faltas y Sanciones', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(15001, 'Mant. Faltas Disciplinarias', 'REGISTRO FALTAS Y SANCIONES DISCIPLINARIAS', 1),
(15002, 'Registro de evidencia', 'Registrar evidencias', 1),
(15003, 'Registro de Sancion', 'Validacion de sancion', 1);

-- -----------------------------------------------------------------------------------
-- ------------------Faltas y asistencia - Inserts Marco Monroy---------------------------------------------
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(16000, 'ASISTENCIA', 'Asistencia y Faltas', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(16001, 'Mant. Permisos', 'PARA PERMISOS', 1),
(16002, 'Registro de Asitencia', 'PARA ASISTENCIA', 1);
-- -----------------------------------------------------------------------------------

-- -----------Evaluación de desempeño - Inserts Jose Daniel----------------------------------------------------
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(17000, 'EVALUACION', 'Evaluación y Desempeño', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(17001, 'Mant. Resultado de Evaluaciones', 'PARA EVALUACION DE DESEMPEÑO', 1),
(17002, 'Mant. Bonos y Promociones', 'PARA EVALUACION DE DESEMPEÑO', 1),
(17003, 'Evaluación', 'PARA EVALUACION DE DESEMPEÑO', 1),
(17004, 'Reporte de Evaluación', 'PARA EVALUACION DE DESEMPEÑO', 1);

-- --------------------------------------------------------------------------------------

INSERT INTO `Tbl_asignacion_modulo_aplicacion` VALUES
(12000, 12001),
(12000, 12002),

(13000, 13001),
(13000, 13002),
(13000, 13003),
(13000, 13004),
(13000, 13005),

(14000, 14001),
(14000, 14002),
(14000, 14003),
(14000, 14004),

(15000, 15001),
(15000, 15002),
(15000, 15003),

(16000, 16001),
(16000, 16002),

(17000, 17001),
(17000, 17002),
(17000, 17003),
(17000, 17004);



INSERT INTO `Tbl_permisos_aplicacion_perfil` 
(Fk_id_perfil, Fk_id_aplicacion, guardar_permiso, modificar_permiso, eliminar_permiso, buscar_permiso, imprimir_permiso) 
VALUES 
(1, 12001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 12002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 13001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 13002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 13003, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 13004, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 13005, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 14001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 14002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 14003, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 14004, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 15001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 15002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 15003, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 16001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 16002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 17001, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 17002, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 17003, TRUE, TRUE, TRUE, TRUE, TRUE),
(1, 17004, TRUE, TRUE, TRUE, TRUE, TRUE);

