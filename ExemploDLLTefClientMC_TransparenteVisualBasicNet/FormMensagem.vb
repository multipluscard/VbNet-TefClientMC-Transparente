Partial Public Class FormMensagem
    Inherits Form
    Public retornoMsg As String
    Public cancelar As Boolean = False
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal titulo As String, ByVal msg As String)
        InitializeComponent()

        lbMensagem.Text = msg
        Me.Text = titulo

        If Equals(titulo, "[ERRODISPLAY]") OrElse Equals(titulo, "[MSG]") Then txbRecebe.Visible = False
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        retornoMsg = txbRecebe.Text
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        cancelar = True
        Me.Close()
    End Sub

    Private Sub txbRecebe_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txbRecebe.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        'Ok.PerformClick()
        'End If
    End Sub


End Class
