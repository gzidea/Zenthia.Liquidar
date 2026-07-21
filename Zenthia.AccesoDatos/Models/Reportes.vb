Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Enum ProcesoReporte
    ReciboSueldo = 1
    ListadoLegajos = 2
    LiquidacionResumen = 3
End Enum

Public Class Reportes
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Nombre As String

    ' Reemplaza el Codigo string libre por el enum -> consistencia garantizada
    Public Property Proceso As ProcesoReporte

    Public Property LayoutXml As String

    Public Property FechaModificacion As DateTime

    Public Property EsPredeterminado As Boolean

    Public Property Activo As Boolean

    <StringLength(500)>
    Public Property Descripcion As String ' opcional: "Versión resumida para gerencia"
End Class
