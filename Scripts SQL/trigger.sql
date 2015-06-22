
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