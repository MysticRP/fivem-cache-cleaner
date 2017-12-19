Imports System.IO
Imports System.Environment

Public Class Form1
    Dim appData As String = GetFolderPath(SpecialFolder.LocalApplicationData)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Directory.Exists(appData + "/FiveM/FiveM.app/cache/browser/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/db/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/dunno/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/servers/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/priv/") Then
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/browser/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/db/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/dunno/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/servers/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/priv/", True)
            MsgBox("Cache Cleaned !", MsgBoxStyle.Information)
        Else
            MsgBox("No Cache Founded !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(appData + "/FiveM/FiveM.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Directory.Exists(appData + "/FiveM/FiveM.app/cache/browser/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/db/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/dunno/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/servers/") Or Directory.Exists(appData + "/FiveM/FiveM.app/cache/priv/") Then
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/browser/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/db/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/dunno/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/servers/", True)
            Directory.Delete(appData + "/FiveM/FiveM.app/cache/priv/", True)
            Process.Start(appData + "/FiveM/FiveM.exe")
            MsgBox("Cache Cleaned & FiveM Started !", MsgBoxStyle.Information)
        Else
            MsgBox("No Cache Founded !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://oskarr.eu/")
    End Sub
End Class
