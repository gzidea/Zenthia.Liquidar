Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Friend NotInheritable Class Program

    Private Sub New()
    End Sub

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Shared Sub Main()
        SkinManager.EnableFormSkins()
        Application.EnableVisualStyles()
        AplicarTemaGuardado()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmPrincipal())
    End Sub

    Private Shared Sub AplicarTemaGuardado()
        BonusSkins.Register()
        SkinManager.EnableFormSkins()

        Dim skinGuardado As String = My.Settings.TemaSeleccionado
        Dim paletaGuardada As String = My.Settings.PaletaSeleccionada

        If String.IsNullOrEmpty(skinGuardado) Then
            skinGuardado = "WXI"
        End If

        If Not String.IsNullOrEmpty(paletaGuardada) Then
            UserLookAndFeel.Default.SetSkinStyle(skinGuardado, paletaGuardada)
        Else
            UserLookAndFeel.Default.SetSkinStyle(skinGuardado)
        End If
    End Sub
End Class
