Public Class 居室登録

    'フォーカス制御用
    Private displayedFlg As Boolean = False

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 居室登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'コンボボックス初期設定
        initTextBox()

        '居室データ表示
        displayRoomData()

    End Sub

    ''' <summary>
    ''' コンボボックス初期設定
    ''' </summary>
    Private Sub initTextBox()
        '設定する利用者名リスト取得
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Nam from UsrM order by Kana"
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim namList As New List(Of String)
        While Not rs.EOF
            namList.Add(Util.checkDBNullValue(rs.Fields("Nam").Value))
            rs.MoveNext()
        End While
        rs.Close()
        cnn.Close()

        '取得したリストを配列に
        Dim itemsArray() As String = namList.ToArray()

        '各ボックスへセット
        For i As Integer = 0 To 11
            Dim cb As ComboBox = CType(Controls("ComboBox" & i), ComboBox)
            cb.ImeMode = ImeMode.Hiragana
            cb.Items.AddRange(itemsArray)
        Next

    End Sub

    ''' <summary>
    ''' 居室データ表示
    ''' </summary>
    Private Sub displayRoomData()
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Nam from Room order by Num"
        cnn.Open(TopForm.DB_Sien)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim count As Integer = 0
        While Not rs.EOF
            CType(Controls("ComboBox" & count), ComboBox).Text = Util.checkDBNullValue(rs.Fields("Nam").Value)
            rs.MoveNext()
            count += 1
        End While
        rs.Close()
        cnn.Close()

        Me.ActiveControl = ComboBox11
    End Sub

    ''' <summary>
    ''' 更新ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '既存データ削除
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Sien)
        Dim cmd As New ADODB.Command()
        cmd.ActiveConnection = cn
        cmd.CommandText = "delete from Room"
        cmd.Execute()

        '登録
        Dim rs As New ADODB.Recordset()
        rs.Open("Room", cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        For i As Integer = 0 To 11
            rs.AddNew()
            rs.Fields("Num").Value = i
            rs.Fields("Nam").Value = CType(Controls("ComboBox" & i), ComboBox).Text
        Next
        rs.Update()
        rs.Close()
        cn.Close()

        MsgBox("更新しました。", MsgBoxStyle.Information)

    End Sub

    ''' <summary>
    ''' ききょうボックスフォーカスイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBox11_GotFocus(sender As Object, e As EventArgs) Handles ComboBox11.GotFocus
        '最初の一回だけ処理を行う
        If displayedFlg = False Then
            ComboBox11.SelectionStart = 0
            ComboBox11.SelectionLength = 0
            displayedFlg = True
        End If
    End Sub
End Class