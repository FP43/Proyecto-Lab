Public Class Form2

    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PañolDataBase1DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PañolDataBase1DataSet.Stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.PañolDataBase1DataSet.Stock)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Hide()


    End Sub

    Private Sub StockBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles StockBindingNavigator.RefreshItems

    End Sub
End Class