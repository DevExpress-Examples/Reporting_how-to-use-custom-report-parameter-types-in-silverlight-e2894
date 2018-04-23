Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing

Namespace E2894.Web
	Public Class [Global]
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			ServiceKnownTypeProvider.Register(Of GangOfFour)()
		End Sub
	End Class
End Namespace
