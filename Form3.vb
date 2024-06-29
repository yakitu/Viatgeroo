Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button5.Focus()
        Button5.TabIndex = 2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Amaga el formulari actual
        Me.Hide()

        ' Crea una nova instancia del primer formulari
        Dim Form1 As New Form1

        ' Mostra el primer formulari en el mateix lloc que l'actual
        Form1.StartPosition = FormStartPosition.Manual
        Form1.Location = Me.Location

        ' Mostra el primer formulari
        Form1.Show()
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
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Dim tt As New ToolTip()
        tt.SetToolTip(PictureBox1, "Gaudeix del viatge amb VIATGEROO!")
    End Sub
    Private Sub TextBox4_GetFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        Dim tt As New ToolTip()
        tt.SetToolTip(TextBox4, "Introdueix només un número de telèfon")
    End Sub
End Class