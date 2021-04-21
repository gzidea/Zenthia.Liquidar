Option Infer On

Public Class EmpresaMessage
	Public Sub New(ByVal t As YiZi.AccesoDatos.Empresas)
		ID = t.Id
	End Sub
	Public Property ID() As Integer
End Class
