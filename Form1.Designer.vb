<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHitungMundur = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtWaktu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHitungMundur
        '
        Me.lblHitungMundur.AutoSize = True
        Me.lblHitungMundur.Location = New System.Drawing.Point(92, 50)
        Me.lblHitungMundur.Name = "lblHitungMundur"
        Me.lblHitungMundur.Size = New System.Drawing.Size(77, 13)
        Me.lblHitungMundur.TabIndex = 0
        Me.lblHitungMundur.Text = "Angka Mundur"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(94, 127)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtWaktu
        '
        Me.txtWaktu.Location = New System.Drawing.Point(82, 85)
        Me.txtWaktu.Name = "txtWaktu"
        Me.txtWaktu.Size = New System.Drawing.Size(100, 20)
        Me.txtWaktu.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtWaktu)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblHitungMundur)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHitungMundur As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtWaktu As System.Windows.Forms.TextBox

End Class
