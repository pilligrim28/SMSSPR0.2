<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panmenu = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dvSpr = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SprDataSet = New SMSSPR0._2.sprDataSet()
        Me.SmsprBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmsprTableAdapter = New SMSSPR0._2.sprDataSetTableAdapters.smsprTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panmenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dvSpr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SprDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsprBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 57)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(1222, 0)
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
        Me.Label1.Size = New System.Drawing.Size(346, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Справочник СЦ СМ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 824)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1290, 42)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(12, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 36)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "МЕНЮ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'panmenu
        '
        Me.panmenu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panmenu.Controls.Add(Me.Button5)
        Me.panmenu.Controls.Add(Me.Button4)
        Me.panmenu.Controls.Add(Me.Button3)
        Me.panmenu.Controls.Add(Me.Label2)
        Me.panmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panmenu.Location = New System.Drawing.Point(0, 57)
        Me.panmenu.Name = "panmenu"
        Me.panmenu.Size = New System.Drawing.Size(273, 767)
        Me.panmenu.TabIndex = 2
        Me.panmenu.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(54, 254)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 56)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Удалить"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(54, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 56)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Изменить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(54, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 56)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "МЕНЮ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.dvSpr)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(273, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1017, 767)
        Me.Panel3.TabIndex = 5
        '
        'dvSpr
        '
        Me.dvSpr.AllowUserToAddRows = False
        Me.dvSpr.AllowUserToDeleteRows = False
        Me.dvSpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvSpr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dvSpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvSpr.DefaultCellStyle = DataGridViewCellStyle1
        Me.dvSpr.Dock = System.Windows.Forms.DockStyle.Left
        Me.dvSpr.Location = New System.Drawing.Point(0, 0)
        Me.dvSpr.Name = "dvSpr"
        Me.dvSpr.ReadOnly = True
        Me.dvSpr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvSpr.Size = New System.Drawing.Size(727, 767)
        Me.dvSpr.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(749, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SprDataSet
        '
        Me.SprDataSet.DataSetName = "sprDataSet"
        Me.SprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SmsprBindingSource
        '
        Me.SmsprBindingSource.DataMember = "smspr"
        Me.SmsprBindingSource.DataSource = Me.SprDataSet
        '
        'SmsprTableAdapter
        '
        Me.SmsprTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 866)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panmenu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panmenu.ResumeLayout(False)
        Me.panmenu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dvSpr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SprDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsprBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Protected Friend WithEvents Button2 As Button
    Friend WithEvents panmenu As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dvSpr As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SprDataSet As sprDataSet
    Friend WithEvents SmsprBindingSource As BindingSource
    Friend WithEvents SmsprTableAdapter As sprDataSetTableAdapters.smsprTableAdapter
End Class
