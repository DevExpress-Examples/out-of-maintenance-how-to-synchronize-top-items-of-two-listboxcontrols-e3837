Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Reflection

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Overloads Sub OnScroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles myListBoxScrollHelper1.VScroll, myListBoxScrollHelper2.VScroll
			Dim topIndex As Integer = (TryCast(sender, ListBoxControl)).TopIndex
			listBoxControl1.TopIndex = topIndex
			listBoxControl2.TopIndex = topIndex
		End Sub


	End Class
End Namespace