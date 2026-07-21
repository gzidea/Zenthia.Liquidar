Public Class NovedadesWizardSetting

    Public Property IdEmpresa As Integer

    Public Property IdConvenio As Integer

    Public Property IdTipoLiquidacion As Integer

    Public Property RowInicio As Integer?

    Public Property RowFin As Integer?

    Public Property ColumnaLegajo As String = String.Empty

    Public Property ColumnaDiasNormales As String = String.Empty

    Public Property ColumnaHorasNormales As String = String.Empty

    Public Property Conceptos As List(Of NovedadesWizardSettingDetalle)
End Class

Public Class NovedadesWizardSettingDetalle

    Public Property IdFormula As Integer?

    Public Property ColumnaCantidad As String = String.Empty

    Public Property ColumnaImporte As String = String.Empty
End Class