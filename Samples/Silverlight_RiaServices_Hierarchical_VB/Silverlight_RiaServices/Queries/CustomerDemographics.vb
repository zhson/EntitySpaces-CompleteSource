'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/23/2012 6:16:25 PM
'===============================================================================

Imports System
Imports System.Runtime.Serialization

Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	<DataContract(Name:="CustomerDemographicsQuery", Namespace:= "http://www.entityspaces.net")> _
	Partial Public Class CustomerDemographicsQueryProxyStub 
		Inherits esDynamicQuerySerializable
	
		Public Sub New()
		
		End Sub
	
        Public Sub New(ByVal joinAlias As String)
            MyBase.es.JoinAlias = joinAlias
        End Sub	
		
        Protected Overrides Function GetQueryName() As String
			Return "CustomerDemographicsQuery"
		End Function

		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal query As CustomerDemographicsQueryProxyStub) As String
			Return esDynamicQuerySerializable.SerializeHelper.ToXml(query)
		End Operator

		#End Region		
        

		Public ReadOnly Property CustomerTypeID As esQueryItem
			Get
				Return new esQueryItem(Me, "CustomerTypeID", esSystemType.String)
			End Get			
		End Property 
		
		Public ReadOnly Property CustomerDesc As esQueryItem
			Get
				Return new esQueryItem(Me, "CustomerDesc", esSystemType.String)
			End Get			
		End Property 
				
	
	End Class
	
End Namespace