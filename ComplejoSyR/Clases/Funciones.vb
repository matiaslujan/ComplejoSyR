Public Class Funciones
    Private Function ValidarCampos(ByVal frm As Form, ByVal errorprovider As ErrorProvider)
        ValidarCampos = True
        'Try
        '    For Each Control As Windows.Forms.Control In frm.Controls

        '        If Control.Tag = "Validar" Then
        '            If Control.Text = "" Then
        '                Throw New Exception("Ingresar datos")
        '            Else
        '                errorprovider.SetError(Control, "")

        '            End If

        '        End If

        '    Next
        'Catch ex As Exception
        '    errorprovider.SetError(Control, ex.mensaje)
        'End Try

    End Function
End Class
