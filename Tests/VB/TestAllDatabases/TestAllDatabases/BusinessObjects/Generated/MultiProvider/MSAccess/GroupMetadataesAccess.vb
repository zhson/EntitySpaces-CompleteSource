'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : Access
' Date Generated       : 3/17/2012 4:51:58 AM
'===============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Imports EntitySpaces.Interfaces
Imports EntitySpaces.Core

Namespace BusinessObjects

	Partial Public Class GroupMetadata 
		Inherits esMetadata
		Implements IMetadata
		
        Private Shared Function RegisterDelegateesAccess() As Integer
		
            ' This is only executed once per the life of the application
            SyncLock GetType(GroupMetadata)
			
				If GroupMetadata.mapDelegates Is Nothing Then
					GroupMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If GroupMetadata._meta Is Nothing Then
                    GroupMetadata._meta = New GroupMetadata()
                End If

                Dim mapMethod As New MapToMeta(AddressOf _meta.esAccess)
                mapDelegates.Add("esAccess", mapMethod)
                mapMethod("esAccess")
                Return 0

            End SyncLock			
		
        End Function

        Private Function esAccess(ByVal mapName As String) As esProviderSpecificMetadata

            If (Not m_providerMetadataMaps.ContainsKey(mapName)) Then		

				Dim meta As esProviderSpecificMetadata = new esProviderSpecificMetadata()
			

				meta.AddTypeMap("Id", new esTypeMap("Text", "System.String"))
				meta.AddTypeMap("Notes", new esTypeMap("Memo", "System.String"))				
				meta.Catalog = "ForeignKeyTest.mdb"
				
				
				meta.Source = "Group"
				meta.Destination = "Group"
				
				meta.spInsert = "proc_GroupInsert"
				meta.spUpdate = "proc_GroupUpdate"
				meta.spDelete = "proc_GroupDelete"
				meta.spLoadAll = "proc_GroupLoadAll"
				meta.spLoadByPrimaryKey = "proc_GroupLoadByPrimaryKey"
				
                m_providerMetadataMaps.Add("esAccess", meta)

            End If

            Return m_providerMetadataMaps("esAccess")

        End Function
		
		Private Shared _esAccess As Integer = RegisterDelegateesAccess()	
		
	End Class
	
End Namespace	
