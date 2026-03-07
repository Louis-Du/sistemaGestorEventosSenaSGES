CREATE DATABASE SGES
GO
CREATE TABLE Eventos{
	idEvento int NOT NULL PRIMARY key,
	nombreEvento varchar(50) NOT NULL,
	tipoEvento varchar(15) NOT NULL,
	fechaEvento date NOT NULL,
	horaEvento time NOT NULL
}

CREATE TABLE Administrador{
	idAdmin int NOT NULL PRIMARY KEY,
	nombreAdmin varchar(50) NOT NULL,
	contraseñaAdmin varchar(8) NOT null
}

CREATE TABLE Inscripciones{
	idInscrip int NOT NULL PRIMARY KEY,
	fechaInscrip DATA NOT NULL,
	modalidadInscrip varchar(10) NOT null
}

CREATE TABLE Aprendiz{
	idApr int NOT NULL PRIMARY KEY,
	nombreApr varchar(50) NOT NULL,
	edadApr int NOT NULL,
	generoApr char NOT NULL,
	
}