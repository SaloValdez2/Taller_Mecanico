Public Class FrmConsulta01

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objbuscar As New ABDTaller.Clsconsultas
        dg.DataSource = objbuscar.buscar_Vehiculo(Me.TextBox1.Text.Trim).Tables(0)
    End Sub
End Class
