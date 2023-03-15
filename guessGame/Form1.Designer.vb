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
        Me.lbloutput1 = New System.Windows.Forms.Label()
        Me.lbloutput4 = New System.Windows.Forms.Label()
        Me.lbloutput3 = New System.Windows.Forms.Label()
        Me.lbloutput2 = New System.Windows.Forms.Label()
        Me.textInput = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(222, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess The Country"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbloutput1
        '
        Me.lbloutput1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbloutput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput1.Location = New System.Drawing.Point(23, 252)
        Me.lbloutput1.Name = "lbloutput1"
        Me.lbloutput1.Size = New System.Drawing.Size(212, 35)
        Me.lbloutput1.TabIndex = 5
        Me.lbloutput1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbloutput4
        '
        Me.lbloutput4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbloutput4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput4.Location = New System.Drawing.Point(740, 252)
        Me.lbloutput4.Name = "lbloutput4"
        Me.lbloutput4.Size = New System.Drawing.Size(212, 35)
        Me.lbloutput4.TabIndex = 7
        Me.lbloutput4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbloutput3
        '
        Me.lbloutput3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbloutput3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput3.Location = New System.Drawing.Point(503, 252)
        Me.lbloutput3.Name = "lbloutput3"
        Me.lbloutput3.Size = New System.Drawing.Size(212, 35)
        Me.lbloutput3.TabIndex = 8
        Me.lbloutput3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbloutput2
        '
        Me.lbloutput2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbloutput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput2.Location = New System.Drawing.Point(266, 252)
        Me.lbloutput2.Name = "lbloutput2"
        Me.lbloutput2.Size = New System.Drawing.Size(212, 35)
        Me.lbloutput2.TabIndex = 9
        Me.lbloutput2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textInput
        '
        Me.textInput.Location = New System.Drawing.Point(188, 353)
        Me.textInput.Name = "textInput"
        Me.textInput.Size = New System.Drawing.Size(574, 26)
        Me.textInput.TabIndex = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.guessGame.My.Resources.Resources.brazil
        Me.PictureBox4.Location = New System.Drawing.Point(744, 96)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(208, 139)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.guessGame.My.Resources.Resources.Flag_of_Turkey_svg
        Me.PictureBox3.Location = New System.Drawing.Point(270, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(208, 139)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.guessGame.My.Resources.Resources.Flag_of_France_svg
        Me.PictureBox2.Location = New System.Drawing.Point(507, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(208, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.guessGame.My.Resources.Resources.Flag_of_Somalia_svg
        Me.PictureBox1.Location = New System.Drawing.Point(27, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 524)
        Me.Controls.Add(Me.textInput)
        Me.Controls.Add(Me.lbloutput2)
        Me.Controls.Add(Me.lbloutput3)
        Me.Controls.Add(Me.lbloutput4)
        Me.Controls.Add(Me.lbloutput1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lbloutput1 As Label
    Friend WithEvents lbloutput4 As Label
    Friend WithEvents lbloutput3 As Label
    Friend WithEvents lbloutput2 As Label
    Friend WithEvents textInput As TextBox
End Class
