-- Insertar en Programa
INSERT INTO Programas VALUES (101, 'Análisis de Datos', '2024-01-15', 24, 'Tecnólogo');
INSERT INTO Programas VALUES (102, 'Desarrollo de Software', '2024-02-01', 18, 'Técnico');
INSERT INTO Programas VALUES (103, 'Ciberseguridad', '2024-03-10', 12, 'Especialización');

-- Insertar en Administrador
INSERT INTO Usuario VALUES (1, 'Carlos Ruiz', 'carlosruiz@gmail.com', 'Admin12*', 'Administrador');
INSERT INTO Usuario VALUES (2, 'Ana Martínez', 'anamartines@gmail.com', 'Pass789#', 'Administrador');
INSERT INTO Usuario VALUES (3, 'Luis Peña', 'luispeña@gmail.com', 'Sena2024', 'Administrador');


-- Insertar en Ficha (Depende de Programa)
INSERT INTO Fichas VALUES (26701, '2024-01-20', '2026-01-20', 101);
INSERT INTO Fichas VALUES (26702, '2024-02-05', '2025-08-05', 102);
INSERT INTO Fichas VALUES (26703, '2024-03-15', '2025-03-15', 103);

-- Insertar en Evento (Depende de Administrador)
INSERT INTO Eventos (idEvento, nombreEvento, tipoEvento, fechaEvento, horaEvento, idUser)
VALUES (501, 'Conferencia Tech', 'Educativo', '2024-05-10', '09:00:00', 1),
       (502, 'Hackathon SENA', 'Competencia', '2024-06-15', '08:00:00', 2),
       (503, 'Feria de Empleo', 'Laboral', '2024-07-20', '10:00:00', 1);

-- Aprendices
INSERT INTO Aprendiz VALUES 
(1, 'Carlos Ramirez', 20, 'carlosr@gmail.com', 3001234567, 'Carlos Ramirez', 'carlosr@gmail.com', 'pass123', 'Aprendiz', 'M', 26701), 
(2, 'Laura Gomez', 22, 'laurag@gmail.com', 3019876543, 'Laura Gomez', 'laurag@gmail.com', 'clave456', 'Aprendiz', 'F', 26702), 
(3, 'Andres Torres', 19, 'andrest@gmail.com', 3024567890, 'Andres Torres', 'andrest@gmail.com', 'abc789', 'Aprendiz', 'M', 26703);
       
-- Insertar en Grupos 
INSERT INTO Grupos VALUES
(1, 'Grupo 1'),
(2, 'Grupo 2'),
(3, 'Grupo 3')

-- Insertar en Inscripcion (Depende de Aprendiz y Evento)
INSERT INTO Inscripciones VALUES (9001, '2024-04-01', 'Presencial', 1, 501, 1);
INSERT INTO Inscripciones VALUES (9002, '2024-04-02', 'Virtual', 2, 501, 2);
INSERT INTO Inscripciones VALUES (9003, '2024-04-05', 'Presencial', 3, 502, 3)