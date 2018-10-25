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
                    If TypeOf control Is ComboBox Then
                        Dim c As ComboBox = control

                        If c.SelectedIndex = -1 Then

                            Throw New Exception("Por favor, seleccione un Tipo")
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

    Public Function ValidarCamposReserva(ByVal Controles As TableLayoutPanel.ControlCollection, ByVal errorprovider As ErrorProvider)
        ValidarCamposReserva = True

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

                    If TypeOf control Is ComboBox Then
                        Dim c As ComboBox = control

                        If c.SelectedIndex = -1 Then

                            Throw New Exception("Por favor, seleccione un cliente")
                        Else

                            errorprovider.SetError(control, "")

                        End If

                    End If

                End If

        
            Catch ex As Exception

                errorprovider.SetError(control, ex.Message)

                ValidarCamposReserva = False


            End Try
        Next
    End Function

    Public Function filanoseleccionada(ByVal dgv As DataGridView) As Boolean

        If dgv.CurrentRow Is Nothing Then

            MsgBox("Seleccione un registro")

            Return True

        Else
            Return False

        End If
    End Function

    Public Sub IngresoSoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then

            e.Handled = False

        Else

            e.Handled = True


        End If


    End Sub
End Class
