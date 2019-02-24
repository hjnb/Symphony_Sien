<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 洗濯関係
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.unitListBox = New System.Windows.Forms.ListBox()
        Me.dgvResident = New System.Windows.Forms.DataGridView()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.rbtnWashList = New System.Windows.Forms.RadioButton()
        Me.rbtnType = New System.Windows.Forms.RadioButton()
        Me.dgvSisetu = New System.Windows.Forms.DataGridView()
        Me.dgvSibutu = New System.Windows.Forms.DataGridView()
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSisetu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSibutu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'unitListBox
        '
        Me.unitListBox.BackColor = System.Drawing.SystemColors.Control
        Me.unitListBox.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.unitListBox.FormattingEnabled = True
        Me.unitListBox.ItemHeight = 19
        Me.unitListBox.Location = New System.Drawing.Point(18, 31)
        Me.unitListBox.Name = "unitListBox"
        Me.unitListBox.Size = New System.Drawing.Size(39, 194)
        Me.unitListBox.TabIndex = 0
        '
        'dgvResident
        '
        Me.dgvResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResident.Location = New System.Drawing.Point(80, 31)
        Me.dgvResident.Name = "dgvResident"
        Me.dgvResident.RowTemplate.Height = 21
        Me.dgvResident.Size = New System.Drawing.Size(325, 203)
        Me.dgvResident.TabIndex = 1
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(124, 308)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(75, 29)
        Me.btnRegist.TabIndex = 2
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(198, 308)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 29)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "印刷"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'rbtnWashList
        '
        Me.rbtnWashList.AutoSize = True
        Me.rbtnWashList.Location = New System.Drawing.Point(295, 308)
        Me.rbtnWashList.Name = "rbtnWashList"
        Me.rbtnWashList.Size = New System.Drawing.Size(95, 16)
        Me.rbtnWashList.TabIndex = 4
        Me.rbtnWashList.TabStop = True
        Me.rbtnWashList.Text = "洗濯物リスト表"
        Me.rbtnWashList.UseVisualStyleBackColor = True
        '
        'rbtnType
        '
        Me.rbtnType.AutoSize = True
        Me.rbtnType.Location = New System.Drawing.Point(295, 333)
        Me.rbtnType.Name = "rbtnType"
        Me.rbtnType.Size = New System.Drawing.Size(95, 16)
        Me.rbtnType.TabIndex = 5
        Me.rbtnType.TabStop = True
        Me.rbtnType.Text = "処理別一覧表"
        Me.rbtnType.UseVisualStyleBackColor = True
        '
        'dgvSisetu
        '
        Me.dgvSisetu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSisetu.Location = New System.Drawing.Point(433, 31)
        Me.dgvSisetu.Name = "dgvSisetu"
        Me.dgvSisetu.RowTemplate.Height = 21
        Me.dgvSisetu.Size = New System.Drawing.Size(94, 328)
        Me.dgvSisetu.TabIndex = 6
        '
        'dgvSibutu
        '
        Me.dgvSibutu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSibutu.Location = New System.Drawing.Point(538, 31)
        Me.dgvSibutu.Name = "dgvSibutu"
        Me.dgvSibutu.RowTemplate.Height = 21
        Me.dgvSibutu.Size = New System.Drawing.Size(94, 263)
        Me.dgvSibutu.TabIndex = 7
        '
        '洗濯関係
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 379)
        Me.Controls.Add(Me.dgvSibutu)
        Me.Controls.Add(Me.dgvSisetu)
        Me.Controls.Add(Me.rbtnType)
        Me.Controls.Add(Me.rbtnWashList)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.dgvResident)
        Me.Controls.Add(Me.unitListBox)
        Me.Name = "洗濯関係"
        Me.Text = "洗濯物リスト表/処理別一覧表"
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSisetu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSibutu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unitListBox As ListBox
    Friend WithEvents dgvResident As DataGridView
    Friend WithEvents btnRegist As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents rbtnWashList As RadioButton
    Friend WithEvents rbtnType As RadioButton
    Friend WithEvents dgvSisetu As DataGridView
    Friend WithEvents dgvSibutu As DataGridView
End Class
