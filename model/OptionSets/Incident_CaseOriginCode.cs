#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseModel
{
	
	
	/// <summary>
	/// Informationen, durch die die Quelle der Anfrageinformationen angegeben wird, z. B. Internet, Telefon oder E-Mail.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Incident_CaseOriginCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("E-Mail", 4, "#00B294")]
		Email = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Facebook", 0, "#0086FF")]
		Facebook = 2483,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Fax", 7, "#0000ff")]
		Fax = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Intern", 8, "#ff70ee")]
		Intern = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("IoT", 2, "#0000ff")]
		Iot = 700610000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Telefon", 3, "#FCD116")]
		Phone = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Toolineo", 6, "#0086FF")]
		Toolineo = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Twitter", 1, "#0086FF")]
		Twitter = 3986,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Extranet", 5, "#FF8C00")]
		Web = 3,
	}
}
#pragma warning restore CS1591
