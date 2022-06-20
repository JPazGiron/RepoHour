Imports System.IO
Imports System.Data.SqlClient

Module conec

    Public cnn As SqlConnection

    Dim strConnect As String = "Data Source=DESKTOP-A3F4BPM;Initial Catalog=hour;Integrated Security=True"

    Public Sub cargaDB(ByVal xsql As String, ByVal grid As DataGridView)
        Dim conta As New Integer

        Dim conexion As New SqlConnection

        conexion.ConnectionString = strConnect

        Dim oComando As New SqlCommand(xsql, conexion)

        Dim Tabla As New DataTable

        Dim adapter As New SqlDataAdapter(xsql, strConnect)

        Tabla.Clear()

        adapter.Fill(Tabla)

        grid.DataSource = Tabla






    End Sub

End Module
