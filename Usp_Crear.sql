
-- =============================================
-- Author:		Marvin Ramirez
-- Create date:  22-02-2025
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE usp_Cuentas_crear 
	-- Add the parameters for the stored procedure here  
	( 
	@CodigoCliente int, 
	@NumeroCuenta varchar (50),  
	@TipoCuenta varchar (50), 
	@Saldo decimal (10,2), 
	@FechaApertura DATETIME, 
	@Estado varchar (15)
	) 


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 
	Insert into tbl_cuentas  
	( 
	CodigoCliente, 
	NumeroCuenta, 
	TipoCuenta, 
	Saldo, 
	FechaApertura, 
	Estado  
	) 

	values 
	( 
	@CodigoCliente, 
	@NumeroCuenta, 
	@TipoCuenta, 
	@Saldo, 
	@FechaApertura, 
	@Estado  
	)


    
END
GO

