Imports System.IO

Public Class FrmSC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cm = New OleDb.OleDbCommand("insert into smspr (@kod, @name, @tm, @image) values ()", cn)
        Dim mstream As New MemoryStream
        ImagePictureBox.Image.Save(mstream, ImagePictureBox.Image.RawFormat)
        With cm
            .Parameters.AddWithValue("@kod", KodTextBox.Text)
            .Parameters.AddWithValue("@name", NameTextBox.Text)
            .Parameters.AddWithValue("@tm", TmComboBox.SelectedItem)
            .Parameters.AddWithValue("@image", mstream.ToArray)

        End With

        cn.Close()
    End Sub
End Class