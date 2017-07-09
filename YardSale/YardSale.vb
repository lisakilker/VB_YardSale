Public Class frmYardSale

    Private Sub YardSaleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles YardSaleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.YardSaleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalesDataSet)

    End Sub

    Private Sub frmYardSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet.YardSale' table. You can move, or remove it, as needed.
        Me.YardSaleTableAdapter.Fill(Me.SalesDataSet.YardSale)

    End Sub
End Class
