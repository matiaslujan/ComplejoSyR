Public Class ConfiguracionConexion
    Private aSettingsReader As New System.Configuration.AppSettingsReader
    Private servidorSQL_ As String
    Private baseDatosSQL_ As String
    Private usuarioSQL_ As String
    Private passwordSQL_ As String


    Public Sub New()


        servidorSQL_ = aSettingsReader.GetValue("servidorSQL", GetType(String))
        baseDatosSQL_ = aSettingsReader.GetValue("baseDatosSQL", GetType(String))
        usuarioSQL_ = aSettingsReader.GetValue("usuarioSQL", GetType(String))
        passwordSQL_ = aSettingsReader.GetValue("passwordSQL", GetType(String))

    End Sub

    Public ReadOnly Property servidorSQL() As String
        Get
            Return servidorSQL_
        End Get
    End Property

    Public ReadOnly Property baseDatosSQL() As String
        Get
            Return baseDatosSQL_
        End Get
    End Property

    Public ReadOnly Property usuarioSQL() As String
        Get
            Return usuarioSQL_
        End Get
    End Property

    Public ReadOnly Property passwordSQL() As String
        Get
            Return passwordSQL_
        End Get
    End Property
End Class
