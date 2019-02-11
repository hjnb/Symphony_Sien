Imports System.Text

Public Class ハウス日誌

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

        '全体dgv,連絡事項dgv内容クリア
        For Each dgv As DataGridView In {dgvZen, dgvRen}
            For Each row As DataGridViewRow In dgv.Rows
                row.Cells.Item(0).Value = ""
            Next
        Next

        '各ハウス内容クリア
        For Each hn As String In houseNameArray
            CType(Controls(hn & "Chk1"), CheckBox).Checked = False '入浴チェック
            CType(Controls(hn & "Chk2"), CheckBox).Checked = False '外泊チェック
            CType(Controls(hn & "Chk3"), CheckBox).Checked = False '入院チェック
            CType(Controls(hn & "Chk4"), CheckBox).Checked = False '外出チェック
            CType(Controls(hn & "Cbo"), ComboBox).Text = "" '外出ボックス
            CType(Controls(hn & "FrmH"), TextBox).Text = "" 'From時
            CType(Controls(hn & "FrmM"), TextBox).Text = "" 'From分
            CType(Controls(hn & "ToH"), TextBox).Text = "" 'To時
            CType(Controls(hn & "ToM"), TextBox).Text = "" 'To分
            'dgv内容クリア
            Dim dgv As DataGridView = CType(Controls("dgv" & hn), DataGridView)
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
                CType(Controls(houseName & "Nam"), Label).Text = Util.checkDBNullValue(rs.Fields("Nam").Value)
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
                    '
                    '

                End If

                '対象のハウス名
                Dim houseName As String = houseNumberDictionary((houseNum))

                'データ表示
                CType(Controls(houseName & "Nam"), Label).Text = Util.checkDBNullValue(rs.Fields("Nam").Value) '氏名ラベル
                CType(Controls(houseName & "Chk1"), CheckBox).Checked = If(rs.Fields("Chk1").Value = 1, True, False) '入浴チェック
                CType(Controls(houseName & "Chk2"), CheckBox).Checked = If(rs.Fields("Chk2").Value = 1, True, False) '外泊チェック
                CType(Controls(houseName & "Chk3"), CheckBox).Checked = If(rs.Fields("Chk3").Value = 1, True, False) '入院チェック
                CType(Controls(houseName & "Chk4"), CheckBox).Checked = If(rs.Fields("Chk4").Value = 1, True, False) '外出チェック
                CType(Controls(houseName & "Cbo"), ComboBox).Text = Util.checkDBNullValue(rs.Fields("Cbo").Value) '外出ボックス
                CType(Controls(houseName & "FrmH"), TextBox).Text = Util.checkDBNullValue(rs.Fields("FrmH").Value) 'From時
                CType(Controls(houseName & "FrmM"), TextBox).Text = Util.checkDBNullValue(rs.Fields("FrmM").Value) 'From分
                CType(Controls(houseName & "ToH"), TextBox).Text = Util.checkDBNullValue(rs.Fields("ToH").Value) 'To時
                CType(Controls(houseName & "ToM"), TextBox).Text = Util.checkDBNullValue(rs.Fields("ToM").Value) 'To分
                Dim dgv As DataGridView = CType(Controls("dgv" & houseName), DataGridView)
                For i As Integer = 1 To 7 'dgvテキスト
                    dgv("Text", i - 1).Value = Util.checkDBNullValue(rs.Fields("Txt" & i).Value)
                Next

                rs.MoveNext()
            End While
            rs.Close()
            cnn.Close()
        End If

        'フォーカス
        weatherBox.Focus()
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
End Class