CREATE PROC Boletos
@CodCliente INT
AS
SELECT DISTINCT Peliculas.TituloPelicula, Cliente.NombreCl,
	Cliente.ApellidoCl, Cliente.Asi_Tradicional, Cliente.Asi_Preferente, 
	RAsientos.Nro_Asiento, Cliente.Monto

FROM RAsientos, Cliente, Peliculas, Cartelera

WHERE Cliente.Cod_Cliente = RAsientos.Cod_Cliente AND 
	Cartelera.Cod_Cartelera = RAsientos.Cod_Cartelera AND 
	Peliculas.Cod_Pelicula = Cartelera.Cod_Pelicula AND
	Cartelera.Cod_Cartelera = Cartelera.Cod_Cartelera AND
	Cartelera.Cod_Sala = Cartelera.Cod_Sala AND
	RAsientos.Cod_Cliente = @CodCliente
