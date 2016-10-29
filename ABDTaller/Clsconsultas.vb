Imports System.Data.SqlClient
Public Class Clsconsultas
    Public Function buscar_Vehiculo(ByVal dni As String) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexion
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "BUSCAR_VEHICULO"
                    cmd.Parameters.Add("@IDVEHICULO", SqlDbType.Char).Value = dni
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
    'CARGAR COMBO MARCA
    Public Function Cargar_Combo_Marca() As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexion
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "CARGAR_COMBO_MARCA"
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
    'BUSCAR BEHICULO MARCA
    Public Function buscar_Vehiculo_Marca(ByVal idmarca As Integer) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexion
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "BUSCAR_VEHICULO_MARCA_ID"
                    cmd.Parameters.Add("@IDMARCA", SqlDbType.int).Value = IDMARCA
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function

    'BUSCAR VEHICULO LIKE
    Public Function buscar_Vehiculo_Like(ByVal Buscar As String) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexion
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "BUSCAR_VEHICULO_LIKE"
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Buscar
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
End Class
