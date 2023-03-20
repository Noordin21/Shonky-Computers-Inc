Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCHECKPRICE.Click
        Dim IntelPentiumG4400 As Integer
        Dim Inteli36100 As Integer
        Dim TOTALITEM As Integer


        IntelPentiumG4400 = TxtIntelPentiumG4400.Text
        Inteli36100 = TxtInteli36100.Text
        TOTALITEM = IntelPentiumG4400 + Inteli36100
        TxtTOTALITEMS.Text = TOTALITEM.ToString

        Dim kshA As Integer
        Dim kshB As Integer
        Dim TOTALPRICE As Integer

        kshA = IntelPentiumG4400 + 500
        TxtkshA.Text = kshA.ToString
        kshB = Inteli36100 + 1000
        TxtkshB.Text = kshB.ToString
        TOTALPRICE = kshA + kshB
        TxtTOTALPRICE.Text = TOTALPRICE.ToString




    End Sub


End Class
