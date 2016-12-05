Public Class USUARIO

    Private Sub USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIBLIOTECA1DataSet.USUARIO' table. You can move, or remove it, as needed.
        Me.USUARIOTableAdapter.Fill(Me.BIBLIOTECA1DataSet.USUARIO)
    End Sub
         Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.USUARIOTableAdapter.INSERTAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.USUARIOTableAdapter.Fill(Me.BIBLIOTECA1DataSet.USUARIO)
        limpiar()
        MsgBox("DATOS INSERTADOS CORRECTAMENTE")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.USUARIOTableAdapter.ACTUALIZAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.USUARIOTableAdapter.Fill(Me.BIBLIOTECA1DataSet.USUARIO)
        limpiar()
        MsgBox("DATOS ACTUALIZADOS CORRECTAMENTE")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.USUARIOTableAdapter.BUSCAR(Me.BIBLIOTECA1DataSet.USUARIO, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       

    End Sub
End Class