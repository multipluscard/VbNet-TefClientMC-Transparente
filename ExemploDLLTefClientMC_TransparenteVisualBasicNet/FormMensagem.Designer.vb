<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMensagem
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMensagem))
        Me.panelMensagem = New System.Windows.Forms.Panel()
        Me.lbMensagem = New System.Windows.Forms.Label()
        Me.txbRecebe = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.iconImag = New System.Windows.Forms.PictureBox()
        Me.panelMensagem.SuspendLayout()
        CType(Me.iconImag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMensagem
        '
        Me.panelMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMensagem.Controls.Add(Me.lbMensagem)
        Me.panelMensagem.Controls.Add(Me.txbRecebe)
        Me.panelMensagem.Controls.Add(Me.btnCancelar)
        Me.panelMensagem.Controls.Add(Me.btnOk)
        Me.panelMensagem.Controls.Add(Me.iconImag)
        Me.panelMensagem.Location = New System.Drawing.Point(12, 12)
        Me.panelMensagem.Name = "panelMensagem"
        Me.panelMensagem.Size = New System.Drawing.Size(479, 251)
        Me.panelMensagem.TabIndex = 2
        '
        'lbMensagem
        '
        Me.lbMensagem.AutoSize = True
        Me.lbMensagem.BackColor = System.Drawing.SystemColors.Control
        Me.lbMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensagem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbMensagem.Location = New System.Drawing.Point(11, 60)
        Me.lbMensagem.Name = "lbMensagem"
        Me.lbMensagem.Size = New System.Drawing.Size(82, 18)
        Me.lbMensagem.TabIndex = 5
        Me.lbMensagem.Text = "Mensagem"
        '
        'txbRecebe
        '
        Me.txbRecebe.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbRecebe.Location = New System.Drawing.Point(15, 208)
        Me.txbRecebe.Name = "txbRecebe"
        Me.txbRecebe.Size = New System.Drawing.Size(444, 26)
        Me.txbRecebe.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancelar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(385, 84)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 37)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(385, 41)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(89, 37)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'iconImag
        '
        Me.iconImag.Image = CType(resources.GetObject("iconImag.Image"), System.Drawing.Image)
        Me.iconImag.Location = New System.Drawing.Point(15, 14)
        Me.iconImag.Name = "iconImag"
        Me.iconImag.Size = New System.Drawing.Size(37, 32)
        Me.iconImag.TabIndex = 0
        Me.iconImag.TabStop = False
        '
        'FormMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 274)
        Me.Controls.Add(Me.panelMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMensagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMensagem"
        Me.panelMensagem.ResumeLayout(False)
        Me.panelMensagem.PerformLayout()
        CType(Me.iconImag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelMensagem As Panel
    Private WithEvents lbMensagem As Label
    Private WithEvents txbRecebe As TextBox
    Private WithEvents btnCancelar As Button
    Private WithEvents btnOk As Button
    Private WithEvents iconImag As PictureBox
End Class
