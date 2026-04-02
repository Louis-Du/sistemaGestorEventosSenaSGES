

-- Programas
INSERT INTO Programas (codigoProg, nombreProg, fechaIniProg, duracionProg, nivelProg)
VALUES (101, 'Análisis de Datos', '2024-01-15', 24, 'Tecnólogo'),
       (102, 'Desarrollo de Software', '2024-02-01', 18, 'Técnico'),
       (103, 'Ciberseguridad', '2024-03-10', 12, 'Especialización');

-- Usuarios (admins)
INSERT INTO Usuario (idUser, nombreUser, contraseñaUser, tipoUser)
VALUES (1, 'Carlos Ruiz', 'Admin12*', 'Administrador'),
       (2, 'Ana Martínez', 'Pass789#', 'Administrador'),
       (3, 'Luis Peña', 'Sena2024', 'Administrador');

-- Grupos
INSERT INTO Grupos (idGrupo, nombreGrupo)
VALUES (1, 'Grupo 1'), (2, 'Grupo 2'), (3, 'Grupo 3');

-- Fichas
INSERT INTO Fichas (codigoFic, fechaIniFic, fechaFinFic, codigoProg)
VALUES (26701, '2024-01-20', '2026-01-20', 101),
       (26702, '2024-02-05', '2025-08-05', 102),
       (26703, '2024-03-15', '2025-03-15', 103);

-- Aprendices
INSERT INTO Aprendiz (idApr, nombreApr, edadApr, emailApr, contactoApr, nomberUser, contraseñaUser, tipoUser, generoApr, codigoFic)
VALUES (1, 'Carlos Ramirez', 20, 'carlosr@gmail.com', 3001234567, 'Carlos Ramirez', 'pass123', 'Aprendiz', 'M', 26701),
       (2, 'Laura Gomez', 22, 'laurag@gmail.com', 3019876543, 'Laura Gomez', 'clave456', 'Aprendiz', 'F', 26702),
       (3, 'Andres Torres', 19, 'andrest@gmail.com', 3024567890, 'Andres Torres', 'abc789', 'Aprendiz', 'M', 26703);

-- Eventos (IDs manuales; duracionMinutos usa DEFAULT = 60 si no se pasa)
INSERT INTO Eventos (idEvento, nombreEvento, tipoEvento, fechaEvento, horaEvento, idUser)
VALUES (501, 'Conferencia Tech', 'Educativo', '2024-05-10', '09:00:00', 1),
       (502, 'Hackathon SENA', 'Competencia', '2024-06-15', '08:00:00', 2),
       (503, 'Feria de Empleo', 'Laboral', '2024-07-20', '10:00:00', 1);

-- Inscripciones (IDs manuales)
INSERT INTO Inscripciones (idInscrip, fechaInscrip, modalidadInscrip, idApr, idEvento, idGrupo)
VALUES (9001, '2024-04-01', 'Presencial', 1, 501, 1),
       (9002, '2024-04-02', 'Virtual', 2, 501, 2),
       (9003, '2024-04-05', 'Presencial', 3, 502, 3);


