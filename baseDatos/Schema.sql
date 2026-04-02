CREATE DATABASE SGES
go

-- Script de creación de tablas y datos de ejemplo (IDs manuales).

-- Eliminar tablas si existen para evitar errores al crear.
IF OBJECT_ID('dbo.Inscripciones', 'U') IS NOT NULL DROP TABLE dbo.Inscripciones;
IF OBJECT_ID('dbo.Aprendiz', 'U') IS NOT NULL DROP TABLE dbo.Aprendiz;
IF OBJECT_ID('dbo.Eventos', 'U') IS NOT NULL DROP TABLE dbo.Eventos;
IF OBJECT_ID('dbo.Fichas', 'U') IS NOT NULL DROP TABLE dbo.Fichas;
IF OBJECT_ID('dbo.Grupos', 'U') IS NOT NULL DROP TABLE dbo.Grupos;
IF OBJECT_ID('dbo.Programas', 'U') IS NOT NULL DROP TABLE dbo.Programas;
IF OBJECT_ID('dbo.Usuario', 'U') IS NOT NULL DROP TABLE dbo.Usuario;

-- Usuario (administradores)
CREATE TABLE Usuario(
	idUser int NOT NULL PRIMARY KEY,
	nombreUser varchar(50) NOT NULL,
	contraseñaUser varchar(8) NOT NULL,
	tipoUser varchar(20) not null
);

-- Programas
CREATE TABLE Programas(
	codigoProg int NOT NULL PRIMARY KEY,
	nombreProg varchar(30) NOT NULL,
	fechaIniProg date NOT NULL,
	duracionProg int NOT NULL,
	nivelProg varchar(15) NOT NULL
);

-- Grupos
CREATE TABLE Grupos(
	idGrupo int NOT NULL PRIMARY KEY,
	nombreGrupo varchar(20) NOT NULL
);

-- Fichas
CREATE TABLE Fichas(
	codigoFic int NOT NULL PRIMARY KEY,
	fechaIniFic date NOT NULL,
	fechaFinFic date NOT NULL,
	codigoProg int NOT NULL,
	FOREIGN KEY (codigoProg) REFERENCES Programas(codigoProg)
);

-- Eventos (IDS MANUALES: NO IDENTITY)
CREATE TABLE Eventos (
    idEvento INT NOT NULL PRIMARY KEY,
    nombreEvento VARCHAR(50) NOT NULL,
    tipoEvento VARCHAR(50) NOT NULL,
    fechaEvento DATE NOT NULL,
    horaEvento TIME NOT NULL,
    duracionMinutos INT NOT NULL CONSTRAINT DF_Eventos_duracionMinutos DEFAULT 60, -- Regla de duración por defecto de 60 minutos
    idUser INT NOT NULL,
    CONSTRAINT FK_Eventos_Usuario FOREIGN KEY (idUser) REFERENCES Usuario(idUser),
    CONSTRAINT CK_Eventos_Duracion_Positive CHECK (duracionMinutos > 0) -- Regla de duración positiva 
);

-- Aprendiz
CREATE TABLE Aprendiz(
	idApr int NOT NULL PRIMARY KEY,
	nombreApr varchar(50) NOT NULL,
	edadApr int NOT NULL,
	emailApr varchar(50) not null,
	contactoApr numeric not null,
	nomberUser varchar(50) not null,
	contraseñaUser varchar(18) not null,
	tipoUser varchar(20) not null,
	generoApr char(1) NOT NULL,
	codigoFic int NOT NULL,
	FOREIGN KEY (codigoFic) REFERENCES Fichas(codigoFic)
);

-- Inscripciones 
CREATE TABLE Inscripciones(
	idInscrip int NOT NULL PRIMARY KEY,
	fechaInscrip DATE NOT NULL,
	modalidadInscrip varchar(10) NOT NULL,
	idApr int NOT NULL,
	idEvento int NOT NULL,
	idGrupo int NOT NULL,
	FOREIGN KEY (idApr) REFERENCES Aprendiz(idApr),
	FOREIGN KEY (idEvento) REFERENCES Eventos(idEvento),
	FOREIGN KEY (idGrupo) REFERENCES Grupos(idGrupo)
);