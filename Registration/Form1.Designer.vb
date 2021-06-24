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
        Me.components = New System.ComponentModel.Container()
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SecondnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim DoBLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BIT2118DataSet = New Registration.BIT2118DataSet()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationTableAdapter = New Registration.BIT2118DataSetTableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New Registration.BIT2118DataSetTableAdapters.TableAdapterManager()
        Me.RegistrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SecondnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.DoBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.txtregister = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        FirstnameLabel = New System.Windows.Forms.Label()
        SecondnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        DoBLabel = New System.Windows.Forms.Label()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(1, 21)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(60, 13)
        FirstnameLabel.TabIndex = 3
        FirstnameLabel.Text = "First Name:"
        '
        'SecondnameLabel
        '
        SecondnameLabel.AutoSize = True
        SecondnameLabel.Location = New System.Drawing.Point(1, 47)
        SecondnameLabel.Name = "SecondnameLabel"
        SecondnameLabel.Size = New System.Drawing.Size(78, 13)
        SecondnameLabel.TabIndex = 5
        SecondnameLabel.Text = "Second Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(1, 73)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'DoBLabel
        '
        DoBLabel.AutoSize = True
        DoBLabel.Location = New System.Drawing.Point(40, 286)
        DoBLabel.Name = "DoBLabel"
        DoBLabel.Size = New System.Drawing.Size(34, 13)
        DoBLabel.TabIndex = 9
        DoBLabel.Text = "Do B:"
        '
        'BIT2118DataSet
        '
        Me.BIT2118DataSet.DataSetName = "BIT2118DataSet"
        Me.BIT2118DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.BIT2118DataSet
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Registration.BIT2118DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrationBindingNavigator
        '
        Me.RegistrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistrationBindingNavigator.BindingSource = Me.RegistrationBindingSource
        Me.RegistrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistrationBindingNavigatorSaveItem})
        Me.RegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistrationBindingNavigator.Name = "RegistrationBindingNavigator"
        Me.RegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistrationBindingNavigator.Size = New System.Drawing.Size(486, 25)
        Me.RegistrationBindingNavigator.TabIndex = 0
        Me.RegistrationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RegistrationBindingNavigatorSaveItem
        '
        Me.RegistrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistrationBindingNavigatorSaveItem.Name = "RegistrationBindingNavigatorSaveItem"
        Me.RegistrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(80, 18)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.FirstnameTextBox.TabIndex = 4
        '
        'SecondnameTextBox
        '
        Me.SecondnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Secondname", True))
        Me.SecondnameTextBox.Location = New System.Drawing.Point(80, 44)
        Me.SecondnameTextBox.Name = "SecondnameTextBox"
        Me.SecondnameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.SecondnameTextBox.TabIndex = 6
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(80, 70)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.SurnameTextBox.TabIndex = 8
        '
        'DoBDateTimePicker
        '
        Me.DoBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "DoB", True))
        Me.DoBDateTimePicker.Location = New System.Drawing.Point(88, 286)
        Me.DoBDateTimePicker.Name = "DoBDateTimePicker"
        Me.DoBDateTimePicker.Size = New System.Drawing.Size(197, 20)
        Me.DoBDateTimePicker.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SecondnameTextBox)
        Me.GroupBox1.Controls.Add(FirstnameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(SecondnameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 104)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GenderTextBox)
        Me.GroupBox2.Controls.Add(Me.rbfemale)
        Me.GroupBox2.Controls.Add(Me.rbmale)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 66)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(80, 29)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(59, 17)
        Me.rbfemale.TabIndex = 1
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(7, 29)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(48, 17)
        Me.rbmale.TabIndex = 0
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'txtregister
        '
        Me.txtregister.Location = New System.Drawing.Point(307, 331)
        Me.txtregister.Name = "txtregister"
        Me.txtregister.Size = New System.Drawing.Size(75, 23)
        Me.txtregister.TabIndex = 16
        Me.txtregister.Text = "Register"
        Me.txtregister.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(25, 331)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 17
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(119, 331)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 18
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(213, 331)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(145, 28)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(85, 20)
        Me.GenderTextBox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 407)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.txtregister)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DoBLabel)
        Me.Controls.Add(Me.DoBDateTimePicker)
        Me.Controls.Add(Me.RegistrationBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Student Registration Form"
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationBindingNavigator.ResumeLayout(False)
        Me.RegistrationBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BIT2118DataSet As BIT2118DataSet
    Friend WithEvents RegistrationBindingSource As BindingSource
    Friend WithEvents RegistrationTableAdapter As BIT2118DataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As BIT2118DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RegistrationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents SecondnameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents DoBDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents txtregister As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents GenderTextBox As TextBox
End Class
