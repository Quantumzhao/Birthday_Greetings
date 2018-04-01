Public Class StringManipulation

	Public Shared Function Len(input As String) As Int64

		Return Strings.Len(input)

	End Function

	Public Shared Function Mid(input As String, start As Integer, length As Integer) As String

		If start <= 0 Then

			Throw New ArgumentOutOfRangeException()

			Return input

		End If

		If length > Strings.Len(input) Then

			Return input

		Else

			Return Strings.Mid(input, start, length)

		End If

	End Function

End Class
