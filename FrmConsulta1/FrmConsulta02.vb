Public Class FrmConsulta02
    Private Sub FrmConsulta02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_combo()
    End Sub
    Sub cargar_combo()
        Dim objcargar As New ABDTaller.Clsconsultas
        Dim dt As New DataTable
        dt = objcargar.Cargar_Combo_Marca.Tables(0)
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = dt.Columns(0).ToString
        ComboBox1.DisplayMember = dt.Columns(1).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objbuscar As New ABDTaller.Clsconsultas
        Dim DT As New DataTable
        DT = objbuscar.buscar_Vehiculo_Marca(ComboBox1.SelectedValue).Tables(0)

        If DT.Rows.Count > 0 Then
            DG.DataSource = DT
        End If
    End Sub
End Class