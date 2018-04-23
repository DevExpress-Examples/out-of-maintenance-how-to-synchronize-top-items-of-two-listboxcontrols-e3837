Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.listBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
			Me.myListBoxScrollHelper1 = New WindowsApplication1.MyListBoxScrollHelper()
			Me.myListBoxScrollHelper2 = New WindowsApplication1.MyListBoxScrollHelper()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.listBoxControl1.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"})
			Me.listBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(120, 361)
			Me.listBoxControl1.TabIndex = 0
			' 
			' listBoxControl2
			' 
			Me.listBoxControl2.Dock = System.Windows.Forms.DockStyle.Left
			Me.listBoxControl2.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"})
			Me.listBoxControl2.Location = New System.Drawing.Point(120, 0)
			Me.listBoxControl2.Name = "listBoxControl2"
			Me.listBoxControl2.Size = New System.Drawing.Size(120, 361)
			Me.listBoxControl2.TabIndex = 1
			' 
			' myListBoxScrollHelper1
			' 
			Me.myListBoxScrollHelper1.ListBox = Me.listBoxControl1
'			Me.myListBoxScrollHelper1.VScroll += New System.Windows.Forms.ScrollEventHandler(Me.OnScroll);
			' 
			' myListBoxScrollHelper2
			' 
			Me.myListBoxScrollHelper2.ListBox = Me.listBoxControl2
'			Me.myListBoxScrollHelper2.VScroll += New System.Windows.Forms.ScrollEventHandler(Me.OnScroll);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(541, 361)
			Me.Controls.Add(Me.listBoxControl2)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private listBoxControl2 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents myListBoxScrollHelper1 As MyListBoxScrollHelper
		Private WithEvents myListBoxScrollHelper2 As MyListBoxScrollHelper

	End Class
End Namespace

