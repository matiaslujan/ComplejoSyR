Public Class Funciones
    Public Function ValidarCampos(ByVal frm As Form, ByVal errorprovider As ErrorProvider)
        ValidarCampos = True

        Dim control As Control

        Try
            For Each control In frm.Controls

                If control.Tag = "Validar" Then
                    If control.Text = "" Then
                        Throw New Exception("Por favor, ingrese un valor")
                    Else
                        errorprovider.SetError(control, "")

                    End If

                End If

            Next
        Catch ex As Exception

            errorprovider.SetError(control, ex.Message)

            ValidarCampos = False


        End Try

    End Function
End Class
