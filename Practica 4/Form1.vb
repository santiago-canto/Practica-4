Public Class Form1
    Dim Formato As Boolean = True
    Dim Start_Button As Boolean = False
    Dim Tiempo As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Iniciar los Timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Crear una variable, le asigna un valor, el valor es la fecha del dia de hoy convertida a string
        'En el formato de "dd 'de' MMMM 'del' yyyy"[dd. numero de dia, MMMM el mes en texto, yyyy para el año]
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = ""

        'Este es el formato de 24 h
        If Formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf Formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        Horas.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dia.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            Horas.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Fecha.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            Horas.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dia.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
        ElseIf color_texto = "Verde" Then
            Horas.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
        ElseIf color_texto = "Amarillo" Then
            Horas.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Formato = True Then
            Button1.Text = "12h"
            Formato = False
        ElseIf Formato = False Then
            Button1.Text = "24h"
            Formato = True
        End If
    End Sub

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Start_Button = False Then
            Timer3.Enabled = True
            Start_Button = True
            Start.Text = "Stop"
        ElseIf Start_Button = True Then
            Timer3.Enabled = False
            Start_Button = False
            Start.Text = "Start"

        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Tiempo = 0
        Timer3.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Tiempo = Tiempo + 1
        Crono.Text = Tiempo.ToString()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

End Class


