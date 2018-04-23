Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E2894.Web
	Partial Public Class SampleReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()

			customParameter.Type = GetType(GangOfFour)
			customParameter.Value = GangOfFour.None
		End Sub
	End Class
End Namespace
