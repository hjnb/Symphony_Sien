﻿Public Class 洗濯関係

    'ﾕﾆｯﾄ配列
    Private unitArray() As String = {"森", "星", "空", "花", "月", "虹", "光", "丘", "風", "雪"}

    '
    Private cellValueChangeFlg As Boolean = False

    ''' <summary>
    ''' 行ヘッダーのカレントセルを表す三角マークを非表示に設定する為のクラス。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class dgvRowHeaderCell

        'DataGridViewRowHeaderCell を継承
        Inherits DataGridViewRowHeaderCell

        'DataGridViewHeaderCell.Paint をオーバーライドして行ヘッダーを描画
        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle,
           ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates,
           ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String,
           ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle,
           ByVal paintParts As DataGridViewPaintParts)
            '標準セルの描画からセル内容の背景だけ除いた物を描画(-5)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
                     formattedValue, errorText, cellStyle, advancedBorderStyle,
                     Not DataGridViewPaintParts.ContentBackground)
        End Sub

    End Class

    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub 洗濯関係_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initDgvNam()

        'ﾕﾆｯﾄ配列セット
        unitListBox.Items.AddRange(unitArray)

        '森を選択
        unitListBox.SelectedIndex = 0
    End Sub

    Private Sub initDgvNam()
        Util.EnableDoubleBuffering(dgvResident)

        With dgvResident
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .BorderStyle = BorderStyle.None
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 20
            .RowTemplate.Height = 18
            .RowHeadersWidth = 25
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ShowCellToolTips = False
        End With

        '空行追加
        Dim dt As New DataTable()
        dt.Columns.Add("Check", GetType(Boolean))
        dt.Columns.Add("Nam", GetType(String))
        dt.Columns.Add("Biko", GetType(String))
        For i = 0 To 9
            Dim row As DataRow = dt.NewRow()
            row(0) = False
            row(1) = ""
            row(2) = ""
            dt.Rows.Add(row)
        Next
        dgvResident.DataSource = dt

        '幅設定等
        With dgvResident
            With .Columns("Check")
                .HeaderText = "ワ"
                .Width = 23
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .DefaultCellStyle.BackColor = Color.White
                .DefaultCellStyle.SelectionBackColor = Color.White
            End With

            With .Columns("Nam")
                .HeaderText = "氏名"
                .Width = 105
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With

            With .Columns("Biko")
                .HeaderText = "備　考"
                .Width = 170
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With
        End With

        cellValueChangeFlg = True

        dgvResident.CurrentCell.Selected = False

    End Sub

    Private Sub dgvResident_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvResident.CellPainting
        '行ヘッダーかどうか調べる
        If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
            'セルを描画する
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

            '行番号を描画する範囲を決定する
            'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
            Dim indexRect As Rectangle = e.CellBounds
            indexRect.Inflate(-2, -2)
            '行番号を描画する
            TextRenderer.DrawText(e.Graphics,
                (e.RowIndex + 1).ToString(),
                e.CellStyle.Font,
                indexRect,
                e.CellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            '描画が完了したことを知らせる
            e.Handled = True
        End If
    End Sub

    Private Sub dgvResident_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResident.CellEnter
        dgvResident.BeginEdit(False)
    End Sub

    Private Sub dgvResident_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResident.CellValueChanged
        If cellValueChangeFlg AndAlso e.ColumnIndex = 0 Then
            Dim cellChecked As Boolean = dgvResident(e.ColumnIndex, e.RowIndex).Value
            If cellChecked Then
                dgvResident(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.Red
                dgvResident(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.Red
            Else
                dgvResident(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.White
                dgvResident(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.White
            End If
        End If
    End Sub

    Private Sub dgvResident_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvResident.CurrentCellDirtyStateChanged
        If dgvResident.CurrentCellAddress.X = 0 AndAlso dgvResident.IsCurrentCellDirty Then
            'コミットする
            dgvResident.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class