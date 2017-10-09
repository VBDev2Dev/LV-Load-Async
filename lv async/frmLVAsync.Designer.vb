<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLVAsync
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
        Me.lvLoad = New System.Windows.Forms.ListView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvLoad
        '
        Me.lvLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvLoad.Location = New System.Drawing.Point(0, 0)
        Me.lvLoad.Name = "lvLoad"
        Me.lvLoad.Size = New System.Drawing.Size(655, 354)
        Me.lvLoad.TabIndex = 0
        Me.lvLoad.UseCompatibleStateImageBehavior = False
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(81, 19)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load Data"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 66)
        Me.Panel1.TabIndex = 2
        '
        'frmLVAsync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvLoad)
        Me.Name = "frmLVAsync"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvLoad As ListView
    Friend WithEvents btnLoad As Button
    Friend WithEvents Panel1 As Panel
End Class
