Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Office.Interop

Public Class 洗濯関係

    'ﾕﾆｯﾄ配列
    Private unitArray() As String = {"森", "星", "空", "花", "月", "虹", "光", "丘", "風", "雪"}

    'ﾕﾆｯﾄ名番号対応
    Private unitNumDictionary As New Dictionary(Of String, Integer) From {{"森", 0}, {"星", 1}, {"空", 2}, {"花", 3}, {"月", 4}, {"虹", 5}, {"光", 6}, {"丘", 7}, {"風", 8}, {"雪", 9}}

    'チェックボックス列チェック制御用フラグ
    Private cellValueChangeFlg As Boolean = False

    'セルエンター制御用
    Private cellEnterFlg As Boolean = False

    '文字数制御用
    Private Const LIMIT_LENGTHBYTE_NAM As Integer = 16
    Private Const LIMIT_LENGTHBYTE_BIKO As Integer = 24

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
    ''' 洗濯物リスト表印刷
    ''' </summary>
    Private Sub printWashList()
        Dim namAllArray(9, 9) As String '各ユニットのチェック有の氏名
        Dim sisetuWashArray(20, 0) As String
        Dim sibutuWashArray(16, 0) As String

        '書き込みデータ取得
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Sien)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from Wash order by Gyo"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            Dim gyo As Integer = rs.Fields("Gyo").Value
            If gyo = 0 Then
                '施設
                For i As Integer = 1 To 21
                    sisetuWashArray(i - 1, 0) = Util.checkDBNullValue(rs.Fields("ss" & i).Value)
                Next

                '私物
                For i As Integer = 1 To 17
                    sibutuWashArray(i - 1, 0) = Util.checkDBNullValue(rs.Fields("sb" & i).Value)
                Next
            End If
            '氏名
            Dim count As Integer = 0
            For i As Integer = 1 To 10
                Dim chk As String = Util.checkDBNullValue(rs.Fields("chk" & i).Value)
                'チェック有の氏名を代入
                If chk = "1" Then
                    namAllArray(gyo, count) = Util.checkDBNullValue(rs.Fields("nam" & i).Value)
                    count += 1
                End If
            Next
            rs.MoveNext()
        End While
        rs.Close()
        cnn.Close()

        'エクセル準備
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("2改")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '共通部分貼り付け
        '施設洗濯物
        oSheet.Range("A5", "A25").Value = sisetuWashArray
        oSheet.Range("L5", "L25").Value = sisetuWashArray
        '私物洗濯物
        oSheet.Range("A29", "A45").Value = sibutuWashArray
        oSheet.Range("L29", "L45").Value = sibutuWashArray

        '各ユニット用にコピペ
        For i As Integer = 1 To 9
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (1 + 46 * i)) 'ペースト先
            oSheet.Rows("1:46").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (1 + 46 * i))) '改ページ
        Next

        'ユニット名、対象入居者名書き込み
        For i As Integer = 0 To 9
            'ユニット名
            oSheet.Range("H" & (1 + 46 * i)).Value = "( " & unitArray(i) & " )"

            '入居者名
            Dim namArray(9) As String
            For j As Integer = 0 To 9
                namArray(j) = namAllArray(i, j)
            Next
            oSheet.Range("B" & (4 + 46 * i), "K" & (4 + 46 * i)).Value = namArray
            oSheet.Range("B" & (28 + 46 * i), "K" & (28 + 46 * i)).Value = namArray
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If TopForm.rbtnPrintout.Checked = True Then
            oSheet.PrintOut()
        ElseIf TopForm.rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 処理別一覧表印刷
    ''' </summary>
    Private Sub printTypeList()
        'データ取得
        Dim page1Array(54, 3) As String '森、星、空、花、月
        Dim page2Array(54, 3) As String '虹、光、丘、風、雪
        Dim baseRowIndex() As Integer = {0, 11, 22, 33, 44}
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Sien)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from Wash order by Gyo"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            Dim outNamList As New List(Of String)
            Dim outMemList As New List(Of String)
            Dim inNamList As New List(Of String)
            Dim inMemList As New List(Of String)
            For i As Integer = 1 To 10
                Dim nam As String = Util.checkDBNullValue(rs.Fields("nam" & i).Value)
                If nam = "" Then
                    Continue For
                End If
                Dim chk As String = Util.checkDBNullValue(rs.Fields("chk" & i).Value)
                Dim mem As String = Util.checkDBNullValue(rs.Fields("mem" & i).Value)
                If chk = "1" Then
                    outNamList.Add(nam)
                    outMemList.Add(mem)
                Else
                    inNamList.Add(nam)
                    inMemList.Add(mem)
                End If
            Next
            Dim gyo As Integer = rs.Fields("Gyo").Value
            If 0 <= gyo AndAlso gyo <= 4 Then
                Dim startRowIndex As Integer = baseRowIndex(gyo)
                For i As Integer = 0 To outNamList.Count - 1
                    page1Array(startRowIndex + i, 0) = outNamList(i)
                    page1Array(startRowIndex + i, 1) = outMemList(i)
                Next
                page1Array(startRowIndex + 10, 0) = "計 " & outNamList.Count & " 人"
                For i As Integer = 0 To inNamList.Count - 1
                    page1Array(startRowIndex + i, 2) = inNamList(i)
                    page1Array(startRowIndex + i, 3) = inMemList(i)
                Next
                page1Array(startRowIndex + 10, 2) = "計 " & inNamList.Count & " 人"
            ElseIf 5 <= gyo AndAlso gyo <= 9 Then
                Dim startRowIndex As Integer = baseRowIndex(gyo - 5)
                For i As Integer = 0 To outNamList.Count - 1
                    page2Array(startRowIndex + i, 0) = outNamList(i)
                    page2Array(startRowIndex + i, 1) = outMemList(i)
                Next
                page2Array(startRowIndex + 10, 0) = "計 " & outNamList.Count & " 人"
                For i As Integer = 0 To inNamList.Count - 1
                    page2Array(startRowIndex + i, 2) = inNamList(i)
                    page2Array(startRowIndex + i, 3) = inMemList(i)
                Next
                page2Array(startRowIndex + 10, 2) = "計 " & inNamList.Count & " 人"
            End If
            rs.MoveNext()
        End While
        rs.Close()
        cnn.Close()

        'エクセル準備
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '1枚目
        oSheet = objWorkBook.Worksheets("3改")
        oSheet.Range("G2").Value = "印刷日 : " & formatDateStr(Today.ToString("yyyy/MM/dd"))
        oSheet.Range("E6", "H60").Value = page1Array

        '2枚目
        oSheet = objWorkBook.Worksheets("4改")
        oSheet.Range("G2").Value = "印刷日 : " & formatDateStr(Today.ToString("yyyy/MM/dd"))
        oSheet.Range("E6", "H60").Value = page2Array

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If TopForm.rbtnPrintout.Checked = True Then
            objWorkBook.Worksheets({"3改", "4改"}).PrintOut()
        ElseIf TopForm.rbtnPreview.Checked = True Then
            objExcel.Visible = True
            objWorkBook.Worksheets({"3改", "4改"}).PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 和暦表記にフォーマット
    ''' </summary>
    ''' <param name="adStr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function formatDateStr(adStr As String) As String
        If adStr = "" Then
            Return ""
        End If
        Dim dayArray() As String = {"日", "月", "火", "水", "木", "金", "土"}
        Dim day As String = dayArray(New DateTime(CInt(adStr.Substring(0, 4)), CInt(adStr.Substring(5, 2)), CInt(adStr.Substring(8, 2))).DayOfWeek)
        Dim warekiStr As String = Util.convADStrToWarekiStr(adStr)
        Dim kanji As String = Util.getKanji(warekiStr)
        Dim eraNum As String = CInt(warekiStr.Substring(1, 2))
        Dim monthNum As String = CInt(warekiStr.Substring(4, 2))
        Dim dateNum As String = CInt(warekiStr.Substring(7, 2))
        Return kanji & " " & eraNum & " 年 " & monthNum & " 月 " & dateNum & " 日 " & "( " & day & " )"
    End Function

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

    ''' <summary>
    ''' 印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If rbtnWashList.Checked Then
            '洗濯物リスト表印刷
            printWashList()
        Else
            '処理別一覧表印刷
            printTypeList()
        End If
    End Sub

    ''' <summary>
    ''' dgvResidentのEditingControlShowingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvResident_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvResident.EditingControlShowing
        Dim editTextBox As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
        Dim columnNum As String = dgvResident.CurrentCell.ColumnIndex

        'イベントハンドラを削除、追加
        If columnNum = 1 Then '氏名列
            RemoveHandler editTextBox.KeyPress, AddressOf namTextBox_KeyPress
            RemoveHandler editTextBox.KeyPress, AddressOf bikoTextBox_KeyPress
            AddHandler editTextBox.KeyPress, AddressOf namTextBox_KeyPress
        ElseIf columnNum = 2 Then '備考列
            RemoveHandler editTextBox.KeyPress, AddressOf namTextBox_KeyPress
            RemoveHandler editTextBox.KeyPress, AddressOf bikoTextBox_KeyPress
            AddHandler editTextBox.KeyPress, AddressOf bikoTextBox_KeyPress
        End If
    End Sub

    ''' <summary>
    ''' dgvSisetu,dgvSibutuのEditingControlShowingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvS_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvSisetu.EditingControlShowing, dgvSibutu.EditingControlShowing
        Dim editTextBox As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)

        'イベントハンドラを削除、追加
        RemoveHandler editTextBox.KeyPress, AddressOf namTextBox_KeyPress
        AddHandler editTextBox.KeyPress, AddressOf namTextBox_KeyPress
    End Sub

    ''' <summary>
    ''' 備考用のテキストボックスKeyPressイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bikoTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim text As String = CType(sender, DataGridViewTextBoxEditingControl).Text
        Dim lengthByte As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(text)
        Dim limitLengthByte As Integer = LIMIT_LENGTHBYTE_BIKO

        If lengthByte >= limitLengthByte Then '設定されているバイト数以上の時
            If e.KeyChar = ChrW(Keys.Back) Then
                'Backspaceは入力可能
                e.Handled = False
            Else
                '入力できなくする
                e.Handled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' 備考以外用のテキストボックスKeyPressイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub namTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim text As String = CType(sender, DataGridViewTextBoxEditingControl).Text
        Dim lengthByte As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(text)
        Dim limitLengthByte As Integer = LIMIT_LENGTHBYTE_NAM

        If lengthByte >= limitLengthByte Then '設定されているバイト数以上の時
            If e.KeyChar = ChrW(Keys.Back) Then
                'Backspaceは入力可能
                e.Handled = False
            Else
                '入力できなくする
                e.Handled = True
            End If
        End If
    End Sub
End Class