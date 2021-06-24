<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbltest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tbltest))
        Dim RegNoLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim SnameLabel As System.Windows.Forms.Label
        Dim MathsLabel As System.Windows.Forms.Label
        Dim EnglishLabel As System.Windows.Forms.Label
        Dim KiswahiliLabel As System.Windows.Forms.Label
        Dim BiologyLabel As System.Windows.Forms.Label
        Dim HistoryLabel As System.Windows.Forms.Label
        Me.BIT2118DataSet = New DB_Practice.BIT2118DataSet()
        Me.TblexamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblexamsTableAdapter = New DB_Practice.BIT2118DataSetTableAdapters.tblexamsTableAdapter()
        Me.TableAdapterManager = New DB_Practice.BIT2118DataSetTableAdapters.TableAdapterManager()
        Me.TblexamsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblexamsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegNoTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.SnameTextBox = New System.Windows.Forms.TextBox()
        Me.MathsTextBox = New System.Windows.Forms.TextBox()
        Me.EnglishTextBox = New System.Windows.Forms.TextBox()
        Me.KiswahiliTextBox = New System.Windows.Forms.TextBox()
        Me.BiologyTextBox = New System.Windows.Forms.TextBox()
        Me.HistoryTextBox = New System.Windows.Forms.TextBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        RegNoLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        SnameLabel = New System.Windows.Forms.Label()
        MathsLabel = New System.Windows.Forms.Label()
        EnglishLabel = New System.Windows.Forms.Label()
        KiswahiliLabel = New System.Windows.Forms.Label()
        BiologyLabel = New System.Windows.Forms.Label()
        HistoryLabel = New System.Windows.Forms.Label()
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblexamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblexamsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblexamsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BIT2118DataSet
        '
        Me.BIT2118DataSet.DataSetName = "BIT2118DataSet"
        Me.BIT2118DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblexamsBindingSource
        '
        Me.TblexamsBindingSource.DataMember = "tblexams"
        Me.TblexamsBindingSource.DataSource = Me.BIT2118DataSet
        '
        'TblexamsTableAdapter
        '
        Me.TblexamsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblexamsTableAdapter = Me.TblexamsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DB_Practice.BIT2118DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblexamsBindingNavigator
        '
        Me.TblexamsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblexamsBindingNavigator.BindingSource = Me.TblexamsBindingSource
        Me.TblexamsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblexamsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblexamsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblexamsBindingNavigatorSaveItem})
        Me.TblexamsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblexamsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblexamsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblexamsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblexamsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblexamsBindingNavigator.Name = "TblexamsBindingNavigator"
        Me.TblexamsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblexamsBindingNavigator.Size = New System.Drawing.Size(395, 25)
        Me.TblexamsBindingNavigator.TabIndex = 0
        Me.TblexamsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblexamsBindingNavigatorSaveItem
        '
        Me.TblexamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblexamsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblexamsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblexamsBindingNavigatorSaveItem.Name = "TblexamsBindingNavigatorSaveItem"
        Me.TblexamsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblexamsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RegNoLabel
        '
        RegNoLabel.AutoSize = True
        RegNoLabel.Location = New System.Drawing.Point(47, 89)
        RegNoLabel.Name = "RegNoLabel"
        RegNoLabel.Size = New System.Drawing.Size(109, 13)
        RegNoLabel.TabIndex = 3
        RegNoLabel.Text = "Registration Number :"
        '
        'RegNoTextBox
        '
        Me.RegNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "RegNo", True))
        Me.RegNoTextBox.Location = New System.Drawing.Point(180, 82)
        Me.RegNoTextBox.Name = "RegNoTextBox"
        Me.RegNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegNoTextBox.TabIndex = 4
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(47, 115)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(63, 13)
        FnameLabel.TabIndex = 5
        FnameLabel.Text = "First Name :"
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "Fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(180, 108)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FnameTextBox.TabIndex = 6
        '
        'SnameLabel
        '
        SnameLabel.AutoSize = True
        SnameLabel.Location = New System.Drawing.Point(47, 141)
        SnameLabel.Name = "SnameLabel"
        SnameLabel.Size = New System.Drawing.Size(81, 13)
        SnameLabel.TabIndex = 7
        SnameLabel.Text = "Second Name :"
        '
        'SnameTextBox
        '
        Me.SnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "Sname", True))
        Me.SnameTextBox.Location = New System.Drawing.Point(180, 134)
        Me.SnameTextBox.Name = "SnameTextBox"
        Me.SnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SnameTextBox.TabIndex = 8
        '
        'MathsLabel
        '
        MathsLabel.AutoSize = True
        MathsLabel.Location = New System.Drawing.Point(47, 167)
        MathsLabel.Name = "MathsLabel"
        MathsLabel.Size = New System.Drawing.Size(39, 13)
        MathsLabel.TabIndex = 9
        MathsLabel.Text = "Maths:"
        '
        'MathsTextBox
        '
        Me.MathsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "Maths", True))
        Me.MathsTextBox.Location = New System.Drawing.Point(180, 160)
        Me.MathsTextBox.Name = "MathsTextBox"
        Me.MathsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MathsTextBox.TabIndex = 10
        '
        'EnglishLabel
        '
        EnglishLabel.AutoSize = True
        EnglishLabel.Location = New System.Drawing.Point(47, 193)
        EnglishLabel.Name = "EnglishLabel"
        EnglishLabel.Size = New System.Drawing.Size(44, 13)
        EnglishLabel.TabIndex = 11
        EnglishLabel.Text = "English:"
        '
        'EnglishTextBox
        '
        Me.EnglishTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "English", True))
        Me.EnglishTextBox.Location = New System.Drawing.Point(180, 186)
        Me.EnglishTextBox.Name = "EnglishTextBox"
        Me.EnglishTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnglishTextBox.TabIndex = 12
        '
        'KiswahiliLabel
        '
        KiswahiliLabel.AutoSize = True
        KiswahiliLabel.Location = New System.Drawing.Point(47, 219)
        KiswahiliLabel.Name = "KiswahiliLabel"
        KiswahiliLabel.Size = New System.Drawing.Size(50, 13)
        KiswahiliLabel.TabIndex = 13
        KiswahiliLabel.Text = "Kiswahili:"
        '
        'KiswahiliTextBox
        '
        Me.KiswahiliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "Kiswahili", True))
        Me.KiswahiliTextBox.Location = New System.Drawing.Point(180, 212)
        Me.KiswahiliTextBox.Name = "KiswahiliTextBox"
        Me.KiswahiliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KiswahiliTextBox.TabIndex = 14
        '
        'BiologyLabel
        '
        BiologyLabel.AutoSize = True
        BiologyLabel.Location = New System.Drawing.Point(47, 245)
        BiologyLabel.Name = "BiologyLabel"
        BiologyLabel.Size = New System.Drawing.Size(44, 13)
        BiologyLabel.TabIndex = 15
        BiologyLabel.Text = "Biology:"
        '
        'BiologyTextBox
        '
        Me.BiologyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "Biology", True))
        Me.BiologyTextBox.Location = New System.Drawing.Point(180, 238)
        Me.BiologyTextBox.Name = "BiologyTextBox"
        Me.BiologyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BiologyTextBox.TabIndex = 16
        '
        'HistoryLabel
        '
        HistoryLabel.AutoSize = True
        HistoryLabel.Location = New System.Drawing.Point(47, 271)
        HistoryLabel.Name = "HistoryLabel"
        HistoryLabel.Size = New System.Drawing.Size(42, 13)
        HistoryLabel.TabIndex = 17
        HistoryLabel.Text = "History:"
        '
        'HistoryTextBox
        '
        Me.HistoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblexamsBindingSource, "History", True))
        Me.HistoryTextBox.Location = New System.Drawing.Point(180, 264)
        Me.HistoryTextBox.Name = "HistoryTextBox"
        Me.HistoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HistoryTextBox.TabIndex = 18
        '
        'btnprevious
        '
        Me.btnprevious.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.Location = New System.Drawing.Point(50, 307)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 19
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(174, 306)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(298, 306)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 21
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(244, 335)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(113, 335)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 23
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'tbltest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(395, 360)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(RegNoLabel)
        Me.Controls.Add(Me.RegNoTextBox)
        Me.Controls.Add(FnameLabel)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(SnameLabel)
        Me.Controls.Add(Me.SnameTextBox)
        Me.Controls.Add(MathsLabel)
        Me.Controls.Add(Me.MathsTextBox)
        Me.Controls.Add(EnglishLabel)
        Me.Controls.Add(Me.EnglishTextBox)
        Me.Controls.Add(KiswahiliLabel)
        Me.Controls.Add(Me.KiswahiliTextBox)
        Me.Controls.Add(BiologyLabel)
        Me.Controls.Add(Me.BiologyTextBox)
        Me.Controls.Add(HistoryLabel)
        Me.Controls.Add(Me.HistoryTextBox)
        Me.Controls.Add(Me.TblexamsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tbltest"
        Me.Text = "Examination System"
        CType(Me.BIT2118DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblexamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblexamsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblexamsBindingNavigator.ResumeLayout(False)
        Me.TblexamsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BIT2118DataSet As BIT2118DataSet
    Friend WithEvents TblexamsBindingSource As BindingSource
    Friend WithEvents TblexamsTableAdapter As BIT2118DataSetTableAdapters.tblexamsTableAdapter
    Friend WithEvents TableAdapterManager As BIT2118DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblexamsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblexamsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RegNoTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents SnameTextBox As TextBox
    Friend WithEvents MathsTextBox As TextBox
    Friend WithEvents EnglishTextBox As TextBox
    Friend WithEvents KiswahiliTextBox As TextBox
    Friend WithEvents BiologyTextBox As TextBox
    Friend WithEvents HistoryTextBox As TextBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnnext As Button
End Class
