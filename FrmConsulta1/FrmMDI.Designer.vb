<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FORMULARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAPORIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAPORMARCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FORMULARIOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(479, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FORMULARIOSToolStripMenuItem
        '
        Me.FORMULARIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAPORIDToolStripMenuItem, Me.CONSULTAPORMARCAToolStripMenuItem})
        Me.FORMULARIOSToolStripMenuItem.Name = "FORMULARIOSToolStripMenuItem"
        Me.FORMULARIOSToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.FORMULARIOSToolStripMenuItem.Text = "FORMULARIOS"
        '
        'CONSULTAPORIDToolStripMenuItem
        '
        Me.CONSULTAPORIDToolStripMenuItem.Name = "CONSULTAPORIDToolStripMenuItem"
        Me.CONSULTAPORIDToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CONSULTAPORIDToolStripMenuItem.Text = "CONSULTA POR ID"
        '
        'CONSULTAPORMARCAToolStripMenuItem
        '
        Me.CONSULTAPORMARCAToolStripMenuItem.Name = "CONSULTAPORMARCAToolStripMenuItem"
        Me.CONSULTAPORMARCAToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CONSULTAPORMARCAToolStripMenuItem.Text = "CONSULTA POR MARCA"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 276)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "FrmMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FORMULARIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTAPORIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTAPORMARCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
