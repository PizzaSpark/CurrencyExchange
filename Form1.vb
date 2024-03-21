Imports System.Globalization
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Shared dontChange As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxTo.Items.AddRange(ComboBoxFrom.Items.Cast(Of Object).ToArray())
        ComboBoxFrom.SelectedIndex = 0
        ComboBoxTo.SelectedIndex = 0
    End Sub

    Private Sub TextBoxFrom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFrom.TextChanged
        'exit sub if blank text
        If String.IsNullOrEmpty(TextBoxFrom.Text) Then
            TextBoxTo.Text = ""
            Exit Sub
        End If

        If IsNumeric(TextBoxFrom.Text) Then
            'convert the currency and display the result in textboxto
            Dim fromValue As Double = Convert.ToDouble(TextBoxFrom.Text)
            Dim culture As CultureInfo = New CultureInfo(GetCulture(ComboBoxTo.SelectedItem.ToString()))
            Dim toValue As Double = ConvertCurrency(fromValue, ComboBoxFrom.SelectedItem.ToString(), ComboBoxTo.SelectedItem.ToString())
            TextBoxTo.Text = String.Format(culture, "{0:C}", toValue)
        Else
            TextBoxFrom.Text = TextBoxFrom.Text.Remove(TextBoxFrom.Text.Length - 1)
            TextBoxFrom.SelectionStart = TextBoxFrom.Text.Length
        End If
    End Sub

    Private Sub ComboBoxFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFrom.SelectedIndexChanged
        ComboBoxTo.Items.Clear()
        ComboBoxTo.Items.AddRange(ComboBoxFrom.Items.Cast(Of Object).ToArray())
        ComboBoxTo.Items.Remove(ComboBoxFrom.SelectedItem)
        ComboBoxTo.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTo.SelectedIndexChanged
        TextBoxFrom_TextChanged(sender, e)
    End Sub

    Private Function ConvertCurrency(value As Double, fromCurrency As String, toCurrency As String) As Decimal
        Dim rate As Double

        Select Case fromCurrency
            Case "PHP - Philippine Peso"
                Select Case toCurrency
                    Case "PHP - Philippine Peso"
                        rate = 1
                    Case "USD - US Dollar"
                        rate = 0.01813
                    Case "JPY - Japanese Yen"
                        rate = 2.45679
                    Case "EUR - Euro"
                        rate = 0.01714
                    Case "HKD - Hong Kong Dollar"
                        rate = 0.14226
                End Select
            Case "USD - US Dollar"
                Select Case toCurrency
                    Case "PHP - Philippine Peso"
                        rate = 55.12749
                    Case "USD - US Dollar"
                        rate = 1
                    Case "JPY - Japanese Yen"
                        rate = 135.53368
                    Case "EUR - Euro"
                        rate = 0.94568
                    Case "HKD - Hong Kong Dollar"
                        rate = 7.848
                End Select
            Case "JPY - Japanese Yen"
                Select Case toCurrency
                    Case "PHP - Philippine Peso"
                        rate = 0.40669
                    Case "USD - US Dollar"
                        rate = 0.00738
                    Case "JPY - Japanese Yen"
                        rate = 1
                    Case "EUR - Euro"
                        rate = 0.00698
                    Case "HKD - Hong Kong Dollar"
                        rate = 0.0579
                End Select
            Case "EUR - Euro"
                Select Case toCurrency
                    Case "PHP - Philippine Peso"
                        rate = 58.28538
                    Case "USD - US Dollar"
                        rate = 1.05728
                    Case "JPY - Japanese Yen"
                        rate = 143.30654
                    Case "EUR - Euro"
                        rate = 1
                    Case "HKD - Hong Kong Dollar"
                        rate = 8.29764
                End Select
            Case "HKD - Hong Kong Dollar"
                Select Case toCurrency
                    Case "PHP - Philippine Peso"
                        rate = 7.02396
                    Case "USD - US Dollar"
                        rate = 0.12741
                    Case "JPY - Japanese Yen"
                        rate = 17.26876
                    Case "EUR - Euro"
                        rate = 0.1205
                    Case "HKD - Hong Kong Dollar"
                        rate = 1
                End Select
        End Select
        Return rate * value
    End Function

    'same method as above but it returns the culture
    Private Function GetCulture(currency As String) As String
        Dim culture As String = ""
        Select Case currency
            Case "PHP - Philippine Peso"
                culture = "en-PH"
            Case "USD - US Dollar"
                culture = "en-US"
            Case "JPY - Japanese Yen"
                culture = "ja-JP"
            Case "EUR - Euro"
                culture = "en-GB"
            Case "HKD - Hong Kong Dollar"
                culture = "en-HK"
        End Select
        Return culture
    End Function


End Class
