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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cardNo = New System.Windows.Forms.TextBox()
        Me.cardHolder = New System.Windows.Forms.TextBox()
        Me.cardCVV = New System.Windows.Forms.TextBox()
        Me.amountVal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cardType = New System.Windows.Forms.Label()
        Me.cardLogoAE = New System.Windows.Forms.PictureBox()
        Me.cardLogoMC = New System.Windows.Forms.PictureBox()
        Me.cardLogoVi = New System.Windows.Forms.PictureBox()
        Me.cardLogoNo = New System.Windows.Forms.PictureBox()
        Me.cardLogoDC = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cvvMM = New System.Windows.Forms.ComboBox()
        Me.cvvYYYY = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.toAcc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.cvvShow = New System.Windows.Forms.Button()
        CType(Me.cardLogoAE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardLogoMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardLogoVi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardLogoNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardLogoDC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardNo
        '
        Me.cardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardNo.Location = New System.Drawing.Point(419, 214)
        Me.cardNo.Multiline = True
        Me.cardNo.Name = "cardNo"
        Me.cardNo.Size = New System.Drawing.Size(396, 46)
        Me.cardNo.TabIndex = 0
        '
        'cardHolder
        '
        Me.cardHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardHolder.Location = New System.Drawing.Point(419, 291)
        Me.cardHolder.Multiline = True
        Me.cardHolder.Name = "cardHolder"
        Me.cardHolder.Size = New System.Drawing.Size(396, 41)
        Me.cardHolder.TabIndex = 0
        '
        'cardCVV
        '
        Me.cardCVV.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardCVV.Location = New System.Drawing.Point(419, 356)
        Me.cardCVV.Multiline = True
        Me.cardCVV.Name = "cardCVV"
        Me.cardCVV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cardCVV.Size = New System.Drawing.Size(396, 41)
        Me.cardCVV.TabIndex = 0
        Me.cardCVV.UseSystemPasswordChar = True
        '
        'amountVal
        '
        Me.amountVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountVal.Location = New System.Drawing.Point(419, 535)
        Me.amountVal.Multiline = True
        Me.amountVal.Name = "amountVal"
        Me.amountVal.Size = New System.Drawing.Size(262, 43)
        Me.amountVal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Card Number"
        '
        'cardType
        '
        Me.cardType.AutoSize = True
        Me.cardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardType.Location = New System.Drawing.Point(970, 225)
        Me.cardType.Name = "cardType"
        Me.cardType.Size = New System.Drawing.Size(99, 38)
        Me.cardType.TabIndex = 2
        Me.cardType.Text = "None"
        '
        'cardLogoAE
        '
        Me.cardLogoAE.Image = Global.Bill_Desk.My.Resources.Resource1.american_express
        Me.cardLogoAE.Location = New System.Drawing.Point(860, 221)
        Me.cardLogoAE.Name = "cardLogoAE"
        Me.cardLogoAE.Size = New System.Drawing.Size(60, 50)
        Me.cardLogoAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardLogoAE.TabIndex = 3
        Me.cardLogoAE.TabStop = False
        '
        'cardLogoMC
        '
        Me.cardLogoMC.Image = Global.Bill_Desk.My.Resources.Resource1.mastercard
        Me.cardLogoMC.Location = New System.Drawing.Point(860, 221)
        Me.cardLogoMC.Name = "cardLogoMC"
        Me.cardLogoMC.Size = New System.Drawing.Size(60, 50)
        Me.cardLogoMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardLogoMC.TabIndex = 3
        Me.cardLogoMC.TabStop = False
        '
        'cardLogoVi
        '
        Me.cardLogoVi.Image = Global.Bill_Desk.My.Resources.Resource1.visa
        Me.cardLogoVi.Location = New System.Drawing.Point(860, 221)
        Me.cardLogoVi.Name = "cardLogoVi"
        Me.cardLogoVi.Size = New System.Drawing.Size(60, 50)
        Me.cardLogoVi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardLogoVi.TabIndex = 3
        Me.cardLogoVi.TabStop = False
        '
        'cardLogoNo
        '
        Me.cardLogoNo.Image = CType(resources.GetObject("cardLogoNo.Image"), System.Drawing.Image)
        Me.cardLogoNo.Location = New System.Drawing.Point(860, 221)
        Me.cardLogoNo.Name = "cardLogoNo"
        Me.cardLogoNo.Size = New System.Drawing.Size(60, 50)
        Me.cardLogoNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardLogoNo.TabIndex = 3
        Me.cardLogoNo.TabStop = False
        '
        'cardLogoDC
        '
        Me.cardLogoDC.Image = CType(resources.GetObject("cardLogoDC.Image"), System.Drawing.Image)
        Me.cardLogoDC.Location = New System.Drawing.Point(860, 221)
        Me.cardLogoDC.Name = "cardLogoDC"
        Me.cardLogoDC.Size = New System.Drawing.Size(60, 50)
        Me.cardLogoDC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardLogoDC.TabIndex = 3
        Me.cardLogoDC.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Card Holder Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CVV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Expiry Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 534)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Month"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(696, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(571, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 36)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "/"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(624, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 38)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "20"
        '
        'cvvMM
        '
        Me.cvvMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cvvMM.FormattingEnabled = True
        Me.cvvMM.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cvvMM.Location = New System.Drawing.Point(419, 462)
        Me.cvvMM.Name = "cvvMM"
        Me.cvvMM.Size = New System.Drawing.Size(121, 39)
        Me.cvvMM.TabIndex = 9
        '
        'cvvYYYY
        '
        Me.cvvYYYY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvvYYYY.FormattingEnabled = True
        Me.cvvYYYY.Items.AddRange(New Object() {"20", "21", "22", "23", "24", "25", "26", "27", "28"})
        Me.cvvYYYY.Location = New System.Drawing.Point(694, 463)
        Me.cvvYYYY.Name = "cvvYYYY"
        Me.cvvYYYY.Size = New System.Drawing.Size(121, 39)
        Me.cvvYYYY.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(516, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(335, 38)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Pay - Way Bill Desk "
        '
        'toAcc
        '
        Me.toAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toAcc.Location = New System.Drawing.Point(419, 142)
        Me.toAcc.Multiline = True
        Me.toAcc.Name = "toAcc"
        Me.toAcc.Size = New System.Drawing.Size(396, 46)
        Me.toAcc.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 36)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "To Account No"
        '
        'submitBtn
        '
        Me.submitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.Location = New System.Drawing.Point(622, 682)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(173, 43)
        Me.submitBtn.TabIndex = 6
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'cvvShow
        '
        Me.cvvShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvvShow.Location = New System.Drawing.Point(875, 356)
        Me.cvvShow.Name = "cvvShow"
        Me.cvvShow.Size = New System.Drawing.Size(105, 41)
        Me.cvvShow.TabIndex = 12
        Me.cvvShow.Text = "Show"
        Me.cvvShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 835)
        Me.Controls.Add(Me.cvvShow)
        Me.Controls.Add(Me.toAcc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cvvYYYY)
        Me.Controls.Add(Me.cvvMM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cardLogoNo)
        Me.Controls.Add(Me.cardLogoAE)
        Me.Controls.Add(Me.cardType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cardCVV)
        Me.Controls.Add(Me.cardHolder)
        Me.Controls.Add(Me.amountVal)
        Me.Controls.Add(Me.cardNo)
        Me.Controls.Add(Me.cardLogoDC)
        Me.Controls.Add(Me.cardLogoVi)
        Me.Controls.Add(Me.cardLogoMC)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2"
        CType(Me.cardLogoAE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardLogoMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardLogoVi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardLogoNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardLogoDC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cardNo As TextBox
    Friend WithEvents cardHolder As TextBox
    Friend WithEvents cardCVV As TextBox
    Friend WithEvents amountVal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cardType As Label
    Friend WithEvents cardLogoAE As PictureBox
    Friend WithEvents cardLogoMC As PictureBox
    Friend WithEvents cardLogoVi As PictureBox
    Friend WithEvents cardLogoNo As PictureBox
    Friend WithEvents cardLogoDC As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cvvMM As ComboBox
    Friend WithEvents cvvYYYY As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents toAcc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents cvvShow As Button
End Class
