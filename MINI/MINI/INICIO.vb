Public Class INICIO

 
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        LIBROS.Show()
        Me.Visible = True
        MsgBox("RETROCEDIENDO...")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PRESTAMO.Show()
        Me.Visible = True
        MsgBox("RETROCEDIENDO...")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        USUARIO.Show()
        Me.Visible = True
        MsgBox("RETROCEDIENDO...")
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub
End Class