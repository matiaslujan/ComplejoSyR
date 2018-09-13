﻿Imports System.Data.SqlClient
Public Class AlojamientoReservaClass

    Inherits ConexionClass
    Private Id_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private IdReserva_ As Integer

    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property

    Private IdAlojamiento_ As Integer

    Public Property IdAlojamiento() As Integer
        Get
            Return IdAlojamiento_
        End Get
        Set(ByVal value As Integer)
            IdAlojamiento_ = value
        End Set
    End Property
    Private accion_ As String
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Private numero_ As String
    Public Property numero() As String
        Get
            Return numero_
        End Get
        Set(ByVal value As String)
            numero_ = value
        End Set
    End Property
    Private nombre_ As String
    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property
    Private capacidad_ As String
    Public Property capacidad() As String
        Get
            Return capacidad_
        End Get
        Set(ByVal value As String)
            capacidad_ = value
        End Set
    End Property

    Public Sub Actualizar(ByRef lst As List(Of AlojamientoReservaClass))
        Try
            Conectar()

            For Each row In lst

                If row.accion = "Agregar" Then
                 

                    Dim comando As New SqlCommand("AlojResAgregar", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@idalojamiento", row.IdAlojamiento)
                    comando.Parameters.AddWithValue("@idreserva", row.IdReserva)

                    comando.ExecuteNonQuery()

                ElseIf row.accion = "Eliminar" Then

                    Dim comando As New SqlCommand("AlojResEliminar", conexion)

                    comando.CommandType = CommandType.StoredProcedure
                
                    comando.Parameters.AddWithValue("@id", row.Id)

                    comando.ExecuteNonQuery()

                End If

            Next
            Desconectar()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    'trae los alojamientos de una reserva predeterminada

    Public Sub TraerAlojamiento(ByVal id As Integer, ByRef lst As List(Of AlojamientoReservaClass))

        Conectar()

        Dim comando As New SqlCommand("AlojResTraer", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@IdReserva", id)

        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            For Each row In lista

                Dim alojres As New AlojamientoReservaClass

                alojres.Id = (lista("Id"))
                alojres.numero = (lista("Numero"))
                alojres.nombre = (lista("Nombre"))
                alojres.capacidad = (lista("Capacidad"))

                lst.Add(alojres)

            Next

        End If

        Desconectar()

    End Sub

End Class
