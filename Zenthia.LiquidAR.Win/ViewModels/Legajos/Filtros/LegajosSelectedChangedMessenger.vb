Public Class LegajosSelectedChangedMessenger
	Public Sub New(ByVal t As List(Of Zenthia.AccesoDatos.Legajos), ByVal p As String, ByVal tl As Zenthia.AccesoDatos.TipoLiquidacion)
		legajosSel = t
		Periodo = p
		TipoLiquidacion = tl
	End Sub
	Public Property legajosSel As List(Of Zenthia.AccesoDatos.Legajos)
	Public Property Periodo As String
	Public Property TipoLiquidacion As Zenthia.AccesoDatos.TipoLiquidacion
End Class
