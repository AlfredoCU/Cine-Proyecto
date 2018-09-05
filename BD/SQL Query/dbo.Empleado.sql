USE Cine

CREATE TABLE Empleado(
	[Id Empleado]			INT				PRIMARY KEY,
	Nombre					VARCHAR(35)		NOT NULL,
	Apellidos				VARCHAR(35)		NOT NULL,
	Sexo					VARCHAR(1)		NOT NULL,
	[Fecha de Nacimiento]	DATE			NOT NULL,
	Dirección				VARCHAR(MAX)	NULL,
	Teléfono				INT				NULL,
	Email					VARCHAR(50)	    NULL,
	Acceso					VARCHAR(25)		NOT NULL,
	Usuario					VARCHAR(25)		NOT NULL,
	Password				VARCHAR(25)		NOT NULL
);