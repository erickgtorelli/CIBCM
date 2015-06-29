use BD_CIBCM

CREATE PROCEDURE ActualizarInstrumentos
@nombreViejo varchar(255), 
@nombreNuevo varchar (255)
AS
Update InstrumentosClinicos
Set Nombre = @nombreNuevo
Where Nombre = @nombreViejo


