<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(653, 641)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.Color.Black
        Me.Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.Color.White
        Me.Horas.Location = New System.Drawing.Point(242, 286)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(66, 46)
        Me.Horas.TabIndex = 1
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(314, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.Black
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.White
        Me.Fecha.Location = New System.Drawing.Point(237, 364)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(171, 21)
        Me.Fecha.TabIndex = 3
        Me.Fecha.Text = "13 de Marzo del 2026"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.Color.Black
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.Color.White
        Me.Minutos.Location = New System.Drawing.Point(348, 286)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(66, 46)
        Me.Minutos.TabIndex = 4
        Me.Minutos.Text = "00"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.BackColor = System.Drawing.Color.Black
        Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.Color.White
        Me.Dia.Location = New System.Drawing.Point(288, 344)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(70, 20)
        Me.Dia.TabIndex = 5
        Me.Dia.Text = "Viernes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(654, 629)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dia As Label
End Class
