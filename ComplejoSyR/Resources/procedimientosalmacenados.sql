SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- PROCEDIMIENTOS DE ALOJAMIENTOS
CREATE PROCEDURE AlojamientoTraer 
	-- traer alojamientos con el nombre de la modalidad a la cual pertenencen
AS
BEGIN 

	SET NOCOUNT ON;

	select a.id, a.numero,a.capacidad,a.idmodalidad,m.nombre Modalidad, a.sector from alojamientos a 
	inner join modalidades m on m.id = a.IdModalidad
	order by a.Numero asc 
END
GO
------------------------------------------------------
CREATE PROCEDURE AlojamientoAgregar 
	-- parametros
	@Numero varchar (60),
	@Capacidad int,
	@idModalidad int,
	@Sector varchar (10)
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Alojamientos (Numero,Capacidad,IdModalidad,Sector)
	VALUES (@Numero,@Capacidad,@idModalidad,@Sector)
	
END
GO
-------------------------------------------------------
CREATE PROCEDURE AlojamientoEliminar 
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM Alojamientos WHERE Id = @Id
	
END
GO
-------------------------------------------------------
CREATE PROCEDURE AlojamientoModificar 
	-- parametros
	@Id int,
	@Numero varchar (60),
	@Capacidad int,
	@idModalidad int,
	@Sector varchar (10)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Alojamientos SET Numero=@Numero ,
	Capacidad=@Capacidad, IdModalidad= @idModalidad,
	Sector= @Sector 
	WHERE Id = @Id 
	
END
GO
-------------------------------------------------------
CREATE PROCEDURE AlojamientosDisponibles
@FI date, @FE date,@Tipo varchar(20)
AS
BEGIN

	SET NOCOUNT ON;
SELECT a.Id,a.Numero,m.Nombre Modalidad, a.Capacidad  FROM Alojamientos a
INNER JOIN Modalidades m on m.Id = a.IdModalidad  
where m.Tipo like @Tipo and a.Id not in (SELECT a.Id  FROM Alojamientos a 
INNER JOIN Modalidades m on m.Id = a.IdModalidad 
INNER JOIN AlojamientoDeReserva  ar on ar.IdAlojamiento= a.Id 
INNER JOIN Reservas r on r.id = ar.IdReserva 

where	(@FI <= r.FIngreso and @FE <= r.FEgreso and @FE > r.FIngreso and r.Cancelada = 0  ) or 
		(@FI > r.FIngreso  and  @FE < r.FEgreso and r.Cancelada = 0 ) or 
		(@FI >= r.FIngreso  and  @FE >= r.FEgreso and @FI < r.FEgreso and r.Cancelada = 0 ) or
		(@FI < r.FIngreso  and @FE >=r.FEgreso and r.Cancelada = 0 )) order by a.Numero asc  
END
GO
-------------------------------------------------------
CREATE PROCEDURE AlojamientosOcupacion
@FI date,
@FE date,
@Tipo varchar (20)
AS
BEGIN
	
	SET NOCOUNT ON;
select * from (
(SELECT a.Id, a.Numero, m.Nombre,a.Capacidad, c.Nombre Cliente,  r.FIngreso , r.FEgreso, r.Id IdReserva  FROM Alojamientos a 

INNER JOIN Modalidades m on m.Id = a.IdModalidad 
INNER JOIN AlojamientoDeReserva  ar on ar.IdAlojamiento= a.Id 
INNER JOIN Reservas r on r.id = ar.IdReserva
inner join Clientes c on c.Id = r.idcliente 

where	(@FI <= r.FIngreso and @FE <= r.FEgreso and @FE > r.FIngreso and r.Cancelada = 0 and m.Tipo like @Tipo and r.Retiro = 0 ) or 
		(@FI > r.FIngreso  and  @FE <= r.FEgreso and r.Cancelada = 0 and m.Tipo like @Tipo and r.Retiro = 0) or 
		(@FI >= r.FIngreso  and  @FE >= r.FEgreso and @FI < r.FEgreso and r.Cancelada = 0 and m.Tipo like @Tipo and r.Retiro = 0) or
		(@FI <r.FIngreso  and @FE >=r.FEgreso and r.Cancelada = 0 and m.Tipo like @Tipo and r.Retiro = 0))
		
union all 

SELECT a.Id,a.Numero, m.Nombre,a.Capacidad, null ,null, null, null FROM Alojamientos a
INNER JOIN Modalidades m on m.Id = a.IdModalidad  
where m.Tipo like @Tipo and a.Id not in (SELECT a.Id  FROM Alojamientos a  
INNER JOIN AlojamientoDeReserva  ar on ar.IdAlojamiento= a.Id 
INNER JOIN Reservas r on r.id = ar.IdReserva 

where	(@FI <= r.FIngreso and @FE <= r.FEgreso and @FE > r.FIngreso and r.Cancelada = 0 and r.Retiro = 0 ) or 
		(@FI > r.FIngreso  and  @FE <= r.FEgreso and r.Cancelada = 0 and r.Retiro = 0) or 
		(@FI >= r.FIngreso  and  @FE >= r.FEgreso and @FI < r.FEgreso and r.Cancelada = 0 and r.Retiro = 0 ) or
		(@FI < r.FIngreso  and @FE >=r.FEgreso and r.Cancelada = 0 and r.Retiro = 0))
		)as disp
		
 order by numero asc, FIngreso asc
END
GO
--------------------------------------------------------------

-- PROCEDIMIENTOS DE ALOJAMIENTOS RESERVA

CREATE PROCEDURE AlojResTraer 
	-- traer alojamientos de una reserva predeterminada
	@IdReserva int 
AS
BEGIN 

SET NOCOUNT ON;
select aljr.Id, a.Numero,m.Nombre Modalidad , a.Capacidad  from alojamientos a
inner join Modalidades m on m.Id = a.IdModalidad 
inner join AlojamientoDeReserva aljr on aljr.IdAlojamiento = a.Id
where aljr.IdReserva = @IdReserva 

END
GO
------------------------------------------------------
CREATE PROCEDURE AlojResAgregar 
	-- parametros
	@IdReserva int, @IdAlojamiento int
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO AlojamientoDeReserva (IdReserva,IdAlojamiento)
	VALUES (@IdReserva,@IdAlojamiento)
	
END
GO
------------------------------------------------------
CREATE PROCEDURE AlojResModificar 
	-- parametros
	@Id int, @IdReserva int, @IdAlojamiento int
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE AlojamientoDeReserva SET IdReserva=@IdReserva,
	IdAlojamiento = @IdAlojamiento WHERE Id = @Id

END
GO
-------------------------------------------------------
CREATE PROCEDURE AlojResEliminar

@Id int 

AS
BEGIN

SET NOCOUNT ON;
   DELETE FROM AlojamientoDeReserva WHERE Id=@Id
END
GO
--------------------------------------------------------------
-- PROCEDIMIENTOS DE CLIENTES 

CREATE PROCEDURE ClienteTraer 
	-- traer clientes 
AS
BEGIN 

	SET NOCOUNT ON;

	select * from Clientes 
	order by Nombre asc
END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteDatos 
	-- traer datos de un cliente
	@Id int
AS
BEGIN 

	SET NOCOUNT ON;

	select * from Clientes where id = @Id

END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteAgregar 
	-- parametros
	@Nombre varchar (60),
	@Telefono varchar (13),
	@Correo varchar (60),
	@Domicilio varchar (60),
	@Provincia varchar (30),
	@Vehiculo varchar (30),
	@Patente varchar (10)
AS
BEGIN

	SET NOCOUNT ON;

		INSERT INTO Clientes (nombre,telefono,correo,domicilio, Provincia,Vehiculo,Patente) 
		VALUES (@nombre,@telefono,@correo,@domicilio,@Provincia,@Vehiculo,@Patente)
			
END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteModificar
	-- parametros
	@Id int,
	@Nombre varchar (60),
	@Telefono varchar (13),
	@Correo varchar (60),
	@Domicilio varchar (60),
	@Provincia varchar (30),
	@Vehiculo varchar (30),
	@Patente varchar (10)
AS
BEGIN

	SET NOCOUNT ON;

        UPDATE Clientes SET Nombre=@Nombre, Telefono=@Telefono,
        Correo=@Correo,Domicilio= @Domicilio, 
        Provincia = @Provincia, Vehiculo = @Vehiculo,
        Patente = @Patente
        WHERE Id=@Id 
		
			
END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteEliminar
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

     DELETE FROM Clientes 
     WHERE Id=@Id 
		
			
END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteBuscar
	-- parametros
	@Nombre varchar (60)
AS
BEGIN

	SET NOCOUNT ON;

     SELECT * FROM Clientes 
     WHERE Nombre like '%' + @Nombre + '%'
		
			
END
GO
------------------------------------------------------
CREATE PROCEDURE ClienteHistorial
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

     SELECT r.Id, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado FROM Reservas r
     WHERE r.IdCliente = @Id
	  ORDER BY r.fingreso desc
			
END
GO
--------------------------------------------------------
--------------------------------------------------------
-- PROCEDIMIENTOS DE MODALIDADES 
CREATE PROCEDURE ModalidadTraer 
	-- traer Modalidades 
AS
BEGIN 

	SET NOCOUNT ON;

	select * from Modalidades  
END
GO
------------------------------------------------------
CREATE PROCEDURE ModalidadAgregar 
	-- parametros
	@Nombre varchar (60),
	@Tipo varchar (20)
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Modalidades (Nombre,Tipo)
	VALUES (@Nombre,@Tipo )
	
END
GO

------------------------------------------------------
CREATE PROCEDURE ModalidadModificar
	-- parametros
	@Id int,
	@Nombre varchar (60),
	@Tipo varchar (20)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Modalidades 
	SET Nombre=@Nombre, Tipo=@Tipo
	WHERE Id = @Id 
	 
END
GO

------------------------------------------------------
CREATE PROCEDURE ModalidadEliminar 
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;
		
		DELETE FROM Modalidades WHERE Id = @Id	
 
END
GO
--------------------------------------------------------
--------------------------------------------------------
-- PROCEDIMIENTOS DE PAGOS
CREATE PROCEDURE PagosTraer 
	-- traer pagos de una reserva predeterminada
	@IdReserva int 
AS
BEGIN 

	SET NOCOUNT ON;

SELECT * FROM Pagos 
WHERE IdReserva = @IdReserva
END
GO
------------------------------------------------------
CREATE PROCEDURE PagoAgregar 
	-- parametros
@IdReserva int, 
@Importe decimal (10,2),
@Descripcion varchar(60),
@Fecha date 
AS
BEGIN

	SET NOCOUNT ON;
        INSERT INTO Pagos (IdReserva,Importe,Descripcion,Fecha)
        VALUES (@IdReserva,@Importe,@Descripcion,@Fecha)
	
END
GO
------------------------------------------------------
CREATE PROCEDURE PagoModificar 
	-- parametros
	@id int,
	@IdReserva int, 
	@Importe decimal (10,2),
	@Descripcion varchar(60),
	@Fecha date 
AS
BEGIN

	SET NOCOUNT ON;
       
        UPDATE pagos SET IdReserva = @IdReserva, Importe = @Importe,
        Fecha=@Fecha,Descripcion = @Descripcion
        WHERE Id=@Id
	
END
GO
------------------------------------------------------
CREATE PROCEDURE PagoEliminar
	-- parametros
	@id int
AS
BEGIN

	SET NOCOUNT ON;
       DELETE FROM Pagos 
       WHERE Id=@Id
	
END
GO
--------------------------------------------------------
--------------------------------------------------------
-- PROCEDIMIENTOS DE SERVICIOS
CREATE PROCEDURE ServicioTraer 
	-- traer servicios de una reserva 
	@IdReserva int
AS
BEGIN 

	SET NOCOUNT ON;

	select id,Descripcion, Fecha, Importe from Servicios WHERE IdReserva = @IdReserva 
END
GO
------------------------------------------------------
CREATE PROCEDURE ServicioAgregar 
	-- parametros
	@IdReserva int,  @Fecha date,
	@Importe decimal(10,2), @Descripcion varchar (60)
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Servicios(IdReserva,Fecha,Importe,Descripcion) 
    
	 VALUES (@IdReserva,@Fecha,@Importe,@Descripcion)
	
END
GO
------------------------------------------------------
CREATE PROCEDURE ServicioModificar 
	-- parametros
	@Id int, @IdReserva int, @Fecha date,
	@Importe decimal(10,2), @Descripcion varchar (60)
AS
BEGIN

	SET NOCOUNT ON;

UPDATE Servicios SET IdReserva = @IdReserva,
										Fecha= @Fecha,
										Importe= @Importe,
										Descripcion =@Descripcion
	
WHERE Id = @Id
	
END
GO
------------------------------------------------------
CREATE PROCEDURE ServicioEliminar
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM Servicios
	WHERE Id = @Id
	
END
GO

--------------------------------------------------------
--------------------------------------------------------
-- PROCEDIMIENTOS DE RESERVA
CREATE PROCEDURE ReservasTraer 
	-- traer las reservas
	
AS
BEGIN 

	SET NOCOUNT ON;

SELECT r.Id,m.Nombre, a.Numero, c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado   FROM Reservas r 
	inner join Clientes c on c.Id = r.IdCliente
	inner join AlojamientoDeReserva ar on ar.IdReserva = r.Id 
	inner join Alojamientos a on a.Id = ar.IdAlojamiento
	inner join Modalidades m on m.Id = a.IdModalidad   
        group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva,M.Nombre,a.Numero
		order by r.freserva desc
END
GO
------------------------------------------------------
CREATE PROCEDURE ReservaDatos
	-- traer las reservas
	@Id int
AS
BEGIN 

	SET NOCOUNT ON;

SELECT * FROM Reservas WHERE Id = @Id
END
GO
------------------------------------------------------
CREATE PROCEDURE ReservaAgregar 
	-- parametros
@IdCliente int ,@FIngreso date ,@FEgreso date ,@FReserva  date,
 @CantDias int ,@CantPersonas int,@ImpDia decimal(10,2),
 @ImpTotal decimal(10,2), @Descripcion varchar(200), @Cancelada bit,@Retiro bit
AS
BEGIN

	SET NOCOUNT ON;
       INSERT INTO reservas (IdCliente,FIngreso,FEgreso,FReserva, CantDias,cantPersonas,ImpDia,ImpTotal,Descripcion,Cancelada,Retiro)
        values (@IdCliente,@FIngreso,@FEgreso,@FReserva, @CantDias,@cantPersonas,@impDia,@ImpTotal,@Descripcion,@Cancelada,@Retiro)
END
GO
------------------------------------------------------
CREATE PROCEDURE ReservaModificar 
	-- parametros
	@IdCliente int ,@FIngreso date ,
	@FEgreso date ,@FReserva  date,
 @CantDias int ,@CantPersonas int
 ,@ImpDia decimal(10,2),@ImpTotal decimal(10,2),
 @Descripcion varchar(200),@Cancelada bit, @Id int,@Retiro bit 
AS
BEGIN

	SET NOCOUNT ON;
       
     UPDATE Reservas 
     SET IdCliente=@IdCliente, FIngreso=@FIngreso,
		FEgreso=@FEgreso,FReserva=@FReserva, CantDias = @CantDias,
		CantPersonas=@CantPersonas,ImpDia=@ImpDia,
		ImpTotal=@ImpTotal, Descripcion=@Descripcion,
		Cancelada=@Cancelada, retiro = @Retiro
     WHERE Id=@Id
	
END
GO
------------------------------------------------------
CREATE PROCEDURE ReservaEliminar
	-- parametros
	@Id int
AS
BEGIN

	SET NOCOUNT ON;
       DELETE FROM Reservas  
       WHERE Id=@Id
	
END
GO
-------------------------------------------------------
CREATE PROCEDURE ReservaUltimoId

AS
BEGIN

	SET NOCOUNT ON;
   SELECT MAX(Id)Id FROM RESERVAS
	
END
GO
--------------------------------------------------------
-- al modificar la fecha de egreso de una reserva se verifica que esta no sea mayor
-- que la fecha de ingreso de otra reserva en el mismo alojamiento
CREATE PROCEDURE DisponibilidadDelAlojamiento
@idalojamiento int, @FE date,@FI date
AS
BEGIN
	
	SET NOCOUNT ON;

  
	SELECT count(a.id) id from Alojamientos a
	
	inner join AlojamientoDeReserva ar on ar.IdAlojamiento = a.Id 
	inner join Reservas r on r.Id = ar.IdReserva 
	
		where a.Id = @idalojamiento and @FE > r.FIngreso and r.Fingreso >@FI and r.Id <> @idreserva
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE ReservaBuscar
	-- parametros
	@Nombre varchar (60)
AS
BEGIN

	SET NOCOUNT ON;
       SELECT r.Id,c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado  FROM Reservas r 
        inner join Clientes c on c.id = r.idcliente 
        where c.Nombre  like '%' + @Nombre + '%'
        group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva 
        order by r.freserva desc
END
GO


/*---PAGOS IMPORTE*/
CREATE VIEW [dbo].[PagosImportes]
AS
SELECT     r.Id, r.ImpTotal, ISNULL(SUM(p.Importe), 0) AS Pagado
FROM         dbo.Reservas AS r LEFT OUTER JOIN
                      dbo.Pagos AS p ON p.IdReserva = r.Id
GROUP BY r.Id, r.ImpTotal

GO
/*---SERVICIOS IMPORTE*/
CREATE VIEW [dbo].[ServiciosImporte]
AS
SELECT     r.Id, r.ImpTotal, ISNULL(SUM(s.Importe), 0) AS TotalServicio
FROM         dbo.Reservas AS r LEFT OUTER JOIN
                      dbo.Servicios AS s ON s.IdReserva = r.Id
GROUP BY r.Id, r.ImpTotal

GO
--------------------------------------------------------
CREATE PROCEDURE ReservaImportes
@Id int
AS
BEGIN

	SET NOCOUNT ON;
select p.id, s.Totalservicio Servicios,s.ImpTotal SubTotal,  (s.imptotal + s.totalservicio)Total, p.Pagado,
((s.imptotal+ s.totalservicio)- p.pagado)Deuda  from PagosImportes p 
inner join serviciosimporte s on s.id = p.id 

where p.Id = @Id
group by p.id, s.totalservicio, p.pagado, s.imptotal
 
END
GO
--------------------------------------------------------
CREATE PROCEDURE ReservasCanceladas

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT r.Id,a.Numero, m.Nombre Modalidad, c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado    FROM Reservas r 
	inner join Clientes c on c.Id = r.IdCliente
	inner join AlojamientoDeReserva ar on ar.IdReserva = r.Id 
	inner join Alojamientos a on a.Id = ar.IdAlojamiento
	inner join Modalidades m on m.Id = a.IdModalidad
	
	where  r.Cancelada = 1
        group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva,M.Nombre,a.Numero
		order by r.freserva desc
END
GO
--------------------------------------------------------
CREATE PROCEDURE ReservasConfirmadas

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT r.Id,a.Numero, m.Nombre Modalidad, c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado, Sum(p.Pagado)Pagado    FROM Reservas r 
	inner join Clientes c on c.Id = r.IdCliente
	inner join AlojamientoDeReserva ar on ar.IdReserva = r.Id 
	inner join Alojamientos a on a.Id = ar.IdAlojamiento
	inner join Modalidades m on m.Id = a.IdModalidad
	inner join PagosImportes p on p.Id = r.Id 
	where p.Pagado > 0 and r.Cancelada = 0 
        group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva,M.Nombre,a.Numero
		order by r.freserva desc
END
GO
--------------------------------------------------------
CREATE PROCEDURE ReservasSinConfirmar

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT r.Id,a.Numero, m.Nombre Modalidad, c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado, Sum(p.Pagado)Pagado,r.Cancelada cancelar    FROM Reservas r 
	inner join Clientes c on c.Id = r.IdCliente
	inner join AlojamientoDeReserva ar on ar.IdReserva = r.Id 
	inner join Alojamientos a on a.Id = ar.IdAlojamiento
	inner join Modalidades m on m.Id = a.IdModalidad
	inner join PagosImportes p on p.Id = r.Id 
	where p.Pagado = 0 and r.Cancelada = 0 
        group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva,M.Nombre,a.Numero,r.Cancelada
		order by r.freserva desc
END
GO
--------------------------------------------------------

CREATE PROCEDURE ReservasARetirarse
@Fecha date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT r.Id,a.Numero, m.Nombre Modalidad, c.Nombre Cliente, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado    FROM Reservas r 
	inner join Clientes c on c.Id = r.IdCliente
	inner join AlojamientoDeReserva ar on ar.IdReserva = r.Id 
	inner join Alojamientos a on a.Id = ar.IdAlojamiento
	inner join Modalidades m on m.Id = a.IdModalidad
	
	where  r.Cancelada = 0 and r.FEgreso = @Fecha
    --group by r.Id,c.Nombre, r.FIngreso, r.FEgreso,r.FReserva,M.Nombre,a.Numero
	--order by r.freserva desc
END
GO
--------------------------------------------------------

CREATE PROCEDURE ActualizarRetiro 
@Retiro bit, @Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   UPDATE Reservas SET Retiro = @Retiro WHERE Id = @Id
END
GO