
CREATE PROCEDURE usp_cuentas_mostrar
AS
BEGIN
	SET NOCOUNT ON;
Select 
CodigoCuenta as 'CodigoCuenta',
CodigoCliente as 'CodigoCliente',
NumeroCuenta,
TipoCuenta,
Saldo as 'Saldo',
FechaApertura as 'FechaApertura',
Estado
from tbl_cuentas;


END
GO
