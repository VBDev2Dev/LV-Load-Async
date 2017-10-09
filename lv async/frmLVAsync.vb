Public Class frmLVAsync
    Private Async Sub btnLoad_ClickAsync(sender As Object, e As EventArgs) Handles btnLoad.Click
        CanLoad = False
        Dim items = Await GetItems(800) 'pauses for 8 seconds.  Move the form while it is loading.

        lvLoad.BeginUpdate()
        lvLoad.Items.Clear()
        lvLoad.Items.AddRange(items.ToArray)
        lvLoad.EndUpdate()
        CanLoad = True
    End Sub
    WriteOnly Property CanLoad As Boolean
        Set(value As Boolean)
            btnLoad.Enabled = value
        End Set
    End Property

    Async Function GetItems(howMany As Integer) As Task(Of IEnumerable(Of ListViewItem))

        Return Await Task.Run(Async Function()
                                  Dim items As New List(Of ListViewItem)
                                  For x As Integer = 0 To howMany
                                      Await Task.Delay(10)
                                      items.Add(New ListViewItem(x.ToString))
                                  Next
                                  Return items
                              End Function)
    End Function

End Class
