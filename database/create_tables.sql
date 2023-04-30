CREATE DATABASE College;
USE College;

CREATE TABLE Angajati(
	id_angajat int PRIMARY KEY IDENTITY(1,1),
	nume varchar(20),
	prenume varchar(20),
	data_nasterii date,
	idnp char(13) UNIQUE,
	sexul char(1),
	email varchar(50),
	salariu int
);

CREATE TABLE Catedre(
	id_catedra int PRIMARY KEY IDENTITY(1,1),
	nume_catedra varchar(40)
);

CREATE TABLE Cabinete(
	nr_cab int PRIMARY KEY,
	admin_cab int,
	FOREIGN KEY(admin_cab)REFERENCES Angajati(id_angajat)
);

CREATE TABLE Specialitate(
	id_specialitate int PRIMARY KEY IDENTITY(1,1),
	nume_specialitate varchar(50)
);

CREATE TABLE Grupe(
	id_grupa int PRIMARY KEY IDENTITY(1,1),
	nume_grupa char(10),
	id_specialitate int,
	nr_sectie int,
	FOREIGN KEY(id_specialitate)REFERENCES Specialitate(id_specialitate)ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Elevi(
	id_elevi int PRIMARY KEY IDENTITY(1,1),
	nume char(20),
	prenume char(20),
	sexul char(1),
	id_grupa int
);

CREATE TABLE Discipline(
	id_disciplina int PRIMARY KEY IDENTITY(1,1),
	nume_disciplina varchar(30)
);

use master;
drop database College;
