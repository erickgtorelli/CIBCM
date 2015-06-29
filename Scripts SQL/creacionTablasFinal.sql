Create table Persona(
	Cedula char(9) PRIMARY KEY,
	PrimerNombre varchar(10),
	Apellido1 varchar(10),
	Apellido2 varchar(10),
	FechaDeNacimiento DATE,
	Sexo char
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
	Metodo varchar(128) DEFAULT 'Secuensación',
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

use BD_CIBCM;
CREATE TABLE Diagnostico(
	Cedula char(9) NOT NULL,
	NumDiagnostico int NOT NULL,
	Link varchar(256) NULL,
	Fecha date NULL,
	Enfermedad varchar(512) NULL,
	Sintomas varchar(512) NULL,
	PRIMARY KEY (Cedula, NumDiagnostico),
	FOREIGN KEY(Cedula)REFERENCES Paciente (Cedula)

)
CREATE TABLE Consenso(
	Cedula char(9) NOT NULL,
	NumDiagnostico int NOT NULL,
PRIMARY KEY (Cedula ,NumDiagnostico),
FOREIGN KEY(Cedula, NumDiagnostico)
REFERENCES Diagnostico (Cedula, NumDiagnostico)
);

CREATE TABLE Parcial (
	Cedula char (9) NOT NULL,
	NumDiagnostico int  NOT NULL,
	CedInvestigador char (9) NOT NULL,
	NumDiagnosticoCons int,
	CedCons char(9),
PRIMARY KEY 
(
	Cedula,
	NumDiagnostico,
	CedInvestigador
), 
 FOREIGN KEY(CedCons, NumDiagnosticoCons)
REFERENCES Consenso (Cedula, NumDiagnostico),
FOREIGN KEY(Cedula, NumDiagnostico)REFERENCES Diagnostico (Cedula, NumDiagnostico),
FOREIGN KEY(CedInvestigador)REFERENCES Investigador (Cedula)
);


CREATE TABLE Realiza(
	Cedula char (9) NOT NULL,
	CodigoEstudio char (6) NULL,
	PRIMARY KEY (Cedula),
	FOREIGN KEY(Cedula) REFERENCES Investigador (Cedula),
	FOREIGN KEY(CodigoEstudio) REFERENCES Estudio (CodigoEstudio)
);

CREATE TABLE InstrumentosClinicos ( 
			Nombre VARCHAR (255) PRIMARY KEY,
			);

CREATE TABLE Lleno ( 
			 Cedula char (9),
			 FOREIGN KEY (Cedula) References Paciente (Cedula),
			 NombreInstrumentoClinico VARCHAR (255), 
			 FOREIGN KEY (NombreInstrumentoClinico) REFERENCES InstrumentosClinicos (Nombre)
			 	ON DELETE NO ACTION
				ON UPDATE CASCADE, 
			 PRIMARY KEY (Cedula, NombreInstrumentoClinico), 
			 );

CREATE TABLE Estudio (
				CodigoEstudio char (6) NOT NULL,
				Descripcion varchar (255), 
				Fecha date, 
				PRIMARY KEY (CodigoEstudio), 
				);	

				
CREATE TABLE Participo (       	
				Cedula char (9),--FK Paciente 
				FOREIGN KEY (Cedula) REFERENCES Paciente (Cedula), 
				CodigoEstudio char (6), 
				FOREIGN KEY (CodigoEstudio) REFERENCES Estudio (CodigoEstudio),   --FK Estudio 
				CodigoParticipacion char(6), 
				PRIMARY KEY (Cedula, CodigoEstudio,CodigoParticipacion),
);                


--meter hasta tener diagnostico, parcial y consenso 
CREATE TABLE sintomas(
		sintoma varchar (256) NOT NULL, 
		cedulaPaciente char (9) NOT NULL, 
		numDiagnostico int NOT NULL, 
		FOREIGN KEY (cedulaPaciente,numDiagnostico) REFERENCES Diagnostico (Cedula,NumDiagnostico), 
		PRIMARY KEY (sintoma, cedulaPaciente, numDiagnostico),

);



CREATE PROCEDURE ActualizarInstrumentos
@nombreViejo varchar(255), 
@nombreNuevo varchar (255)
AS
Update InstrumentosClinicos
Set Nombre = @nombreNuevo
Where Nombre = @nombreViejo

