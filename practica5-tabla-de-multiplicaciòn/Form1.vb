Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Integer
        Label3.Text = ""
        Try    
            For i = 1 To 10 Step 1
                res = TextBox1.Text * i
                Label3.Text = Label3.Text & TextBox1.Text & " X " & i & " = " & res & Chr(13)
            Next i
        Catch ex As Exception
            MsgBox("Debes ingresar un numero válido")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Ingresa un numero en el campo"
        TextBox1.Text = "Ingresa un numero"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Ingresa un numero"

    End Sub
End Class
