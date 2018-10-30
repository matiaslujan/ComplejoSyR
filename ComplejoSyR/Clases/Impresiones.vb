﻿Imports CrystalDecisions.Shared

Public Class Impresiones

    Inherits ConexionClass

    Public Sub Configurar(ByVal objreporte As Object)

        Conectar()

        objreporte.datasourceconnections.item(0).setconnection(servidor, basededatos, intsecurity)

        objreporte.setdatabaselogon(usuario, password)

        Desconectar()


    End Sub

    Public Sub detallereserva(ByVal frmdetalle As Form, ByVal objreporte As Object, ByVal idreserva As Integer)

        Dim parametros As New parametervalues
        Dim id As New ParameterDiscreteValue
        parametros.Clear()
        id.Value = idreserva
        parametros.Add(id)

        objreporte.datadefinition.parameterfields("@IdReserva").applycurrentvalues(parametros)

        frmdetalle.ShowDialog()
        frmdetalle.Dispose()

    End Sub
    Public Sub seretiranhoy(ByVal frmdetalle As Form, ByVal objreporte As Object, ByVal fechar As Date)

        Dim parametros As New ParameterValues
        Dim fecha As New ParameterDiscreteValue
        parametros.Clear()
        fecha.Value = fechar
        parametros.Add(fecha)

        objreporte.datadefinition.parameterfields("@Fecha").applycurrentvalues(parametros)

        frmdetalle.ShowDialog()
        frmdetalle.Dispose()

    End Sub
End Class