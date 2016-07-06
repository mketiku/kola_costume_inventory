<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblUsername As System.Windows.Forms.Label
        Dim lblPassword As System.Windows.Forms.Label
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.LogonDataSet = New Costume_Manager_V6_.LogonDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Costume_Manager_V6_.LogonDataSetTableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New Costume_Manager_V6_.LogonDataSetTableAdapters.TableAdapterManager()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        lblUsername = New System.Windows.Forms.Label()
        lblPassword = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(8, 142)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(57, 23)
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "Sign In:"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(lblUsername)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign In"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(76, 142)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(60, 23)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(147, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'LogonDataSet
        '
        Me.LogonDataSet.DataSetName = "LogonDataSet"
        Me.LogonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.LogonDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = Costume_Manager_V6_.LogonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblUsername
        '
        lblUsername.AutoSize = True
        lblUsername.Location = New System.Drawing.Point(11, 27)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New System.Drawing.Size(58, 13)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Username", True))
        Me.txtUsername.Location = New System.Drawing.Point(75, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblPassword
        '
        lblPassword.AutoSize = True
        lblPassword.Location = New System.Drawing.Point(13, 57)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New System.Drawing.Size(56, 13)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(75, 54)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(223, 177)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSignIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LogonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TableAdapterManager As LogonDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginTableAdapter As LogonDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LogonDataSet As LogonDataSet
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
