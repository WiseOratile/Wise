Imports System.Data.OleDb
Public Class Admin
    Dim con As New OleDbConnection
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        If String.IsNullOrEmpty(txtAdminPassWrd.Text) And String.IsNullOrEmpty(txtAdminUser.Text) Then
            MessageBox.Show("Please Enter values", "Empty", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        Else
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Documents\CafeDatabase.accdb"
            con.Open()
            Dim loginAdmincmd As OleDbCommand = New OleDbCommand("Select * from Admin where [UserName]='" & txtAdminUser.Text & "'and [AdminPass]='" & txtAdminPassWrd.Text & "'", con)
            Dim loginAdminrd As OleDbDataReader = loginAdmincmd.ExecuteReader

            If (loginAdminrd.Read() = True) Then
                Me.Hide() ''Hide the form
                Registration.Show()
                MessageBox.Show("Login Successful", "Admin log in Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdminPassWrd.Text = ""
                txtAdminUser.Text = ""
                con.Close()
            Else
                MessageBox.Show("Login Failed, It's either Admin Password or username is incorrect", "Login Unsuccessful", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                txtAdminPassWrd.Text = ""
                txtAdminUser.Text = ""
                con.Close()
            End If

        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class