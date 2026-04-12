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
INSERT INTO Eventos (nombreEvento, tipoEvento, categoriaEvento, cantIntegrantes, fechaHoraInicio, fechaHoraFin, idUser) VALUES 
('Conferencia Tech', 'Educativo', 'Grupal', '3', '2026-05-10 09:00:00', '2026-05-11 10:00:00', 101),
('Hackathon SENA',   'Cultural', 'Individual', null, '2026-07-15 08:00:00', '2026-07-16 20:00:00', 102),
('Feria de Empleo',  'Deportivo', 'Individual', null, '2026-07-20 10:00:00', '2026-07-23 13:00:00', 103);

-- Aprendices
INSERT INTO Aprendiz VALUES 
(1, 'Carlos Ramirez', 20, 'carlosr@gmail.com', 3001234567, 'Carlos Ramirez', 'carlosr@gmail.com', 'pass123', 'Aprendiz', 'M', 26701), 
(2, 'Laura Gomez', 22, 'laurag@gmail.com', 3019876543, 'Laura Gomez', 'laurag@gmail.com', 'clave456', 'Aprendiz', 'F', 26702), 
(3, 'Andres Torres', 19, 'andrest@gmail.com', 3024567890, 'Andres Torres', 'andrest@gmail.com', 'abc789', 'Aprendiz', 'M', 26703),
(4, 'Sofia Martinez', 21, 'sofijd@gmail.com', 3031234567, 'Sofia Martinez', 'sofijd@gmail.com', 'xyz123', 'Aprendiz', 'F', 26701),
(5, 'Diego Fernandez', 23, 'diegdx@outlook.com', 3049876543, 'Diego Fernandez', 'diegdx@outlook.com', 'pass789', 'Aprendiz', 'M', 26702),
(6, 'Valentina Lopez', 20, 'vale2d9@outlook.com', 3054567890, 'Valentina Lopez', 'vale2d9@outlook.com', 'clave321', 'Aprendiz', 'F', 26703);

