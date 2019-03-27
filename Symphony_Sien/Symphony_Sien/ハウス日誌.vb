Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class ハウス日誌

    '時間入力チェックエラー
    Private Const ERROR_HALF_NUMBER As Integer = 1
    Private Const ERROR_HALF_NUMBER_MESSAGE As String = "時間は半角数字で入力して下さい。"
    Private Const ERROR_24HOUR As Integer = 2
    Private Const ERROR_24HOUR_MESSAGE As String = "時間は24時間制で入力して下さい。"
    Private Const ERROR_CORRECT_TIME As Integer = 3
    Private Const ERROR_CORRECT_TIME_MESSAGE As String = "時間を正しく入力して下さい。"

    '曜日配列
    Private dayArray() As String = {"日", "月", "火", "水", "木", "金", "土"}

    'セルエンターイベント制御用
    Private canCellEnter As Boolean = False

    '全体dgv,連絡事項dgvの文字数制限用
    Private Const ZENREN_LIMIT_LENGTHBYTE As Integer = 96

    '各ハウスdgvの文字数制限用
    Private Const HOUSE_LIMIT_LENGTHBYTE As Integer = 24

    '天気配列
    Private weatherArray() As String = {"晴れ", "雨", "曇り", "晴れ/曇り", "曇り/雨", "雪"}

    '外出内容配列
    Private gaisyutuArray() As String = {"通院", "買物", "通院/買物", "通院/買物/他", "ﾃﾞｲｻｰﾋﾞｽ", "他"}

    'ハウス名配列
    Private houseNameArray() As String = {"sakura", "suisen", "ayame", "huji", "ajisai", "nadesiko", "botan", "himawari", "hamanasu", "yuri", "yaguruma", "kikyo"}

    'ハウス名番号対応
    Private houseNumberDictionary As New Dictionary(Of Integer, String) From {{1, "sakura"}, {2, "suisen"}, {3, "ayame"}, {4, "huji"}, {5, "ajisai"}, {6, "nadesiko"}, {7, "botan"}, {8, "himawari"}, {9, "hamanasu"}, {10, "yuri"}, {11, "yaguruma"}, {12, "kikyo"}}

    'ハウス名（かな）番号対応
    Private houseKanaNumberDictionary As New Dictionary(Of Integer, String) From {{1, "さくら"}, {2, "すいせん"}, {3, "あやめ"}, {4, "ふじ"}, {5, "あじさい"}, {6, "なでしこ"}, {7, "ぼたん"}, {8, "ひまわり"}, {9, "はまなす"}, {10, "ゆり"}, {11, "やぐるま"}, {12, "ききょう"}}

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ''' <summary>
    ''' keyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ハウス日誌_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub ハウス日誌_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sealBoxフォルダ存在チェック
        If Not System.IO.Directory.Exists(TopForm.sealBoxDirPath) Then
            MsgBox(TopForm.sealBoxDirPath & "が存在しません。iniファイルにsealBoxの正しいパスを設定して下さい。")
            Me.Close()
            Exit Sub
        End If

        'Journalデータベース存在チェック
        If Not System.IO.File.Exists(TopForm.dbJournalFilePath) Then
            MsgBox(TopForm.dbJournalFilePath & "が存在しません。iniファイルのDB2Dirに正しいパスを設定して下さい。")
            Me.Close()
            Exit Sub
        End If

        'dgv初期設定
        initDgv()

        'コンボボックス初期設定
        initComboBox()

        '現在日付をセット
        YmdBox.setADStr(Today.ToString("yyyy/MM/dd"))
    End Sub

    ''' <summary>
    ''' コンボボックス初期設定
    ''' </summary>
    Private Sub initComboBox()
        '天気コンボボックス
        weatherBox.Items.AddRange(weatherArray)

        '外出コンボボックス
        For Each name As String In houseNameArray
            CType(Controls(name & "Cbo"), ComboBox).Items.AddRange(gaisyutuArray)
        Next

    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    Private Sub initDgv()

        '全体dgvと連絡事項dgv
        For Each dgv As DataGridView In {dgvZen, dgvRen}
            With dgv
                Util.EnableDoubleBuffering(dgv)
                .AllowUserToAddRows = False '行追加禁止
                .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
                .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
                .AllowUserToDeleteRows = False '行削除禁止
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'クリック時に行選択
                .MultiSelect = False
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .ColumnHeadersVisible = False
                .RowHeadersVisible = False
                .RowTemplate.Height = 15
                .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                .ShowCellToolTips = False
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .BorderStyle = BorderStyle.None

                '空行追加
                Dim dt As New DataTable()
                dt.Columns.Add("Text", Type.GetType("System.String"))
                For i = 0 To 3
                    Dim row As DataRow = dt.NewRow()
                    row(0) = ""
                    dt.Rows.Add(row)
                Next
                .DataSource = dt

                '幅設定等
                With .Columns("Text")
                    .Width = 542
                End With
            End With
        Next

        'さくらdgv～ききょうdgv
        For Each dgv As DataGridView In {dgvSakura, dgvSuisen, dgvAyame, dgvHuji, dgvAjisai, dgvNadesiko, dgvBotan, dgvHimawari, dgvHamanasu, dgvYuri, dgvYaguruma, dgvKikyo}
            With dgv
                Util.EnableDoubleBuffering(dgv)
                .AllowUserToAddRows = False '行追加禁止
                .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
                .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
                .AllowUserToDeleteRows = False '行削除禁止
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'クリック時に行選択
                .MultiSelect = False
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .ColumnHeadersVisible = False
                .RowHeadersVisible = False
                .RowTemplate.Height = 15
                .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                .ShowCellToolTips = False
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .BorderStyle = BorderStyle.None

                '空行追加
                Dim dt As New DataTable()
                dt.Columns.Add("Text", Type.GetType("System.String"))
                For i = 0 To 6
                    Dim row As DataRow = dt.NewRow()
                    row(0) = ""
                    dt.Rows.Add(row)
                Next
                .DataSource = dt

                '幅設定等
                With .Columns("Text")
                    .Width = 153
                End With
            End With
        Next

        'セルエンターフラグ更新
        canCellEnter = True
    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    Private Sub clearInputContent()
        '天気
        weatherBox.Text = ""

        '印影
        sign1Box.ImageLocation = ""
        sign7Box.ImageLocation = ""
        sign8Box.ImageLocation = ""
        sign9Box.ImageLocation = ""

        '全体dgv,連絡事項dgv内容クリア
        For Each dgv As DataGridView In {dgvZen, dgvRen}
            For Each row As DataGridViewRow In dgv.Rows
                row.Cells.Item(0).Value = ""
            Next
        Next

        '各ハウス内容クリア
        For Each hn As String In houseNameArray
            DirectCast(Controls(hn & "Chk1"), CheckBox).Checked = False '入浴チェック
            DirectCast(Controls(hn & "Chk2"), CheckBox).Checked = False '外泊チェック
            DirectCast(Controls(hn & "Chk3"), CheckBox).Checked = False '入院チェック
            DirectCast(Controls(hn & "Chk4"), CheckBox).Checked = False '外出チェック
            DirectCast(Controls(hn & "Cbo"), ComboBox).Text = "" '外出ボックス
            DirectCast(Controls(hn & "FrmH"), TextBox).Text = "" 'From時
            DirectCast(Controls(hn & "FrmM"), TextBox).Text = "" 'From分
            DirectCast(Controls(hn & "ToH"), TextBox).Text = "" 'To時
            DirectCast(Controls(hn & "ToM"), TextBox).Text = "" 'To分
            'dgv内容クリア
            Dim dgv As DataGridView = DirectCast(Controls("dgv" & hn), DataGridView)
            For Each row As DataGridViewRow In dgv.Rows
                row.Cells.Item(0).Value = ""
            Next
        Next
    End Sub

    ''' <summary>
    ''' ハウス日誌データ表示
    ''' </summary>
    Private Sub displayHouseData()
        '入力内容クリア
        clearInputContent()

        'データ取得
        Dim ymd As String = YmdBox.getADStr() '日付
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from House where Ymd='" & ymd & "' order by Num"
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.RecordCount <= 0 Then
            '居室登録データから氏名取得、表示
            rs.Close()
            sql = "select Num, Nam from Room order by Num"
            rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            While Not rs.EOF
                Dim houseNum As Integer = rs.Fields("Num").Value + 1
                Dim houseName As String = houseNumberDictionary((houseNum))
                DirectCast(Controls(houseName & "Nam"), Label).Text = Util.checkDBNullValue(rs.Fields("Nam").Value)
                rs.MoveNext()
            End While
            rs.Close()
            cnn.Close()
        Else
            While Not rs.EOF
                Dim houseNum As Integer = rs.Fields("Num").Value
                If houseNum = 1 Then
                    '天気
                    weatherBox.Text = Util.checkDBNullValue(rs.Fields("Tenki").Value)

                    '全体dgv,連絡事項dgvデータ表示
                    For i As Integer = 1 To 4
                        dgvZen("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("Zen" & i).Value)
                        dgvRen("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("Ren" & i).Value)
                    Next

                    '印影部分
                    Dim sign1SealPath As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign1").Value) & ".wmf"
                    Dim sign7SealPath As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign7").Value) & ".wmf"
                    Dim sign8SealPath As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign8").Value) & ".wmf"
                    Dim sign9SealPath As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign9").Value) & ".wmf"
                    If System.IO.File.Exists(sign1SealPath) Then
                        sign1Box.ImageLocation = sign1SealPath
                    End If
                    If System.IO.File.Exists(sign7SealPath) Then
                        sign7Box.ImageLocation = sign7SealPath
                    End If
                    If System.IO.File.Exists(sign8SealPath) Then
                        sign8Box.ImageLocation = sign8SealPath
                    End If
                    If System.IO.File.Exists(sign9SealPath) Then
                        sign9Box.ImageLocation = sign9SealPath
                    End If

                End If

                '対象のハウス名
                Dim houseName As String = houseNumberDictionary((houseNum))

                'データ表示
                DirectCast(Controls(houseName & "Nam"), Label).Text = Util.checkDBNullValue(rs.Fields("Nam").Value) '氏名ラベル
                DirectCast(Controls(houseName & "Chk1"), CheckBox).Checked = If(rs.Fields("Chk1").Value = 1, True, False) '入浴チェック
                DirectCast(Controls(houseName & "Chk2"), CheckBox).Checked = If(rs.Fields("Chk2").Value = 1, True, False) '外泊チェック
                DirectCast(Controls(houseName & "Chk3"), CheckBox).Checked = If(rs.Fields("Chk3").Value = 1, True, False) '入院チェック
                DirectCast(Controls(houseName & "Chk4"), CheckBox).Checked = If(rs.Fields("Chk4").Value = 1, True, False) '外出チェック
                DirectCast(Controls(houseName & "Cbo"), ComboBox).Text = Util.checkDBNullValue(rs.Fields("Cbo").Value) '外出ボックス
                DirectCast(Controls(houseName & "FrmH"), TextBox).Text = Util.checkDBNullValue(rs.Fields("FrmH").Value) 'From時
                DirectCast(Controls(houseName & "FrmM"), TextBox).Text = Util.checkDBNullValue(rs.Fields("FrmM").Value) 'From分
                DirectCast(Controls(houseName & "ToH"), TextBox).Text = Util.checkDBNullValue(rs.Fields("ToH").Value) 'To時
                DirectCast(Controls(houseName & "ToM"), TextBox).Text = Util.checkDBNullValue(rs.Fields("ToM").Value) 'To分
                Dim dgv As DataGridView = DirectCast(Controls("dgv" & houseName), DataGridView)
                For i As Integer = 1 To 7 'dgvテキスト
                    dgv("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("Txt" & i).Value)
                Next

                rs.MoveNext()
            End While
            rs.Close()
            cnn.Close()
        End If
    End Sub

    ''' <summary>
    ''' セルエンターイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvZen.CellEnter, dgvRen.CellEnter, dgvSakura.CellEnter, dgvSuisen.CellEnter, dgvAyame.CellEnter, dgvHuji.CellEnter, dgvAjisai.CellEnter, dgvNadesiko.CellEnter, dgvBotan.CellEnter, dgvHimawari.CellEnter, dgvHamanasu.CellEnter, dgvYuri.CellEnter, dgvYaguruma.CellEnter, dgvKikyo.CellEnter
        If canCellEnter Then
            Dim dgv As DataGridView = CType(sender, DataGridView)
            dgv.BeginEdit(False)
        End If
    End Sub

    ''' <summary>
    ''' 日付ボックス値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub YmdBox_YmdTextChange(sender As Object, e As EventArgs) Handles YmdBox.YmdTextChange
        displayHouseData()
    End Sub

    ''' <summary>
    ''' 全体dgv,連絡事項dgvのEditingControlShowingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvZenRen_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvZen.EditingControlShowing, dgvRen.EditingControlShowing
        Dim editTextBox As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)

        'イベントハンドラを削除、追加
        RemoveHandler editTextBox.KeyPress, AddressOf dgvZenRenTextBox_KeyPress
        AddHandler editTextBox.KeyPress, AddressOf dgvZenRenTextBox_KeyPress
    End Sub

    ''' <summary>
    ''' 各ハウスdgvのEditingControlShowingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvHouse_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvSakura.EditingControlShowing, dgvSuisen.EditingControlShowing, dgvAyame.EditingControlShowing, dgvHuji.EditingControlShowing, dgvAjisai.EditingControlShowing, dgvNadesiko.EditingControlShowing, dgvBotan.EditingControlShowing, dgvHimawari.EditingControlShowing, dgvHamanasu.EditingControlShowing, dgvYuri.EditingControlShowing, dgvYaguruma.EditingControlShowing, dgvKikyo.EditingControlShowing
        Dim editTextBox As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)

        'イベントハンドラを削除、追加
        RemoveHandler editTextBox.KeyPress, AddressOf dgvHouseTextBox_KeyPress
        AddHandler editTextBox.KeyPress, AddressOf dgvHouseTextBox_KeyPress
    End Sub

    ''' <summary>
    ''' 全体dgv,連絡事項dgv用のテキストボックスKeyPressイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvZenRenTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim text As String = CType(sender, DataGridViewTextBoxEditingControl).Text
        Dim lengthByte As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(text)
        Dim limitLengthByte As Integer = ZENREN_LIMIT_LENGTHBYTE

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
    ''' 各ハウスdgv用のテキストボックスKeyPressイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvHouseTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim text As String = CType(sender, DataGridViewTextBoxEditingControl).Text
        Dim lengthByte As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(text)
        Dim limitLengthByte As Integer = HOUSE_LIMIT_LENGTHBYTE

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
    ''' 時間テキスト入力チェック
    ''' </summary>
    ''' <param name="inputTextBox"></param>
    ''' <param name="boxType"></param>
    ''' <returns></returns>
    Private Function checkInputTime(inputTextBox As TextBox, boxType As String) As Integer
        Dim result As Integer = -1 'エラー初期値
        Dim inputText As String = inputTextBox.Text '入力テキスト
        If inputText = "" Then
            result = 0
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(inputText, "^\d+$") Then
            result = ERROR_HALF_NUMBER
        ElseIf boxType = "H" AndAlso CInt(inputText) >= 24 Then
            result = ERROR_24HOUR
        ElseIf boxType = "M" AndAlso CInt(inputText) >= 60 Then
            result = ERROR_CORRECT_TIME
        Else
            result = 0
        End If

        If result <> 0 Then
            inputTextBox.Focus()
        End If

        Return result
    End Function

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
        '入力値チェック
        For i As Integer = 1 To 12
            Dim houseName As String = houseNumberDictionary(i)
            For Each boxName As String In {"FrmH", "FrmM", "ToH", "ToM"}
                Dim tb As TextBox = CType(Controls(houseName & boxName), TextBox)
                Dim boxType As String = boxName.Substring(boxName.Length - 1, 1) 'H or M
                Dim result As Integer = checkInputTime(tb, boxType)
                If result = ERROR_HALF_NUMBER Then
                    MsgBox(ERROR_HALF_NUMBER_MESSAGE, MsgBoxStyle.Exclamation)
                    Return
                ElseIf result = ERROR_24HOUR Then
                    MsgBox(ERROR_24HOUR_MESSAGE, MsgBoxStyle.Exclamation)
                    Return
                ElseIf result = ERROR_CORRECT_TIME Then
                    MsgBox(ERROR_CORRECT_TIME_MESSAGE, MsgBoxStyle.Exclamation)
                    Return
                End If
            Next
        Next

        '既存データ削除
        Dim ymd As String = YmdBox.getADStr() '日付
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Sien)
        Dim cmd As New ADODB.Command()
        cmd.ActiveConnection = cnn
        cmd.CommandText = "delete from House where Ymd='" & ymd & "'"
        cmd.Execute()

        '登録
        Dim weather As String = weatherBox.Text '天気
        Dim zen1 As String = dgvZen("Text", 0).Value '全体1行目
        Dim zen2 As String = dgvZen("Text", 1).Value '全体2行目
        Dim zen3 As String = dgvZen("Text", 2).Value '全体3行目
        Dim zen4 As String = dgvZen("Text", 3).Value '全体4行目
        Dim ren1 As String = dgvRen("Text", 0).Value '連絡事項1行目
        Dim ren2 As String = dgvRen("Text", 1).Value '連絡事項2行目
        Dim ren3 As String = dgvRen("Text", 2).Value '連絡事項3行目
        Dim ren4 As String = dgvRen("Text", 3).Value '連絡事項4行目
        Dim sign1 As String = System.IO.Path.GetFileNameWithoutExtension(sign1Box.ImageLocation) '施設長印影
        Dim sign7 As String = System.IO.Path.GetFileNameWithoutExtension(sign7Box.ImageLocation) '援助員印影
        Dim sign8 As String = System.IO.Path.GetFileNameWithoutExtension(sign8Box.ImageLocation) '宿直印影
        Dim sign9 As String = System.IO.Path.GetFileNameWithoutExtension(sign9Box.ImageLocation) '合議印影
        'Num=1の登録(天気、印影、全体、連絡事項と【さくら】の入力データ登録)
        Dim rs As New ADODB.Recordset
        rs.Open("House", cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields("Tenki").Value = weather
        rs.Fields("Sign1").Value = sign1
        rs.Fields("Sign7").Value = sign7
        rs.Fields("Sign8").Value = sign8
        rs.Fields("Sign9").Value = sign9
        rs.Fields("Zen1").Value = zen1
        rs.Fields("Zen2").Value = zen2
        rs.Fields("Zen3").Value = zen3
        rs.Fields("Zen4").Value = zen4
        rs.Fields("Ren1").Value = ren1
        rs.Fields("Ren2").Value = ren2
        rs.Fields("Ren3").Value = ren3
        rs.Fields("Ren4").Value = ren4
        rs.Fields("Num").Value = 1
        rs.Fields("Ymd").Value = ymd
        rs.Fields("Nam").Value = sakuraNam.Text
        rs.Fields("Chk1").Value = If(sakuraChk1.Checked, 1, 0)
        rs.Fields("Chk2").Value = If(sakuraChk2.Checked, 1, 0)
        rs.Fields("Chk3").Value = If(sakuraChk3.Checked, 1, 0)
        rs.Fields("Chk4").Value = If(sakuraChk4.Checked, 1, 0)
        rs.Fields("Cbo").Value = sakuraCbo.Text
        rs.Fields("FrmH").Value = sakuraFrmH.Text
        rs.Fields("FrmM").Value = sakuraFrmM.Text
        rs.Fields("ToH").Value = sakuraToH.Text
        rs.Fields("ToM").Value = sakuraToM.Text
        For i As Integer = 1 To 7
            rs.Fields("Txt" & i).Value = dgvSakura("Text", i - 1).Value.ToString()
        Next
        'Num>=2以降の登録(【すいせん】～【ききょう】までの入力データ登録)
        For i As Integer = 2 To 12
            Dim houseName As String = houseNumberDictionary(i)
            rs.AddNew()
            rs.Fields("Num").Value = i
            rs.Fields("Ymd").Value = ymd
            rs.Fields("Nam").Value = CType(Controls(houseName & "Nam"), Label).Text
            rs.Fields("Chk1").Value = If(CType(Controls(houseName & "Chk1"), CheckBox).Checked, 1, 0)
            rs.Fields("Chk2").Value = If(CType(Controls(houseName & "Chk2"), CheckBox).Checked, 1, 0)
            rs.Fields("Chk3").Value = If(CType(Controls(houseName & "Chk3"), CheckBox).Checked, 1, 0)
            rs.Fields("Chk4").Value = If(CType(Controls(houseName & "Chk4"), CheckBox).Checked, 1, 0)
            rs.Fields("Cbo").Value = CType(Controls(houseName & "Cbo"), ComboBox).Text
            rs.Fields("FrmH").Value = CType(Controls(houseName & "FrmH"), TextBox).Text
            rs.Fields("FrmM").Value = CType(Controls(houseName & "FrmM"), TextBox).Text
            rs.Fields("ToH").Value = CType(Controls(houseName & "ToH"), TextBox).Text
            rs.Fields("ToM").Value = CType(Controls(houseName & "ToM"), TextBox).Text
            Dim dgv As DataGridView = CType(Controls("dgv" & houseName), DataGridView)
            For j As Integer = 1 To 7
                rs.Fields("Txt" & j).Value = dgv("Text", j - 1).Value.ToString()
            Next
        Next
        rs.Update()
        rs.Close()
        cnn.Close()
    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("対象日の日誌を削除しますか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim ymd As String = YmdBox.getADStr() '日付
            Dim cnn As New ADODB.Connection
            cnn.Open(TopForm.DB_Sien)
            Dim cmd As New ADODB.Command()
            cmd.ActiveConnection = cnn
            cmd.CommandText = "delete from House where Ymd='" & ymd & "'"
            cmd.Execute()
            cnn.Close()

            '再表示
            displayHouseData()
        End If
    End Sub

    ''' <summary>
    ''' 印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        '印刷範囲設定
        Dim sql As String
        Dim fromYmd As String '開始日
        Dim toYmd As String '終了日
        If rbtnYm.Checked Then
            'ラジオボタン年月にチェック有
            Dim ym As String = YmdBox.getADStr().Substring(0, 7)
            Dim lastDay As Integer = DateTime.DaysInMonth(CInt(ym.Substring(0, 4)), CInt(ym.Substring(5, 2)))
            fromYmd = ym & "/01"
            toYmd = ym & lastDay
            sql = "select * from House where ('" & fromYmd & "' <= Ymd And Ymd <= '" & toYmd & "') order by Ymd, Num"
        Else
            'ラジオボタン年月日にチェック有
            fromYmd = YmdBox.getADStr()
            toYmd = ""
            sql = "select * from House where Ymd='" & fromYmd & "' order by Num"
        End If

        '印刷対象データ取得
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.RecordCount <= 0 Then
            MsgBox("該当がありません。", MsgBoxStyle.Exclamation)
            rs.Close()
            cnn.Close()
            Return
        End If

        '管理者パスワードフォーム表示
        Dim passForm As passwordForm = New passwordForm(TopForm.iniFilePath, 3)
        If passForm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return
        End If

        '必要ページ数
        Dim pageCount As Integer = 0
        Dim ymdTemp As String = ""
        Dim ymd As String = ""
        While Not rs.EOF
            ymd = Util.checkDBNullValue(rs.Fields("Ymd").Value)
            If ymd <> ymdTemp Then
                pageCount += 1
                ymdTemp = ymd
            End If
            rs.MoveNext()
        End While
        rs.MoveFirst()

        'エクセル準備
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("1改")

        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '必要ページ数コピペ
        Const PAGE_RANGE As Integer = 110
        For i As Integer = 0 To pageCount - 2
            oSheet.rows("1:" & PAGE_RANGE).copy(oSheet.Range("A" & (1 + PAGE_RANGE * (i + 1))))
            oSheet.HpageBreaks.add(oSheet.Range("A" & (1 + PAGE_RANGE * (i + 1)))) '改ページ
        Next

        'データ作成、書き込み
        Dim pageDataArray(100, 39) As String
        Dim xlShapes As Excel.Shapes = DirectCast(oSheet.Shapes, Excel.Shapes)
        Dim currentPage As Integer = 0
        ymdTemp = Util.checkDBNullValue(rs.Fields("Ymd").Value)
        ymd = Util.checkDBNullValue(rs.Fields("Ymd").Value)
        While Not rs.EOF
            ymd = Util.checkDBNullValue(rs.Fields("Ymd").Value)
            If ymd <> ymdTemp Then
                '現在のページにデータ貼り付け
                oSheet.Range("C" & (9 + PAGE_RANGE * currentPage), "AP" & (109 + PAGE_RANGE * currentPage)).Value = pageDataArray

                '配列クリア
                Array.Clear(pageDataArray, 0, pageDataArray.Length)

                currentPage += 1
                ymdTemp = ymd
            End If
            Dim num As Integer = rs.Fields("Num").Value
            If num = 1 Then
                '日付、天気
                pageDataArray(0, 0) = formatDateStr(ymd)
                pageDataArray(0, 23) = "天気"
                pageDataArray(0, 30) = "/"
                pageDataArray(0, 32) = Util.checkDBNullValue(rs.Fields("Tenki").Value)

                '印影部分
                Dim sign1Path As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign1").Value) & ".wmf"
                Dim sign7Path As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign7").Value) & ".wmf"
                Dim sign8Path As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign8").Value) & ".wmf"
                Dim sign9Path As String = TopForm.sealBoxDirPath & "\" & Util.checkDBNullValue(rs.Fields("Sign9").Value) & ".wmf"
                If System.IO.File.Exists(sign1Path) Then
                    Dim cell As Excel.Range = DirectCast(oSheet.Cells(4 + (PAGE_RANGE * currentPage), "AM"), Excel.Range)
                    xlShapes.AddPicture(sign1Path, False, True, cell.Left, cell.Top, 30, 30)
                End If
                If System.IO.File.Exists(sign7Path) Then
                    Dim cell As Excel.Range = DirectCast(oSheet.Cells(4 + (PAGE_RANGE * currentPage), "AR"), Excel.Range)
                    xlShapes.AddPicture(sign7Path, False, True, cell.Left, cell.Top, 30, 30)
                End If
                If System.IO.File.Exists(sign8Path) Then
                    Dim cell As Excel.Range = DirectCast(oSheet.Cells(4 + (PAGE_RANGE * currentPage), "AT"), Excel.Range)
                    xlShapes.AddPicture(sign8Path, False, True, cell.Left, cell.Top, 30, 30)
                End If
                If System.IO.File.Exists(sign9Path) Then
                    Dim cell As Excel.Range = DirectCast(oSheet.Cells(4 + (PAGE_RANGE * currentPage), "AV"), Excel.Range)
                    xlShapes.AddPicture(sign9Path, False, True, cell.Left, cell.Top, 30, 30)
                End If

                '全体、連絡事項部分
                For i As Integer = 1 To 4
                    pageDataArray(i - 1 + 3, 0) = Util.checkDBNullValue(rs.Fields("Zen" & i).Value)
                    pageDataArray(i - 1 + 97, 0) = Util.checkDBNullValue(rs.Fields("Ren" & i).Value)
                Next

                '【さくら】部分
                pageDataArray(8, 2) = "【さくら】"
                pageDataArray(9, 1) = Util.checkDBNullValue(rs.Fields("Nam").Value)
                pageDataArray(12, 2) = If(rs.Fields("Chk1").Value = 1, "✔", "")
                pageDataArray(11, 4) = "入浴"
                pageDataArray(12, 6) = If(rs.Fields("Chk2").Value = 1, "✔", "")
                pageDataArray(11, 9) = "外泊"
                pageDataArray(12, 12) = If(rs.Fields("Chk3").Value = 1, "✔", "")
                pageDataArray(11, 14) = "入院"
                pageDataArray(15, 2) = If(rs.Fields("Chk4").Value = 1, "✔", "")
                pageDataArray(14, 4) = "外出"
                pageDataArray(14, 5) = "〔"
                pageDataArray(14, 7) = Util.checkDBNullValue(rs.Fields("Cbo").Value)
                pageDataArray(14, 15) = "〕"
                pageDataArray(17, 5) = "〔"
                pageDataArray(17, 7) = Util.checkDBNullValue(rs.Fields("FrmH").Value) & ":" & Util.checkDBNullValue(rs.Fields("FrmM").Value)
                pageDataArray(17, 10) = "～"
                pageDataArray(17, 12) = Util.checkDBNullValue(rs.Fields("ToH").Value) & ":" & Util.checkDBNullValue(rs.Fields("ToM").Value)
                pageDataArray(17, 15) = "〕"
                pageDataArray(8, 17) = Util.checkDBNullValue(rs.Fields("Txt1").Value)
                pageDataArray(9, 17) = Util.checkDBNullValue(rs.Fields("Txt2").Value)
                pageDataArray(10, 17) = Util.checkDBNullValue(rs.Fields("Txt3").Value)
                pageDataArray(11, 17) = Util.checkDBNullValue(rs.Fields("Txt4").Value)
                pageDataArray(14, 17) = Util.checkDBNullValue(rs.Fields("Txt5").Value)
                pageDataArray(17, 17) = Util.checkDBNullValue(rs.Fields("Txt6").Value)
                pageDataArray(20, 17) = Util.checkDBNullValue(rs.Fields("Txt7").Value)
            ElseIf 2 <= num AndAlso num <= 6 Then 'すいせん～なでしこ
                Dim plusRowNum As Integer = 15 * (num - 1)
                pageDataArray(8 + plusRowNum, 2) = "【" & houseKanaNumberDictionary(num) & "】"
                pageDataArray(9 + plusRowNum, 1) = Util.checkDBNullValue(rs.Fields("Nam").Value)
                pageDataArray(12 + plusRowNum, 2) = If(rs.Fields("Chk1").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 4) = "入浴"
                pageDataArray(12 + plusRowNum, 6) = If(rs.Fields("Chk2").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 9) = "外泊"
                pageDataArray(12 + plusRowNum, 12) = If(rs.Fields("Chk3").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 14) = "入院"
                pageDataArray(15 + plusRowNum, 2) = If(rs.Fields("Chk4").Value = 1, "✔", "")
                pageDataArray(14 + plusRowNum, 4) = "外出"
                pageDataArray(14 + plusRowNum, 5) = "〔"
                pageDataArray(14 + plusRowNum, 7) = Util.checkDBNullValue(rs.Fields("Cbo").Value)
                pageDataArray(14 + plusRowNum, 15) = "〕"
                pageDataArray(17 + plusRowNum, 5) = "〔"
                pageDataArray(17 + plusRowNum, 7) = Util.checkDBNullValue(rs.Fields("FrmH").Value) & ":" & Util.checkDBNullValue(rs.Fields("FrmM").Value)
                pageDataArray(17 + plusRowNum, 10) = "～"
                pageDataArray(17 + plusRowNum, 12) = Util.checkDBNullValue(rs.Fields("ToH").Value) & ":" & Util.checkDBNullValue(rs.Fields("ToM").Value)
                pageDataArray(17 + plusRowNum, 15) = "〕"
                pageDataArray(8 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt1").Value)
                pageDataArray(9 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt2").Value)
                pageDataArray(10 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt3").Value)
                pageDataArray(11 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt4").Value)
                pageDataArray(14 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt5").Value)
                pageDataArray(17 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt6").Value)
                pageDataArray(20 + plusRowNum, 17) = Util.checkDBNullValue(rs.Fields("Txt7").Value)
            ElseIf 7 <= num AndAlso num <= 12 Then 'ぼたん～ききょう
                Dim plusRowNum As Integer = 15 * (num - 7)
                pageDataArray(8 + plusRowNum, 20) = "【" & houseKanaNumberDictionary(num) & "】"
                pageDataArray(9 + plusRowNum, 19) = Util.checkDBNullValue(rs.Fields("Nam").Value)
                pageDataArray(12 + plusRowNum, 20) = If(rs.Fields("Chk1").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 22) = "入浴"
                pageDataArray(12 + plusRowNum, 24) = If(rs.Fields("Chk2").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 27) = "外泊"
                pageDataArray(12 + plusRowNum, 32) = If(rs.Fields("Chk3").Value = 1, "✔", "")
                pageDataArray(11 + plusRowNum, 34) = "入院"
                pageDataArray(15 + plusRowNum, 20) = If(rs.Fields("Chk4").Value = 1, "✔", "")
                pageDataArray(14 + plusRowNum, 22) = "外出"
                pageDataArray(14 + plusRowNum, 23) = "〔"
                pageDataArray(14 + plusRowNum, 25) = Util.checkDBNullValue(rs.Fields("Cbo").Value)
                pageDataArray(14 + plusRowNum, 37) = "〕"
                pageDataArray(17 + plusRowNum, 23) = "〔"
                pageDataArray(17 + plusRowNum, 25) = Util.checkDBNullValue(rs.Fields("FrmH").Value) & ":" & Util.checkDBNullValue(rs.Fields("FrmM").Value)
                pageDataArray(17 + plusRowNum, 30) = "～"
                pageDataArray(17 + plusRowNum, 32) = Util.checkDBNullValue(rs.Fields("ToH").Value) & ":" & Util.checkDBNullValue(rs.Fields("ToM").Value)
                pageDataArray(17 + plusRowNum, 37) = "〕"
                pageDataArray(8 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt1").Value)
                pageDataArray(9 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt2").Value)
                pageDataArray(10 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt3").Value)
                pageDataArray(11 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt4").Value)
                pageDataArray(14 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt5").Value)
                pageDataArray(17 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt6").Value)
                pageDataArray(20 + plusRowNum, 39) = Util.checkDBNullValue(rs.Fields("Txt7").Value)
            End If
            rs.MoveNext()
        End While
        '現在のページにデータ貼り付け
        oSheet.Range("C" & (9 + PAGE_RANGE * currentPage), "AP" & (109 + PAGE_RANGE * currentPage)).Value = pageDataArray

        rs.Close()
        cnn.Close()

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If TopForm.rbtnPrintout.Checked = True Then
            oSheet.printOut()
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
    ''' 押ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSealSet_Click(sender As Object, e As EventArgs) Handles btnSealSet.Click
        If btnSealSet.Text = "押" Then
            If TopForm.className = "" AndAlso TopForm.sealFileName = "" Then
                Dim passForm As 印鑑パスワード = New 印鑑パスワード(TopForm.DB_Journal)
                If passForm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    Return
                Else
                    TopForm.className = passForm.getClassName()
                    TopForm.sealFileName = passForm.getSealFileName()
                End If
            End If

            Dim sealNum As Integer = If(IsNumeric(TopForm.className.Substring(0, 1)), CInt(TopForm.className.Substring(0, 1)), -1)
            If sealNum = 1 OrElse sealNum = 7 OrElse sealNum = 8 OrElse sealNum = 9 Then
                Dim sealFilePath As String = TopForm.sealBoxDirPath & "\" & TopForm.sealFileName & ".wmf"
                If System.IO.File.Exists(sealFilePath) Then
                    CType(Controls("sign" & sealNum & "Box"), PictureBox).ImageLocation = sealFilePath
                End If
            End If
            btnSealSet.Text = "消"
            btnSealSet.ForeColor = Color.Black
        ElseIf btnSealSet.Text = "消" Then
            Dim sealNum As Integer = If(IsNumeric(TopForm.className.Substring(0, 1)), CInt(TopForm.className.Substring(0, 1)), -1)
            If sealNum = 1 OrElse sealNum = 7 OrElse sealNum = 8 OrElse sealNum = 9 Then
                CType(Controls("sign" & sealNum & "Box"), PictureBox).ImageLocation = ""
            End If
            btnSealSet.Text = "押"
            btnSealSet.ForeColor = Color.Red
        End If
    End Sub
End Class