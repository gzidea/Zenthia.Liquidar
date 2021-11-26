Public Class LegajosSelectedChangedMessenger
	Public Sub New(ByVal t As List(Of YiZi.AccesoDatos.Legajos), ByVal p As String, ByVal tl As YiZi.AccesoDatos.TipoLiquidacion)
		legajosSel = t
		Periodo = p
		TipoLiquidacion = tl
	End Sub
	Public Property legajosSel As List(Of YiZi.AccesoDatos.Legajos)
	Public Property Periodo As String
	Public Property TipoLiquidacion As YiZi.AccesoDatos.TipoLiquidacion
End Class
