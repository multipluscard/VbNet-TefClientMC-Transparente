Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.Logging
Imports System.IO
Imports System.Threading

Partial Public Class FormPrincipal
    Inherits Form

#Region "Declaração das Funções da DLL"

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function IniciaFuncaoMCInterativo(ByVal iComando As Integer, ByVal sCnpjCliente As String, ByVal iParcela As Integer, ByVal sCupom As String, ByVal sValor As String, ByVal sNsu As String, ByVal sData As String, ByVal sNumeroPDV As String, ByVal sCodigoLoja As String, ByVal sTipoComunicacao As Integer, ByVal sParametro As String) As Integer
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function AguardaFuncaoMCInterativo() As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function ContinuaFuncaoMCInterativo(ByVal sInformacao As String) As Integer
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function FinalizaFuncaoMCInterativo(ByVal iComando As Integer, ByVal sCnpjCliente As String, ByVal iParcela As Integer, ByVal sCupom As String, ByVal sValor As String, ByVal sNsu As String, ByVal sData As String, ByVal sNumeroPDV As String, ByVal sCodigoLoja As String, ByVal sTipoComunicacao As Integer, ByVal sParametro As String) As Integer
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function CancelarFluxoMCInterativo() As Integer
    End Function

#End Region

#Region "Variaveis Globais FormAtributos"
    Private Shared comunicacao As Integer
    Public cnpj As String
    Public data As String
    Public pdv As String
    Public codloja As String

#End Region

#Region "Variaveis formPrincipal"
    Dim flagretorno As Integer
    Dim flagoperacao As Integer
    Dim valor As String
    Dim parcelas As Integer
    Dim cupom As String
    Dim nsu As String
    Dim confirmar = True

    Dim InsereNovoCartao As Boolean
    Dim NovaVenda = True
#End Region

    Dim form As FormAtributosAParte

    Dim lstCupons As List(Of RetCupom)
    Dim lstExibicao As List(Of Object) = New List(Of Object)()

    Public Sub New()
        InitializeComponent()
        AtribuirosDados()
        form = New FormAtributosAParte(comunicacao, cnpj, codloja, data, pdv)

        lbLog.HorizontalScrollbar = True
        tansacoespendentes.HorizontalScrollbar = True

        If checkBoxMultiplosCartoes.Checked = True Then
            panelTransacoes.Visible = True
            lbLog.Size = New Size(314, 342)
        Else
            panelTransacoes.Visible = False
            lbLog.Size = New Size(314, 550)
        End If
    End Sub



#Region "Metodos"
    Private Sub ExecutarFuncao(ByVal operacao As Integer)
        If GetParametros() Then
            flagoperacao = operacao
            Dim retorno As Integer = IniciaFuncaoMCInterativo(operacao, cnpj, parcelas, cupom, valor, nsu, data, pdv, codloja, comunicacao, "")

            flagretorno = retorno
            lbLog.Items.Insert(0, Date.Now & " - IniciaFuncaoMCInterativo()")
            lbLog.HorizontalScrollbar = True

            Util.AdicionaLog("IniciaFuncaoMCInterativo()")
            lbLog.Refresh()


            If retorno = 0 Then
                Dim retMsg = ""
                Dim retFim As Integer
                Dim arrMsg As String() = Nothing

                While Not Equals(retMsg, "[ERROABORTAR]") AndAlso Not Equals(retMsg, "[RETORNO]") AndAlso Not Equals(retMsg, "[ERRODISPLAY]")
                    Dim strRetAguardaFMCInt As String = AguardaFuncaoMCInterativo()
                    Util.AdicionaLog(strRetAguardaFMCInt)

                    If Not Equals(strRetAguardaFMCInt, "") Then
                        lbLog.Items.Insert(0, Date.Now & " - " & strRetAguardaFMCInt)
                        lbLog.Refresh()
                    End If

                    arrMsg = strRetAguardaFMCInt.Split("#"c)
                    retMsg = arrMsg(0)

                    If Equals(retMsg, "[MENU]") Then
                        Dim tela As FormMensagem = If(arrMsg.Count() > 2, New FormMensagem(arrMsg(1), arrMsg(2).Replace("|"c, ChrW(10))), New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10))))
                        tela.ShowDialog()

                        If tela.cancelar Then
                            CancelarFluxoMCInterativo()
                            Util.AdicionaLog("CancelarFluxoMCInterativo()")
                            MessageBox.Show("Fluxo Cancelado")
                            retMsg = "[ERROABORTAR]"
                            lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                            Util.AdicionaLog("Fluxo Cancelado")
                            lbLog.Refresh()
                        Else
                            ContinuaFuncaoMCInterativo(tela.retornoMsg)
                            tela.Dispose()
                        End If
                    End If

                    If Equals(retMsg, "[PERGUNTA]") Then
                        Dim tela As FormMensagem = New FormMensagem(arrMsg(1), arrMsg(2).Replace("|"c, ChrW(10)))
                        tela.ShowDialog()

                        If tela.cancelar Then
                            CancelarFluxoMCInterativo()
                            Util.AdicionaLog("CancelarFluxoMCInterativo()")
                            MessageBox.Show("Fluxo Cancelado")
                            retMsg = "[ERROABORTAR]"
                            lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                            Util.AdicionaLog("Fluxo Cancelado")
                            lbLog.Refresh()
                        Else
                            ContinuaFuncaoMCInterativo(tela.retornoMsg)
                            tela.Dispose()
                        End If
                    End If

                    If Equals(retMsg, "[MSG]") Then
                        If arrMsg.Count() >= 2 Then
                            If arrMsg(1).Contains("SALDO") AndAlso Not arrMsg(1).Contains("RETIRE") Then
                                Dim tela As FormMensagem = New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10)))
                                tela.ShowDialog()
                            End If
                        End If


                        If arrMsg(1).Contains("QRCODE") Then
                            Dim arrAux = arrMsg(1).Split("|"c)

                            Dim nsu = arrAux(0).Split("="c)
                            Dim origem = arrAux(1).Split("="c)
                            Dim valor = arrAux(2).Split("="c)
                            Dim qrcode = arrAux(3).Split("="c)

                            Dim t = Task.Run(Function() ExibirTelaQrCode())
                        End If


                    End If
                    If Equals(retMsg, "[ERRODISPLAY]") Then
                        Dim tela As FormMensagem = New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10)))
                        tela.ShowDialog()

                        If tela.cancelar Then
                            CancelarFluxoMCInterativo()
                            Util.AdicionaLog("CancelarFluxoMCInterativo()")
                            MessageBox.Show("Fluxo Cancelado")
                            retMsg = "[ERROABORTAR]"
                            lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                            Util.AdicionaLog("Fluxo Cancelado")
                            lbLog.Refresh()
                        Else
                            ContinuaFuncaoMCInterativo(tela.retornoMsg)
                            tela.Dispose()
                        End If
                    End If

                    Thread.Sleep(50)
                End While
                If Equals(retMsg, "[ERROABORTAR]") Then
                    MessageBox.Show(retMsg)
                End If
                If Equals(retMsg, "[RETORNO]") Then
                    ''Thread.Sleep(50)
                    Dim strCupom = ""
                    Dim nsuRet = ""

                    If arrMsg.Length > 2 Then
                        If operacao > 50 AndAlso operacao < 60 Then
                            Try
                                File.Create($"{AppDomain.CurrentDomain.BaseDirectory}concluiupix.txt")
                            Catch ex As Exception
                                Util.AdicionaLog($"Erro - {ex.Message}")
                            End Try
                        End If

                        strCupom = arrMsg(15).Replace("CAMPO122=", "").Replace("|", vbLf).Replace("CORTAR", vbLf & "-------------------------------" & vbLf)

                        Dim auxCupom = strCupom & "-------------------------------" & vbLf & vbLf

                        nsuRet = arrMsg(5).Replace("CAMPO0133=", "")
                    End If

                    If arrMsg.Length = 2 And operacao = 200 Then
                        Dim aux = arrMsg(1).Split("="c)
                        strCupom = $"CPF Coletado: {aux(1)}"
                    End If

                    MessageBox.Show(strCupom)
                    MessageBox.Show(String.Join(vbLf, arrMsg))

                    retFim = 0

                    If operacao <> 98 AndAlso operacao <> 99 Then
                        If confirmar Then
                            retFim = FinalizaFuncaoMCInterativo(98, cnpj, parcelas, cupom, valor, nsuRet, data, pdv, codloja, comunicacao, "")
                        Else
                            retFim = FinalizaFuncaoMCInterativo(99, cnpj, parcelas, cupom, valor, nsuRet, data, pdv, codloja, comunicacao, "")
                        End If
                        Util.AdicionaLog("FinalizaFuncaoMCInterativo()")
                    Else
                        retFim = 0
                    End If

                    If retFim = 0 Then
                        lbLog.Items.Insert(0, Date.Now & " - FIM DA TRANSAÇÃO")
                        lbLog.Refresh()
                    Else
                        lbLog.Items.Insert(0, Date.Now & " - ERRO: " & retFim)
                        lbLog.Refresh()
                    End If
                End If
            Else
                retornaErro()
                Util.AdicionaLog("Erro - IniciaFuncaoMCInterativo")
            End If
        End If

    End Sub


    Private Function GetParametros(ByVal Optional ExcluirBins As Boolean = False) As Boolean
        If ExcluirBins Then flagoperacao = 110

        If cnpj Is Nothing OrElse comunicacao.ToString() Is "" OrElse txbCupom.Text Is "" OrElse data.ToString() Is "" OrElse txbNsu.Text Is "" OrElse txbParcela.Text Is "" OrElse pdv Is Nothing OrElse txbValor.Text = "" OrElse codloja Is Nothing Then
            'txbParcela.Text = "0"
            MessageBox.Show("Informe todos os parâmetros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        Else
            flagoperacao = 0
            parcelas = 1

            comunicacao = 0

            Integer.TryParse(txbParcela.Text, parcelas)

            cupom = txbCupom.Text
            nsu = txbNsu.Text
            valor = txbValor.Text

            ' if (checkBoxMultiplosCartoes.Checked == true)
            ' confirmar = true;
            ' else
            ' confirmar = false;
            ' 
            Return True
        End If
    End Function

    Private Sub retornaErro()
        If flagretorno = 1 Then
            MessageBox.Show("Erro genérico na execução", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 30 Then
            MessageBox.Show("Não foi encontrado o caminho do ClientD.exe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 31 Then
            MessageBox.Show("ConfigMC.ini está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 32 Then
            MessageBox.Show("ClientD.exe não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 33 Then
            MessageBox.Show("ClientD.exe não está em execução", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 34 Then
            MessageBox.Show("Erro ao iniciar ClientD.exe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 35 Then
            MessageBox.Show("Não foi possível criar o arquivo de resposta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 36 Then
            MessageBox.Show("Erro na manipulação do arquivo de resposta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 37 Then
            MessageBox.Show("Erro na leitura do arquivo ConfigMC.ini", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 38 Then
            MessageBox.Show("Valor da transação com formato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 39 Then
            MessageBox.Show("Executável de envio de transações não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 40 Then
            MessageBox.Show("CNPJ Inválido ou no formato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 41 Then
            MessageBox.Show("ClientD.exe está em processo de atualização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flagretorno = 42 Then
            MessageBox.Show("A automação não está sendo executada no modo administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return
    End Sub

    Private Sub AtribuirosDados()
        Dim aplicacao As String = Application.StartupPath
        Dim path = $"{aplicacao}\ArqCarregaDados.txt"
        Dim src = File.ReadAllLines(path)
        For Each line In src
            Dim arr = line.ToUpper().Split("="c)
            If arr.Length < 2 Then Continue For
            Select Case arr(0)
                Case "CNPJ"
                    cnpj = arr(1)
                Case "PDV"
                    pdv = arr(1)
                Case "CODIGO_LOJA"
                    codloja = arr(1)
            End Select
        Next

        data = Date.Now.ToString("yyyyMMdd")
        comunicacao = 0
    End Sub

    Private Function ExibirTelaQrCode()
        ContinuaFuncaoMCInterativo("1")
    End Function


#End Region



#Region "Eventos"
    Private Sub btnAtributosAParte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtributosAParte.Click
        If form IsNot Nothing Then
            form.ShowDialog()
            If Not form.IsDisposed Then
                comunicacao = form.AtrComunicacao
                cnpj = form.AtrCnpj
                pdv = form.AtrPdv
                data = form.AtrData
                codloja = form.AtrCodLoja
            End If
        Else
            form = New FormAtributosAParte()
            form.ShowDialog()
        End If
    End Sub
    Private Sub btnCredito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCredito.Click
        ExecutarFuncao(1)
    End Sub
    Private Sub btnLimpaLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpaLog.Click
        lbLog.Items.Clear()
    End Sub
    Private Sub btnCreditoAVista_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoAVista.Click
        ExecutarFuncao(0)
    End Sub
    Private Sub btnDebito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebito.Click
        ExecutarFuncao(4)
    End Sub
    Private Sub btnDebitoAVista_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebitoAVista.Click
        ExecutarFuncao(20)
    End Sub
    Private Sub btnCreditoParceladoLoja_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoParceladoLoja.Click
        ExecutarFuncao(2)
    End Sub
    Private Sub btnCreditoParceladoAdm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoParceladoAdm.Click
        ExecutarFuncao(3)
    End Sub
    Private Sub btnVendaFrota_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVendaFrota.Click
        ExecutarFuncao(11)
    End Sub
    Private Sub btnVendaVoucher_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVendaVoucher.Click
        ExecutarFuncao(18)
    End Sub
    Private Sub checkBoxMultiplosCartoes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxMultiplosCartoes.CheckedChanged
        If GetParametros() AndAlso checkBoxMultiplosCartoes.Checked Then
            NovaVenda = True
            While NovaVenda
                panelTransacoes.Visible = True
                lbLog.Size = New Size(314, 342)


                If Not InsereNovoCartao Then
                    lstCupons = New List(Of RetCupom)()
                    lstExibicao = New List(Of Object)()
                End If

                Dim flagnsu = $"{nsu}*"
                'MessageBox.Show(flagnsu);
                Dim retorno As Integer = IniciaFuncaoMCInterativo(flagoperacao, cnpj, parcelas, cupom, valor, flagnsu, data, pdv, codloja, comunicacao, "")
                lbLog.Items.Insert(0, Date.Now & " - IniciaFuncaoMCInterativo()")
                Util.AdicionaLog("IniciaFuncaoMCInterativo()")
                lbLog.Refresh()

                Dim tela As FormMensagem

                If retorno = 0 Then
                    Dim retMsg = ""
                    Dim arrMsg As String() = Nothing

                    While Not Equals(retMsg, "[ERROABORTAR]") AndAlso Not Equals(retMsg, "[RETORNO]") AndAlso Not Equals(retMsg, "[ERRODISPLAY]")

                        Dim strRetAguardaFMCInt As String = AguardaFuncaoMCInterativo()
                        Util.AdicionaLog(strRetAguardaFMCInt)

                        If Not Equals(strRetAguardaFMCInt, "") Then
                            lbLog.Items.Insert(0, Date.Now & " - " & strRetAguardaFMCInt)
                            lbLog.Refresh()
                        End If

                        arrMsg = strRetAguardaFMCInt.Split("#"c)
                        retMsg = arrMsg(0)

                        If Equals(retMsg, "[MENU]") Then
                            tela = If(arrMsg.Count() > 2, New FormMensagem(arrMsg(1), arrMsg(2).Replace("|"c, ChrW(10))), New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10))))
                            tela.ShowDialog()

                            If tela.cancelar Then
                                CancelarFluxoMCInterativo()
                                Util.AdicionaLog("CancelarFluxoMCInterativo()")
                                MessageBox.Show("Fluxo Cancelado")
                                retMsg = "[ERROABORTAR]"
                                lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                                Util.AdicionaLog("Fluxo Cancelado")
                                lbLog.Refresh()
                            Else
                                ContinuaFuncaoMCInterativo(tela.retornoMsg)
                                tela.Dispose()
                            End If
                        End If

                        If Equals(retMsg, "[PERGUNTA]") Then
                            tela = New FormMensagem(arrMsg(1), arrMsg(2).Replace("|"c, ChrW(10)))
                            tela.ShowDialog()

                            If tela.cancelar Then
                                CancelarFluxoMCInterativo()
                                Util.AdicionaLog("CancelarFluxoMCInterativo()")
                                MessageBox.Show("Fluxo Cancelado")
                                retMsg = "[ERROABORTAR]"
                                lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                                Util.AdicionaLog("Fluxo Cancelado")
                                lbLog.Refresh()
                            Else
                                ContinuaFuncaoMCInterativo(tela.retornoMsg)
                                tela.Dispose()
                            End If
                        End If

                        If Equals(retMsg, "[MSG]") Then
                            If arrMsg.Count() >= 2 Then
                                If arrMsg(1).Contains("SALDO") AndAlso Not arrMsg(1).Contains("RETIRE") Then
                                    tela = New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10)))
                                    tela.ShowDialog()
                                End If

                                If arrMsg(1).Contains("QRCODE") Then
                                    Dim arrAux = arrMsg(1).Split("|"c)

                                    Dim nsu = arrAux(0).Split("="c)
                                    Dim origem = arrAux(1).Split("="c)
                                    Dim valor = arrAux(2).Split("="c)
                                    Dim qrcode = arrAux(3).Split("="c)

                                    ContinuaFuncaoMCInterativo("1")
                                End If
                            End If
                        End If
                        If Equals(retMsg, "[ERRODISPLAY]") Then
                            tela = New FormMensagem(arrMsg(0), arrMsg(1).Replace("|"c, ChrW(10)))
                            tela.ShowDialog()

                            InsereNovoCartao = False
                            NovaVenda = False

                            If tela.cancelar Then
                                CancelarFluxoMCInterativo()
                                Util.AdicionaLog("CancelarFluxoMCInterativo()")
                                MessageBox.Show("Fluxo Cancelado")
                                retMsg = "[ERROABORTAR]"
                                lbLog.Items.Insert(0, Date.Now & " - Fluxo Cancelado")
                                Util.AdicionaLog("Fluxo Cancelado")
                                lbLog.Refresh()

                            Else
                                ContinuaFuncaoMCInterativo(tela.retornoMsg)
                                tela.Dispose()
                            End If
                        End If
                        Thread.Sleep(50)
                    End While
                    If Equals(retMsg, "[ERROABORTAR]") Then 'transação abortada
                        MessageBox.Show(retMsg)
                        NovaVenda = False
                    End If
                    If Equals(retMsg, "[RETORNO]") Then
                        Thread.Sleep(50)
                        Dim strCupom = arrMsg(15).Replace("CAMPO122=", "").Replace("|", vbLf).Replace("CORTAR", vbLf & vbLf)

                        Dim auxCupom = strCupom & "-------------------------------" & vbLf & vbLf & strCupom

                        Dim dadosCupom = New RetCupom With {
                                    .Comprovante = arrMsg(15).Replace("CAMPO122=", "").Replace("|", vbLf).Replace("CORTAR", vbLf & "-------------------------------" & vbLf),
                                    .VenctoCartao = arrMsg(14).Replace("CAMPO0513=", ""),
                                    .NsuRede = arrMsg(13).Replace("CAMPO0134=", ""),
                                    .Cliente = arrMsg(12).Replace("CAMPO1003=", ""),
                                    .Cnpj = arrMsg(11).Replace("CAMPO0950=", ""),
                                    .UltimosDigitos = arrMsg(10).Replace("CAMPO1190=", ""),
                                    .BinCartao = arrMsg(9).Replace("CAMPO0136=", ""),
                                    .TxServico = arrMsg(8).Replace("CAMPO0504=", ""),
                                    .Parcelas = arrMsg(7).Replace("CAMPO0505=", ""),
                                    .Nsu = arrMsg(6).Replace("CAMPO0133=", ""),
                                    .CodAutorizacao = arrMsg(5).Replace("CAMPO0135=", ""),
                                    .CodRede = arrMsg(4).Replace("CAMPO0131=", ""),
                                    .CodBandeira = arrMsg(3).Replace("CAMPO0132=", ""),
                                    .Valor = arrMsg(2).Replace("CAMPO0002=", ""),
                                    .Cupom = arrMsg(1).Replace("CAMPO0160=", "")
                                    }

                        lstCupons.Add(dadosCupom)

                        Dim obj1 = New With {
                            dadosCupom.Valor,
                            .exibir = dadosCupom.Comprovante.Replace(vbLf, "|")
                        }

                        tansacoespendentes.Items.Add(dadosCupom.Comprovante.Replace(vbLf, "|"))
                        tansacoespendentes.Refresh()

                        lstExibicao.Add(obj1)
                    End If
                Else
                    MessageBox.Show("Erro - IniciaFuncaoMCInterativo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    Util.AdicionaLog("Erro - IniciaFuncaoMCInterativo")
                    NovaVenda = False
                End If

                If NovaVenda Then
                    Dim novoValor As String

                    If MessageBox.Show("Deseja Pagar com mais um cartão?", "Pagar com Multiplos Cartões", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                        novoValor = InputBox("Digite o valor da Transação:", "Multiplus Cartões", "")
                        valor = novoValor
                        InsereNovoCartao = True
                    Else
                        InsereNovoCartao = False
                        NovaVenda = False

                    End If
                Else
                    checkBoxMultiplosCartoes.Checked = False
                    panelTransacoes.Visible = False
                    lbLog.Size = New Size(314, 550)
                End If
            End While
        Else
            NovaVenda = False
            checkBoxMultiplosCartoes.Checked = False
        End If
    End Sub

    Private Sub btnStatusTransacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStatusTransacao.Click
        ExecutarFuncao(56)
    End Sub
    Private Sub btnCancelarEstornoQR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelarEstornoQR.Click
        ExecutarFuncao(54)
    End Sub
    Private Sub btnExcluirBins_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcluirBins.Click
        Try
            GetParametros(True)
            Dim ret = IniciaFuncaoMCInterativo(110, cnpj, parcelas, cupom, valor, nsu, data, pdv, codloja, comunicacao, "")
        Catch ex As Exception
            MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnConsultaCredito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultaCredito.Click
        ExecutarFuncao(9)
    End Sub
    Private Sub btnPreAutorizacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreAutorizacao.Click
        ExecutarFuncao(15)
    End Sub
    Private Sub btnConfPreAutorizacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfPreAutorizacao.Click
        ExecutarFuncao(16)
    End Sub
    Private Sub btnCancPreAutorizacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancPreAutorizacao.Click
        ExecutarFuncao(17)
    End Sub
    Private Sub btnConsultaDebito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultaDebito.Click
        ExecutarFuncao(10)
    End Sub
    Private Sub btnReimpressao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReimpressao.Click
        ExecutarFuncao(6)
    End Sub
    Private Sub btnColetaCpf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnColetaCpf.Click
        ExecutarFuncao(200)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        ExecutarFuncao(5)
    End Sub
    Private Sub btnPSPClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPSPClient.Click
        ExecutarFuncao(51)
    End Sub
    Private Sub btnMenuPSP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPSP.Click
        ExecutarFuncao(50)
    End Sub
    Private Sub btnMercadoPago_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMercadoPago.Click
        ExecutarFuncao(52)
    End Sub
    Private Sub btnPicPay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPicPay.Click
        ExecutarFuncao(53)
    End Sub
    Private Sub btnConfirma_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirma.Click
        Dim paramConfConfi = 98
        Dim nsuConf = ""

        Me.Cursor = Cursors.WaitCursor
        checkBoxMultiplosCartoes.Checked = False
        If checkBoxTodas.Checked Then
            For Each item In lstCupons

                Dim auxParc = Convert.ToInt32(item.Parcelas)

                Dim parc = If(auxParc = 0, 1, auxParc)

                Dim sNsu = item.Nsu

                If item IsNot lstCupons.Last() Then sNsu += "*"

                Dim retFim = FinalizaFuncaoMCInterativo(paramConfConfi, cnpj, parc, item.Cupom, item.Valor, sNsu, data, pdv, codloja, comunicacao, "")
                Util.AdicionaLog($"{paramConfConfi}, {cnpj}, {Convert.ToInt32(item.Parcelas)}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}")
                Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}")

                lbLog.Items.Insert(0, Date.Now & $" - Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}")
                lbLog.Items.Insert(0, Date.Now & $" - {paramConfConfi}, {cnpj}, {parc}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}")

                nsuConf = item.Nsu
                'var timeout = Convert.ToInt32(tbTimeout.Text);

                'Thread.Sleep(timeout);
            Next

            For Each item In lstCupons
                Dim auxCupom = item.Comprovante & "-------------------------------" & vbLf & vbLf + item.Comprovante

                'Comprovante
                MessageBox.Show(item.Comprovante)
                Me.Cursor = Cursors.Default
            Next

            tansacoespendentes.Items.Clear()
            lbLog.Items.Insert(0, Date.Now & " - FIM DA TRANSAÇÃO")
            panelTransacoes.Visible = False
            lbLog.Height = 537
            lbLog.Refresh()
        Else
            Me.Cursor = Cursors.WaitCursor

            Dim iTrans = If(tansacoespendentes.SelectedIndex = -1, 0, tansacoespendentes.SelectedIndex)

            Dim transacao = lstCupons.ElementAt(iTrans)

            MessageBox.Show(transacao.Comprovante)

            Dim auxParc = Convert.ToInt32(transacao.Parcelas)

            Dim parc = If(auxParc = 0, 1, auxParc)

            Dim sNsu = transacao.Nsu

            If lstCupons.Count() > 1 Then sNsu += "*"

            Dim retFim = FinalizaFuncaoMCInterativo(paramConfConfi, cnpj, parc, transacao.Cupom, transacao.Valor, sNsu, data, pdv, codloja, comunicacao, "")
            Util.AdicionaLog($"{paramConfConfi}, {cnpj}, {Convert.ToInt32(transacao.Parcelas)}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}")
            Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}")

            lbLog.Items.Insert(0, Date.Now & $" - Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}")
            lbLog.Items.Insert(0, Date.Now & $" - {paramConfConfi}, {cnpj}, {parc}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}")


            lstCupons.RemoveAt(iTrans)

            lstExibicao.RemoveAt(iTrans)

            tansacoespendentes.Items.RemoveAt(iTrans)

            tansacoespendentes.Refresh()


            If lstCupons.Count = 0 Then

                lbLog.Items.Insert(0, Date.Now & " - FIM DA TRANSAÇÃO")
                lbLog.Refresh()
                Me.Cursor = Cursors.Default
                panelTransacoes.Visible = False
                lbLog.Height = 537
                '  bOperacao.Enabled = true;
            End If

        End If


    End Sub
    Private Sub btnDesfaz_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDesfaz.Click
        Dim paramConfDesf = 99
        Dim nsuConf = ""

        Me.Cursor = Cursors.WaitCursor
        checkBoxMultiplosCartoes.Checked = False
        If checkBoxTodas.Checked Then
            For Each item In lstCupons

                Dim auxParc = Convert.ToInt32(item.Parcelas)

                Dim parc = If(auxParc = 0, 1, auxParc)

                Dim sNsu = item.Nsu

                If item IsNot lstCupons.Last() Then sNsu += "*"

                Dim retFim = FinalizaFuncaoMCInterativo(paramConfDesf, cnpj, parc, item.Cupom, item.Valor, sNsu, data, pdv, codloja, comunicacao, "")
                Util.AdicionaLog($"{paramConfDesf}, {cnpj}, {Convert.ToInt32(item.Parcelas)}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}")
                Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}")

                lbLog.Items.Insert(0, Date.Now & $" - Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}")
                lbLog.Items.Insert(0, Date.Now & $" - {paramConfDesf}, {cnpj}, {parc}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}")

                nsuConf = item.Nsu

            Next

            For Each item In lstCupons
                Dim auxCupom = item.Comprovante & "-------------------------------" & vbLf & vbLf + item.Comprovante

                'Comprovante
                MessageBox.Show(item.Comprovante)
            Next

            tansacoespendentes.Items.Clear()
            lbLog.Items.Insert(0, Date.Now & " - FIM DA TRANSAÇÃO")
            panelTransacoes.Visible = False
            lbLog.Height = 537
            Me.Cursor = Cursors.Default
            lbLog.Refresh()
        Else
            Me.Cursor = Cursors.WaitCursor

            Dim iTrans = If(tansacoespendentes.SelectedIndex = -1, 0, tansacoespendentes.SelectedIndex)

            Dim transacao = lstCupons.ElementAt(iTrans)

            MessageBox.Show(transacao.Comprovante)

            Dim auxParc = Convert.ToInt32(transacao.Parcelas)

            Dim parc = If(auxParc = 0, 1, auxParc)

            Dim sNsu = transacao.Nsu

            If lstCupons.Count() > 1 Then sNsu += "*"

            Dim retFim = FinalizaFuncaoMCInterativo(paramConfDesf, cnpj, parc, transacao.Cupom, transacao.Valor, sNsu, data, pdv, codloja, comunicacao, "")
            Util.AdicionaLog($"{paramConfDesf}, {cnpj}, {Convert.ToInt32(transacao.Parcelas)}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}")
            Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}")

            lbLog.Items.Insert(0, Date.Now & $" - Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}")
            lbLog.Items.Insert(0, Date.Now & $" - {paramConfDesf}, {cnpj}, {parc}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}")


            lstCupons.RemoveAt(iTrans)

            lstExibicao.RemoveAt(iTrans)

            tansacoespendentes.Items.RemoveAt(iTrans)

            tansacoespendentes.Refresh()


            If lstCupons.Count = 0 Then

                lbLog.Items.Insert(0, Date.Now & " - FIM DA TRANSAÇÃO")
                panelTransacoes.Visible = False
                lbLog.Height = 537
                lbLog.Height = 537
                Me.Cursor = Cursors.Default
                lbLog.Refresh()
            End If

        End If

    End Sub

#End Region


End Class
