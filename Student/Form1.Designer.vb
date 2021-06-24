<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbirth
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
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.BirthdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIT2118DataSet = New Student.BIT2118DataSet()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblsurname = New System.Windows.Forms.Label()
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtmother = New System.Windows.Forms.TextBox()
        Me.txtfather = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmidwife = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbcounty = New System.Windows.Forms.ComboBox()
        Me.cbhospital = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BirthdetailsTableAdapter = New Student.BIT2118DataSetTableAdapters.BirthdetailsTableAdapter()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.BirthdetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BirthdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BirthdetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Location = New System.Drawing.Point(18, 27)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(63, 13)
        Me.lblfirst.TabIndex = 0
        Me.lblfirst.Text = "First Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.txtfirstname)
        Me.GroupBox1.Controls.Add(Me.lblsurname)
        Me.GroupBox1.Controls.Add(Me.lblsecond)
        Me.GroupBox1.Controls.Add(Me.lblfirst)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Child Details"
        '
        'txtsurname
        '
        Me.txtsurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Surname", True))
        Me.txtsurname.Location = New System.Drawing.Point(110, 74)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 20)
        Me.txtsurname.TabIndex = 5
        '
        'BirthdetailsBindingSource
        '
        Me.BirthdetailsBindingSource.DataMember = "Birthdetails"
        Me.BirthdetailsBindingSource.DataSource = Me.BIT2118DataSet
        '
        'BIT2118DataSet
        '
        Me.BIT2118DataSet.DataSetName = "BIT2118DataSet"
        Me.BIT2118DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Secondname", True))
        Me.txtlastname.Location = New System.Drawing.Point(110, 51)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 20)
        Me.txtlastname.TabIndex = 4
        '
        'txtfirstname
        '
        Me.txtfirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Firstname", True))
        Me.txtfirstname.Location = New System.Drawing.Point(110, 27)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtfirstname.TabIndex = 3
        '
        'lblsurname
        '
        Me.lblsurname.AutoSize = True
        Me.lblsurname.Location = New System.Drawing.Point(18, 77)
        Me.lblsurname.Name = "lblsurname"
        Me.lblsurname.Size = New System.Drawing.Size(55, 13)
        Me.lblsurname.TabIndex = 2
        Me.lblsurname.Text = "Surname :"
        '
        'lblsecond
        '
        Me.lblsecond.AutoSize = True
        Me.lblsecond.Location = New System.Drawing.Point(17, 51)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(81, 13)
        Me.lblsecond.TabIndex = 1
        Me.lblsecond.Text = "Second Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtgender)
        Me.GroupBox2.Controls.Add(Me.rbfemale)
        Me.GroupBox2.Controls.Add(Me.rbmale)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 72)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'txtgender
        '
        Me.txtgender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Gender", True))
        Me.txtgender.Location = New System.Drawing.Point(52, 45)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(68, 20)
        Me.txtgender.TabIndex = 2
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BirthdetailsBindingSource, "Gender", True))
        Me.rbfemale.Location = New System.Drawing.Point(133, 20)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(59, 17)
        Me.rbfemale.TabIndex = 1
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Checked = True
        Me.rbmale.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BirthdetailsBindingSource, "Gender", True))
        Me.rbmale.Location = New System.Drawing.Point(10, 20)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(48, 17)
        Me.rbmale.TabIndex = 0
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.lbldob)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 55)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "DateofBirth", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(85, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(7, 25)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(72, 13)
        Me.lbldob.TabIndex = 0
        Me.lbldob.Text = "Date of Birth :"
        '
        'btnregister
        '
        Me.btnregister.Location = New System.Drawing.Point(139, 329)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(75, 23)
        Me.btnregister.TabIndex = 5
        Me.btnregister.Text = "New Entry"
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtmother)
        Me.GroupBox4.Controls.Add(Me.txtfather)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(328, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 90)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parents' Details"
        '
        'txtmother
        '
        Me.txtmother.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Mothername", True))
        Me.txtmother.Location = New System.Drawing.Point(94, 48)
        Me.txtmother.Name = "txtmother"
        Me.txtmother.Size = New System.Drawing.Size(100, 20)
        Me.txtmother.TabIndex = 4
        '
        'txtfather
        '
        Me.txtfather.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Fathername", True))
        Me.txtfather.Location = New System.Drawing.Point(94, 24)
        Me.txtfather.Name = "txtfather"
        Me.txtfather.Size = New System.Drawing.Size(100, 20)
        Me.txtfather.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mother's name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Father's name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Midwife name :"
        '
        'txtmidwife
        '
        Me.txtmidwife.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Midwife", True))
        Me.txtmidwife.Location = New System.Drawing.Point(94, 73)
        Me.txtmidwife.Name = "txtmidwife"
        Me.txtmidwife.Size = New System.Drawing.Size(100, 20)
        Me.txtmidwife.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbcounty)
        Me.GroupBox5.Controls.Add(Me.cbhospital)
        Me.GroupBox5.Controls.Add(Me.txtmidwife)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(328, 129)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Hospital Details"
        '
        'cbcounty
        '
        Me.cbcounty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "County", True))
        Me.cbcounty.FormattingEnabled = True
        Me.cbcounty.Items.AddRange(New Object() {"Mombasa", "Nakuru", "Meru", "Bungoma", "Malindi", "Uasin Gishu", "Nandi", "Kisumu", "Kakamega", "Nairobi"})
        Me.cbcounty.Location = New System.Drawing.Point(94, 42)
        Me.cbcounty.Name = "cbcounty"
        Me.cbcounty.Size = New System.Drawing.Size(100, 21)
        Me.cbcounty.TabIndex = 7
        '
        'cbhospital
        '
        Me.cbhospital.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdetailsBindingSource, "Hospital", True))
        Me.cbhospital.FormattingEnabled = True
        Me.cbhospital.Items.AddRange(New Object() {"Mater", "Aga Khan", "Getrude", "St. Christopher", "Kenyatta", "Marie Stopes", "Nairobi", "Langata", "Kijabe", "Karen", "MP Shah"})
        Me.cbhospital.Location = New System.Drawing.Point(94, 11)
        Me.cbhospital.Name = "cbhospital"
        Me.cbhospital.Size = New System.Drawing.Size(100, 21)
        Me.cbhospital.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "County name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hospital name :"
        '
        'BirthdetailsTableAdapter
        '
        Me.BirthdetailsTableAdapter.ClearBeforeFill = True
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(239, 329)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 8
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(339, 330)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(82, 22)
        Me.btnnext.TabIndex = 9
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(446, 330)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(39, 329)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'BirthdetailsBindingSource1
        '
        Me.BirthdetailsBindingSource1.DataMember = "Birthdetails"
        Me.BirthdetailsBindingSource1.DataSource = Me.BIT2118DataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmbirth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(540, 389)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmbirth"
        Me.Text = "Birth Certificate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BirthdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BirthdetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblfirst As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents lblsurname As Label
    Friend WithEvents lblsecond As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbldob As Label
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents btnregister As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtmother As TextBox
    Friend WithEvents txtfather As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmidwife As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbcounty As ComboBox
    Friend WithEvents cbhospital As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BIT2118DataSet As BIT2118DataSet
    Friend WithEvents BirthdetailsBindingSource As BindingSource
    Friend WithEvents BirthdetailsTableAdapter As BIT2118DataSetTableAdapters.BirthdetailsTableAdapter
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents BirthdetailsBindingSource1 As BindingSource
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Button1 As Button
End Class
