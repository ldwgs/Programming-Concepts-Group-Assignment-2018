Option Strict On
Imports System.Data.OleDb

Public Class formAddStudent
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Dim path As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'RESOURCE: https://www.youtube.com/watch?v=UtE3kkQR7_w'

        'Insert this code for your ADD button click'
        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" 'This should work for all access database versions since its the oldest one. Change the version to match your computer's if it still doesnt work'
        dataFile = "C:\Users\lute_\Downloads\Programming-Concepts-Assignment-master\Assignment 1\Database.mdb" 'This is where your access database is located.'
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim sql As String
        sql = "INSERT INTO Students([StudentID],[FirstName],[LastName],[Course],[Username],[Password]) VALUES (?,?,?,?,?,?)" 'This is the SQL script which you need to change based on the way your tables are structured. Here, my table name is STUDENTS and i have a couple of columns for data entry'
        Dim cmd As OleDbCommand = New OleDbCommand(sql, myConnection)
        cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtStudentID.Text, String))) 'Inserts the text that's in the text box into the StudentID column in the database'
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFirstName.Text, String))) 'Inserts the text that's in the text box into the FirstName column in the database'
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtLastName.Text, String))) 'Inserts the text that's in the text box into the LastName column in the database'
        cmd.Parameters.Add(New OleDbParameter("Course", CType(txtCourse.Text, String))) 'Inserts the text that's in the text box into the Course column in the database'
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtUsername.Text, String))) 'Inserts the text that's in the text box into the Username column in the database'
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String))) 'Inserts the text that's in the text box into the Password column in the database'

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MessageBox.Show("Student added! Student: " + txtFirstName.Text + " " + txtLastName.Text) 'Verification that the student has been registered onto the database'
            myConnection.Close()
            txtStudentID.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MessageBox.Show("Error detected! Error: " + ex.ToString) 'If there is an error, this line of code catches the error text and outputs it to you in a way you can understand what went wrong'
        End Try
    End Sub

    Private Sub chooseFolder()
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class