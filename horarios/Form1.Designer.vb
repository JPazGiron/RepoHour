<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateCheckin = New System.Windows.Forms.DateTimePicker()
        Me.dateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.HourDataSet = New horarios.hourDataSet()
        Me.HourDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdcontrolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChecktimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChecktypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerifycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SensoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinsemanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserExtEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HourDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlHTableAdapter = New horarios.hourDataSetTableAdapters.controlHTableAdapter()
        Me.hourCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hourCheckin = New System.Windows.Forms.DateTimePicker()
        CType(Me.HourDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'cbxEmpleado
        '
        Me.cbxEmpleado.FormattingEnabled = True
        Me.cbxEmpleado.Location = New System.Drawing.Point(321, 49)
        Me.cbxEmpleado.Name = "cbxEmpleado"
        Me.cbxEmpleado.Size = New System.Drawing.Size(477, 21)
        Me.cbxEmpleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de entrada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de salida:"
        '
        'dateCheckin
        '
        Me.dateCheckin.Location = New System.Drawing.Point(229, 108)
        Me.dateCheckin.Name = "dateCheckin"
        Me.dateCheckin.Size = New System.Drawing.Size(254, 20)
        Me.dateCheckin.TabIndex = 4
        '
        'dateCheckout
        '
        Me.dateCheckout.Location = New System.Drawing.Point(609, 108)
        Me.dateCheckout.Name = "dateCheckout"
        Me.dateCheckout.Size = New System.Drawing.Size(217, 20)
        Me.dateCheckout.TabIndex = 5
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(867, 109)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(93, 51)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(951, 378)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 33)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'HourDataSet
        '
        Me.HourDataSet.DataSetName = "hourDataSet"
        Me.HourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HourDataSetBindingSource
        '
        Me.HourDataSetBindingSource.DataSource = Me.HourDataSet
        Me.HourDataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcontrolDataGridViewTextBoxColumn, Me.ChecktimeDataGridViewTextBoxColumn, Me.ChecktypeDataGridViewTextBoxColumn, Me.VerifycodeDataGridViewTextBoxColumn, Me.SensoridDataGridViewTextBoxColumn, Me.FinsemanaDataGridViewTextBoxColumn, Me.DiaDataGridViewTextBoxColumn, Me.WorkcodeDataGridViewTextBoxColumn, Me.SnDataGridViewTextBoxColumn, Me.UserExtEmpDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ControlHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1022, 147)
        Me.DataGridView1.TabIndex = 9
        '
        'IdcontrolDataGridViewTextBoxColumn
        '
        Me.IdcontrolDataGridViewTextBoxColumn.DataPropertyName = "idcontrol"
        Me.IdcontrolDataGridViewTextBoxColumn.HeaderText = "idcontrol"
        Me.IdcontrolDataGridViewTextBoxColumn.Name = "IdcontrolDataGridViewTextBoxColumn"
        '
        'ChecktimeDataGridViewTextBoxColumn
        '
        Me.ChecktimeDataGridViewTextBoxColumn.DataPropertyName = "checktime"
        Me.ChecktimeDataGridViewTextBoxColumn.HeaderText = "checktime"
        Me.ChecktimeDataGridViewTextBoxColumn.Name = "ChecktimeDataGridViewTextBoxColumn"
        '
        'ChecktypeDataGridViewTextBoxColumn
        '
        Me.ChecktypeDataGridViewTextBoxColumn.DataPropertyName = "checktype"
        Me.ChecktypeDataGridViewTextBoxColumn.HeaderText = "checktype"
        Me.ChecktypeDataGridViewTextBoxColumn.Name = "ChecktypeDataGridViewTextBoxColumn"
        '
        'VerifycodeDataGridViewTextBoxColumn
        '
        Me.VerifycodeDataGridViewTextBoxColumn.DataPropertyName = "verifycode"
        Me.VerifycodeDataGridViewTextBoxColumn.HeaderText = "verifycode"
        Me.VerifycodeDataGridViewTextBoxColumn.Name = "VerifycodeDataGridViewTextBoxColumn"
        '
        'SensoridDataGridViewTextBoxColumn
        '
        Me.SensoridDataGridViewTextBoxColumn.DataPropertyName = "sensorid"
        Me.SensoridDataGridViewTextBoxColumn.HeaderText = "sensorid"
        Me.SensoridDataGridViewTextBoxColumn.Name = "SensoridDataGridViewTextBoxColumn"
        '
        'FinsemanaDataGridViewTextBoxColumn
        '
        Me.FinsemanaDataGridViewTextBoxColumn.DataPropertyName = "finsemana"
        Me.FinsemanaDataGridViewTextBoxColumn.HeaderText = "finsemana"
        Me.FinsemanaDataGridViewTextBoxColumn.Name = "FinsemanaDataGridViewTextBoxColumn"
        '
        'DiaDataGridViewTextBoxColumn
        '
        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "dia"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        '
        'WorkcodeDataGridViewTextBoxColumn
        '
        Me.WorkcodeDataGridViewTextBoxColumn.DataPropertyName = "workcode"
        Me.WorkcodeDataGridViewTextBoxColumn.HeaderText = "workcode"
        Me.WorkcodeDataGridViewTextBoxColumn.Name = "WorkcodeDataGridViewTextBoxColumn"
        '
        'SnDataGridViewTextBoxColumn
        '
        Me.SnDataGridViewTextBoxColumn.DataPropertyName = "sn"
        Me.SnDataGridViewTextBoxColumn.HeaderText = "sn"
        Me.SnDataGridViewTextBoxColumn.Name = "SnDataGridViewTextBoxColumn"
        '
        'UserExtEmpDataGridViewTextBoxColumn
        '
        Me.UserExtEmpDataGridViewTextBoxColumn.DataPropertyName = "userExtEmp"
        Me.UserExtEmpDataGridViewTextBoxColumn.HeaderText = "userExtEmp"
        Me.UserExtEmpDataGridViewTextBoxColumn.Name = "UserExtEmpDataGridViewTextBoxColumn"
        '
        'ControlHBindingSource
        '
        Me.ControlHBindingSource.DataMember = "controlH"
        Me.ControlHBindingSource.DataSource = Me.HourDataSetBindingSource1
        '
        'HourDataSetBindingSource1
        '
        Me.HourDataSetBindingSource1.DataSource = Me.HourDataSet
        Me.HourDataSetBindingSource1.Position = 0
        '
        'ControlHTableAdapter
        '
        Me.ControlHTableAdapter.ClearBeforeFill = True
        '
        'hourCheckout
        '
        Me.hourCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.hourCheckout.Location = New System.Drawing.Point(727, 143)
        Me.hourCheckout.Name = "hourCheckout"
        Me.hourCheckout.ShowUpDown = True
        Me.hourCheckout.Size = New System.Drawing.Size(99, 20)
        Me.hourCheckout.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hora de entrada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hora de salida:"
        '
        'hourCheckin
        '
        Me.hourCheckin.CustomFormat = "hh:mm:ss"
        Me.hourCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.hourCheckin.Location = New System.Drawing.Point(388, 141)
        Me.hourCheckin.Name = "hourCheckin"
        Me.hourCheckin.ShowUpDown = True
        Me.hourCheckin.Size = New System.Drawing.Size(94, 20)
        Me.hourCheckin.TabIndex = 14
        Me.hourCheckin.Value = New Date(2022, 6, 8, 13, 59, 0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 429)
        Me.Controls.Add(Me.hourCheckin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hourCheckout)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dateCheckout)
        Me.Controls.Add(Me.dateCheckin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Horario"
        CType(Me.HourDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxEmpleado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateCheckin As DateTimePicker
    Friend WithEvents dateCheckout As DateTimePicker
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents HourDataSetBindingSource As BindingSource
    Friend WithEvents HourDataSet As hourDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HourDataSetBindingSource1 As BindingSource
    Friend WithEvents ControlHBindingSource As BindingSource
    Friend WithEvents ControlHTableAdapter As hourDataSetTableAdapters.controlHTableAdapter
    Friend WithEvents IdcontrolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChecktimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChecktypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VerifycodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SensoridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinsemanaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserExtEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents hourCheckout As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents hourCheckin As DateTimePicker
End Class
