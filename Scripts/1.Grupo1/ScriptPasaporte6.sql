DROP DATABASE IF exists sistemapasaportes;
CREATE DATABASE sistemapasaportes;
USE sistemapasaportes;

-- Tabla Nacionalidad
CREATE TABLE IF NOT EXISTS Tbl_nacionalidad (
  Pk_id_nacionalidad INT AUTO_INCREMENT NOT NULL,
  nombre_nacionalidad VARCHAR(50) NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_nacionalidad)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Usuario
CREATE TABLE IF NOT EXISTS Tbl_usuario (
  Pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  fecha_nacimiento_usuario DATE NOT NULL,
  genero_usuario VARCHAR(50) NOT NULL,
  DPI_usuario VARCHAR(13),
  BoletoOrnato_usuario VARCHAR(12),
  Fk_id_nacionalidad INT NOT NULL,
  direccion_usuario TEXT NOT NULL,
  telefono_usuario VARCHAR(15) NOT NULL,
  correo_usuario VARCHAR(100) UNIQUE,
 --  Fk_id_tutor INT NULL,  -- Tutor legal para menores
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_usuario),
  FOREIGN KEY (Fk_id_nacionalidad) REFERENCES Tbl_nacionalidad(Pk_id_nacionalidad)
 -- FOREIGN KEY (Fk_id_tutor) REFERENCES Tbl_usuario(Pk_id_usuario)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS Tbl_usuario_menor (
  Pk_id_usuario_menor INT AUTO_INCREMENT NOT NULL,
  nombre_usuario_menor VARCHAR(50) NOT NULL,
  apellido_usuario_menor VARCHAR(50) NOT NULL,
  fecha_nacimiento_usuario_menor DATE NOT NULL,
  genero_usuario_menor VARCHAR(50) NOT NULL,
  acta_nacimiento_usuario_menor VARCHAR(50) NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_usuario_menor)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


CREATE TABLE IF NOT EXISTS Tbl_tutor_menor (
  Pk_id_tutor_menor INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario_menor INT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_tutor_menor ),
  FOREIGN KEY (Fk_id_usuario_menor) REFERENCES Tbl_usuario_menor(Pk_id_usuario_menor),
  FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuario(Pk_id_usuario)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;



-- Tabla Oficina
CREATE TABLE IF NOT EXISTS Tbl_oficina (
  Pk_id_oficina INT AUTO_INCREMENT NOT NULL,
  nombre_oficina VARCHAR(100) NOT NULL,
  direccion_oficina TEXT NOT NULL,
  telefono_oficina VARCHAR(15) NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_oficina)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Empleado
CREATE TABLE IF NOT EXISTS Tbl_empleado (
  Pk_id_empleado INT AUTO_INCREMENT NOT NULL,
  nombre_empleado VARCHAR(50) NOT NULL,
  apellido_empleado VARCHAR(50) NOT NULL,
  cargo_empleado VARCHAR(50) NOT NULL,
  Fk_id_oficina INT NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_empleado),
  FOREIGN KEY (Fk_id_oficina) REFERENCES Tbl_oficina(Pk_id_oficina)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Estado de Solicitud
-- CREATE TABLE IF NOT EXISTS Tbl_estado_solicitud (
--   Pk_id_estado_solicitud INT AUTO_INCREMENT NOT NULL,
--   estado_solicitud VARCHAR(50) NOT NULL,
--   estado TINYINT(1) NOT NULL DEFAULT 1,
--   PRIMARY KEY (Pk_id_estado_solicitud)
-- ) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Estado de Pasaporte
-- CREATE TABLE IF NOT EXISTS Tbl_estado_pasaporte (
--   Pk_id_estado_pasaporte INT AUTO_INCREMENT NOT NULL,
--   estado_pasaporte VARCHAR(50) NOT NULL,
--   estado TINYINT(1) NOT NULL DEFAULT 1,
--   PRIMARY KEY (Pk_id_estado_pasaporte)
-- ) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Cita
CREATE TABLE IF NOT EXISTS Tbl_cita (
  Pk_id_cita INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  fecha_cita DATETIME NOT NULL,
  Fk_id_oficina INT NOT NULL,
  Fk_id_empleado INT NOT NULL,
  Fk_id_estado_solicitud INT NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_cita),
  FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuario(Pk_id_usuario),
  FOREIGN KEY (Fk_id_oficina) REFERENCES Tbl_oficina(Pk_id_oficina),
  FOREIGN KEY (Fk_id_empleado) REFERENCES Tbl_empleado(Pk_id_empleado)
  -- FOREIGN KEY (Fk_id_estado_solicitud) REFERENCES Tbl_estado_solicitud(Pk_id_estado_solicitud)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS Tbl_cita_menor (
  Pk_id_cita_menor INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario_menor INT NOT NULL,
  Fk_id_cita INT NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_cita_menor),
  FOREIGN KEY (Fk_id_usuario_menor) REFERENCES Tbl_usuario_menor(Pk_id_usuario_menor),
  FOREIGN KEY (Fk_id_cita) REFERENCES Tbl_cita(Pk_id_cita)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Pago
CREATE TABLE IF NOT EXISTS Tbl_pago (
  Pk_id_pago INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  Fk_id_cita INT NOT NULL,
  monto_pago DECIMAL(10,2) NOT NULL,
  metodo_pago ENUM('Tarjeta', 'Efectivo', 'Transferencia') NOT NULL,
  fecha_pago DATETIME NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_pago),
  FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuario(Pk_id_usuario),
  FOREIGN KEY (Fk_id_cita) REFERENCES Tbl_cita(Pk_id_cita)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Pasaporte
CREATE TABLE IF NOT EXISTS Tbl_pasaporte (
  Pk_id_pasaporte INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  numero_pasaporte VARCHAR(15) UNIQUE NOT NULL,
  fecha_emision_pasaporte DATE NOT NULL,
  fecha_expiracion_pasaporte DATE NOT NULL,
  Fk_id_estado_pasaporte INT NOT NULL,
  Fk_id_usuario_menor INT NOT NULL,
  estado TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (Pk_id_pasaporte),
  FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuario(Pk_id_usuario),
  FOREIGN KEY (Fk_id_usuario_menor) REFERENCES Tbl_usuario_menor(Pk_id_usuario_menor)
  -- FOREIGN KEY (Fk_id_estado_pasaporte) REFERENCES Tbl_estado_pasaporte(Pk_id_estado_pasaporte)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Tabla Información Judicial
-- CREATE TABLE IF NOT EXISTS Tbl_informacion_judicial (
--   Pk_id_informacion_judicial INT AUTO_INCREMENT NOT NULL,
--   Fk_id_usuario INT NOT NULL,
--   descripcion_informacion_judicial TEXT NOT NULL,
--   fecha_registro_informacion_judicial DATE NOT NULL,
--   estado TINYINT(1) NOT NULL DEFAULT 1,
--   PRIMARY KEY (Pk_id_informacion_judicial),
--   FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuario(Pk_id_usuario)
-- ) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- /////////////////////////////////////Ingresos///////////////////////////////////////////
-- Poblar la tabla Tbl_nacionalidad
INSERT INTO Tbl_nacionalidad (nombre_nacionalidad) VALUES
('Guatemalteca'),
('Mexicana'),
('Salvadoreña');

-- Poblar la tabla Tbl_usuario
INSERT INTO Tbl_usuario (nombre_usuario, apellido_usuario, fecha_nacimiento_usuario, genero_usuario, DPI_usuario, BoletoOrnato_usuario, Fk_id_nacionalidad, direccion_usuario, telefono_usuario, correo_usuario) VALUES
('Juan', 'Perez', '1985-04-23', 'Masculino', '1234567890123', 'BO123456', 1, 'Zona 1, Ciudad', '55551234', 'juan.perez@email.com'),
('Maria', 'Lopez', '1992-07-15', 'Femenino', '9876543210987', 'BO987654', 1, 'Zona 5, Ciudad', '55559876', 'maria.lopez@email.com');

-- Poblar la tabla Tbl_usuario_menor
INSERT INTO Tbl_usuario_menor (nombre_usuario_menor, apellido_usuario_menor, fecha_nacimiento_usuario_menor, genero_usuario_menor, acta_nacimiento_usuario_menor) VALUES
('Carlos', 'Perez', '2015-09-12', 'Masculino', 'ACTA001'),
('Sofia', 'Lopez', '2018-02-25', 'Femenino', 'ACTA002');

-- Poblar la tabla Tbl_tutor_menor
INSERT INTO Tbl_tutor_menor (Fk_id_usuario_menor, Fk_id_usuario) VALUES
(1, 1),
(2, 2);

-- Poblar la tabla Tbl_oficina
INSERT INTO Tbl_oficina (nombre_oficina, direccion_oficina, telefono_oficina) VALUES
('Oficina Central', 'Zona 1, Ciudad', '55550001'),
('Sucursal Norte', 'Zona 17, Ciudad', '55550002');

-- Poblar la tabla Tbl_empleado
INSERT INTO Tbl_empleado (nombre_empleado, apellido_empleado, cargo_empleado, Fk_id_oficina) VALUES
('Luis', 'Gomez', 'Atencion', 1),
('Ana', 'Martinez', 'Supervisor', 2);

-- Poblar la tabla Tbl_cita
INSERT INTO Tbl_cita (Fk_id_usuario, fecha_cita, Fk_id_oficina, Fk_id_empleado, Fk_id_estado_solicitud) VALUES
(1, '2024-03-01 09:00:00', 1, 1, 1),
(2, '2024-03-02 10:30:00', 2, 2, 1);

-- Poblar la tabla Tbl_cita_menor
INSERT INTO Tbl_cita_menor (Fk_id_usuario_menor, Fk_id_cita) VALUES
(1, 1),
(2, 2);

-- Poblar la tabla Tbl_pago
INSERT INTO Tbl_pago (Fk_id_usuario, Fk_id_cita, monto_pago, metodo_pago, fecha_pago) VALUES
(1, 1, 250.00, 'Tarjeta', '2024-02-15 14:30:00'),
(2, 2, 250.00, 'Efectivo', '2024-02-16 11:00:00');

-- Poblar la tabla Tbl_pasaporte
INSERT INTO Tbl_pasaporte (Fk_id_usuario, numero_pasaporte, fecha_emision_pasaporte, fecha_expiracion_pasaporte, Fk_id_estado_pasaporte, Fk_id_usuario_menor) VALUES
(1, 'P001234567', '2024-03-05', '2034-03-05', 1, 1),
(2, 'P009876543', '2024-03-06', '2034-03-06', 1, 2);


-- ////////////////////////////////////////////////////////////////////////////////////////
-- ///////////////////////////////////////Consultas////////////////////////////////////////

-- Contar pasaportes de usuarios adultos por oficina
SELECT o.nombre_oficina, COUNT(p.Pk_id_pasaporte) AS total_pasaportes
FROM Tbl_pasaporte p
JOIN Tbl_usuario u ON p.Fk_id_usuario = u.Pk_id_usuario
JOIN Tbl_cita c ON u.Pk_id_usuario = c.Fk_id_usuario
JOIN Tbl_oficina o ON c.Fk_id_oficina = o.Pk_id_oficina
WHERE o.Pk_id_oficina IN (1, 2, 3) -- Aquí puedes especificar las oficinas que deseas consultar
GROUP BY o.nombre_oficina;

-- Contar pasaportes de menores por oficina
SELECT o.nombre_oficina, COUNT(p.Pk_id_pasaporte) AS total_pasaportes
FROM Tbl_pasaporte p
JOIN Tbl_usuario_menor um ON p.Fk_id_usuario_menor = um.Pk_id_usuario_menor
JOIN Tbl_cita_menor cm ON um.Pk_id_usuario_menor = cm.Fk_id_usuario_menor
JOIN Tbl_cita c ON cm.Fk_id_cita = c.Pk_id_cita
JOIN Tbl_oficina o ON c.Fk_id_oficina = o.Pk_id_oficina
WHERE o.Pk_id_oficina IN (1, 2, 3) -- Aquí puedes especificar las oficinas que deseas consultar
GROUP BY o.nombre_oficina;

-- Combinado
SELECT o.nombre_oficina, COUNT(p.Pk_id_pasaporte) AS total_pasaportes
FROM Tbl_pasaporte p
LEFT JOIN Tbl_usuario u ON p.Fk_id_usuario = u.Pk_id_usuario
LEFT JOIN Tbl_cita c ON u.Pk_id_usuario = c.Fk_id_usuario
LEFT JOIN Tbl_usuario_menor um ON p.Fk_id_usuario_menor = um.Pk_id_usuario_menor
LEFT JOIN Tbl_cita_menor cm ON um.Pk_id_usuario_menor = cm.Fk_id_usuario_menor
LEFT JOIN Tbl_cita c2 ON cm.Fk_id_cita = c2.Pk_id_cita
LEFT JOIN Tbl_oficina o ON (c.Fk_id_oficina = o.Pk_id_oficina OR c2.Fk_id_oficina = o.Pk_id_oficina)
WHERE o.Pk_id_oficina IN (1, 2, 3)
GROUP BY o.nombre_oficina;

-- Agregar fotografia BLOB
-- Agregar huella BLOB
-- Fecha
-- Hora 
-- Sede

