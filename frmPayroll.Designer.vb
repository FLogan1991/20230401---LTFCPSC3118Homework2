<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHeader2 = New System.Windows.Forms.Label()
        Me.lblHeader3 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblFICAdesc = New System.Windows.Forms.Label()
        Me.lblFedTaxDesc = New System.Windows.Forms.Label()
        Me.lblStateTaxDesc = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNetPayDesc = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGross = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(355, 36)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(283, 34)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Payroll Calculator"
        '
        'lblHeader2
        '
        Me.lblHeader2.AutoSize = True
        Me.lblHeader2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader2.Location = New System.Drawing.Point(432, 92)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.Size = New System.Drawing.Size(111, 24)
        Me.lblHeader2.TabIndex = 2
        Me.lblHeader2.Text = "Paycheck"
        Me.lblHeader2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeader3
        '
        Me.lblHeader3.AutoSize = True
        Me.lblHeader3.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader3.Location = New System.Drawing.Point(420, 127)
        Me.lblHeader3.Name = "lblHeader3"
        Me.lblHeader3.Size = New System.Drawing.Size(132, 24)
        Me.lblHeader3.TabIndex = 3
        Me.lblHeader3.Text = "Calculation"
        Me.lblHeader3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrossPay.Location = New System.Drawing.Point(182, 256)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(173, 24)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'lblFICAdesc
        '
        Me.lblFICAdesc.AutoSize = True
        Me.lblFICAdesc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFICAdesc.Location = New System.Drawing.Point(105, 344)
        Me.lblFICAdesc.Name = "lblFICAdesc"
        Me.lblFICAdesc.Size = New System.Drawing.Size(43, 16)
        Me.lblFICAdesc.TabIndex = 5
        Me.lblFICAdesc.Text = "FICA:"
        '
        'lblFedTaxDesc
        '
        Me.lblFedTaxDesc.AutoSize = True
        Me.lblFedTaxDesc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFedTaxDesc.Location = New System.Drawing.Point(224, 344)
        Me.lblFedTaxDesc.Name = "lblFedTaxDesc"
        Me.lblFedTaxDesc.Size = New System.Drawing.Size(92, 16)
        Me.lblFedTaxDesc.TabIndex = 6
        Me.lblFedTaxDesc.Text = "Federal Tax:"
        '
        'lblStateTaxDesc
        '
        Me.lblStateTaxDesc.AutoSize = True
        Me.lblStateTaxDesc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStateTaxDesc.Location = New System.Drawing.Point(409, 344)
        Me.lblStateTaxDesc.Name = "lblStateTaxDesc"
        Me.lblStateTaxDesc.Size = New System.Drawing.Size(74, 16)
        Me.lblStateTaxDesc.TabIndex = 7
        Me.lblStateTaxDesc.Text = "State Tax:"
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFica.Location = New System.Drawing.Point(154, 344)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(31, 16)
        Me.lblFica.TabIndex = 8
        Me.lblFica.Text = "123"
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFederal.Location = New System.Drawing.Point(324, 344)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(31, 16)
        Me.lblFederal.TabIndex = 9
        Me.lblFederal.Text = "456"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblState.Location = New System.Drawing.Point(486, 344)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(31, 16)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "789"
        '
        'lblNetPayDesc
        '
        Me.lblNetPayDesc.AutoSize = True
        Me.lblNetPayDesc.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetPayDesc.Location = New System.Drawing.Point(104, 392)
        Me.lblNetPayDesc.Name = "lblNetPayDesc"
        Me.lblNetPayDesc.Size = New System.Drawing.Size(207, 21)
        Me.lblNetPayDesc.TabIndex = 11
        Me.lblNetPayDesc.Text = "Net Paycheck Income:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNet.Location = New System.Drawing.Point(341, 392)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(95, 21)
        Me.lblNet.TabIndex = 12
        Me.lblNet.Text = "$12345.67"
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTaxCalc.Location = New System.Drawing.Point(99, 297)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(106, 35)
        Me.btnTaxCalc.TabIndex = 13
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(252, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 35)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(401, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtGross
        '
        Me.txtGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtGross.Location = New System.Drawing.Point(371, 255)
        Me.txtGross.MinimumSize = New System.Drawing.Size(0, 20)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(100, 26)
        Me.txtGross.TabIndex = 16
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblNetPayDesc)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.lblStateTaxDesc)
        Me.Controls.Add(Me.lblFedTaxDesc)
        Me.Controls.Add(Me.lblFICAdesc)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblHeader3)
        Me.Controls.Add(Me.lblHeader2)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblHeader2 As Label
    Friend WithEvents lblHeader3 As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblFICAdesc As Label
    Friend WithEvents lblFedTaxDesc As Label
    Friend WithEvents lblStateTaxDesc As Label
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNetPayDesc As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtGross As TextBox
End Class
