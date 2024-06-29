Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() ' Centra el formulari al iniciar l'aplicació
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Amaga el formulari actual
        Me.Hide()

        ' Crea una nova instància del segon formulari
        Dim Form2 As New Form2

        ' Mostra el segon formulari en el mateix lloc que l'actual
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location

        ' Mostra el segon formulari
        Form2.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Amaga el formulari actual
        Me.Hide()

        ' Crea una nova instància del tercer formulari
        Dim Form3 As New Form3

        ' Mostra el tercer formulari en el mateix lloc que l'actual
        Form3.StartPosition = FormStartPosition.Manual
        Form3.Location = Me.Location

        ' Mostra el tercer formulari
        Form3.Show()
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Dim tt As New ToolTip()
        tt.SetToolTip(PictureBox1, "Gaudeix del viatge amb VIATGEROO!")
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim tt As New ToolTip()
        tt.SetToolTip(NumericUpDown1, "Màxim 10 passatgers")
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Dim tt As New ToolTip()
        tt.SetToolTip(NumericUpDown2, "Màxim 9 nens acompanyats d'un passatger adult")
    End Sub

    Private Sub TextBox4_GetFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        Dim tt As New ToolTip()
        tt.SetToolTip(TextBox4, "Introdueix només un número de telèfon")
    End Sub
End Class
