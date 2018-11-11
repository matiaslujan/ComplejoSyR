Imports CrystalDecisions.Shared

Public Class Impresiones

    Inherits ConexionClass
    'prueba
    Public Sub New()

        Dim miConfiguracion = New ConfiguracionConexion
        servidor = miConfiguracion.servidorSQL
        baseDatos = miConfiguracion.baseDatosSQL
        usuario = miConfiguracion.usuarioSQL
        password = miConfiguracion.passwordSQL

        If password = "" And usuario = "" Then

            intsecurity = True

        End If

    End Sub
    Public Sub Configurar(ByVal objreporte As Object)

        Conectar()

        objreporte.datasourceconnections.item(0).setconnection(servidor, baseDatos, intsecurity)

        objreporte.setdatabaselogon(usuario, password)

        Desconectar()


    End Sub

    Public Sub detallereserva(ByVal frmdetalle As Form, ByVal objreporte As Object, ByVal idreserva As Integer)


        Dim parametros As New parametervalues
        Dim id As New ParameterDiscreteValue
        parametros.Clear()
        id.Value = idreserva
        parametros.Add(id)

        Configurar(objreporte)

        objreporte.datadefinition.parameterfields("@IdReserva").applycurrentvalues(parametros)

        frmdetalle.ShowDialog()
        frmdetalle.Dispose()

    End Sub
    Public Sub listahoy(ByVal frmdetalle As Form, ByVal objreporte As Object, ByVal fechar As Date)


        Dim parametros As New ParameterValues
        Dim fecha As New ParameterDiscreteValue
        parametros.Clear()

        fecha.Value = fechar

        parametros.Add(fecha)

        Configurar(objreporte)

        objreporte.datadefinition.parameterfields("@Fecha").applycurrentvalues(parametros)

        frmdetalle.ShowDialog()
        frmdetalle.Dispose()

    End Sub
End Class
