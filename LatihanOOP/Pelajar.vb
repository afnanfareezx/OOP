Public Class Pelajar
    Private strNoMatrik As String
    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik


    End Sub
    Public Function Politeknik() As String
        Dim strKodPoli As String =
        strNoMatrik.Substring(0, 2)

        If strKodPoli = "18" Then
            Return "PTSS"
        Else
            Return "Bukan PTSS"
        End If
    End Function

    Public Function Program() As String
        Dim strProgram As String =
        strNoMatrik.Substring(2, 3)

        If strProgram = "DDT" Then
            Return "Diploma Teknologi Maklumat(Teknologi Digital)"
        Else
            Return "BUKAN DDT"
        End If

    End Function

    Public Function Ambilan() As String
        Dim strAmbilan As String =strNoMatrik.Substring(5, 3)
        Dim strSesi As String = strNoMatrik.Substring(8, 1)

        If strAmbilan = "19F" Then
            If strSesi = "1" Then
                Return "Jun 2019"
            ElseIf strSesi = "2" Then
                Return "Dec 2019"
            End If
        Else
            Return "Bukan Sesi 2019"
        End If
    End Function
End Class
