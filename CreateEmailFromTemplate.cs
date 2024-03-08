using System;
using System.Linq;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Crm.Sdk.Messages;

namespace Dynamics365WorkflowActivities
{
    public class CreateEmailFromTemplate : CodeActivity
    {
        // Input Parameters
        [Input("Email Template")]
        [RequiredArgument]
        [ReferenceTarget("template")]
        public InArgument<EntityReference> EmailTemplate { get; set; }

        [Input("Regarding Record (incident)")]
        [ReferenceTarget("incident")]
        public InArgument<EntityReference> RegardingRecordIncident { get; set; }

        [Input("Regarding Record (quote)")]
        [ReferenceTarget("quote")]
        public InArgument<EntityReference> RegardingRecordQuote { get; set; }

        [Input("Regarding Record (systemuser)")]
        [ReferenceTarget("systemuser")]
        public InArgument<EntityReference> RegardingRecordUser { get; set; }

        [Input("Regarding Record (salesorder)")]
        [ReferenceTarget("salesorder")]
        public InArgument<EntityReference> RegardingRecordOrder { get; set; }

        [Input("Regarding Record (account)")]
        [ReferenceTarget("account")]
        public InArgument<EntityReference> RegardingRecordAccount { get; set; }

        [Input("Regarding Record (campaignresponse)")]
        [ReferenceTarget("campaignresponse")]
        public InArgument<EntityReference> RegardingRecordCampaignResponse { get; set; }

        [Input("Regarding Record (contact)")]
        [ReferenceTarget("contact")]
        public InArgument<EntityReference> RegardingRecordContact { get; set; }

        [Input("Regarding Record (lead)")]
        [ReferenceTarget("lead")]
        public InArgument<EntityReference> RegardingRecordLead { get; set; }

        [Input("Regarding Record (invoice)")]
        [ReferenceTarget("invoice")]
        public InArgument<EntityReference> RegardingRecordInvoice { get; set; }

        [Input("Regarding Record (serviceappointment)")]
        [ReferenceTarget("serviceappointment")]
        public InArgument<EntityReference> RegardingRecordServiceActivity { get; set; }

        [Input("Regarding Record (opportunity)")]
        [ReferenceTarget("opportunity")]
        public InArgument<EntityReference> RegardingRecordOpportunity { get; set; }

        [Input("Regarding Record (contract)")]
        [ReferenceTarget("contract")]
        public InArgument<EntityReference> RegardingRecordContract { get; set; }

        // Output Parameters
        [Output("Created Email")]
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

                EntityReference emailTemplate = EmailTemplate.Get<EntityReference>(context);

                EntityReference[] regardinRecords = {
                    RegardingRecordIncident.Get<EntityReference>(context),
                    RegardingRecordQuote.Get<EntityReference>(context),
                    RegardingRecordUser.Get<EntityReference>(context),
                    RegardingRecordOrder.Get<EntityReference>(context),
                    RegardingRecordAccount.Get<EntityReference>(context),
                    RegardingRecordCampaignResponse.Get<EntityReference>(context),
                    RegardingRecordContact.Get<EntityReference>(context),
                    RegardingRecordLead.Get<EntityReference>(context),
                    RegardingRecordInvoice.Get<EntityReference>(context),
                    RegardingRecordServiceActivity.Get<EntityReference>(context),
                    RegardingRecordOpportunity.Get<EntityReference>(context),
                    RegardingRecordContract.Get<EntityReference>(context)
                };

                EntityReference regardingRecord = null; 

                foreach (var record in regardinRecords)
                {
                    if (record != null)
                    {
                        regardingRecord = record;
                    }
                }

                // Validate that the Regarding Record is one of the allowed types
                if (regardingRecord == null)
                {
                    throw new InvalidPluginExecutionException("No Regarding Record provided.");
                }


                InstantiateTemplateRequest instantiateTemplateRequest = new InstantiateTemplateRequest
                {
                    ObjectId = regardingRecord.Id,
                    ObjectType = regardingRecord.LogicalName,
                    TemplateId = emailTemplate.Id
                };

                InstantiateTemplateResponse instantiateTemplateResponse = (InstantiateTemplateResponse)service.Execute(instantiateTemplateRequest);
                var attributes = instantiateTemplateResponse.EntityCollection.Entities.FirstOrDefault().Attributes;

                // Retrieve the created email EntityReference
                string subject = (string)attributes.FirstOrDefault(a => a.Key == "subject").Value;
                string description = (string)attributes.FirstOrDefault(a => a.Key == "description").Value;

                Entity emailEntity = new Entity("email");
                emailEntity["regardingobjectid"] = new EntityReference(regardingRecord.LogicalName, regardingRecord.Id);
                emailEntity["subject"] = subject;
                emailEntity["description"] = description;

                Guid createdEmailId = service.Create(emailEntity);

                // Retrieve the created email EntityReference
                EntityReference createdEmailRef = new EntityReference("email", createdEmailId);


                // Set the output parameter
                CreatedEmail.Set(context, createdEmailRef);
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (logging, rethrow, etc.)
                throw new InvalidPluginExecutionException($"An error occurred: {ex.Message}", ex);
            }
        }
    }
}
