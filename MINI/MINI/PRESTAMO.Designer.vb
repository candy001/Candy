<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRESTAMO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdprestamosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdlibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTAMOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIBLIOTECA1DataSet1 = New MINI.BIBLIOTECA1DataSet()
        Me.PRESTAMOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIBLIOTECA1DataSet = New MINI.BIBLIOTECA1DataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PRESTAMOSTableAdapter = New MINI.BIBLIOTECA1DataSetTableAdapters.PRESTAMOSTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECA1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECA1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprestamosDataGridViewTextBoxColumn, Me.IdusuarioDataGridViewTextBoxColumn, Me.IdlibroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PRESTAMOSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(62, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IdprestamosDataGridViewTextBoxColumn
        '
        Me.IdprestamosDataGridViewTextBoxColumn.DataPropertyName = "id_prestamos"
        Me.IdprestamosDataGridViewTextBoxColumn.HeaderText = "id_prestamos"
        Me.IdprestamosDataGridViewTextBoxColumn.Name = "IdprestamosDataGridViewTextBoxColumn"
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        '
        'IdlibroDataGridViewTextBoxColumn
        '
        Me.IdlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro"
        Me.IdlibroDataGridViewTextBoxColumn.HeaderText = "id_libro"
        Me.IdlibroDataGridViewTextBoxColumn.Name = "IdlibroDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        '
        'PRESTAMOSBindingSource1
        '
        Me.PRESTAMOSBindingSource1.DataMember = "PRESTAMOS"
        Me.PRESTAMOSBindingSource1.DataSource = Me.BIBLIOTECA1DataSet1
        '
        'BIBLIOTECA1DataSet1
        '
        Me.BIBLIOTECA1DataSet1.DataSetName = "BIBLIOTECA1DataSet"
        Me.BIBLIOTECA1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRESTAMOSBindingSource
        '
        Me.PRESTAMOSBindingSource.DataMember = "PRESTAMOS"
        Me.PRESTAMOSBindingSource.DataSource = Me.BIBLIOTECA1DataSet
        '
        'BIBLIOTECA1DataSet
        '
        Me.BIBLIOTECA1DataSet.DataSetName = "BIBLIOTECA1DataSet"
        Me.BIBLIOTECA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ID_PRESTAMOS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(525, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "INSERTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(500, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(183, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "HORA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "FECHA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID_LIBRO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID_USUARIO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PRESTAMOSTableAdapter
        '
        Me.PRESTAMOSTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(490, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'PRESTAMO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 416)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PRESTAMO"
        Me.Text = "PRESTAMO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECA1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECA1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BIBLIOTECA1DataSet As MINI.BIBLIOTECA1DataSet
    Friend WithEvents PRESTAMOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRESTAMOSTableAdapter As MINI.BIBLIOTECA1DataSetTableAdapters.PRESTAMOSTableAdapter
    Friend WithEvents IdprestamosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdlibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BIBLIOTECA1DataSet1 As MINI.BIBLIOTECA1DataSet
    Friend WithEvents PRESTAMOSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
