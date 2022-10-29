<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcFu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProcFu))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnilai1 = New System.Windows.Forms.TextBox()
        Me.Txtnilai2 = New System.Windows.Forms.TextBox()
        Me.cmdprocedureDP = New System.Windows.Forms.Button()
        Me.cmdfunctionDP = New System.Windows.Forms.Button()
        Me.cmdfunctionTP = New System.Windows.Forms.Button()
        Me.cmdprocedureTP = New System.Windows.Forms.Button()
        Me.cmdhitungP = New System.Windows.Forms.Button()
        Me.cmdhitungF = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbjari = New System.Windows.Forms.TextBox()
        Me.tbdiam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkeliling = New System.Windows.Forms.TextBox()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(835, 295)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdhitungF)
        Me.TabPage2.Controls.Add(Me.cmdhitungP)
        Me.TabPage2.Controls.Add(Me.Txtnilai2)
        Me.TabPage2.Controls.Add(Me.Txtnilai1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txthasil)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(827, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Latihan 1"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdfunctionDP)
        Me.GroupBox1.Controls.Add(Me.cmdprocedureDP)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dengan Parameter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdfunctionTP)
        Me.GroupBox2.Controls.Add(Me.cmdprocedureTP)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 78)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tanpa Parameter"
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(44, 106)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(714, 20)
        Me.txthasil.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nilai 2"
        '
        'Txtnilai1
        '
        Me.Txtnilai1.Location = New System.Drawing.Point(119, 145)
        Me.Txtnilai1.Name = "Txtnilai1"
        Me.Txtnilai1.Size = New System.Drawing.Size(639, 20)
        Me.Txtnilai1.TabIndex = 5
        Me.Txtnilai1.Text = "7"
        '
        'Txtnilai2
        '
        Me.Txtnilai2.Location = New System.Drawing.Point(119, 174)
        Me.Txtnilai2.Name = "Txtnilai2"
        Me.Txtnilai2.Size = New System.Drawing.Size(639, 20)
        Me.Txtnilai2.TabIndex = 6
        Me.Txtnilai2.Text = "5"
        '
        'cmdprocedureDP
        '
        Me.cmdprocedureDP.Location = New System.Drawing.Point(7, 28)
        Me.cmdprocedureDP.Name = "cmdprocedureDP"
        Me.cmdprocedureDP.Size = New System.Drawing.Size(146, 44)
        Me.cmdprocedureDP.TabIndex = 0
        Me.cmdprocedureDP.Text = "Procedure"
        Me.cmdprocedureDP.UseVisualStyleBackColor = True
        '
        'cmdfunctionDP
        '
        Me.cmdfunctionDP.Location = New System.Drawing.Point(175, 28)
        Me.cmdfunctionDP.Name = "cmdfunctionDP"
        Me.cmdfunctionDP.Size = New System.Drawing.Size(146, 44)
        Me.cmdfunctionDP.TabIndex = 1
        Me.cmdfunctionDP.Text = "Function"
        Me.cmdfunctionDP.UseVisualStyleBackColor = True
        '
        'cmdfunctionTP
        '
        Me.cmdfunctionTP.Location = New System.Drawing.Point(183, 24)
        Me.cmdfunctionTP.Name = "cmdfunctionTP"
        Me.cmdfunctionTP.Size = New System.Drawing.Size(146, 44)
        Me.cmdfunctionTP.TabIndex = 3
        Me.cmdfunctionTP.Text = "Function"
        Me.cmdfunctionTP.UseVisualStyleBackColor = True
        '
        'cmdprocedureTP
        '
        Me.cmdprocedureTP.Location = New System.Drawing.Point(15, 24)
        Me.cmdprocedureTP.Name = "cmdprocedureTP"
        Me.cmdprocedureTP.Size = New System.Drawing.Size(146, 44)
        Me.cmdprocedureTP.TabIndex = 2
        Me.cmdprocedureTP.Text = "Procedure"
        Me.cmdprocedureTP.UseVisualStyleBackColor = True
        '
        'cmdhitungP
        '
        Me.cmdhitungP.Location = New System.Drawing.Point(44, 223)
        Me.cmdhitungP.Name = "cmdhitungP"
        Me.cmdhitungP.Size = New System.Drawing.Size(345, 23)
        Me.cmdhitungP.TabIndex = 7
        Me.cmdhitungP.Text = "Hitung P (+)"
        Me.cmdhitungP.UseVisualStyleBackColor = True
        '
        'cmdhitungF
        '
        Me.cmdhitungF.Location = New System.Drawing.Point(413, 223)
        Me.cmdhitungF.Name = "cmdhitungF"
        Me.cmdhitungF.Size = New System.Drawing.Size(345, 23)
        Me.cmdhitungF.TabIndex = 8
        Me.cmdhitungF.Text = "Hitung F (- )"
        Me.cmdhitungF.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.txtluas)
        Me.TabPage3.Controls.Add(Me.txtkeliling)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.tbdiam)
        Me.TabPage3.Controls.Add(Me.tbjari)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(827, 269)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Quiz Lingkaran"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(92, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tbjari
        '
        Me.tbjari.Location = New System.Drawing.Point(224, 98)
        Me.tbjari.Name = "tbjari"
        Me.tbjari.Size = New System.Drawing.Size(81, 20)
        Me.tbjari.TabIndex = 1
        '
        'tbdiam
        '
        Me.tbdiam.Location = New System.Drawing.Point(135, 155)
        Me.tbdiam.Name = "tbdiam"
        Me.tbdiam.Size = New System.Drawing.Size(100, 20)
        Me.tbdiam.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keliling"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Luas"
        '
        'txtkeliling
        '
        Me.txtkeliling.BackColor = System.Drawing.SystemColors.Info
        Me.txtkeliling.Location = New System.Drawing.Point(471, 35)
        Me.txtkeliling.Name = "txtkeliling"
        Me.txtkeliling.Size = New System.Drawing.Size(100, 20)
        Me.txtkeliling.TabIndex = 5
        '
        'txtluas
        '
        Me.txtluas.BackColor = System.Drawing.SystemColors.Info
        Me.txtluas.Location = New System.Drawing.Point(471, 72)
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(100, 20)
        Me.txtluas.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Hasil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProcFu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 310)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmProcFu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Procedure  & Function"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdhitungF As System.Windows.Forms.Button
    Friend WithEvents cmdhitungP As System.Windows.Forms.Button
    Friend WithEvents Txtnilai2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdfunctionTP As System.Windows.Forms.Button
    Friend WithEvents cmdprocedureTP As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdfunctionDP As System.Windows.Forms.Button
    Friend WithEvents cmdprocedureDP As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtluas As System.Windows.Forms.TextBox
    Friend WithEvents txtkeliling As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbdiam As System.Windows.Forms.TextBox
    Friend WithEvents tbjari As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
