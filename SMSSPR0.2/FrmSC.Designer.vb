<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSC
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim KodLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim TmLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSC))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KodTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dvSpr = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TmComboBox = New System.Windows.Forms.ComboBox()
        KodLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        TmLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvSpr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodLabel
        '
        KodLabel.AutoSize = True
        KodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        KodLabel.Location = New System.Drawing.Point(29, 86)
        KodLabel.Name = "KodLabel"
        KodLabel.Size = New System.Drawing.Size(42, 20)
        KodLabel.TabIndex = 3
        KodLabel.Text = "Код"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        NameLabel.Location = New System.Drawing.Point(29, 144)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(134, 20)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Наименование"
        '
        'TmLabel
        '
        TmLabel.AutoSize = True
        TmLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TmLabel.Location = New System.Drawing.Point(29, 187)
        TmLabel.Name = "TmLabel"
        TmLabel.Size = New System.Drawing.Size(145, 20)
        TmLabel.TabIndex = 7
        TmLabel.Text = "Торговая Марка"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ImageLabel.Location = New System.Drawing.Point(29, 231)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(55, 20)
        ImageLabel.TabIndex = 9
        ImageLabel.Text = "Фото"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 57)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(1052, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Добавление СЦ СМ"
        '
        'KodTextBox
        '
        Me.KodTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.KodTextBox.Location = New System.Drawing.Point(208, 86)
        Me.KodTextBox.Name = "KodTextBox"
        Me.KodTextBox.Size = New System.Drawing.Size(380, 26)
        Me.KodTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(208, 138)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(380, 26)
        Me.NameTextBox.TabIndex = 6
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(208, 234)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(380, 209)
        Me.ImagePictureBox.TabIndex = 10
        Me.ImagePictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(208, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 41)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Добавить"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dvSpr
        '
        Me.dvSpr.AllowUserToAddRows = False
        Me.dvSpr.AllowUserToDeleteRows = False
        Me.dvSpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvSpr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvSpr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvSpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvSpr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Edit, Me.ColDel})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvSpr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dvSpr.Dock = System.Windows.Forms.DockStyle.Right
        Me.dvSpr.Location = New System.Drawing.Point(608, 57)
        Me.dvSpr.Name = "dvSpr"
        Me.dvSpr.ReadOnly = True
        Me.dvSpr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvSpr.Size = New System.Drawing.Size(512, 488)
        Me.dvSpr.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Код"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Наименование"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 108
        '
        'Column3
        '
        Me.Column3.HeaderText = "Торговая марка"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.HeaderText = "Изменить"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        '
        'ColDel
        '
        Me.ColDel.HeaderText = "Delete"
        Me.ColDel.Name = "ColDel"
        Me.ColDel.ReadOnly = True
        '
        'TmComboBox
        '
        Me.TmComboBox.FormattingEnabled = True
        Me.TmComboBox.Items.AddRange(New Object() {"Prosharp", "Metabo", "ЗУБР", "Интерскол", "Swix", "Amico", "КРАТОН", "PATRIOT", "Wintersteiger", "NILFISK", "QBL", "Reichmann"})
        Me.TmComboBox.Location = New System.Drawing.Point(208, 186)
        Me.TmComboBox.Name = "TmComboBox"
        Me.TmComboBox.Size = New System.Drawing.Size(380, 21)
        Me.TmComboBox.TabIndex = 14
        '
        'FrmSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 545)
        Me.Controls.Add(Me.TmComboBox)
        Me.Controls.Add(Me.dvSpr)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(KodLabel)
        Me.Controls.Add(Me.KodTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(TmLabel)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvSpr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents KodTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents dvSpr As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
    Friend WithEvents TmComboBox As ComboBox
End Class
