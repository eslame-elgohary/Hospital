Public Partial Class XafSplashScreen

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XafSplashScreen))
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.subtitleLabel = New DevExpress.XtraEditors.LabelControl()
        Me.applicationNameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureEdit2
        '
        Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit2.EditValue = CType(resources.GetObject("pictureEdit2.EditValue"), Object)
        Me.pictureEdit2.Location = New System.Drawing.Point(12, 12)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.AllowFocused = False
        Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit2.Properties.ShowMenu = False
        Me.pictureEdit2.Size = New System.Drawing.Size(426, 180)
        Me.pictureEdit2.TabIndex = 14
        '
        'pictureEdit1
        '
        Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit1.Location = New System.Drawing.Point(350, 328)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Properties.AllowFocused = False
        Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit1.Properties.ShowMenu = False
        Me.pictureEdit1.Size = New System.Drawing.Size(120, 20)
        Me.pictureEdit1.TabIndex = 13
        '
        'labelControl1
        '
        Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelControl1.Location = New System.Drawing.Point(24, 324)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(47, 13)
        Me.labelControl1.TabIndex = 11
        Me.labelControl1.Text = "Copyright"
        '
        'marqueeProgressBarControl1
        '
        Me.marqueeProgressBarControl1.EditValue = 0
        Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(74, 271)
        Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
        Me.marqueeProgressBarControl1.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.marqueeProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.marqueeProgressBarControl1.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.marqueeProgressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.marqueeProgressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.marqueeProgressBarControl1.Properties.StartColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.marqueeProgressBarControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(350, 16)
        Me.marqueeProgressBarControl1.TabIndex = 10
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.subtitleLabel)
        Me.PanelControl1.Controls.Add(Me.applicationNameLabel)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(494, 220)
        Me.PanelControl1.TabIndex = 15
        '
        'subtitleLabel
        '
        Me.subtitleLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.subtitleLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.subtitleLabel.Appearance.Options.UseFont = True
        Me.subtitleLabel.Appearance.Options.UseForeColor = True
        Me.subtitleLabel.Location = New System.Drawing.Point(60, 114)
        Me.subtitleLabel.Name = "subtitleLabel"
        Me.subtitleLabel.Size = New System.Drawing.Size(378, 25)
        Me.subtitleLabel.TabIndex = 1
        Me.subtitleLabel.Text = "Al Karma Soft for software and web solutions"
        '
        'applicationNameLabel
        '
        Me.applicationNameLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationNameLabel.Appearance.ForeColor = System.Drawing.Color.White
        Me.applicationNameLabel.Appearance.Options.UseFont = True
        Me.applicationNameLabel.Appearance.Options.UseForeColor = True
        Me.applicationNameLabel.Location = New System.Drawing.Point(39, 22)
        Me.applicationNameLabel.Name = "applicationNameLabel"
        Me.applicationNameLabel.Size = New System.Drawing.Size(416, 86)
        Me.applicationNameLabel.TabIndex = 0
        Me.applicationNameLabel.Text = "Doctors Clinic"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(312, 253)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(50, 13)
        Me.labelControl2.TabIndex = 12
        Me.labelControl2.Text = "Starting..."
        '
        'XafSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 370)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Controls.Add(Me.pictureEdit1)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.marqueeProgressBarControl1)
        Me.Name = "XafSplashScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Form1"
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents subtitleLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents applicationNameLabel As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
End Class
