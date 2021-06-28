<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lacto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lacto))
        Me.lblLacto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFine1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLacto
        '
        Me.lblLacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLacto.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLacto.Location = New System.Drawing.Point(27, 65)
        Me.lblLacto.Name = "lblLacto"
        Me.lblLacto.Size = New System.Drawing.Size(322, 352)
        Me.lblLacto.TabIndex = 0
        Me.lblLacto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your Order is As Follows: "
        '
        'BtnFine1
        '
        Me.BtnFine1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFine1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFine1.Location = New System.Drawing.Point(241, 367)
        Me.BtnFine1.Name = "BtnFine1"
        Me.BtnFine1.Size = New System.Drawing.Size(94, 38)
        Me.BtnFine1.TabIndex = 3
        Me.BtnFine1.Text = "Ok"
        Me.BtnFine1.UseVisualStyleBackColor = False
        '
        'Lacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 496)
        Me.Controls.Add(Me.BtnFine1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLacto)
        Me.Name = "Lacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lacto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLacto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFine1 As Button
End Class
