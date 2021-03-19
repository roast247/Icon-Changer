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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoastingLabel = New System.Windows.Forms.Label()
        Me.RoastingPic = New System.Windows.Forms.PictureBox()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.changeico = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.addexe = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.addico = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RoastingLabel)
        Me.Panel1.Controls.Add(Me.RoastingPic)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 25)
        Me.Panel1.TabIndex = 0
        '
        'RoastingLabel
        '
        Me.RoastingLabel.AutoSize = True
        Me.RoastingLabel.Location = New System.Drawing.Point(31, 6)
        Me.RoastingLabel.Name = "RoastingLabel"
        Me.RoastingLabel.Size = New System.Drawing.Size(119, 14)
        Me.RoastingLabel.TabIndex = 2
        Me.RoastingLabel.Text = "Roasting Icon Changer "
        '
        'RoastingPic
        '
        Me.RoastingPic.BackColor = System.Drawing.Color.Transparent
        Me.RoastingPic.Image = Global.Roasting_Icon_Changer.My.Resources.Resources.icon_changer
        Me.RoastingPic.Location = New System.Drawing.Point(0, 0)
        Me.RoastingPic.Name = "RoastingPic"
        Me.RoastingPic.Size = New System.Drawing.Size(25, 25)
        Me.RoastingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoastingPic.TabIndex = 1
        Me.RoastingPic.TabStop = False
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Red
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Location = New System.Drawing.Point(321, 0)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(25, 25)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'changeico
        '
        Me.changeico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeico.Location = New System.Drawing.Point(128, 102)
        Me.changeico.Name = "changeico"
        Me.changeico.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.changeico.Size = New System.Drawing.Size(90, 20)
        Me.changeico.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeico.TabIndex = 29
        Me.changeico.Values.Text = "Change"
        '
        'addexe
        '
        Me.addexe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addexe.Location = New System.Drawing.Point(165, 36)
        Me.addexe.Name = "addexe"
        Me.addexe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.addexe.Size = New System.Drawing.Size(90, 20)
        Me.addexe.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addexe.TabIndex = 30
        Me.addexe.Values.Text = "Add EXE File"
        '
        'addico
        '
        Me.addico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addico.Location = New System.Drawing.Point(165, 70)
        Me.addico.Name = "addico"
        Me.addico.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.addico.Size = New System.Drawing.Size(90, 20)
        Me.addico.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addico.TabIndex = 31
        Me.addico.Values.Text = "Add Icon"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 36)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 33
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.Roasting_Icon_Changer.My.Resources.Resources.birdy
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox1.Location = New System.Drawing.Point(270, 36)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 28
        Me.pictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(346, 132)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addico)
        Me.Controls.Add(Me.addexe)
        Me.Controls.Add(Me.changeico)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closebtn As Button
    Friend WithEvents RoastingLabel As Label
    Friend WithEvents RoastingPic As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents changeico As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents addexe As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents addico As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
