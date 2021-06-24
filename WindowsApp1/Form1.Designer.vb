<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexams
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbreg = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmarks = New System.Windows.Forms.TextBox()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.txtcre = New System.Windows.Forms.TextBox()
        Me.txtgeo = New System.Windows.Forms.TextBox()
        Me.txthistory = New System.Windows.Forms.TextBox()
        Me.txtsci = New System.Windows.Forms.TextBox()
        Me.txtmath = New System.Windows.Forms.TextBox()
        Me.txtswa = New System.Windows.Forms.TextBox()
        Me.txteng = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.BIT2118DataSet = New WindowsApp1.BIT2118DataSet()
        Me.ExamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableAdapter = New WindowsApp1.BIT2118DataSetTableAdapters.ExamsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Reg. No. :"
        '
        'cbreg
        '
        Me.cbreg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "StudentID", True))
        Me.cbreg.FormattingEnabled = True
        Me.cbreg.Location = New System.Drawing.Point(158, 34)
        Me.cbreg.Name = "cbreg"
        Me.cbreg.Size = New System.Drawing.Size(121, 21)
        Me.cbreg.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "English :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kiswahili :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Maths :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Science :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "History :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Geography :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmarks)
        Me.GroupBox1.Controls.Add(Me.txtgrade)
        Me.GroupBox1.Controls.Add(Me.txtcre)
        Me.GroupBox1.Controls.Add(Me.txtgeo)
        Me.GroupBox1.Controls.Add(Me.txthistory)
        Me.GroupBox1.Controls.Add(Me.txtsci)
        Me.GroupBox1.Controls.Add(Me.txtmath)
        Me.GroupBox1.Controls.Add(Me.txtswa)
        Me.GroupBox1.Controls.Add(Me.txteng)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 248)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter scores"
        '
        'txtmarks
        '
        Me.txtmarks.Location = New System.Drawing.Point(182, 216)
        Me.txtmarks.Name = "txtmarks"
        Me.txtmarks.ReadOnly = True
        Me.txtmarks.Size = New System.Drawing.Size(26, 20)
        Me.txtmarks.TabIndex = 20
        '
        'txtgrade
        '
        Me.txtgrade.Location = New System.Drawing.Point(52, 219)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.ReadOnly = True
        Me.txtgrade.Size = New System.Drawing.Size(27, 20)
        Me.txtgrade.TabIndex = 19
        '
        'txtcre
        '
        Me.txtcre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "CRE", True))
        Me.txtcre.Location = New System.Drawing.Point(108, 189)
        Me.txtcre.Name = "txtcre"
        Me.txtcre.Size = New System.Drawing.Size(100, 20)
        Me.txtcre.TabIndex = 18
        '
        'txtgeo
        '
        Me.txtgeo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "Geography", True))
        Me.txtgeo.Location = New System.Drawing.Point(108, 162)
        Me.txtgeo.Name = "txtgeo"
        Me.txtgeo.Size = New System.Drawing.Size(100, 20)
        Me.txtgeo.TabIndex = 17
        '
        'txthistory
        '
        Me.txthistory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "History", True))
        Me.txthistory.Location = New System.Drawing.Point(108, 135)
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(100, 20)
        Me.txthistory.TabIndex = 16
        '
        'txtsci
        '
        Me.txtsci.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "Science", True))
        Me.txtsci.Location = New System.Drawing.Point(108, 108)
        Me.txtsci.Name = "txtsci"
        Me.txtsci.Size = New System.Drawing.Size(100, 20)
        Me.txtsci.TabIndex = 15
        '
        'txtmath
        '
        Me.txtmath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "Maths", True))
        Me.txtmath.Location = New System.Drawing.Point(108, 82)
        Me.txtmath.Name = "txtmath"
        Me.txtmath.Size = New System.Drawing.Size(100, 20)
        Me.txtmath.TabIndex = 14
        '
        'txtswa
        '
        Me.txtswa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "Kiswahili", True))
        Me.txtswa.Location = New System.Drawing.Point(108, 54)
        Me.txtswa.Name = "txtswa"
        Me.txtswa.Size = New System.Drawing.Size(100, 20)
        Me.txtswa.TabIndex = 13
        '
        'txteng
        '
        Me.txteng.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamsBindingSource, "English", True))
        Me.txteng.Location = New System.Drawing.Point(108, 27)
        Me.txteng.Name = "txteng"
        Me.txteng.Size = New System.Drawing.Size(100, 20)
        Me.txteng.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Total marks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Grade "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "C.R.E :"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(41, 345)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.btncalculate.TabIndex = 10
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(149, 345)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(41, 384)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 12
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(149, 384)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'BIT2118DataSet
        '
        Me.BIT2118DataSet.DataSetName = "BIT2118DataSet"
        Me.BIT2118DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamsBindingSource
        '
        Me.ExamsBindingSource.DataMember = "Exams"
        Me.ExamsBindingSource.DataSource = Me.BIT2118DataSet
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'frmexams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(350, 413)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbreg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmexams"
        Me.Text = "Exams"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbreg As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcre As TextBox
    Friend WithEvents txtgeo As TextBox
    Friend WithEvents txthistory As TextBox
    Friend WithEvents txtsci As TextBox
    Friend WithEvents txtmath As TextBox
    Friend WithEvents txtswa As TextBox
    Friend WithEvents txteng As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmarks As TextBox
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents BIT2118DataSet As BIT2118DataSet
    Friend WithEvents ExamsBindingSource As BindingSource
    Friend WithEvents ExamsTableAdapter As BIT2118DataSetTableAdapters.ExamsTableAdapter
End Class
