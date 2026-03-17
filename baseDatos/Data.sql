-- Insertar en Programa
INSERT INTO Programa VALUES (101, 'Análisis de Datos', '2024-01-15', 24, 'Tecnólogo');
INSERT INTO Programa VALUES (102, 'Desarrollo de Software', '2024-02-01', 18, 'Técnico');
INSERT INTO Programa VALUES (103, 'Ciberseguridad', '2024-03-10', 12, 'Especialización');

-- Insertar en Administrador
INSERT INTO Administrador VALUES (1, 'Carlos Ruiz', 'Admin123*');
INSERT INTO Administrador VALUES (2, 'Ana Martínez', 'Pass789#');
INSERT INTO Administrador VALUES (3, 'Luis Peña', 'Sena2024!');


-- Insertar en Ficha (Depende de Programa)
INSERT INTO Ficha VALUES (26701, '2024-01-20', '2026-01-20', 101);
INSERT INTO Ficha VALUES (26702, '2024-02-05', '2025-08-05', 102);
INSERT INTO Ficha VALUES (26703, '2024-03-15', '2025-03-15', 103);

-- Insertar en Evento (Depende de Administrador)
INSERT INTO Evento VALUES (501, 'Conferencia Tech', 'Educativo', '2024-05-10', '09:00:00', 1);
INSERT INTO Evento VALUES (502, 'Hackathon SENA', 'Competencia', '2024-06-15', '08:00:00', 2);
INSERT INTO Evento VALUES (503, 'Feria de Empleo', 'Laboral', '2024-07-20', '10:00:00', 1);

-- Insertar en Aprendiz (Depende de Ficha)
INSERT INTO Aprendiz VALUES (1001, 'Juan Perez', 20, 'M', 'juan@mail.com', 3101234567, 'Juan123', 26701);
INSERT INTO Aprendiz VALUES (1002, 'Maria Lopez', 22, 'F', 'maria@mail.com', 3209876543, 'Maria456', 26702);
INSERT INTO Aprendiz VALUES (1003, 'Pedro Gomez', 19, 'M', 'pedro@mail.com', 3154443322, 'Pedro789', 26703);

-- Insertar en Inscripcion (Depende de Aprendiz y Evento)
INSERT INTO Inscripcion VALUES (9001, '2024-04-01', 'Presencial', 1001, 501);
INSERT INTO Inscripcion VALUES (9002, '2024-04-02', 'Virtual', 1002, 501);
INSERT INTO Inscripcion VALUES (9003, '2024-04-05', 'Presencial', 1003, 502);
