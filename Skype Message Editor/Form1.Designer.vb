<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.html_link_btn = New System.Windows.Forms.Button()
        Me.html_underline_btn = New System.Windows.Forms.Button()
        Me.html_italics_btn = New System.Windows.Forms.Button()
        Me.html_font_btn = New System.Windows.Forms.Button()
        Me.html_bold_btn = New System.Windows.Forms.Button()
        Me.html_blink_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.send_btn = New System.Windows.Forms.Button()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.message_input = New System.Windows.Forms.RichTextBox()
        Me.editid_input = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtoken_input = New System.Windows.Forms.RichTextBox()
        Me.url_input = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.groupBox5.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'html_link_btn
        '
        Me.html_link_btn.Location = New System.Drawing.Point(87, 77)
        Me.html_link_btn.Name = "html_link_btn"
        Me.html_link_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_link_btn.TabIndex = 5
        Me.html_link_btn.Text = "Link"
        Me.html_link_btn.UseVisualStyleBackColor = True
        '
        'html_underline_btn
        '
        Me.html_underline_btn.Location = New System.Drawing.Point(87, 19)
        Me.html_underline_btn.Name = "html_underline_btn"
        Me.html_underline_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_underline_btn.TabIndex = 4
        Me.html_underline_btn.Text = "Underline"
        Me.html_underline_btn.UseVisualStyleBackColor = True
        '
        'html_italics_btn
        '
        Me.html_italics_btn.Location = New System.Drawing.Point(6, 77)
        Me.html_italics_btn.Name = "html_italics_btn"
        Me.html_italics_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_italics_btn.TabIndex = 3
        Me.html_italics_btn.Text = "Italics"
        Me.html_italics_btn.UseVisualStyleBackColor = True
        '
        'html_font_btn
        '
        Me.html_font_btn.Location = New System.Drawing.Point(87, 48)
        Me.html_font_btn.Name = "html_font_btn"
        Me.html_font_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_font_btn.TabIndex = 2
        Me.html_font_btn.Text = "Font"
        Me.html_font_btn.UseVisualStyleBackColor = True
        '
        'html_bold_btn
        '
        Me.html_bold_btn.Location = New System.Drawing.Point(6, 48)
        Me.html_bold_btn.Name = "html_bold_btn"
        Me.html_bold_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_bold_btn.TabIndex = 1
        Me.html_bold_btn.Text = "Bold"
        Me.html_bold_btn.UseVisualStyleBackColor = True
        '
        'html_blink_btn
        '
        Me.html_blink_btn.Location = New System.Drawing.Point(6, 19)
        Me.html_blink_btn.Name = "html_blink_btn"
        Me.html_blink_btn.Size = New System.Drawing.Size(75, 23)
        Me.html_blink_btn.TabIndex = 0
        Me.html_blink_btn.Text = "Blink"
        Me.html_blink_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Location = New System.Drawing.Point(332, 131)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.clear_btn.TabIndex = 6
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'send_btn
        '
        Me.send_btn.Location = New System.Drawing.Point(251, 131)
        Me.send_btn.Name = "send_btn"
        Me.send_btn.Size = New System.Drawing.Size(75, 23)
        Me.send_btn.TabIndex = 5
        Me.send_btn.Text = "Send"
        Me.send_btn.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.html_link_btn)
        Me.groupBox5.Controls.Add(Me.html_underline_btn)
        Me.groupBox5.Controls.Add(Me.html_italics_btn)
        Me.groupBox5.Controls.Add(Me.html_font_btn)
        Me.groupBox5.Controls.Add(Me.html_bold_btn)
        Me.groupBox5.Controls.Add(Me.html_blink_btn)
        Me.groupBox5.Location = New System.Drawing.Point(245, 19)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(170, 106)
        Me.groupBox5.TabIndex = 4
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "HTML Tags"
        '
        'message_input
        '
        Me.message_input.Location = New System.Drawing.Point(6, 19)
        Me.message_input.Name = "message_input"
        Me.message_input.Size = New System.Drawing.Size(233, 142)
        Me.message_input.TabIndex = 3
        Me.message_input.Text = ""
        '
        'editid_input
        '
        Me.editid_input.Location = New System.Drawing.Point(6, 19)
        Me.editid_input.Name = "editid_input"
        Me.editid_input.Size = New System.Drawing.Size(415, 20)
        Me.editid_input.TabIndex = 0
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.editid_input)
        Me.groupBox3.Location = New System.Drawing.Point(6, 233)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(427, 48)
        Me.groupBox3.TabIndex = 8
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Message ID"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rtoken_input)
        Me.groupBox2.Location = New System.Drawing.Point(6, 65)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(427, 162)
        Me.groupBox2.TabIndex = 7
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Registration Token"
        '
        'rtoken_input
        '
        Me.rtoken_input.Location = New System.Drawing.Point(6, 19)
        Me.rtoken_input.Name = "rtoken_input"
        Me.rtoken_input.Size = New System.Drawing.Size(415, 137)
        Me.rtoken_input.TabIndex = 0
        Me.rtoken_input.Text = ""
        '
        'url_input
        '
        Me.url_input.Location = New System.Drawing.Point(6, 19)
        Me.url_input.Name = "url_input"
        Me.url_input.Size = New System.Drawing.Size(415, 20)
        Me.url_input.TabIndex = 0
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.clear_btn)
        Me.groupBox4.Controls.Add(Me.send_btn)
        Me.groupBox4.Controls.Add(Me.groupBox5)
        Me.groupBox4.Controls.Add(Me.message_input)
        Me.groupBox4.Location = New System.Drawing.Point(6, 287)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(427, 167)
        Me.groupBox4.TabIndex = 9
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Message"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.url_input)
        Me.groupBox1.Location = New System.Drawing.Point(6, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(427, 47)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Request URL"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 457)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Credits"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 476)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Skype Message Editor"
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents html_link_btn As System.Windows.Forms.Button
    Private WithEvents html_underline_btn As System.Windows.Forms.Button
    Private WithEvents html_italics_btn As System.Windows.Forms.Button
    Private WithEvents html_font_btn As System.Windows.Forms.Button
    Private WithEvents html_bold_btn As System.Windows.Forms.Button
    Private WithEvents html_blink_btn As System.Windows.Forms.Button
    Private WithEvents clear_btn As System.Windows.Forms.Button
    Private WithEvents send_btn As System.Windows.Forms.Button
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents message_input As System.Windows.Forms.RichTextBox
    Private WithEvents editid_input As System.Windows.Forms.TextBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents rtoken_input As System.Windows.Forms.RichTextBox
    Private WithEvents url_input As System.Windows.Forms.TextBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
