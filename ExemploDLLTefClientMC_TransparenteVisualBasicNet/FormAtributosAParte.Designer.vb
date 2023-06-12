<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAtributosAParte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAtributosAParte))
        Me.panelAtribultosAParte = New System.Windows.Forms.Panel()
        Me.txbPDV = New System.Windows.Forms.TextBox()
        Me.lbPdv = New System.Windows.Forms.Label()
        Me.txbCodLoja = New System.Windows.Forms.TextBox()
        Me.txbCnpj = New System.Windows.Forms.TextBox()
        Me.txbData = New System.Windows.Forms.TextBox()
        Me.txbComunicacao = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbCodigoLoja = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.lbCnpj = New System.Windows.Forms.Label()
        Me.lbComunicacao = New System.Windows.Forms.Label()
        Me.panelAtribultosAParte.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelAtribultosAParte
        '
        Me.panelAtribultosAParte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAtribultosAParte.Controls.Add(Me.txbPDV)
        Me.panelAtribultosAParte.Controls.Add(Me.lbPdv)
        Me.panelAtribultosAParte.Controls.Add(Me.txbCodLoja)
        Me.panelAtribultosAParte.Controls.Add(Me.txbCnpj)
        Me.panelAtribultosAParte.Controls.Add(Me.txbData)
        Me.panelAtribultosAParte.Controls.Add(Me.txbComunicacao)
        Me.panelAtribultosAParte.Controls.Add(Me.pictureBox1)
        Me.panelAtribultosAParte.Controls.Add(Me.lbCodigoLoja)
        Me.panelAtribultosAParte.Controls.Add(Me.lbData)
        Me.panelAtribultosAParte.Controls.Add(Me.lbCnpj)
        Me.panelAtribultosAParte.Controls.Add(Me.lbComunicacao)
        Me.panelAtribultosAParte.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAtribultosAParte.Location = New System.Drawing.Point(12, 6)
        Me.panelAtribultosAParte.Name = "panelAtribultosAParte"
        Me.panelAtribultosAParte.Size = New System.Drawing.Size(232, 393)
        Me.panelAtribultosAParte.TabIndex = 1
        '
        'txbPDV
        '
        Me.txbPDV.Location = New System.Drawing.Point(17, 341)
        Me.txbPDV.Name = "txbPDV"
        Me.txbPDV.Size = New System.Drawing.Size(191, 26)
        Me.txbPDV.TabIndex = 13
        '
        'lbPdv
        '
        Me.lbPdv.AutoSize = True
        Me.lbPdv.Location = New System.Drawing.Point(13, 318)
        Me.lbPdv.Name = "lbPdv"
        Me.lbPdv.Size = New System.Drawing.Size(36, 20)
        Me.lbPdv.TabIndex = 12
        Me.lbPdv.Text = "PDV"
        '
        'txbCodLoja
        '
        Me.txbCodLoja.Location = New System.Drawing.Point(17, 211)
        Me.txbCodLoja.Name = "txbCodLoja"
        Me.txbCodLoja.Size = New System.Drawing.Size(191, 26)
        Me.txbCodLoja.TabIndex = 11
        '
        'txbCnpj
        '
        Me.txbCnpj.Location = New System.Drawing.Point(17, 143)
        Me.txbCnpj.Name = "txbCnpj"
        Me.txbCnpj.Size = New System.Drawing.Size(191, 26)
        Me.txbCnpj.TabIndex = 10
        '
        'txbData
        '
        Me.txbData.Location = New System.Drawing.Point(17, 276)
        Me.txbData.Name = "txbData"
        Me.txbData.Size = New System.Drawing.Size(191, 26)
        Me.txbData.TabIndex = 8
        '
        'txbComunicacao
        '
        Me.txbComunicacao.Location = New System.Drawing.Point(17, 78)
        Me.txbComunicacao.Name = "txbComunicacao"
        Me.txbComunicacao.Size = New System.Drawing.Size(191, 26)
        Me.txbComunicacao.TabIndex = 7
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(39, 37)
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'lbCodigoLoja
        '
        Me.lbCodigoLoja.AutoSize = True
        Me.lbCodigoLoja.Location = New System.Drawing.Point(13, 186)
        Me.lbCodigoLoja.Name = "lbCodigoLoja"
        Me.lbCodigoLoja.Size = New System.Drawing.Size(74, 20)
        Me.lbCodigoLoja.TabIndex = 5
        Me.lbCodigoLoja.Text = "COD LOJA"
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbData.Location = New System.Drawing.Point(13, 253)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(43, 20)
        Me.lbData.TabIndex = 3
        Me.lbData.Text = "DATA"
        '
        'lbCnpj
        '
        Me.lbCnpj.AutoSize = True
        Me.lbCnpj.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCnpj.Location = New System.Drawing.Point(13, 120)
        Me.lbCnpj.Name = "lbCnpj"
        Me.lbCnpj.Size = New System.Drawing.Size(43, 20)
        Me.lbCnpj.TabIndex = 2
        Me.lbCnpj.Text = "CNPJ"
        '
        'lbComunicacao
        '
        Me.lbComunicacao.AutoSize = True
        Me.lbComunicacao.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComunicacao.Location = New System.Drawing.Point(13, 55)
        Me.lbComunicacao.Name = "lbComunicacao"
        Me.lbComunicacao.Size = New System.Drawing.Size(106, 20)
        Me.lbComunicacao.TabIndex = 0
        Me.lbComunicacao.Text = "COMUNICAÇÃO"
        '
        'FormAtributosAParte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 404)
        Me.Controls.Add(Me.panelAtribultosAParte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAtributosAParte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelAtribultosAParte.ResumeLayout(False)
        Me.panelAtribultosAParte.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelAtribultosAParte As Panel
    Private WithEvents txbPDV As TextBox
    Private WithEvents lbPdv As Label
    Private WithEvents txbCodLoja As TextBox
    Private WithEvents txbCnpj As TextBox
    Private WithEvents txbData As TextBox
    Private WithEvents txbComunicacao As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lbCodigoLoja As Label
    Private WithEvents lbData As Label
    Private WithEvents lbCnpj As Label
    Private WithEvents lbComunicacao As Label
End Class
