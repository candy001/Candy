Public Class PRESTAMO

    Private Sub PRESTAMO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIBLIOTECA1DataSet1.PRESTAMOS' table. You can move, or remove it, as needed.
        Me.PRESTAMOSTableAdapter.Fill(Me.BIBLIOTECA1DataSet1.PRESTAMOS)
        'TODO: This line of code loads data into the 'BIBLIOTECA1DataSet.PRESTAMOS' table. You can move, or remove it, as needed.
        Me.PRESTAMOSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.PRESTAMOS)

    End Sub
    Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PRESTAMOSTableAdapter.INSERTAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text)
        Me.PRESTAMOSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.PRESTAMOS)
        limpiar()
        MsgBox("DATOS INSERTADOS CORRECTAMENTE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PRESTAMOSTableAdapter.ACTUAL(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox4.Text)
        Me.PRESTAMOSTableAdapter.Fill(Me.BIBLIOTECA1DataSet.PRESTAMOS)
        limpiar()
        MsgBox("DATOS ACTUALIZADOS CORRECTAMENTE")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class