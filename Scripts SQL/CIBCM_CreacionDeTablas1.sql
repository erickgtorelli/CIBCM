
Create table Persona(
	Cedula char(9) PRIMARY KEY,
	PrimerNombre varchar(10),
	Apellido1 varchar(10),
	Apellido2 varchar(10),
	FechaDeNacimiento DATE,
	Sexo bit
);

Create table Paciente(
	Cedula char(9) PRIMARY KEY,
	CONSTRAINT FKPaciente_Persona Foreign key (Cedula) References Persona(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

Create table Investigador(
	Cedula char(9) PRIMARY KEY,
	CONSTRAINT FKInvestigador_Persona Foreign key (Cedula) References Persona(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

Create table Genotipeo(
	Cedula char(9),
	Metodo varchar(128),
	Link varchar(256)
	CONSTRAINT PKGenotipeo Primary key(Cedula,Metodo,Link),
	CONSTRAINT FKGenotipeo_Paciente Foreign key(Cedula) References Paciente(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

Create table Muestra(
	Cedula char(9),
	TipoDeMuestra varchar(128),
	Localizacion varchar(256),
	CONSTRAINT PKMuestra Primary key(Cedula,TipoDeMuestra),
	CONSTRAINT FKaPaciente Foreign key (Cedula) References Paciente(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
