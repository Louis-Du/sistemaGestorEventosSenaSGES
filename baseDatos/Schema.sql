CREATE DATABASE SGES
go

CREATE TABLE Administrador(
	idAdmin int NOT NULL PRIMARY KEY,
	nombreAdmin varchar(50) NOT NULL,
	contraseñaAdmin varchar(8) NOT NULL
)

CREATE TABLE Evento(
	idEvento INT NOT NULL PRIMARY KEY,
	nombreEvento VARCHAR(50) NOT NULL,
	tipoEvento VARCHAR(15) NOT NULL,
	fechaEvento DATE NOT NULL,
	horaEvento TIME NOT NULL,
	idAdmin INT NOT NULL,
	FOREIGN KEY (idAdmin) REFERENCES Administrador(idAdmin)
)

CREATE TABLE Programa(
	codigoProg int NOT NULL PRIMARY KEY,
	nombreProg varchar(30) NOT NULL,
	fechaIniProg date NOT NULL,
	duracionProg int NOT NULL,
	nivelProg int NOT NULL
)

CREATE TABLE Ficha(
	codigoFic int NOT NULL PRIMARY KEY,
	fechaIniFic date NOT NULL,
	fechaFinFic date NOT NULL,
	codigoProg int NOT NULL,
	FOREIGN KEY (codigoProg) REFERENCES Programas(codigoProg)
)

CREATE TABLE Aprendiz(
	idApr int NOT NULL PRIMARY KEY,
	nombreApr varchar(50) NOT NULL,
	edadApr int NOT NULL,
	generoApr varchar(10) NOT NULL,
	codigoFic int NOT NULL,
	FOREIGN KEY (codigoFic) REFERENCES Fichas(codigoFic)
)

CREATE TABLE Grupo(
	idGrupo int NOT NULL PRIMARY KEY,
	nombreGrupo varchar(20) NOT NULL
)

CREATE TABLE Inscripcion(
	idInscrip int NOT NULL PRIMARY KEY,
	fechaInscrip DATE NOT NULL,
	modalidadInscrip varchar(10) NOT NULL,
	idApr int NOT NULL,
	idEvento int NOT NULL,
	idGrupo int NOT NULL,
	FOREIGN KEY (idApr) REFERENCES Aprendiz(idApr),
	FOREIGN KEY (idEvento) REFERENCES Eventos(idEvento),
	FOREIGN KEY (idGrupo) REFERENCES Grupos(idGrupo)
)

