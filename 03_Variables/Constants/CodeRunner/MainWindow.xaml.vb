Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'explicit data typing
        Dim myString As String = "Hello Word"
        Dim myNumber As Integer = 42
        Dim myDate As Date = DateValue("November 28, 2018")
        Output(myString)
        Output(myNumber)
        Output(myDate)

        'inferred data typing
        Dim myString2 = "Hello Word"
        Dim myNumber2 = 42.5
        Dim myDate2 = DateValue("November 28, 2018")
        Output(myString2)
        Output(myNumber2)
        Output(myDate2)
    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
