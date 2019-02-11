Public Class TopForm
    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\Sien.mdb"
    Public DB_Sien As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    'エクセルのパス
    Public excelFilePass As String = My.Application.Info.DirectoryPath & "\Sien.xls"

    '.iniファイルのパス
    Public iniFilePath As String = My.Application.Info.DirectoryPath & "\Sien.ini"

    '画像パス
    Public imageFilePath As String = My.Application.Info.DirectoryPath & "\Sien.jpg"

    'SealBoxフォルダパス
    Public sealBoxDirPath As String = Util.getIniString("System", "SealBoxDir", iniFilePath)

    '印鑑パス通過後保持用　職制
    Public className As String

    '印鑑パス通過後保持用　印影ファイル名
    Public sealFileName As String

    '各フォーム
    Private houseDiaryForm As ハウス日誌
    Private residentRegistForm As 入居者登録
    Private roomRegistForm As 居室登録
    Private washForm As 洗濯関係

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'データベース、エクセル、構成ファイルの存在チェック
        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("データベースファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(excelFilePass) Then
            MsgBox("エクセルファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(iniFilePath) Then
            MsgBox("構成ファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(imageFilePath) Then
            MsgBox("画像ファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        '画面サイズ等
        Me.WindowState = FormWindowState.Maximized
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        '画像の配置処理
        topPicture.ImageLocation = imageFilePath

        '印刷ラジオボタンの初期設定
        initPrintState()
    End Sub

    ''' <summary>
    ''' ラジオボタン初期設定
    ''' </summary>
    Private Sub initPrintState()
        Dim state As String = Util.getIniString("System", "Printer", iniFilePath)
        If state = "Y" Then
            rbtnPrintout.Checked = True
        Else
            rbtnPreview.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' ﾌﾟﾚﾋﾞｭｰラジオボタン値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rbtnPreview_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPreview.CheckedChanged
        If rbtnPreview.Checked = True Then
            Util.putIniString("System", "Printer", "N", iniFilePath)
        End If
    End Sub

    ''' <summary>
    ''' 印刷ラジオボタン値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rbtnPrintout_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPrintout.CheckedChanged
        If rbtnPrintout.Checked = True Then
            Util.putIniString("System", "Printer", "Y", iniFilePath)
        End If
    End Sub

    ''' <summary>
    ''' トップ画像クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub topPicture_Click(sender As System.Object, e As System.EventArgs) Handles topPicture.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' ハウス日誌ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHouseDiary_Click(sender As Object, e As EventArgs) Handles btnHouseDiary.Click
        If IsNothing(houseDiaryForm) OrElse houseDiaryForm.IsDisposed Then
            houseDiaryForm = New ハウス日誌()
            houseDiaryForm.Owner = Me
            houseDiaryForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 入居者登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnResidentRegist_Click(sender As Object, e As EventArgs) Handles btnResidentRegist.Click
        If IsNothing(residentRegistForm) OrElse residentRegistForm.IsDisposed Then
            residentRegistForm = New 入居者登録()
            residentRegistForm.Owner = Me
            residentRegistForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 居室登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRoomRegist_Click(sender As Object, e As EventArgs) Handles btnRoomRegist.Click
        If IsNothing(roomRegistForm) OrElse roomRegistForm.IsDisposed Then
            roomRegistForm = New 居室登録()
            roomRegistForm.Owner = Me
            roomRegistForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 洗濯関係ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnWash_Click(sender As Object, e As EventArgs) Handles btnWash.Click
        If IsNothing(washForm) OrElse washForm.IsDisposed Then
            washForm = New 洗濯関係()
            washForm.Owner = Me
            washForm.Show()
        End If
    End Sub
End Class
