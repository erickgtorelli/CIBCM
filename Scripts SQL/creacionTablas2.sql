use BD_CIBCM

CREATE TABLE InstrumentosClinicos ( 
			Nombre VARCHAR (255) PRIMARY KEY,
			);
CREATE TABLE Lleno ( 
			 Cedula char (9),
			 FOREIGN KEY (Cedula) References Paciente (Cedula),
			 NombreInstrumentoClinico VARCHAR (255), 
			 FOREIGN KEY (NombreInstrumentoClinico) REFERENCES InstrumentosClinicos (Nombre), 
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
				CodigoParticipación char(6), 
				PRIMARY KEY (Cedula, CodigoEstudio),
);                


--meter hasta tener diagnostico, parcial y consenso 
CREATE TABLE sintomas(
sintoma varchar (256) NOT NULL, 
cedulaPaciente char (9) NOT NULL, 
numDiagnostico int NOT NULL, 
FOREIGN KEY (cedulaPaciente,numDiagnostico) REFERENCES Diagnostico (Cedula,NumDiagnostico), 
PRIMARY KEY (sintoma, cedulaPaciente, numDiagnostico),

);

