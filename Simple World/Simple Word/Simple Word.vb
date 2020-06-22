

Public Class No1


    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim opf As New OpenFileDialog
        Dim doc As String
        opf.Filter = "(*.docx)|*.docx|(*.pdf)|*.pdf|(*.txt)|*.txt|All files (*.*)|*.*"
        If opf.ShowDialog(Me) = DialogResult.OK Then
            doc = opf.FileName
            TxtTulisBox.Text = My.Computer.FileSystem.ReadAllText(doc)
            MessageBox.Show("File sudah dibuka ^-^")
            StatusFile.Text = "Nama file kamu :" + opf.FileName
            Label1.Text = StatusFile.Text
        End If
    End Sub


    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        Dim dfb As DialogResult = MessageBox.Show("Ingin buat file baru ?", "Buat file baru", MessageBoxButtons.YesNo)
        If dfb = DialogResult.Yes Then
            TxtTulisBox.SelectAll()
            TxtTulisBox.SelectedText = ""
            MessageBox.Show("Kamu membuat file baru ^-^")
            StatusFile.Text = "Nama file kamu :" + ""
            Label1.Text = StatusFile.Text
        ElseIf dfb = DialogResult.No Then
            Dim opf As New OpenFileDialog
            StatusFile.Text = "Nama file kamu :" + opf.FileName
            Label1.Text = StatusFile.Text
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim svf As New SaveFileDialog
        Dim doc As String
        svf.Filter = "(*.docx)|*.docx|(*.pdf)|*.pdf|(*.txt)|*.txt|All files (*.*)|*.*"
        If svf.ShowDialog(Me) = DialogResult.OK Then
            doc = svf.FileName
            My.Computer.FileSystem.WriteAllText(doc, TxtTulisBox.Text, True)
            MessageBox.Show("Kamu telah save file ^-^")
            StatusFile.Text = "Nama file kamu :" + svf.FileName
            Label1.Text = StatusFile.Text
        End If

    End Sub


    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim svf As New SaveFileDialog
        Dim doc As String
        svf.Filter = "(*.docx)|*.docx|(*.pdf)|*.pdf|(*.txt)|*.txt|All files (*.*)|*.*"
        If svf.ShowDialog(Me) = DialogResult.OK Then
            doc = svf.FileName
            My.Computer.FileSystem.WriteAllText(doc, TxtTulisBox.Text, True)
            StatusFile.Text = "Kamu telah save file ^-^"
            StatusFile.Text = "Nama file kamu :" + svf.FileName
            Label1.Text = StatusFile.Text
        End If
    End Sub
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TxtTulisBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        TxtTulisBox.Redo()
    End Sub
    Private Sub AboutAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem.Click
        MessageBox.Show("Dibuat oleh Tech Source Code Store pada tanggal 22 Juni 2020.")
        MessageBox.Show("Terima kasih telah memakai aplikasi ini ^-^")
    End Sub


    Private Sub TebalkanHurufBoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TebalkanHurufBoldToolStripMenuItem.Click
        TxtTulisBox.SelectionFont = New Font(Me.TxtTulisBox.SelectionFont, FontStyle.Bold)
    End Sub

    Private Sub ImportGambarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportGambarToolStripMenuItem.Click
        Dim img As Image
        Dim opimg As New OpenFileDialog
        opimg.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp|All files (*.*)|*.*"
        If opimg.ShowDialog(Me) = DialogResult.OK Then

            img = Image.FromFile(opimg.FileName)
            Clipboard.SetImage(img)
            Me.TxtTulisBox.Paste()

        End If


    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim dfb As DialogResult = MessageBox.Show("Yakin ingin keluar , tanpa save file ?", "Keluar", MessageBoxButtons.YesNo)
        If dfb = DialogResult.Yes Then
            Close()
        ElseIf dfb = DialogResult.No Then
            Me.Show()
        End If
    End Sub
End Class
