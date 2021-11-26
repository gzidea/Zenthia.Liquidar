Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("TipoLiquidacion")>
Partial Public Class TipoLiquidacion
    Public Sub New()
        Recibos = New HashSet(Of Recibos)()
        FormulaTipoLiquidacion = New HashSet(Of FormulaTipoLiquidacion)()
        RecibosPlantillas = New HashSet(Of RecibosPlantillas)()
        LegajosConeptosParticulares = New HashSet(Of LegajosConceptosParticulares)()
        LegajosNovedades = New HashSet(Of LegajosNovedades)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Descripcion As String

    Public Overridable Property Recibos As ICollection(Of Recibos)

    Public Overridable Property FormulaTipoLiquidacion As ICollection(Of FormulaTipoLiquidacion)

    Public Overridable Property RecibosPlantillas As ICollection(Of RecibosPlantillas)

    Public Overridable Property LegajosConeptosParticulares As ICollection(Of LegajosConceptosParticulares)

    Public Overridable Property LegajosNovedades As ICollection(Of LegajosNovedades)
End Class
