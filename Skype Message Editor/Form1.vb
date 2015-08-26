Imports System.Net
Imports System.IO

Public Class Form1
    Private Sub message_html_paste(tag As String, c_pos As Integer)

        message_input.Focus()
        Dim current_pos As Integer = message_input.SelectionStart
        Dim open_tag As String = tag.Split("|"c)(0)
        Dim close_tag As String = tag.Split("|"c)(1)

        If message_input.SelectedText.Length <> 0 Then
            Dim selected_text As String = message_input.SelectedText
            message_input.SelectedText = Convert.ToString(open_tag & selected_text) & close_tag
        Else
            message_input.SelectedText = open_tag & close_tag
            Dim new_pos As Integer = current_pos + c_pos
            message_input.SelectionStart = new_pos
        End If
    End Sub

    Private Sub time_for_magic()
        Try
            Dim request = DirectCast(WebRequest.Create(url_input.Text), HttpWebRequest)
            request.ContentType = "application/json"
            request.Method = "POST"
            request.Headers("RegistrationToken") = rtoken_input.Text

            Using streamWriter = New StreamWriter(request.GetRequestStream())

                Dim json As String = "{""content"": """ + message_input.Text + """, ""contenttype"": ""text"", ""messagetype"": ""RichText"", ""skypeeditedid"": """ + editid_input.Text + """}"

                streamWriter.Write(json)
                streamWriter.Flush()

                streamWriter.Close()
            End Using
            Try
                Dim httpResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                    Dim result = streamReader.ReadToEnd()
                End Using
            Catch e As Exception
                MessageBox.Show("Something went wrong with the request", "Skype Message Editor", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Catch e As Exception
            MessageBox.Show("Could not make the request", "Skype Message Editor", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Function validate_form() As Boolean
        If url_input.Text.Length < 10 Then
            Return False
        End If

        If rtoken_input.Text.Length < 50 Then
            Return False
        End If

        If editid_input.Text.Length < 5 Then
            Return False
        End If

        If message_input.Text.Length < 1 Then
            Return False
        End If

        Return True
    End Function
    Private Sub html_blink_btn_Click_1(sender As Object, e As EventArgs) Handles html_blink_btn.Click
        message_html_paste("<blink>|</blink>", 7)
    End Sub

    Private Sub html_underline_btn_Click_1(sender As Object, e As EventArgs) Handles html_underline_btn.Click
        message_html_paste("<u>|</u>", 3)
    End Sub

    Private Sub html_bold_btn_Click_1(sender As Object, e As EventArgs) Handles html_bold_btn.Click
        message_html_paste("<b>|</b>", 3)
    End Sub

    Private Sub html_font_btn_Click_1(sender As Object, e As EventArgs) Handles html_font_btn.Click
        message_html_paste("<font size=""10"" color=""red"">|</font>", 27)
    End Sub

    Private Sub html_italics_btn_Click_1(sender As Object, e As EventArgs) Handles html_italics_btn.Click
        message_html_paste("<i>|</i>", 3)
    End Sub

    Private Sub html_link_btn_Click_1(sender As Object, e As EventArgs) Handles html_link_btn.Click
        message_html_paste("<a href=""http://hgcommunity.net"">|</a>", 28)
    End Sub

    Private Sub send_btn_Click_1(sender As Object, e As EventArgs) Handles send_btn.Click
        If validate_form() Then
            time_for_magic()
        Else
            MessageBox.Show("Please make sure every field is properly populated", "Skype Message Editor", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub clear_btn_Click_1(sender As Object, e As EventArgs) Handles clear_btn.Click
        url_input.Text = ""
        rtoken_input.Text = ""
        editid_input.Text = ""
        message_input.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.MaximumSize
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Credits.Show()
    End Sub

    Private Sub editid_input_TextChanged(sender As Object, e As EventArgs) Handles editid_input.TextChanged
        editid_input.Text = editid_input.Text.Replace("msg_", "")
    End Sub
End Class
