USE [Cine]
GO
CREATE PROC ReporteVentaBoletos
AS
SELECT CONCAT(NombreCl,' ', ApellidoCl) AS Nombre_Completo, Dni AS Tarejeta, Asi_Tradicional, 
Asi_Preferente, Monto FROM Cliente
SELECT  SUM(Monto) AS total FROM Cliente