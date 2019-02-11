<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ハウス日誌
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
        Me.YmdBox = New ymdBox.ymdBox()
        Me.weatherBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.rbtnYmd = New System.Windows.Forms.RadioButton()
        Me.rbtnYm = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSealSet = New System.Windows.Forms.Button()
        Me.dgvZen = New System.Windows.Forms.DataGridView()
        Me.dgvRen = New System.Windows.Forms.DataGridView()
        Me.dgvSakura = New System.Windows.Forms.DataGridView()
        Me.dgvSuisen = New System.Windows.Forms.DataGridView()
        Me.dgvHuji = New System.Windows.Forms.DataGridView()
        Me.dgvAyame = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvHimawari = New System.Windows.Forms.DataGridView()
        Me.dgvBotan = New System.Windows.Forms.DataGridView()
        Me.dgvNadesiko = New System.Windows.Forms.DataGridView()
        Me.dgvAjisai = New System.Windows.Forms.DataGridView()
        Me.dgvKikyo = New System.Windows.Forms.DataGridView()
        Me.dgvYaguruma = New System.Windows.Forms.DataGridView()
        Me.dgvYuri = New System.Windows.Forms.DataGridView()
        Me.dgvHamanasu = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sakuraNam = New System.Windows.Forms.Label()
        Me.sakuraChk1 = New System.Windows.Forms.CheckBox()
        Me.sakuraChk2 = New System.Windows.Forms.CheckBox()
        Me.sakuraChk3 = New System.Windows.Forms.CheckBox()
        Me.sakuraChk4 = New System.Windows.Forms.CheckBox()
        Me.sakuraCbo = New System.Windows.Forms.ComboBox()
        Me.sakuraFrmH = New System.Windows.Forms.TextBox()
        Me.sakuraFrmM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.sakuraToM = New System.Windows.Forms.TextBox()
        Me.sakuraToH = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ajisaiToM = New System.Windows.Forms.TextBox()
        Me.ajisaiToH = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ajisaiFrmM = New System.Windows.Forms.TextBox()
        Me.ajisaiFrmH = New System.Windows.Forms.TextBox()
        Me.ajisaiCbo = New System.Windows.Forms.ComboBox()
        Me.ajisaiChk4 = New System.Windows.Forms.CheckBox()
        Me.ajisaiChk3 = New System.Windows.Forms.CheckBox()
        Me.ajisaiChk2 = New System.Windows.Forms.CheckBox()
        Me.ajisaiChk1 = New System.Windows.Forms.CheckBox()
        Me.ajisaiNam = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.hamanasuToM = New System.Windows.Forms.TextBox()
        Me.hamanasuToH = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.hamanasuFrmM = New System.Windows.Forms.TextBox()
        Me.hamanasuFrmH = New System.Windows.Forms.TextBox()
        Me.hamanasuCbo = New System.Windows.Forms.ComboBox()
        Me.hamanasuChk4 = New System.Windows.Forms.CheckBox()
        Me.hamanasuChk3 = New System.Windows.Forms.CheckBox()
        Me.hamanasuChk2 = New System.Windows.Forms.CheckBox()
        Me.hamanasuChk1 = New System.Windows.Forms.CheckBox()
        Me.hamanasuNam = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.suisenToM = New System.Windows.Forms.TextBox()
        Me.suisenToH = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.suisenFrmM = New System.Windows.Forms.TextBox()
        Me.suisenFrmH = New System.Windows.Forms.TextBox()
        Me.suisenCbo = New System.Windows.Forms.ComboBox()
        Me.suisenChk4 = New System.Windows.Forms.CheckBox()
        Me.suisenChk3 = New System.Windows.Forms.CheckBox()
        Me.suisenChk2 = New System.Windows.Forms.CheckBox()
        Me.suisenChk1 = New System.Windows.Forms.CheckBox()
        Me.suisenNam = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ayameToM = New System.Windows.Forms.TextBox()
        Me.ayameToH = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ayameFrmM = New System.Windows.Forms.TextBox()
        Me.ayameFrmH = New System.Windows.Forms.TextBox()
        Me.ayameCbo = New System.Windows.Forms.ComboBox()
        Me.ayameChk4 = New System.Windows.Forms.CheckBox()
        Me.ayameChk3 = New System.Windows.Forms.CheckBox()
        Me.ayameChk2 = New System.Windows.Forms.CheckBox()
        Me.ayameChk1 = New System.Windows.Forms.CheckBox()
        Me.ayameNam = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.hujiToM = New System.Windows.Forms.TextBox()
        Me.hujiToH = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.hujiFrmM = New System.Windows.Forms.TextBox()
        Me.hujiFrmH = New System.Windows.Forms.TextBox()
        Me.hujiCbo = New System.Windows.Forms.ComboBox()
        Me.hujiChk4 = New System.Windows.Forms.CheckBox()
        Me.hujiChk3 = New System.Windows.Forms.CheckBox()
        Me.hujiChk2 = New System.Windows.Forms.CheckBox()
        Me.hujiChk1 = New System.Windows.Forms.CheckBox()
        Me.hujiNam = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.nadesikoToM = New System.Windows.Forms.TextBox()
        Me.nadesikoToH = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.nadesikoFrmM = New System.Windows.Forms.TextBox()
        Me.nadesikoFrmH = New System.Windows.Forms.TextBox()
        Me.nadesikoCbo = New System.Windows.Forms.ComboBox()
        Me.nadesikoChk4 = New System.Windows.Forms.CheckBox()
        Me.nadesikoChk3 = New System.Windows.Forms.CheckBox()
        Me.nadesikoChk2 = New System.Windows.Forms.CheckBox()
        Me.nadesikoChk1 = New System.Windows.Forms.CheckBox()
        Me.nadesikoNam = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.botanToM = New System.Windows.Forms.TextBox()
        Me.botanToH = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.botanFrmM = New System.Windows.Forms.TextBox()
        Me.botanFrmH = New System.Windows.Forms.TextBox()
        Me.botanCbo = New System.Windows.Forms.ComboBox()
        Me.botanChk4 = New System.Windows.Forms.CheckBox()
        Me.botanChk3 = New System.Windows.Forms.CheckBox()
        Me.botanChk2 = New System.Windows.Forms.CheckBox()
        Me.botanChk1 = New System.Windows.Forms.CheckBox()
        Me.botanNam = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.himawariToM = New System.Windows.Forms.TextBox()
        Me.himawariToH = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.himawariFrmM = New System.Windows.Forms.TextBox()
        Me.himawariFrmH = New System.Windows.Forms.TextBox()
        Me.himawariCbo = New System.Windows.Forms.ComboBox()
        Me.himawariChk4 = New System.Windows.Forms.CheckBox()
        Me.himawariChk3 = New System.Windows.Forms.CheckBox()
        Me.himawariChk2 = New System.Windows.Forms.CheckBox()
        Me.himawariChk1 = New System.Windows.Forms.CheckBox()
        Me.himawariNam = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.yuriToM = New System.Windows.Forms.TextBox()
        Me.yuriToH = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.yuriFrmM = New System.Windows.Forms.TextBox()
        Me.yuriFrmH = New System.Windows.Forms.TextBox()
        Me.yuriCbo = New System.Windows.Forms.ComboBox()
        Me.yuriChk4 = New System.Windows.Forms.CheckBox()
        Me.yuriChk3 = New System.Windows.Forms.CheckBox()
        Me.yuriChk2 = New System.Windows.Forms.CheckBox()
        Me.yuriChk1 = New System.Windows.Forms.CheckBox()
        Me.yuriNam = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.yagurumaToM = New System.Windows.Forms.TextBox()
        Me.yagurumaToH = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.yagurumaFrmM = New System.Windows.Forms.TextBox()
        Me.yagurumaFrmH = New System.Windows.Forms.TextBox()
        Me.yagurumaCbo = New System.Windows.Forms.ComboBox()
        Me.yagurumaChk4 = New System.Windows.Forms.CheckBox()
        Me.yagurumaChk3 = New System.Windows.Forms.CheckBox()
        Me.yagurumaChk2 = New System.Windows.Forms.CheckBox()
        Me.yagurumaChk1 = New System.Windows.Forms.CheckBox()
        Me.yagurumaNam = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.kikyoToM = New System.Windows.Forms.TextBox()
        Me.kikyoToH = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.kikyoFrmM = New System.Windows.Forms.TextBox()
        Me.kikyoFrmH = New System.Windows.Forms.TextBox()
        Me.kikyoCbo = New System.Windows.Forms.ComboBox()
        Me.kikyoChk4 = New System.Windows.Forms.CheckBox()
        Me.kikyoChk3 = New System.Windows.Forms.CheckBox()
        Me.kikyoChk2 = New System.Windows.Forms.CheckBox()
        Me.kikyoChk1 = New System.Windows.Forms.CheckBox()
        Me.kikyoNam = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSakura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSuisen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHuji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAyame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHimawari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBotan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNadesiko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAjisai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKikyo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvYaguruma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvYuri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHamanasu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YmdBox
        '
        Me.YmdBox.boxType = 8
        Me.YmdBox.DateText = ""
        Me.YmdBox.EraLabelText = "H31"
        Me.YmdBox.EraText = ""
        Me.YmdBox.Location = New System.Drawing.Point(21, 25)
        Me.YmdBox.MonthLabelText = "02"
        Me.YmdBox.MonthText = ""
        Me.YmdBox.Name = "YmdBox"
        Me.YmdBox.Size = New System.Drawing.Size(174, 46)
        Me.YmdBox.TabIndex = 0
        '
        'weatherBox
        '
        Me.weatherBox.FormattingEnabled = True
        Me.weatherBox.Location = New System.Drawing.Point(88, 85)
        Me.weatherBox.Name = "weatherBox"
        Me.weatherBox.Size = New System.Drawing.Size(103, 20)
        Me.weatherBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "天気"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "【全　体】"
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(505, 15)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(63, 32)
        Me.btnRegist.TabIndex = 4
        Me.btnRegist.Text = "登　録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(570, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 32)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "削　除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(635, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(63, 32)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "印　刷"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'rbtnYmd
        '
        Me.rbtnYmd.AutoSize = True
        Me.rbtnYmd.Checked = True
        Me.rbtnYmd.Location = New System.Drawing.Point(706, 15)
        Me.rbtnYmd.Name = "rbtnYmd"
        Me.rbtnYmd.Size = New System.Drawing.Size(59, 16)
        Me.rbtnYmd.TabIndex = 7
        Me.rbtnYmd.TabStop = True
        Me.rbtnYmd.Text = "年月日"
        Me.rbtnYmd.UseVisualStyleBackColor = True
        '
        'rbtnYm
        '
        Me.rbtnYm.AutoSize = True
        Me.rbtnYm.Location = New System.Drawing.Point(706, 33)
        Me.rbtnYm.Name = "rbtnYm"
        Me.rbtnYm.Size = New System.Drawing.Size(47, 16)
        Me.rbtnYm.TabIndex = 8
        Me.rbtnYm.Text = "年月"
        Me.rbtnYm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(819, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 42)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(861, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 42)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(945, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 42)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(903, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 42)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(819, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "施設長"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(861, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "援助員"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(909, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "宿直"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(950, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "合議"
        '
        'btnSealSet
        '
        Me.btnSealSet.ForeColor = System.Drawing.Color.Red
        Me.btnSealSet.Location = New System.Drawing.Point(875, 79)
        Me.btnSealSet.Name = "btnSealSet"
        Me.btnSealSet.Size = New System.Drawing.Size(52, 23)
        Me.btnSealSet.TabIndex = 17
        Me.btnSealSet.Text = "押"
        Me.btnSealSet.UseVisualStyleBackColor = True
        '
        'dgvZen
        '
        Me.dgvZen.AllowUserToAddRows = False
        Me.dgvZen.AllowUserToDeleteRows = False
        Me.dgvZen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZen.Location = New System.Drawing.Point(216, 50)
        Me.dgvZen.Name = "dgvZen"
        Me.dgvZen.RowTemplate.Height = 21
        Me.dgvZen.Size = New System.Drawing.Size(545, 63)
        Me.dgvZen.TabIndex = 18
        '
        'dgvRen
        '
        Me.dgvRen.AllowUserToAddRows = False
        Me.dgvRen.AllowUserToDeleteRows = False
        Me.dgvRen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRen.Location = New System.Drawing.Point(216, 609)
        Me.dgvRen.Name = "dgvRen"
        Me.dgvRen.RowTemplate.Height = 21
        Me.dgvRen.Size = New System.Drawing.Size(545, 63)
        Me.dgvRen.TabIndex = 19
        '
        'dgvSakura
        '
        Me.dgvSakura.AllowUserToAddRows = False
        Me.dgvSakura.AllowUserToDeleteRows = False
        Me.dgvSakura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSakura.Location = New System.Drawing.Point(187, 124)
        Me.dgvSakura.Name = "dgvSakura"
        Me.dgvSakura.RowTemplate.Height = 21
        Me.dgvSakura.Size = New System.Drawing.Size(157, 107)
        Me.dgvSakura.TabIndex = 20
        '
        'dgvSuisen
        '
        Me.dgvSuisen.AllowUserToAddRows = False
        Me.dgvSuisen.AllowUserToDeleteRows = False
        Me.dgvSuisen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuisen.Location = New System.Drawing.Point(187, 242)
        Me.dgvSuisen.Name = "dgvSuisen"
        Me.dgvSuisen.RowTemplate.Height = 21
        Me.dgvSuisen.Size = New System.Drawing.Size(157, 107)
        Me.dgvSuisen.TabIndex = 21
        '
        'dgvHuji
        '
        Me.dgvHuji.AllowUserToAddRows = False
        Me.dgvHuji.AllowUserToDeleteRows = False
        Me.dgvHuji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHuji.Location = New System.Drawing.Point(187, 478)
        Me.dgvHuji.Name = "dgvHuji"
        Me.dgvHuji.RowTemplate.Height = 21
        Me.dgvHuji.Size = New System.Drawing.Size(157, 107)
        Me.dgvHuji.TabIndex = 23
        '
        'dgvAyame
        '
        Me.dgvAyame.AllowUserToAddRows = False
        Me.dgvAyame.AllowUserToDeleteRows = False
        Me.dgvAyame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAyame.Location = New System.Drawing.Point(187, 360)
        Me.dgvAyame.Name = "dgvAyame"
        Me.dgvAyame.RowTemplate.Height = 21
        Me.dgvAyame.Size = New System.Drawing.Size(157, 107)
        Me.dgvAyame.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 594)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "【連絡事項】"
        '
        'dgvHimawari
        '
        Me.dgvHimawari.AllowUserToAddRows = False
        Me.dgvHimawari.AllowUserToDeleteRows = False
        Me.dgvHimawari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHimawari.Location = New System.Drawing.Point(504, 478)
        Me.dgvHimawari.Name = "dgvHimawari"
        Me.dgvHimawari.RowTemplate.Height = 21
        Me.dgvHimawari.Size = New System.Drawing.Size(157, 107)
        Me.dgvHimawari.TabIndex = 28
        '
        'dgvBotan
        '
        Me.dgvBotan.AllowUserToAddRows = False
        Me.dgvBotan.AllowUserToDeleteRows = False
        Me.dgvBotan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBotan.Location = New System.Drawing.Point(504, 360)
        Me.dgvBotan.Name = "dgvBotan"
        Me.dgvBotan.RowTemplate.Height = 21
        Me.dgvBotan.Size = New System.Drawing.Size(157, 107)
        Me.dgvBotan.TabIndex = 27
        '
        'dgvNadesiko
        '
        Me.dgvNadesiko.AllowUserToAddRows = False
        Me.dgvNadesiko.AllowUserToDeleteRows = False
        Me.dgvNadesiko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNadesiko.Location = New System.Drawing.Point(504, 242)
        Me.dgvNadesiko.Name = "dgvNadesiko"
        Me.dgvNadesiko.RowTemplate.Height = 21
        Me.dgvNadesiko.Size = New System.Drawing.Size(157, 107)
        Me.dgvNadesiko.TabIndex = 26
        '
        'dgvAjisai
        '
        Me.dgvAjisai.AllowUserToAddRows = False
        Me.dgvAjisai.AllowUserToDeleteRows = False
        Me.dgvAjisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAjisai.Location = New System.Drawing.Point(504, 124)
        Me.dgvAjisai.Name = "dgvAjisai"
        Me.dgvAjisai.RowTemplate.Height = 21
        Me.dgvAjisai.Size = New System.Drawing.Size(157, 107)
        Me.dgvAjisai.TabIndex = 25
        '
        'dgvKikyo
        '
        Me.dgvKikyo.AllowUserToAddRows = False
        Me.dgvKikyo.AllowUserToDeleteRows = False
        Me.dgvKikyo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKikyo.Location = New System.Drawing.Point(822, 478)
        Me.dgvKikyo.Name = "dgvKikyo"
        Me.dgvKikyo.RowTemplate.Height = 21
        Me.dgvKikyo.Size = New System.Drawing.Size(157, 107)
        Me.dgvKikyo.TabIndex = 32
        '
        'dgvYaguruma
        '
        Me.dgvYaguruma.AllowUserToAddRows = False
        Me.dgvYaguruma.AllowUserToDeleteRows = False
        Me.dgvYaguruma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYaguruma.Location = New System.Drawing.Point(822, 360)
        Me.dgvYaguruma.Name = "dgvYaguruma"
        Me.dgvYaguruma.RowTemplate.Height = 21
        Me.dgvYaguruma.Size = New System.Drawing.Size(157, 107)
        Me.dgvYaguruma.TabIndex = 31
        '
        'dgvYuri
        '
        Me.dgvYuri.AllowUserToAddRows = False
        Me.dgvYuri.AllowUserToDeleteRows = False
        Me.dgvYuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYuri.Location = New System.Drawing.Point(822, 242)
        Me.dgvYuri.Name = "dgvYuri"
        Me.dgvYuri.RowTemplate.Height = 21
        Me.dgvYuri.Size = New System.Drawing.Size(157, 107)
        Me.dgvYuri.TabIndex = 30
        '
        'dgvHamanasu
        '
        Me.dgvHamanasu.AllowUserToAddRows = False
        Me.dgvHamanasu.AllowUserToDeleteRows = False
        Me.dgvHamanasu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHamanasu.Location = New System.Drawing.Point(822, 124)
        Me.dgvHamanasu.Name = "dgvHamanasu"
        Me.dgvHamanasu.RowTemplate.Height = 21
        Me.dgvHamanasu.Size = New System.Drawing.Size(157, 107)
        Me.dgvHamanasu.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 12)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "【さくら】"
        '
        'sakuraNam
        '
        Me.sakuraNam.AutoSize = True
        Me.sakuraNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.sakuraNam.ForeColor = System.Drawing.Color.Blue
        Me.sakuraNam.Location = New System.Drawing.Point(32, 140)
        Me.sakuraNam.Name = "sakuraNam"
        Me.sakuraNam.Size = New System.Drawing.Size(0, 19)
        Me.sakuraNam.TabIndex = 34
        '
        'sakuraChk1
        '
        Me.sakuraChk1.AutoSize = True
        Me.sakuraChk1.Location = New System.Drawing.Point(38, 166)
        Me.sakuraChk1.Name = "sakuraChk1"
        Me.sakuraChk1.Size = New System.Drawing.Size(48, 16)
        Me.sakuraChk1.TabIndex = 35
        Me.sakuraChk1.Text = "入浴"
        Me.sakuraChk1.UseVisualStyleBackColor = True
        '
        'sakuraChk2
        '
        Me.sakuraChk2.AutoSize = True
        Me.sakuraChk2.Location = New System.Drawing.Point(86, 166)
        Me.sakuraChk2.Name = "sakuraChk2"
        Me.sakuraChk2.Size = New System.Drawing.Size(48, 16)
        Me.sakuraChk2.TabIndex = 36
        Me.sakuraChk2.Text = "外泊"
        Me.sakuraChk2.UseVisualStyleBackColor = True
        '
        'sakuraChk3
        '
        Me.sakuraChk3.AutoSize = True
        Me.sakuraChk3.Location = New System.Drawing.Point(134, 166)
        Me.sakuraChk3.Name = "sakuraChk3"
        Me.sakuraChk3.Size = New System.Drawing.Size(48, 16)
        Me.sakuraChk3.TabIndex = 37
        Me.sakuraChk3.Text = "入院"
        Me.sakuraChk3.UseVisualStyleBackColor = True
        '
        'sakuraChk4
        '
        Me.sakuraChk4.AutoSize = True
        Me.sakuraChk4.Location = New System.Drawing.Point(38, 188)
        Me.sakuraChk4.Name = "sakuraChk4"
        Me.sakuraChk4.Size = New System.Drawing.Size(48, 16)
        Me.sakuraChk4.TabIndex = 38
        Me.sakuraChk4.Text = "外出"
        Me.sakuraChk4.UseVisualStyleBackColor = True
        '
        'sakuraCbo
        '
        Me.sakuraCbo.FormattingEnabled = True
        Me.sakuraCbo.Location = New System.Drawing.Point(84, 186)
        Me.sakuraCbo.Name = "sakuraCbo"
        Me.sakuraCbo.Size = New System.Drawing.Size(94, 20)
        Me.sakuraCbo.TabIndex = 39
        '
        'sakuraFrmH
        '
        Me.sakuraFrmH.Location = New System.Drawing.Point(42, 211)
        Me.sakuraFrmH.Name = "sakuraFrmH"
        Me.sakuraFrmH.Size = New System.Drawing.Size(22, 19)
        Me.sakuraFrmH.TabIndex = 40
        Me.sakuraFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sakuraFrmM
        '
        Me.sakuraFrmM.Location = New System.Drawing.Point(77, 211)
        Me.sakuraFrmM.Name = "sakuraFrmM"
        Me.sakuraFrmM.Size = New System.Drawing.Size(22, 19)
        Me.sakuraFrmM.TabIndex = 41
        Me.sakuraFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 12)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "～"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(145, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 12)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "："
        '
        'sakuraToM
        '
        Me.sakuraToM.Location = New System.Drawing.Point(156, 211)
        Me.sakuraToM.Name = "sakuraToM"
        Me.sakuraToM.Size = New System.Drawing.Size(22, 19)
        Me.sakuraToM.TabIndex = 45
        Me.sakuraToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sakuraToH
        '
        Me.sakuraToH.Location = New System.Drawing.Point(121, 211)
        Me.sakuraToH.Name = "sakuraToH"
        Me.sakuraToH.Size = New System.Drawing.Size(22, 19)
        Me.sakuraToH.TabIndex = 44
        Me.sakuraToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 12)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "："
        '
        'ajisaiToM
        '
        Me.ajisaiToM.Location = New System.Drawing.Point(472, 211)
        Me.ajisaiToM.Name = "ajisaiToM"
        Me.ajisaiToM.Size = New System.Drawing.Size(22, 19)
        Me.ajisaiToM.TabIndex = 59
        Me.ajisaiToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ajisaiToH
        '
        Me.ajisaiToH.Location = New System.Drawing.Point(437, 211)
        Me.ajisaiToH.Name = "ajisaiToH"
        Me.ajisaiToH.Size = New System.Drawing.Size(22, 19)
        Me.ajisaiToH.TabIndex = 58
        Me.ajisaiToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(418, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 12)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "～"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(382, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 12)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "："
        '
        'ajisaiFrmM
        '
        Me.ajisaiFrmM.Location = New System.Drawing.Point(393, 211)
        Me.ajisaiFrmM.Name = "ajisaiFrmM"
        Me.ajisaiFrmM.Size = New System.Drawing.Size(22, 19)
        Me.ajisaiFrmM.TabIndex = 55
        Me.ajisaiFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ajisaiFrmH
        '
        Me.ajisaiFrmH.Location = New System.Drawing.Point(358, 211)
        Me.ajisaiFrmH.Name = "ajisaiFrmH"
        Me.ajisaiFrmH.Size = New System.Drawing.Size(22, 19)
        Me.ajisaiFrmH.TabIndex = 54
        Me.ajisaiFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ajisaiCbo
        '
        Me.ajisaiCbo.FormattingEnabled = True
        Me.ajisaiCbo.Location = New System.Drawing.Point(400, 186)
        Me.ajisaiCbo.Name = "ajisaiCbo"
        Me.ajisaiCbo.Size = New System.Drawing.Size(94, 20)
        Me.ajisaiCbo.TabIndex = 53
        '
        'ajisaiChk4
        '
        Me.ajisaiChk4.AutoSize = True
        Me.ajisaiChk4.Location = New System.Drawing.Point(354, 188)
        Me.ajisaiChk4.Name = "ajisaiChk4"
        Me.ajisaiChk4.Size = New System.Drawing.Size(48, 16)
        Me.ajisaiChk4.TabIndex = 52
        Me.ajisaiChk4.Text = "外出"
        Me.ajisaiChk4.UseVisualStyleBackColor = True
        '
        'ajisaiChk3
        '
        Me.ajisaiChk3.AutoSize = True
        Me.ajisaiChk3.Location = New System.Drawing.Point(450, 166)
        Me.ajisaiChk3.Name = "ajisaiChk3"
        Me.ajisaiChk3.Size = New System.Drawing.Size(48, 16)
        Me.ajisaiChk3.TabIndex = 51
        Me.ajisaiChk3.Text = "入院"
        Me.ajisaiChk3.UseVisualStyleBackColor = True
        '
        'ajisaiChk2
        '
        Me.ajisaiChk2.AutoSize = True
        Me.ajisaiChk2.Location = New System.Drawing.Point(402, 166)
        Me.ajisaiChk2.Name = "ajisaiChk2"
        Me.ajisaiChk2.Size = New System.Drawing.Size(48, 16)
        Me.ajisaiChk2.TabIndex = 50
        Me.ajisaiChk2.Text = "外泊"
        Me.ajisaiChk2.UseVisualStyleBackColor = True
        '
        'ajisaiChk1
        '
        Me.ajisaiChk1.AutoSize = True
        Me.ajisaiChk1.Location = New System.Drawing.Point(354, 166)
        Me.ajisaiChk1.Name = "ajisaiChk1"
        Me.ajisaiChk1.Size = New System.Drawing.Size(48, 16)
        Me.ajisaiChk1.TabIndex = 49
        Me.ajisaiChk1.Text = "入浴"
        Me.ajisaiChk1.UseVisualStyleBackColor = True
        '
        'ajisaiNam
        '
        Me.ajisaiNam.AutoSize = True
        Me.ajisaiNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ajisaiNam.ForeColor = System.Drawing.Color.Blue
        Me.ajisaiNam.Location = New System.Drawing.Point(350, 140)
        Me.ajisaiNam.Name = "ajisaiNam"
        Me.ajisaiNam.Size = New System.Drawing.Size(0, 19)
        Me.ajisaiNam.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(350, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 12)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "【あじさい】"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(779, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 12)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "："
        '
        'hamanasuToM
        '
        Me.hamanasuToM.Location = New System.Drawing.Point(790, 211)
        Me.hamanasuToM.Name = "hamanasuToM"
        Me.hamanasuToM.Size = New System.Drawing.Size(22, 19)
        Me.hamanasuToM.TabIndex = 73
        Me.hamanasuToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hamanasuToH
        '
        Me.hamanasuToH.Location = New System.Drawing.Point(755, 211)
        Me.hamanasuToH.Name = "hamanasuToH"
        Me.hamanasuToH.Size = New System.Drawing.Size(22, 19)
        Me.hamanasuToH.TabIndex = 72
        Me.hamanasuToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(736, 216)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 12)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "～"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(700, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 12)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "："
        '
        'hamanasuFrmM
        '
        Me.hamanasuFrmM.Location = New System.Drawing.Point(711, 211)
        Me.hamanasuFrmM.Name = "hamanasuFrmM"
        Me.hamanasuFrmM.Size = New System.Drawing.Size(22, 19)
        Me.hamanasuFrmM.TabIndex = 69
        Me.hamanasuFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hamanasuFrmH
        '
        Me.hamanasuFrmH.Location = New System.Drawing.Point(676, 211)
        Me.hamanasuFrmH.Name = "hamanasuFrmH"
        Me.hamanasuFrmH.Size = New System.Drawing.Size(22, 19)
        Me.hamanasuFrmH.TabIndex = 68
        Me.hamanasuFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hamanasuCbo
        '
        Me.hamanasuCbo.FormattingEnabled = True
        Me.hamanasuCbo.Location = New System.Drawing.Point(718, 186)
        Me.hamanasuCbo.Name = "hamanasuCbo"
        Me.hamanasuCbo.Size = New System.Drawing.Size(94, 20)
        Me.hamanasuCbo.TabIndex = 67
        '
        'hamanasuChk4
        '
        Me.hamanasuChk4.AutoSize = True
        Me.hamanasuChk4.Location = New System.Drawing.Point(672, 188)
        Me.hamanasuChk4.Name = "hamanasuChk4"
        Me.hamanasuChk4.Size = New System.Drawing.Size(48, 16)
        Me.hamanasuChk4.TabIndex = 66
        Me.hamanasuChk4.Text = "外出"
        Me.hamanasuChk4.UseVisualStyleBackColor = True
        '
        'hamanasuChk3
        '
        Me.hamanasuChk3.AutoSize = True
        Me.hamanasuChk3.Location = New System.Drawing.Point(768, 166)
        Me.hamanasuChk3.Name = "hamanasuChk3"
        Me.hamanasuChk3.Size = New System.Drawing.Size(48, 16)
        Me.hamanasuChk3.TabIndex = 65
        Me.hamanasuChk3.Text = "入院"
        Me.hamanasuChk3.UseVisualStyleBackColor = True
        '
        'hamanasuChk2
        '
        Me.hamanasuChk2.AutoSize = True
        Me.hamanasuChk2.Location = New System.Drawing.Point(720, 166)
        Me.hamanasuChk2.Name = "hamanasuChk2"
        Me.hamanasuChk2.Size = New System.Drawing.Size(48, 16)
        Me.hamanasuChk2.TabIndex = 64
        Me.hamanasuChk2.Text = "外泊"
        Me.hamanasuChk2.UseVisualStyleBackColor = True
        '
        'hamanasuChk1
        '
        Me.hamanasuChk1.AutoSize = True
        Me.hamanasuChk1.Location = New System.Drawing.Point(672, 166)
        Me.hamanasuChk1.Name = "hamanasuChk1"
        Me.hamanasuChk1.Size = New System.Drawing.Size(48, 16)
        Me.hamanasuChk1.TabIndex = 63
        Me.hamanasuChk1.Text = "入浴"
        Me.hamanasuChk1.UseVisualStyleBackColor = True
        '
        'hamanasuNam
        '
        Me.hamanasuNam.AutoSize = True
        Me.hamanasuNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.hamanasuNam.ForeColor = System.Drawing.Color.Blue
        Me.hamanasuNam.Location = New System.Drawing.Point(668, 140)
        Me.hamanasuNam.Name = "hamanasuNam"
        Me.hamanasuNam.Size = New System.Drawing.Size(0, 19)
        Me.hamanasuNam.TabIndex = 62
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(668, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 12)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "【はまなす】"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.Location = New System.Drawing.Point(145, 333)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 12)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "："
        '
        'suisenToM
        '
        Me.suisenToM.Location = New System.Drawing.Point(156, 329)
        Me.suisenToM.Name = "suisenToM"
        Me.suisenToM.Size = New System.Drawing.Size(22, 19)
        Me.suisenToM.TabIndex = 87
        Me.suisenToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'suisenToH
        '
        Me.suisenToH.Location = New System.Drawing.Point(121, 329)
        Me.suisenToH.Name = "suisenToH"
        Me.suisenToH.Size = New System.Drawing.Size(22, 19)
        Me.suisenToH.TabIndex = 86
        Me.suisenToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(102, 334)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 12)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "～"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Location = New System.Drawing.Point(66, 333)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 12)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "："
        '
        'suisenFrmM
        '
        Me.suisenFrmM.Location = New System.Drawing.Point(77, 329)
        Me.suisenFrmM.Name = "suisenFrmM"
        Me.suisenFrmM.Size = New System.Drawing.Size(22, 19)
        Me.suisenFrmM.TabIndex = 83
        Me.suisenFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'suisenFrmH
        '
        Me.suisenFrmH.Location = New System.Drawing.Point(42, 329)
        Me.suisenFrmH.Name = "suisenFrmH"
        Me.suisenFrmH.Size = New System.Drawing.Size(22, 19)
        Me.suisenFrmH.TabIndex = 82
        Me.suisenFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'suisenCbo
        '
        Me.suisenCbo.FormattingEnabled = True
        Me.suisenCbo.Location = New System.Drawing.Point(84, 304)
        Me.suisenCbo.Name = "suisenCbo"
        Me.suisenCbo.Size = New System.Drawing.Size(94, 20)
        Me.suisenCbo.TabIndex = 81
        '
        'suisenChk4
        '
        Me.suisenChk4.AutoSize = True
        Me.suisenChk4.Location = New System.Drawing.Point(38, 306)
        Me.suisenChk4.Name = "suisenChk4"
        Me.suisenChk4.Size = New System.Drawing.Size(48, 16)
        Me.suisenChk4.TabIndex = 80
        Me.suisenChk4.Text = "外出"
        Me.suisenChk4.UseVisualStyleBackColor = True
        '
        'suisenChk3
        '
        Me.suisenChk3.AutoSize = True
        Me.suisenChk3.Location = New System.Drawing.Point(134, 284)
        Me.suisenChk3.Name = "suisenChk3"
        Me.suisenChk3.Size = New System.Drawing.Size(48, 16)
        Me.suisenChk3.TabIndex = 79
        Me.suisenChk3.Text = "入院"
        Me.suisenChk3.UseVisualStyleBackColor = True
        '
        'suisenChk2
        '
        Me.suisenChk2.AutoSize = True
        Me.suisenChk2.Location = New System.Drawing.Point(86, 284)
        Me.suisenChk2.Name = "suisenChk2"
        Me.suisenChk2.Size = New System.Drawing.Size(48, 16)
        Me.suisenChk2.TabIndex = 78
        Me.suisenChk2.Text = "外泊"
        Me.suisenChk2.UseVisualStyleBackColor = True
        '
        'suisenChk1
        '
        Me.suisenChk1.AutoSize = True
        Me.suisenChk1.Location = New System.Drawing.Point(38, 284)
        Me.suisenChk1.Name = "suisenChk1"
        Me.suisenChk1.Size = New System.Drawing.Size(48, 16)
        Me.suisenChk1.TabIndex = 77
        Me.suisenChk1.Text = "入浴"
        Me.suisenChk1.UseVisualStyleBackColor = True
        '
        'suisenNam
        '
        Me.suisenNam.AutoSize = True
        Me.suisenNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.suisenNam.ForeColor = System.Drawing.Color.Blue
        Me.suisenNam.Location = New System.Drawing.Point(32, 258)
        Me.suisenNam.Name = "suisenNam"
        Me.suisenNam.Size = New System.Drawing.Size(0, 19)
        Me.suisenNam.TabIndex = 76
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(34, 242)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 12)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "【すいせん】"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label28.Location = New System.Drawing.Point(145, 451)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(11, 12)
        Me.Label28.TabIndex = 102
        Me.Label28.Text = "："
        '
        'ayameToM
        '
        Me.ayameToM.Location = New System.Drawing.Point(156, 447)
        Me.ayameToM.Name = "ayameToM"
        Me.ayameToM.Size = New System.Drawing.Size(22, 19)
        Me.ayameToM.TabIndex = 101
        Me.ayameToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ayameToH
        '
        Me.ayameToH.Location = New System.Drawing.Point(121, 447)
        Me.ayameToH.Name = "ayameToH"
        Me.ayameToH.Size = New System.Drawing.Size(22, 19)
        Me.ayameToH.TabIndex = 100
        Me.ayameToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(102, 452)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(17, 12)
        Me.Label29.TabIndex = 99
        Me.Label29.Text = "～"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label30.Location = New System.Drawing.Point(66, 451)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(11, 12)
        Me.Label30.TabIndex = 98
        Me.Label30.Text = "："
        '
        'ayameFrmM
        '
        Me.ayameFrmM.Location = New System.Drawing.Point(77, 447)
        Me.ayameFrmM.Name = "ayameFrmM"
        Me.ayameFrmM.Size = New System.Drawing.Size(22, 19)
        Me.ayameFrmM.TabIndex = 97
        Me.ayameFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ayameFrmH
        '
        Me.ayameFrmH.Location = New System.Drawing.Point(42, 447)
        Me.ayameFrmH.Name = "ayameFrmH"
        Me.ayameFrmH.Size = New System.Drawing.Size(22, 19)
        Me.ayameFrmH.TabIndex = 96
        Me.ayameFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ayameCbo
        '
        Me.ayameCbo.FormattingEnabled = True
        Me.ayameCbo.Location = New System.Drawing.Point(84, 422)
        Me.ayameCbo.Name = "ayameCbo"
        Me.ayameCbo.Size = New System.Drawing.Size(94, 20)
        Me.ayameCbo.TabIndex = 95
        '
        'ayameChk4
        '
        Me.ayameChk4.AutoSize = True
        Me.ayameChk4.Location = New System.Drawing.Point(38, 424)
        Me.ayameChk4.Name = "ayameChk4"
        Me.ayameChk4.Size = New System.Drawing.Size(48, 16)
        Me.ayameChk4.TabIndex = 94
        Me.ayameChk4.Text = "外出"
        Me.ayameChk4.UseVisualStyleBackColor = True
        '
        'ayameChk3
        '
        Me.ayameChk3.AutoSize = True
        Me.ayameChk3.Location = New System.Drawing.Point(134, 402)
        Me.ayameChk3.Name = "ayameChk3"
        Me.ayameChk3.Size = New System.Drawing.Size(48, 16)
        Me.ayameChk3.TabIndex = 93
        Me.ayameChk3.Text = "入院"
        Me.ayameChk3.UseVisualStyleBackColor = True
        '
        'ayameChk2
        '
        Me.ayameChk2.AutoSize = True
        Me.ayameChk2.Location = New System.Drawing.Point(86, 402)
        Me.ayameChk2.Name = "ayameChk2"
        Me.ayameChk2.Size = New System.Drawing.Size(48, 16)
        Me.ayameChk2.TabIndex = 92
        Me.ayameChk2.Text = "外泊"
        Me.ayameChk2.UseVisualStyleBackColor = True
        '
        'ayameChk1
        '
        Me.ayameChk1.AutoSize = True
        Me.ayameChk1.Location = New System.Drawing.Point(38, 402)
        Me.ayameChk1.Name = "ayameChk1"
        Me.ayameChk1.Size = New System.Drawing.Size(48, 16)
        Me.ayameChk1.TabIndex = 91
        Me.ayameChk1.Text = "入浴"
        Me.ayameChk1.UseVisualStyleBackColor = True
        '
        'ayameNam
        '
        Me.ayameNam.AutoSize = True
        Me.ayameNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ayameNam.ForeColor = System.Drawing.Color.Blue
        Me.ayameNam.Location = New System.Drawing.Point(32, 376)
        Me.ayameNam.Name = "ayameNam"
        Me.ayameNam.Size = New System.Drawing.Size(0, 19)
        Me.ayameNam.TabIndex = 90
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(34, 360)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(47, 12)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "【あやめ】"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label33.Location = New System.Drawing.Point(145, 569)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(11, 12)
        Me.Label33.TabIndex = 116
        Me.Label33.Text = "："
        '
        'hujiToM
        '
        Me.hujiToM.Location = New System.Drawing.Point(156, 565)
        Me.hujiToM.Name = "hujiToM"
        Me.hujiToM.Size = New System.Drawing.Size(22, 19)
        Me.hujiToM.TabIndex = 115
        Me.hujiToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hujiToH
        '
        Me.hujiToH.Location = New System.Drawing.Point(121, 565)
        Me.hujiToH.Name = "hujiToH"
        Me.hujiToH.Size = New System.Drawing.Size(22, 19)
        Me.hujiToH.TabIndex = 114
        Me.hujiToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(102, 570)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(17, 12)
        Me.Label34.TabIndex = 113
        Me.Label34.Text = "～"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label35.Location = New System.Drawing.Point(66, 569)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(11, 12)
        Me.Label35.TabIndex = 112
        Me.Label35.Text = "："
        '
        'hujiFrmM
        '
        Me.hujiFrmM.Location = New System.Drawing.Point(77, 565)
        Me.hujiFrmM.Name = "hujiFrmM"
        Me.hujiFrmM.Size = New System.Drawing.Size(22, 19)
        Me.hujiFrmM.TabIndex = 111
        Me.hujiFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hujiFrmH
        '
        Me.hujiFrmH.Location = New System.Drawing.Point(42, 565)
        Me.hujiFrmH.Name = "hujiFrmH"
        Me.hujiFrmH.Size = New System.Drawing.Size(22, 19)
        Me.hujiFrmH.TabIndex = 110
        Me.hujiFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hujiCbo
        '
        Me.hujiCbo.FormattingEnabled = True
        Me.hujiCbo.Location = New System.Drawing.Point(84, 540)
        Me.hujiCbo.Name = "hujiCbo"
        Me.hujiCbo.Size = New System.Drawing.Size(94, 20)
        Me.hujiCbo.TabIndex = 109
        '
        'hujiChk4
        '
        Me.hujiChk4.AutoSize = True
        Me.hujiChk4.Location = New System.Drawing.Point(38, 542)
        Me.hujiChk4.Name = "hujiChk4"
        Me.hujiChk4.Size = New System.Drawing.Size(48, 16)
        Me.hujiChk4.TabIndex = 108
        Me.hujiChk4.Text = "外出"
        Me.hujiChk4.UseVisualStyleBackColor = True
        '
        'hujiChk3
        '
        Me.hujiChk3.AutoSize = True
        Me.hujiChk3.Location = New System.Drawing.Point(134, 520)
        Me.hujiChk3.Name = "hujiChk3"
        Me.hujiChk3.Size = New System.Drawing.Size(48, 16)
        Me.hujiChk3.TabIndex = 107
        Me.hujiChk3.Text = "入院"
        Me.hujiChk3.UseVisualStyleBackColor = True
        '
        'hujiChk2
        '
        Me.hujiChk2.AutoSize = True
        Me.hujiChk2.Location = New System.Drawing.Point(86, 520)
        Me.hujiChk2.Name = "hujiChk2"
        Me.hujiChk2.Size = New System.Drawing.Size(48, 16)
        Me.hujiChk2.TabIndex = 106
        Me.hujiChk2.Text = "外泊"
        Me.hujiChk2.UseVisualStyleBackColor = True
        '
        'hujiChk1
        '
        Me.hujiChk1.AutoSize = True
        Me.hujiChk1.Location = New System.Drawing.Point(38, 520)
        Me.hujiChk1.Name = "hujiChk1"
        Me.hujiChk1.Size = New System.Drawing.Size(48, 16)
        Me.hujiChk1.TabIndex = 105
        Me.hujiChk1.Text = "入浴"
        Me.hujiChk1.UseVisualStyleBackColor = True
        '
        'hujiNam
        '
        Me.hujiNam.AutoSize = True
        Me.hujiNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.hujiNam.ForeColor = System.Drawing.Color.Blue
        Me.hujiNam.Location = New System.Drawing.Point(32, 494)
        Me.hujiNam.Name = "hujiNam"
        Me.hujiNam.Size = New System.Drawing.Size(0, 19)
        Me.hujiNam.TabIndex = 104
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(34, 478)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 12)
        Me.Label37.TabIndex = 103
        Me.Label37.Text = "【ふじ】"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label38.Location = New System.Drawing.Point(461, 333)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(11, 12)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "："
        '
        'nadesikoToM
        '
        Me.nadesikoToM.Location = New System.Drawing.Point(472, 329)
        Me.nadesikoToM.Name = "nadesikoToM"
        Me.nadesikoToM.Size = New System.Drawing.Size(22, 19)
        Me.nadesikoToM.TabIndex = 129
        Me.nadesikoToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nadesikoToH
        '
        Me.nadesikoToH.Location = New System.Drawing.Point(437, 329)
        Me.nadesikoToH.Name = "nadesikoToH"
        Me.nadesikoToH.Size = New System.Drawing.Size(22, 19)
        Me.nadesikoToH.TabIndex = 128
        Me.nadesikoToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(418, 334)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(17, 12)
        Me.Label39.TabIndex = 127
        Me.Label39.Text = "～"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label40.Location = New System.Drawing.Point(382, 333)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(11, 12)
        Me.Label40.TabIndex = 126
        Me.Label40.Text = "："
        '
        'nadesikoFrmM
        '
        Me.nadesikoFrmM.Location = New System.Drawing.Point(393, 329)
        Me.nadesikoFrmM.Name = "nadesikoFrmM"
        Me.nadesikoFrmM.Size = New System.Drawing.Size(22, 19)
        Me.nadesikoFrmM.TabIndex = 125
        Me.nadesikoFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nadesikoFrmH
        '
        Me.nadesikoFrmH.Location = New System.Drawing.Point(358, 329)
        Me.nadesikoFrmH.Name = "nadesikoFrmH"
        Me.nadesikoFrmH.Size = New System.Drawing.Size(22, 19)
        Me.nadesikoFrmH.TabIndex = 124
        Me.nadesikoFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nadesikoCbo
        '
        Me.nadesikoCbo.FormattingEnabled = True
        Me.nadesikoCbo.Location = New System.Drawing.Point(400, 304)
        Me.nadesikoCbo.Name = "nadesikoCbo"
        Me.nadesikoCbo.Size = New System.Drawing.Size(94, 20)
        Me.nadesikoCbo.TabIndex = 123
        '
        'nadesikoChk4
        '
        Me.nadesikoChk4.AutoSize = True
        Me.nadesikoChk4.Location = New System.Drawing.Point(354, 306)
        Me.nadesikoChk4.Name = "nadesikoChk4"
        Me.nadesikoChk4.Size = New System.Drawing.Size(48, 16)
        Me.nadesikoChk4.TabIndex = 122
        Me.nadesikoChk4.Text = "外出"
        Me.nadesikoChk4.UseVisualStyleBackColor = True
        '
        'nadesikoChk3
        '
        Me.nadesikoChk3.AutoSize = True
        Me.nadesikoChk3.Location = New System.Drawing.Point(450, 284)
        Me.nadesikoChk3.Name = "nadesikoChk3"
        Me.nadesikoChk3.Size = New System.Drawing.Size(48, 16)
        Me.nadesikoChk3.TabIndex = 121
        Me.nadesikoChk3.Text = "入院"
        Me.nadesikoChk3.UseVisualStyleBackColor = True
        '
        'nadesikoChk2
        '
        Me.nadesikoChk2.AutoSize = True
        Me.nadesikoChk2.Location = New System.Drawing.Point(402, 284)
        Me.nadesikoChk2.Name = "nadesikoChk2"
        Me.nadesikoChk2.Size = New System.Drawing.Size(48, 16)
        Me.nadesikoChk2.TabIndex = 120
        Me.nadesikoChk2.Text = "外泊"
        Me.nadesikoChk2.UseVisualStyleBackColor = True
        '
        'nadesikoChk1
        '
        Me.nadesikoChk1.AutoSize = True
        Me.nadesikoChk1.Location = New System.Drawing.Point(354, 284)
        Me.nadesikoChk1.Name = "nadesikoChk1"
        Me.nadesikoChk1.Size = New System.Drawing.Size(48, 16)
        Me.nadesikoChk1.TabIndex = 119
        Me.nadesikoChk1.Text = "入浴"
        Me.nadesikoChk1.UseVisualStyleBackColor = True
        '
        'nadesikoNam
        '
        Me.nadesikoNam.AutoSize = True
        Me.nadesikoNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nadesikoNam.ForeColor = System.Drawing.Color.Blue
        Me.nadesikoNam.Location = New System.Drawing.Point(350, 258)
        Me.nadesikoNam.Name = "nadesikoNam"
        Me.nadesikoNam.Size = New System.Drawing.Size(0, 19)
        Me.nadesikoNam.TabIndex = 118
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(350, 242)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(54, 12)
        Me.Label42.TabIndex = 117
        Me.Label42.Text = "【なでしこ】"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label43.Location = New System.Drawing.Point(461, 451)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(11, 12)
        Me.Label43.TabIndex = 144
        Me.Label43.Text = "："
        '
        'botanToM
        '
        Me.botanToM.Location = New System.Drawing.Point(472, 447)
        Me.botanToM.Name = "botanToM"
        Me.botanToM.Size = New System.Drawing.Size(22, 19)
        Me.botanToM.TabIndex = 143
        Me.botanToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'botanToH
        '
        Me.botanToH.Location = New System.Drawing.Point(437, 447)
        Me.botanToH.Name = "botanToH"
        Me.botanToH.Size = New System.Drawing.Size(22, 19)
        Me.botanToH.TabIndex = 142
        Me.botanToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(418, 452)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(17, 12)
        Me.Label44.TabIndex = 141
        Me.Label44.Text = "～"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label45.Location = New System.Drawing.Point(382, 451)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(11, 12)
        Me.Label45.TabIndex = 140
        Me.Label45.Text = "："
        '
        'botanFrmM
        '
        Me.botanFrmM.Location = New System.Drawing.Point(393, 447)
        Me.botanFrmM.Name = "botanFrmM"
        Me.botanFrmM.Size = New System.Drawing.Size(22, 19)
        Me.botanFrmM.TabIndex = 139
        Me.botanFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'botanFrmH
        '
        Me.botanFrmH.Location = New System.Drawing.Point(358, 447)
        Me.botanFrmH.Name = "botanFrmH"
        Me.botanFrmH.Size = New System.Drawing.Size(22, 19)
        Me.botanFrmH.TabIndex = 138
        Me.botanFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'botanCbo
        '
        Me.botanCbo.FormattingEnabled = True
        Me.botanCbo.Location = New System.Drawing.Point(400, 422)
        Me.botanCbo.Name = "botanCbo"
        Me.botanCbo.Size = New System.Drawing.Size(94, 20)
        Me.botanCbo.TabIndex = 137
        '
        'botanChk4
        '
        Me.botanChk4.AutoSize = True
        Me.botanChk4.Location = New System.Drawing.Point(354, 424)
        Me.botanChk4.Name = "botanChk4"
        Me.botanChk4.Size = New System.Drawing.Size(48, 16)
        Me.botanChk4.TabIndex = 136
        Me.botanChk4.Text = "外出"
        Me.botanChk4.UseVisualStyleBackColor = True
        '
        'botanChk3
        '
        Me.botanChk3.AutoSize = True
        Me.botanChk3.Location = New System.Drawing.Point(450, 402)
        Me.botanChk3.Name = "botanChk3"
        Me.botanChk3.Size = New System.Drawing.Size(48, 16)
        Me.botanChk3.TabIndex = 135
        Me.botanChk3.Text = "入院"
        Me.botanChk3.UseVisualStyleBackColor = True
        '
        'botanChk2
        '
        Me.botanChk2.AutoSize = True
        Me.botanChk2.Location = New System.Drawing.Point(402, 402)
        Me.botanChk2.Name = "botanChk2"
        Me.botanChk2.Size = New System.Drawing.Size(48, 16)
        Me.botanChk2.TabIndex = 134
        Me.botanChk2.Text = "外泊"
        Me.botanChk2.UseVisualStyleBackColor = True
        '
        'botanChk1
        '
        Me.botanChk1.AutoSize = True
        Me.botanChk1.Location = New System.Drawing.Point(354, 402)
        Me.botanChk1.Name = "botanChk1"
        Me.botanChk1.Size = New System.Drawing.Size(48, 16)
        Me.botanChk1.TabIndex = 133
        Me.botanChk1.Text = "入浴"
        Me.botanChk1.UseVisualStyleBackColor = True
        '
        'botanNam
        '
        Me.botanNam.AutoSize = True
        Me.botanNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.botanNam.ForeColor = System.Drawing.Color.Blue
        Me.botanNam.Location = New System.Drawing.Point(350, 376)
        Me.botanNam.Name = "botanNam"
        Me.botanNam.Size = New System.Drawing.Size(0, 19)
        Me.botanNam.TabIndex = 132
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(350, 360)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(46, 12)
        Me.Label47.TabIndex = 131
        Me.Label47.Text = "【ぼたん】"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label48.Location = New System.Drawing.Point(461, 569)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(11, 12)
        Me.Label48.TabIndex = 158
        Me.Label48.Text = "："
        '
        'himawariToM
        '
        Me.himawariToM.Location = New System.Drawing.Point(472, 565)
        Me.himawariToM.Name = "himawariToM"
        Me.himawariToM.Size = New System.Drawing.Size(22, 19)
        Me.himawariToM.TabIndex = 157
        Me.himawariToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'himawariToH
        '
        Me.himawariToH.Location = New System.Drawing.Point(437, 565)
        Me.himawariToH.Name = "himawariToH"
        Me.himawariToH.Size = New System.Drawing.Size(22, 19)
        Me.himawariToH.TabIndex = 156
        Me.himawariToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(418, 570)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(17, 12)
        Me.Label49.TabIndex = 155
        Me.Label49.Text = "～"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label50.Location = New System.Drawing.Point(382, 569)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 12)
        Me.Label50.TabIndex = 154
        Me.Label50.Text = "："
        '
        'himawariFrmM
        '
        Me.himawariFrmM.Location = New System.Drawing.Point(393, 565)
        Me.himawariFrmM.Name = "himawariFrmM"
        Me.himawariFrmM.Size = New System.Drawing.Size(22, 19)
        Me.himawariFrmM.TabIndex = 153
        Me.himawariFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'himawariFrmH
        '
        Me.himawariFrmH.Location = New System.Drawing.Point(358, 565)
        Me.himawariFrmH.Name = "himawariFrmH"
        Me.himawariFrmH.Size = New System.Drawing.Size(22, 19)
        Me.himawariFrmH.TabIndex = 152
        Me.himawariFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'himawariCbo
        '
        Me.himawariCbo.FormattingEnabled = True
        Me.himawariCbo.Location = New System.Drawing.Point(400, 540)
        Me.himawariCbo.Name = "himawariCbo"
        Me.himawariCbo.Size = New System.Drawing.Size(94, 20)
        Me.himawariCbo.TabIndex = 151
        '
        'himawariChk4
        '
        Me.himawariChk4.AutoSize = True
        Me.himawariChk4.Location = New System.Drawing.Point(354, 542)
        Me.himawariChk4.Name = "himawariChk4"
        Me.himawariChk4.Size = New System.Drawing.Size(48, 16)
        Me.himawariChk4.TabIndex = 150
        Me.himawariChk4.Text = "外出"
        Me.himawariChk4.UseVisualStyleBackColor = True
        '
        'himawariChk3
        '
        Me.himawariChk3.AutoSize = True
        Me.himawariChk3.Location = New System.Drawing.Point(450, 520)
        Me.himawariChk3.Name = "himawariChk3"
        Me.himawariChk3.Size = New System.Drawing.Size(48, 16)
        Me.himawariChk3.TabIndex = 149
        Me.himawariChk3.Text = "入院"
        Me.himawariChk3.UseVisualStyleBackColor = True
        '
        'himawariChk2
        '
        Me.himawariChk2.AutoSize = True
        Me.himawariChk2.Location = New System.Drawing.Point(402, 520)
        Me.himawariChk2.Name = "himawariChk2"
        Me.himawariChk2.Size = New System.Drawing.Size(48, 16)
        Me.himawariChk2.TabIndex = 148
        Me.himawariChk2.Text = "外泊"
        Me.himawariChk2.UseVisualStyleBackColor = True
        '
        'himawariChk1
        '
        Me.himawariChk1.AutoSize = True
        Me.himawariChk1.Location = New System.Drawing.Point(354, 520)
        Me.himawariChk1.Name = "himawariChk1"
        Me.himawariChk1.Size = New System.Drawing.Size(48, 16)
        Me.himawariChk1.TabIndex = 147
        Me.himawariChk1.Text = "入浴"
        Me.himawariChk1.UseVisualStyleBackColor = True
        '
        'himawariNam
        '
        Me.himawariNam.AutoSize = True
        Me.himawariNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.himawariNam.ForeColor = System.Drawing.Color.Blue
        Me.himawariNam.Location = New System.Drawing.Point(350, 494)
        Me.himawariNam.Name = "himawariNam"
        Me.himawariNam.Size = New System.Drawing.Size(0, 19)
        Me.himawariNam.TabIndex = 146
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(350, 478)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(54, 12)
        Me.Label52.TabIndex = 145
        Me.Label52.Text = "【ひまわり】"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label53.Location = New System.Drawing.Point(779, 333)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(11, 12)
        Me.Label53.TabIndex = 172
        Me.Label53.Text = "："
        '
        'yuriToM
        '
        Me.yuriToM.Location = New System.Drawing.Point(790, 329)
        Me.yuriToM.Name = "yuriToM"
        Me.yuriToM.Size = New System.Drawing.Size(22, 19)
        Me.yuriToM.TabIndex = 171
        Me.yuriToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yuriToH
        '
        Me.yuriToH.Location = New System.Drawing.Point(755, 329)
        Me.yuriToH.Name = "yuriToH"
        Me.yuriToH.Size = New System.Drawing.Size(22, 19)
        Me.yuriToH.TabIndex = 170
        Me.yuriToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(736, 334)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(17, 12)
        Me.Label54.TabIndex = 169
        Me.Label54.Text = "～"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label55.Location = New System.Drawing.Point(700, 333)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(11, 12)
        Me.Label55.TabIndex = 168
        Me.Label55.Text = "："
        '
        'yuriFrmM
        '
        Me.yuriFrmM.Location = New System.Drawing.Point(711, 329)
        Me.yuriFrmM.Name = "yuriFrmM"
        Me.yuriFrmM.Size = New System.Drawing.Size(22, 19)
        Me.yuriFrmM.TabIndex = 167
        Me.yuriFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yuriFrmH
        '
        Me.yuriFrmH.Location = New System.Drawing.Point(676, 329)
        Me.yuriFrmH.Name = "yuriFrmH"
        Me.yuriFrmH.Size = New System.Drawing.Size(22, 19)
        Me.yuriFrmH.TabIndex = 166
        Me.yuriFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yuriCbo
        '
        Me.yuriCbo.FormattingEnabled = True
        Me.yuriCbo.Location = New System.Drawing.Point(718, 304)
        Me.yuriCbo.Name = "yuriCbo"
        Me.yuriCbo.Size = New System.Drawing.Size(94, 20)
        Me.yuriCbo.TabIndex = 165
        '
        'yuriChk4
        '
        Me.yuriChk4.AutoSize = True
        Me.yuriChk4.Location = New System.Drawing.Point(672, 306)
        Me.yuriChk4.Name = "yuriChk4"
        Me.yuriChk4.Size = New System.Drawing.Size(48, 16)
        Me.yuriChk4.TabIndex = 164
        Me.yuriChk4.Text = "外出"
        Me.yuriChk4.UseVisualStyleBackColor = True
        '
        'yuriChk3
        '
        Me.yuriChk3.AutoSize = True
        Me.yuriChk3.Location = New System.Drawing.Point(768, 284)
        Me.yuriChk3.Name = "yuriChk3"
        Me.yuriChk3.Size = New System.Drawing.Size(48, 16)
        Me.yuriChk3.TabIndex = 163
        Me.yuriChk3.Text = "入院"
        Me.yuriChk3.UseVisualStyleBackColor = True
        '
        'yuriChk2
        '
        Me.yuriChk2.AutoSize = True
        Me.yuriChk2.Location = New System.Drawing.Point(720, 284)
        Me.yuriChk2.Name = "yuriChk2"
        Me.yuriChk2.Size = New System.Drawing.Size(48, 16)
        Me.yuriChk2.TabIndex = 162
        Me.yuriChk2.Text = "外泊"
        Me.yuriChk2.UseVisualStyleBackColor = True
        '
        'yuriChk1
        '
        Me.yuriChk1.AutoSize = True
        Me.yuriChk1.Location = New System.Drawing.Point(672, 284)
        Me.yuriChk1.Name = "yuriChk1"
        Me.yuriChk1.Size = New System.Drawing.Size(48, 16)
        Me.yuriChk1.TabIndex = 161
        Me.yuriChk1.Text = "入浴"
        Me.yuriChk1.UseVisualStyleBackColor = True
        '
        'yuriNam
        '
        Me.yuriNam.AutoSize = True
        Me.yuriNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.yuriNam.ForeColor = System.Drawing.Color.Blue
        Me.yuriNam.Location = New System.Drawing.Point(668, 258)
        Me.yuriNam.Name = "yuriNam"
        Me.yuriNam.Size = New System.Drawing.Size(0, 19)
        Me.yuriNam.TabIndex = 160
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(668, 242)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(35, 12)
        Me.Label57.TabIndex = 159
        Me.Label57.Text = "【ゆり】"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label58.Location = New System.Drawing.Point(779, 451)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(11, 12)
        Me.Label58.TabIndex = 186
        Me.Label58.Text = "："
        '
        'yagurumaToM
        '
        Me.yagurumaToM.Location = New System.Drawing.Point(790, 447)
        Me.yagurumaToM.Name = "yagurumaToM"
        Me.yagurumaToM.Size = New System.Drawing.Size(22, 19)
        Me.yagurumaToM.TabIndex = 185
        Me.yagurumaToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yagurumaToH
        '
        Me.yagurumaToH.Location = New System.Drawing.Point(755, 447)
        Me.yagurumaToH.Name = "yagurumaToH"
        Me.yagurumaToH.Size = New System.Drawing.Size(22, 19)
        Me.yagurumaToH.TabIndex = 184
        Me.yagurumaToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(736, 452)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(17, 12)
        Me.Label59.TabIndex = 183
        Me.Label59.Text = "～"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label60.Location = New System.Drawing.Point(700, 451)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(11, 12)
        Me.Label60.TabIndex = 182
        Me.Label60.Text = "："
        '
        'yagurumaFrmM
        '
        Me.yagurumaFrmM.Location = New System.Drawing.Point(711, 447)
        Me.yagurumaFrmM.Name = "yagurumaFrmM"
        Me.yagurumaFrmM.Size = New System.Drawing.Size(22, 19)
        Me.yagurumaFrmM.TabIndex = 181
        Me.yagurumaFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yagurumaFrmH
        '
        Me.yagurumaFrmH.Location = New System.Drawing.Point(676, 447)
        Me.yagurumaFrmH.Name = "yagurumaFrmH"
        Me.yagurumaFrmH.Size = New System.Drawing.Size(22, 19)
        Me.yagurumaFrmH.TabIndex = 180
        Me.yagurumaFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yagurumaCbo
        '
        Me.yagurumaCbo.FormattingEnabled = True
        Me.yagurumaCbo.Location = New System.Drawing.Point(718, 422)
        Me.yagurumaCbo.Name = "yagurumaCbo"
        Me.yagurumaCbo.Size = New System.Drawing.Size(94, 20)
        Me.yagurumaCbo.TabIndex = 179
        '
        'yagurumaChk4
        '
        Me.yagurumaChk4.AutoSize = True
        Me.yagurumaChk4.Location = New System.Drawing.Point(672, 424)
        Me.yagurumaChk4.Name = "yagurumaChk4"
        Me.yagurumaChk4.Size = New System.Drawing.Size(48, 16)
        Me.yagurumaChk4.TabIndex = 178
        Me.yagurumaChk4.Text = "外出"
        Me.yagurumaChk4.UseVisualStyleBackColor = True
        '
        'yagurumaChk3
        '
        Me.yagurumaChk3.AutoSize = True
        Me.yagurumaChk3.Location = New System.Drawing.Point(768, 402)
        Me.yagurumaChk3.Name = "yagurumaChk3"
        Me.yagurumaChk3.Size = New System.Drawing.Size(48, 16)
        Me.yagurumaChk3.TabIndex = 177
        Me.yagurumaChk3.Text = "入院"
        Me.yagurumaChk3.UseVisualStyleBackColor = True
        '
        'yagurumaChk2
        '
        Me.yagurumaChk2.AutoSize = True
        Me.yagurumaChk2.Location = New System.Drawing.Point(720, 402)
        Me.yagurumaChk2.Name = "yagurumaChk2"
        Me.yagurumaChk2.Size = New System.Drawing.Size(48, 16)
        Me.yagurumaChk2.TabIndex = 176
        Me.yagurumaChk2.Text = "外泊"
        Me.yagurumaChk2.UseVisualStyleBackColor = True
        '
        'yagurumaChk1
        '
        Me.yagurumaChk1.AutoSize = True
        Me.yagurumaChk1.Location = New System.Drawing.Point(672, 402)
        Me.yagurumaChk1.Name = "yagurumaChk1"
        Me.yagurumaChk1.Size = New System.Drawing.Size(48, 16)
        Me.yagurumaChk1.TabIndex = 175
        Me.yagurumaChk1.Text = "入浴"
        Me.yagurumaChk1.UseVisualStyleBackColor = True
        '
        'yagurumaNam
        '
        Me.yagurumaNam.AutoSize = True
        Me.yagurumaNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.yagurumaNam.ForeColor = System.Drawing.Color.Blue
        Me.yagurumaNam.Location = New System.Drawing.Point(668, 376)
        Me.yagurumaNam.Name = "yagurumaNam"
        Me.yagurumaNam.Size = New System.Drawing.Size(0, 19)
        Me.yagurumaNam.TabIndex = 174
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(668, 360)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(53, 12)
        Me.Label62.TabIndex = 173
        Me.Label62.Text = "【やぐるま】"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label63.Location = New System.Drawing.Point(779, 569)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(11, 12)
        Me.Label63.TabIndex = 200
        Me.Label63.Text = "："
        '
        'kikyoToM
        '
        Me.kikyoToM.Location = New System.Drawing.Point(790, 565)
        Me.kikyoToM.Name = "kikyoToM"
        Me.kikyoToM.Size = New System.Drawing.Size(22, 19)
        Me.kikyoToM.TabIndex = 199
        Me.kikyoToM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kikyoToH
        '
        Me.kikyoToH.Location = New System.Drawing.Point(755, 565)
        Me.kikyoToH.Name = "kikyoToH"
        Me.kikyoToH.Size = New System.Drawing.Size(22, 19)
        Me.kikyoToH.TabIndex = 198
        Me.kikyoToH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(736, 570)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(17, 12)
        Me.Label64.TabIndex = 197
        Me.Label64.Text = "～"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label65.Location = New System.Drawing.Point(700, 569)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(11, 12)
        Me.Label65.TabIndex = 196
        Me.Label65.Text = "："
        '
        'kikyoFrmM
        '
        Me.kikyoFrmM.Location = New System.Drawing.Point(711, 565)
        Me.kikyoFrmM.Name = "kikyoFrmM"
        Me.kikyoFrmM.Size = New System.Drawing.Size(22, 19)
        Me.kikyoFrmM.TabIndex = 195
        Me.kikyoFrmM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kikyoFrmH
        '
        Me.kikyoFrmH.Location = New System.Drawing.Point(676, 565)
        Me.kikyoFrmH.Name = "kikyoFrmH"
        Me.kikyoFrmH.Size = New System.Drawing.Size(22, 19)
        Me.kikyoFrmH.TabIndex = 194
        Me.kikyoFrmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kikyoCbo
        '
        Me.kikyoCbo.FormattingEnabled = True
        Me.kikyoCbo.Location = New System.Drawing.Point(718, 540)
        Me.kikyoCbo.Name = "kikyoCbo"
        Me.kikyoCbo.Size = New System.Drawing.Size(94, 20)
        Me.kikyoCbo.TabIndex = 193
        '
        'kikyoChk4
        '
        Me.kikyoChk4.AutoSize = True
        Me.kikyoChk4.Location = New System.Drawing.Point(672, 542)
        Me.kikyoChk4.Name = "kikyoChk4"
        Me.kikyoChk4.Size = New System.Drawing.Size(48, 16)
        Me.kikyoChk4.TabIndex = 192
        Me.kikyoChk4.Text = "外出"
        Me.kikyoChk4.UseVisualStyleBackColor = True
        '
        'kikyoChk3
        '
        Me.kikyoChk3.AutoSize = True
        Me.kikyoChk3.Location = New System.Drawing.Point(768, 520)
        Me.kikyoChk3.Name = "kikyoChk3"
        Me.kikyoChk3.Size = New System.Drawing.Size(48, 16)
        Me.kikyoChk3.TabIndex = 191
        Me.kikyoChk3.Text = "入院"
        Me.kikyoChk3.UseVisualStyleBackColor = True
        '
        'kikyoChk2
        '
        Me.kikyoChk2.AutoSize = True
        Me.kikyoChk2.Location = New System.Drawing.Point(720, 520)
        Me.kikyoChk2.Name = "kikyoChk2"
        Me.kikyoChk2.Size = New System.Drawing.Size(48, 16)
        Me.kikyoChk2.TabIndex = 190
        Me.kikyoChk2.Text = "外泊"
        Me.kikyoChk2.UseVisualStyleBackColor = True
        '
        'kikyoChk1
        '
        Me.kikyoChk1.AutoSize = True
        Me.kikyoChk1.Location = New System.Drawing.Point(672, 520)
        Me.kikyoChk1.Name = "kikyoChk1"
        Me.kikyoChk1.Size = New System.Drawing.Size(48, 16)
        Me.kikyoChk1.TabIndex = 189
        Me.kikyoChk1.Text = "入浴"
        Me.kikyoChk1.UseVisualStyleBackColor = True
        '
        'kikyoNam
        '
        Me.kikyoNam.AutoSize = True
        Me.kikyoNam.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.kikyoNam.ForeColor = System.Drawing.Color.Blue
        Me.kikyoNam.Location = New System.Drawing.Point(668, 494)
        Me.kikyoNam.Name = "kikyoNam"
        Me.kikyoNam.Size = New System.Drawing.Size(0, 19)
        Me.kikyoNam.TabIndex = 188
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(668, 478)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(49, 12)
        Me.Label67.TabIndex = 187
        Me.Label67.Text = "【ききょう】"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.Color.Blue
        Me.Label68.Location = New System.Drawing.Point(40, 625)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(159, 12)
        Me.Label68.TabIndex = 201
        Me.Label68.Text = "※　時間は【半角・24時間制】で"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.Color.Blue
        Me.Label69.Location = New System.Drawing.Point(40, 640)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(141, 12)
        Me.Label69.TabIndex = 202
        Me.Label69.Text = "入力して下さい（例/  15:09）"
        '
        'ハウス日誌
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.kikyoToM)
        Me.Controls.Add(Me.kikyoToH)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.kikyoFrmM)
        Me.Controls.Add(Me.kikyoFrmH)
        Me.Controls.Add(Me.kikyoCbo)
        Me.Controls.Add(Me.kikyoChk4)
        Me.Controls.Add(Me.kikyoChk3)
        Me.Controls.Add(Me.kikyoChk2)
        Me.Controls.Add(Me.kikyoChk1)
        Me.Controls.Add(Me.kikyoNam)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.yagurumaToM)
        Me.Controls.Add(Me.yagurumaToH)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.yagurumaFrmM)
        Me.Controls.Add(Me.yagurumaFrmH)
        Me.Controls.Add(Me.yagurumaCbo)
        Me.Controls.Add(Me.yagurumaChk4)
        Me.Controls.Add(Me.yagurumaChk3)
        Me.Controls.Add(Me.yagurumaChk2)
        Me.Controls.Add(Me.yagurumaChk1)
        Me.Controls.Add(Me.yagurumaNam)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.yuriToM)
        Me.Controls.Add(Me.yuriToH)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.yuriFrmM)
        Me.Controls.Add(Me.yuriFrmH)
        Me.Controls.Add(Me.yuriCbo)
        Me.Controls.Add(Me.yuriChk4)
        Me.Controls.Add(Me.yuriChk3)
        Me.Controls.Add(Me.yuriChk2)
        Me.Controls.Add(Me.yuriChk1)
        Me.Controls.Add(Me.yuriNam)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.himawariToM)
        Me.Controls.Add(Me.himawariToH)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.himawariFrmM)
        Me.Controls.Add(Me.himawariFrmH)
        Me.Controls.Add(Me.himawariCbo)
        Me.Controls.Add(Me.himawariChk4)
        Me.Controls.Add(Me.himawariChk3)
        Me.Controls.Add(Me.himawariChk2)
        Me.Controls.Add(Me.himawariChk1)
        Me.Controls.Add(Me.himawariNam)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.botanToM)
        Me.Controls.Add(Me.botanToH)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.botanFrmM)
        Me.Controls.Add(Me.botanFrmH)
        Me.Controls.Add(Me.botanCbo)
        Me.Controls.Add(Me.botanChk4)
        Me.Controls.Add(Me.botanChk3)
        Me.Controls.Add(Me.botanChk2)
        Me.Controls.Add(Me.botanChk1)
        Me.Controls.Add(Me.botanNam)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.nadesikoToM)
        Me.Controls.Add(Me.nadesikoToH)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.nadesikoFrmM)
        Me.Controls.Add(Me.nadesikoFrmH)
        Me.Controls.Add(Me.nadesikoCbo)
        Me.Controls.Add(Me.nadesikoChk4)
        Me.Controls.Add(Me.nadesikoChk3)
        Me.Controls.Add(Me.nadesikoChk2)
        Me.Controls.Add(Me.nadesikoChk1)
        Me.Controls.Add(Me.nadesikoNam)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.hujiToM)
        Me.Controls.Add(Me.hujiToH)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.hujiFrmM)
        Me.Controls.Add(Me.hujiFrmH)
        Me.Controls.Add(Me.hujiCbo)
        Me.Controls.Add(Me.hujiChk4)
        Me.Controls.Add(Me.hujiChk3)
        Me.Controls.Add(Me.hujiChk2)
        Me.Controls.Add(Me.hujiChk1)
        Me.Controls.Add(Me.hujiNam)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.ayameToM)
        Me.Controls.Add(Me.ayameToH)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.ayameFrmM)
        Me.Controls.Add(Me.ayameFrmH)
        Me.Controls.Add(Me.ayameCbo)
        Me.Controls.Add(Me.ayameChk4)
        Me.Controls.Add(Me.ayameChk3)
        Me.Controls.Add(Me.ayameChk2)
        Me.Controls.Add(Me.ayameChk1)
        Me.Controls.Add(Me.ayameNam)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.suisenToM)
        Me.Controls.Add(Me.suisenToH)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.suisenFrmM)
        Me.Controls.Add(Me.suisenFrmH)
        Me.Controls.Add(Me.suisenCbo)
        Me.Controls.Add(Me.suisenChk4)
        Me.Controls.Add(Me.suisenChk3)
        Me.Controls.Add(Me.suisenChk2)
        Me.Controls.Add(Me.suisenChk1)
        Me.Controls.Add(Me.suisenNam)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.hamanasuToM)
        Me.Controls.Add(Me.hamanasuToH)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.hamanasuFrmM)
        Me.Controls.Add(Me.hamanasuFrmH)
        Me.Controls.Add(Me.hamanasuCbo)
        Me.Controls.Add(Me.hamanasuChk4)
        Me.Controls.Add(Me.hamanasuChk3)
        Me.Controls.Add(Me.hamanasuChk2)
        Me.Controls.Add(Me.hamanasuChk1)
        Me.Controls.Add(Me.hamanasuNam)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ajisaiToM)
        Me.Controls.Add(Me.ajisaiToH)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ajisaiFrmM)
        Me.Controls.Add(Me.ajisaiFrmH)
        Me.Controls.Add(Me.ajisaiCbo)
        Me.Controls.Add(Me.ajisaiChk4)
        Me.Controls.Add(Me.ajisaiChk3)
        Me.Controls.Add(Me.ajisaiChk2)
        Me.Controls.Add(Me.ajisaiChk1)
        Me.Controls.Add(Me.ajisaiNam)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.sakuraToM)
        Me.Controls.Add(Me.sakuraToH)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.sakuraFrmM)
        Me.Controls.Add(Me.sakuraFrmH)
        Me.Controls.Add(Me.sakuraCbo)
        Me.Controls.Add(Me.sakuraChk4)
        Me.Controls.Add(Me.sakuraChk3)
        Me.Controls.Add(Me.sakuraChk2)
        Me.Controls.Add(Me.sakuraChk1)
        Me.Controls.Add(Me.sakuraNam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvKikyo)
        Me.Controls.Add(Me.dgvYaguruma)
        Me.Controls.Add(Me.dgvYuri)
        Me.Controls.Add(Me.dgvHamanasu)
        Me.Controls.Add(Me.dgvHimawari)
        Me.Controls.Add(Me.dgvBotan)
        Me.Controls.Add(Me.dgvNadesiko)
        Me.Controls.Add(Me.dgvAjisai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvHuji)
        Me.Controls.Add(Me.dgvAyame)
        Me.Controls.Add(Me.dgvSuisen)
        Me.Controls.Add(Me.dgvSakura)
        Me.Controls.Add(Me.dgvRen)
        Me.Controls.Add(Me.dgvZen)
        Me.Controls.Add(Me.btnSealSet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtnYm)
        Me.Controls.Add(Me.rbtnYmd)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.weatherBox)
        Me.Controls.Add(Me.YmdBox)
        Me.Name = "ハウス日誌"
        Me.Text = "生活支援ハウス業務日誌"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSakura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSuisen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHuji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAyame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHimawari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBotan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNadesiko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAjisai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKikyo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvYaguruma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvYuri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHamanasu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YmdBox As ymdBox.ymdBox
    Friend WithEvents weatherBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegist As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents rbtnYmd As RadioButton
    Friend WithEvents rbtnYm As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSealSet As Button
    Friend WithEvents dgvZen As DataGridView
    Friend WithEvents dgvRen As DataGridView
    Friend WithEvents dgvSakura As DataGridView
    Friend WithEvents dgvSuisen As DataGridView
    Friend WithEvents dgvHuji As DataGridView
    Friend WithEvents dgvAyame As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvHimawari As DataGridView
    Friend WithEvents dgvBotan As DataGridView
    Friend WithEvents dgvNadesiko As DataGridView
    Friend WithEvents dgvAjisai As DataGridView
    Friend WithEvents dgvKikyo As DataGridView
    Friend WithEvents dgvYaguruma As DataGridView
    Friend WithEvents dgvYuri As DataGridView
    Friend WithEvents dgvHamanasu As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents sakuraNam As Label
    Friend WithEvents sakuraChk1 As CheckBox
    Friend WithEvents sakuraChk2 As CheckBox
    Friend WithEvents sakuraChk3 As CheckBox
    Friend WithEvents sakuraChk4 As CheckBox
    Friend WithEvents sakuraCbo As ComboBox
    Friend WithEvents sakuraFrmH As TextBox
    Friend WithEvents sakuraFrmM As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents sakuraToM As TextBox
    Friend WithEvents sakuraToH As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ajisaiToM As TextBox
    Friend WithEvents ajisaiToH As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ajisaiFrmM As TextBox
    Friend WithEvents ajisaiFrmH As TextBox
    Friend WithEvents ajisaiCbo As ComboBox
    Friend WithEvents ajisaiChk4 As CheckBox
    Friend WithEvents ajisaiChk3 As CheckBox
    Friend WithEvents ajisaiChk2 As CheckBox
    Friend WithEvents ajisaiChk1 As CheckBox
    Friend WithEvents ajisaiNam As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents hamanasuToM As TextBox
    Friend WithEvents hamanasuToH As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents hamanasuFrmM As TextBox
    Friend WithEvents hamanasuFrmH As TextBox
    Friend WithEvents hamanasuCbo As ComboBox
    Friend WithEvents hamanasuChk4 As CheckBox
    Friend WithEvents hamanasuChk3 As CheckBox
    Friend WithEvents hamanasuChk2 As CheckBox
    Friend WithEvents hamanasuChk1 As CheckBox
    Friend WithEvents hamanasuNam As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents suisenToM As TextBox
    Friend WithEvents suisenToH As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents suisenFrmM As TextBox
    Friend WithEvents suisenFrmH As TextBox
    Friend WithEvents suisenCbo As ComboBox
    Friend WithEvents suisenChk4 As CheckBox
    Friend WithEvents suisenChk3 As CheckBox
    Friend WithEvents suisenChk2 As CheckBox
    Friend WithEvents suisenChk1 As CheckBox
    Friend WithEvents suisenNam As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ayameToM As TextBox
    Friend WithEvents ayameToH As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents ayameFrmM As TextBox
    Friend WithEvents ayameFrmH As TextBox
    Friend WithEvents ayameCbo As ComboBox
    Friend WithEvents ayameChk4 As CheckBox
    Friend WithEvents ayameChk3 As CheckBox
    Friend WithEvents ayameChk2 As CheckBox
    Friend WithEvents ayameChk1 As CheckBox
    Friend WithEvents ayameNam As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents hujiToM As TextBox
    Friend WithEvents hujiToH As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents hujiFrmM As TextBox
    Friend WithEvents hujiFrmH As TextBox
    Friend WithEvents hujiCbo As ComboBox
    Friend WithEvents hujiChk4 As CheckBox
    Friend WithEvents hujiChk3 As CheckBox
    Friend WithEvents hujiChk2 As CheckBox
    Friend WithEvents hujiChk1 As CheckBox
    Friend WithEvents hujiNam As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents nadesikoToM As TextBox
    Friend WithEvents nadesikoToH As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents nadesikoFrmM As TextBox
    Friend WithEvents nadesikoFrmH As TextBox
    Friend WithEvents nadesikoCbo As ComboBox
    Friend WithEvents nadesikoChk4 As CheckBox
    Friend WithEvents nadesikoChk3 As CheckBox
    Friend WithEvents nadesikoChk2 As CheckBox
    Friend WithEvents nadesikoChk1 As CheckBox
    Friend WithEvents nadesikoNam As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents botanToM As TextBox
    Friend WithEvents botanToH As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents botanFrmM As TextBox
    Friend WithEvents botanFrmH As TextBox
    Friend WithEvents botanCbo As ComboBox
    Friend WithEvents botanChk4 As CheckBox
    Friend WithEvents botanChk3 As CheckBox
    Friend WithEvents botanChk2 As CheckBox
    Friend WithEvents botanChk1 As CheckBox
    Friend WithEvents botanNam As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents himawariToM As TextBox
    Friend WithEvents himawariToH As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents himawariFrmM As TextBox
    Friend WithEvents himawariFrmH As TextBox
    Friend WithEvents himawariCbo As ComboBox
    Friend WithEvents himawariChk4 As CheckBox
    Friend WithEvents himawariChk3 As CheckBox
    Friend WithEvents himawariChk2 As CheckBox
    Friend WithEvents himawariChk1 As CheckBox
    Friend WithEvents himawariNam As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents yuriToM As TextBox
    Friend WithEvents yuriToH As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents yuriFrmM As TextBox
    Friend WithEvents yuriFrmH As TextBox
    Friend WithEvents yuriCbo As ComboBox
    Friend WithEvents yuriChk4 As CheckBox
    Friend WithEvents yuriChk3 As CheckBox
    Friend WithEvents yuriChk2 As CheckBox
    Friend WithEvents yuriChk1 As CheckBox
    Friend WithEvents yuriNam As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents yagurumaToM As TextBox
    Friend WithEvents yagurumaToH As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents yagurumaFrmM As TextBox
    Friend WithEvents yagurumaFrmH As TextBox
    Friend WithEvents yagurumaCbo As ComboBox
    Friend WithEvents yagurumaChk4 As CheckBox
    Friend WithEvents yagurumaChk3 As CheckBox
    Friend WithEvents yagurumaChk2 As CheckBox
    Friend WithEvents yagurumaChk1 As CheckBox
    Friend WithEvents yagurumaNam As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents kikyoToM As TextBox
    Friend WithEvents kikyoToH As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents kikyoFrmM As TextBox
    Friend WithEvents kikyoFrmH As TextBox
    Friend WithEvents kikyoCbo As ComboBox
    Friend WithEvents kikyoChk4 As CheckBox
    Friend WithEvents kikyoChk3 As CheckBox
    Friend WithEvents kikyoChk2 As CheckBox
    Friend WithEvents kikyoChk1 As CheckBox
    Friend WithEvents kikyoNam As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
End Class
