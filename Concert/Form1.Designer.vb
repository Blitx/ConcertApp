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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PicEminem = New System.Windows.Forms.PictureBox()
        Me.PicSheeran = New System.Windows.Forms.PictureBox()
        Me.PicGreenday = New System.Windows.Forms.PictureBox()
        Me.lblPick = New System.Windows.Forms.Label()
        Me.lblEminem = New System.Windows.Forms.Label()
        Me.lblSheeran = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRap = New System.Windows.Forms.Label()
        Me.lblPop = New System.Windows.Forms.Label()
        Me.lblRock = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.LblEminemFact = New System.Windows.Forms.Label()
        Me.LblSheeranFact = New System.Windows.Forms.Label()
        Me.LblGreendayFact = New System.Windows.Forms.Label()
        CType(Me.PicEminem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSheeran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGreenday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Any Day music festival"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicEminem
        '
        Me.PicEminem.ErrorImage = CType(resources.GetObject("PicEminem.ErrorImage"), System.Drawing.Image)
        Me.PicEminem.Image = CType(resources.GetObject("PicEminem.Image"), System.Drawing.Image)
        Me.PicEminem.InitialImage = CType(resources.GetObject("PicEminem.InitialImage"), System.Drawing.Image)
        Me.PicEminem.Location = New System.Drawing.Point(15, 135)
        Me.PicEminem.Name = "PicEminem"
        Me.PicEminem.Size = New System.Drawing.Size(250, 150)
        Me.PicEminem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicEminem.TabIndex = 1
        Me.PicEminem.TabStop = False
        '
        'PicSheeran
        '
        Me.PicSheeran.Image = CType(resources.GetObject("PicSheeran.Image"), System.Drawing.Image)
        Me.PicSheeran.Location = New System.Drawing.Point(271, 135)
        Me.PicSheeran.Name = "PicSheeran"
        Me.PicSheeran.Size = New System.Drawing.Size(264, 150)
        Me.PicSheeran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSheeran.TabIndex = 1
        Me.PicSheeran.TabStop = False
        '
        'PicGreenday
        '
        Me.PicGreenday.Image = CType(resources.GetObject("PicGreenday.Image"), System.Drawing.Image)
        Me.PicGreenday.Location = New System.Drawing.Point(541, 135)
        Me.PicGreenday.Name = "PicGreenday"
        Me.PicGreenday.Size = New System.Drawing.Size(250, 150)
        Me.PicGreenday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicGreenday.TabIndex = 1
        Me.PicGreenday.TabStop = False
        '
        'lblPick
        '
        Me.lblPick.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPick.AutoEllipsis = True
        Me.lblPick.Location = New System.Drawing.Point(12, 43)
        Me.lblPick.Name = "lblPick"
        Me.lblPick.Size = New System.Drawing.Size(776, 49)
        Me.lblPick.TabIndex = 2
        Me.lblPick.Text = "Pick your artist"
        Me.lblPick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEminem
        '
        Me.lblEminem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEminem.Location = New System.Drawing.Point(15, 288)
        Me.lblEminem.Name = "lblEminem"
        Me.lblEminem.Size = New System.Drawing.Size(250, 14)
        Me.lblEminem.TabIndex = 3
        Me.lblEminem.Text = "Eminem"
        Me.lblEminem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSheeran
        '
        Me.lblSheeran.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSheeran.Location = New System.Drawing.Point(271, 288)
        Me.lblSheeran.Name = "lblSheeran"
        Me.lblSheeran.Size = New System.Drawing.Size(264, 14)
        Me.lblSheeran.TabIndex = 3
        Me.lblSheeran.Text = "Ed Sheeran"
        Me.lblSheeran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreen
        '
        Me.lblGreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGreen.Location = New System.Drawing.Point(541, 288)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(250, 14)
        Me.lblGreen.TabIndex = 3
        Me.lblGreen.Text = "Green Day"
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRap
        '
        Me.lblRap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRap.Location = New System.Drawing.Point(15, 302)
        Me.lblRap.Name = "lblRap"
        Me.lblRap.Size = New System.Drawing.Size(250, 14)
        Me.lblRap.TabIndex = 3
        Me.lblRap.Text = "Rap"
        Me.lblRap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPop
        '
        Me.lblPop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPop.Location = New System.Drawing.Point(271, 302)
        Me.lblPop.Name = "lblPop"
        Me.lblPop.Size = New System.Drawing.Size(264, 14)
        Me.lblPop.TabIndex = 3
        Me.lblPop.Text = "Pop"
        Me.lblPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRock
        '
        Me.lblRock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRock.Location = New System.Drawing.Point(541, 302)
        Me.lblRock.Name = "lblRock"
        Me.lblRock.Size = New System.Drawing.Size(250, 14)
        Me.lblRock.TabIndex = 3
        Me.lblRock.Text = "Rock"
        Me.lblRock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(713, 415)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(12, 9)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuit.TabIndex = 4
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'LblEminemFact
        '
        Me.LblEminemFact.AutoSize = True
        Me.LblEminemFact.Location = New System.Drawing.Point(12, 336)
        Me.LblEminemFact.Name = "LblEminemFact"
        Me.LblEminemFact.Size = New System.Drawing.Size(252, 13)
        Me.LblEminemFact.TabIndex = 5
        Me.LblEminemFact.Text = "Fun Fact: Eminem wanted to be a comic book artist."
        Me.LblEminemFact.Visible = False
        '
        'LblSheeranFact
        '
        Me.LblSheeranFact.AutoSize = True
        Me.LblSheeranFact.Location = New System.Drawing.Point(268, 336)
        Me.LblSheeranFact.Name = "LblSheeranFact"
        Me.LblSheeranFact.Size = New System.Drawing.Size(188, 13)
        Me.LblSheeranFact.TabIndex = 5
        Me.LblSheeranFact.Text = "Fun Fact: Ed Sheeran is also an actor."
        Me.LblSheeranFact.Visible = False
        '
        'LblGreendayFact
        '
        Me.LblGreendayFact.AutoSize = True
        Me.LblGreendayFact.Location = New System.Drawing.Point(538, 336)
        Me.LblGreendayFact.Name = "LblGreendayFact"
        Me.LblGreendayFact.Size = New System.Drawing.Size(243, 13)
        Me.LblGreendayFact.TabIndex = 5
        Me.LblGreendayFact.Text = "Fun Fact: Green Day has been active since 1987."
        Me.LblGreendayFact.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblGreendayFact)
        Me.Controls.Add(Me.LblSheeranFact)
        Me.Controls.Add(Me.LblEminemFact)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.lblRock)
        Me.Controls.Add(Me.lblPop)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRap)
        Me.Controls.Add(Me.lblSheeran)
        Me.Controls.Add(Me.lblEminem)
        Me.Controls.Add(Me.lblPick)
        Me.Controls.Add(Me.PicGreenday)
        Me.Controls.Add(Me.PicSheeran)
        Me.Controls.Add(Me.PicEminem)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Any Day ticket purchase"
        CType(Me.PicEminem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSheeran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGreenday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PicEminem As PictureBox
    Friend WithEvents PicSheeran As PictureBox
    Friend WithEvents PicGreenday As PictureBox
    Friend WithEvents lblPick As Label
    Friend WithEvents lblEminem As Label
    Friend WithEvents lblSheeran As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblRap As Label
    Friend WithEvents lblPop As Label
    Friend WithEvents lblRock As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents LblEminemFact As Label
    Friend WithEvents LblSheeranFact As Label
    Friend WithEvents LblGreendayFact As Label
End Class
