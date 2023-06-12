Partial Public Class FormAtributosAParte
    Inherits Form

    Public AtrComunicacao As Integer
    Public Property AtrCnpj As String
    Public Property AtrData As String
    Public Property AtrPdv As String
    Public Property AtrCodLoja As String

    Public Sub New()
        InitializeComponent()
        'txbComunicacao.Text = "0";
        'txbData.Text = DateTime.Now.ToString("yyyyMMdd");          

    End Sub

    Public Sub New(ByVal comunicacao As Integer, ByVal cnpj As String, ByVal codloja As String, ByVal data As String, ByVal pdv As String)

        InitializeComponent()
        txbComunicacao.Text = comunicacao.ToString()
        txbCnpj.Text = cnpj
        txbCodLoja.Text = codloja
        txbData.Text = data
        txbPDV.Text = pdv
    End Sub

    Private Sub txbComunicacao_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txbComunicacao.TextChanged
        Integer.TryParse(txbComunicacao.Text, AtrComunicacao)
    End Sub

    Private Sub txbPDV_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txbPDV.TextChanged
        AtrPdv = txbPDV.Text
    End Sub

    Private Sub txbCodLoja_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txbCodLoja.TextChanged
        AtrCodLoja = txbCodLoja.Text
    End Sub

    Private Sub txbCnpj_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txbCnpj.TextChanged
        AtrCnpj = txbCnpj.Text
    End Sub

    Private Sub txbData_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txbData.TextChanged
        AtrData = txbData.Text
    End Sub
End Class
