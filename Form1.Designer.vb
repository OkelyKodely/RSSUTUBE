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
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.urlLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(13, 13)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(259, 21)
        Me.cb1.TabIndex = 0
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(12, 72)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(260, 158)
        Me.rtb1.TabIndex = 1
        Me.rtb1.Text = ""
        '
        'urlLbl
        '
        Me.urlLbl.AutoSize = True
        Me.urlLbl.Location = New System.Drawing.Point(13, 41)
        Me.urlLbl.Name = "urlLbl"
        Me.urlLbl.Size = New System.Drawing.Size(18, 13)
        Me.urlLbl.TabIndex = 2
        Me.urlLbl.Text = "url"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(510, 261)
        Me.Controls.Add(Me.urlLbl)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.cb1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RSSUTUBE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb1 As ComboBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents urlLbl As Label
End Class
