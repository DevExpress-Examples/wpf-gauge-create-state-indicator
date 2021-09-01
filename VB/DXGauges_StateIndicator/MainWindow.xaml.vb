Imports System.Windows
Imports System.Windows.Input

Namespace DXGauges_StateIndicator

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub stateIndicatorControl1_MouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
			stateIndicatorControl1.StateIndex = 0
		End Sub

		Private Sub stateIndicatorControl1_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			stateIndicatorControl1.StateIndex = 2
		End Sub

	End Class
End Namespace
