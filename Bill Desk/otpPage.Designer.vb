<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class otpPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(otpPage))
        Me.otpTxt = New System.Windows.Forms.TextBox()
        Me.transactNow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showOTP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'otpTxt
        '
        Me.otpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otpTxt.Location = New System.Drawing.Point(182, 191)
        Me.otpTxt.Multiline = True
        Me.otpTxt.Name = "otpTxt"
        Me.otpTxt.Size = New System.Drawing.Size(250, 47)
        Me.otpTxt.TabIndex = 1
        '
        'transactNow
        '
        Me.transactNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactNow.Location = New System.Drawing.Point(300, 286)
        Me.transactNow.Name = "transactNow"
        Me.transactNow.Size = New System.Drawing.Size(175, 54)
        Me.transactNow.TabIndex = 0
        Me.transactNow.Text = "Submit"
        Me.transactNow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "OTP (8-Digit Password)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OTP (8-Digit Password)"
        '
        'showOTP
        '
        Me.showOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showOTP.Location = New System.Drawing.Point(481, 191)
        Me.showOTP.Name = "showOTP"
        Me.showOTP.Size = New System.Drawing.Size(135, 47)
        Me.showOTP.TabIndex = 0
        Me.showOTP.Text = "Show"
        Me.showOTP.UseVisualStyleBackColor = True
        '
        'otpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(742, 365)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.otpTxt)
        Me.Controls.Add(Me.showOTP)
        Me.Controls.Add(Me.transactNow)
        Me.Name = "otpPage"
        Me.Text = "otpPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents otpTxt As TextBox
    Friend WithEvents transactNow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents showOTP As Button
End Class
