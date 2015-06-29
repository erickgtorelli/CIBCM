use BD_CIBCM;
DROP TABLE Genotipeo;
DROP TABLE Muestra;
DROP TABLE Consenso;
DROP TABLE Parcial;
DROP TABLE Realiza;
DROP TABLE Lleno;
DROP TABLE InstrumentosClinicos;
DROP TABLE Participo;
DROP TABLE Estudio;
DROP TABLE sintomas;
DROP TABLE Diagnostico;
DROP TABLE Paciente;
DROP TABLE Investigador;
DROP TABLE Persona;

CREATE TABLE Persona(
	Cedula char(9),
	PrimerNombre varchar(25),
	Apellido1 varchar(25),
	Apellido2 varchar(25),
	FechaDeNacimiento DATE,
	Sexo char DEFAULT 'I',
	CONSTRAINT PKPersona PRIMARY KEY(Cedula)
);

CREATE TABLE Paciente(
	Cedula char(9),
	CONSTRAINT PKPaciente PRIMARY KEY(Cedula),
	CONSTRAINT FKPaciente_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Investigador(
	Cedula char(9),
	CONSTRAINT PKInvestigador PRIMARY KEY(Cedula), 
	CONSTRAINT FKInvestigador_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Genotipeo(
	Cedula char(9),
	Metodo varchar(128),
	Link varchar(256)
	CONSTRAINT PKGenotipeo PRIMARY KEY(Cedula, Metodo, Link),
	CONSTRAINT FKGenotipeo_Paciente FOREIGN KEY(Cedula) REFERENCES Paciente(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Muestra(
	Cedula char(9),
	TipoDeMuestra varchar(128),
	Localizacion varchar(256),
	CONSTRAINT PKMuestra PRIMARY KEY(Cedula, TipoDeMuestra),
	CONSTRAINT FKMuestra_Paciente FOREIGN KEY(Cedula) REFERENCES Paciente(Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Diagnostico(
	Cedula char(9),
	NumDiagnostico int,
	Link varchar(256),
	Fecha DATE,
	Enfermedad varchar(256),
	CONSTRAINT PKDiagnostico PRIMARY KEY(Cedula, NumDiagnostico),
	CONSTRAINT FK_Diagnostico_Paciente FOREIGN KEY(Cedula) REFERENCES Paciente(Cedula) 
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Consenso(
	Cedula char(9),
	NumDiagnostico int,
	CONSTRAINT PKConsenso PRIMARY KEY(Cedula, NumDiagnostico)
);
	
CREATE TABLE Parcial(
	Cedula char(9),
	NumDiagnostico int,
	CedInvestigador char(9) DEFAULT '000000000',
	NumDiagnosticoCons int,
	CedulaCons char(9),
	CHECK (NumDiagnostico>0),
	CONSTRAINT PKParcial PRIMARY KEY (Cedula, NumDiagnostico, CedInvestigador),
	CONSTRAINT FKParcial_Consenso FOREIGN KEY (CedulaCons, NumDiagnosticoCons) REFERENCES Consenso(Cedula, NumDiagnostico),
	CONSTRAINT FKParcial_Diagnostico FOREIGN KEY (Cedula, NumDiagnostico) REFERENCES Diagnostico(Cedula, NumDiagnostico)
	ON UPDATE CASCADE, -- elimino on delete cascade por el trigger
	CONSTRAINT FKParcial_Investigador FOREIGN KEY (CedInvestigador) REFERENCES Investigador(Cedula)
	ON DELETE SET DEFAULT,
);

CREATE TABLE Estudio (
	CodigoEstudio char (6) NOT NULL,
    Descripcion varchar (255), 
    Fecha date, 
    CONSTRAINT PKEstudio PRIMARY KEY (CodigoEstudio)
);	

CREATE TABLE Realiza(
	Cedula char(9),
	CodigoEstudio char(6),
	CONSTRAINT PKRealiza PRIMARY KEY (Cedula, CodigoEstudio),
	CONSTRAINT FKRealiza_Investigador FOREIGN KEY(Cedula) REFERENCES Investigador(Cedula)
	ON DELETE NO ACTION
	ON UPDATE CASCADE,
	CONSTRAINT FKRealiza_Estudio FOREIGN KEY(CodigoEstudio) REFERENCES Estudio(CodigoEstudio)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
);

CREATE TABLE InstrumentosClinicos (
	Nombre VARCHAR (255) 
	CONSTRAINT PKInstrumentosClinicos PRIMARY KEY(Nombre)
);

CREATE TABLE Lleno (
	Cedula char (9),
    NombreInstrumentoClinico VARCHAR (255),
	CONSTRAINT PKLleno PRIMARY KEY (Cedula, NombreInstrumentoClinico),
	CONSTRAINT FKLleno_Paciente FOREIGN KEY (Cedula) References Paciente (Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
    CONSTRAINT FKLleno_Instrumentos FOREIGN KEY (NombreInstrumentoClinico) REFERENCES InstrumentosClinicos (Nombre) 
);
			
CREATE TABLE Participo (
	Cedula char (9),
    CodigoEstudio char(6),
    CodigoParticipacion char(6), 
    CONSTRAINT PKParticipo PRIMARY KEY (Cedula, CodigoEstudio),
	CONSTRAINT FKParticio_Paciente FOREIGN KEY (Cedula) REFERENCES Paciente (Cedula)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	CONSTRAINT FKParticio_Estudio FOREIGN KEY (CodigoEstudio) REFERENCES Estudio (CodigoEstudio),
);                

CREATE TABLE Sintomas(
	Sintoma varchar (256), 
	CedulaPaciente char (9), 
	NumDiagnostico int, 
	CONSTRAINT FKSintomas_Diagnostico FOREIGN KEY (CedulaPaciente, NumDiagnostico) REFERENCES Diagnostico (Cedula, NumDiagnostico),
    CONSTRAINT PKSintomas PRIMARY KEY(Sintoma, CedulaPaciente, NumDiagnostico)
);

DROP TRIGGER BorrarParcial;

GO
CREATE TRIGGER BorrarParcial 
--borra sintomas despues de que se borra un diagnostico parcial 
ON Parcial 
INSTEAD OF DELETE 
AS 
Declare @cedTemp char (9), @diagTemp int
DECLARE cursor_parcial CURSOR FOR 
	Select Cedula, NumDiagnostico 
	FROM deleted 
	WHERE NumDiagnostico is not null 

OPEN cursor_parcial 
FETCH NEXT FROM cursor_parcial INTO @cedTemp, @diagTemp
WHILE @@FETCH_STATUS = 0 BEGIN 

	DELETE FROM sintomas 
	where cedulaPaciente = @cedTemp AND numDiagnostico = @diagTemp 
	DELETE FROM Parcial 
	WHERE cedula = @cedTemp AND NumDiagnostico = @diagTemp
	DELETE FROM Diagnostico 
	WHERE cedula = @cedTemp AND NumDiagnostico = @diagTemp


FETCH NEXT FROM cursor_parcial INTO @cedTemp, @diagTemp
END 
CLOSE cursor_parcial
DEALLOCATE cursor_parcial