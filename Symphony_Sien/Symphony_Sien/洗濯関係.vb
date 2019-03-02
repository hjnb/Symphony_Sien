Public Class 洗濯関係

    'ﾕﾆｯﾄ配列
    Private unitArray() As String = {"森", "星", "空", "花", "月", "虹", "光", "丘", "風", "雪"}

    'ﾕﾆｯﾄ名番号対応
    Private unitNumDictionary As New Dictionary(Of String, Integer) From {{"森", 0}, {"星", 1}, {"空", 2}, {"花", 3}, {"月", 4}, {"虹", 5}, {"光", 6}, {"丘", 7}, {"風", 8}, {"雪", 9}}

    'チェックボックス列チェック制御用フラグ
    Private cellValueChangeFlg As Boolean = False

    'セルエンター制御用
    Private cellEnterFlg As Boolean = False

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

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 洗濯関係_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'データグリッドビュー初期化
        initDgvResident()
        initDgvSisetu()
        initDgvSibutu()


        'ﾕﾆｯﾄ配列セット
        unitListBox.Items.AddRange(unitArray)

        '森を選択
        unitListBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' 入居者dgv初期設定
    ''' </summary>
    Private Sub initDgvResident()
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
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ShowCellToolTips = False
            .ImeMode = ImeMode.Hiragana
        End With

        '空行追加
        Dim dt As New DataTable()
        dt.Columns.Add("chk", GetType(Boolean))
        dt.Columns.Add("nam", GetType(String))
        dt.Columns.Add("mem", GetType(String))
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
            With .Columns("chk")
                .HeaderText = "ワ"
                .Width = 20
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .DefaultCellStyle.BackColor = Color.White
                .DefaultCellStyle.SelectionBackColor = Color.White
            End With

            With .Columns("nam")
                .HeaderText = "氏名"
                .Width = 107
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With

            With .Columns("mem")
                .HeaderText = "備　考"
                .Width = 170
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With
        End With

        cellValueChangeFlg = True
        dgvResident.CurrentCell.Selected = False

    End Sub

    ''' <summary>
    ''' 施設dgv初期設定
    ''' </summary>
    Private Sub initDgvSisetu()
        Util.EnableDoubleBuffering(dgvSisetu)

        With dgvSisetu
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
            .RowHeadersVisible = False
            .RowTemplate.Height = 15
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ShowCellToolTips = False
            .ImeMode = ImeMode.Hiragana
        End With

        '空行追加
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        For i = 0 To 20
            Dim row As DataRow = dt.NewRow()
            row(0) = ""
            dt.Rows.Add(row)
        Next
        dgvSisetu.DataSource = dt

        '幅設定等
        With dgvSisetu
            With .Columns("Text")
                .HeaderText = "施設"
                .Width = 105
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With
        End With

        dgvSisetu.CurrentCell.Selected = False

    End Sub

    ''' <summary>
    ''' 私物dgv初期設定
    ''' </summary>
    Private Sub initDgvSibutu()
        Util.EnableDoubleBuffering(dgvSibutu)

        With dgvSibutu
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
            .RowHeadersVisible = False
            .RowTemplate.Height = 15
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ShowCellToolTips = False
            .ImeMode = ImeMode.Hiragana
        End With

        '空行追加
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        For i = 0 To 16
            Dim row As DataRow = dt.NewRow()
            row(0) = ""
            dt.Rows.Add(row)
        Next
        dgvSibutu.DataSource = dt

        '幅設定等
        With dgvSibutu
            With .Columns("Text")
                .HeaderText = "私物"
                .Width = 105
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With
        End With

        dgvSibutu.CurrentCell.Selected = False

    End Sub

    ''' <summary>
    ''' 対象のユニットのデータ表示
    ''' </summary>
    ''' <param name="unitName">ユニット名</param>
    Private Sub displayUnitData(unitName As String)
        If Not unitNumDictionary.ContainsKey(unitName) Then
            Return
        End If

        '入力クリア
        clearInput()

        cellEnterFlg = False

        If unitName = "森" Then
            dgvSisetu.Visible = True
            dgvSibutu.Visible = True
        Else
            dgvSisetu.Visible = False
            dgvSibutu.Visible = False
        End If

        Dim gyo As Integer = unitNumDictionary(unitName)
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from Wash where Gyo=" & gyo & ""
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.RecordCount > 0 Then
            For i As Integer = 1 To 10
                'チェック
                Dim chk As String = Util.checkDBNullValue(rs.Fields("chk" & i).Value)
                dgvResident("chk", i - 1).Value = If(chk = "1", True, False)
                '名前
                dgvResident("nam", i - 1).Value = Util.checkDBNullValue(rs.Fields("nam" & i).Value)
                '備考
                dgvResident("mem", i - 1).Value = Util.checkDBNullValue(rs.Fields("mem" & i).Value)
            Next
            If gyo = 0 Then
                For i As Integer = 1 To 21
                    dgvSisetu("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("ss" & i).Value)
                Next
                For i As Integer = 1 To 17
                    dgvSibutu("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("sb" & i).Value)
                Next
            End If
        End If

        rs.Close()
        cnn.Close()

        cellEnterFlg = True
    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        For Each row As DataGridViewRow In dgvResident.Rows
            row.Cells(0).Value = False
            row.Cells(1).Value = ""
            row.Cells(2).Value = ""
        Next
        For Each row As DataGridViewRow In dgvSisetu.Rows
            row.Cells(0).Value = ""
        Next
        For Each row As DataGridViewRow In dgvSibutu.Rows
            row.Cells(0).Value = ""
        Next
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

    Private Sub dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResident.CellEnter, dgvSisetu.CellEnter, dgvSibutu.CellEnter
        If cellEnterFlg Then
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)
            dgv.BeginEdit(False)
        End If
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

    Private Sub unitListBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles unitListBox.SelectedValueChanged
        Dim selectedUnitName As String = unitListBox.Text
        displayUnitData(selectedUnitName)
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        Dim unitName As String = unitListBox.Text
        Dim unitNumber As Integer
        If unitNumDictionary.ContainsKey(unitName) Then
            unitNumber = unitNumDictionary(unitName)
        Else
            MsgBox("ユニット名を選択して下さい。", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Sien)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from Wash where Gyo=" & unitNumber
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount = 0 OrElse rs.RecordCount = 1 Then
            If rs.RecordCount = 0 Then
                '新規登録
                rs.AddNew()
            End If
            rs.Fields("Gyo").Value = unitNumber
            For i As Integer = 1 To 10
                rs.Fields("chk" & i).Value = If(dgvResident("chk", i - 1).Value = True, "1", "0")
                rs.Fields("nam" & i).Value = Util.checkDBNullValue(dgvResident("nam", i - 1).Value)
                rs.Fields("mem" & i).Value = Util.checkDBNullValue(dgvResident("mem", i - 1).Value)
            Next
            If unitNumber = 0 Then
                '施設
                For i As Integer = 1 To 21
                    rs.Fields("ss" & i).Value = Util.checkDBNullValue(dgvSisetu(0, i - 1).Value)
                Next

                '私物
                For i As Integer = 1 To 17
                    rs.Fields("sb" & i).Value = Util.checkDBNullValue(dgvSibutu(0, i - 1).Value)
                Next
            End If
            rs.Update()
            rs.Close()
            cnn.Close()
            MsgBox("登録しました。", MsgBoxStyle.Information)
        Else
            rs.Close()
            cnn.Close()
        End If
    End Sub
End Class