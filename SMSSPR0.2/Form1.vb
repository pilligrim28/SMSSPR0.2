Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        panmenu.Visible = True

    End Sub




    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        panmenu.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub



    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        panmenu.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SprDataSet.smspr". При необходимости она может быть перемещена или удалена.
        Me.SmsprTableAdapter.Fill(Me.SprDataSet.smspr)

    End Sub
End Class
