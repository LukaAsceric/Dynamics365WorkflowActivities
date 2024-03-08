using System;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using DataverseModel;
using System.Linq;
using System.Collections.Generic;

namespace Dynamics365WorkflowActivities
{
    public class SendEmailInternational : CodeActivity
    {
        // Input Parameters
        [Input("DE - Email Template")]
        [RequiredArgument]
        [ReferenceTarget("template")]
        public InArgument<EntityReference> EmailTemplate { get; set; }

        [Input("Nicht senden")]
        public InArgument<bool> DoNotSendEmail { get; set; }

        // Output Parameters
        [Output("Sent Email")]
        [ReferenceTarget("email")]
        public OutArgument<EntityReference> CreatedEmail { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                // Retrieve the execution context and service
                IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
                IOrganizationServiceFactory serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
                IOrganizationService service = serviceFactory.CreateOrganizationService(workflowContext.UserId);

                //Create the tracing service
                ITracingService tracingService = context.GetExtension<ITracingService>();

                Incident incident = (Incident)service.Retrieve(workflowContext.PrimaryEntityName,workflowContext.PrimaryEntityId, new ColumnSet(true));
                
                EntityReference emailTemplateRef = EmailTemplate.Get<EntityReference>(context);
                Template emailTemplate = (Template)service.Retrieve(emailTemplateRef.LogicalName, emailTemplateRef.Id, new ColumnSet(true));

                bool doNotSendEmail = DoNotSendEmail.Get(context);

                var sprache = incident.New_Int_SPrAcHe_Der_EInGangsMail;

                string templateNamePrefix = "INT - ";

                // Language to Prefix mapping
                var languagePrefixMap = new Dictionary<Incident_New_Int_SPrAcHe_Der_EInGangsMail, string>
                {
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.DNisch, "DK" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.Englisch, "EN" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.FranszSich, "FR" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.Italienisch, "IT" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.NiederlNdisch, "NL" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.Polnisch, "PL" },
                    { Incident_New_Int_SPrAcHe_Der_EInGangsMail.Spanisch, "ES" },
                };

                if (languagePrefixMap.TryGetValue(sprache.Value, out string prefix))
                {
                    templateNamePrefix += prefix;
                }

                string templateName = sprache == Incident_New_Int_SPrAcHe_Der_EInGangsMail.Deutsch ?
                    emailTemplate.Title :
                    $"{templateNamePrefix}{emailTemplate.Title.Substring(3)}";

                //Create a query expression to get one of Email Template of type "contact"
                QueryExpression queryBuildInTemplates = new QueryExpression
                {
                    EntityName = "template",
                    ColumnSet = new ColumnSet("templateid"),
                    Criteria = new FilterExpression()
                };

                queryBuildInTemplates.Criteria.AddCondition("templatetypecode", ConditionOperator.Equal, "incident");
                queryBuildInTemplates.Criteria.AddCondition("title", ConditionOperator.Equal, templateName);
                EntityCollection templateEntityCollection = service.RetrieveMultiple(queryBuildInTemplates);

                if (templateEntityCollection.Entities.Count == 0)
                {
                    throw new ArgumentException("Email-Vorlage nicht gefunden: " + templateName);
                }

                Guid templateId = (Guid)templateEntityCollection.Entities[0].Attributes["templateid"];

                // Define the International Team
                Guid[] internationalMitglieder = new [] {
                    new Guid("9e2f90b1-a674-ed11-81ab-0022489fd21f"), // Team Service Center Europa
                    new Guid("c869ab4f-a674-ed11-81ab-0022489fd21f")  // Zentrale Dienste und Services Europa
                };

                // Create the ActivityParties
                ActivityParty fromParty = new ActivityParty
                {
                    PartyId = new EntityReference("queue", 
                        new Guid(internationalMitglieder.Contains(incident.OwningBusinessUnit.Id) ?
                        "a22f90b1-a674-ed11-81ab-0022489fd21f" :
                        "c374a48d-b52d-ed11-9db1-0022489d6271"))
                };

                ActivityParty toParty = new ActivityParty
                {
                    PartyId = incident.ResponsibleContactId ?? incident.CustomerId
                };


                if (doNotSendEmail)
                {
                    InstantiateTemplateRequest instantiateTemplateRequest = new InstantiateTemplateRequest
                    {
                        ObjectId = workflowContext.PrimaryEntityId,
                        ObjectType = workflowContext.PrimaryEntityName,
                        TemplateId = templateId
                    };

                    InstantiateTemplateResponse instantiateTemplateResponse = (InstantiateTemplateResponse)service.Execute(instantiateTemplateRequest);
                    var attributes = instantiateTemplateResponse.EntityCollection.Entities.FirstOrDefault().Attributes;

                    // Retrieve the created email EntityReference
                    string subject = (string)attributes.FirstOrDefault(a => a.Key == "subject").Value;
                    string description = (string)attributes.FirstOrDefault(a => a.Key == "description").Value;

                    Email email = new Email
                    {
                        From = new[] { fromParty },
                        To = new[] { toParty },
                        RegardingObjectId = new EntityReference(workflowContext.PrimaryEntityName, workflowContext.PrimaryEntityId),
                        Subject = subject,
                        Description = description,
                        DirectionCode = true
                    };

                    Guid createdEmailId = service.Create(email);

                    // Retrieve the created email EntityReference
                    EntityReference createdEmailRef = new EntityReference("email", createdEmailId);


                    // Set the output parameter
                    CreatedEmail.Set(context, createdEmailRef);
                }
                else
                {
                    // Create the request
                    SendEmailFromTemplateRequest emailUsingTemplateReq = new SendEmailFromTemplateRequest
                    {
                        Target = new Email
                        {
                            From = new[] { fromParty },
                            To = new[] { toParty },
                            Subject = "",
                            Description = "",
                            DirectionCode = true
                        },
                        TemplateId = templateId,
                        RegardingId = workflowContext.PrimaryEntityId,
                        RegardingType = workflowContext.PrimaryEntityName
                    };

                    SendEmailFromTemplateResponse emailUsingTemplateResp = (SendEmailFromTemplateResponse)service.Execute(emailUsingTemplateReq);
                
                    // Set the output parameter
                    CreatedEmail.Set(context, new EntityReference("email", emailUsingTemplateResp.Id ));
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (logging, rethrow, etc.)
                throw new InvalidPluginExecutionException($"An error occurred: {ex.Message}", ex);
            }
        }
    }
}
