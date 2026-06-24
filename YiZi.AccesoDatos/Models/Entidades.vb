Public Class Entidades
    <Flags>
    Public Enum enmColumnaRecivo
        Remunerativo = 0
        Descuento = 1
        NoRemunerativo = 2
        DescuentoNoRemunerativo = 3
        Contribuciones = 4
    End Enum

    <Flags>
    Public Enum enmCondicionLiquidacion
        EnConvenio = 0
        FueraDeConvenio = 1
    End Enum
End Class
