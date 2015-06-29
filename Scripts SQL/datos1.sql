Insert into Persona values('115825968','Francisco','Mora','Torres','19980901','M');
Insert into Persona values('118258695','Juana','Arce','Ballester','19900901','F');
Insert into Persona values('116485796','Gloriana','Porras','Bustos','19980703','F');
Insert into Persona values('113258695','Carolina','Arroyo','Tristan','19950901','F');
Insert into Persona values('112825968','Pablo','Angulo','Castro','19980901','M');
Insert into Persona values('111258695','Ana','Ortiz','Guzman','19950901','F');
Insert into Persona values('115525968','Alejandro','Santos','Torres','19980910','M');
Insert into Persona values('118268695','Susan','Delgado','Sandí','19950906','F');

Insert into Paciente values('118258695');
Insert into Paciente values('115825968');

Insert into Paciente values('116485796');
Insert into Paciente values('113258695');

Insert into Paciente values('112825968');
Insert into Paciente values('111258695');

Insert into Paciente values('115525968');
Insert into Paciente values('118268695');

Insert into Persona values('110000095','Fran','Chavez','Granados','19950901','F');
Insert into Persona values('114458968','Pedro','Mora','Torres','19980901','M');
Insert into Persona values('118568695','Alejandra','Arce','Ballester','19950901','F');

Insert into Investigador values('110000095');
Insert into Investigador values('114458968');
Insert into Investigador values('118568695');

Insert into Diagnostico values('115525968','1','/CIBCM/diagnosticoAlejandro.doc','20000815','Esquizofrenia');
Insert into Parcial values('115525968','1','110000095',null,null);
Insert into Diagnostico values('113258695','2','/CIBCM/diagnosticoCarolina.doc','20000817','Bipolaridad');
Insert into Parcial values('113258695','2','118568695',null,null);

Insert into InstrumentosClinicos VALUES ('DIGS'), ('FIGS'), ('AIMS'), ('Expediente médico'), ('STAN');

INSERT INTO Genotipeo VALUES ('115525968', 'Secuenciación', '/CIBCM/115525968/Genotipeo'), ('118268695', 'SNP', '/CIBCM/118268695/Genotipeo');

Insert Into Estudio VALUES ('123987', 'SIBS bipolar', '20090407');
Insert Into Realiza   ('118568695','123987');

