CREATE DATABASE SGES
go

CREATE TABLE Usuario(
	idUser int NOT NULL PRIMARY KEY,
	nombreUser varchar(50) NOT NULL,
	contraseñaUser varchar(8) NOT NULL,
	tipoUser varchar(20) not null,
)

CREATE TABLE Eventos(
	idEvento INT NOT NULL PRIMARY KEY,
	nombreEvento VARCHAR(50) NOT NULL,
	tipoEvento VARCHAR(15) NOT NULL,
	fechaEvento DATE NOT NULL,
	horaEvento TIME NOT NULL,
	idUser INT NOT NULL,
	FOREIGN KEY (idUser) REFERENCES Usuario(idUser)
)

CREATE TABLE Programas(
	codigoProg int NOT NULL PRIMARY KEY,
	nombreProg varchar(30) NOT NULL,
	fechaIniProg date NOT NULL,
	duracionProg int NOT NULL,
	nivelProg varchar(15) NOT NULL
)

CREATE TABLE Fichas(
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
	emailApr varchar(50) not null,
	contactoApr numeric not null,
	nomberUser varchar(50) not null,
	contraseñaUser varchar(18) not null,
	tipoUser varchar(20) not null,
	generoApr char(1) NOT NULL,
	codigoFic int NOT NULL,
	FOREIGN KEY (codigoFic) REFERENCES Fichas(codigoFic)
)

CREATE TABLE Grupos(
	idGrupo int NOT NULL PRIMARY KEY,
	nombreGrupo varchar(20) NOT NULL
)

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
)
