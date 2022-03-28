<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Source Han Sans CN Bold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(215, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What Do You Feel Today"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Using If Statement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Using Case Statement "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Day Of Week"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim message As String

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String
        If Now.DayOfWeek = System.DayOfWeek.Monday Then
            message = "Have a nice Week"
        Else
            If Now.DayOfWeek <= System.DayOfWeek.Tuesday And
                    Now.DayOfWeek <= System.DayOfWeek.Friday Then
                message = "Welcome back !"
            Else
                message = " Have a nice weekend !"
            End If
        End If
        MessageBox.Show(Message, "If Statement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim message As String
        Select Case Now.DayOfWeek
            Case System.DayOfWeek.Monday
                Message = "Have A Nice Week"
            Case System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday, System.DayOfWeek.Friday
                Message = "Welcome Back !"
            Case System.DayOfWeek.Saturday, System.DayOfWeek.Sunday
                Message = "Have aa nice Weekend !"
        End Select
        MessageBox.Show(Message, "Case Statement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
