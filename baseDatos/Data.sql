-- Insertar en Programa
INSERT INTO Programas VALUES (101, 'Análisis de Datos', '2024-01-15', 24, 'Tecnólogo');
INSERT INTO Programas VALUES (102, 'Desarrollo de Software', '2024-02-01', 18, 'Técnico');
INSERT INTO Programas VALUES (103, 'Ciberseguridad', '2024-03-10', 12, 'Especialización');

-- Insertar en Administrador
INSERT INTO Usuario VALUES (101, 'Carlos Ruiz', 'carlosruiz@gmail.com', 'Admin12*', 'Administrador');
INSERT INTO Usuario VALUES (102, 'Ana Martínez', 'anamartines@gmail.com', 'Pass789#', 'Administrador');
INSERT INTO Usuario VALUES (103, 'Luis Peña', 'luispeña@gmail.com', 'Sena2024', 'Administrador');


-- Insertar en Ficha (Depende de Programa)
INSERT INTO Fichas VALUES (26701, '2024-01-20', '2026-01-20', 101);
INSERT INTO Fichas VALUES (26702, '2024-02-05', '2025-08-05', 102);
INSERT INTO Fichas VALUES (26703, '2024-03-15', '2025-03-15', 103);

-- Inserciones de ejemplo (ajusta ids si ya existen)
INSERT INTO Eventos (idEvento, nombreEvento, tipoEvento, fechaHoraInicio, fechaHoraFin, idUser)
VALUES
(501, 'Conferencia Tech', 'Educativo', '2024-05-10 09:00:00', '2024-05-11 10:00:00', 101),
(502, 'Hackathon SENA',   'Cultural', '2024-06-15 08:00:00', '2024-06-15 20:00:00', 102),
(503, 'Feria de Empleo',  'Deportivo',     '2024-07-20 10:00:00', '2024-07-20 13:00:00', 103);

-- Aprendices
INSERT INTO Aprendiz VALUES 
(1, 'Carlos Ramirez', 20, 'carlosr@gmail.com', 3001234567, 'Carlos Ramirez', 'carlosr@gmail.com', 'pass123', 'Aprendiz', 'M', 26701), 
(2, 'Laura Gomez', 22, 'laurag@gmail.com', 3019876543, 'Laura Gomez', 'laurag@gmail.com', 'clave456', 'Aprendiz', 'F', 26702), 
(3, 'Andres Torres', 19, 'andrest@gmail.com', 3024567890, 'Andres Torres', 'andrest@gmail.com', 'abc789', 'Aprendiz', 'M', 26703),
(4, 'Sofia Martinez', 21, 'sofijd@gmail.com', 3031234567, 'Sofia Martinez', 'sofijd@gmail.com', 'xyz123', 'Aprendiz', 'F', 26701),
(5, 'Diego Fernandez', 23, 'diegdx@outlook.com', 3049876543, 'Diego Fernandez', 'diegdx@outlook.com', 'pass789', 'Aprendiz', 'M', 26702),
(6, 'Valentina Lopez', 20, 'vale2d9@outlook.com', 3054567890, 'Valentina Lopez', 'vale2d9@outlook.com', 'clave321', 'Aprendiz', 'F', 26703);

-- Hacer idGrupo opcional en Inscripciones (no elimina FK, solo permite NULL)
-- Ejecutar en entorno de pruebas antes de producción.

ALTER TABLE Inscripciones
ALTER COLUMN idGrupo INT NULL;

UPDATE Inscripciones
SET idGrupo = NULL;

DELETE FROM Grupos; 

SELECT * FROM Inscripciones;

SELECT * FROM Grupos;

-- Consultas de verificacion para comprobar que idGrupo es opcional y se pueden eliminar grupos sin afectar inscripciones.
SELECT TOP 20 idInscrip, idApr, idEvento, idGrupo, fechaInscrip
FROM Inscripciones
ORDER BY idInscrip DESC;

SELECT idApr, idEvento, COUNT(*) AS cantidad
FROM Inscripciones
GROUP BY idApr, idEvento
HAVING COUNT(*) > 1;

SELECT i.idApr, i.idEvento, e.nombreEvento, e.fechaHoraInicio, e.fechaHoraFin, i.idGrupo
FROM Inscripciones i
JOIN Eventos e ON i.idEvento = e.idEvento
WHERE i.idApr = 1
ORDER BY e.fechaHoraInicio;

SELECT *
FROM Inscripciones
WHERE idGrupo IS NOT NULL;

select * from Eventos

select * from Aprendiz




