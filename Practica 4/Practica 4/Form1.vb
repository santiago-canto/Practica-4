Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        Horas.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Dia.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Horas.Text = ":" Then
            Horas.Text = ""
        ElseIf Horas.Text = "" Then
            Horas.Text = ":"
        End If
    End Sub
End Class
