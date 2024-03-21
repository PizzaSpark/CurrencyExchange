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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxFrom = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTo = New System.Windows.Forms.ComboBox()
        Me.TextBoxTo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(855, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Exchange Rates"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxFrom
        '
        Me.TextBoxFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFrom.Location = New System.Drawing.Point(62, 172)
        Me.TextBoxFrom.Name = "TextBoxFrom"
        Me.TextBoxFrom.Size = New System.Drawing.Size(330, 41)
        Me.TextBoxFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxFrom
        '
        Me.ComboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxFrom.FormattingEnabled = True
        Me.ComboBoxFrom.Items.AddRange(New Object() {"PHP - Philippine Peso", "USD - US Dollar", "JPY - Japanese Yen", "EUR - Euro", "HKD - Hong Kong Dollar"})
        Me.ComboBoxFrom.Location = New System.Drawing.Point(62, 229)
        Me.ComboBoxFrom.Name = "ComboBoxFrom"
        Me.ComboBoxFrom.Size = New System.Drawing.Size(330, 37)
        Me.ComboBoxFrom.TabIndex = 3
        '
        'ComboBoxTo
        '
        Me.ComboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTo.FormattingEnabled = True
        Me.ComboBoxTo.Location = New System.Drawing.Point(463, 229)
        Me.ComboBoxTo.Name = "ComboBoxTo"
        Me.ComboBoxTo.Size = New System.Drawing.Size(330, 37)
        Me.ComboBoxTo.TabIndex = 5
        '
        'TextBoxTo
        '
        Me.TextBoxTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTo.Location = New System.Drawing.Point(463, 172)
        Me.TextBoxTo.Name = "TextBoxTo"
        Me.TextBoxTo.ReadOnly = True
        Me.TextBoxTo.Size = New System.Drawing.Size(330, 41)
        Me.TextBoxTo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 450)
        Me.Controls.Add(Me.ComboBoxTo)
        Me.Controls.Add(Me.TextBoxTo)
        Me.Controls.Add(Me.ComboBoxFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFrom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ReyesConverter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxFrom As ComboBox
    Friend WithEvents ComboBoxTo As ComboBox
    Friend WithEvents TextBoxTo As TextBox
End Class
