﻿Class MainWindow

    Dim names As ArrayList = New ArrayList()

    Sub RunCode(sender As Object, e As RoutedEventArgs)

        'Add code here
        Dim StringVar As String = Nothing
        Dim StrLength As Integer? = StringVar?.Length
        Output("Length = " +
               If(StrLength Is Nothing, "0", StrLength.ToString))

        Output(If(StrLength Is Nothing, "StringVar is empty", StrLength.ToString))

        Output("All done!")

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
