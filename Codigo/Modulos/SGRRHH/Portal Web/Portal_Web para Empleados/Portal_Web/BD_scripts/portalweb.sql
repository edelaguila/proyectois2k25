CREATE DATABASE portalEmpleados;
USE portalEmpleados;

CREATE TABLE Users (
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    UserName VARCHAR(255) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    RoleId INT,
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
CREATE TABLE Roles (
    RoleId INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(255) NOT NULL
);
INSERT INTO Roles (RoleName) VALUES ('Admin');
INSERT INTO Roles (RoleName) VALUES ('User');

-- Insertar un usuario de prueba
INSERT INTO Users (UserName, PasswordHash, Email, RoleId) 
VALUES ('admin', 'admin123', 'admin@empresa.com', 1);

SELECT * FROM Users;
SELECT * FROM Roles;