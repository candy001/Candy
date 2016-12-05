Public Class LOGIN

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Asegúrese de ingresar el Usuario")
            TextBox1.Focus()
        ElseIf TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Asegúrese de ingresar la Contraseña")
            TextBox2.Focus()
        Else
            MessageBox.Show("Bienvenido Sr(a): " & TextBox1.Text)

            Me.Hide()
            Dim fr As New INICIO()
            fr.Show()
        End If
    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If MessageBox.Show("Estas seguro que desea Salir", "◄ ✿♥☆ AVISO ✿♥☆ ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub



End Class