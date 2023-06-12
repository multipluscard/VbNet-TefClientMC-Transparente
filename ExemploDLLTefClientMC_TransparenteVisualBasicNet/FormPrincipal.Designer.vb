<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.checkBoxMultiplosCartoes = New System.Windows.Forms.CheckBox()
        Me.btnLimpaLog = New System.Windows.Forms.Button()
        Me.btnAtributosAParte = New System.Windows.Forms.Button()
        Me.panelAtributos = New System.Windows.Forms.Panel()
        Me.lbNsu = New System.Windows.Forms.Label()
        Me.lbCupom = New System.Windows.Forms.Label()
        Me.lbParcela = New System.Windows.Forms.Label()
        Me.txbNsu = New System.Windows.Forms.TextBox()
        Me.txbParcela = New System.Windows.Forms.TextBox()
        Me.txbCupom = New System.Windows.Forms.TextBox()
        Me.txbValor = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelTransacoes = New System.Windows.Forms.Panel()
        Me.checkBoxTodas = New System.Windows.Forms.CheckBox()
        Me.lbTransacoes = New System.Windows.Forms.Label()
        Me.btnDesfaz = New System.Windows.Forms.Button()
        Me.tansacoespendentes = New System.Windows.Forms.ListBox()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.tabTipo = New System.Windows.Forms.TabControl()
        Me.tabPageCartao = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tabCreditoDebito = New System.Windows.Forms.TabControl()
        Me.tabCredito = New System.Windows.Forms.TabPage()
        Me.btnCancPreAutorizacao = New System.Windows.Forms.Button()
        Me.btnConfPreAutorizacao = New System.Windows.Forms.Button()
        Me.btnPreAutorizacao = New System.Windows.Forms.Button()
        Me.btnConsultaCredito = New System.Windows.Forms.Button()
        Me.btnCreditoParceladoAdm = New System.Windows.Forms.Button()
        Me.btnCreditoParceladoLoja = New System.Windows.Forms.Button()
        Me.btnCredito = New System.Windows.Forms.Button()
        Me.btnCreditoAVista = New System.Windows.Forms.Button()
        Me.tabDebito = New System.Windows.Forms.TabPage()
        Me.btnConsultaDebito = New System.Windows.Forms.Button()
        Me.btnDebitoAVista = New System.Windows.Forms.Button()
        Me.btnDebito = New System.Windows.Forms.Button()
        Me.tabFrota = New System.Windows.Forms.TabPage()
        Me.btnVendaFrota = New System.Windows.Forms.Button()
        Me.tabVoucher = New System.Windows.Forms.TabPage()
        Me.btnVendaVoucher = New System.Windows.Forms.Button()
        Me.lbCorOrientacaoCartao = New System.Windows.Forms.Label()
        Me.tabPageADM = New System.Windows.Forms.TabPage()
        Me.btnColetaCpf = New System.Windows.Forms.Button()
        Me.btnReimpressao = New System.Windows.Forms.Button()
        Me.btnExcluirBins = New System.Windows.Forms.Button()
        Me.lbCorOrientacaoClient = New System.Windows.Forms.Label()
        Me.tabPageQrMultiplos = New System.Windows.Forms.TabPage()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lbCorOrientacaoQrmultiplos = New System.Windows.Forms.Label()
        Me.btnStatusTransacao = New System.Windows.Forms.Button()
        Me.btnCancelarEstornoQR = New System.Windows.Forms.Button()
        Me.btnMercadoPago = New System.Windows.Forms.Button()
        Me.btnPicPay = New System.Windows.Forms.Button()
        Me.btnPSPClient = New System.Windows.Forms.Button()
        Me.btnMenuPSP = New System.Windows.Forms.Button()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelAtributos.SuspendLayout()
        Me.panelTransacoes.SuspendLayout()
        Me.tabTipo.SuspendLayout()
        Me.tabPageCartao.SuspendLayout()
        Me.tabCreditoDebito.SuspendLayout()
        Me.tabCredito.SuspendLayout()
        Me.tabDebito.SuspendLayout()
        Me.tabFrota.SuspendLayout()
        Me.tabVoucher.SuspendLayout()
        Me.tabPageADM.SuspendLayout()
        Me.tabPageQrMultiplos.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkBoxMultiplosCartoes
        '
        Me.checkBoxMultiplosCartoes.AutoSize = True
        Me.checkBoxMultiplosCartoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.checkBoxMultiplosCartoes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxMultiplosCartoes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.checkBoxMultiplosCartoes.Location = New System.Drawing.Point(396, 140)
        Me.checkBoxMultiplosCartoes.Name = "checkBoxMultiplosCartoes"
        Me.checkBoxMultiplosCartoes.Size = New System.Drawing.Size(152, 19)
        Me.checkBoxMultiplosCartoes.TabIndex = 56
        Me.checkBoxMultiplosCartoes.Text = "MULTIPLOS CARTÕES"
        Me.checkBoxMultiplosCartoes.UseVisualStyleBackColor = False
        '
        'btnLimpaLog
        '
        Me.btnLimpaLog.Image = CType(resources.GetObject("btnLimpaLog.Image"), System.Drawing.Image)
        Me.btnLimpaLog.Location = New System.Drawing.Point(806, 7)
        Me.btnLimpaLog.Name = "btnLimpaLog"
        Me.btnLimpaLog.Size = New System.Drawing.Size(28, 28)
        Me.btnLimpaLog.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.btnLimpaLog, "Limpar log de eventos na tela")
        Me.btnLimpaLog.UseVisualStyleBackColor = True
        '
        'btnAtributosAParte
        '
        Me.btnAtributosAParte.Image = CType(resources.GetObject("btnAtributosAParte.Image"), System.Drawing.Image)
        Me.btnAtributosAParte.Location = New System.Drawing.Point(840, 7)
        Me.btnAtributosAParte.Name = "btnAtributosAParte"
        Me.btnAtributosAParte.Size = New System.Drawing.Size(28, 28)
        Me.btnAtributosAParte.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.btnAtributosAParte, "Configurações do PDV")
        Me.btnAtributosAParte.UseVisualStyleBackColor = True
        '
        'panelAtributos
        '
        Me.panelAtributos.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.panelAtributos.Controls.Add(Me.lbNsu)
        Me.panelAtributos.Controls.Add(Me.lbCupom)
        Me.panelAtributos.Controls.Add(Me.lbParcela)
        Me.panelAtributos.Controls.Add(Me.txbNsu)
        Me.panelAtributos.Controls.Add(Me.txbParcela)
        Me.panelAtributos.Controls.Add(Me.txbCupom)
        Me.panelAtributos.Controls.Add(Me.txbValor)
        Me.panelAtributos.Controls.Add(Me.label1)
        Me.panelAtributos.Location = New System.Drawing.Point(13, 37)
        Me.panelAtributos.Name = "panelAtributos"
        Me.panelAtributos.Size = New System.Drawing.Size(535, 97)
        Me.panelAtributos.TabIndex = 53
        '
        'lbNsu
        '
        Me.lbNsu.AutoSize = True
        Me.lbNsu.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNsu.Location = New System.Drawing.Point(408, 26)
        Me.lbNsu.Name = "lbNsu"
        Me.lbNsu.Size = New System.Drawing.Size(31, 16)
        Me.lbNsu.TabIndex = 7
        Me.lbNsu.Text = "NSU"
        '
        'lbCupom
        '
        Me.lbCupom.AutoSize = True
        Me.lbCupom.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCupom.Location = New System.Drawing.Point(272, 26)
        Me.lbCupom.Name = "lbCupom"
        Me.lbCupom.Size = New System.Drawing.Size(48, 16)
        Me.lbCupom.TabIndex = 6
        Me.lbCupom.Text = "CUPOM"
        '
        'lbParcela
        '
        Me.lbParcela.AutoSize = True
        Me.lbParcela.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParcela.Location = New System.Drawing.Point(136, 26)
        Me.lbParcela.Name = "lbParcela"
        Me.lbParcela.Size = New System.Drawing.Size(58, 16)
        Me.lbParcela.TabIndex = 5
        Me.lbParcela.Text = "PARCELA"
        '
        'txbNsu
        '
        Me.txbNsu.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNsu.Location = New System.Drawing.Point(411, 45)
        Me.txbNsu.Name = "txbNsu"
        Me.txbNsu.Size = New System.Drawing.Size(117, 22)
        Me.txbNsu.TabIndex = 4
        '
        'txbParcela
        '
        Me.txbParcela.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbParcela.Location = New System.Drawing.Point(139, 45)
        Me.txbParcela.Name = "txbParcela"
        Me.txbParcela.Size = New System.Drawing.Size(118, 22)
        Me.txbParcela.TabIndex = 3
        '
        'txbCupom
        '
        Me.txbCupom.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCupom.Location = New System.Drawing.Point(275, 45)
        Me.txbCupom.Name = "txbCupom"
        Me.txbCupom.Size = New System.Drawing.Size(117, 22)
        Me.txbCupom.TabIndex = 2
        '
        'txbValor
        '
        Me.txbValor.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbValor.Location = New System.Drawing.Point(6, 45)
        Me.txbValor.Name = "txbValor"
        Me.txbValor.Size = New System.Drawing.Size(117, 22)
        Me.txbValor.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(7, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "VALOR"
        '
        'panelTransacoes
        '
        Me.panelTransacoes.Controls.Add(Me.checkBoxTodas)
        Me.panelTransacoes.Controls.Add(Me.lbTransacoes)
        Me.panelTransacoes.Controls.Add(Me.btnDesfaz)
        Me.panelTransacoes.Controls.Add(Me.tansacoespendentes)
        Me.panelTransacoes.Controls.Add(Me.btnConfirma)
        Me.panelTransacoes.Location = New System.Drawing.Point(554, 384)
        Me.panelTransacoes.Name = "panelTransacoes"
        Me.panelTransacoes.Size = New System.Drawing.Size(314, 199)
        Me.panelTransacoes.TabIndex = 57
        Me.panelTransacoes.Visible = False
        '
        'checkBoxTodas
        '
        Me.checkBoxTodas.AutoSize = True
        Me.checkBoxTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxTodas.Location = New System.Drawing.Point(251, 161)
        Me.checkBoxTodas.Name = "checkBoxTodas"
        Me.checkBoxTodas.Size = New System.Drawing.Size(60, 19)
        Me.checkBoxTodas.TabIndex = 49
        Me.checkBoxTodas.Text = "Todas"
        Me.checkBoxTodas.UseVisualStyleBackColor = True
        '
        'lbTransacoes
        '
        Me.lbTransacoes.AutoSize = True
        Me.lbTransacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransacoes.Location = New System.Drawing.Point(3, 12)
        Me.lbTransacoes.Name = "lbTransacoes"
        Me.lbTransacoes.Size = New System.Drawing.Size(81, 16)
        Me.lbTransacoes.TabIndex = 47
        Me.lbTransacoes.Text = "Transações"
        '
        'btnDesfaz
        '
        Me.btnDesfaz.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesfaz.Location = New System.Drawing.Point(129, 153)
        Me.btnDesfaz.Name = "btnDesfaz"
        Me.btnDesfaz.Size = New System.Drawing.Size(119, 35)
        Me.btnDesfaz.TabIndex = 48
        Me.btnDesfaz.Text = "DESFAZ"
        Me.btnDesfaz.UseVisualStyleBackColor = True
        '
        'tansacoespendentes
        '
        Me.tansacoespendentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.tansacoespendentes.FormattingEnabled = True
        Me.tansacoespendentes.Location = New System.Drawing.Point(6, 31)
        Me.tansacoespendentes.Name = "tansacoespendentes"
        Me.tansacoespendentes.Size = New System.Drawing.Size(302, 121)
        Me.tansacoespendentes.TabIndex = 46
        '
        'btnConfirma
        '
        Me.btnConfirma.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirma.Location = New System.Drawing.Point(6, 153)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(119, 35)
        Me.btnConfirma.TabIndex = 48
        Me.btnConfirma.Text = "CONFIRMA"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'tabTipo
        '
        Me.tabTipo.Controls.Add(Me.tabPageCartao)
        Me.tabTipo.Controls.Add(Me.tabPageADM)
        Me.tabTipo.Controls.Add(Me.tabPageQrMultiplos)
        Me.tabTipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTipo.HotTrack = True
        Me.tabTipo.ItemSize = New System.Drawing.Size(90, 45)
        Me.tabTipo.Location = New System.Drawing.Point(9, 168)
        Me.tabTipo.Multiline = True
        Me.tabTipo.Name = "tabTipo"
        Me.tabTipo.Padding = New System.Drawing.Point(6, 5)
        Me.tabTipo.SelectedIndex = 0
        Me.tabTipo.Size = New System.Drawing.Size(539, 419)
        Me.tabTipo.TabIndex = 52
        '
        'tabPageCartao
        '
        Me.tabPageCartao.Controls.Add(Me.btnCancelar)
        Me.tabPageCartao.Controls.Add(Me.tabCreditoDebito)
        Me.tabPageCartao.Controls.Add(Me.lbCorOrientacaoCartao)
        Me.tabPageCartao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageCartao.Location = New System.Drawing.Point(4, 49)
        Me.tabPageCartao.Name = "tabPageCartao"
        Me.tabPageCartao.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCartao.Size = New System.Drawing.Size(531, 366)
        Me.tabPageCartao.TabIndex = 0
        Me.tabPageCartao.Text = "CARTÃO"
        Me.tabPageCartao.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.Location = New System.Drawing.Point(6, 331)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 29)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'tabCreditoDebito
        '
        Me.tabCreditoDebito.Controls.Add(Me.tabCredito)
        Me.tabCreditoDebito.Controls.Add(Me.tabDebito)
        Me.tabCreditoDebito.Controls.Add(Me.tabFrota)
        Me.tabCreditoDebito.Controls.Add(Me.tabVoucher)
        Me.tabCreditoDebito.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tabCreditoDebito.Location = New System.Drawing.Point(6, 6)
        Me.tabCreditoDebito.Name = "tabCreditoDebito"
        Me.tabCreditoDebito.SelectedIndex = 0
        Me.tabCreditoDebito.Size = New System.Drawing.Size(519, 322)
        Me.tabCreditoDebito.TabIndex = 9
        '
        'tabCredito
        '
        Me.tabCredito.Controls.Add(Me.btnCancPreAutorizacao)
        Me.tabCredito.Controls.Add(Me.btnConfPreAutorizacao)
        Me.tabCredito.Controls.Add(Me.btnPreAutorizacao)
        Me.tabCredito.Controls.Add(Me.btnConsultaCredito)
        Me.tabCredito.Controls.Add(Me.btnCreditoParceladoAdm)
        Me.tabCredito.Controls.Add(Me.btnCreditoParceladoLoja)
        Me.tabCredito.Controls.Add(Me.btnCredito)
        Me.tabCredito.Controls.Add(Me.btnCreditoAVista)
        Me.tabCredito.Location = New System.Drawing.Point(4, 25)
        Me.tabCredito.Name = "tabCredito"
        Me.tabCredito.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCredito.Size = New System.Drawing.Size(511, 293)
        Me.tabCredito.TabIndex = 1
        Me.tabCredito.Text = "CREDITO"
        Me.tabCredito.UseVisualStyleBackColor = True
        '
        'btnCancPreAutorizacao
        '
        Me.btnCancPreAutorizacao.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancPreAutorizacao.Location = New System.Drawing.Point(360, 252)
        Me.btnCancPreAutorizacao.Name = "btnCancPreAutorizacao"
        Me.btnCancPreAutorizacao.Size = New System.Drawing.Size(142, 32)
        Me.btnCancPreAutorizacao.TabIndex = 41
        Me.btnCancPreAutorizacao.Text = "CANC. PRÉ-AUTORIZAÇÃO"
        Me.btnCancPreAutorizacao.UseVisualStyleBackColor = True
        '
        'btnConfPreAutorizacao
        '
        Me.btnConfPreAutorizacao.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfPreAutorizacao.Location = New System.Drawing.Point(213, 252)
        Me.btnConfPreAutorizacao.Name = "btnConfPreAutorizacao"
        Me.btnConfPreAutorizacao.Size = New System.Drawing.Size(141, 32)
        Me.btnConfPreAutorizacao.TabIndex = 40
        Me.btnConfPreAutorizacao.Text = "CONF. PRÉ-AUTORIZAÇÃO"
        Me.btnConfPreAutorizacao.UseVisualStyleBackColor = True
        '
        'btnPreAutorizacao
        '
        Me.btnPreAutorizacao.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreAutorizacao.Location = New System.Drawing.Point(91, 252)
        Me.btnPreAutorizacao.Name = "btnPreAutorizacao"
        Me.btnPreAutorizacao.Size = New System.Drawing.Size(116, 32)
        Me.btnPreAutorizacao.TabIndex = 39
        Me.btnPreAutorizacao.Text = "PRÉ-AUTORIZAÇÃO"
        Me.btnPreAutorizacao.UseVisualStyleBackColor = True
        '
        'btnConsultaCredito
        '
        Me.btnConsultaCredito.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaCredito.Location = New System.Drawing.Point(10, 252)
        Me.btnConsultaCredito.Name = "btnConsultaCredito"
        Me.btnConsultaCredito.Size = New System.Drawing.Size(75, 32)
        Me.btnConsultaCredito.TabIndex = 38
        Me.btnConsultaCredito.Text = "CONSULTA"
        Me.btnConsultaCredito.UseVisualStyleBackColor = True
        '
        'btnCreditoParceladoAdm
        '
        Me.btnCreditoParceladoAdm.Location = New System.Drawing.Point(22, 184)
        Me.btnCreditoParceladoAdm.Name = "btnCreditoParceladoAdm"
        Me.btnCreditoParceladoAdm.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoParceladoAdm.TabIndex = 37
        Me.btnCreditoParceladoAdm.Text = "CRÉDITO PARCELADO ADM"
        Me.btnCreditoParceladoAdm.UseVisualStyleBackColor = True
        '
        'btnCreditoParceladoLoja
        '
        Me.btnCreditoParceladoLoja.Location = New System.Drawing.Point(22, 132)
        Me.btnCreditoParceladoLoja.Name = "btnCreditoParceladoLoja"
        Me.btnCreditoParceladoLoja.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoParceladoLoja.TabIndex = 36
        Me.btnCreditoParceladoLoja.Text = "CRÉDITO PARCELADO LOJA"
        Me.btnCreditoParceladoLoja.UseVisualStyleBackColor = True
        '
        'btnCredito
        '
        Me.btnCredito.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredito.Location = New System.Drawing.Point(22, 28)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(170, 46)
        Me.btnCredito.TabIndex = 35
        Me.btnCredito.Text = "CRÉDITO "
        Me.btnCredito.UseVisualStyleBackColor = True
        '
        'btnCreditoAVista
        '
        Me.btnCreditoAVista.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditoAVista.Location = New System.Drawing.Point(22, 80)
        Me.btnCreditoAVista.Name = "btnCreditoAVista"
        Me.btnCreditoAVista.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoAVista.TabIndex = 34
        Me.btnCreditoAVista.Text = "CRÉDITO A VISTA"
        Me.btnCreditoAVista.UseVisualStyleBackColor = True
        '
        'tabDebito
        '
        Me.tabDebito.Controls.Add(Me.btnConsultaDebito)
        Me.tabDebito.Controls.Add(Me.btnDebitoAVista)
        Me.tabDebito.Controls.Add(Me.btnDebito)
        Me.tabDebito.Location = New System.Drawing.Point(4, 25)
        Me.tabDebito.Name = "tabDebito"
        Me.tabDebito.Size = New System.Drawing.Size(511, 293)
        Me.tabDebito.TabIndex = 2
        Me.tabDebito.Text = "DEBITO"
        Me.tabDebito.UseVisualStyleBackColor = True
        '
        'btnConsultaDebito
        '
        Me.btnConsultaDebito.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnConsultaDebito.Location = New System.Drawing.Point(10, 252)
        Me.btnConsultaDebito.Name = "btnConsultaDebito"
        Me.btnConsultaDebito.Size = New System.Drawing.Size(75, 32)
        Me.btnConsultaDebito.TabIndex = 25
        Me.btnConsultaDebito.Text = "CONSULTA"
        Me.btnConsultaDebito.UseVisualStyleBackColor = True
        '
        'btnDebitoAVista
        '
        Me.btnDebitoAVista.Location = New System.Drawing.Point(22, 80)
        Me.btnDebitoAVista.Name = "btnDebitoAVista"
        Me.btnDebitoAVista.Size = New System.Drawing.Size(170, 46)
        Me.btnDebitoAVista.TabIndex = 24
        Me.btnDebitoAVista.Text = "DÉBITO A VISTA"
        Me.btnDebitoAVista.UseVisualStyleBackColor = True
        '
        'btnDebito
        '
        Me.btnDebito.Location = New System.Drawing.Point(22, 28)
        Me.btnDebito.Name = "btnDebito"
        Me.btnDebito.Size = New System.Drawing.Size(170, 46)
        Me.btnDebito.TabIndex = 24
        Me.btnDebito.Text = "DÉBITO"
        Me.btnDebito.UseVisualStyleBackColor = True
        '
        'tabFrota
        '
        Me.tabFrota.Controls.Add(Me.btnVendaFrota)
        Me.tabFrota.Location = New System.Drawing.Point(4, 25)
        Me.tabFrota.Name = "tabFrota"
        Me.tabFrota.Size = New System.Drawing.Size(511, 293)
        Me.tabFrota.TabIndex = 3
        Me.tabFrota.Text = "FROTA"
        Me.tabFrota.UseVisualStyleBackColor = True
        '
        'btnVendaFrota
        '
        Me.btnVendaFrota.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVendaFrota.Location = New System.Drawing.Point(22, 28)
        Me.btnVendaFrota.Name = "btnVendaFrota"
        Me.btnVendaFrota.Size = New System.Drawing.Size(170, 46)
        Me.btnVendaFrota.TabIndex = 44
        Me.btnVendaFrota.Text = "VENDA FROTA"
        Me.btnVendaFrota.UseVisualStyleBackColor = True
        '
        'tabVoucher
        '
        Me.tabVoucher.Controls.Add(Me.btnVendaVoucher)
        Me.tabVoucher.Location = New System.Drawing.Point(4, 25)
        Me.tabVoucher.Name = "tabVoucher"
        Me.tabVoucher.Size = New System.Drawing.Size(511, 293)
        Me.tabVoucher.TabIndex = 4
        Me.tabVoucher.Text = "VOUCHER"
        Me.tabVoucher.UseVisualStyleBackColor = True
        '
        'btnVendaVoucher
        '
        Me.btnVendaVoucher.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVendaVoucher.Location = New System.Drawing.Point(22, 28)
        Me.btnVendaVoucher.Name = "btnVendaVoucher"
        Me.btnVendaVoucher.Size = New System.Drawing.Size(170, 46)
        Me.btnVendaVoucher.TabIndex = 0
        Me.btnVendaVoucher.Text = "VENDA VOUCHER"
        Me.btnVendaVoucher.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoCartao
        '
        Me.lbCorOrientacaoCartao.AutoSize = True
        Me.lbCorOrientacaoCartao.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCorOrientacaoCartao.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoCartao.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbCorOrientacaoCartao.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoCartao.Name = "lbCorOrientacaoCartao"
        Me.lbCorOrientacaoCartao.Size = New System.Drawing.Size(589, 7)
        Me.lbCorOrientacaoCartao.TabIndex = 39
        Me.lbCorOrientacaoCartao.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabPageADM
        '
        Me.tabPageADM.Controls.Add(Me.btnColetaCpf)
        Me.tabPageADM.Controls.Add(Me.btnReimpressao)
        Me.tabPageADM.Controls.Add(Me.btnExcluirBins)
        Me.tabPageADM.Controls.Add(Me.lbCorOrientacaoClient)
        Me.tabPageADM.Location = New System.Drawing.Point(4, 49)
        Me.tabPageADM.Name = "tabPageADM"
        Me.tabPageADM.Size = New System.Drawing.Size(531, 366)
        Me.tabPageADM.TabIndex = 3
        Me.tabPageADM.Text = "ADMINISTRAÇÃO"
        Me.tabPageADM.UseVisualStyleBackColor = True
        '
        'btnColetaCpf
        '
        Me.btnColetaCpf.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnColetaCpf.Location = New System.Drawing.Point(22, 132)
        Me.btnColetaCpf.Name = "btnColetaCpf"
        Me.btnColetaCpf.Size = New System.Drawing.Size(170, 46)
        Me.btnColetaCpf.TabIndex = 43
        Me.btnColetaCpf.Text = "COLETA DE CPF"
        Me.btnColetaCpf.UseVisualStyleBackColor = True
        '
        'btnReimpressao
        '
        Me.btnReimpressao.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReimpressao.Location = New System.Drawing.Point(23, 80)
        Me.btnReimpressao.Name = "btnReimpressao"
        Me.btnReimpressao.Size = New System.Drawing.Size(170, 46)
        Me.btnReimpressao.TabIndex = 42
        Me.btnReimpressao.Text = "REIMPRESSAO"
        Me.btnReimpressao.UseVisualStyleBackColor = True
        '
        'btnExcluirBins
        '
        Me.btnExcluirBins.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExcluirBins.Location = New System.Drawing.Point(22, 28)
        Me.btnExcluirBins.Name = "btnExcluirBins"
        Me.btnExcluirBins.Size = New System.Drawing.Size(170, 46)
        Me.btnExcluirBins.TabIndex = 41
        Me.btnExcluirBins.Text = "EXCLUIR BINS"
        Me.btnExcluirBins.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoClient
        '
        Me.lbCorOrientacaoClient.AutoSize = True
        Me.lbCorOrientacaoClient.BackColor = System.Drawing.Color.Salmon
        Me.lbCorOrientacaoClient.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoClient.ForeColor = System.Drawing.Color.Salmon
        Me.lbCorOrientacaoClient.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoClient.Name = "lbCorOrientacaoClient"
        Me.lbCorOrientacaoClient.Size = New System.Drawing.Size(582, 7)
        Me.lbCorOrientacaoClient.TabIndex = 40
        Me.lbCorOrientacaoClient.Text = "xxxXXXXXXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxx"
        '
        'tabPageQrMultiplos
        '
        Me.tabPageQrMultiplos.Controls.Add(Me.label2)
        Me.tabPageQrMultiplos.Controls.Add(Me.lbCorOrientacaoQrmultiplos)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnStatusTransacao)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnCancelarEstornoQR)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnMercadoPago)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnPicPay)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnPSPClient)
        Me.tabPageQrMultiplos.Controls.Add(Me.btnMenuPSP)
        Me.tabPageQrMultiplos.Location = New System.Drawing.Point(4, 49)
        Me.tabPageQrMultiplos.Name = "tabPageQrMultiplos"
        Me.tabPageQrMultiplos.Size = New System.Drawing.Size(531, 366)
        Me.tabPageQrMultiplos.TabIndex = 4
        Me.tabPageQrMultiplos.Text = "QRMULTIPLUS"
        Me.tabPageQrMultiplos.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(7, 323)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(337, 32)
        Me.label2.TabIndex = 42
        Me.label2.Text = "Obs: Para visualizar o QR Code utilizar o parâmetro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ExibirQrCode=2  no CliMC.ini" &
    ""
        '
        'lbCorOrientacaoQrmultiplos
        '
        Me.lbCorOrientacaoQrmultiplos.AutoSize = True
        Me.lbCorOrientacaoQrmultiplos.BackColor = System.Drawing.Color.Red
        Me.lbCorOrientacaoQrmultiplos.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoQrmultiplos.ForeColor = System.Drawing.Color.Blue
        Me.lbCorOrientacaoQrmultiplos.Location = New System.Drawing.Point(-17, -4)
        Me.lbCorOrientacaoQrmultiplos.Name = "lbCorOrientacaoQrmultiplos"
        Me.lbCorOrientacaoQrmultiplos.Size = New System.Drawing.Size(582, 7)
        Me.lbCorOrientacaoQrmultiplos.TabIndex = 41
        Me.lbCorOrientacaoQrmultiplos.Text = "xxxXXXXXXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxx"
        '
        'btnStatusTransacao
        '
        Me.btnStatusTransacao.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnStatusTransacao.Location = New System.Drawing.Point(141, 252)
        Me.btnStatusTransacao.Name = "btnStatusTransacao"
        Me.btnStatusTransacao.Size = New System.Drawing.Size(116, 32)
        Me.btnStatusTransacao.TabIndex = 5
        Me.btnStatusTransacao.Text = "STATUS TRANSAÇÃO"
        Me.btnStatusTransacao.UseVisualStyleBackColor = True
        '
        'btnCancelarEstornoQR
        '
        Me.btnCancelarEstornoQR.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarEstornoQR.Location = New System.Drawing.Point(10, 252)
        Me.btnCancelarEstornoQR.Name = "btnCancelarEstornoQR"
        Me.btnCancelarEstornoQR.Size = New System.Drawing.Size(125, 32)
        Me.btnCancelarEstornoQR.TabIndex = 4
        Me.btnCancelarEstornoQR.Text = "CANCELAR/ESTORNO"
        Me.btnCancelarEstornoQR.UseVisualStyleBackColor = True
        '
        'btnMercadoPago
        '
        Me.btnMercadoPago.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMercadoPago.Location = New System.Drawing.Point(22, 132)
        Me.btnMercadoPago.Name = "btnMercadoPago"
        Me.btnMercadoPago.Size = New System.Drawing.Size(170, 46)
        Me.btnMercadoPago.TabIndex = 3
        Me.btnMercadoPago.Text = "MERCADO PAGO"
        Me.btnMercadoPago.UseVisualStyleBackColor = True
        '
        'btnPicPay
        '
        Me.btnPicPay.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPicPay.Location = New System.Drawing.Point(22, 184)
        Me.btnPicPay.Name = "btnPicPay"
        Me.btnPicPay.Size = New System.Drawing.Size(170, 46)
        Me.btnPicPay.TabIndex = 2
        Me.btnPicPay.Text = "PICPAY"
        Me.btnPicPay.UseVisualStyleBackColor = True
        '
        'btnPSPClient
        '
        Me.btnPSPClient.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPSPClient.Location = New System.Drawing.Point(22, 80)
        Me.btnPSPClient.Name = "btnPSPClient"
        Me.btnPSPClient.Size = New System.Drawing.Size(170, 46)
        Me.btnPSPClient.TabIndex = 1
        Me.btnPSPClient.Text = "PSP CLIENTE"
        Me.btnPSPClient.UseVisualStyleBackColor = True
        '
        'btnMenuPSP
        '
        Me.btnMenuPSP.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMenuPSP.Location = New System.Drawing.Point(22, 28)
        Me.btnMenuPSP.Name = "btnMenuPSP"
        Me.btnMenuPSP.Size = New System.Drawing.Size(170, 46)
        Me.btnMenuPSP.TabIndex = 0
        Me.btnMenuPSP.Text = "MENU OPÇÕES PSP"
        Me.btnMenuPSP.UseVisualStyleBackColor = True
        '
        'lbLog
        '
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.Location = New System.Drawing.Point(554, 37)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(314, 537)
        Me.lbLog.TabIndex = 51
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 594)
        Me.Controls.Add(Me.checkBoxMultiplosCartoes)
        Me.Controls.Add(Me.btnLimpaLog)
        Me.Controls.Add(Me.btnAtributosAParte)
        Me.Controls.Add(Me.panelAtributos)
        Me.Controls.Add(Me.panelTransacoes)
        Me.Controls.Add(Me.tabTipo)
        Me.Controls.Add(Me.lbLog)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exemplo TefClientMC - VB.Net"
        Me.panelAtributos.ResumeLayout(False)
        Me.panelAtributos.PerformLayout()
        Me.panelTransacoes.ResumeLayout(False)
        Me.panelTransacoes.PerformLayout()
        Me.tabTipo.ResumeLayout(False)
        Me.tabPageCartao.ResumeLayout(False)
        Me.tabPageCartao.PerformLayout()
        Me.tabCreditoDebito.ResumeLayout(False)
        Me.tabCredito.ResumeLayout(False)
        Me.tabDebito.ResumeLayout(False)
        Me.tabFrota.ResumeLayout(False)
        Me.tabVoucher.ResumeLayout(False)
        Me.tabPageADM.ResumeLayout(False)
        Me.tabPageADM.PerformLayout()
        Me.tabPageQrMultiplos.ResumeLayout(False)
        Me.tabPageQrMultiplos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents checkBoxMultiplosCartoes As CheckBox
    Private WithEvents btnLimpaLog As Button
    Private WithEvents btnAtributosAParte As Button
    Private WithEvents panelAtributos As Panel
    Private WithEvents lbNsu As Label
    Private WithEvents lbCupom As Label
    Private WithEvents lbParcela As Label
    Private WithEvents txbNsu As TextBox
    Private WithEvents txbParcela As TextBox
    Private WithEvents txbCupom As TextBox
    Private WithEvents txbValor As TextBox
    Private WithEvents label1 As Label
    Private WithEvents panelTransacoes As Panel
    Private WithEvents checkBoxTodas As CheckBox
    Private WithEvents lbTransacoes As Label
    Private WithEvents btnDesfaz As Button
    Private WithEvents tansacoespendentes As ListBox
    Private WithEvents btnConfirma As Button
    Private WithEvents tabTipo As TabControl
    Private WithEvents tabPageCartao As TabPage
    Private WithEvents btnCancelar As Button
    Private WithEvents tabCreditoDebito As TabControl
    Private WithEvents tabCredito As TabPage
    Private WithEvents btnCancPreAutorizacao As Button
    Private WithEvents btnConfPreAutorizacao As Button
    Private WithEvents btnPreAutorizacao As Button
    Private WithEvents btnConsultaCredito As Button
    Private WithEvents btnCreditoParceladoAdm As Button
    Private WithEvents btnCreditoParceladoLoja As Button
    Private WithEvents btnCredito As Button
    Private WithEvents btnCreditoAVista As Button
    Private WithEvents tabDebito As TabPage
    Private WithEvents btnConsultaDebito As Button
    Private WithEvents btnDebitoAVista As Button
    Private WithEvents btnDebito As Button
    Private WithEvents tabFrota As TabPage
    Private WithEvents btnVendaFrota As Button
    Private WithEvents tabVoucher As TabPage
    Private WithEvents btnVendaVoucher As Button
    Private WithEvents lbCorOrientacaoCartao As Label
    Private WithEvents tabPageADM As TabPage
    Private WithEvents btnColetaCpf As Button
    Private WithEvents btnReimpressao As Button
    Private WithEvents btnExcluirBins As Button
    Private WithEvents lbCorOrientacaoClient As Label
    Private WithEvents tabPageQrMultiplos As TabPage
    Private WithEvents btnStatusTransacao As Button
    Private WithEvents btnCancelarEstornoQR As Button
    Private WithEvents btnMercadoPago As Button
    Private WithEvents btnPicPay As Button
    Private WithEvents btnPSPClient As Button
    Private WithEvents btnMenuPSP As Button
    Private WithEvents lbLog As ListBox
    Private WithEvents lbCorOrientacaoQrmultiplos As Label
    Private WithEvents label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
