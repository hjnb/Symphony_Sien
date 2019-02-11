<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.topPicture = New System.Windows.Forms.PictureBox()
        Me.rbtnPreview = New System.Windows.Forms.RadioButton()
        Me.rbtnPrintout = New System.Windows.Forms.RadioButton()
        Me.btnHouseDiary = New System.Windows.Forms.Button()
        Me.btnResidentRegist = New System.Windows.Forms.Button()
        Me.btnRoomRegist = New System.Windows.Forms.Button()
        Me.btnWash = New System.Windows.Forms.Button()
        CType(Me.topPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPicture
        '
        Me.topPicture.Location = New System.Drawing.Point(447, 108)
        Me.topPicture.Name = "topPicture"
        Me.topPicture.Size = New System.Drawing.Size(217, 142)
        Me.topPicture.TabIndex = 0
        Me.topPicture.TabStop = False
        '
        'rbtnPreview
        '
        Me.rbtnPreview.AutoSize = True
        Me.rbtnPreview.Location = New System.Drawing.Point(447, 63)
        Me.rbtnPreview.Name = "rbtnPreview"
        Me.rbtnPreview.Size = New System.Drawing.Size(63, 16)
        Me.rbtnPreview.TabIndex = 10
        Me.rbtnPreview.TabStop = True
        Me.rbtnPreview.Text = "ﾌﾟﾚﾋﾞｭｰ"
        Me.rbtnPreview.UseVisualStyleBackColor = True
        '
        'rbtnPrintout
        '
        Me.rbtnPrintout.AutoSize = True
        Me.rbtnPrintout.Location = New System.Drawing.Point(540, 63)
        Me.rbtnPrintout.Name = "rbtnPrintout"
        Me.rbtnPrintout.Size = New System.Drawing.Size(47, 16)
        Me.rbtnPrintout.TabIndex = 12
        Me.rbtnPrintout.TabStop = True
        Me.rbtnPrintout.Text = "印刷"
        Me.rbtnPrintout.UseVisualStyleBackColor = True
        '
        'btnHouseDiary
        '
        Me.btnHouseDiary.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHouseDiary.ForeColor = System.Drawing.Color.Red
        Me.btnHouseDiary.Location = New System.Drawing.Point(26, 32)
        Me.btnHouseDiary.Name = "btnHouseDiary"
        Me.btnHouseDiary.Size = New System.Drawing.Size(204, 151)
        Me.btnHouseDiary.TabIndex = 3
        Me.btnHouseDiary.Text = "ハウス日誌"
        Me.btnHouseDiary.UseVisualStyleBackColor = True
        '
        'btnResidentRegist
        '
        Me.btnResidentRegist.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnResidentRegist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResidentRegist.Location = New System.Drawing.Point(26, 207)
        Me.btnResidentRegist.Name = "btnResidentRegist"
        Me.btnResidentRegist.Size = New System.Drawing.Size(102, 52)
        Me.btnResidentRegist.TabIndex = 4
        Me.btnResidentRegist.Text = "入居者登録"
        Me.btnResidentRegist.UseVisualStyleBackColor = True
        '
        'btnRoomRegist
        '
        Me.btnRoomRegist.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRoomRegist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRoomRegist.Location = New System.Drawing.Point(128, 207)
        Me.btnRoomRegist.Name = "btnRoomRegist"
        Me.btnRoomRegist.Size = New System.Drawing.Size(102, 52)
        Me.btnRoomRegist.TabIndex = 5
        Me.btnRoomRegist.Text = "居室登録"
        Me.btnRoomRegist.UseVisualStyleBackColor = True
        '
        'btnWash
        '
        Me.btnWash.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnWash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWash.Location = New System.Drawing.Point(230, 207)
        Me.btnWash.Name = "btnWash"
        Me.btnWash.Size = New System.Drawing.Size(102, 52)
        Me.btnWash.TabIndex = 6
        Me.btnWash.Text = "洗濯関係"
        Me.btnWash.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 559)
        Me.Controls.Add(Me.btnWash)
        Me.Controls.Add(Me.btnRoomRegist)
        Me.Controls.Add(Me.btnResidentRegist)
        Me.Controls.Add(Me.btnHouseDiary)
        Me.Controls.Add(Me.rbtnPrintout)
        Me.Controls.Add(Me.rbtnPreview)
        Me.Controls.Add(Me.topPicture)
        Me.Name = "TopForm"
        Me.Text = "Sien 生活支援ハウス"
        CType(Me.topPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents topPicture As PictureBox
    Friend WithEvents rbtnPreview As RadioButton
    Friend WithEvents rbtnPrintout As RadioButton
    Friend WithEvents btnHouseDiary As Button
    Friend WithEvents btnResidentRegist As Button
    Friend WithEvents btnRoomRegist As Button
    Friend WithEvents btnWash As Button
End Class
