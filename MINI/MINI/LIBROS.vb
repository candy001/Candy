Public Class LIBROS

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIBLIOTECA1DataSet.LIBROS' table. You can move, or remove it, as needed.
        Me.LIBROSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.LIBROS)
    End Sub
    Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LIBROSTableAdapter.INSERTAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.LIBROSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.LIBROS)
        limpiar()
        MsgBox("DATOS INSERTADOS CORRECTAMENTE")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.LIBROSTableAdapter.ELIMINAR(TextBox1.Text)
        Me.LIBROSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.LIBROS)
        limpiar()
        MsgBox("DATOS BORRADOS CORRECTAMENTE")
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.LIBROSTableAdapter.AC(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.LIBROSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.LIBROS)
        limpiar()
        MsgBox("DATOS ACTUALIZADOS CORRECTAMENTE")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.LIBROSTableAdapter.BUS(Me.BIBLIOTECA1DataSet.LIBROS, TextBox1.Text)

        
    End Sub
End Class