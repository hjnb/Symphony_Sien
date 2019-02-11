<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 入居者登録
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvResident = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namBox = New System.Windows.Forms.TextBox()
        Me.kanaBox = New System.Windows.Forms.TextBox()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResident
        '
        Me.dgvResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResident.Location = New System.Drawing.Point(17, 122)
        Me.dgvResident.Name = "dgvResident"
        Me.dgvResident.RowTemplate.Height = 21
        Me.dgvResident.Size = New System.Drawing.Size(334, 322)
        Me.dgvResident.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "入居者名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ｶﾅ"
        '
        'namBox
        '
        Me.namBox.Location = New System.Drawing.Point(108, 29)
        Me.namBox.Name = "namBox"
        Me.namBox.Size = New System.Drawing.Size(114, 19)
        Me.namBox.TabIndex = 3
        '
        'kanaBox
        '
        Me.kanaBox.Location = New System.Drawing.Point(108, 57)
        Me.kanaBox.Name = "kanaBox"
        Me.kanaBox.Size = New System.Drawing.Size(114, 19)
        Me.kanaBox.TabIndex = 4
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(250, 21)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(69, 30)
        Me.btnRegist.TabIndex = 5
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(250, 54)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 30)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        '入居者登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 464)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.kanaBox)
        Me.Controls.Add(Me.namBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvResident)
        Me.Name = "入居者登録"
        Me.Text = "入居者登録"
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvResident As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namBox As TextBox
    Friend WithEvents kanaBox As TextBox
    Friend WithEvents btnRegist As Button
    Friend WithEvents btnDelete As Button
End Class
