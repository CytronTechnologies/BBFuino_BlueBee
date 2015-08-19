<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Me.comlbl = New System.Windows.Forms.Label()
        Me.cbcom = New System.Windows.Forms.ComboBox()
        Me.baudlbl = New System.Windows.Forms.Label()
        Me.cbbaud = New System.Windows.Forms.ComboBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.btndisconnect = New System.Windows.Forms.Button()
        Me.gb_transmit = New System.Windows.Forms.GroupBox()
        Me.btnledblink = New System.Windows.Forms.Button()
        Me.btnledoff = New System.Windows.Forms.Button()
        Me.btnledon = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.txtcom = New System.Windows.Forms.TextBox()
        Me.lblcom = New System.Windows.Forms.Label()
        Me.gb_transmit.SuspendLayout()
        Me.SuspendLayout()
        '
        'comlbl
        '
        Me.comlbl.AutoSize = True
        Me.comlbl.Location = New System.Drawing.Point(27, 13)
        Me.comlbl.Name = "comlbl"
        Me.comlbl.Size = New System.Drawing.Size(31, 13)
        Me.comlbl.TabIndex = 0
        Me.comlbl.Text = "COM"
        '
        'cbcom
        '
        Me.cbcom.FormattingEnabled = True
        Me.cbcom.Location = New System.Drawing.Point(83, 10)
        Me.cbcom.Name = "cbcom"
        Me.cbcom.Size = New System.Drawing.Size(121, 21)
        Me.cbcom.TabIndex = 1
        '
        'baudlbl
        '
        Me.baudlbl.AutoSize = True
        Me.baudlbl.Location = New System.Drawing.Point(27, 57)
        Me.baudlbl.Name = "baudlbl"
        Me.baudlbl.Size = New System.Drawing.Size(50, 13)
        Me.baudlbl.TabIndex = 2
        Me.baudlbl.Text = "Baudrate"
        '
        'cbbaud
        '
        Me.cbbaud.FormattingEnabled = True
        Me.cbbaud.Location = New System.Drawing.Point(83, 54)
        Me.cbbaud.Name = "cbbaud"
        Me.cbbaud.Size = New System.Drawing.Size(121, 21)
        Me.cbbaud.TabIndex = 3
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(287, 13)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnconnect
        '
        Me.btnconnect.Location = New System.Drawing.Point(231, 52)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnconnect.TabIndex = 5
        Me.btnconnect.Text = "Connect"
        Me.btnconnect.UseVisualStyleBackColor = True
        '
        'btndisconnect
        '
        Me.btndisconnect.Location = New System.Drawing.Point(339, 52)
        Me.btndisconnect.Name = "btndisconnect"
        Me.btndisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btndisconnect.TabIndex = 6
        Me.btndisconnect.Text = "Disconnect"
        Me.btndisconnect.UseVisualStyleBackColor = True
        '
        'gb_transmit
        '
        Me.gb_transmit.Controls.Add(Me.btnledblink)
        Me.gb_transmit.Controls.Add(Me.btnledoff)
        Me.gb_transmit.Controls.Add(Me.btnledon)
        Me.gb_transmit.Location = New System.Drawing.Point(83, 108)
        Me.gb_transmit.Name = "gb_transmit"
        Me.gb_transmit.Size = New System.Drawing.Size(95, 100)
        Me.gb_transmit.TabIndex = 7
        Me.gb_transmit.TabStop = False
        Me.gb_transmit.Text = "Transmit"
        '
        'btnledblink
        '
        Me.btnledblink.Location = New System.Drawing.Point(7, 76)
        Me.btnledblink.Name = "btnledblink"
        Me.btnledblink.Size = New System.Drawing.Size(75, 23)
        Me.btnledblink.TabIndex = 2
        Me.btnledblink.Text = "LED blink"
        Me.btnledblink.UseVisualStyleBackColor = True
        '
        'btnledoff
        '
        Me.btnledoff.Location = New System.Drawing.Point(6, 49)
        Me.btnledoff.Name = "btnledoff"
        Me.btnledoff.Size = New System.Drawing.Size(75, 23)
        Me.btnledoff.TabIndex = 1
        Me.btnledoff.Text = "LED off"
        Me.btnledoff.UseVisualStyleBackColor = True
        '
        'btnledon
        '
        Me.btnledon.Location = New System.Drawing.Point(7, 20)
        Me.btnledon.Name = "btnledon"
        Me.btnledon.Size = New System.Drawing.Size(75, 23)
        Me.btnledon.TabIndex = 0
        Me.btnledon.Text = "LED on"
        Me.btnledon.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(231, 184)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(168, 20)
        Me.txtstatus.TabIndex = 8
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(228, 167)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(84, 13)
        Me.lblstatus.TabIndex = 9
        Me.lblstatus.Text = "Received status"
        '
        'txtcom
        '
        Me.txtcom.Location = New System.Drawing.Point(231, 130)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.ReadOnly = True
        Me.txtcom.Size = New System.Drawing.Size(168, 20)
        Me.txtcom.TabIndex = 10
        '
        'lblcom
        '
        Me.lblcom.AutoSize = True
        Me.lblcom.Location = New System.Drawing.Point(231, 108)
        Me.lblcom.Name = "lblcom"
        Me.lblcom.Size = New System.Drawing.Size(62, 13)
        Me.lblcom.TabIndex = 11
        Me.lblcom.Text = "COM status"
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 240)
        Me.Controls.Add(Me.lblcom)
        Me.Controls.Add(Me.txtcom)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.gb_transmit)
        Me.Controls.Add(Me.btndisconnect)
        Me.Controls.Add(Me.btnconnect)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cbbaud)
        Me.Controls.Add(Me.baudlbl)
        Me.Controls.Add(Me.cbcom)
        Me.Controls.Add(Me.comlbl)
        Me.Name = "main_form"
        Me.Text = "LED Control Panel"
        Me.gb_transmit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comlbl As System.Windows.Forms.Label
    Friend WithEvents cbcom As System.Windows.Forms.ComboBox
    Friend WithEvents baudlbl As System.Windows.Forms.Label
    Friend WithEvents cbbaud As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnconnect As System.Windows.Forms.Button
    Friend WithEvents btndisconnect As System.Windows.Forms.Button
    Friend WithEvents gb_transmit As System.Windows.Forms.GroupBox
    Friend WithEvents btnledblink As System.Windows.Forms.Button
    Friend WithEvents btnledoff As System.Windows.Forms.Button
    Friend WithEvents btnledon As System.Windows.Forms.Button
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents txtcom As System.Windows.Forms.TextBox
    Friend WithEvents lblcom As System.Windows.Forms.Label

End Class
