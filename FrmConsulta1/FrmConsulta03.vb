Public Class FrmConsulta03

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim objbuscar As New ABDTaller.Clsconsultas
        DataGridView1.DataSource = objbuscar.Buscar_Vehiculo_Like(Me.TextBox1.Text.Trim).tables(0)
    End Sub
End Class