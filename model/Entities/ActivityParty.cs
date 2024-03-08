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
	/// Instanzentyp einer Serie.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ActivityParty_InstanceTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Nicht wiederkehrend", 0)]
		NotRecurring = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wiederkehrende Ausnahme", 3)]
		RecurringException = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wiederkehrende künftige Ausnahme", 4)]
		RecurringFutureException = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wiederkehrende Instanz", 2)]
		RecurringInstance = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Serienmaster", 1)]
		RecurringMaster = 1,
	}
	
	/// <summary>
	/// Rolle der Person in der Aktivität, z. B. Absender, An, Cc, Bcc, erforderlich, optional, Planung, Bezug oder Besitzer.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ActivityParty_ParticipationTypeMask
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Empfänger (Bcc:)", 3)]
		BccRecipient = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Empfänger (Cc:)", 2)]
		CcRecipient = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Chatteilnehmer", 11)]
		ChatParticipant = 12,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Kunde", 10)]
		Customer = 11,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Optionaler Teilnehmer", 5)]
		OptionalAttendee = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Planung", 6)]
		Organizer = 7,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Besitzer", 8)]
		Owner = 9,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Bezug", 7)]
		Regarding = 8,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Verknüpft", 12)]
		Related = 13,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Erforderlicher Teilnehmer", 4)]
		RequiredAttendee = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ressource", 9)]
		Resource = 10,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Absender", 0)]
		Sender = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Empfänger (An:)", 1)]
		ToRecipient = 2,
	}
	
	/// <summary>
	/// Person oder Gruppe, die einer Aktivität zugeordnet ist. Eine Aktivität kann mehrere Aktivitätsparteien haben.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
	public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the activityparty entity
		/// </summary>
		public partial class Fields
		{
			public const string ActivityId = "activityid";
			public const string ActivityPartyId = "activitypartyid";
			public const string Id = "activitypartyid";
			public const string ActivityPointer_Activity_Parties = "activitypointer_activity_parties";
			public const string AddressUsed = "addressused";
			public const string AddressUsedEmailColumnNumber = "addressusedemailcolumnnumber";
			public const string Contact_Activity_Parties = "contact_activity_parties";
			public const string DoNotEmail = "donotemail";
			public const string DoNotEmailName = "donotemailname";
			public const string DoNotFax = "donotfax";
			public const string DoNotFaxName = "donotfaxname";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPhoneName = "donotphonename";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string DoNotPostalMailName = "donotpostalmailname";
			public const string Effort = "effort";
			public const string Email_Activity_Parties = "email_activity_parties";
			public const string ExchangeEntryId = "exchangeentryid";
			public const string Incident_Activity_Parties = "incident_activity_parties";
			public const string InstanceTypeCode = "instancetypecode";
			public const string InstanceTypeCodename = "instancetypecodename";
			public const string IsPartyDeleted = "ispartydeleted";
			public const string IsPartyDeletedName = "ispartydeletedname";
			public const string OwnerId = "ownerid";
			public const string ParticipationTypeMask = "participationtypemask";
			public const string ParticipationTypeMaskName = "participationtypemaskname";
			public const string PartyId = "partyid";
			public const string PartyIdName = "partyidname";
			public const string ResourceSpecId = "resourcespecid";
			public const string ResourceSpecIdName = "resourcespecidname";
			public const string ScheduledEnd = "scheduledend";
			public const string ScheduledStart = "scheduledstart";
			public const string System_User_Activity_Parties = "system_user_activity_parties";
			public const string UnresolvedPartyName = "unresolvedpartyname";
			public const string VersionNumber = "versionnumber";
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "activitypartyid";
		
		public const string PrimaryNameAttribute = "partyidname";
		
		public const string EntitySchemaName = "ActivityParty";
		
		public const string EntityLogicalName = "activityparty";
		
		public const string EntityLogicalCollectionName = "activityparties";
		
		public const string EntitySetName = "activityparties";
		
		/// <summary>
		/// Eindeutiger Bezeichner der Aktivität, die der Aktivitätspartei zugeordnet sind (eine 'Partei' ist eine beliebige Person, die einer Aktivität zugeordnet ist).
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("activityid", value);
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der Aktivitätspartei.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public System.Nullable<System.Guid> ActivityPartyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("activitypartyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ActivityPartyId = value;
			}
		}
		
		/// <summary>
		/// E-Mail-Adresse, an die eine E-Mail gesendet wird und die der Zielentität zugeordnet ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
		public string AddressUsed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("addressused");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("addressused", value);
			}
		}
		
		/// <summary>
		/// Nummer der E-Mail-Adressspalte der zugeordneten Partei.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
		public System.Nullable<int> AddressUsedEmailColumnNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
			}
		}
		
		/// <summary>
		/// Informationen darüber, ob das Senden von E-Mails an die Aktivitätspartei zugelassen werden soll.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEmail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemailname")]
		public string DoNotEmailName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("donotemail"))
				{
					return this.FormattedValues["donotemail"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Informationen darüber, ob das Senden von Faxen an die Aktivitätspartei zugelassen werden soll.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfaxname")]
		public string DoNotFaxName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("donotfax"))
				{
					return this.FormattedValues["donotfax"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Informationen darüber, ob Telefonanrufe an den Lead zugelassen werden sollen.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphonename")]
		public string DoNotPhoneName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("donotphone"))
				{
					return this.FormattedValues["donotphone"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Informationen darüber, ob das Senden von Post an den Lead zugelassen werden soll.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmailname")]
		public string DoNotPostalMailName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("donotpostalmail"))
				{
					return this.FormattedValues["donotpostalmail"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Aufwand einer Ressource bei einer Serviceterminaktivität.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("effort", value);
			}
		}
		
		/// <summary>
		/// Nur zur internen Verwendung.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("exchangeentryid", value);
			}
		}
		
		/// <summary>
		/// Instanzentyp einer Serie.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public virtual ActivityParty_InstanceTypeCode? InstanceTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ActivityParty_InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecodename")]
		public string InstanceTypeCodename
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("instancetypecode"))
				{
					return this.FormattedValues["instancetypecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Informationen darüber, ob der zugrundeliegende Entitätsdatensatz gelöscht ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
		public System.Nullable<bool> IsPartyDeleted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeletedname")]
		public string IsPartyDeletedName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("ispartydeleted"))
				{
					return this.FormattedValues["ispartydeleted"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner des Benutzers oder Teams, der bzw. das im Besitz der Aktivitätspartei ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Rolle der Person in der Aktivität, z. B. Absender, An, Cc, Bcc, erforderlich, optional, Planung, Bezug oder Besitzer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public virtual ActivityParty_ParticipationTypeMask? ParticipationTypeMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ActivityParty_ParticipationTypeMask?)(EntityOptionSetEnum.GetEnum(this, "participationtypemask")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("participationtypemask", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemaskname")]
		public string ParticipationTypeMaskName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("participationtypemask"))
				{
					return this.FormattedValues["participationtypemask"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der Partei, die der Aktivität zugeordnet ist.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		public Microsoft.Xrm.Sdk.EntityReference PartyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("partyid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyidname")]
		public string PartyIdName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("partyid"))
				{
					return this.FormattedValues["partyid"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("partyidname", value);
			}
		}
		
		/// <summary>
		/// Eindeutiger Bezeichner der Ressourcenspezifikation für die Aktivitätspartei.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("resourcespecid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecidname")]
		public string ResourceSpecIdName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("resourcespecid"))
				{
					return this.FormattedValues["resourcespecid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Geplante Endzeit der Aktivität.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
		}
		
		/// <summary>
		/// Geplante Startzeit der Aktivität.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
		}
		
		/// <summary>
		/// Der Name der zu verwendenden Partei, wenn die Partei nicht zu einer Entität aufgelöst wird
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("unresolvedpartyname")]
		public string UnresolvedPartyName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("unresolvedpartyname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("unresolvedpartyname", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 activitypointer_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
		public DataverseModel.ActivityPointer ActivityPointer_Activity_Parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DataverseModel.ActivityPointer>("activitypointer_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<DataverseModel.ActivityPointer>("activitypointer_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public DataverseModel.Contact Contact_Activity_Parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DataverseModel.Contact>("contact_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<DataverseModel.Contact>("contact_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 email_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
		public DataverseModel.Email Email_Activity_Parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DataverseModel.Email>("email_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<DataverseModel.Email>("email_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 incident_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
		public DataverseModel.Incident Incident_Activity_Parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DataverseModel.Incident>("incident_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<DataverseModel.Incident>("incident_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 system_user_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
		public DataverseModel.SystemUser System_User_Activity_Parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DataverseModel.SystemUser>("system_user_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<DataverseModel.SystemUser>("system_user_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["activitypartyid"] = base.Id;
                        break;
                    case "activitypartyid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}
#pragma warning restore CS1591