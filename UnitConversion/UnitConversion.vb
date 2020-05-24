Public Class UnitConversion

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim convt As Double
        If ComboBox1.Text = "Celsius to Fahrenheit" Then
            convt = (9 / 5 * TextBox1.Text) + 32
            TextBox2.Text = (convt) & "Fahrenheit"
        ElseIf ComboBox1.Text = "Fahrenheit to Celsius" Then
            convt = 5 / 9 * (TextBox1.Text - 32)
            TextBox2.Text = convt & "Celsius"
        ElseIf ComboBox1.Text = "Kilometres to Miles" Then
            convt = (TextBox1.Text / 1.609344)
            TextBox2.Text = convt & "Miles"
        ElseIf ComboBox1.Text = "Miles to Kilometres" Then
            convt = (TextBox2.Text * 1.609344)
            TextBox2.Text = convt & "Kilometres"
        ElseIf ComboBox1.Text = "Choose One..." Or TextBox1.Text = "" Then
            MsgBox("Select a unit of conversion")

        End If
    End Sub
End Class
