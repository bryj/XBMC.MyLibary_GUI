Public Class Form1

    Dim file As String

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoadConfigFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadConfigFileToolStripMenuItem.Click
        OpenFileDialog1.FileName = "Config.xml"
        OpenFileDialog1.Filter = "XML files (*.xml)|*.xml"
        file = OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub
End Class
