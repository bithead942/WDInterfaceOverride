
Option Strict Off
Option Explicit On

Public Class WDInterfaceOverride

    'Friend WithEvents Event_HistoryTableAdapter As New WatchdogDataSetTableAdapters.Event_HistoryTableAdapter


    Private Sub btnLight1On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight1On.Click
        X10_ControlTableAdapter.Light1_on()
    End Sub

    Private Sub btnLight2On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight2On.Click
        X10_ControlTableAdapter.Light2_on()
    End Sub

    Private Sub btnLight3On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight3On.Click
        X10_ControlTableAdapter.Light3_on()
    End Sub

    Private Sub btnLight4On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight4On.Click
        X10_ControlTableAdapter.Light4_on()
    End Sub

    Private Sub btnLight1Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight1Off.Click
        X10_ControlTableAdapter.Light1_off()
    End Sub

    Private Sub btnLight2Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight2Off.Click
        X10_ControlTableAdapter.Light2_off()
    End Sub

    Private Sub btnLight3Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight3Off.Click
        X10_ControlTableAdapter.Light3_off()
    End Sub

    Private Sub btnLight4Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLight4Off.Click
        X10_ControlTableAdapter.Light4_off()
    End Sub

    Private Sub btnZone1On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone1On.Click
        X10_ControlTableAdapter.Zone1_on()
    End Sub

    Private Sub btnZone2On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone2On.Click
        X10_ControlTableAdapter.Zone2_on()
    End Sub

    Private Sub btnZone3On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone3On.Click
        X10_ControlTableAdapter.Zone3_on()
    End Sub

    Private Sub btnZone4On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone4On.Click
        X10_ControlTableAdapter.Zone4_on()
    End Sub

    Private Sub btnZone1Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone1Off.Click
        X10_ControlTableAdapter.Zone1_off()
    End Sub

    Private Sub btnZone2Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone2Off.Click
        X10_ControlTableAdapter.Zone2_off()
    End Sub

    Private Sub btnZone3Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone3Off.Click
        X10_ControlTableAdapter.Zone3_off()
    End Sub

    Private Sub btnZone4Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone4Off.Click
        X10_ControlTableAdapter.Zone4_off()
    End Sub

    Private Sub btnTempUp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempUp1.Click
        X10_ControlTableAdapter.Temp_Up_1()
    End Sub

    Private Sub btnTempDown1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempDown1.Click
        X10_ControlTableAdapter.Temp_Down_1()
    End Sub

    Private Sub btnTempUp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempUp3.Click
        X10_ControlTableAdapter.Temp_Up_3()
    End Sub

    Private Sub btnTempDown3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempDown3.Click
        X10_ControlTableAdapter.Temp_Down_3()
    End Sub

    Private Sub btnDoorbell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoorbell.Click
        Event_Current_StateTableAdapter.RingDoorbell()
        X10_ControlTableAdapter.Doorbell()
    End Sub


    Public Sub SpeakIt(ByVal SpeakText As String)
        Dim SpeakIt As System.Diagnostics.Process = New System.Diagnostics.Process

        SpeakIt.StartInfo.UseShellExecute = False
        SpeakIt.StartInfo.CreateNoWindow = True
        SpeakIt.StartInfo.FileName = "WDPlay_Voice.exe"
        SpeakIt.StartInfo.Arguments = SpeakText
        Try
            SpeakIt.Start()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SendTextMsgGreg(ByVal MsgText As String)
        Dim SendIt As System.Diagnostics.Process

        SendIt = New System.Diagnostics.Process
        SendIt.StartInfo.UseShellExecute = False
        SendIt.StartInfo.CreateNoWindow = True
        SendIt.StartInfo.FileName = "WDSendTextMsg.exe"
        Try
            SendIt.StartInfo.Arguments = "5133287911 " & MsgText
            SendIt.Start()
        Catch ex As Exception
        End Try

    End Sub

    Public Sub SendTextMsgJuli(ByVal MsgText As String)
        Dim SendIt As System.Diagnostics.Process

        SendIt = New System.Diagnostics.Process
        SendIt.StartInfo.UseShellExecute = False
        SendIt.StartInfo.CreateNoWindow = True
        SendIt.StartInfo.FileName = "WDSendTextMsg.exe"
        Try
            SendIt.StartInfo.Arguments = "5135445316 " & MsgText
            SendIt.Start()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub btnSayIt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSayIt.Click
        SpeakIt(txtSayIt.Text)
    End Sub

    Private Sub btnTextGreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextGreg.Click
        SendTextMsgGreg(txtTextIt.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendTextMsgJuli(txtTextIt.Text)

    End Sub

    Private Sub WDInterfaceOverride_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WatchdogDataSet1.Event_Current_State' table. You can move, or remove it, as needed.
        Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet1.Event_Current_State)

    End Sub
End Class
