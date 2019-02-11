Imports System.Data.OleDb

Public Class 入居者登録

    '現在選択しているAutono
    Private selectedAutono As Integer = -1

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
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    ''' <summary>
    ''' keyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 入居者登録_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 入居者登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'テキストボックス初期設定
        initTextBox()

        'データグリッドビュー初期設定
        initDgvResident()

        'データ表示
        displayDgvResident()
    End Sub

    ''' <summary>
    ''' テキストクリア
    ''' </summary>
    Private Sub clearInputText()
        namBox.Text = ""
        kanaBox.Text = ""
        selectedAutono = -1
    End Sub

    ''' <summary>
    ''' テキストボックス初期設定
    ''' </summary>
    Private Sub initTextBox()
        '入居者名ボックス
        namBox.ImeMode = ImeMode.Hiragana

        'カナボックス
        kanaBox.ImeMode = ImeMode.KatakanaHalf
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    Private Sub initDgvResident()
        Util.EnableDoubleBuffering(dgvResident)

        With dgvResident
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'クリック時に行選択
            .MultiSelect = False
            .ReadOnly = True
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 20
            .RowTemplate.Height = 15
            .RowHeadersWidth = 35
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ShowCellToolTips = False
        End With
    End Sub

    ''' <summary>
    ''' dgvデータ表示
    ''' </summary>
    Private Sub displayDgvResident()
        dgvResident.Columns.Clear()
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Autono, Nam, Kana from UsrM order by Kana"
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "UsrM")
        dgvResident.DataSource = ds.Tables("UsrM")
        cnn.Close()

        If dgvResident.Rows.Count > 20 Then
            dgvResident.Size = New Size(334, 322)
        Else
            dgvResident.Size = New Size(317, 322)
        End If
        settingDgvResident()
    End Sub

    ''' <summary>
    ''' dgv表示設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingDgvResident()
        '並び替えができないようにする
        For Each c As DataGridViewColumn In dgvResident.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        With dgvResident
            .Columns("Autono").Visible = False

            With .Columns("Nam")
                .HeaderText = "利用者氏名"
                .Width = 115
            End With

            With .Columns("Kana")
                .HeaderText = "カナ"
                .Width = 165
            End With
        End With
    End Sub

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' セルマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvResident_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResident.CellMouseClick
        If e.RowIndex >= 0 Then
            '選択している値取得
            selectedAutono = dgvResident("Autono", e.RowIndex).Value
            Dim nam As String = Util.checkDBNullValue(dgvResident("Nam", e.RowIndex).Value)
            Dim kana As String = Util.checkDBNullValue(dgvResident("Kana", e.RowIndex).Value)

            '各ボックスへセット
            namBox.Text = nam
            kanaBox.Text = kana
        End If
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        Dim nam As String = namBox.Text '利用者氏名
        Dim kana As String = kanaBox.Text 'カナ

        '入力項目チェック
        If nam = "" Then
            MsgBox("漢字氏名を入力して下さい。", MsgBoxStyle.Exclamation)
            namBox.Focus()
            Return
        End If
        If kana = "" Then
            MsgBox("ｶﾅ氏名を入力して下さい。", MsgBoxStyle.Exclamation)
            kanaBox.Focus()
            Return
        End If

        '登録処理
        If selectedAutono = -1 Then '新規登録
            Dim result As DialogResult = MessageBox.Show("新規登録してよろしいですか？", "登録", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cn As New ADODB.Connection()
                cn.Open(TopForm.DB_Sien)
                Dim rs As New ADODB.Recordset
                rs.Open("UsrM", cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
                rs.AddNew()
                rs.Fields("Nam").Value = nam
                rs.Fields("Kana").Value = kana
                rs.Update()
                rs.Close()
                cn.Close()

                '再表示
                clearInputText()
                displayDgvResident()
            End If
        Else '変更登録
            Dim result As DialogResult = MessageBox.Show("変更登録してよろしいですか？", "登録", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cn As New ADODB.Connection()
                cn.Open(TopForm.DB_Sien)
                Dim rs As New ADODB.Recordset
                Dim sql As String = "select Autono, Nam, Kana from UsrM where Autono=" & selectedAutono
                rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
                rs.Fields("Nam").Value = nam
                rs.Fields("Kana").Value = kana
                rs.Update()
                rs.Close()
                cn.Close()

                '再表示
                clearInputText()
                displayDgvResident()
            End If
        End If

    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '削除対象行が選択されていない場合
        If selectedAutono = -1 Then
            MsgBox("選択されていません。", MsgBoxStyle.Exclamation)
            Return
        End If

        '削除処理
        Dim result As DialogResult = MessageBox.Show("削除してよろしいですか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim cn As New ADODB.Connection()
            cn.Open(TopForm.DB_Sien)
            Dim rs As New ADODB.Recordset
            Dim sql As String = "select Autono, Nam, Kana from UsrM where Autono=" & selectedAutono
            rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Delete()
            rs.Update()
            rs.Close()
            cn.Close()

            '再表示
            clearInputText()
            displayDgvResident()
        End If
    End Sub
End Class