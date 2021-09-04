<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInt1 = New System.Windows.Forms.TextBox()
        Me.txtint2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simple Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Number"
        '
        'txtInt1
        '
        Me.txtInt1.Location = New System.Drawing.Point(136, 75)
        Me.txtInt1.Name = "txtInt1"
        Me.txtInt1.Size = New System.Drawing.Size(100, 20)
        Me.txtInt1.TabIndex = 2
        '
        'txtint2
        '
        Me.txtint2.Location = New System.Drawing.Point(136, 135)
        Me.txtint2.Name = "txtint2"
        Me.txtint2.Size = New System.Drawing.Size(100, 20)
        Me.txtint2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Result"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(136, 188)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Operators"
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(309, 125)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(52, 23)
        Me.add.TabIndex = 8
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'subtract
        '
        Me.subtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtract.Location = New System.Drawing.Point(380, 125)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(55, 23)
        Me.subtract.TabIndex = 9
        Me.subtract.Text = "-"
        Me.subtract.UseVisualStyleBackColor = True
        '
        'multiply
        '
        Me.multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiply.Location = New System.Drawing.Point(309, 186)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(52, 23)
        Me.multiply.TabIndex = 10
        Me.multiply.Text = "*"
        Me.multiply.UseVisualStyleBackColor = True
        '
        'divide
        '
        Me.divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divide.Location = New System.Drawing.Point(380, 185)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(55, 23)
        Me.divide.TabIndex = 11
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(330, 234)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 29)
        Me.clear.TabIndex = 12
        Me.clear.Text = "Reset"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 341)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtint2)
        Me.Controls.Add(Me.txtInt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtint2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents subtract As System.Windows.Forms.Button
    Friend WithEvents multiply As System.Windows.Forms.Button
    Friend WithEvents divide As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button

End Class
