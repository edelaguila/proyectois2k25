/*Tablas para portal web*/
CREATE TABLE IF NOT EXISTS tbl_asistencias (
    pk_id_asistencia INT NOT NULL AUTO_INCREMENT,
    fecha DATE NOT NULL,
    hora_entrada TIME NULL,
    hora_salida TIME NULL,
    estado_asistencia VARCHAR(255) NOT NULL,
    observaciones TEXT,
    fk_clave_empleado INT NOT NULL,
    PRIMARY KEY (pk_id_asistencia),
    FOREIGN KEY (fk_clave_empleado)
        REFERENCES tbl_empleados(pk_clave)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
