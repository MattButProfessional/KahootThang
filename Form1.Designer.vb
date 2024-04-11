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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenQuestionJSON = New System.Windows.Forms.OpenFileDialog()
        Me.pnlButtonTimeYippee = New System.Windows.Forms.Panel()
        Me.TimeIsEnding = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAHHHHHHH = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(12, 24)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(776, 142)
        Me.lblQuestion.TabIndex = 4
        Me.lblQuestion.Text = "are you do have stupid"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Image = Global.KahootThang.My.Resources.Resources.purple_circle_light_md
        Me.lblTimer.Location = New System.Drawing.Point(34, 169)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(50, 52)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "20"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.KahootThang.My.Resources.Resources.purple_circle_light_md
        Me.PictureBox1.Location = New System.Drawing.Point(12, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(560, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Score:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(662, 202)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(84, 39)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ResetGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ResetGameToolStripMenuItem
        '
        Me.ResetGameToolStripMenuItem.Name = "ResetGameToolStripMenuItem"
        Me.ResetGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetGameToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ResetGameToolStripMenuItem.Text = "Reset Game"
        '
        'OpenQuestionJSON
        '
        Me.OpenQuestionJSON.DefaultExt = "json"
        Me.OpenQuestionJSON.FileName = "OpenFileDialog1"
        '
        'pnlButtonTimeYippee
        '
        Me.pnlButtonTimeYippee.BackColor = System.Drawing.Color.Transparent
        Me.pnlButtonTimeYippee.Location = New System.Drawing.Point(12, 247)
        Me.pnlButtonTimeYippee.Name = "pnlButtonTimeYippee"
        Me.pnlButtonTimeYippee.Size = New System.Drawing.Size(776, 191)
        Me.pnlButtonTimeYippee.TabIndex = 11
        Me.pnlButtonTimeYippee.Tag = "Correct"
        '
        'TimeIsEnding
        '
        Me.TimeIsEnding.Enabled = True
        Me.TimeIsEnding.Interval = 1000
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(108, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 39)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Question:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAHHHHHHH
        '
        Me.lblAHHHHHHH.BackColor = System.Drawing.Color.Transparent
        Me.lblAHHHHHHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAHHHHHHH.ForeColor = System.Drawing.Color.White
        Me.lblAHHHHHHH.Location = New System.Drawing.Point(253, 202)
        Me.lblAHHHHHHH.Name = "lblAHHHHHHH"
        Me.lblAHHHHHHH.Size = New System.Drawing.Size(72, 39)
        Me.lblAHHHHHHH.TabIndex = 13
        Me.lblAHHHHHHH.Text = "1"
        Me.lblAHHHHHHH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KahootThang.My.Resources.Resources.i_am_in_50_liters_of_sulfuric_acid
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAHHHHHHH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlButtonTimeYippee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Kahoot"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenQuestionJSON As OpenFileDialog
    Friend WithEvents pnlButtonTimeYippee As Panel
    Friend WithEvents ResetGameToolStripMenuItem As ToolStripMenuItem
    Public WithEvents TimeIsEnding As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAHHHHHHH As Label
End Class
