Public Class Funciones
    Public Function ValidarCampos(ByVal Controles As Form.ControlCollection, ByVal errorprovider As ErrorProvider)
        ValidarCampos = True

        Dim control As Control

        'recorrer controles y verificar el ingreso de datos
        For Each control In Controles

            Try



                If control.Tag = "Validar" Then
                    If TypeOf control Is TextBox Then
                        If control.Text = "" Then
                            Throw New Exception("Por favor, ingrese un valor")
                        Else
                            errorprovider.SetError(control, "")

                        End If

                    End If
                End If
            Catch ex As Exception

                errorprovider.SetError(control, ex.Message)

                ValidarCampos = False


            End Try
        Next
    End Function

    Public Function ValidarCampos(ByVal Controles As TableLayoutPanel.ControlCollection, ByVal errorprovider As ErrorProvider)
        ValidarCampos = True

        Dim control As Control

        'recorrer controles y verificar el ingreso de datos
        For Each control In Controles

            Try



                If control.Tag = "Validar" Then
                    If TypeOf control Is TextBox Then
                        If control.Text = "" Then
                            Throw New Exception("Por favor, ingrese un valor")
                        Else
                            errorprovider.SetError(control, "")

                        End If

                    End If
                End If
            Catch ex As Exception

                errorprovider.SetError(control, ex.Message)

                ValidarCampos = False


            End Try
        Next
    End Function
End Class
