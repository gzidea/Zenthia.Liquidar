Module FuncionesComunes
    Public Function DiferenciasEntreFechasStr(FechaDesde As Date, FechaHasta As Date) As String
        Dim años As Integer = DateDiff(DateInterval.Year, FechaDesde, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, FechaDesde.Month, FechaDesde.Day) Then
            años = años - 1
        End If

        Dim fechainicial As Date = DateAdd("YYYY", años, FechaDesde)
        Dim meses As Integer = DateDiff(DateInterval.Month, fechainicial, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, fechainicial.Month, fechainicial.Day) Then
            meses = meses - 1
        End If

        fechainicial = DateAdd("m", meses, fechainicial)
        Dim dias As Integer = DateDiff(DateInterval.Day, fechainicial, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, fechainicial.Month, fechainicial.Day) Then
            dias = dias - 1
        End If
        Return años & " Años " & meses & " Meses " & dias & " Dias"
    End Function

    Public Function DiferenciasEntreFechas(FechaDesde As Date, FechaHasta As Date) As Double
        Dim años As Integer = DateDiff(DateInterval.Year, FechaDesde, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, FechaDesde.Month, FechaDesde.Day) Then
            años = años - 1
        End If

        Dim fechainicial As Date = DateAdd("YYYY", años, FechaDesde)
        Dim meses As Integer = DateDiff(DateInterval.Month, fechainicial, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, fechainicial.Month, fechainicial.Day) Then
            meses = meses - 1
        End If

        fechainicial = DateAdd("m", meses, fechainicial)
        Dim dias As Integer = DateDiff(DateInterval.Day, fechainicial, FechaHasta)
        If FechaHasta < DateSerial(FechaHasta.Year, fechainicial.Month, fechainicial.Day) Then
            dias = dias - 1
        End If
        Return años + meses / 12 + dias / 365
    End Function
End Module
