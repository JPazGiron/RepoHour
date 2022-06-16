Imports System.Data.SqlClient

Public Class Form1
    Private Sub cbxEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load

        cargaDB("select * from Empleado", DataGridView1)

        cbxEmpleado.DisplayMember = "idEmp"
        cbxEmpleado.ValueMember = "nombreEmp"


    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If dateCheckin.Checked > dateCheckout.Checked Then

            MsgBox("Error en las fechas de inicio o salida")

        End If


        Try



        Catch ex As Exception

            MsgBox("No puede generar este proceso")

        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '''Conexión a la bd
        Using conection As New SqlConnection("Data Source=DESKTOP-A3F4BPM;Initial Catalog=hour;Integrated Security=True")
            '''Consulta a bd
            Dim querySQL = New SqlCommand("insert into controlH (idcontrol,checktime,checktype,verifycode,sensorid,finsemana,dia,workcode,sn,userExtEmp) values (@idcontrol,@checktime,@checktype,@verifycode,@sensorid,@finsemana,@dia,@workcode,@sn,@userExtEmp)", conection)
            conection.Open()

            Dim fila As DataGridViewRow = New DataGridViewRow()

            '''For que recorre cada una de las columnas para realizar el guardado en la misma pocisión que en la bd
            For Each fila In DataGridView1.Rows

                querySQL.Parameters.Clear()

                querySQL.Parameters.AddWithValue("@idcontrol", Convert.ToString(fila.Cells(0).Value))
                querySQL.Parameters.AddWithValue("@checktime", Convert.ToString(fila.Cells(1).Value))
                querySQL.Parameters.AddWithValue("@checktype", Convert.ToString(fila.Cells(2).Value))
                querySQL.Parameters.AddWithValue("@verifycode", Convert.ToString(fila.Cells(3).Value))
                querySQL.Parameters.AddWithValue("@sensorid", Convert.ToString(fila.Cells(4).Value))
                querySQL.Parameters.AddWithValue("@finsemana", Convert.ToString(fila.Cells(5).Value))
                querySQL.Parameters.AddWithValue("@dia", Convert.ToString(fila.Cells(6).Value))
                querySQL.Parameters.AddWithValue("@workcode", Convert.ToString(fila.Cells(7).Value))
                querySQL.Parameters.AddWithValue("@sn", Convert.ToString(fila.Cells(8).Value))
                querySQL.Parameters.AddWithValue("@userExtEmp", Convert.ToString(fila.Cells(9).Value))

                querySQL.ExecuteNonQuery()

            Next

            MessageBox.Show("Datos agregados")

        End Using

    End Sub

End Class
