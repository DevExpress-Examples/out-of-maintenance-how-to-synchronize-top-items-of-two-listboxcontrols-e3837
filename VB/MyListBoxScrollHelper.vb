Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Reflection

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyListBoxScrollHelper
		Inherits Component

		Public Event HScroll As ScrollEventHandler
		Public Event VScroll As ScrollEventHandler

		#Region "OnOnHScroll"
		''' <summary>
		''' Triggers the OnHScroll event.
		''' </summary>
		Public Overridable Sub OnHScroll(ByVal sender As Object, ByVal ea As ScrollEventArgs)
			RaiseEvent HScroll(sender, ea)
		End Sub
		#End Region
		#Region "OnOnVScroll"
		''' <summary>
		''' Triggers the OnVScroll event.
		''' </summary>
		Public Overridable Sub OnVScroll(ByVal sender As Object, ByVal ea As ScrollEventArgs)
			RaiseEvent VScroll(sender, ea)
		End Sub
		#End Region


		Public Sub New()

		End Sub

		' Fields...
		Private _ListBox As ListBoxControl

		Public Property ListBox() As ListBoxControl
			Get
				Return _ListBox
			End Get
			Set(ByVal value As ListBoxControl)
				Dim prevValue As ListBoxControl = _ListBox
				_ListBox = value
				OnListBoxChanged(prevValue, value)
			End Set
		End Property
		Private Sub OnListBoxChanged(ByVal prevValue As ListBoxControl, ByVal newValue As ListBoxControl)
			If prevValue IsNot Nothing Then
				UnSubscribeEvents(prevValue)
			End If
			If newValue IsNot Nothing Then
				SubscribeEvents(newValue)
			End If
		End Sub


		Private Sub UnSubscribeEvents(ByVal prevValue As ListBoxControl)
			Dim si As ListBoxScrollInfo = GetScrollInfo(prevValue)
			If si IsNot Nothing Then
				AddHandler si.VScroll_Scroll, AddressOf MyListBoxScrollHelper_VScroll_Scroll
				RemoveHandler si.HScroll_Scroll, AddressOf MyListBoxScrollHelper_HScroll_Scroll
			End If
		End Sub
		Private Shared Function GetScrollInfo(ByVal newValue As ListBoxControl) As ListBoxScrollInfo
			Dim pi As PropertyInfo = newValue.GetType().GetProperty("ScrollInfo", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
			Return TryCast(pi.GetValue(newValue, Nothing), ListBoxScrollInfo)
		End Function
		Private Sub SubscribeEvents(ByVal newValue As ListBoxControl)
			Dim si As ListBoxScrollInfo = GetScrollInfo(newValue)
			If si IsNot Nothing Then
				AddHandler si.VScroll_Scroll, AddressOf MyListBoxScrollHelper_VScroll_Scroll
				AddHandler si.HScroll_Scroll, AddressOf MyListBoxScrollHelper_HScroll_Scroll
			End If
		End Sub

		Private Sub MyListBoxScrollHelper_HScroll_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
			OnHScroll(ListBox, e)
		End Sub

		Private Sub MyListBoxScrollHelper_VScroll_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
			OnVScroll(ListBox, e)
		End Sub


	End Class
End Namespace
