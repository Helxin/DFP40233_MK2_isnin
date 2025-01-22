<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maklumat_Pelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtNoTelefon = New TextBox()
        lblNoTelefon = New Label()
        cmbNegeri = New ComboBox()
        lblNegeri = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        gpbJantina = New GroupBox()
        rdoPerempuan = New RadioButton()
        rdoLelaki = New RadioButton()
        gpbKaedahPembayaran = New GroupBox()
        rdoCashless = New RadioButton()
        rdoCash = New RadioButton()
        ckbMilo = New CheckBox()
        gpbPerisa = New GroupBox()
        ckbPisang = New CheckBox()
        ckbStrawberri = New CheckBox()
        ckbKopi = New CheckBox()
        dtpTarikh = New DateTimePicker()
        dgvStatistik = New DataGridView()
        btnCreate = New Button()
        btnUpdate = New Button()
        btnRead = New Button()
        btnDelete = New Button()
        Label4 = New Label()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNoTelefon = New DataGridViewTextBoxColumn()
        gpbJantina.SuspendLayout()
        gpbKaedahPembayaran.SuspendLayout()
        gpbPerisa.SuspendLayout()
        CType(dgvStatistik, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(43, 111)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(117, 111)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(406, 31)
        txtNama.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(117, 163)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(406, 161)
        txtAlamat.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(43, 163)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 2
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNoTelefon
        ' 
        txtNoTelefon.Location = New Point(117, 344)
        txtNoTelefon.Name = "txtNoTelefon"
        txtNoTelefon.Size = New Size(406, 31)
        txtNoTelefon.TabIndex = 5
        ' 
        ' lblNoTelefon
        ' 
        lblNoTelefon.AutoSize = True
        lblNoTelefon.Location = New Point(10, 344)
        lblNoTelefon.Name = "lblNoTelefon"
        lblNoTelefon.Size = New Size(101, 25)
        lblNoTelefon.TabIndex = 4
        lblNoTelefon.Text = "No. Telefon"
        ' 
        ' cmbNegeri
        ' 
        cmbNegeri.FormattingEnabled = True
        cmbNegeri.Items.AddRange(New Object() {"Johor  ", "Negeri Perak  ", "Negeri Melaka  ", "Negeri Sembilan  ", "Pulau Pinang  ", "Sabah  ", "Kedah  ", "Selangor  ", "Perlis  ", "Sarawak  ", "Pahang  ", "Terengganu  ", "Kelantan  ", "Labuan  "})
        cmbNegeri.Location = New Point(117, 406)
        cmbNegeri.Name = "cmbNegeri"
        cmbNegeri.Size = New Size(182, 33)
        cmbNegeri.TabIndex = 6
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(10, 406)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(64, 25)
        lblNegeri.TabIndex = 7
        lblNegeri.Text = "Negeri"
        ' 
        ' gpbJantina
        ' 
        gpbJantina.Controls.Add(rdoPerempuan)
        gpbJantina.Controls.Add(rdoLelaki)
        gpbJantina.Location = New Point(572, 111)
        gpbJantina.Name = "gpbJantina"
        gpbJantina.Size = New Size(300, 150)
        gpbJantina.TabIndex = 8
        gpbJantina.TabStop = False
        gpbJantina.Text = "Jantina"
        ' 
        ' rdoPerempuan
        ' 
        rdoPerempuan.AutoSize = True
        rdoPerempuan.Location = New Point(19, 92)
        rdoPerempuan.Name = "rdoPerempuan"
        rdoPerempuan.Size = New Size(126, 29)
        rdoPerempuan.TabIndex = 1
        rdoPerempuan.TabStop = True
        rdoPerempuan.Text = "Perempuan"
        rdoPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdoLelaki
        ' 
        rdoLelaki.AutoSize = True
        rdoLelaki.Location = New Point(19, 48)
        rdoLelaki.Name = "rdoLelaki"
        rdoLelaki.Size = New Size(80, 29)
        rdoLelaki.TabIndex = 0
        rdoLelaki.TabStop = True
        rdoLelaki.Text = "Lelaki"
        rdoLelaki.UseVisualStyleBackColor = True
        ' 
        ' gpbKaedahPembayaran
        ' 
        gpbKaedahPembayaran.Controls.Add(rdoCashless)
        gpbKaedahPembayaran.Controls.Add(rdoCash)
        gpbKaedahPembayaran.Location = New Point(572, 289)
        gpbKaedahPembayaran.Name = "gpbKaedahPembayaran"
        gpbKaedahPembayaran.Size = New Size(300, 150)
        gpbKaedahPembayaran.TabIndex = 9
        gpbKaedahPembayaran.TabStop = False
        gpbKaedahPembayaran.Text = "Kaedah Pembayaran"
        ' 
        ' rdoCashless
        ' 
        rdoCashless.AutoSize = True
        rdoCashless.Location = New Point(19, 92)
        rdoCashless.Name = "rdoCashless"
        rdoCashless.Size = New Size(104, 29)
        rdoCashless.TabIndex = 1
        rdoCashless.TabStop = True
        rdoCashless.Text = "Cashless"
        rdoCashless.UseVisualStyleBackColor = True
        ' 
        ' rdoCash
        ' 
        rdoCash.AutoSize = True
        rdoCash.Location = New Point(19, 48)
        rdoCash.Name = "rdoCash"
        rdoCash.Size = New Size(75, 29)
        rdoCash.TabIndex = 0
        rdoCash.TabStop = True
        rdoCash.Text = "Cash"
        rdoCash.UseVisualStyleBackColor = True
        ' 
        ' ckbMilo
        ' 
        ckbMilo.AutoSize = True
        ckbMilo.Location = New Point(19, 46)
        ckbMilo.Name = "ckbMilo"
        ckbMilo.Size = New Size(73, 29)
        ckbMilo.TabIndex = 10
        ckbMilo.Text = "Milo"
        ckbMilo.UseVisualStyleBackColor = True
        ' 
        ' gpbPerisa
        ' 
        gpbPerisa.Controls.Add(ckbPisang)
        gpbPerisa.Controls.Add(ckbStrawberri)
        gpbPerisa.Controls.Add(ckbKopi)
        gpbPerisa.Controls.Add(ckbMilo)
        gpbPerisa.Location = New Point(897, 111)
        gpbPerisa.Name = "gpbPerisa"
        gpbPerisa.Size = New Size(300, 150)
        gpbPerisa.TabIndex = 11
        gpbPerisa.TabStop = False
        gpbPerisa.Text = "Perisa"
        ' 
        ' ckbPisang
        ' 
        ckbPisang.AutoSize = True
        ckbPisang.Location = New Point(149, 97)
        ckbPisang.Name = "ckbPisang"
        ckbPisang.Size = New Size(90, 29)
        ckbPisang.TabIndex = 13
        ckbPisang.Text = "Pisang"
        ckbPisang.UseVisualStyleBackColor = True
        ' 
        ' ckbStrawberri
        ' 
        ckbStrawberri.AutoSize = True
        ckbStrawberri.Location = New Point(149, 46)
        ckbStrawberri.Name = "ckbStrawberri"
        ckbStrawberri.Size = New Size(117, 29)
        ckbStrawberri.TabIndex = 12
        ckbStrawberri.Text = "Strawberri"
        ckbStrawberri.UseVisualStyleBackColor = True
        ' 
        ' ckbKopi
        ' 
        ckbKopi.AutoSize = True
        ckbKopi.Location = New Point(19, 97)
        ckbKopi.Name = "ckbKopi"
        ckbKopi.Size = New Size(74, 29)
        ckbKopi.TabIndex = 11
        ckbKopi.Text = "Kopi"
        ckbKopi.UseVisualStyleBackColor = True
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(897, 289)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(300, 31)
        dtpTarikh.TabIndex = 12
        ' 
        ' dgvStatistik
        ' 
        dgvStatistik.AllowUserToOrderColumns = True
        dgvStatistik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStatistik.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNoTelefon})
        dgvStatistik.Location = New Point(572, 465)
        dgvStatistik.Name = "dgvStatistik"
        dgvStatistik.RowHeadersWidth = 62
        dgvStatistik.Size = New Size(625, 334)
        dgvStatistik.TabIndex = 13
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(117, 500)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(112, 34)
        btnCreate.TabIndex = 14
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(117, 540)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(235, 500)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(112, 34)
        btnRead.TabIndex = 16
        btnRead.Text = "Read"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(235, 540)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(257, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(636, 65)
        Label4.TabIndex = 18
        Label4.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' clmBil
        ' 
        clmBil.HeaderText = "Bil"
        clmBil.MinimumWidth = 8
        clmBil.Name = "clmBil"
        clmBil.Width = 150
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "Nama"
        clmNama.MinimumWidth = 8
        clmNama.Name = "clmNama"
        clmNama.Width = 150
        ' 
        ' clmNoTelefon
        ' 
        clmNoTelefon.HeaderText = "No. Telefon"
        clmNoTelefon.MinimumWidth = 8
        clmNoTelefon.Name = "clmNoTelefon"
        clmNoTelefon.Width = 150
        ' 
        ' Maklumat_Pelanggan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1235, 870)
        Controls.Add(Label4)
        Controls.Add(btnDelete)
        Controls.Add(btnRead)
        Controls.Add(btnUpdate)
        Controls.Add(btnCreate)
        Controls.Add(dgvStatistik)
        Controls.Add(dtpTarikh)
        Controls.Add(gpbPerisa)
        Controls.Add(gpbKaedahPembayaran)
        Controls.Add(gpbJantina)
        Controls.Add(lblNegeri)
        Controls.Add(cmbNegeri)
        Controls.Add(txtNoTelefon)
        Controls.Add(lblNoTelefon)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Maklumat_Pelanggan"
        Text = "Maklumat Pelanggan"
        gpbJantina.ResumeLayout(False)
        gpbJantina.PerformLayout()
        gpbKaedahPembayaran.ResumeLayout(False)
        gpbKaedahPembayaran.PerformLayout()
        gpbPerisa.ResumeLayout(False)
        gpbPerisa.PerformLayout()
        CType(dgvStatistik, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNoTelefon As TextBox
    Friend WithEvents lblNoTelefon As Label
    Friend WithEvents cmbNegeri As ComboBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gpbJantina As GroupBox
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents rdoLelaki As RadioButton
    Friend WithEvents gpbKaedahPembayaran As GroupBox
    Friend WithEvents rdoCashless As RadioButton
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents gpbPerisa As GroupBox
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents ckbStrawberri As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvStatistik As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNoTelefon As DataGridViewTextBoxColumn
End Class
