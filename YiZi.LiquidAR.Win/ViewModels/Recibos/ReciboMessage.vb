Public Class ReciboMessage
	Public Sub New(ByVal t As YiZi.AccesoDatos.Recibos)
		ID = t.Id
	End Sub
	Public Property ID() As Long
End Class

