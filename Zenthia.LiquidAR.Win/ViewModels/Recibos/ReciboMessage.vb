Public Class ReciboMessage
	Public Sub New(ByVal t As Zenthia.AccesoDatos.Recibos)
		ID = t.Id
	End Sub
	Public Property ID() As Long
End Class

