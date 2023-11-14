Imports System.Data
Imports System.Data.Odbc
Module KoneksiDB
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public da2 As OdbcDataAdapter
    Public ds2 As DataSet
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public str As String
    Public Sub KonekDB()
        Try
            str = "Driver={MYSQL ODBC 8.0 ANSI Driver};database=toko_souvenir;server=localhost;user=root;password="
            conn = New OdbcConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub TampilData(ByVal sqldata As String, ByVal sqltabel As String)
        Try
            da = New Data.Odbc.OdbcDataAdapter(sqldata, conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, sqltabel)
        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Error")
        End Try
    End Sub
    Sub ProsesSQL(ByVal sqlisi As String)
        Try
            Call KonekDB()
            Dim sqlquery As New Odbc.OdbcCommand
            sqlquery.Connection = conn
            sqlquery.CommandType = CommandType.Text
            sqlquery.CommandText = sqlisi
            sqlquery.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Error")
        End Try
    End Sub
    Function CariData(ByVal sqlisi As String) As Boolean
        Try
            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = sqlisi
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), 16, "Error")
        End Try
    End Function
End Module
