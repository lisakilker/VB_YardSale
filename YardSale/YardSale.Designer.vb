<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYardSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYardSale))
        Dim Yard_Sale_IDLabel As System.Windows.Forms.Label
        Dim Yard_Sale_OwnerLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Me.lblYardSales = New System.Windows.Forms.Label()
        Me.picYardSale = New System.Windows.Forms.PictureBox()
        Me.SalesDataSet = New YardSale.SalesDataSet()
        Me.YardSaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YardSaleTableAdapter = New YardSale.SalesDataSetTableAdapters.YardSaleTableAdapter()
        Me.TableAdapterManager = New YardSale.SalesDataSetTableAdapters.TableAdapterManager()
        Me.YardSaleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.YardSaleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Yard_Sale_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Yard_Sale_OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Yard_Sale_IDLabel = New System.Windows.Forms.Label()
        Yard_Sale_OwnerLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CType(Me.picYardSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YardSaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YardSaleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YardSaleBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYardSales
        '
        Me.lblYardSales.AutoSize = True
        Me.lblYardSales.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYardSales.ForeColor = System.Drawing.Color.Red
        Me.lblYardSales.Location = New System.Drawing.Point(76, 25)
        Me.lblYardSales.Name = "lblYardSales"
        Me.lblYardSales.Size = New System.Drawing.Size(420, 54)
        Me.lblYardSales.TabIndex = 0
        Me.lblYardSales.Text = "Saturday Yard Sales"
        '
        'picYardSale
        '
        Me.picYardSale.Image = Global.YardSale.My.Resources.Resources.Yard
        Me.picYardSale.Location = New System.Drawing.Point(262, 60)
        Me.picYardSale.Name = "picYardSale"
        Me.picYardSale.Size = New System.Drawing.Size(299, 260)
        Me.picYardSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYardSale.TabIndex = 1
        Me.picYardSale.TabStop = False
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YardSaleBindingSource
        '
        Me.YardSaleBindingSource.DataMember = "YardSale"
        Me.YardSaleBindingSource.DataSource = Me.SalesDataSet
        '
        'YardSaleTableAdapter
        '
        Me.YardSaleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = YardSale.SalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YardSaleTableAdapter = Me.YardSaleTableAdapter
        '
        'YardSaleBindingNavigator
        '
        Me.YardSaleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.YardSaleBindingNavigator.BindingSource = Me.YardSaleBindingSource
        Me.YardSaleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.YardSaleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.YardSaleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.YardSaleBindingNavigatorSaveItem})
        Me.YardSaleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.YardSaleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.YardSaleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.YardSaleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.YardSaleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.YardSaleBindingNavigator.Name = "YardSaleBindingNavigator"
        Me.YardSaleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.YardSaleBindingNavigator.Size = New System.Drawing.Size(573, 25)
        Me.YardSaleBindingNavigator.TabIndex = 2
        Me.YardSaleBindingNavigator.Text = "BindingNavigator1"
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
        'YardSaleBindingNavigatorSaveItem
        '
        Me.YardSaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.YardSaleBindingNavigatorSaveItem.Image = CType(resources.GetObject("YardSaleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.YardSaleBindingNavigatorSaveItem.Name = "YardSaleBindingNavigatorSaveItem"
        Me.YardSaleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.YardSaleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Yard_Sale_IDLabel
        '
        Yard_Sale_IDLabel.AutoSize = True
        Yard_Sale_IDLabel.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Yard_Sale_IDLabel.Location = New System.Drawing.Point(17, 107)
        Yard_Sale_IDLabel.Name = "Yard_Sale_IDLabel"
        Yard_Sale_IDLabel.Size = New System.Drawing.Size(116, 22)
        Yard_Sale_IDLabel.TabIndex = 3
        Yard_Sale_IDLabel.Text = "Yard Sale ID:"
        '
        'Yard_Sale_IDTextBox
        '
        Me.Yard_Sale_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YardSaleBindingSource, "Yard Sale ID", True))
        Me.Yard_Sale_IDTextBox.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yard_Sale_IDTextBox.Location = New System.Drawing.Point(139, 100)
        Me.Yard_Sale_IDTextBox.Name = "Yard_Sale_IDTextBox"
        Me.Yard_Sale_IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Yard_Sale_IDTextBox.TabIndex = 4
        '
        'Yard_Sale_OwnerLabel
        '
        Yard_Sale_OwnerLabel.AutoSize = True
        Yard_Sale_OwnerLabel.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Yard_Sale_OwnerLabel.Location = New System.Drawing.Point(61, 158)
        Yard_Sale_OwnerLabel.Name = "Yard_Sale_OwnerLabel"
        Yard_Sale_OwnerLabel.Size = New System.Drawing.Size(147, 22)
        Yard_Sale_OwnerLabel.TabIndex = 5
        Yard_Sale_OwnerLabel.Text = "Yard Sale Owner:"
        '
        'Yard_Sale_OwnerTextBox
        '
        Me.Yard_Sale_OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YardSaleBindingSource, "Yard Sale Owner", True))
        Me.Yard_Sale_OwnerTextBox.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yard_Sale_OwnerTextBox.Location = New System.Drawing.Point(58, 183)
        Me.Yard_Sale_OwnerTextBox.Name = "Yard_Sale_OwnerTextBox"
        Me.Yard_Sale_OwnerTextBox.Size = New System.Drawing.Size(150, 29)
        Me.Yard_Sale_OwnerTextBox.TabIndex = 6
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(95, 233)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(83, 22)
        LocationLabel.TabIndex = 7
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YardSaleBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(58, 258)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(150, 29)
        Me.LocationTextBox.TabIndex = 8
        '
        'frmYardSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 320)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Yard_Sale_OwnerLabel)
        Me.Controls.Add(Me.Yard_Sale_OwnerTextBox)
        Me.Controls.Add(Yard_Sale_IDLabel)
        Me.Controls.Add(Me.Yard_Sale_IDTextBox)
        Me.Controls.Add(Me.YardSaleBindingNavigator)
        Me.Controls.Add(Me.lblYardSales)
        Me.Controls.Add(Me.picYardSale)
        Me.Name = "frmYardSale"
        Me.Text = "Local Yard Sales This Saturday"
        CType(Me.picYardSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YardSaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YardSaleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YardSaleBindingNavigator.ResumeLayout(False)
        Me.YardSaleBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYardSales As System.Windows.Forms.Label
    Friend WithEvents picYardSale As System.Windows.Forms.PictureBox
    Friend WithEvents SalesDataSet As YardSale.SalesDataSet
    Friend WithEvents YardSaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YardSaleTableAdapter As YardSale.SalesDataSetTableAdapters.YardSaleTableAdapter
    Friend WithEvents TableAdapterManager As YardSale.SalesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YardSaleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YardSaleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Yard_Sale_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Yard_Sale_OwnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox

End Class
